using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Notifications;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Data.Xml.Dom;
using System.Threading.Tasks;

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
            Notify("Добро пожаловать!", "Проверка на обновления...", "Закрыть");
            // Это не надо
            //this.Loaded += MainPage_Loaded;
            webview_kotiphotos.NavigationStarting += webview_kotiphotos_NavigationStarting;
            webview_kotiphotos.NavigationCompleted += webview_kotiphotos_NavigationCompleted;
            LoadWebView();
            update();
        }

        private async void update()
        {
            await Task.Delay(2000); // Ждём 2 секунды перед проверкой обновлений
            checkForUpdates();
        }
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            var view = ApplicationView.GetForCurrentView();
            view.TitleBar.BackgroundColor = Windows.UI.Colors.Transparent;
            view.TitleBar.ButtonBackgroundColor = Windows.UI.Colors.Transparent;

            Window.Current.SetTitleBar(null);
            this.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.Transparent);
        }

        private void checkForUpdates()
        {
            string title = "Произошла ошибка";
            string content = "Не удалось проверить обновления: Нет имплементации.";
            string toastXmlString = $@"
            <toast>
                <visual>
                    <binding template='ToastGeneric'>
                        <text>{title}</text>
                        <text>{content}</text>
                    </binding>
                </visual>
                <actions>
                    <action content='Закрыть' arguments='action=close' />
                </actions>
            </toast>";
            XmlDocument toastXml = new XmlDocument();
            toastXml.LoadXml(toastXmlString);
            ToastNotification toast = new ToastNotification(toastXml);
            ToastNotificationManager.CreateToastNotifier().Show(toast);
        }

        private void Notify(string notificationTitle, string notificationContent, string button1String)
        {
            string title = $"{notificationTitle}";
            string content = $"{notificationContent}";
            string toastXmlString = $@"
            <toast>
                <visual>
                    <binding template='ToastGeneric'>
                        <text>{title}</text>
                        <text>{content}</text>
                    </binding>
                </visual>
                <actions>
                    <action content='{button1String}' arguments='action=close' />
                </actions>
            </toast>";
            XmlDocument toastXml = new XmlDocument();
            toastXml.LoadXml(toastXmlString);
            ToastNotification toast = new ToastNotification(toastXml);
            ToastNotificationManager.CreateToastNotifier().Show(toast);
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

        private void webview_kotiphotos_NavigationStarting(WebView sender, WebViewNavigationStartingEventArgs args)
        {
            progressBar.Visibility = Visibility.Visible;
        }
        private void webview_kotiphotos_NavigationCompleted(WebView sender, WebViewNavigationCompletedEventArgs args)
        {
            progressBar.Visibility = Visibility.Collapsed;
        }

        private void RefreshPageButton_Click(object sender, RoutedEventArgs e)
        {
            webview_kotiphotos.Refresh();
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ContentDialog exitDialog = new ContentDialog
            {
                Title = "Подтверждение выхода",
                Content = "Вы уверены, что хотите выйти из приложения?",
                PrimaryButtonText = "Да",
                SecondaryButtonText = "Нет"
            };
            ContentDialogResult result = await exitDialog.ShowAsync();
            if (result == ContentDialogResult.Primary)
            {
                Application.Current.Exit();
            }
        }
    }
}
