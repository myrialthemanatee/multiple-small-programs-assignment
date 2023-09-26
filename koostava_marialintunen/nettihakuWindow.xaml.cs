using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
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
using System.Xml;
using Microsoft.Web.WebView2.Core;

namespace koostava_marialintunen
{
    /// <summary>
    /// Interaction logic for nettihakuWindow.xaml
    /// </summary>
    public partial class nettihakuWindow : Window
    {
        readonly HttpClient client = new HttpClient();
        public nettihakuWindow()
        {
            InitializeComponent();
        }


        private void meneButton_Click(object sender, RoutedEventArgs e)
        {
            webView.CoreWebView2.Navigate(addressBar.Text); 
        }

        private async void jokuButton_Click(object sender, RoutedEventArgs e)
        {
            string responseBody = await client.GetStringAsync(addressBar.Text);
            MessageBox.Show(responseBody.Substring(0,50));
        }
    }
}
