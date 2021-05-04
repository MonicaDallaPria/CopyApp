using System.IO;

namespace CopyLogic
{
    public class CopyLogic
    {
        public void Copy(string sourceDirectory, string targetDirectory, string fileName)
        {

            string sourcePath = sourceDirectory;
            string targetPath = targetDirectory;

            string sourceFile = Path.Combine(sourcePath, fileName);
            string destFile = Path.Combine(targetPath, fileName);

            Directory.CreateDirectory(targetPath);

            if (Directory.Exists(sourcePath))
            {
                string[] files = System.IO.Directory.GetFiles(sourcePath);

                // Copy the files and overwrite destination files if they already exist.
                foreach (string s in files)
                {
                    // Use static Path methods to extract only the file name from the path.
                    fileName = Path.GetFileName(s);
                    destFile = Path.Combine(targetPath, fileName);
                    File.Copy(s, destFile, true);
                    System.Windows.Forms.MessageBox.Show("Files loaded: " + s.ToString() + " from " + sourceFile + " to " + targetPath, "Message");
                }
            }
        }

    }
}
