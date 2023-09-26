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
    /// Interaction logic for fontWindow.xaml
    /// </summary>
    public partial class fontWindow : Window
    {
        public fontWindow()
        {
            InitializeComponent();
        }
        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            notepadWindow kokoava_notepad = Application.Current.Windows.OfType<notepadWindow>().FirstOrDefault();
            if (kokoava_notepad != null)
            {
                kokoava_notepad.changeFontwhenOk();
            }
            Close();
        }

    }
}
