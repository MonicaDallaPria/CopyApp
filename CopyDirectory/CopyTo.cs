using System;
using System.IO;


namespace CopyDirectory
{

    public class CopyTo
    {
        public void Copy(string sourceDirectory, string targetDirectory, string fileName)
        {

            string sourcePath = sourceDirectory;
            string targetPath = targetDirectory;

            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);

            System.IO.Directory.CreateDirectory(targetPath);

            if (System.IO.Directory.Exists(sourcePath))
            {
                string[] files = System.IO.Directory.GetFiles(sourcePath);

                // Copy the files and overwrite destination files if they already exist.
                foreach (string s in files)
                {
                    // Use static Path methods to extract only the file name from the path.
                    fileName = System.IO.Path.GetFileName(s);
                    destFile = System.IO.Path.Combine(targetPath, fileName);
                    System.IO.File.Copy(s, destFile, true);
                    System.Windows.Forms.MessageBox.Show("Files loaded: " + s.ToString(), "Message");
                }
            }
            }

        }

    }



