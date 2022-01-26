using Linphone;
using LinphoneXamarin.Entities;
using LinphoneXamarin.Services;
using LinphoneXamarin.Util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Windows.ApplicationModel.AppService;
using Windows.ApplicationModel.Core;
using Windows.ApplicationModel.ExtendedExecution.Foreground;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Audio;
using Windows.Media.Devices;
using Windows.Storage;
using Windows.System;
using Windows.UI;
using Windows.UI.Core;
using Windows.UI.Core.Preview;
using Windows.UI.Popups;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;
using Xamarin.Essentials;
using Xamarin.Forms.Platform.UWP;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : UIVideoListener
    {

        int videoLayoutId;
        bool isVideoScreen;
        CoreApplicationView videoView;
        ExtendedExecutionForegroundSession _session;
        public MainPage()
        {

            addLog("MainPage()");
            this.InitializeComponent();
            this.Loaded += OnMainPageLoaded;

            //Application.Current.Suspending += new SuspendingEventHandler(App_Suspending);
            LoadApplication(new LinphoneXamarin.App());
            SharedData.Instance.launchAction = LaunchAction.DEFAULT;
            var timeHelper = TimeHelper.Instance;
            timeHelper.timeFormat = CultureInfo.CurrentCulture.DateTimeFormat.ShortTimePattern;
            timeHelper.dateFormat = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            CallService.Instance.UWPVideoListener = this;
            videoLayoutId = 0;
            addVideoView();
            Window.Current.Activated += Current_Activated;
            SystemNavigationManagerPreview.GetForCurrentView().CloseRequested += App_CloseRequested;
            MediaDevice.DefaultAudioRenderDeviceChanged += MediaDevice_DefaultAudioRenderDeviceChanged;
            var linphoneCore = LinphoneBase.Instance.linphoneCore;
            linphoneCore.RootCa = "Assets/rootca.pem";
            linphoneCore.Ringback = "Assets/ringback.wav";
            linphoneCore.CreateConfig("Assets/linphonerc_default");
            var appSettings = MyFileSystem.Instance.loadSettings();
            if (appSettings != null && !appSettings.isTermOfUse)
                uleaDialogAsync();

            setFullTrustAppContract();
        }


        void OnMainPageLoaded(object sender, RoutedEventArgs e)
        {

            addLog("OnMainPageLoaded()");
            var desiredSize = new Size(400, 650);
            var minSize = new Size(360, 350);
            ApplicationView.PreferredLaunchViewSize = desiredSize;
            ApplicationView.GetForCurrentView().SetPreferredMinSize(minSize);
            ApplicationView.GetForCurrentView().TryResizeView(desiredSize);
        }

        private async void MediaDevice_DefaultAudioRenderDeviceChanged(object sender, DefaultAudioRenderDeviceChangedEventArgs args)
        {

            addLog($"MediaDevice_DefaultAudioRenderDeviceChanged()");
            try
            {
                var lb = LinphoneBase.Instance;
                lb.linphoneCore.ReloadSoundDevices();

                //if (lb.linphoneCore.CallsNb == 0)
                //{
                //    var settings = MyFileSystem.Instance.loadSettings();
                //    if (settings != null)
                //    {
                //        addLog("reset audio devices to default, since OS audio devices have changed!");
                //        var DefaultAsString = "Default";
                //        settings.inAcallDevice = DefaultAsString;
                //        settings.ringDevice = DefaultAsString;
                //        settings.micDevice = DefaultAsString;
                //        MyFileSystem.Instance.saveSettings(settings);

                //        lb.linphoneCore.ReloadSoundDevices();
                //        lb.linphoneCore.PlaybackDevice = DefaultAsString;
                //        lb.linphoneCore.RingerDevice = DefaultAsString;
                //        lb.linphoneCore.CaptureDevice = DefaultAsString;
                //    }
                //}
            }
            catch (Exception e)
            {
                addLog(e.ToString());
            }
        }

        private async void App_CloseRequested(object sender, SystemNavigationCloseRequestedPreviewEventArgs e)
        {
            addLog("App_CloseRequested()");

            var deferral = e.GetDeferral();
            var dialog = new MessageDialog("Are you sure you want to exit?", "Exit");
            var confirmCommand = new UICommand("Yes");
            var cancelCommand = new UICommand("No");
            dialog.Commands.Add(confirmCommand);
            dialog.Commands.Add(cancelCommand);

            if (await dialog.ShowAsync() == cancelCommand)
            {
                //cancel close by handling the event
                e.Handled = true;
            }
            deferral.Complete();
        }

        private void Current_Activated(object sender, Windows.UI.Core.WindowActivatedEventArgs e)
        {
            var sd = SharedData.Instance;
            switch (e.WindowActivationState)
            {
                case CoreWindowActivationState.CodeActivated:
                case CoreWindowActivationState.PointerActivated:
                    addLog("forground true");
                    sd.isUWPForground = true;
                    // sd.toggleMinimize(false);
                    break;

                case CoreWindowActivationState.Deactivated:
                    addLog("forground false");
                    sd.isUWPForground = false;
                    // sd.toggleMinimize(true);
                    break;
            }
        }

        public async Task setFullTrustAppContract()
        {
            if (ApiInformation.IsApiContractPresent("Windows.ApplicationModel.FullTrustAppContract", 1, 0))
            {
                Process process = Process.GetCurrentProcess();
                process.PriorityBoostEnabled = true;
                process.PriorityClass = ProcessPriorityClass.High;
                ApplicationData.Current.LocalSettings.Values["processID"] = process.Id;
                App.AppServiceConnected += AppServiceConnected;
                await PreventFromSuspending();
                await FullTrustProcessLauncher.LaunchFullTrustProcessForCurrentAppAsync();
                addLog("processID: " + process.Id);
            }
        }

        private async Task uleaDialogAsync()
        {
            UleaDialog u = new UleaDialog();
            var result = await u.ShowAsync();
            ApplicationView.GetForCurrentView().TryResizeView(new Size(360, 600));
        }

        public async Task PreventFromSuspending()
        {
            addLog("PreventFromSuspending()");
            ExtendedExecutionForegroundSession newSession = new ExtendedExecutionForegroundSession();
            newSession.Reason = ExtendedExecutionForegroundReason.Unconstrained;
            newSession.Revoked += SessionRevoked;

            ExtendedExecutionForegroundResult result = await newSession.RequestExtensionAsync();
            addLog("PreventFromSuspending() result: " + result);
            switch (result)
            {
                case ExtendedExecutionForegroundResult.Allowed:
                    AlertHelper.Instance.updateSuspandedBadge(false);
                    _session = newSession;
                    break;
                default:
                case ExtendedExecutionForegroundResult.Denied:
                    newSession.Dispose();
                    break;
            }
        }

        private void SessionRevoked(object sender, ExtendedExecutionForegroundRevokedEventArgs args)
        {
            addLog("SessionRevoked(), reason: " + args.Reason);
            if (_session != null)
            {
                _session.Dispose();
                _session = null;
            }
        }

        private void AppServiceConnected(object sender, Windows.ApplicationModel.AppService.AppServiceTriggerDetails e)
        {
            addLog("AppServiceConnected()");
            e.AppServiceConnection.RequestReceived += AppServiceConnection_RequestReceived;
        }

        private string FetchDigitsOnlyFromPhoneNumber(string formattedNumber)
        {
            string actualNumber;
            actualNumber = formattedNumber;
            var addPrefix = actualNumber.StartsWith("+");

            actualNumber = actualNumber.Replace("(", string.Empty);
            actualNumber = actualNumber.Replace(")", string.Empty);
            actualNumber = actualNumber.Replace("-", string.Empty);
            actualNumber = actualNumber.Replace(" ", string.Empty); //Blank
            actualNumber = actualNumber.Replace(".", string.Empty);
            actualNumber = actualNumber.Replace("+", string.Empty);
            return addPrefix ? "+" + actualNumber : actualNumber;
        }

        private async void AppServiceConnection_RequestReceived(AppServiceConnection sender, AppServiceRequestReceivedEventArgs args)
        {
            try
            {
                var result = "OK";
                AppServiceDeferral messageDeferral = args.GetDeferral();
                int id = (int)args.Request.Message["ID"];
                addLog($"AppServiceConnection_RequestReceived(), id is: {id}");
                switch (id)
                {
                    case 1001:
                        CallService.Instance.answerCall(false);
                        break;
                    case 1002:
                        CallService.Instance.terminateCall();
                        break;
                    case 1003:
                        await Dispatcher.RunAsync(CoreDispatcherPriority.Normal,
async () =>
{
    var clipBoardText = await Clipboard.GetTextAsync();
    if (clipBoardText != null && clipBoardText.Length > 0)
    {
        clipBoardText = FetchDigitsOnlyFromPhoneNumber(clipBoardText);
        addLog($"AppServiceConnection_RequestReceived(), clipBoardText is: {clipBoardText}");
        CallService.Instance.callAsync(clipBoardText, clipBoardText, false);
        Clipboard.SetTextAsync("");
    }
    else
    {
        AeonixInfoService.Instance.fireUiMessage("Nothing was selected, please highlight a phone number, and try again", "", 5, false);
    }
});
                        break;
                    case 1004:

                        var commamdArr = args.Request.Message["command"].ToString().Split(":");
                        addLog($"tapi command: {commamdArr[0]}");
                        if (LoginService.Instance.registrationProcess.CurrentState == MyRegistrationState.AfterAeonix)
                        {
                            var cs = CallService.Instance;
                            switch (commamdArr[0])
                            {
                                case "CALL":
                                    await Dispatcher.RunAsync(CoreDispatcherPriority.High,
async () =>
{
    cs.callAsync(commamdArr[1], commamdArr[1], false, commamdArr[1]);
});
                                    result = $"CALLREP:{commamdArr[2]}:OK";
                                    break;
                                case "CLOSE":
                                    await Dispatcher.RunAsync(CoreDispatcherPriority.High,
async () =>
{
    cs.terminateCall();
});
                                    result = $"CLOSEREP:{commamdArr[1]}:OK";
                                    break;
                                case "STATUS":
                                    await Dispatcher.RunAsync(CoreDispatcherPriority.High,
async () =>
{
    result = $"STATUSREP:{commamdArr[1]}:{cs.getStatus()}";
});
                                    //var status = cs.getStatus();
                                    //result = $"STATUSREP:{commamdArr[1]}:{status}";
                                    break;
                                case "HOLD":
                                    var s = cs.getStatus();
                                    if (s.Equals("CONNECTED"))
                                    {
                                        await Dispatcher.RunAsync(CoreDispatcherPriority.Normal,
async () =>
{
    cs.toggleHold();
});

                                        result = $"HOLDREP:{commamdArr[1]}:OK";
                                    }
                                    else if (s.Equals("HOLD"))
                                    {
                                        result = $"HOLDREP:{commamdArr[1]}:OK";
                                    }
                                    else
                                    {
                                        result = $"HOLDREP:{commamdArr[1]}:NO_CALL";
                                    }
                                    break;
                                case "RETRIVE":
                                    var s2 = cs.getStatus();
                                    if (s2.Equals("HOLD"))
                                    {
                                        await Dispatcher.RunAsync(CoreDispatcherPriority.Normal,
async () =>
{
    cs.toggleHold();
});

                                        result = $"RETRIVEREP:{commamdArr[1]}:OK";
                                    }
                                    else if (s2.Equals("CONNECTED"))
                                    {
                                        result = $"RETRIVEREP:{commamdArr[1]}:OK";
                                    }
                                    else
                                    {
                                        result = $"RETRIVEREP:{commamdArr[1]}:NO_CALL";
                                    }
                                    break;


                            }
                        }
                        else
                        {
                            switch (commamdArr[0])
                            {
                                case "CALL":
                                    result = $"CALLREP:{commamdArr[2]}:NO_AEONIX_CONNCT";
                                    break;
                                case "CLOSE":
                                    result = $"CLOSEREP:{commamdArr[1]}:NO_CALL";
                                    break;
                                case "STATUS":
                                    result = $"STATUSREP:{commamdArr[1]}:NO_CALL";
                                    break;
                                case "HOLD":
                                    result = $"HOLDREP:{commamdArr[1]}:NO_CALL";
                                    break;
                                case "RETRIVE":
                                    result = $"RETRIVEREP:{commamdArr[1]}:NO_CALL";
                                    break;
                            }
                        }
                        break;
                    default:
                        break;
                }
                ValueSet commandValueSet = new ValueSet();
                commandValueSet.Add("result", result);
                try
                {
                    await args.Request.SendResponseAsync(commandValueSet);
                }
                catch (Exception err)
                {
                    addLog(err.ToString());
                }
                finally
                {
                    messageDeferral.Complete();
                }

            }
            catch (Exception e)
            {
                addLog(e.ToString());
            }
            finally
            {
                // we no longer need the connection
                App.AppServiceDeferral?.Complete();
                App.Connection = null;
            }


        }



        public async Task onVideoStatusChangedAsync(bool isvideo)
        {
            addLog($"onVideoStatusChangedAsync(), should be video: {isvideo}, is video screen : {isVideoScreen}");
            if (isvideo)
            {
                if (!isVideoScreen)

                    isVideoScreen = await ApplicationViewSwitcher.TryShowAsStandaloneAsync(videoLayoutId);
                addLog($"onVideoStatusChangedAsync() isVideoScreen: {isVideoScreen}");
            }
            else
            {
                if (isVideoScreen)
                {
                    try
                    {
                        await videoView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                                            {
                                                videoView.CoreWindow.Close();
                                            });
                        isVideoScreen = false;
                        addLog($"onVideoStatusChangedAsync() isVideoScreen: {isVideoScreen}");
                        addVideoView();
                    }
                    catch (Exception e)
                    {
                        addLog("onVideoStatusChanged: " + e);
                    }
                }
            }
        }

        private async void addVideoView()
        {
            try
            {
                videoView = CoreApplication.CreateNewView();
                await videoView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                              {
                                  Grid r = new Grid();
                                  r.Margin = new Thickness(10);

                                  r.Background = new SolidColorBrush(Colors.Black);
                                  SwapChainPanel s = new SwapChainPanel();
                                  s.Name = "s";
                                  s.Width = 150;
                                  s.Height = 150;
                                  s.HorizontalAlignment = HorizontalAlignment.Right;
                                  s.VerticalAlignment = VerticalAlignment.Top;

                                  new MSWinRTVideo.SwapChainPanelSource().Start(s);

                                  LinphoneBase.Instance.linphoneCore.NativePreviewWindowId = s.Name;
                                  // You have to activate the window in order to show it later.
                                  Window.Current.Activate();

                                  SwapChainPanel s2 = new SwapChainPanel();
                                  s2.Name = "s2";
                                  s2.HorizontalAlignment = HorizontalAlignment.Stretch;
                                  new MSWinRTVideo.SwapChainPanelSource().Start(s2);

                                  LinphoneBase.Instance.linphoneCore.NativeVideoWindowId = s2.Name;

                                  r.Children.Add(s2);
                                  r.Children.Add(s);
                                  Window.Current.Content = r;

                                  videoLayoutId = ApplicationView.GetForCurrentView().Id;

                              });
            }
            catch (Exception e)
            {
                addLog(e.ToString());
            }

        }

        private void addLog(string message)
        {
            MyFileSystem.Instance.writeDebug(message, "MainAPPUWP");
        }

    }
}
