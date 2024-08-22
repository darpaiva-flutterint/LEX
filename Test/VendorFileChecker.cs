using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogExtractor
{
    internal class VendorFileChecker
    {
        public static string vendorLogFileName = "Error in Vendor File Name";
        public static string checkVendorFiles(string vendorId)
        {
            if (vendorId == "3")
            {
                vendorLogFileName = "EvoGateway.log";
                return vendorLogFileName;
            }
            if (vendorId == "25")
            {
                vendorLogFileName = "playtechlivedealergateway.log";
                return vendorLogFileName;
            }
            if (vendorId == "30")
            {
                vendorLogFileName = "sgdogsgateway.log";
                return vendorLogFileName;
            }
            if (vendorId == "35")
            {
                vendorLogFileName = "pushgateway.log";
                return vendorLogFileName;
            }
            if (vendorId == "36")
            {
                vendorLogFileName = "egtgateway.log";
                return vendorLogFileName;
            }
            if (vendorId == "38")
            {
                vendorLogFileName = "mgsgateway.log";
                return vendorLogFileName;
            }
            if (vendorId == "40")
            {
                vendorLogFileName = "ossgateway.log";
                return vendorLogFileName;
            }
            if (vendorId != "3" || vendorId != "25" || vendorId != "30" || vendorId != "36")
            {
                vendorLogFileName = "pyrCasinoServices.log";
                return vendorLogFileName;
            } else
            {
                return "Issue with vendorid";
            }
        }
    }
}
