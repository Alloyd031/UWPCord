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

namespace UWPCord.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DMPage : Page
    {
        public DMPage()
        {
            this.InitializeComponent();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            this.DMFrame.Navigate(typeof(FriendsPage));
        }
        private void Friends_Click(object sender, RoutedEventArgs e)
        {
            this.DMFrame.Navigate(typeof(FriendsPage));
        }
        private void Nitro_Click(object sender, RoutedEventArgs e)
        {
            this.DMFrame.Navigate(typeof(NitroPage));
        }
        private async void UserButton_Click(object sender, RoutedEventArgs e)
        {
            UserInfoDialog dialog = new UserInfoDialog();
            await dialog.ShowAsync();
        }
        private void UserSettingsButton_Click(object sender, RoutedEventArgs e)
        {
            Frame contentFrame = Window.Current.Content as Frame;
            MainPage mp = contentFrame.Content as MainPage;
            contentFrame.Navigate(typeof(UserSettings));
        }
    }
}
