using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace VideoCompare
{
    /// <summary>
    /// Interaction logic for OptionMenu.xaml
    /// </summary>
    public partial class OptionMenu : Window
    {
        public OptionMenu()
        {
            InitializeComponent();
        }

        private void DeleteTime_1_Click(object sender, RoutedEventArgs e)
        {
            ListBox1.Items.RemoveAt(ListBox1.Items.IndexOf(ListBox1.SelectedItem));
        }

        private void DeleteTime_2_Click(object sender, RoutedEventArgs e)
        {

        }


        private void DeleteTime_4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteTime_3_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
