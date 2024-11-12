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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace KotiPhotos_UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage1 : Page
    {
        public BlankPage1()
        {
            this.InitializeComponent();
            LoadWebView();
        }

        private void LoadWebView()
        {
            login.Navigate(new Uri("https://login.microsoftonline.com/common/oauth2/v2.0/authorize?scope=service%3A%3Aaccount.microsoft.com%3A%3AMBI_SSL+openid+profile+offline_access&response_type=code&client_id=81feaced-5ddd-41e7-8bef-3e20a2689bb7&redirect_uri=https%3A%2F%2Faccount.microsoft.com%2Fauth%2Fcomplete-signin-oauth&client-request-id=c461b2ae-6cc0-4c35-8912-437ec055d77d&x-client-SKU=MSAL.Desktop&x-client-Ver=4.61.3.0&x-client-OS=Windows+Server+2019+Datacenter&prompt=login&client_info=1&state=H4sIAAAAAAAEAAXBx4JDQAAA0H_Zq4M-iUMOQaIshlj1NsroRMIoX7_v_TDEDABsmfkQDcDf7dQU7Qqfgp8QlS-nnl_Zku86bfPRQ2c1L1ZDO_k43AKrjDTm6ZNtUQ18oLDXpUXs9AAYd8V1-xC0r_ZeOsP2Ua5x4Bfrx5eN_ZlM0wzyYRiFL6tT1rtGWTH0ZqtHe4oRB1uWn3XOLwrlpFIN0EfXkQ3RD4Kb4kr4GjSMms5rMdhVYhS_SvOChtejRbFCHKfAngunjLUJPaKNoRzLyxutg-wqXdTKEL6NUNXIlf5US3rCXj6joAYtXgOHNs3x2Xfz1X6xMh4hHmV7FBFY9ySCcm25enZ3aTpT3-eBh3CGw7vJ4w3Zp9VQIbdfIHFao9NWPYfQu91-_gHktMHeWgEAAA&msaoauth2=true&lc=1033&sso_reload=true"));
        }
    }
}
