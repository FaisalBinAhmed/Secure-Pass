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
using Windows.UI.Core;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
       
        

        public MainPage()
        {
            this.InitializeComponent();
            myframe.Navigate(typeof(Firstpage));
            
        }
        private void App_BackRequested(object sender,
    Windows.UI.Core.BackRequestedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            if (rootFrame == null)
                return;

            // Navigate back if possible, and if the event has not 
            // already been handled .
            if (rootFrame.CanGoBack && e.Handled == false)
            {
                e.Handled = true;
                rootFrame.GoBack();
            }
        }


        private void library(object sender, RoutedEventArgs e)
        {
            //textBlock3.Text = "Coming soon";
        }
        private void OneD(object sender, RoutedEventArgs e)
        {
            //textBlock3.Text = "Coming soon";
        }
        private void Settingsbutton(object sender, RoutedEventArgs e) {
            myframe.Navigate(typeof(SettingsPage));

        }
        private void back(object sender, RoutedEventArgs e)
        {
            if (myframe.CanGoBack) {
                myframe.GoBack();
            }

        }

    }
}
