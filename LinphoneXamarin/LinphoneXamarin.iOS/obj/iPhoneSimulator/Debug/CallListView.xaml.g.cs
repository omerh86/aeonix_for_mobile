//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("LinphoneXamarin.CallListView.xaml", "CallListView.xaml", typeof(global::LinphoneXamarin.components.userControllers.CallListView))]

namespace LinphoneXamarin.components.userControllers {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("/Users/tadirantelecom/Documents/xamarian1/LinphoneXamarin/LinphoneXamarin/compone" +
        "nts/userControllers/CallListView.xaml")]
    public partial class CallListView : global::Xamarin.Forms.StackLayout {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.Label callsBtn;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.ListView callsListComponent;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(CallListView));
            callsBtn = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.Label>(this, "callsBtn");
            callsListComponent = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.ListView>(this, "callsListComponent");
        }
    }
}