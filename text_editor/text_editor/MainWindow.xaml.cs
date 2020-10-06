using Microsoft.Win32;
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

namespace text_editor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string copytext;
        public string path;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Window.Close();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "text_file";
            save.DefaultExt = ".txt";
            save.Filter = "Text documents (.txt)|*.txt";
            Nullable<bool> result = save.ShowDialog();
        }

        private void Copy_Click(object sender, RoutedEventArgs e)
        {
            copytext = TextBox.Text;
        }

        private void Paste_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = copytext;
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            Nullable<bool> result = open.ShowDialog();
            string filename = open.FileName;
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = "";
        }
    }
}
