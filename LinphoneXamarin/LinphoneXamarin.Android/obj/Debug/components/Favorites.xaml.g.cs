//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::Xamarin.Forms.Xaml.XamlResourceIdAttribute("LinphoneXamarin.Android.components.Favorites.xaml", "components/Favorites.xaml", typeof(global::LinphoneXamarin.components.Favorites))]

namespace LinphoneXamarin.components {
    
    
    [global::Xamarin.Forms.Xaml.XamlFilePathAttribute("C:\\xamarin-svn\\LinphoneXamarin\\LinphoneXamarin\\components\\Favorites.xaml")]
    public partial class Favorites : global::Xamarin.Forms.ContentPage {
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.StackLayout stack_layout;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::LinphoneXamarin.components.userControllers.MySearch search;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private global::Xamarin.Forms.ListView favorites;
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Xamarin.Forms.Build.Tasks.XamlG", "2.0.0.0")]
        private void InitializeComponent() {
            global::Xamarin.Forms.Xaml.Extensions.LoadFromXaml(this, typeof(Favorites));
            stack_layout = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.StackLayout>(this, "stack_layout");
            search = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::LinphoneXamarin.components.userControllers.MySearch>(this, "search");
            favorites = global::Xamarin.Forms.NameScopeExtensions.FindByName<global::Xamarin.Forms.ListView>(this, "favorites");
        }
    }
}
