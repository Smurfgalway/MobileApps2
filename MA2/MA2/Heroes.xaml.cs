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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MA2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Heroes : Page
    {
        public Heroes()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), UriKind.Relative);
        }

        private void Bastion_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Hero_Pages.Hero1), UriKind.Relative);
        }

        private void Reinhart_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Hero_Pages.Hero2), UriKind.Relative);
        }

        private void Genji_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Hero_Pages.Hero3), UriKind.Relative);
        }

        private void Roadhog_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Hero_Pages.Hero4), UriKind.Relative);
        }

        private void Dva_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Hero_Pages.Hero5), UriKind.Relative);
        }

        private void Soldier_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Hero_Pages.Hero6), UriKind.Relative);
        }

        private void Hanzo_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Hero_Pages.Hero7), UriKind.Relative);
        }

        private void torb_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Hero_Pages.Hero8), UriKind.Relative);
        }

        private void Junk_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Hero_Pages.Hero9), UriKind.Relative);
        }

        private void Sym_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Hero_Pages.Hero10), UriKind.Relative);
        }

        private void Mercy_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Hero_Pages.Hero11), UriKind.Relative);
        }

        private void winston_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Hero_Pages.Hero12), UriKind.Relative);
        }

        private void Mcgree_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Hero_Pages.Hero13), UriKind.Relative);
        }

        private void mei_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Hero_Pages.Hero14), UriKind.Relative);
        }

        private void WidowMaker_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Hero_Pages.Hero15), UriKind.Relative);
        }

        private void Lucio_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Hero_Pages.Hero16), UriKind.Relative);
        }

        private void Tracer_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Hero_Pages.Hero17), UriKind.Relative);
        }

        private void ana_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Hero_Pages.Hero18), UriKind.Relative);
        }

        private void Pharah_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Hero_Pages.Hero19), UriKind.Relative);
        }

        private void Reaper_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Hero_Pages.Hero20), UriKind.Relative);
        }

        private void Za_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Hero_Pages.Hero21), UriKind.Relative);
        }

        private void Zen_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Hero_Pages.Hero22), UriKind.Relative);
        }

        private void Som_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Hero_Pages.Hero23), UriKind.Relative);

        }
    }
}
