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

namespace koostava_marialintunen
{
    /// <summary>
    /// Interaction logic for notepadWindow.xaml
    /// </summary>
    public partial class notepadWindow : Window
    {

        fontWindow fontwindow;

        public notepadWindow()
        {
            InitializeComponent();
        }

        //Open-painike
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            // OpenFileDialog
            var dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.ShowDialog();

            if (dialog.ShowDialog() == true)
            {
                using (var reader = new StreamReader(dialog.FileName))
                {
                    notepadTextBox.Text = reader.ReadToEnd();
                }
            }
        }

        //Save-painike
        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            var SaveAs = new Microsoft.Win32.SaveFileDialog();
            Nullable<bool> result = SaveAs.ShowDialog();

            if (result == true)
            {
                var filename = SaveAs.FileName;
                var file = File.Open(filename, FileMode.OpenOrCreate);
                var saving = new BinaryWriter(file);
                saving.Write(notepadTextBox.Text);
                saving.Close();
            }
        }

        private void Print_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)
            {
                printDialog.PrintVisual(notepadTextBox, "Print");
            }

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void fontButton_Click(object sender, RoutedEventArgs e)
        {
            fontwindow = new fontWindow();
            fontwindow.ShowDialog();
        }

        public void changeFontwhenOk()
        {
            notepadTextBox.FontSize = Convert.ToDouble(fontwindow.fontBox.Text);
        }

    }
}

