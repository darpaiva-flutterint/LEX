using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogExtractor
{
    internal class GatewayExtractor
    {
        // This class defines where the GW logs are and copies the files locally
        public static void getGatewayLogs(string env, string vendorId, string rg, string table, string installationDirectory)
        {
            string logFileName = VendorFileChecker.checkVendorFiles(vendorId);
            if (env != "QA (GDK/Stars Studio)" || env != "QR (GDK/Stars Studio)") // there aren't GW logs for GDK games
            {
                if (env == "QA (3PP)")
                {
                    if (vendorId != "0")
                    {
                        string sourceFile132 = @"\\10.30.46.132\\tomcat\\catalina_base\\" + vendorId + "\\logs\\" + logFileName;
                        string destinationFile132 = installationDirectory + "\\Logs\\" + table + "\\132pyrCasinoServices.log";
                        File.Copy(sourceFile132, destinationFile132, true);
                        
                        string sourceFile133 = @"\\10.30.46.133\tomcat\catalina_base\" + vendorId + "\\logs\\" + logFileName;
                        string destinationFile133 = installationDirectory + "\\Logs\\" + table + "\\133pyrCasinoServices.log";
                        File.Copy(sourceFile133, destinationFile133, true);

                        // check if files are copied and then run GateWayFilter, otherwise exceptions
                        if (File.Exists(destinationFile132))
                        {
                            GateWayFilter.filter132(rg, table, installationDirectory);
                            GateWayFilter.filter133(rg, table, installationDirectory);
                            GateWayFilter.filterMessages(table, installationDirectory);
                        }
                    }
                }
                if (env == "116 (3PP)")
                {
                    if (vendorId != "0")
                    {
                        string sourceFile116 = @"\\10.30.76.132\tomcat\catalina_base\" + vendorId + "\\logs\\pyrCasinoServices.log";
                        string destinationFile116 = installationDirectory + "\\Logs\\" + table + "\\116pyrCasinoServices.log";
                        File.Copy(sourceFile116, destinationFile116, true);

                        if (File.Exists(destinationFile116))
                        {
                            GateWayFilter.filter116(rg, table, installationDirectory);
                            GateWayFilter.filterMessages(table, installationDirectory);
                        }
                    }
                }
            }
        }
    }
}