using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using UWPCord.Pages;
using Microsoft.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPCord
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            Window.Current.SetTitleBar(AppTitleBar);
            CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;
            ApplicationViewTitleBar titleBar = ApplicationView.GetForCurrentView().TitleBar;
            titleBar.ButtonBackgroundColor = Colors.Transparent;
            titleBar.ButtonInactiveBackgroundColor = Colors.Transparent;
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            this.ContentFrame.Navigate(typeof(DMPage));
        }
        private void DirectMessages_Click(object sender, RoutedEventArgs e)
        {
            this.ContentFrame.Navigate(typeof(DMPage));
        }
        private void TestServer_Click(object sender, RoutedEventArgs e)
        {
            this.ContentFrame.Navigate(typeof(TestServerPage));
        }
        private async void UserButton_Click(object sender, RoutedEventArgs e)
        {
            UserInfoDialog dialog = new UserInfoDialog();
            await dialog.ShowAsync();
        }
        private async void UserSettingsButton_Click(object sender, RoutedEventArgs e)
        {
            UserSettings dialog = new UserSettings();
            await dialog.ShowAsync();
        }
    }
}
