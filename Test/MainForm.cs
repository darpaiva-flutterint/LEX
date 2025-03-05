using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Media;
using LEX;

namespace LogExtractor
{
    // This class defines variables and constructs objects and is used to execute the program

    public partial class MainForm : Form
    {
        //SoundPlayer player = new SoundPlayer();   // sound player to play sounds upon completed actions
        private AuxMatchFinder matchFinder;
        private ErrorHandler errorHandler;
        string environment;
        string rgToken;
        string tableId;
        string vendorId;
        string itOption;
        string multiLogSelection;

        // Would recommend refactoring these
        public static bool inputError;
        string installationDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            EnvUIPopulator.populateEnvironment(envList);
            EnvUIPopulator.populateITBox(itList);
            EnvUIPopulator.populateMultiLogsBox(multiLog);
            this.matchFinder = new AuxMatchFinder();
            this.errorHandler = new ErrorHandler();
        }

        private void envList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (envList.SelectedIndex == 0 || envList.SelectedIndex == 1)
            {
                vendorBox.Visible = true;
                rgTokenBox.Visible = true;
                vendorIDNotUsedLabel.Visible = false;
                rgTokenNotUsedLabel.Visible = false;
                this.Update();
            }  else if (envList.SelectedIndex == 2 || envList.SelectedIndex == 3 || envList.SelectedIndex == 4 || envList.SelectedIndex == 5 || envList.SelectedIndex == 6)
            {
                vendorBox.Visible = false;
                rgTokenBox.Visible = false;
                vendorIDNotUsedLabel.Visible = true;
                rgTokenNotUsedLabel.Visible = true;
                this.Update();
            }
        }

        private void extractButton_Click(object sender, EventArgs e)
        {
            doneLabel.Visible = false;
            progressBar.Value = 0;
            this.Update();
            this.environment = envList.Text;
            this.itOption = itList.Text;
            this.multiLogSelection = multiLog.Text;
            this.rgToken = rgTokenBox.Text;
            this.tableId = tableBox.Text;
            this.vendorId = vendorBox.Text;
            this.errorHandler.handleErrors(environment, rgToken, tableId, vendorId, itOption);
            this.remainingFiles.Text = "Files = ";
            progressBar.Value = 25;

            if (inputError == true)
            {
                // We make inputError false after we have displayed the error to the user
                inputError = false;
            } else
            {
                FolderCreator.createFolder(tableId, installationDirectory);
                progressBar.Value = 50;
                GatewayExtractor.getGatewayLogs(environment, vendorId, rgToken, tableId, installationDirectory);
                progressBar.Value = 75;
                this.matchFinder.copyAux(tableId, environment, installationDirectory, itOption, multiLogSelection);
                progressBar.Value = 100;
                doneLabel.Visible = true;
            }
        }
        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}