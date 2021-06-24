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
        public bool LineActive = false;
        public Brush Color;
        public int WidthB = 2;
        public DrawPanel()
        {
            InitializeComponent();
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            Color = new SolidColorBrush(ColorPick.SelectedColor);
            WidthB = Convert.ToInt16(WidthBox.Text);
            if (LineActive == false)
            {
                LineActive = true;

            }
            else
            {
                LineActive = false;
            }
        }

        private void Button_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Color = new SolidColorBrush(ColorPick.SelectedColor);
            WidthB = Convert.ToInt16(WidthBox.Text);
            if (PenActive == false)
                PenActive = true;
            else
            {
                PenActive = false;
            }
        }

        private void Image_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            Color = new SolidColorBrush(ColorPick.SelectedColor);
            WidthB = Convert.ToInt16(WidthBox.Text);
            if (PenActive == false)
                PenActive = true;
            else
            {
                PenActive = false;
            }
            
        }

        private void ColorPick_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
