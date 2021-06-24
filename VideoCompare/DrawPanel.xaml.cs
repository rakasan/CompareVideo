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
    /// Interaction logic for DrawPanel.xaml
    /// </summary>
    public partial class DrawPanel : Window
    {

        public bool PenActive = false;
     
        public DrawPanel()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PenActive = true;

          
        }
    }
}
