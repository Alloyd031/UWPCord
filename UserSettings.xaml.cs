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
using UWPCord.UserSettingsPages;
using Microsoft.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPCord
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class UserSettings : Page
    {
        public UserSettings()
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
            this.UserSettingsFrame.Navigate(typeof(NotAvailable));
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.GoBack();
        }
        private void MyAccount_Click(object sender, RoutedEventArgs e)
        {
            this.UserSettingsFrame.Navigate(typeof(NotAvailable));
        }
        private void Profiles_Click(object sender, RoutedEventArgs e)
        {
            this.UserSettingsFrame.Navigate(typeof(NotAvailable));
        }
        private void PrivacyAndSafety_Click(object sender, RoutedEventArgs e)
        {
            this.UserSettingsFrame.Navigate(typeof(NotAvailable));
        }
        private void AuthorizedApps_Click(object sender, RoutedEventArgs e)
        {
            this.UserSettingsFrame.Navigate(typeof(NotAvailable));
        }
        private void Devices_Click(object sender, RoutedEventArgs e)
        {
            this.UserSettingsFrame.Navigate(typeof(NotAvailable));
        }
        private void Connections_Click(object sender, RoutedEventArgs e)
        {
            this.UserSettingsFrame.Navigate(typeof(NotAvailable));
        }
        private void FriendRequests_Click(object sender, RoutedEventArgs e)
        {
            this.UserSettingsFrame.Navigate(typeof(NotAvailable));
        }
        private void Nitro_Click(object sender, RoutedEventArgs e)
        {
            this.UserSettingsFrame.Navigate(typeof(NotAvailable));
        }
        private void ServerBoost_Click(object sender, RoutedEventArgs e)
        {
            this.UserSettingsFrame.Navigate(typeof(NotAvailable));
        }
        private void Subscriptions_Click(object sender, RoutedEventArgs e)
        {
            this.UserSettingsFrame.Navigate(typeof(NotAvailable));
        }
        private void GiftInvertory_Click(object sender, RoutedEventArgs e)
        {
            this.UserSettingsFrame.Navigate(typeof(NotAvailable));
        }
        private void Billing_Click(object sender, RoutedEventArgs e)
        {
            this.UserSettingsFrame.Navigate(typeof(NotAvailable));
        }
        private void Appearance_Click(object sender, RoutedEventArgs e)
        {
            this.UserSettingsFrame.Navigate(typeof(NotAvailable));
        }
        private void Accessibility_Click(object sender, RoutedEventArgs e)
        {
            this.UserSettingsFrame.Navigate(typeof(NotAvailable));
        }
        private void VoiceAndVideo_Click(object sender, RoutedEventArgs e)
        {
            this.UserSettingsFrame.Navigate(typeof(NotAvailable));
        }
        private void TextAndImages_Click(object sender, RoutedEventArgs e)
        {
            this.UserSettingsFrame.Navigate(typeof(NotAvailable));
        }
        private void Notifications_Click(object sender, RoutedEventArgs e)
        {
            this.UserSettingsFrame.Navigate(typeof(NotAvailable));
        }
        private void Keybinds_Click(object sender, RoutedEventArgs e)
        {
            this.UserSettingsFrame.Navigate(typeof(NotAvailable));
        }
        private void Language_Click(object sender, RoutedEventArgs e)
        {
            this.UserSettingsFrame.Navigate(typeof(NotAvailable));
        }
        private void WindowsSettings_Click(object sender, RoutedEventArgs e)
        {
            this.UserSettingsFrame.Navigate(typeof(NotAvailable));
        }
        private void StreamerMode_Click(object sender, RoutedEventArgs e)
        {
            this.UserSettingsFrame.Navigate(typeof(NotAvailable));
        }
        private void Advanced_Click(object sender, RoutedEventArgs e)
        {
            this.UserSettingsFrame.Navigate(typeof(NotAvailable));
        }
        private void ActivityPrivacy_Click(object sender, RoutedEventArgs e)
        {
            this.UserSettingsFrame.Navigate(typeof(NotAvailable));
        }
        private void RegistreredGames_Click(object sender, RoutedEventArgs e)
        {
            this.UserSettingsFrame.Navigate(typeof(NotAvailable));
        }
        private void GameOverlay_Click(object sender, RoutedEventArgs e)
        {
            this.UserSettingsFrame.Navigate(typeof(NotAvailable));
        }
        private void WhatsNew_Click(object sender, RoutedEventArgs e)
        {
            this.UserSettingsFrame.Navigate(typeof(NotAvailable));
        }
        private void Hypesquad_Click(object sender, RoutedEventArgs e)
        {
            this.UserSettingsFrame.Navigate(typeof(NotAvailable));
        }
    }
}
