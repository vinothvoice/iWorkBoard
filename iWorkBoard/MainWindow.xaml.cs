using System;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Web;

namespace iWorkBoard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            button8.Content = DateTime.Now.Date;
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0,0,1);
            dispatcherTimer.Start();
            try
            {
                string[] args = Environment.GetCommandLineArgs();
                if (args.Length == 2)
                {
                    string filename = args[1];
                    FileStream istr = new FileStream(filename, FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(istr);

                    textBox3.Text = sr.ReadLine();
                    textBox1.Text = sr.ReadLine();
                    textBox11.Text = sr.ReadLine();
                    textBox10.Text = sr.ReadLine();
                    textBox9.Text = sr.ReadLine();
                    textBox8.Text = sr.ReadLine();
                    textBox2.Text = sr.ReadLine();
                    textBox6.Text = sr.ReadLine();
                    textBox5.Text = sr.ReadLine();
                    textBox17.Text = sr.ReadLine();
                    textBox16.Text = sr.ReadLine();
                    textBox15.Text = sr.ReadLine();
                    textBox4.Text = "";
                    textBox4.AppendText(sr.ReadToEnd());
                    sr.Close();
                    istr.Close();
                    
                }
            }
            catch (Exception ev)
            {
                MessageBox.Show(ev.Message);
            }
            
        }
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {            
            button9.Content = DateTime.Now.TimeOfDay;
        }
        
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (calendar1.Visibility==Visibility.Hidden)
                calendar1.Visibility = Visibility.Visible;
            else
                calendar1.Visibility = Visibility.Hidden;
        }

       private void textBox18_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            canvas1.EditingMode = InkCanvasEditingMode.EraseByPoint;
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
           canvas1.Strokes.Clear();  
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            canvas1.EditingMode = InkCanvasEditingMode.Ink;
        }

        private void button12_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                webBrowser1.Source = new Uri("http://www.google.com/search?q=Google");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                webBrowser1.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                webBrowser1.GoForward();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox10_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Microsoft.Win32.SaveFileDialog Sdlg = new Microsoft.Win32.SaveFileDialog();
                Nullable<bool> Re = Sdlg.ShowDialog();
                Sdlg.DefaultExt = ".iwb";
                
                if (Re == true)
                {
                    string filename = Sdlg.FileName;                   
                    FileStream ou = new FileStream(filename+".iwb", FileMode.Create, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(ou);
                    sw.WriteLine(textBox3.Text);
                    sw.WriteLine(textBox1.Text);
                    sw.WriteLine(textBox11.Text);
                    sw.WriteLine(textBox10.Text);
                    sw.WriteLine(textBox9.Text);
                    sw.WriteLine(textBox8.Text);
                    sw.WriteLine(textBox2.Text);
                    sw.WriteLine(textBox6.Text);
                    sw.WriteLine(textBox5.Text);
                    sw.WriteLine(textBox17.Text);
                    sw.WriteLine(textBox16.Text);
                    sw.WriteLine(textBox15.Text);
                    sw.WriteLine(textBox4.Text);
                    sw.Close();
                    ou.Close();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog Odlg = new Microsoft.Win32.OpenFileDialog();
            Odlg.DefaultExt = ".iwb";
            Nullable<bool> Re = Odlg.ShowDialog();
            if (Re == true)
            {
                string filename = Odlg.FileName;
                FileStream istr = new FileStream(filename,FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(istr);
               
               textBox3.Text=sr.ReadLine();
               textBox1.Text=sr.ReadLine();
               textBox11.Text=sr.ReadLine();
               textBox10.Text=sr.ReadLine();
               textBox9.Text=sr.ReadLine();
               textBox8.Text=sr.ReadLine();
               textBox2.Text=sr.ReadLine();
               textBox6.Text=sr.ReadLine();
               textBox5.Text=sr.ReadLine();
               textBox17.Text=sr.ReadLine();
               textBox16.Text=sr.ReadLine();
               textBox15.Text=sr.ReadLine();
               textBox4.Text = "";
               textBox4.AppendText(sr.ReadToEnd());
               sr.Close();
               istr.Close();
            }

        }

        private void button13_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                textBox4.Width = double.NaN;
                textBox4.Height = double.NaN;
                textBox4.HorizontalAlignment = HorizontalAlignment.Stretch;
                textBox4.VerticalAlignment = VerticalAlignment.Stretch;
                textBox4.Margin = new Thickness(0, 0, 0, 0);
                webBrowser1.Visibility = Visibility.Hidden;
                button13.Visibility = Visibility.Hidden;
                button14.Visibility = Visibility.Visible;
            }
            catch (Exception as1)
            {
                MessageBox.Show(as1.Message);
            }
          
        }

        private void button14_Click(object sender, RoutedEventArgs e)
        {
            textBox4.Width =331;
            textBox4.Height =229;
            textBox4.HorizontalAlignment = HorizontalAlignment.Left;
            textBox4.VerticalAlignment = VerticalAlignment.Bottom;
            textBox4.Margin = new Thickness(21, 0, 0, 18);
            webBrowser1.Visibility = Visibility.Visible;
            button13.Visibility = Visibility.Visible;
            button14.Visibility = Visibility.Hidden; 
        }

        private void image1_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            
            image1.Visibility = Visibility.Visible;
            button15.Visibility = Visibility.Visible;
            webBrowser1.Visibility = Visibility.Hidden;
        }

        private void button15_Click(object sender, RoutedEventArgs e)
        {
            image1.Visibility = Visibility.Hidden;
            button15.Visibility = Visibility.Hidden;
            webBrowser1.Visibility = Visibility.Visible;
        }
        
    }
}
