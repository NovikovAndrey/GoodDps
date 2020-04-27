using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GoodDps
{
    /// <summary>
    /// Interaction logic for Path_indication.xaml
    /// </summary>
    public partial class Path_indication : Window
    {
        public Path_indication()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var Path = new OpenFileDialog();
            Path.Filter = "WOW Launcher (World of Warcraft Launcher.exe)|World of Warcraft Launcher.exe";
            if (Path.ShowDialog()==true)
            {
                PathFolder.Text = Path.FileName;
            }
        }
    }
}
