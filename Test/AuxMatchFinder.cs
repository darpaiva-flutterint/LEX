using System.Linq;
using System.IO;
using System.Collections;
using LEX;
using File = System.IO.File;
using System.Windows.Forms;
using System.Runtime.Remoting.Contexts;

namespace LogExtractor
{
    internal class AuxMatchFinder
    {
        public void copyAux(string table, string env, string destinationFileLocation, string itSelection, string multiLogSelection)
        {
            bool fileFound = false;
            bool fileFoundIT = false;
            var localListOfObjectsFiles = new ArrayList();

            // Creating patterns to search for needed files from locations
            string patternTableID = "*" + table + "*";
            string patternListOfObjects = "listofobjects" + "*";
            string patternMultiLogs = "CASF_" + "*";
            string patternIT = "AuxAamsGatewayServerInstance.log." + "*";
            int dateItaly = 0;
            int dateItalyMax = 0;
            string fileNameItaly = "";

            string multiLogName = "";
            string multiLog = "";

            int counter = 0;

            ServerListPopulator serverList = new ServerListPopulator();
            string[] listOfObjectFiles;

            foreach (var serverIP in serverList.getMethod(env, itSelection))
            {
                string[] serverLogFiles = System.IO.Directory.GetFiles(serverIP.ToString(), patternTableID);
                
                if (serverLogFiles != null)
                {
                    for (int i = 0; i < serverLogFiles.Length; i++)
                    {
                        DirectoryInfo di = Directory.CreateDirectory(destinationFileLocation + "\\Logs\\" + table);
                        System.IO.File.Copy(serverLogFiles[i], destinationFileLocation + "\\Logs\\" + table + "\\" + FileNameTrimmer.NameTrimmer(serverLogFiles[i]), true);
                        fileFound = true;
                    }
                }
            }
            if (!fileFound && multiLogSelection == "Yes")
            {
                foreach (var serverListOfObjects in serverList.getMethod(env, itSelection))
                {
                    listOfObjectFiles = Directory.GetFiles(serverListOfObjects.ToString(), patternListOfObjects);
                    if (listOfObjectFiles != null)
                    {
                        foreach (var item in listOfObjectFiles)
                        {
                            DirectoryInfo di = Directory.CreateDirectory(destinationFileLocation + "\\Logs\\" + table);
                            System.IO.File.Copy(item, destinationFileLocation + "\\Logs\\" + table + "\\" + FileNameTrimmer.NameTrimmer(item + counter), true);
                            localListOfObjectsFiles.Add(FileNameTrimmer.NameTrimmer(item) + counter);
                        }
                    }
                    counter++;
                }
            }
            foreach (var localObject in localListOfObjectsFiles)
            {
                foreach (var line in File.ReadLines(destinationFileLocation + "\\Logs\\" + table + "\\" + FileNameTrimmer.NameTrimmer(localObject.ToString())))
                {
                    if (line.Contains(table))
                    {
                        multiLog = line.Remove(line.Length - 1);
                        multiLogName = FileNameTrimmer.MultiTableNameTrimmer(multiLog);
                    }
                }
            }
            if (multiLogName != "")
            {
                foreach (var serverMultiLogFiles in serverList.getMethod(env, itSelection))
                {
                    string[] multiLogFilesArray = Directory.GetFiles(serverMultiLogFiles.ToString(), patternMultiLogs);
                    foreach (var multiLogItem in multiLogFilesArray)
                    {
                        if (multiLogFilesArray != null && multiLogItem.Contains(multiLogName))
                        {
                            File.Copy(multiLogItem, destinationFileLocation + "\\Logs\\" + table + "\\" + FileNameTrimmer.NameTrimmer(multiLogItem), true);
                            fileFound = true;

                            string[] auxTableLines = File.ReadAllLines(destinationFileLocation + "\\Logs\\" + table + "\\" + FileNameTrimmer.MultiTableNameTrimmer(multiLogItem));
                            for (int i = 0; i < auxTableLines.Length; i++)
                            {
                                if (auxTableLines[i].Contains(table))
                                {
                                    fileFound = true;
                                    using (var writer = new StreamWriter(destinationFileLocation + "\\Logs\\" + table + "\\" + "auxtableFromMultiLog_" + table, true))
                                    {
                                        writer.WriteLine(auxTableLines[i]);
                                        writer.Close();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            foreach (var localObject in localListOfObjectsFiles)
            {
                File.Delete(destinationFileLocation + "\\Logs\\" + table + "\\" + FileNameTrimmer.NameTrimmer(localObject.ToString()));
            }

            if (itSelection == "Yes")
            {
                foreach (var serverItemIT in serverList.getMethod(env, itSelection))
                {
                    string[] serverItemsITArray = Directory.GetFiles(serverItemIT.ToString(), patternIT);
                    if (serverItemsITArray != null)
                    {
                        for (int i = 0; i < serverItemsITArray.Length; i++)
                        {
                            dateItaly = FileNameTrimmer.ItalyGatewayDate(serverItemsITArray[i].ToString());
                            if (dateItaly > dateItalyMax)
                            {
                                dateItalyMax = dateItaly;
                                fileNameItaly = serverItemsITArray[i].ToString();
                            }
                        }
                        DirectoryInfo di = Directory.CreateDirectory(destinationFileLocation + "\\Logs\\" + table);
                        System.IO.File.Copy(fileNameItaly, destinationFileLocation + "\\Logs\\" + table + "\\" + FileNameTrimmer.ItalyGatewayTrimmer(fileNameItaly), true);
                        fileFoundIT = true;
                        fileFound = true;
                    }
                }
            }
            if (!fileFound)
            {
                MessageBox.Show("Table log not found.");
            }
            if (itSelection == "Yes" && !fileFoundIT)
            {
                MessageBox.Show("AAMS logs not found.");
            }
        }
    }
}
