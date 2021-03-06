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
using System.Windows.Threading;
using Microsoft.Win32;
using System.Windows.Controls.Primitives;
using Xceed.Wpf.Toolkit.Zoombox;



namespace VideoCompare
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        DrawPanel DrawPanelWindow = new DrawPanel();
        ZoomControl ZoomControlWindow = new ZoomControl();
        OptionMenu OptionMenuWindow = new OptionMenu();
        bool IsDrawing = false;
        public bool fullscreen;
        int TimeScaler = 1;
        DispatcherTimer SyncTime = new DispatcherTimer();
        DispatcherTimer SyncEndless = new DispatcherTimer();
        
        int EndValue1;
        int EndValue2;

        int Video1PauseStatus = 0;

        int Line_index;

        int startValue1 ;
        int startValue2 ;
        int counter = 0;
        bool EndlessSync = false;
        bool SyncLoop = false;

        bool Video1Load = false;
        bool Video2Load = false;

        System.Windows.Forms.OpenFileDialog ofd1;
        public MainWindow()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();

            SyncTime.Interval = TimeSpan.FromSeconds(1);
            SyncTime.Tick += SyncTimeEvent;
            SyncTime.Start();


            SyncEndless.Interval = TimeSpan.FromSeconds(1);
            SyncEndless.Tick += SyncEndlessEvent;
            SyncEndless.Start();
           
        }

         private void SyncTimeEvent(object sender, EventArgs e)
        {
            if (SyncLoop == true)
            {
                if (counter == (Math.Abs(EndValue1 - startValue1) * TimeScaler))
                {
                    counter = 0;
                    Me1.Pause();
                    Me2.Pause();
                }
                else
                {
                    counter++;
                }
            }
            else
            {

                /*Do nothing */
            }
      
         }

         private void SyncEndlessEvent(object sender, EventArgs e)
         {

            if(EndlessSync == true)
            { 
                 if (counter == (Math.Abs(EndValue1 - startValue1) * TimeScaler))
                 {
                     counter = 0;
                     Me1.Pause();
                     Me2.Pause();

                     Me1.Position = TimeSpan.FromSeconds(Convert.ToInt32(startValue1));
                     Me2.Position = TimeSpan.FromSeconds(Convert.ToInt32(startValue2));

                     Me1.Play();
                     Me2.Play();
                    
                 }
                 else
                 {
                     counter++;
                 }
            }
            else
            {
                /*Do nothing*/
            }
             
             



         }

        private void timer_Tick(object sender, EventArgs e)
        {
            if ((Me1.Source != null) && (Me1.NaturalDuration.HasTimeSpan) )
            {
                Slider1.Minimum = 0;
                Slider1.Maximum = Me1.NaturalDuration.TimeSpan.TotalSeconds;
                Slider1.Value = Me1.Position.TotalSeconds;
            }

            if ((Me2.Source != null) && (Me2.NaturalDuration.HasTimeSpan))
            {
                Slider2.Minimum = 0;
                Slider2.Maximum = Me2.NaturalDuration.TimeSpan.TotalSeconds;
                Slider2.Value = Me2.Position.TotalSeconds;
            }
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
            ofd1 = new System.Windows.Forms.OpenFileDialog();
            Me1.LoadedBehavior = MediaState.Manual;
            if(ofd1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Me1.Source = new Uri(ofd1.FileName);
               
            }
            btnPlay1.IsEnabled = true;
            btnPause1.IsEnabled = true;

            Video1Load = true;
            
        }

        private void btnResume_Click(object sender, RoutedEventArgs e)
        {
            Me1.LoadedBehavior = MediaState.Play;
        
        }
        private void btnPlay1_Click(object sender, RoutedEventArgs e)
        {
            string LocalValue;
            int LocalValue2;
            if (btnPlay1.IsEnabled == true)
            {

                Me1.Source = new Uri(ofd1.FileName);

                Me1.SpeedRatio = Convert.ToDouble(PlaySpeed1.Text);            
            }
          
            if (OptionMenuWindow.View1StartSecond.IsChecked == true )
            {
             //   Me1.Position = TimeSpan.FromSeconds(Convert.ToInt32(StartSec1.Text));
                Me1.Position = TimeSpan.FromSeconds(Convert.ToInt32(OptionMenuWindow.View1_StartSecondTime.Text));

            }
            else
            { 
                /* Do nothing */
            }

            if (OptionMenuWindow.View_1_EnableLoop.IsChecked == true)
            {
                LocalValue = OptionMenuWindow.ListBox1.Items[0].ToString();
                LocalValue2 = Convert.ToInt32(Double.Parse(LocalValue));
                Me1.Position = TimeSpan.FromSeconds(LocalValue2);
              
            
            }

            if (btnPlay1.IsEnabled == true)
            {


                Me1.LoadedBehavior = MediaState.Play; 

            
            
            }

        }

        private void btnPause1_Click(object sender, RoutedEventArgs e)
        {
            

            switch (Video1PauseStatus)
            {
                case 1:
                {
                    Video1PauseStatus = 0;
                    Me1.LoadedBehavior = MediaState.Play;
                    btnPause1.Content = "Pause";
                    
                }
                break;

                case 0:
                {

                    Video1PauseStatus = 1;
                    Me1.LoadedBehavior = MediaState.Pause;
                    btnPause1.Content = "Resume";
                
                }

                    break;

                default :
                    break;
            
            }

          
            
        }

        private void btnLoad2_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog ofd = new System.Windows.Forms.OpenFileDialog();
            Me2.LoadedBehavior = MediaState.Manual;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Me2.Source = new Uri(ofd.FileName);

            }

            btnPlay2.IsEnabled = true;
            btnPause2.IsEnabled = true;

            Video2Load = true;
        }

        private void btnPlay2_Click(object sender, RoutedEventArgs e)
        {

            if (EnableStart_V2.IsChecked == true)
            {
                Me2.Position = TimeSpan.FromSeconds(Convert.ToInt32(StartSec2.Text));

            }
            else
            {
                /* Do nothing */
            }
    
            Me2.SpeedRatio = Convert.ToDouble(PlaySpeed2.Text);
            Me2.Play();
        }

        private void btnPause2_Click(object sender, RoutedEventArgs e)
        {
            Me2.Pause();
        }

        private void btnLoad1_Copy1_Click(object sender, RoutedEventArgs e)
        {

            
        }

        private void btnPlay1_Copy1_Click(object sender, RoutedEventArgs e)
        {
         
        }

        private void btnPause1_Copy1_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnLoad1_Copy2_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void btnPlay1_Copy2_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void btnPause1_Copy2_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
        }

        private void BtnSync_Click(object sender, RoutedEventArgs e)
        {

            if ((Video1Load == true) && (Video2Load == true))
            {
                if ((ListBox1.Items.Count == 0) && (ListBox2.Items.Count == 0))
                {
                    Me1.SpeedRatio = Convert.ToDouble(PlaySpeed.Text);
                    Me2.SpeedRatio = Convert.ToDouble(PlaySpeed.Text);

                    Me1.Play();
                    Me2.Play();
                }
                else if ((ListBox1.Items.Count % 2 == 0) && (ListBox2.Items.Count % 2 == 0))
                {
                    startValue1 = Convert.ToInt16(ListBox1.Items[0].ToString());
                    startValue2 = Convert.ToInt16(ListBox2.Items[0].ToString());

                    EndValue1 = Convert.ToInt16(ListBox1.Items[ListBox1.Items.Count - 1].ToString());
                    EndValue2 = Convert.ToInt16(ListBox1.Items[ListBox2.Items.Count - 1].ToString());

                    Me1.Position = TimeSpan.FromSeconds(Convert.ToInt32(startValue1));
                    Me2.Position = TimeSpan.FromSeconds(Convert.ToInt32(startValue2));

                    Me1.SpeedRatio = Convert.ToDouble(PlaySpeed.Text);
                    Me2.SpeedRatio = Convert.ToDouble(PlaySpeed.Text);

                    TimeScaler = Convert.ToInt16(1 / Convert.ToDouble(PlaySpeed.Text));
                    SyncLoop = true;

                    Me1.Play();
                    Me2.Play();



                    //MessageBox.Show(startValue1 + " " + EndValue1 + " " + startValue2 + " " + EndValue2);
                }
                else
                {
                    MessageBox.Show("A list box has an uneven number of values");
                }


            }
            else
            {
                MessageBox.Show("Please load both videos");
            }
        }

        private void EnableStart_V1_Checked(object sender, RoutedEventArgs e)
        {
           /* if(EnableStart_V1.IsChecked == true)
            {
                StartSec1.IsEnabled = true;
              
            }
            else
            {
            */
                /* Do nothing*/             
               
            //}
        }

        private void EnableStart_V1_Unchecked(object sender, RoutedEventArgs e)
        {
           /* BrushConverter bc = new BrushConverter();
            Brush brush = (Brush)bc.ConvertFrom("#FFFFFF");
            brush.Freeze();
            if(EnableStart_V1.IsChecked == false)
            {
                StartSec1.IsEnabled = false;
                StartSec1.Background = brush;
            }
            else
            {
               
            }
            */

        }

        private void Me1_MouseDown(object sender, MouseButtonEventArgs e)
        {
       
        }

        public bool first_click = true;
        double x = 0;
        double y = 0;
        private void Me1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {


            if(DrawPanelWindow.PenActive == true)
            {
                Line myLine = new Line();
                Point position = Mouse.GetPosition(Me1);
                myLine.Stroke = DrawPanelWindow.Color;
                myLine.Name = "Test";
                if(first_click == true)
                {
                    x= position.X;
                    y = position.Y;
                    first_click = false;
                }
                else
                {
                    myLine.X1 = x;
                    myLine.Y1 = y;
                    myLine.X2 = position.X;
                    myLine.Y2 = position.Y;
                    x = myLine.X2;
                    y = myLine.Y2;

                    myLine.HorizontalAlignment = HorizontalAlignment.Left;
                    myLine.VerticalAlignment = VerticalAlignment.Center;
                    myLine.StrokeThickness = DrawPanelWindow.WidthB;
                    DrawingBoard.Children.Add(myLine);
                }
               
                              
                
               
            }
            else if(DrawPanelWindow.LineActive == true)
            {
                IsDrawing = false;
                MoveFirstClick = true;
                
            }
            else
            {
                BrushConverter bc = new BrushConverter();
                Brush brush = (Brush)bc.ConvertFrom("#FF34495E");
                brush.Freeze();

                if (fullscreen == false)
                {

                    LayoutRoot.Children.Remove(Me1);

                    this.Background = new SolidColorBrush(Colors.Black);

                    this.Content = Me1;

                    this.WindowStyle = WindowStyle.None;



                    Me1.Width = System.Windows.SystemParameters.PrimaryScreenHeight;
                    Me1.Height = System.Windows.SystemParameters.PrimaryScreenHeight;

                    fullscreen = true;

                }

                else if (fullscreen == true)
                {


                    this.Content = LayoutRoot;

                    LayoutRoot.Children.Add(Me1);

                    this.Background = brush;

                    this.WindowStyle = WindowStyle.SingleBorderWindow;



                    Me1.Width = 650;
                    Me1.Height = 408;

                    fullscreen = false;

                }
              
            }
            
        }

        private void Slider1_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
        }

        private void Slider1_DragCompleted(object sender, DragCompletedEventArgs e)
        {
          
            Me1.Position = TimeSpan.FromSeconds(Slider1.Value);
         
        }

        private void Slider2_DragCompleted(object sender, DragCompletedEventArgs e)
        {

            Me2.Position = TimeSpan.FromSeconds(Slider2.Value);

        }

        private void Slider1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider1_Value.Text = TimeSpan.FromSeconds(Slider1.Value).ToString(@"hh\:mm\:ss\:ff");

          

            if (OptionMenuWindow.View_1_EnableLoop.IsChecked == true)
            {

                EndValue1 = Convert.ToInt16(OptionMenuWindow.ListBox1.Items[1].ToString());

                Me1.Position = TimeSpan.FromSeconds(Convert.ToInt32(Double.Parse(OptionMenuWindow.ListBox1.Items[0].ToString())));


                if (Slider1.Value > EndValue1)
                {
                    /* Pause the video */
                    Me1.LoadedBehavior = MediaState.Pause;

                    /* Set the start position */
                    Me1.Position = TimeSpan.FromSeconds(Convert.ToInt32(OptionMenuWindow.ListBox1.Items[0].ToString()));

                    /* Resume the video */
                    Me1.LoadedBehavior = MediaState.Play;

                }
                else
                { 
                /* Do nothing */
                
                }


            }

         
        }

        private void AddElement1_Click(object sender, RoutedEventArgs e)
        {
            ListBox1.Items.Add(Me1_TimeSync.Text);
        }

        private void DeleteTime_Click(object sender, RoutedEventArgs e)
        {
            ListBox1.Items.RemoveAt(ListBox1.Items.IndexOf(ListBox1.SelectedItem));
        }

        private void ClearAll1_Click(object sender, RoutedEventArgs e)
        {
            ListBox1.Items.Clear();
        }

        bool Me2_first_click = true;
        double Me2_X;
        double Me2_Y;
        private void Me2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            if(DrawPanelWindow.PenActive == true)
            {
                Line myLine = new Line();
                Point position = Mouse.GetPosition(Me1);
                myLine.Stroke = DrawPanelWindow.Color;
                myLine.Name = "Test";
                if(Me2_first_click == true)
                {
                    Me2_X= position.X;
                    Me2_Y = position.Y;
                    first_click = false;
                }
                else
                {
                    myLine.X1 = Me2_X;
                    myLine.Y1 = Me2_Y;
                    myLine.X2 = position.X;
                    myLine.Y2 = position.Y;
                    Me2_X = myLine.X2;
                    Me2_Y = myLine.Y2;

                    myLine.HorizontalAlignment = HorizontalAlignment.Left;
                    myLine.VerticalAlignment = VerticalAlignment.Center;
                    myLine.StrokeThickness = DrawPanelWindow.WidthB;
                    DrawingBoard.Children.Add(myLine);
                }
               
                              
                
               
            }
            else if(DrawPanelWindow.LineActive == true)
            {
                IsDrawing = false;
                MoveFirstClick = true;
                
            }
            else
            {

            BrushConverter bc = new BrushConverter();
            Brush brush = (Brush)bc.ConvertFrom("#FF34495E");
            brush.Freeze();

            if (fullscreen == false)
            {

                LayoutRoot.Children.Remove(Me2);

                this.Background = new SolidColorBrush(Colors.Black);

                this.Content = Me2;

                this.WindowStyle = WindowStyle.None;



                Me2.Width = System.Windows.SystemParameters.PrimaryScreenHeight;
                Me2.Height = System.Windows.SystemParameters.PrimaryScreenHeight;

          
                fullscreen = true;

            }

            else if (fullscreen == true)
            {


                this.Content = LayoutRoot;

                LayoutRoot.Children.Add(Me2);

                this.Background = brush;

                this.WindowStyle = WindowStyle.SingleBorderWindow;



                Me2.Width = 650;
                Me2.Height = 408;

                fullscreen = false;
            }
            }
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            BrushConverter bc = new BrushConverter();
            Brush brush = (Brush)bc.ConvertFrom("#FFFFFF");
            brush.Freeze();
            if (EnableStart_V2.IsChecked == false)
            {
                StartSec2.IsEnabled = false;
                StartSec2.Background = brush;
            }
            else
            {
                /* Do mothing */
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (EnableStart_V2.IsChecked == true)
            {
                StartSec2.IsEnabled = true;

            }
            else
            {
                /* Do nothing*/

            }
        }

        private void Slider2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider2_Value.Text = TimeSpan.FromSeconds(Slider2.Value).ToString(@"hh\:mm\:ss\:ff");
        }

        private void AddElement2_Click(object sender, RoutedEventArgs e)
        {
            ListBox2.Items.Add(Me2_TimeSync.Text);
        }

        private void DeleteTime_Copy_Click(object sender, RoutedEventArgs e)
        {
            ListBox2.Items.RemoveAt(ListBox2.Items.IndexOf(ListBox2.SelectedItem));
        }

        private void ClearAll2_Click(object sender, RoutedEventArgs e)
        {
            ListBox2.Items.Clear();
        }

        private void BtnSync_Pause_Click(object sender, RoutedEventArgs e)
        {

            if ((Video1Load == true) && (Video2Load == true))
            {
                SyncLoop = false;

                Me1.Pause();
                Me2.Pause();
            }
            else
            {
                MessageBox.Show("Pease load both videos");
            }
        }

        private void BtnEndlessLoop_Play_Click(object sender, RoutedEventArgs e)
        {
            if ((Video1Load == true) && (Video2Load == true))
            {

                if ((SyncV1.IsChecked == true) && (SyncV2.IsChecked == true))
                {

                    if ((ListBox1.Items.Count == 0) && (ListBox2.Items.Count == 0))
                    {
                        Me1.SpeedRatio = Convert.ToDouble(PlaySpeed.Text);
                        Me2.SpeedRatio = Convert.ToDouble(PlaySpeed.Text);

                        Me1.Play();
                        Me2.Play();
                    }
                    else if ((ListBox1.Items.Count % 2 == 0) && (ListBox2.Items.Count % 2 == 0))
                    {
                        startValue1 = Convert.ToInt16(ListBox1.Items[0].ToString());
                        startValue2 = Convert.ToInt16(ListBox2.Items[0].ToString());

                        EndValue1 = Convert.ToInt16(ListBox1.Items[ListBox1.Items.Count - 1].ToString());
                        EndValue2 = Convert.ToInt16(ListBox1.Items[ListBox2.Items.Count - 1].ToString());

                        Me1.Position = TimeSpan.FromSeconds(Convert.ToInt32(startValue1));
                        Me2.Position = TimeSpan.FromSeconds(Convert.ToInt32(startValue2));

                        Me1.SpeedRatio = Convert.ToDouble(PlaySpeed.Text);
                        Me2.SpeedRatio = Convert.ToDouble(PlaySpeed.Text);

                        TimeScaler = Convert.ToInt16(1 / Convert.ToDouble(PlaySpeed.Text));
                        EndlessSync = true;
                        Me1.Play();
                        Me2.Play();

                    }
                    else
                    {
                        MessageBox.Show("A list box has an uneven number of values");
                    }
                }
                else if (SyncV1.IsChecked == true)
                {

                    startValue1 = Convert.ToInt16(ListBox1.Items[0].ToString());
                    EndValue1 = Convert.ToInt16(ListBox1.Items[ListBox1.Items.Count - 1].ToString());
                    Me1.Position = TimeSpan.FromSeconds(Convert.ToInt32(startValue1));
                    Me1.SpeedRatio = Convert.ToDouble(PlaySpeed.Text);
                    TimeScaler = Convert.ToInt16(1 / Convert.ToDouble(PlaySpeed.Text));
                    EndlessSync = true;
                    Me1.Play();

                }
                else if (SyncV2.IsChecked == true)
                {
                    startValue2 = Convert.ToInt16(ListBox2.Items[0].ToString());
                    EndValue2 = Convert.ToInt16(ListBox2.Items[ListBox2.Items.Count - 1].ToString());
                    Me2.Position = TimeSpan.FromSeconds(Convert.ToInt32(startValue2));
                    Me2.SpeedRatio = Convert.ToDouble(PlaySpeed.Text);
                    TimeScaler = Convert.ToInt16(1 / Convert.ToDouble(PlaySpeed.Text));
                    EndlessSync = true;
                    Me2.Play();
                }
                else
                {
                    MessageBox.Show("No video was selected");
                }

            }
            else
            {
                MessageBox.Show("Please load both videos");
            }
        }

        private void BtnEndlessLoop_Pause_Click(object sender, RoutedEventArgs e)
        {
            if ((Video1Load == true) && (Video2Load == true))
            {
                if ((SyncV1.IsChecked == true) && (SyncV2.IsChecked == true))
                {
                    Me1.Pause();
                    Me2.Pause();
                }
                else if (SyncV1.IsChecked == true)
                {
                    Me1.Pause();
                }
                else if (SyncV2.IsChecked == true)
                {
                    Me2.Pause();
                }
                else
                {
                    MessageBox.Show("No video was selected");
                }

                EndlessSync = false;
            }
            else
            {
                MessageBox.Show("Please load both videos");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Me1Mute_Checked(object sender, RoutedEventArgs e)
        {
            Me1.Volume = 0;
        }

        private void Me1Mute_Unchecked(object sender, RoutedEventArgs e)
        {
            Me1.Volume = 100;
        }

        private void Me2Mute_Unchecked(object sender, RoutedEventArgs e)
        {
            Me2.Volume = 100;
                 
        }

        private void Me2Mute_Checked(object sender, RoutedEventArgs e)
        {
            Me2.Volume = 0;
        }

        private void Test_Click(object sender, RoutedEventArgs e)
        {
           Line myLine = new Line();
            //myLine.Stroke = System.Windows.Media.Brushes.LightSteelBlue;
            //Brush Color = new SolidColorBrush(ColorPick.SelectedColor);
           // myLine.Stroke = Color;
            myLine.Name = "Test";
            myLine.X1 = 1;
            myLine.X2 = 50;
            myLine.Y1 = 1;
            myLine.Y2 = 50;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 6;
            DrawingBoard.Children.Add(myLine);

            
        }

        private void AppRestart(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.Application.Restart();
            System.Windows.Application.Current.Shutdown();
        }

        private void AppShutdown(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void OpenDraw(object sender, RoutedEventArgs e)
        {
            
            DrawPanelWindow.Show();
        }

        private void OptionMenu_Click(object sender, RoutedEventArgs e)
        {

            OptionMenuWindow.Show();
        }

        private void Test_Copy_Click(object sender, RoutedEventArgs e)
        {
           // foreach(Line ui in DrawingBoard.Children)
           /* UIElement x = null;
            for (int ite = DrawingBoard.Children.Count - 1; ite >= 0; ite -- )
            {
                x = DrawingBoard.Children[ite];
                if (x. == "Test")
                {
                    DrawingBoard.Children.Remove(ui);
                }
            }
            */

            //DrawingBoard.Children.RemoveAt(0);

            
        }

        double MoveX = 0;
        double MoveY = 0;
        bool MoveFirstClick = true;
        private void Me1_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (IsDrawing == true)
            {
                
                Line myLine = new Line();
                Point position = Mouse.GetPosition(Me1);

                myLine.Stroke = DrawPanelWindow.Color;
                myLine.Name = "Test";
                if (MoveFirstClick == true)
                {
                    MoveX = position.X;
                    MoveY = position.Y;
                    MoveFirstClick = false;
                }
                else
                {
                    myLine.X1 = MoveX;
                    myLine.Y1 = MoveY;
                    myLine.X2 = position.X;
                    myLine.Y2 = position.Y;
                    MoveX = myLine.X2;
                    MoveY = myLine.Y2;

                    myLine.HorizontalAlignment = HorizontalAlignment.Left;
                    myLine.VerticalAlignment = VerticalAlignment.Center;
                    myLine.StrokeThickness = DrawPanelWindow.WidthB;
                    DrawingBoard.Children.Add(myLine);
                }
            }else
            {

            }
        }

        private void Me1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (DrawPanelWindow.LineActive == true)
            {
                IsDrawing = true;
            }
        }

        private void Me1_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            IsDrawing = false;
            MoveFirstClick = true;
        }

        private void Me1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            IsDrawing = false;
            MoveFirstClick = true;
        }

        bool Me2MoveFirstClick = true;
        double Me2MoveX;
        double Me2MoveY;
        private void Me2_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsDrawing == true)
            {

                Line myLine = new Line();
                Point position = Mouse.GetPosition(Me1);

                myLine.Stroke = DrawPanelWindow.Color;
                myLine.Name = "Test";
                if (Me2MoveFirstClick == true)
                {
                    Me2MoveX = position.X;
                    Me2MoveY = position.Y;
                    MoveFirstClick = false;
                }
                else
                {
                    myLine.X1 = Me2MoveX;
                    myLine.Y1 = Me2MoveY;
                    myLine.X2 = position.X;
                    myLine.Y2 = position.Y;
                    Me2MoveX = myLine.X2;
                    Me2MoveY = myLine.Y2;

                    myLine.HorizontalAlignment = HorizontalAlignment.Left;
                    myLine.VerticalAlignment = VerticalAlignment.Center;
                    myLine.StrokeThickness = DrawPanelWindow.WidthB;
                    DrawingBoard.Children.Add(myLine);
                }
            }
            else
            {

            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Point ellipse = new Point(80, 80);
            Me1.Clip = new EllipseGeometry(ellipse, 30, 30);
            Me1.ClipToBounds = true;
            Me1.Stretch = Stretch.UniformToFill;

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            ZoomControlWindow.Show();
        }

        private void btnOptions_Click(object sender, RoutedEventArgs e)
        {
            OptionMenuWindow.Show();
        }

        private void Me1_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            OptionMenuWindow.ListBox1.Items.Add(Slider1.Value);

        }
    }
}
