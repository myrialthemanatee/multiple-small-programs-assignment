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
using System.Windows.Shapes;

namespace koostava_marialintunen
{
    /// <summary>
    /// Interaction logic for olympiarenkaatWindow.xaml
    /// </summary>
    public partial class olympiarenkaatWindow : Window
    {
        public olympiarenkaatWindow()
        {
            InitializeComponent();
        }



        private void scatterButton_Click(object sender, RoutedEventArgs e)
        {
            OlympiaCanvas.SetXY(300, 200);
            OlympiaCanvas.SetXY2(50, 300);
            OlympiaCanvas.SetXY3(250, 300);
            OlympiaCanvas.SetXY4(400, 280);
            OlympiaCanvas.SetXY5(200, 100);

        }
    }
}
