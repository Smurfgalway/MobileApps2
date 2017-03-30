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
        private int count = 0;
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
            count++;

            if (count == 1)
            {
                Tr.Play();
            }
            else if (count == 2)
            {
                T2.Play();
            }
            else if (count == 3)
            {
                T3.Play();
            }
            else if (count > 3)
            {
                count = 0;
            }
        }

        private void Reinhart_Click(object sender, RoutedEventArgs e)
        {
            Re.Play();
        }

        private void Roadhog_Click(object sender, RoutedEventArgs e)
        {
            Ro.Play();
        }

        private void Pharah_Click(object sender, RoutedEventArgs e)
        {
            P.Play();
        }

        private void Lucio_Click(object sender, RoutedEventArgs e)
        {
            L.Play();
            
        }

        private void WidowMaker_Click(object sender, RoutedEventArgs e)
        {
            Wid.Play();
        }

        private void DVA_Click(object sender, RoutedEventArgs e)
        {
            D.Play();
        }

        private void Hanzo_Click(object sender, RoutedEventArgs e)
        {
            H.Play();
        }

        private void Mercy_Click(object sender, RoutedEventArgs e)
        {
            Mrc.Play();
        }

        private void Mcgree_Click(object sender, RoutedEventArgs e)
        {
            Mc.Play();
        }

        private void JR_Click(object sender, RoutedEventArgs e)
        {
            J.Play();
        }

        private void Mai_Click(object sender, RoutedEventArgs e)
        {
            Me.Play();
        }

        private void Reaper_Click(object sender, RoutedEventArgs e)
        {
            R.Play();
        }

        private void Genji_Click(object sender, RoutedEventArgs e)
        {
            G.Play();
        }

        private void Soldier_Click(object sender, RoutedEventArgs e)
        {
            S76.Play();
        }

        private void Winston_Click(object sender, RoutedEventArgs e)
        {
            Win.Play();
        }

        private void Ana_Click(object sender, RoutedEventArgs e)
        {
            A.Play();
        }

        private void Symmetra_Click(object sender, RoutedEventArgs e)
        {
            Sym.Play();
        }

        private void Bastion_Click(object sender, RoutedEventArgs e)
        {
            B.Play();
        }

        private void Zayra_Click(object sender, RoutedEventArgs e)
        {
            Za.Play();
        }

        private void Sombra_Click(object sender, RoutedEventArgs e)
        {
            Som.Play();
        }

        private void Zenyatta_Click(object sender, RoutedEventArgs e)
        {
            Ze.Play();
        }

        private void Torbjörn_Click(object sender, RoutedEventArgs e)
        {
            Tor.Play();
        }

        private void Orisa_Click(object sender, RoutedEventArgs e)
        {
            Or.Play();
        }
    }
}
