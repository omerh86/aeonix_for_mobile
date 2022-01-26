using ImageCircle.Forms.Plugin.UWP;
using LinphoneXamarin.components.userControllers;
using LinphoneXamarin.Entities;
using LinphoneXamarin.Services;
using LinphoneXamarin.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.ApplicationModel.AppService;
using Windows.ApplicationModel.Background;
using Windows.ApplicationModel.Core;
using Windows.ApplicationModel.ExtendedExecution.Foreground;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Capture;
using Windows.System;
using Windows.System.Display;
using Windows.System.Profile;
using Windows.UI.Core;
using Windows.UI.Core.Preview;
using Windows.UI.Notifications;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Xamarin.Forms.Platform.UWP;

namespace UWP
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    sealed partial class App : Application
    {
        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        /// 
        public bool _isInBackgroundMode;
        public static BackgroundTaskDeferral AppServiceDeferral = null;
        public static AppServiceConnection Connection = null;
        public static event EventHandler<AppServiceTriggerDetails> AppServiceConnected;

        public App()
        {
            this.InitializeComponent();
            this.Suspending += new SuspendingEventHandler(OnSuspendingAsync);
            this.EnteredBackground += AppEnteredBackground;
            this.LeavingBackground += AppLeavingBackground;
            this.RequestedTheme = ApplicationTheme.Light;
            Windows.System.MemoryManager.AppMemoryUsageLimitChanging += MemoryManager_AppMemoryUsageLimitChanging;
            Windows.System.MemoryManager.AppMemoryUsageIncreased += MemoryManager_AppMemoryUsageIncreased;
            var token = HardwareIdentification.GetPackageSpecificToken(null);
        }

        private void MemoryManager_AppMemoryUsageLimitChanging(object sender, AppMemoryUsageLimitChangingEventArgs e)
        {
            // If app memory usage is over the limit, reduce usage within 2 seconds
            // so that the system does not suspend the app
            addLog($"MemoryManager_AppMemoryUsageLimitChanging(), AppMemoryUsage: {MemoryManager.AppMemoryUsage}, NewLimit {e.NewLimit}");
            if (MemoryManager.AppMemoryUsage >= e.NewLimit)
            {
                ReduceMemoryUsage(e.NewLimit);
            }
        }
        private void MemoryManager_AppMemoryUsageIncreased(object sender, object e)
        {
            // Obtain the current usage level

            var level = MemoryManager.AppMemoryUsageLevel;
            addLog($"MemoryManager_AppMemoryUsageIncreased(), AppMemoryUsageLevel: {level}");

            // Check the usage level to determine whether reducing memory is necessary.
            // Memory usage may have been fine when initially entering the background but
            // the app may have increased its memory usage since then and will need to trim back.
            if (level == AppMemoryUsageLevel.OverLimit || level == AppMemoryUsageLevel.High)
            {
                ReduceMemoryUsage(MemoryManager.AppMemoryUsageLimit);
            }
        }
        private void AppEnteredBackground(object sender, EnteredBackgroundEventArgs e)
        {
            var level = MemoryManager.AppMemoryUsageLevel;
            addLog($"AppEnteredBackground(), AppMemoryUsageLevel: {MemoryManager.AppMemoryUsageLevel}");
            _isInBackgroundMode = true;

        }
        private void AppLeavingBackground(object sender, LeavingBackgroundEventArgs e)
        {
            var level = MemoryManager.AppMemoryUsageLevel;
            addLog($"AppLeavingBackground(), AppMemoryUsageLevel: {MemoryManager.AppMemoryUsageLevel}");
            _isInBackgroundMode = false;
        }

        public void ReduceMemoryUsage(ulong limit)
        {
            addLog("ReduceMemoryUsage1");
            // If the app has caches or other memory it can free, it should do so now.
            // << App can release memory here >>

            // Additionally, if the application is currently
            // in background mode and still has a view with content
            // then the view can be released to save memory and
            // can be recreated again later when leaving the background.
            if (_isInBackgroundMode && Window.Current.Content != null)
            {
                addLog("ReduceMemoryUsage2");
                // Some apps may wish to use this helper to explicitly disconnect
                // child references.
                // VisualTreeHelper.DisconnectChildrenRecursive(Window.Current.Content);

                // Clear the view content. Note that views should rely on
                // events like Page.Unloaded to further release resources.
                // Release event handlers in views since references can
                // prevent objects from being collected.
                //Window.Current.Content = null;
            }

            // Run the GC to collect released resources.
            GC.Collect();
        }
        protected override void OnBackgroundActivated(BackgroundActivatedEventArgs args)
        {
            base.OnBackgroundActivated(args);
            addLog("OnBackgroundActivated()");
            if (args.TaskInstance.TriggerDetails is AppServiceTriggerDetails details)
            {
                // only accept connections from callers in the same package
                if (details.CallerPackageFamilyName == Package.Current.Id.FamilyName)
                {
                    // connection established from the fulltrust process
                    AppServiceDeferral = args.TaskInstance.GetDeferral();
                    args.TaskInstance.Canceled += OnTaskCanceled;

                    Connection = details.AppServiceConnection;
                    AppServiceConnected?.Invoke(this, args.TaskInstance.TriggerDetails as AppServiceTriggerDetails);
                }
            }
        }

        private void OnTaskCanceled(IBackgroundTaskInstance sender, BackgroundTaskCancellationReason reason)
        {
            addLog($"OnTaskCanceled() reason: {reason.ToString()}");
            AppServiceDeferral?.Complete();
            AppServiceDeferral = null;
            Connection = null;
        }


        protected override async void OnActivated(IActivatedEventArgs e)
        {
            addLog("OnActivated(): type: " + e.Kind);

            Frame rootFrame = Window.Current.Content as Frame;

            // Do not repeat app initialization when the Window already has content,
            // just ensure that the window is active
            if (rootFrame == null)
            {
                addLog("rootFrame is null!!!!");
                // Create a Frame to act as the navigation context and navigate to the first page
                rootFrame = new Frame();

                rootFrame.NavigationFailed += OnNavigationFailed;
                ImageCircleRenderer.Init();
                var rendererAssemblies = new[]
                {
                typeof(ImageCircleRenderer).GetTypeInfo().Assembly,
                };
                Xamarin.Forms.Forms.Init(e, rendererAssemblies);
                Window.Current.Content = rootFrame;

            }
            if (e is ToastNotificationActivatedEventArgs)
            {
                var toastActivationArgs = e as ToastNotificationActivatedEventArgs;
                addLog("OnActivated(): args is: " + toastActivationArgs.Argument);
                if (toastActivationArgs.Argument.Equals("yes"))
                    CallService.Instance.answerCall(false);
            }

            if (e.Kind == ActivationKind.StartupTask)
            {

                if (rootFrame.Content == null)
                {
                    addLog("rootFrame.Navigate()");
                    rootFrame.Navigate(typeof(MainPage));
                }
                Window.Current.Activate();
                try
                {
                    var MyMediaCapture = new MediaCapture();
                    var settings = new MediaCaptureInitializationSettings();
                    settings.StreamingCaptureMode = StreamingCaptureMode.AudioAndVideo;

                    await MyMediaCapture.InitializeAsync(settings);
                }
                catch (Exception ex)
                {
                    addLog(ex.ToString());
                }
            }
        }

        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used such as when the application is launched to open a specific file.
        /// </summary>
        /// <param name="e">Details about the launch request and process.</param>
        protected override async void OnLaunched(LaunchActivatedEventArgs e)
        {
            addLog($"OnLaunched(), kind: {e.Kind}, PreviousExecutionState: {e.PreviousExecutionState}, PrelaunchActivated: {e.PrelaunchActivated} ");
            if (e.PreviousExecutionState == ApplicationExecutionState.Running)
            {
                addLog($"OnLaunched(), PreviousExecutionState was running. return");
                return;
            }
            Frame rootFrame = Window.Current.Content as Frame;

            if (rootFrame == null)
            {
                rootFrame = new Frame();

                rootFrame.NavigationFailed += OnNavigationFailed;
                ImageCircleRenderer.Init();
                var rendererAssemblies = new[]
                {
                    typeof(ImageCircleRenderer).GetTypeInfo().Assembly,
                };
                Xamarin.Forms.Forms.Init(e, rendererAssemblies);
                Window.Current.Content = rootFrame;
            }
            if (e.PrelaunchActivated == false)
            {
                if (rootFrame.Content == null)
                {
                    rootFrame.Navigate(typeof(MainPage), e.Arguments);
                }

                Window.Current.Activate();
                try
                {
                    var MyMediaCapture = new MediaCapture();
                    var settings = new MediaCaptureInitializationSettings();
                    settings.StreamingCaptureMode = StreamingCaptureMode.AudioAndVideo;

                    await MyMediaCapture.InitializeAsync(settings);
                }
                catch (Exception ex)
                {
                    addLog(ex.ToString());
                }
            }
        }

        /// <summary>
        /// Invoked when Navigation to a certain page fails
        /// </summary>
        /// <param name="sender">The Frame which failed navigation</param>
        /// <param name="e">Details about the navigation failure</param>
        void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        }

        /// <summary>
        /// Invoked when application execution is being suspended.  Application state is saved
        /// without knowing whether the application will be terminated or resumed with the contents
        /// of memory still intact.
        /// </summary>
        /// <param name="sender">The source of the suspend request.</param>
        /// <param name="e">Details about the suspend request.</param>
        private async void OnSuspendingAsync(object sender, SuspendingEventArgs e)
        {
            addLog("OnSuspendingAsync");
            AlertHelper.Instance.updateSuspandedBadge(true);
            var deferral = e.SuspendingOperation.GetDeferral();
            //TODO: Save application state and stop any background activity
            AppServiceDeferral?.Complete();
            AppServiceDeferral = null;
            Connection = null;
            // await SaveEntities();
            deferral.Complete();
        }

        private void addLog(string message)
        {
            MyFileSystem.Instance.writeDebug(message, "APPUWP");
        }


    }
}
