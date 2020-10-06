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
            SaveFileDialog save = new Microsoft.Win32.SaveFileDialog();
            save.FileName = "text_file"; 
            save.DefaultExt = ".txt"; 
            save.Filter = "Text documents (.txt)|*.txt"; 
            Nullable<bool> res = save.ShowDialog();
                string filename = save.FileName;
            System.IO.File.WriteAllText(filename, TextBox.Text);
        }

        private void Copy_Click(object sender, RoutedEventArgs e)
        {
            copytext = TextBox.SelectedText;
        }

        private void Paste_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += copytext;
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            open.ShowDialog();
            string filename = open.FileName;
            TextBox.Text = System.IO.File.ReadAllText(filename);
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            string text = "Do you want to save file?";
            MessageBoxButton button = MessageBoxButton.YesNoCancel;
            string caption = "Save changes";
            MessageBoxImage icon = MessageBoxImage.Warning;
            MessageBoxResult result = MessageBox.Show(text, caption, button, icon);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    {
                        SaveFileDialog save = new Microsoft.Win32.SaveFileDialog();
                        save.FileName = "text_file";
                        save.DefaultExt = ".txt";
                        save.Filter = "Text documents (.txt)|*.txt";
                        Nullable<bool> res = save.ShowDialog();
                        string filename = save.FileName;
                        System.IO.File.WriteAllText(filename, TextBox.Text);
                    }
                    break;
                case MessageBoxResult.No:
                    TextBox.Text = "";
                    break;
                case MessageBoxResult.Cancel:
                    break;
            }

            
        }

        private void Cut_Click(object sender, RoutedEventArgs e)
        {
            copytext = TextBox.SelectedText;
            TextBox.SelectedText = "";
        }
    }
}
