using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.AxHost;
using static System.Net.WebRequestMethods;
using LEX;
using System.Diagnostics.Eventing.Reader;
using File = System.IO.File;
using System.Net.NetworkInformation;
using static System.Windows.Forms.LinkLabel;

namespace LogExtractor
{
    internal class AuxMatchFinder
    {
        public void copyFiles(string table, string env, string destinationFileLocation, string itSelection)
        {
            bool fileFound = false;
            bool itFileFound = false;
            var localObjectsArray = new ArrayList();
            var copiedMultiLogsArray = new ArrayList();

            // Creating patterns to search for needed files from locations
            string patternTableID = "*" + table + "*";
            string patternListOfObjects = "listofobjects" + "*";
            //string patternMultiLogs = "*" + "AuxTableServerMulti" + "*";
            string patternMultiLogs = "CASF_" + "*";
            string patternIT = "AuxAamsGatewayServerInstance.log." + "*";

            string multiLogName = "";
            string multiLog = "";

            int counter = 0;

            if (env == "QA (GDK/Stars Studio)")
            {
                var serverListGDK = new ArrayList();
                serverListGDK.Add(@"\\10.30.46.4\d\apps\logs\c_gdk1\");
                serverListGDK.Add(@"\\10.30.46.8\d\apps\logs\c_gdk1\");
                serverListGDK.Add(@"\\10.30.46.14\d\apps\logs\c_gdk2");
                serverListGDK.Add(@"\\10.30.46.5\d\apps\logs\c_tables1\");
                serverListGDK.Add(@"\\10.30.46.6\d\apps\logs\c_tables2\");

                foreach (var itemQA in serverListGDK)
                {
                    string allFilesGDK = System.IO.Directory.GetFiles(itemQA.ToString(), patternTableID).FirstOrDefault();
                    if (allFilesGDK != null)
                    {
                        DirectoryInfo di = Directory.CreateDirectory(destinationFileLocation + "\\Logs\\" + table);
                        System.IO.File.Copy(allFilesGDK, destinationFileLocation + "\\Logs\\" + table + "\\" + Trimmer.FileNameTrimmer(allFilesGDK), true);
                        fileFound = true;
                    }
                    if (!fileFound)
                    {
                        continue;
                    }
                }
            }
            else if (env == "QR (GDK/Stars Studio)")
            {
                var serverListQR = new ArrayList();
                serverListQR.Add(@"\\10.30.49.47\d\apps\logs\c_zn_gdk");
                serverListQR.Add(@"\\10.30.49.47\d\apps\logs\c_zn_tables");
                // Array list for QR in case more locations are added in the future

                foreach (var itemQR in serverListQR)
                {
                    string auxFiles = System.IO.Directory.GetFiles(itemQR.ToString(), patternTableID).FirstOrDefault();
                    if (auxFiles != null)
                    {
                        DirectoryInfo di = Directory.CreateDirectory(destinationFileLocation + "\\Logs\\" + table);
                        System.IO.File.Copy(auxFiles, destinationFileLocation + "\\Logs\\" + table + "\\" + Trimmer.FileNameTrimmer(auxFiles), true);
                        fileFound = true;
                    }
                }
                if (!fileFound)
                {
                    foreach (var itemQR in serverListQR)
                    {
                        string[] listOfObjectFiles = Directory.GetFiles(itemQR.ToString(), patternListOfObjects);
                        if (listOfObjectFiles != null)
                        {
                            foreach (var item in listOfObjectFiles)
                            {
                                DirectoryInfo di = Directory.CreateDirectory(destinationFileLocation + "\\Logs\\" + table);
                                System.IO.File.Copy(item, destinationFileLocation + "\\Logs\\" + table + "\\" + Trimmer.FileNameTrimmer(item + counter), true);
                                // add copied files to array list to be read later
                                localObjectsArray.Add(Trimmer.FileNameTrimmer(item) + counter);
                            }
                            //listOfObjectFiles = null;
                        }
                        counter++;
                    }
                }
                // read List of objects
                foreach (var localObject in localObjectsArray)
                {
                    foreach (var line in File.ReadLines(destinationFileLocation + "\\Logs\\" + table + "\\" + Trimmer.FileNameTrimmer(localObject.ToString())))
                    {
                        if (line.Contains(table))
                        {
                            multiLog = line.Remove(line.Length - 1);
                            multiLogName = Trimmer.MultiTableNameTrimmer(multiLog);
                        }
                    }
                }
                if (multiLogName != "")
                {
                    foreach (var itemQR in serverListQR)
                    {
                        string[] multiLogFiles = Directory.GetFiles(itemQR.ToString(), patternMultiLogs);
                        foreach (var item in multiLogFiles)
                        {
                            if (multiLogFiles != null && item.Contains(multiLogName))
                            {
                                File.Copy(item, destinationFileLocation + "\\Logs\\" + table + "\\" + Trimmer.FileNameTrimmer(item), true);
                                fileFound = true;
                            }
                            else
                            {
                                fileFound = false;
                                continue;
                            }
                        }
                    }
                }
            }
            else if (env == "US (GDK/Stars Studio)")
            {
                var serverListUS = new ArrayList();
                // USMI
                serverListUS.Add(@"\\10.30.141.14\d\logs\c_gdk\");
                // USNJ
                serverListUS.Add(@"\\10.30.165.14\d\logs\c_gdk");
                // USPA
                serverListUS.Add(@"\\10.30.146.14\d\logs\c_gdk");
                // Array list for US licenses in case more locations are added in the future

                foreach (var itemUS in serverListUS)
                {
                    string allFilesUS = System.IO.Directory.GetFiles(itemUS.ToString(), patternTableID).FirstOrDefault();
                    if (allFilesUS != null)
                    {
                        DirectoryInfo di = Directory.CreateDirectory(destinationFileLocation + "\\Logs\\" + table);
                        System.IO.File.Copy(allFilesUS, destinationFileLocation + "\\Logs\\" + table + "\\" + Trimmer.FileNameTrimmer(allFilesUS), true);
                        fileFound = true;
                    }
                    if (!fileFound)
                    {
                        continue;
                    }
                }
            }
            else if (env == "QA (3PP)")
            {
                var serverListQA = new ArrayList();
                serverListQA.Add(@"\\10.30.46.5\d\apps\logs\c_tables1\");
                serverListQA.Add(@"\\10.30.46.6\d\apps\logs\c_tables2\");

                foreach (var itemQA in serverListQA)
                {
                    string allFilesQA = System.IO.Directory.GetFiles(itemQA.ToString(), patternTableID).FirstOrDefault();
                    if (allFilesQA != null)
                    {
                        DirectoryInfo di = Directory.CreateDirectory(destinationFileLocation + "\\Logs\\" + table);
                        System.IO.File.Copy(allFilesQA, destinationFileLocation + "\\Logs\\" + table + "\\" + Trimmer.FileNameTrimmer(allFilesQA), true);
                        fileFound = true;
                    }
                    if (!fileFound)
                    {
                        continue;
                        // maybe add MultiLog solution ?
                    }
                }
            }
            else if (env == "116 (3PP)")
            {
                var serverList116 = new ArrayList();
                serverList116.Add(@"\\10.30.46.116\d\apps\logs\c_zn_tables\");
                // Array list for 116 in case more locations are added in the future

                foreach (var item116 in serverList116)
                {
                    string logs116 = System.IO.Directory.GetFiles(item116.ToString(), patternTableID).FirstOrDefault();
                    if (logs116 != null)
                    {
                        DirectoryInfo di = Directory.CreateDirectory(destinationFileLocation + "\\Logs\\" + table);
                        System.IO.File.Copy(logs116, destinationFileLocation + "\\Logs\\" + table + "\\" + Trimmer.FileNameTrimmer(logs116), true);
                        fileFound = true;
                    }
                    if (!fileFound)
                    {
                        continue;
                    }
                }
            }
            else if (env == "US (3PP)")
            {
                var serverListUS = new ArrayList();
                // USMI
                serverListUS.Add(@"\\10.30.141.3\d\logs\c_lobby\");
                // USNJ
                serverListUS.Add(@"\\10.30.165.3\d\logs\c_lobby\");
                // USPA
                serverListUS.Add(@"\\10.30.146.3\d\logs\c_lobby\");
                // Array list for US licenses in case more locations are added in the future

                foreach (var itemUS in serverListUS)
                {
                    string allFilesUS = System.IO.Directory.GetFiles(itemUS.ToString(), patternTableID).FirstOrDefault();
                    if (allFilesUS != null)
                    {
                        DirectoryInfo di = Directory.CreateDirectory(destinationFileLocation + "\\Logs\\" + table);
                        System.IO.File.Copy(allFilesUS, destinationFileLocation + "\\Logs\\" + table + "\\" + Trimmer.FileNameTrimmer(allFilesUS), true);
                        fileFound = true;
                    }
                    if (!fileFound)
                    {
                        continue;
                    }
                }
                if (!fileFound)
                {
                    MessageBox.Show("Table log not found.");
                }
            }
            else if (env == "UAT")
            {
                var serverListUAT = new ArrayList();
                // USMI
                serverListUAT.Add(@"\\10.30.141.3\d\logs\c_lobby\");
                serverListUAT.Add(@"\\10.30.47.3\d\logs\casino");

                foreach (var itemUS in serverListUAT)
                {
                    string allFilesUAT = System.IO.Directory.GetFiles(itemUS.ToString(), patternTableID).FirstOrDefault();
                    if (allFilesUAT != null)
                    {
                        DirectoryInfo di = Directory.CreateDirectory(destinationFileLocation + "\\Logs\\" + table);
                        System.IO.File.Copy(allFilesUAT, destinationFileLocation + "\\Logs\\" + table + "\\" + Trimmer.FileNameTrimmer(allFilesUAT), true);
                        fileFound = true;
                    }
                    if (!fileFound)
                    {
                        foreach (var itemUAT in serverListUAT)
                        {
                            string[] listOfObjectFiles = Directory.GetFiles(itemUAT.ToString(), patternListOfObjects);
                            if (listOfObjectFiles != null)
                            {
                                foreach (var item in listOfObjectFiles)
                                {
                                    DirectoryInfo di = Directory.CreateDirectory(destinationFileLocation + "\\Logs\\" + table);
                                    System.IO.File.Copy(item, destinationFileLocation + "\\Logs\\" + table + "\\" + Trimmer.FileNameTrimmer(item), true);
                                    // add copied files to array list to be read later
                                    localObjectsArray.Add(item);
                                }
                                //listOfObjectFiles = null;
                            }
                        }
                        foreach (var localObject in localObjectsArray)
                        {
                            foreach (var line in File.ReadLines(destinationFileLocation + "\\Logs\\" + table + "\\" + Trimmer.FileNameTrimmer(localObject.ToString())))
                            {
                                if (line.Contains(table))
                                {
                                    multiLog = line.Remove(line.Length - 1);
                                    multiLogName = Trimmer.MultiTableNameTrimmer(line);
                                }
                            }
                        }
                        if (multiLogName != "")
                        {
                            foreach (var itemUAT in serverListUAT)
                            {
                                string[] multiLogFiles = Directory.GetFiles(itemUAT.ToString(), patternMultiLogs);
                                foreach (var item in multiLogFiles)
                                {
                                    if (multiLogFiles != null && item.Contains(multiLogName))
                                    {
                                        File.Copy(item, destinationFileLocation + "\\Logs\\" + table + "\\" + Trimmer.FileNameTrimmer(item), true);
                                        fileFound = true;
                                    }
                                    else
                                    {
                                        fileFound = false;
                                        continue;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (itSelection == "Yes")
            {
                var serverListIT = new ArrayList();
                serverListIT.Add(@"\\10.30.46.72\d\apps\logs\c_itgateway");

                foreach (var itemIT in serverListIT)
                {
                    string allFilesIT = System.IO.Directory.GetFiles(itemIT.ToString(), patternIT).FirstOrDefault();
                    if (allFilesIT != null)
                    {
                        DirectoryInfo di = Directory.CreateDirectory(destinationFileLocation + "\\Logs\\" + table);
                        System.IO.File.Copy(allFilesIT, destinationFileLocation + "\\Logs\\" + table + "\\" + Trimmer.FileNameTrimmer(allFilesIT), true);
                        itFileFound = true;
                    }
                    if (!itFileFound)
                    {
                        continue;
                    }
                }
            }
            if (!fileFound)
            {
                MessageBox.Show("Table log not found.");
            }
            if (itSelection == "Yes" && !fileFound)
            {
                MessageBox.Show("IT Logs not found.");
            }
        }
    }
}
