using System;
using System.Collections;

namespace LEX
{
    internal class ServerListPopulator
    {
        private ArrayList returnArray(string env, string italySelection)
        {
            if (italySelection == "Yes")
            {
                var serverListIT = new ArrayList();
                serverListIT.Add(@"\\10.30.46.72\d\apps\logs\c_itgateway");

                return serverListIT;
            }
            if (env == "QA (GDK/Stars Studio)")
            {
                var serverListGDK = new ArrayList();
                serverListGDK.Add(@"\\10.30.46.4\d\apps\logs\c_gdk1\");
                serverListGDK.Add(@"\\10.30.46.8\d\apps\logs\c_gdk1\");
                serverListGDK.Add(@"\\10.30.46.14\d\apps\logs\c_gdk2");
                serverListGDK.Add(@"\\10.30.46.5\d\apps\logs\c_tables1\");
                serverListGDK.Add(@"\\10.30.46.6\d\apps\logs\c_tables2\");

                return serverListGDK;
            }

            if (env == "QR (3PP/GDK/Stars Studio)")
            {
                var serverListQR = new ArrayList();
                serverListQR.Add(@"\\10.30.49.47\d\apps\logs\c_zn_gdk");
                serverListQR.Add(@"\\10.30.49.47\d\apps\logs\c_zn_tables");

                return serverListQR;
            }
            if (env == "US (GDK/Stars Studio)")
            {
                var serverListUS = new ArrayList();
                serverListUS.Add(@"\\10.30.141.14\d\logs\c_gdk\"); // USMI
                serverListUS.Add(@"\\10.30.165.14\d\logs\c_gdk"); // USNJ
                serverListUS.Add(@"\\10.30.146.14\d\logs\c_gdk"); // USPA

                return serverListUS;
            }
            if (env == "QA (3PP)")
            {
                var serverListQA = new ArrayList();
                serverListQA.Add(@"\\10.30.46.5\d\apps\logs\c_tables1\");
                serverListQA.Add(@"\\10.30.46.6\d\apps\logs\c_tables2\");

                return serverListQA;
            }
            if (env == "116 (3PP)")
            {
                var serverList116 = new ArrayList();
                serverList116.Add(@"\\10.30.46.116\d\apps\logs\c_zn_tables\");

                return serverList116;
            }
            if (env == "US (3PP)")
            {
                var serverListUS2 = new ArrayList();
                serverListUS2.Add(@"\\10.30.141.3\d\logs\c_lobby\"); // USMI
                serverListUS2.Add(@"\\10.30.165.3\d\logs\c_lobby\"); // USNJ
                serverListUS2.Add(@"\\10.30.146.3\d\logs\c_lobby\"); // USPA

                return serverListUS2;
            }
            if (env == "UAT")
            {
                var serverListUAT = new ArrayList();
                // USMI
                serverListUAT.Add(@"\\10.30.141.3\d\logs\c_lobby\");
                serverListUAT.Add(@"\\10.30.47.3\d\logs\casino");

                return serverListUAT;
            }
            else
            {
                return null;
            }

        }
        public ArrayList getMethod(string env, string italySelection)
        {
            ArrayList newArray = null;
            newArray = this.returnArray(env, italySelection);
            return newArray;
        }
    }
}
