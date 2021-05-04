using System;
using MainWindow.xaml.cs
using System.IO;

namespace CopyDirectory 
{

    static void Main(string[] args)
    {
        string sourceDirectory = fileSource.Text;
        string targetDirectory = fileDestination.Text;
    }

    public class Program
    {
        public static void Copy(string sourceDirectory, string targetDirectory)
        {
            var diSource = new DirectoryInfo(sourceDirectory);
            var diTarget = new DirectoryInfo(targetDirectory);

            var copyLogic = new CopyTo();

            copyLogic.Copy(diSource, diTarget);
        }
    }
}