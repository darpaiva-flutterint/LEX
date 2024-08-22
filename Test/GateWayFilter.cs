using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogExtractor
{
    internal class GateWayFilter
    {
        public static void filter132(string rg, string table, string installationDirectory)
        {
            string[] pyr132LogLines = File.ReadAllLines(installationDirectory + "\\Logs\\" + table + "\\" + "132pyrCasinoServices.log");
            for (int i = 0; i < pyr132LogLines.Length; i++)
            {
                if (pyr132LogLines[i].Contains(rg))
                {
                    using (var writer = new StreamWriter(installationDirectory + "\\Logs\\" + table + "\\" + "GW.xml", true))
                    {
                        writer.WriteLine(pyr132LogLines[i]);
                        writer.Close();
                    }
                }
            }
        }
        public static void filter133(string rg, string table, string installationDirectory)
        {
            string[] pyr133LogLines = File.ReadAllLines(installationDirectory + "\\Logs\\" + table + "\\" + "133pyrCasinoServices.log");
            for (int i = 0; i < pyr133LogLines.Length; i++)
            {
                if (pyr133LogLines[i].Contains(rg))
                {
                    using (var writer = new StreamWriter(installationDirectory + "\\Logs\\" + table + "\\" + "GW.xml", true))
                    {
                        writer.WriteLine(pyr133LogLines[i]);
                        writer.Close();
                    }
                }
            }
        }
        public static void filter116(string rg, string table, string installationDirectory)
        {
            string[] pyr116LogLines = File.ReadAllLines(installationDirectory + "\\Logs\\" + table + "\\" + "116pyrCasinoServices.log");
            for (int i = 0; i < pyr116LogLines.Length; i++)
            {
                if (pyr116LogLines[i].Contains(rg))
                {
                    using (var writer = new StreamWriter(installationDirectory + "\\Logs\\" + table + "\\" + "GW.xml", true))
                    {
                        writer.WriteLine(pyr116LogLines[i]);
                        writer.Close();
                    }
                }
            }
        }
        public static void filterMessages(string table, string installationDirectory)
        {   
            if (File.Exists("GW.xml"))
            {
                string[] gwLines = File.ReadAllLines(installationDirectory + "\\Logs\\" + table + "\\" + "GW.xml");
                for (int i = 0; i < gwLines.Length; i++)
                {
                    if (gwLines[i].Contains("FromAux") || gwLines[i].Contains("ToAux"))
                    {
                        using (var writer = new StreamWriter(installationDirectory + "\\Logs\\" + table + "\\" + table + ".xml", true))
                        {
                            writer.WriteLine(gwLines[i]);
                            writer.Close();
                        }
                    }
                }
            }
        }
    }
}