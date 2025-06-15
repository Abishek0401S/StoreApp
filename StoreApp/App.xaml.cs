using Microsoft.AspNetCore.Components.WebView.Maui;

namespace StoreApp
{
    public partial class App : Application
    {
        public App(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            Services = serviceProvider;
        }

        public IServiceProvider Services { get; }

        //protected override Window CreateWindow(IActivationState activationState)
        //{
        //    var blazorWebView = new BlazorWebView
        //    {
        //        HostPage = "wwwroot/index.html"
        //    };

        //    blazorWebView.RootComponents.Add(new RootComponent
        //    {
        //        Selector = "#app",
        //        ComponentType = typeof(ProductList) // 👈 This is Main.razor
        //    });

        //    return new Window
        //    {
        //        Page = new ContentPage
        //        {
        //            Content = blazorWebView
        //        }
        //    };
        //}

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new MainPage())
            {
                Title = "StoreApp"
            };
        }
    }
}
