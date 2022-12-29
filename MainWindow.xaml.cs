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

namespace starpractice_project
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
            StringBuilder stringBuilder = new StringBuilder();

            int x, y, z;
            for (x = 6; x >= 1; x--)
            {
                for (y = 1; y < x; y++)
                {
                    stringBuilder.Append("");
                }

                stringBuilder.Append("\n");
                for (z = 6; z >= x; z--)
                {
                    stringBuilder.Append("*");
                }
            }
            MessageBox.Show(stringBuilder.ToString());



        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();

            int a, b, c;
            for (a = 6; a >= 1; a--)
            {
                for (b = 6; b > a; b--)
                {
                    stringBuilder.Append("");
                }

                stringBuilder.Append("\n");
                for (c = 1; c <= a; c++)
                {
                    stringBuilder.Append("*");
                }
            }
            MessageBox.Show(stringBuilder.ToString());


        }
    }
} 
