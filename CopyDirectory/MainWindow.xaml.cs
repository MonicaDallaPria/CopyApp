using Microsoft.Win32;
using Ookii.Dialogs.Wpf;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;



namespace CopyDirectory
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string DestFileName { get; private set; }
        List<string> filelist = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
        }

        public void Button_Click_1(object sender, RoutedEventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string file = fbd.SelectedPath;
                    {
                     fileSource.Text = file; // lbFiles.Items.Add(Path.GetFileName(filename)); 
                    }
                }
            }
        }

        public void Button_Click_2(object sender, RoutedEventArgs e)
        {
            using (var fbd2 = new FolderBrowserDialog())
            {
                DialogResult result = fbd2.ShowDialog();
                if (fbd2.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string file = fbd2.SelectedPath;
                    {
                        fileDestination.Text = file; // lbFiles.Items.Add(Path.GetFileName(filename)); 
                    }
                }
            }
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            string sourceDirectory = fileSource.Text;
            string targetDirectory = fileDestination.Text;

            //Task.Run(() =>
            //{
            //   Copy(targetDirectory, x => progressBar.Dispatcher.BeginInvoke(new Action(() => { progressBar.Value = x; lblPercent.Content = x.ToString() + "%"; })));
            //}).GetAwaiter().OnCompleted(() => progressBar.Dispatcher.BeginInvoke(new Action(() => { progressBar.Value = 100; lblPercent.Content = "100%"; MessageBox.Show("You have successfully copied the file !", "Message", MessageBoxButton.OK, MessageBoxImage.Information); })));
        }
    }
}

