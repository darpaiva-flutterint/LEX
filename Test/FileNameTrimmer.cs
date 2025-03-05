using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEX
{
    internal class FileNameTrimmer
    {
        static int localObjectTrimmer = 0;
        static string localObjectToString = "";

        public static string NameTrimmer(string fileName)
        {
            localObjectToString = fileName.ToString();
            localObjectTrimmer = localObjectToString.LastIndexOf("\\");
            string localObjectTrimmed = localObjectToString.Substring(localObjectTrimmer);

            return localObjectTrimmed;
        }
        public static string MultiTableNameTrimmer(string fileName)
        {
            localObjectToString = fileName.ToString();
            localObjectTrimmer = localObjectToString.LastIndexOf("\\");
            string localObjectTrimmed = localObjectToString.Substring(localObjectTrimmer + 1);
            //localObjectTrimmed = localObjectTrimmed.Remove(localObjectTrimmed.Length - 1);

            return localObjectTrimmed;
        }

        public static string ItalyGatewayTrimmer(string fileName)
        {
            localObjectToString = fileName.ToString();
            localObjectTrimmer = localObjectToString.LastIndexOf("\\");
            string localObjectTrimmed = localObjectToString.Substring(localObjectTrimmer + 1);

            return localObjectTrimmed;
        }

        public static int ItalyGatewayDate(string fileName)
        {
            localObjectToString = fileName.ToString();
            localObjectTrimmer = localObjectToString.LastIndexOf(".");
            string localObjectTrimmed = localObjectToString.Substring(localObjectTrimmer + 1);

            // parsing string to Int as method returns int value
            int localObjectToInt = Int32.Parse(localObjectTrimmed);

            return localObjectToInt;
        }
    }
}