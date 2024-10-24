using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace KotiPhotos_UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            LoadWebView();
        }

        private void LoadWebView()
        {
            webview_kotiphotos.Navigate(new Uri("https://kotiphotos.serv00.net/uwp.html"));
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var uri = new Uri("https://github.com/ImVovanchik/KotiPhotos-UWP");
            await Launcher.LaunchUriAsync(uri);
        }
    }
}
