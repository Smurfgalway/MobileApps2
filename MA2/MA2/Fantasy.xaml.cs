using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Streams;
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
        private int gametype;


        private void button_Click(object sender, RoutedEventArgs e)
        {
          
            if (count == 0)
            {
                heroes1.Text = heroes1.Text + " Genji";
            }
            else
            {

            }
            count++;
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage), UriKind.Relative);
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            
            if (count1 == 0)
            {
                heroes1.Text = heroes1.Text + " Orisa";
            }
            else
            {

            }
            count1++;
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            
            if (count2 == 0)
            {
                heroes1.Text = heroes1.Text + " Bastion";
            }
            else
            {

            }
            count2++;
        }

        private void Mccree_Click(object sender, RoutedEventArgs e)
        {
           
            if (count3 == 0)
            {
                heroes1.Text = heroes1.Text + " Mcree";
            }
            else
            {

            }
            count3++;

        }

        private void Hanzo_Click(object sender, RoutedEventArgs e)
        {
            
            if (count4 == 0)
            {
                heroes1.Text = heroes1.Text + " Hanzo";
            }
            else
            {

            }
            count4++;
        }

        private void Reinhardt_Click(object sender, RoutedEventArgs e)
        {
            
            if (count5 == 0)
            {
                heroes1.Text = heroes1.Text + " Reinhardt";
            }
            else
            {
            
            }
            count5++;
        }

        private void Pharah_Click(object sender, RoutedEventArgs e)
        {
            
            if (count6 == 0)
            {
                heroes1.Text = heroes1.Text + " Pharah";
            }
            else
            {

            }
            count6++;

        }

        private void Junkrat_Click(object sender, RoutedEventArgs e)
        {
           
            if (count7 == 0)
            {
                heroes1.Text = heroes1.Text + " Junkrat";
            }
            else
            {

            }
            count7++;

        }

        private void Roadhog_Click(object sender, RoutedEventArgs e)
        {
            
            if (count8 == 0)
            {
                heroes1.Text = heroes1.Text + " Roadhog";
            }
            else
            {

            }
            count8++;
        }

        private void Reaper_Click(object sender, RoutedEventArgs e)
        {
            
            if (count9 == 0)
            {
                heroes1.Text = heroes1.Text + " Reaper";
            }
            else
            {

            }
            count9++;
        }

        private void Mei_Click(object sender, RoutedEventArgs e)
        {
            if (count10 == 0)
            {
                heroes1.Text = heroes1.Text + " Mei";
            }
            else
            {

            }
            count10++;

        }

        private void Winston_Click(object sender, RoutedEventArgs e)
        {
            if (count11 == 0)
            {
                heroes1.Text = heroes1.Text + " Winston";
            }
            else
            {

            }
            count11++;

        }

        private void Sombra_Click(object sender, RoutedEventArgs e)
        {
            if (count12 == 0)
            {
                heroes1.Text = heroes1.Text + " Sombra";
            }
            else
            {

            }
            count12++;

        }

        private void Widowmaker_Click(object sender, RoutedEventArgs e)
        {
            if (count13 == 0)
            {
                heroes1.Text = heroes1.Text + " Widowmaker";
            }
            else
            {

            }
            count13++;

        }

        private void Ana_Click(object sender, RoutedEventArgs e)
        {
            if (count14 == 0)
            {
                heroes1.Text = heroes1.Text + " Ana";
            }
            else
            {

            }
            count14++;

        }

        private void Tracer_Click(object sender, RoutedEventArgs e)
        {
           
            if (count15 == 0)
            {
                heroes1.Text = heroes1.Text + " Tracer";
            }
            else
            {
                    
            }
            count15++;

        }

        private void D_va_Click(object sender, RoutedEventArgs e)
        {
            
            if (count16 == 0)
            {
                heroes1.Text = heroes1.Text + " D.va";
            }
            else
            {

            }
            count16++;

        }

        private void lucio_Click(object sender, RoutedEventArgs e)
        {
            
            if (count17 == 0)
            {
                heroes1.Text = heroes1.Text + " lucio";
            }
            else
            {

            }
            count17++;
        }

        private void Soldier_Click(object sender, RoutedEventArgs e)
        {
            if (count18 == 0)
            {
                heroes1.Text = heroes1.Text + " Soldier";
            }
            else
            {

            }
            count18++;

        }

        private void Torbjorn_Click(object sender, RoutedEventArgs e)
        {
            if (count19 == 0)
            {
                heroes1.Text = heroes1.Text + " Torbjorn";
            }
            else
            {

            }
            count19++;

        }

        private void Zayra_Click(object sender, RoutedEventArgs e)
        {
            if (count20 == 0)
            {
                heroes1.Text = heroes1.Text + " Zayra";
            }
            else
            {

            }
            count20++;

        }

        private void Mercy_Click(object sender, RoutedEventArgs e)
        {
         
            if (count21 == 0)
            {
                heroes1.Text = heroes1.Text + " Mercy";
            }
            else
            {

            }
            count21++;

        }

        private void Symmetra_Click(object sender, RoutedEventArgs e)
        {
            if (count22 == 0)
            {
                heroes1.Text = heroes1.Text + " Symmetra";
            }
            else
            {

            }
            count22++;

        }

        private void Zenyatta_Click(object sender, RoutedEventArgs e)
        {
            
            if (count23 == 0)
            {
                heroes1.Text = heroes1.Text + " Zenyatta";
            }
            else
            {

            }
            count23++;

        }



        private async void Save_Click(object sender, RoutedEventArgs e)
         {

             Windows.Storage.StorageFolder storageFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
             Windows.Storage.StorageFile File = await storageFolder.CreateFileAsync("savedheroes.txt", Windows.Storage.CreationCollisionOption.ReplaceExisting);
             Windows.Storage.StorageFile savedFile = await storageFolder.GetFileAsync("savedHeroes.txt");
            

            using (IRandomAccessStream iRandomAccessStream = await savedFile.OpenAsync(FileAccessMode.ReadWrite))
             {
                 using (DataWriter writer = new DataWriter(iRandomAccessStream))
                 { 
                   writer.WriteString(heroes1.Text);
                    await writer.StoreAsync();
                    writer.WriteString(heroes2.Text);
                    await writer.StoreAsync();

                }
           
            }

        }

        private async void Load_Click(object sender, RoutedEventArgs e)
         {

             Windows.Storage.StorageFolder storageFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
             Windows.Storage.StorageFile savedFile = await storageFolder.GetFileAsync("savedHeroes.txt");
       

            var stream = await savedFile.OpenAsync(Windows.Storage.FileAccessMode.Read); using
                         (StreamReader reader = new StreamReader(stream.AsStream()))
            {
                heroes1.Text = reader.ReadToEnd();
                heroes2.Text = reader.ReadToEnd();
            }

        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            heroes1.Text = " ";
            heroes2.Text = " ";
        }

        private void g2_Click(object sender, RoutedEventArgs e)
        {

            if (gametype == 0)
            {
                heroes2.Text  = " Escort";
            }
            else
            {

            }
            gametype++;

        }

        private void g1_Click(object sender, RoutedEventArgs e)
        {
            if (gametype == 0)
            {
                heroes2.Text = " Capture the Flag";
            }
            else
            {

            }
            gametype++;
        }

        private void g3_Click(object sender, RoutedEventArgs e)
        {
            if (gametype == 0)
            {
                heroes2.Text = " Control";
            }
            else
            {

            }
            gametype++;
        }

        private void g4_Click(object sender, RoutedEventArgs e)
        {
            if (gametype == 0)
            {
                heroes2.Text = " Assualt";
            }
            else
            {

            }
            gametype++;
        }
    }
}
