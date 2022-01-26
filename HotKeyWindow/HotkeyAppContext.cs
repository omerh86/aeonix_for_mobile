
using System;
using Windows.Storage;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Windows.ApplicationModel;
using Windows.ApplicationModel.AppService;
using Windows.ApplicationModel.Core;
using Windows.Foundation.Collections;
using System.IO;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using HotKeyWindow;

namespace HotkeyWindow
{
    public enum Modifiers
    {
        Alt = 1,
        Control = 2,
        Shift = 4,
        Windows = 8,
        NoRepeast = 16384
    }

    public enum HotKey
    {
        None,
        CtrlQ,
        CtrlW,
        CtrlE,
        CtrlR,
        CtrlT,
        Ctrlf7,
        AltQ,
        AltW,
        AltlE,
        AltlR,
        AltlT,
        Altf7
    }

    public class HotkeyAppContext : ApplicationContext
    {
        private HotKeyWindow hotkeyWindow = null;
        private Process process = null;
        private bool hotkeyInProgress = false;

        public HotkeyAppContext()
        {
            addLog("HotkeyAppContext()");
            try
            {

                int processId = (int)ApplicationData.Current.LocalSettings.Values["processId"];
                process = Process.GetProcessById(processId);
                process.EnableRaisingEvents = true;
                addLog("processId(): " + processId);
                process.Exited += HotkeyAppContext_Exited;
                if (hotkeyWindow != null)
                {
                    addLog("DestroyHandle()");
                    hotkeyWindow.DestroyHandle();
                }
                hotkeyWindow = new HotKeyWindow();
                hotkeyWindow.HotkeyPressed += new HotKeyWindow.HotkeyDelegate(hotkeys_HotkeyPressed);
                var appSettings = loadSettings();
                if (appSettings != null)
                {
                    setCombo(1001, appSettings.answerKey);
                    setCombo(1002, appSettings.endKey);
                    setCombo(1003, appSettings.callKey);
                }
            }
            catch (Exception e)
            {
                addLog(e.ToString());
            }

        }

        private MySettings loadSettings()
        {

            string fileName = Windows.Storage.ApplicationData.Current.LocalFolder.Path + "\\my_settings";

            if (!File.Exists(fileName))
            {
                return null;
            }

            string s = File.ReadAllText(fileName);
            if (s != null && s != "")
            {
                MySettings result = jsonToObj<MySettings>(s);
                return result;
            }
            return null;
        }

        private T jsonToObj<T>(string val)
        {
            T loginInfo = JsonConvert.DeserializeObject<T>(val);
            return loginInfo;
        }

        private void setCombo(int id, HotKey hotKey)
        {
            switch (hotKey)
            {
                case HotKey.Altf7:
                    hotkeyWindow.RegisterCombo(id, Modifiers.Alt, Keys.F7);
                    break;
                case HotKey.AltQ:
                    hotkeyWindow.RegisterCombo(id, Modifiers.Alt, Keys.Q);
                    break;
                case HotKey.AltW:
                    hotkeyWindow.RegisterCombo(id, Modifiers.Alt, Keys.W);
                    break;
                case HotKey.AltlE:
                    hotkeyWindow.RegisterCombo(id, Modifiers.Alt, Keys.E);
                    break;
                case HotKey.AltlR:
                    hotkeyWindow.RegisterCombo(id, Modifiers.Alt, Keys.R);
                    break;
                case HotKey.AltlT:
                    hotkeyWindow.RegisterCombo(id, Modifiers.Alt, Keys.T);
                    break;

                case HotKey.Ctrlf7:
                    hotkeyWindow.RegisterCombo(id, Modifiers.Control, Keys.F7);
                    break;
                case HotKey.CtrlQ:
                    hotkeyWindow.RegisterCombo(id, Modifiers.Control, Keys.Q);
                    break;
                case HotKey.CtrlW:
                    hotkeyWindow.RegisterCombo(id, Modifiers.Control, Keys.W);
                    break;
                case HotKey.CtrlE:
                    hotkeyWindow.RegisterCombo(id, Modifiers.Control, Keys.E);
                    break;
                case HotKey.CtrlR:
                    hotkeyWindow.RegisterCombo(id, Modifiers.Control, Keys.R);
                    break;
                case HotKey.CtrlT:
                    hotkeyWindow.RegisterCombo(id, Modifiers.Control, Keys.T);
                    break;
            }
        }

