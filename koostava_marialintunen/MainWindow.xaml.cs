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

namespace koostava_marialintunen
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

        private void LaskinButton_Click(object sender, RoutedEventArgs e)
        {
            LaskinWindow laskinwindow = new LaskinWindow();
            laskinwindow.ShowDialog();
        }

        private void NotePadButton_Click(object sender, RoutedEventArgs e)
        {
            notepadWindow kokoava_notepad = new notepadWindow();
            kokoava_notepad.ShowDialog();
        }

        private void OlympiarenkaatButton_Click(object sender, RoutedEventArgs e)
        {
            olympiarenkaatWindow olympiawindow = new olympiarenkaatWindow();
            olympiawindow.ShowDialog();
        }

        private void PiirtoButton_Click(object sender, RoutedEventArgs e)
        {
            piirtopeliWindow piirtowindow = new piirtopeliWindow();
            piirtowindow.ShowDialog();
        }

        private void NettihakuButton_Click(object sender, RoutedEventArgs e)
        {
            nettihakuWindow nettiwindow = new nettihakuWindow();
            nettiwindow.ShowDialog();
        }

        private void PuujalkaButton_Click(object sender, RoutedEventArgs e)
        {
            puujalkaWindow puujalkawindow = new puujalkaWindow();
            puujalkawindow.ShowDialog();
        }
    }
}
