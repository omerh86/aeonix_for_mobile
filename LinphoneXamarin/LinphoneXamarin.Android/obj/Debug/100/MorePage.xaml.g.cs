//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("LinphoneXamarin.Android.MorePage.xaml", "MorePage.xaml", typeof(global::LinphoneXamarin.components.MorePage))]

namespace LinphoneXamarin.components {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("C:\\Atouch\\LinphoneXamarin\\LinphoneXamarin\\components\\MorePage.xaml")]
    public partial class MorePage : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.StackLayout myContactContainer;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.BoxView presenceLabel;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::LinphoneXamarin.components.userControllers.MyPresenceComponent myPresenceComponent;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(MorePage));
            myContactContainer = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.StackLayout>(this, "myContactContainer");
            presenceLabel = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.BoxView>(this, "presenceLabel");
            myPresenceComponent = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::LinphoneXamarin.components.userControllers.MyPresenceComponent>(this, "myPresenceComponent");
        }
    }
}