        public void addLog(string message)
        {
            try
            {
                Logger.Instance.addLog(message);
            }
            catch (Exception e)
            {
                Console.WriteLine("omer:" + e);
            }

        }

        private void HotkeyAppContext_Exited(object sender, EventArgs e)
        {
            addLog("HotkeyAppContext_Exited()");
            Application.Exit();
        }

        private void Connection_ServiceClosed(AppServiceConnection sender, AppServiceClosedEventArgs args)
        {
            addLog("Connection_ServiceClosed()");

            hotkeyInProgress = false;
        }

        private async void hotkeys_HotkeyPressed(int ID)
        {
            addLog("hotkeys_HotkeyPressed(), hotkeyInProgress: " + hotkeyInProgress);
            if (hotkeyInProgress) return; // prevent reentrancy
            hotkeyInProgress = true;
            if (ID == 1003)
            {
                addLog("Send copy command");
                SendKeys.SendWait("^(c)");
            }
            if (ID != 1002)
            {
                // bring the UWP to the foreground (optional)
                IEnumerable<AppListEntry> appListEntries = await Package.Current.GetAppListEntriesAsync();
                await appListEntries.First().LaunchAsync();
            }



            // send the key ID to the UWP
            ValueSet hotkeyPressed = new ValueSet();
            hotkeyPressed.Add("ID", ID);

            AppServiceConnection connection = new AppServiceConnection();
            connection.PackageFamilyName = Package.Current.Id.FamilyName;
            connection.AppServiceName = "HotkeyConnection";
            AppServiceConnectionStatus status = await connection.OpenAsync();
            if (status != AppServiceConnectionStatus.Success)
            {
                Debug.WriteLine(status);
                Application.Exit();
            }
            connection.ServiceClosed += Connection_ServiceClosed;
            AppServiceResponse response = await connection.SendMessageAsync(hotkeyPressed);
        }


    }

    public class HotKeyWindow : NativeWindow
    {
        private const int WM_HOTKEY = 0x0312;
        private const int WM_DESTROY = 0x0002;

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private List<Int32> IDs = new List<int>();
        public delegate void HotkeyDelegate(int ID);
        public event HotkeyDelegate HotkeyPressed;

        // creates a headless Window to register for and handle WM_HOTKEY
        public HotKeyWindow()
        {


            addLog("HotKeyWindow");
            try
            {
                this.CreateHandle(new CreateParams());
                addLog("HotKeyWindow2");
                Application.ApplicationExit += new EventHandler(Application_ApplicationExit);
            }
            catch (Exception e)
            {
                addLog(e.ToString());
            }

        }

        public void addLog(string message)
        {
            try
            {
                Logger.Instance.addLog(message);
            }
            catch (Exception e)
            {
                Console.WriteLine("omer:" + e);
            }

        }

        public void RegisterCombo(Int32 ID, Modifiers fsModifiers, Keys vlc)
        {
            addLog("RegisterCombo()1");
            if (RegisterHotKey(this.Handle, ID, (int)fsModifiers, (int)vlc))
            {
                addLog("RegisterCombo()2, id: " + ID);
                IDs.Add(ID);
            }
        }

        private void Application_ApplicationExit(object sender, EventArgs e)
        {
            addLog("Application_ApplicationExit");
            this.DestroyHandle();
        }

        protected override void WndProc(ref Message m)
        {
            try
            {
                switch (m.Msg)
                {
                    case WM_HOTKEY: //raise the HotkeyPressed event
                        addLog("raise the HotkeyPressed event: " + m.Msg.ToString());
                        HotkeyPressed?.Invoke(m.WParam.ToInt32());
                        break;

                    case WM_DESTROY: //unregister all hot keys
                        foreach (int ID in IDs)
                        {
                            addLog("unregister all hot keys(): " + ID);
                            UnregisterHotKey(this.Handle, ID);
                        }
                        break;
                }
                base.WndProc(ref m);
            }
            catch (Exception e)
            {
                addLog(e.ToString());
            }

        }
        protected override void OnHandleChange()
        {
            addLog("OnHandleChange");
            base.OnHandleChange();
        }
        protected override void OnThreadException(Exception e)
        {
            addLog("OnThreadException: " + e.ToString());
            base.OnThreadException(e);
        }
    }

    public class MySettings
    {
        public HotKey answerKey { set; get; }
        public HotKey endKey { set; get; }
        public HotKey callKey { set; get; }

    }
}

