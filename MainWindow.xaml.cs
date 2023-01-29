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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Button button1 = new Button();
            button1.Content = "pulsa!";
            button1.Height = 50;
            button1.Width = 200;
            button1.HorizontalAlignment = HorizontalAlignment.Center;
            button1.VerticalAlignment = VerticalAlignment.Center;
            button1.FontSize = 18;
            button1.HorizontalContentAlignment = HorizontalAlignment.Center;
            button1.VerticalContentAlignment = VerticalAlignment.Center;
            button1.Click += Button1_Click;

            grid1.Children.Add(button1);


        }


        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            hello.Content = "Hello World!";
        }
    }
}
