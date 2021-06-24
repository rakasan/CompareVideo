using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VideoCompare
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(Form.Width == 1110)
            { 
                Form.Width = 1250;
            }
            else
            {
                Form.Width = 1110;
            }
      }

        private void btnLoad1_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog ofd = new System.Windows.Forms.OpenFileDialog();
            Me1.LoadedBehavior = MediaState.Manual;
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Me1.Source = new Uri(ofd.FileName);
               
            }
            
        }

        private void btnPlay1_Click(object sender, RoutedEventArgs e)
        {
            Me1.Position = TimeSpan.FromSeconds(Convert.ToInt32(StartSec1.Text));
            Me1.SpeedRatio = Convert.ToDouble(PlaySpeed1.Text);
            Me1.Play();
        }

        private void btnPause1_Click(object sender, RoutedEventArgs e)
        {
            Me1.Pause();
            
        }

        private void btnLoad2_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog ofd = new System.Windows.Forms.OpenFileDialog();
            //Me2.LoadedBehavior = MediaState.Manual;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
              //  Me2.Source = new Uri(ofd.FileName);

            }
        }

        private void btnPlay2_Click(object sender, RoutedEventArgs e)
        {
           // Me2.Position = TimeSpan.FromSeconds(Convert.ToInt32(StartSec2.Text));
           // Me2.SpeedRatio = Convert.ToDouble(PlaySpeed2.Text);
           // Me2.Play();
        }

        private void btnPause2_Click(object sender, RoutedEventArgs e)
        {
           // Me2.Pause();
        }

        private void btnLoad1_Copy1_Click(object sender, RoutedEventArgs e)
        {

            System.Windows.Forms.OpenFileDialog ofd = new System.Windows.Forms.OpenFileDialog();
            Me3.LoadedBehavior = MediaState.Manual;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Me3.Source = new Uri(ofd.FileName);

            }
        }

        private void btnPlay1_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Me3.Position = TimeSpan.FromSeconds(Convert.ToInt32(StartSec3.Text));
            Me3.SpeedRatio = Convert.ToDouble(PlaySpeed3.Text);
            Me3.Play();
        }

        private void btnPause1_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Me3.Pause();
        }

        private void btnLoad1_Copy2_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog ofd = new System.Windows.Forms.OpenFileDialog();
            //Me4.LoadedBehavior = MediaState.Manual;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
              //  Me4.Source = new Uri(ofd.FileName);

            }
        }

        private void btnPlay1_Copy2_Click(object sender, RoutedEventArgs e)
        {
           // Me4.Position = TimeSpan.FromSeconds(Convert.ToInt32(StartSec4.Text));
           // Me4.SpeedRatio = Convert.ToDouble(PlaySpeed4.Text);
           // Me4.Play();
        }

        private void btnPause1_Copy2_Click(object sender, RoutedEventArgs e)
        {
           // Me4.Pause();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            switch(Convert.ToInt16(VideoNr.Text))
            {
                case 3 :

                    Me1.Visibility = Visibility.Hidden;
                    //PlaySpeed4.Visibility = Visibility.Hidden;
                    //SS4.Visibility = Visibility.Hidden;
                    //PS4.Visibility = Visibility.Hidden;
                  //  StartSec4.Visibility = Visibility.Hidden;
                  // btnPlay1_Copy2.Visibility = Visibility.Hidden;
                   // btnLoad1_Copy2.Visibility = Visibility.Hidden;
                    //btnPause1_Copy2.Visibility = Visibility.Hidden;
                    //SyncV4.Visibility = Visibility.Hidden;
                    break;

                default :
                    break;
            
            }
        }

        private void BtnSync_Click(object sender, RoutedEventArgs e)
        {
            if((SyncV1.IsChecked == true)&& (SyncV2.IsChecked == true))
            {
                Me1.Play();
               // Me2.Play();
            }
            if((SyncV1.IsChecked == true)&& (SyncV3.IsChecked == true))
            {
                Me1.Play();
                Me3.Play();

          }
            if((SyncV1.IsChecked == true)&& (SyncV4.IsChecked == true))
            {
                Me1.Play();
              //  Me4.Play();
            }
            if ((SyncV2.IsChecked == true) && (SyncV4.IsChecked == true))
            {
              //  Me2.Play();
              //  Me4.Play();
            }
            if ((SyncV3.IsChecked == true) && (SyncV4.IsChecked == true))
            {
                Me3.Play();
               // Me4.Play();
            }
            if ((SyncV3.IsChecked == true) && (SyncV2.IsChecked == true))
            {
                Me3.Play();
              //  Me2.Play();
            }
            if ((SyncV1.IsChecked == true) && (SyncV4.IsChecked == true) && (SyncV3.IsChecked == true))
            {
                Me1.Play();
                Me3.Play();
              //  Me4.Play();
            }
            if ((SyncV1.IsChecked == true) && (SyncV2.IsChecked == true) && (SyncV3.IsChecked == true))
            {
                Me1.Play();
              //  Me2.Play();
                Me3.Play();
            }
            if ((SyncV4.IsChecked == true) && (SyncV2.IsChecked == true) && (SyncV3.IsChecked == true) && (SyncV1.IsChecked == true))
            {
              //  Me4.Play();
              //  Me2.Play();
                Me3.Play();
                Me1.Play();
            }

        }
    }
}
