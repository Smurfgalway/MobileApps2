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
    public sealed partial class SoundBoard : Page
    {
        public SoundBoard()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), UriKind.Relative);
        }

        private void Tracer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Reinhart_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Roadhog_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Pharah_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Lucio_Click(object sender, RoutedEventArgs e)
        {
            L.Play();
            
        }
    }
}
