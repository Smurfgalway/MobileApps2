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
        private int Tracercount = 0;
        private int Anacount = 0;
        private int Bastioncount = 0;
        private int Dvacount = 0;
        private int Hanzocount = 0;
        private int Junkratcount = 0;
        private int Luciocount = 0;
        private int McCreecount = 0;
        private int Meicount = 0;
        private int Mercycount = 0;
        private int Orisacount = 0;
        private int Genjicount = 0;
        private int Pharahcount = 0;
        private int Roadhogcount = 0;
        private int Reinhardtcount = 0;
        private int Reapercount = 0;
        private int Soldiercount = 0;
        private int Sombracount = 0;
        private int Symmetracount = 0;
        private int Torbjorncount = 0;
        private int Widowmakercount = 0;
        private int Winstoncount = 0;
        private int Zenyattacount = 0;

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
            Tracercount++;

            if (Tracercount == 1)
            {
                Tr.Play();
            }
            else if (Tracercount == 2)
            {
                T2.Play();
            }
            else if (Tracercount == 3)
            {
                T3.Play();
            }
            else if (Tracercount > 3)
            {
                Tracercount = 0;
            }
        }

        private void Reinhart_Click(object sender, RoutedEventArgs e)
        {
            Reinhardtcount++;

            if (Reinhardtcount == 1)
            {
              Re.Play();
            }
            else if (Reinhardtcount == 2)
            {
                Re2.Play();
            }
            else if (Reinhardtcount == 3)
            {
                Re3.Play();
            }
            else if (Reinhardtcount > 3)
            {
                Reinhardtcount = 0;
            }
            
        }

        private void Roadhog_Click(object sender, RoutedEventArgs e)
        {
            Roadhogcount++;

            if (Roadhogcount == 1)
            {
                Ro.Play();
            }
            else if (Roadhogcount == 2)
            {
                Ro2.Play();
            }
            else if (Roadhogcount == 3)
            {
                Ro3.Play();
            }
            else if (Roadhogcount > 3)
            {
                Roadhogcount = 0;
            }
        }

        private void Pharah_Click(object sender, RoutedEventArgs e)
        {
            Pharahcount++;

            if (Pharahcount == 1)
            {
                P.Play();
            }
            else if (Pharahcount == 2)
            {
                P2.Play();
            }
            else if (Pharahcount == 3)
            {
                P3.Play();
            }
            else if (Pharahcount > 3)
            {
                Pharahcount = 0;
            }
        }

        private void Lucio_Click(object sender, RoutedEventArgs e)
        {
            Luciocount++;

            if (Luciocount == 1)
            {
                L.Play();
            }
            else if (Luciocount == 2)
            {
                L2.Play();
            }
            else if (Luciocount == 3)
            {
                L3.Play();
            }
            else if (Luciocount > 3)
            {
                Luciocount = 0;
            }

        }

        private void WidowMaker_Click(object sender, RoutedEventArgs e)
        {
            Widowmakercount++;

            if (Widowmakercount == 1)
            {
                Wid.Play();
            }
            else if (Widowmakercount == 2)
            {
                Wid2.Play();
            }
            else if (Widowmakercount == 3)
            {
                Wid3.Play();
            }
            else if (Widowmakercount > 3)
            {
                Widowmakercount = 0;
            }
        }

        private void DVA_Click(object sender, RoutedEventArgs e)
        {
            Dvacount++;

            if (Dvacount == 1)
            {
                D.Play();
            }
            else if (Dvacount == 2)
            {
                D2.Play();
            }
            else if (Dvacount == 3)
            {
                D3.Play();
            }
            else if (Dvacount > 3)
            {
                Dvacount = 0;
            }
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
