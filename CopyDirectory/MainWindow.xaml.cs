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
        string fileRoot = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        public void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                 fileRoot = fbd.RootFolder.ToString();
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
            CopyTo logic = new CopyTo();
            string fileName = fileRoot;
            string sourceDirectory = fileSource.Text;
            string targetDirectory = fileDestination.Text;
            logic.Copy(sourceDirectory, targetDirectory, fileName);            
        }
    }
}

