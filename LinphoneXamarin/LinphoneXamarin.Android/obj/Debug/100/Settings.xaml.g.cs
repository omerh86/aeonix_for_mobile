//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("LinphoneXamarin.Android.Settings.xaml", "Settings.xaml", typeof(global::LinphoneXamarin.components.Settings))]

namespace LinphoneXamarin.components {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("C:\\Atouch\\LinphoneXamarin\\LinphoneXamarin\\components\\Settings.xaml")]
    public partial class Settings : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Switch actionFeaturesSwitch;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::LinphoneXamarin.styles.CustomPicker langPicker;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Picker ringPicker;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Switch ringSwitch;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Switch messageSwitch;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Switch ringVibrateSwitch;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Switch messageVibrateSwitch;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.StackLayout vmLayout;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Entry vmPassword;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.StackLayout syncContactsLayout;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Label syncLoader;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.ProgressBar syncContactsPB;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Switch syncContacts;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Label syncErrLbl;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Label micGainLbl;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(Settings));
            actionFeaturesSwitch = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Switch>(this, "actionFeaturesSwitch");
            langPicker = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::LinphoneXamarin.styles.CustomPicker>(this, "langPicker");
            ringPicker = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Picker>(this, "ringPicker");
            ringSwitch = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Switch>(this, "ringSwitch");
            messageSwitch = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Switch>(this, "messageSwitch");
            ringVibrateSwitch = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Switch>(this, "ringVibrateSwitch");
            messageVibrateSwitch = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Switch>(this, "messageVibrateSwitch");
            vmLayout = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.StackLayout>(this, "vmLayout");
            vmPassword = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Entry>(this, "vmPassword");
            syncContactsLayout = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.StackLayout>(this, "syncContactsLayout");
            syncLoader = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "syncLoader");
            syncContactsPB = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.ProgressBar>(this, "syncContactsPB");
            syncContacts = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Switch>(this, "syncContacts");
            syncErrLbl = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "syncErrLbl");
            micGainLbl = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "micGainLbl");
        }
    }
}
