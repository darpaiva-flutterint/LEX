using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogExtractor
{
    internal class ErrorHandler
    {
        // This class acts as a QA to the QA

        public static string fieldsWithError = "";
        public static string errorString = "The following fields are EMPTY or INCORRECT: ";
        public void handleErrors(string env, string rg, string table, string vendor, string itSelection)
        {
            if (itSelection != "Yes")
            {
                if (env.Length == 0)
                {
                    MainForm.inputError = true;
                    fieldsWithError += "Environment, ";
                }
                if (env != "QA (GDK/Stars Studio)" && env != "QR (3PP/GDK/Stars Studio)" && env != "US (GDK/Stars Studio)" && env != "US (3PP)" && env != "UAT" && rg.Length == 0)
                {
                    MainForm.inputError = true;
                    fieldsWithError += "RG Token, ";
                }
                // Don't want to give user the ability to type less or more characters, but for 116, the TID is 1 less char than on QA
                // Also I don't feel like we need to test if input is letters rather than digits (as tableId currently is a String)
                if (env == "116 (3PP)" && table.Length != 7)
                {
                    MainForm.inputError = true;
                    fieldsWithError += "Table ID (Not correct), ";
                }
                /*if (env == "US (3PP)" && table.Length != 16)
                {
                    MainForm.inputError = true;
                    fieldsWithError += "Table ID (Not correct), ";
                } */
                if (env != "116 (3PP)" && env != "US (3PP)" && env != "US (GDK/Stars Studio)" && env != "UAT" && table.Length != 8)
                {
                    MainForm.inputError = true;
                    fieldsWithError += "Table ID (Not correct), ";
                }
                if (table.Length == 0)
                {
                    MainForm.inputError = true;
                    fieldsWithError += "Table ID (Empty), ";
                }
                if (env != "QA (GDK/Stars Studio)" && env != "QR (3PP/GDK/Stars Studio)" && env != "US (GDK/Stars Studio)" && env != "US (3PP)" && env != "UAT" && vendor.Length == 0)
                {
                    MainForm.inputError = true;
                    fieldsWithError += "Vendor ID";
                }
            } else if (itSelection == "Yes" && env == "QA (3PP)" || env == "116 (3PP)")
            {
                MainForm.inputError = true;
                fieldsWithError += "Environment can't be QA (3PP) or 116 (3PP). Choose a different environment.";
            }
            if (MainForm.inputError == true)
            {
                MessageBox.Show(errorString + fieldsWithError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fieldsWithError = "";
            }
        }
    }
}