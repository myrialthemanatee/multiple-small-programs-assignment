using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Ink;
using Microsoft.Win32;

namespace koostava_marialintunen
{
    /// <summary>
    /// Interaction logic for piirtopeliWindow.xaml
    /// </summary>
    public partial class piirtopeliWindow : Window
    {
        public piirtopeliWindow()
        {
            InitializeComponent();
        }

        private void Canvas_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
                { }

        private InkCanvas GetInkCanvas()
        {
            return inkCanvas;
        }

        
        private void tallennaClick(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "isf files (*.isf)|*.isf";

            if (saveFileDialog1.ShowDialog() == true)
            {
                FileStream fs = new FileStream(saveFileDialog1.FileName,
                                               FileMode.Create);
                inkCanvas.Strokes.Save(fs);
                fs.Close();
            }
        }

        private void tyhjennaClick(object sender, RoutedEventArgs e)
        {
            inkCanvas.Strokes.Clear();
        }

        private void peruutaClick(object sender, RoutedEventArgs e)
        {

        }

        private void avaaClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "isf files (*.isf)|*.isf";

            if (openFileDialog1.ShowDialog() == true)
            {
                FileStream fs = new FileStream(openFileDialog1.FileName,
                                               FileMode.Open);
                inkCanvas.Strokes = new StrokeCollection(fs);
                fs.Close();
            }
        }
    }
}
