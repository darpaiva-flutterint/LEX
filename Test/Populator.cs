using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogExtractor
{
    internal class Populator
    {
        // This class populates the drop env down list
        public static void populateEnvironment(System.Windows.Forms.ComboBox envList)
        {
            envList.Items.Add("116 (3PP)");
            envList.Items.Add("QA (3PP)");
            envList.Items.Add("US (3PP)");
            envList.Items.Add("QA (GDK/Stars Studio)");
            envList.Items.Add("QR (GDK/Stars Studio)");
            envList.Items.Add("US (GDK/Stars Studio)");
            envList.Items.Add("UAT");
        }
        public static void populateITBox(System.Windows.Forms.ComboBox itList)
        {
            itList.Items.Add("Yes");
            itList.Items.Add("No");
        }
    }
}
