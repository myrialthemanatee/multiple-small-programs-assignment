using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
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
    record Puujalka(string puujalka);
    /// <summary>
    /// Interaction logic for puujalkaWindow.xaml
    /// </summary>
    public partial class puujalkaWindow : Window
    {

        List<Puujalka> puujalkalista = new List<Puujalka>();

        public puujalkaWindow()
        {
            InitializeComponent();
        }

        
        private void randomButton_Click(object sender, RoutedEventArgs e)
        {

            System.Random rnd = new System.Random();

            int index = rnd.Next(puujalkalista.Count);
            VitsiTextBox.Text = puujalkalista[index].puujalka;

        }

        private void TallennaButton_Click(object sender, RoutedEventArgs e)
        {
            puujalkalista.Add(new Puujalka(omaVitsiBox.Text));
            omaVitsiBox.Clear();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            File.WriteAllText("puujalka.json", JsonSerializer.Serialize(puujalkalista));
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (File.Exists("puujalka.json"))
            {
                puujalkalista = JsonSerializer.Deserialize<List<Puujalka>>(File.ReadAllText("puujalka.json"));
            }
        }
    }
}
