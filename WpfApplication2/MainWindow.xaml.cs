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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            /*foreach (object item in st01.Children)
            {
                //if (item.GetType() is Button)
                Button btn = (Button)item;
                
            }*/
            pic01.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\user\Documents\visual studio 2015\Projects\WpfApplication2\WpfApplication2\images\01.png")));
            pic02.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\user\Documents\visual studio 2015\Projects\WpfApplication2\WpfApplication2\images\02.png")));
            pic03.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\user\Documents\visual studio 2015\Projects\WpfApplication2\WpfApplication2\images\03.png")));
            pic04.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\user\Documents\visual studio 2015\Projects\WpfApplication2\WpfApplication2\images\04.png")));
            pic05.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\user\Documents\visual studio 2015\Projects\WpfApplication2\WpfApplication2\images\05.png")));
        }
    }
}
