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
    public sealed partial class ChannelOnePage : Page
    {
        public ChannelOnePage()
        {
            this.InitializeComponent();
        }
        private void MembersButton_Click(object sender, RoutedEventArgs e)
        {
            Button btnE = sender as Button;
            if (this.MembersPanel.Visibility == Visibility.Visible)
            {
                this.MembersPanel.Visibility = Visibility.Collapsed;
                this.NotAvailableGrid.Margin = new Thickness(0, 49, 0, 0);
            }
            else
            {
                this.MembersPanel.Visibility = Visibility.Visible;
                this.NotAvailableGrid.Margin = new Thickness(0, 49, 240, 0);
            }
        }
        private async void UserButton_Click(object sender, RoutedEventArgs e)
        {
            UserInfoDialog dialog = new UserInfoDialog();
            await dialog.ShowAsync();
        }
    }
}
