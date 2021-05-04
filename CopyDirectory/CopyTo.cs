using LogicLibrary;
using System.IO;

namespace CopyDirectory
{
    public class CopyTo
    {
        public void Copy(string sourceDirectory, string targetDirectory, string fileName)
        {
            var copyLogic = new CopyLogic();
            copyLogic.Copy(sourceDirectory, targetDirectory, fileName);

        }

    }

}



