using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
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
    public sealed partial class Fantasy : Page
    {
        public Fantasy()
        {
            this.InitializeComponent();
        }
        private int count;
        private int count1;
        private int count2;
        private int count3;
        private int count4;
        private int count5;
        private int count6;
        private int count7;
        private int count8;
        private int count9;
        private int count10;
        private int count11;
        private int count12;
        private int count13;
        private int count14;
        private int count15;
        private int count16;
        private int count17;
        private int count18;
        private int count19;
        private int count20;
        private int count21;
        private int count22;
        private int count23;

        private void button_Click(object sender, RoutedEventArgs e)
        {
            count++;
            if (count == 1)
            {
                heroes1.Text = heroes1.Text + "Genji";
            }
            else {

            }
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), UriKind.Relative);
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            count1++;
            if (count == 1)
            {
                heroes1.Text = heroes1.Text + " Orisa";
            }
            else
            {

            }
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            count2++;
            if (count == 1)
            {
                heroes1.Text = heroes1.Text + " Bastion";
            }
            else
            {

            }
        }

        private void Mccree_Click(object sender, RoutedEventArgs e)
        {
            count3++;
            if (count == 1)
            {
                heroes1.Text = heroes1.Text + " Mcree";
            }
            else
            {

            }

        }

        private void Hanzo_Click(object sender, RoutedEventArgs e)
        {
            count4++;
            if (count == 1)
            {
                heroes1.Text = heroes1.Text + " Hanzo";
            }
            else
            {
                    
            }
        }

        private void Reinhardt_Click(object sender, RoutedEventArgs e)
        {
            count5++;
            if (count == 1)
            {
                heroes1.Text = heroes1.Text + " Reinhardt";
            }
            else
            {

            }

        }

        private void Pharah_Click(object sender, RoutedEventArgs e)
        {
            count6++;
            if (count == 1)
            {
                heroes1.Text = heroes1.Text + " Pharah";
            }
            else
            {

            }

        }

        private void Junkrat_Click(object sender, RoutedEventArgs e)
        {
            count7++;
            if (count == 1)
            {
                heroes1.Text = heroes1.Text + " Junkrat";
            }
            else
            {

            }

        }

        private void Roadhog_Click(object sender, RoutedEventArgs e)
        {
            count8++;
            if (count == 1)
            {
                heroes1.Text = heroes1.Text + " Roadhog";
            }
            else
            {

            }

        }

        private void Reaper_Click(object sender, RoutedEventArgs e)
        {
            count9++;
            if (count == 1)
            {
                heroes1.Text = heroes1.Text + " Reaper";
            }
            else
            {

            }

        }

        private void Mei_Click(object sender, RoutedEventArgs e)
        {
            count10++;
            if (count == 1)
            {
                heroes1.Text = heroes1.Text + " Mei";
            }
            else
            {

            }

        }

        private void Winston_Click(object sender, RoutedEventArgs e)
        {
            count11++;
            if (count == 1)
            {
                heroes1.Text = heroes1.Text + " Winston";
            }
            else
            {

            }

        }

        private void Sombra_Click(object sender, RoutedEventArgs e)
        {
            count12++;
            if (count == 1)
            {
                heroes1.Text = heroes1.Text + " Sombra";
            }
            else
            {

            }
        }

        private void Widowmaker_Click(object sender, RoutedEventArgs e)
        {
            count13++;
            if (count == 1)
            {
                heroes1.Text = heroes1.Text + " Widowmaker";
            }
            else
            {

            }
        }

        private void Ana_Click(object sender, RoutedEventArgs e)
        {
            count14++;
            if (count == 1)
            {
                heroes1.Text = heroes1.Text + " Ana";
            }
            else
            {

            }
        }

        private void Tracer_Click(object sender, RoutedEventArgs e)
        {
            count15++;
            if (count == 1)
            {
                heroes1.Text = heroes1.Text + " Tracer";
            }

        }

        private void D_va_Click(object sender, RoutedEventArgs e)
        {
            count16++;
            if (count == 1)
            {
                heroes1.Text = heroes1.Text + " D.va";
            }
            else
            {

            }

        }

        private void lucio_Click(object sender, RoutedEventArgs e)
        {
            count17++;
            if (count == 1)
            {
                heroes1.Text = heroes1.Text + " lucio";
            }
            else
            {
                   
            }

        }

        private void Soldier_Click(object sender, RoutedEventArgs e)
        {
            count18++;
            if (count == 1)
            {
                heroes1.Text = heroes1.Text + " Soldier";
            }
            else
            {
                   
            }

        }

        private void Torbjorn_Click(object sender, RoutedEventArgs e)
        {
            count19++;
            if (count == 1)
            {
                heroes1.Text = heroes1.Text + " Torbjorn";
            }
            else
            {

            }

        }

        private void Zayra_Click(object sender, RoutedEventArgs e)
        {
            count20++;
            if (count == 1)
            {
                heroes1.Text = heroes1.Text + " Zayra";
            }
            else
            {

            }

        }

        private void Mercy_Click(object sender, RoutedEventArgs e)
        {
            count21++;
            if (count == 1)
            {
                heroes1.Text = heroes1.Text + " Mercy";
            }
            else
            {

            }

        }

        private void Symmetra_Click(object sender, RoutedEventArgs e)
        {
            count22++;
            if (count == 1)
            {
                heroes1.Text = heroes1.Text + " Symmetra";
            }
            else
            {

            }

        }

        private void Zenyatta_Click(object sender, RoutedEventArgs e)
        {
            count23++;
            if (count == 1)
            {
                heroes1.Text = heroes1.Text + " Zenyatta";
            }
            else
            {

            }

        }
    }
}
