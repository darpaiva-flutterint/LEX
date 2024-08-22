using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LogExtractor
{
    internal class FolderCreator
    {
        // This class creates the folders locally

        public static void createFolder(string table, string destinationFileLocation)
        {
            // Specify the directory you want to manipulate.
            string path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

            try
            {
                // Determine whether the directory exists.
                if (!Directory.Exists(path + "\\Logs\\"))
                {
                    DirectoryInfo di = Directory.CreateDirectory(path + "\\Logs\\");   
                }
                if (!Directory.Exists(destinationFileLocation + "\\Logs\\" + table))
                {
                    DirectoryInfo diTable = Directory.CreateDirectory(destinationFileLocation + "\\Logs\\" + table);
                } else
                {
                    return;
                }
                //DirectoryInfo di2 = Directory.CreateDirectory(path);
                //Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(path));

                // To delete the directory use:
                //di.Delete();
                //Console.WriteLine("The directory was deleted successfully.");
            }
            catch (Exception e)
            {
                //Console.WriteLine("The process failed: {0}", e.ToString());
            }
            finally { }
        }
    }
}
