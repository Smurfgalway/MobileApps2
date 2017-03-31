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
        private int Zaryacount = 0;

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
            Hanzocount++;

            if (Hanzocount == 1)
            {
                H.Play();
            }
            else if (Hanzocount == 2)
            {
                H2.Play();
            }
            else if (Hanzocount == 3)
            {
                H3.Play();
            }
            else if (Hanzocount > 3)
            {
                Hanzocount = 0;
            }
        }

        private void Mercy_Click(object sender, RoutedEventArgs e)
        {
            Mercycount++;

            if (Mercycount == 1)
            {
                Mrc.Play();
            }
            else if (Mercycount == 2)
            {
                Mrc2.Play();
            }
            else if (Mercycount == 3)
            {
                Mrc3.Play();
            }
            else if (Mercycount > 3)
            {
                Mercycount = 0;
            }
        }

        private void Mcgree_Click(object sender, RoutedEventArgs e)
        {
            McCreecount++;

            if (McCreecount == 1)
            {
                Mc.Play();
            }
            else if (McCreecount == 2)
            {
                Mc2.Play();
            }
            else if (McCreecount == 3)
            {
                Mc3.Play();
            }
            else if (McCreecount > 3)
            {
                McCreecount = 0;
            }
        }

        private void JR_Click(object sender, RoutedEventArgs e)
        {
            Junkratcount++;

            if (Junkratcount == 1)
            {
                J.Play();
            }
            else if (Junkratcount == 2)
            {
                J2.Play();
            }
            else if (Junkratcount == 3)
            {
                J3.Play();
            }
            else if (Junkratcount > 3)
            {
                Junkratcount = 0;
            }
        }

        private void Mai_Click(object sender, RoutedEventArgs e)
        {
            Meicount++;

            if (Meicount == 1)
            {
                Me.Play();
            }
            else if (Meicount == 2)
            {
                Me2.Play();
            }
            else if (Meicount == 3)
            {
                Me3.Play();
            }
            else if (Meicount > 3)
            {
                Meicount = 0;
            }
        }

        private void Reaper_Click(object sender, RoutedEventArgs e)
        {
            Reapercount++;

            if (Reapercount == 1)
            {
                R.Play();
            }
            else if (Reapercount == 2)
            {
                R2.Play();
            }
            else if (Reapercount == 3)
            {
                R3.Play();
            }
            else if (Reapercount > 3)
            {
                Reapercount = 0;
            }
        }

        private void Genji_Click(object sender, RoutedEventArgs e)
        {
            Genjicount++;

            if (Genjicount == 1)
            {
                G.Play();
            }
            else if (Genjicount == 2)
            {
                G2.Play();
            }
            else if (Genjicount == 3)
            {
                G3.Play();
            }
            else if (Genjicount > 3)
            {
                Genjicount = 0;
            }
           
        }

        private void Soldier_Click(object sender, RoutedEventArgs e)
        {
            Soldiercount++;

            if (Soldiercount == 1)
            {
                S76.Play();
            }
            else if (Soldiercount == 2)
            {
                S762.Play();
            }
            else if (Soldiercount == 3)
            {
                S763.Play();
            }
            else if (Soldiercount > 3)
            {
                Soldiercount = 0;
            }
        }

        private void Winston_Click(object sender, RoutedEventArgs e)
        {
            Winstoncount++;

            if (Winstoncount == 1)
            {
                Win.Play();
            }
            else if (Winstoncount == 2)
            {
                Win2.Play();
            }
            else if (Winstoncount == 3)
            {
                Win3.Play();
            }
            else if (Winstoncount > 3)
            {
                Winstoncount = 0;
            }
            
        }

        private void Ana_Click(object sender, RoutedEventArgs e)
        {
            Anacount++;

            if (Anacount == 1)
            {
                A.Play();
            }
            else if (Anacount == 2)
            {
                A2.Play();
            }
            else if (Anacount == 3)
            {
                A3.Play();
            }
            else if (Anacount > 3)
            {
                Anacount = 0;
            }
        }

        private void Symmetra_Click(object sender, RoutedEventArgs e)
        {
            Symmetracount++;

            if (Symmetracount == 1)
            {
                Sym.Play();
            }
            else if (Symmetracount == 2)
            {
                Sym2.Play();
            }
            else if (Symmetracount == 3)
            {
                Sym3.Play();
            }
            else if (Symmetracount > 3)
            {
                Symmetracount = 0;
            }
        }

        private void Bastion_Click(object sender, RoutedEventArgs e)
        {
            Bastioncount++;

            if (Bastioncount == 1)
            {
                B.Play();
            }
            else if (Bastioncount == 2)
            {
                B2.Play();
            }
            else if (Bastioncount == 3)
            {
                B3.Play();
            }
            else if (Bastioncount > 3)
            {
                Bastioncount = 0;
            }
        }

        private void Zayra_Click(object sender, RoutedEventArgs e)
        {

           Zaryacount++;

            if (Zaryacount == 1)
            {
                Za.Play();
            }
            else if (Zaryacount == 2)
            {
                Za2.Play();
            }
            else if (Zaryacount == 3)
            {
                Za3.Play();
            }
            else if (Zaryacount > 3)
            {
                Zaryacount = 0;
            }
        }

        private void Sombra_Click(object sender, RoutedEventArgs e)
        {
            Sombracount++;

            if (Sombracount == 1)
            {
                Som.Play();
            }
            else if (Sombracount == 2)
            {
                Som2.Play();
            }
            else if (Sombracount == 3)
            {
                Som3.Play();
            }
            else if (Sombracount > 3)
            {
                Sombracount = 0;
            }
        }

        private void Zenyatta_Click(object sender, RoutedEventArgs e)
        {
            Zenyattacount++;

            if (Zenyattacount == 1)
            {
                Ze.Play();
            }
            else if (Zenyattacount == 2)
            {
                Ze2.Play();
            }
            else if (Zenyattacount == 3)
            {
                Ze3.Play();
            }
            else if (Zenyattacount > 3)
            {
                Zenyattacount = 0;
            }
        }

        private void Torbjörn_Click(object sender, RoutedEventArgs e)
        {
            Torbjorncount++;

            if (Torbjorncount == 1)
            {
                Tor.Play();
            }
            else if (Torbjorncount == 2)
            {
                Tor2.Play();
            }
            else if (Torbjorncount == 3)
            {
                Tor3.Play();
            }
            else if (Torbjorncount > 3)
            {
                Torbjorncount = 0;
            }
        }

        private void Orisa_Click(object sender, RoutedEventArgs e)
        {
            Or.Play();
        }
    }
}
