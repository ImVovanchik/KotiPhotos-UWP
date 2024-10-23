using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
        /// <summary>
        /// Initializes a new instance of the <see cref="KotiPhotos_UWP.MainPage"/> class.
        /// </summary>
        /// <remarks>
        /// This constructor initializes the components of the MainPage and loads the WebView with a predefined URL.
        /// </remarks>
        public MainPage()
        {
            this.InitializeComponent();
            LoadWebView();
        }
        /// <summary>
        /// Loads the WebView control with a predefined URL.
        /// </summary>
        /// <remarks>
        /// This method navigates the WebView control named <c>webview_kotiphotos</c> to the specified URL.
        /// </remarks>
        private void LoadWebView()
        {
            webview_kotiphotos.Navigate(new Uri("https://kotiphotos.serv00.net/uwp.html"));
        }
    }
}
