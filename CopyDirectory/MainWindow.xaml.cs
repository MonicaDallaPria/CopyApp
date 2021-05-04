using System.Collections.Generic;
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
                     fileSource.Text = file;
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
                        fileDestination.Text = file; 
                    }
                }
            }
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            CopyTo _logic = new CopyTo();
            string sourceDirectory = fileSource.Text;
            string targetDirectory = fileDestination.Text;
            _logic.Copy(sourceDirectory, targetDirectory);            
        }
    }
}

