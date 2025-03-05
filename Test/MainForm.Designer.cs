namespace LogExtractor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.tableBox = new System.Windows.Forms.TextBox();
            this.vendorBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.quitButton = new System.Windows.Forms.Button();
            this.envList = new System.Windows.Forms.ComboBox();
            this.rgTokenBox = new System.Windows.Forms.TextBox();
            this.extractButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.doneLabel = new System.Windows.Forms.Label();
            this.vendorIDNotUsedLabel = new System.Windows.Forms.Label();
            this.rgTokenNotUsedLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.remainingFiles = new System.Windows.Forms.Label();
            this.itList = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.multiLog = new System.Windows.Forms.ComboBox();
            this.multiLogLabel = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.helperLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Environment:";
            this.toolTip1.SetToolTip(this.label1, "Without a selected environment, LEX won\'t extract any logs (including IT)!");
            // 
            // tableBox
            // 
            this.tableBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.tableBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableBox.ForeColor = System.Drawing.Color.White;
            this.tableBox.Location = new System.Drawing.Point(301, 219);
            this.tableBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tableBox.MaxLength = 19;
            this.tableBox.Name = "tableBox";
            this.tableBox.Size = new System.Drawing.Size(315, 31);
            this.tableBox.TabIndex = 3;
            this.toolTip1.SetToolTip(this.tableBox, "TableID field limited to 19 characters!");
            // 
            // vendorBox
            // 
            this.vendorBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.vendorBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vendorBox.ForeColor = System.Drawing.Color.White;
            this.vendorBox.Location = new System.Drawing.Point(301, 141);
            this.vendorBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.vendorBox.MaxLength = 3;
            this.vendorBox.Name = "vendorBox";
            this.vendorBox.Size = new System.Drawing.Size(53, 31);
            this.vendorBox.TabIndex = 2;
            this.toolTip1.SetToolTip(this.vendorBox, "VendorID field limited to 3 characters!");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label3.Location = new System.Drawing.Point(56, 293);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 40);
            this.label3.TabIndex = 7;
            this.label3.Text = "RG Token:";
            this.toolTip1.SetToolTip(this.label3, "RGToken field limited to 80 characters!");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 212);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 40);
            this.label4.TabIndex = 8;
            this.label4.Text = "Table ID:";
            this.toolTip1.SetToolTip(this.label4, "TableID field limited to 19 characters!");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 136);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 40);
            this.label5.TabIndex = 9;
            this.label5.Text = "Vendor ID:";
            this.toolTip1.SetToolTip(this.label5, "VendorID field limited to 3 characters!");
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.quitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("quitButton.BackgroundImage")));
            this.quitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quitButton.FlatAppearance.BorderSize = 0;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitButton.ForeColor = System.Drawing.Color.Transparent;
            this.quitButton.Location = new System.Drawing.Point(939, 389);
            this.quitButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(197, 81);
            this.quitButton.TabIndex = 8;
            this.quitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.quitButton.UseMnemonic = false;
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // envList
            // 
            this.envList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.envList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.envList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.envList.ForeColor = System.Drawing.Color.White;
            this.envList.FormattingEnabled = true;
            this.envList.Location = new System.Drawing.Point(291, 55);
            this.envList.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.envList.Name = "envList";
            this.envList.Size = new System.Drawing.Size(367, 39);
            this.envList.TabIndex = 1;
            this.toolTip1.SetToolTip(this.envList, "Without a selected environment, LEX won\'t extract any logs (excluding IT)!");
            this.envList.SelectedIndexChanged += new System.EventHandler(this.envList_SelectedIndexChanged);
            // 
            // rgTokenBox
            // 
            this.rgTokenBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.rgTokenBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rgTokenBox.ForeColor = System.Drawing.Color.White;
            this.rgTokenBox.Location = new System.Drawing.Point(301, 293);
            this.rgTokenBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.rgTokenBox.MaxLength = 80;
            this.rgTokenBox.Name = "rgTokenBox";
            this.rgTokenBox.Size = new System.Drawing.Size(691, 31);
            this.rgTokenBox.TabIndex = 6;
            this.toolTip1.SetToolTip(this.rgTokenBox, "RGToken field limited to 80 characters!");
            // 
            // extractButton
            // 
            this.extractButton.AllowDrop = true;
            this.extractButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.extractButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("extractButton.BackgroundImage")));
            this.extractButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.extractButton.FlatAppearance.BorderSize = 0;
            this.extractButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.extractButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extractButton.ForeColor = System.Drawing.Color.Transparent;
            this.extractButton.Location = new System.Drawing.Point(40, 389);
            this.extractButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.extractButton.Name = "extractButton";
            this.extractButton.Size = new System.Drawing.Size(197, 81);
            this.extractButton.TabIndex = 7;
            this.extractButton.UseVisualStyleBackColor = false;
            this.extractButton.Click += new System.EventHandler(this.extractButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.Color.Red;
            this.progressBar.Location = new System.Drawing.Point(251, 403);
            this.progressBar.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(672, 45);
            this.progressBar.TabIndex = 10;
            // 
            // doneLabel
            // 
            this.doneLabel.AutoSize = true;
            this.doneLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(176)))), ((int)(((byte)(37)))));
            this.doneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneLabel.ForeColor = System.Drawing.Color.White;
            this.doneLabel.Location = new System.Drawing.Point(541, 410);
            this.doneLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.doneLabel.Name = "doneLabel";
            this.doneLabel.Size = new System.Drawing.Size(100, 32);
            this.doneLabel.TabIndex = 11;
            this.doneLabel.Text = "DONE";
            this.doneLabel.Visible = false;
            // 
            // vendorIDNotUsedLabel
            // 
            this.vendorIDNotUsedLabel.AutoSize = true;
            this.vendorIDNotUsedLabel.BackColor = System.Drawing.Color.Transparent;
            this.vendorIDNotUsedLabel.Enabled = false;
            this.vendorIDNotUsedLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorIDNotUsedLabel.ForeColor = System.Drawing.Color.Black;
            this.vendorIDNotUsedLabel.Location = new System.Drawing.Point(295, 136);
            this.vendorIDNotUsedLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.vendorIDNotUsedLabel.Name = "vendorIDNotUsedLabel";
            this.vendorIDNotUsedLabel.Size = new System.Drawing.Size(503, 36);
            this.vendorIDNotUsedLabel.TabIndex = 12;
            this.vendorIDNotUsedLabel.Text = "VendorID not used for GDK / US";
            this.vendorIDNotUsedLabel.Visible = false;
            // 
            // rgTokenNotUsedLabel
            // 
            this.rgTokenNotUsedLabel.AutoSize = true;
            this.rgTokenNotUsedLabel.BackColor = System.Drawing.Color.Transparent;
            this.rgTokenNotUsedLabel.Enabled = false;
            this.rgTokenNotUsedLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgTokenNotUsedLabel.ForeColor = System.Drawing.Color.Black;
            this.rgTokenNotUsedLabel.Location = new System.Drawing.Point(294, 297);
            this.rgTokenNotUsedLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.rgTokenNotUsedLabel.Name = "rgTokenNotUsedLabel";
            this.rgTokenNotUsedLabel.Size = new System.Drawing.Size(502, 36);
            this.rgTokenNotUsedLabel.TabIndex = 5;
            this.rgTokenNotUsedLabel.Text = "RG Token not used for GDK / US";
            this.rgTokenNotUsedLabel.Visible = false;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(958, 59);
            this.versionLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(159, 32);
            this.versionLabel.TabIndex = 14;
            this.versionLabel.Text = "Version 4.6";
            // 
            // remainingFiles
            // 
            this.remainingFiles.AutoSize = true;
            this.remainingFiles.ForeColor = System.Drawing.Color.White;
            this.remainingFiles.Location = new System.Drawing.Point(251, 467);
            this.remainingFiles.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.remainingFiles.Name = "remainingFiles";
            this.remainingFiles.Size = new System.Drawing.Size(0, 32);
            this.remainingFiles.TabIndex = 15;
            this.remainingFiles.Visible = false;
            // 
            // itList
            // 
            this.itList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.itList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.itList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itList.ForeColor = System.Drawing.Color.White;
            this.itList.FormattingEnabled = true;
            this.itList.Location = new System.Drawing.Point(968, 219);
            this.itList.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.itList.Name = "itList";
            this.itList.Size = new System.Drawing.Size(140, 39);
            this.itList.TabIndex = 5;
            this.toolTip1.SetToolTip(this.itList, "Extracts the IT AAMS Gateway Log (doesn\'t need other parameters).");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(968, 136);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 74);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Extracts the IT AAMS Gateway Log (doesn\'t need other parameters).");
            // 
            // multiLog
            // 
            this.multiLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.multiLog.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.multiLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiLog.ForeColor = System.Drawing.Color.White;
            this.multiLog.FormattingEnabled = true;
            this.multiLog.Location = new System.Drawing.Point(741, 219);
            this.multiLog.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.multiLog.Name = "multiLog";
            this.multiLog.Size = new System.Drawing.Size(140, 39);
            this.multiLog.TabIndex = 4;
            this.toolTip1.SetToolTip(this.multiLog, "Pick Yes if logs aren\'t found (avoid using on QA as it will be slow)!");
            // 
            // multiLogLabel
            // 
            this.multiLogLabel.AutoSize = true;
            this.multiLogLabel.BackColor = System.Drawing.Color.Transparent;
            this.multiLogLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiLogLabel.ForeColor = System.Drawing.Color.White;
            this.multiLogLabel.Location = new System.Drawing.Point(730, 179);
            this.multiLogLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.multiLogLabel.Name = "multiLogLabel";
            this.multiLogLabel.Size = new System.Drawing.Size(164, 32);
            this.multiLogLabel.TabIndex = 20;
            this.multiLogLabel.Text = "Multi Logs:";
            this.toolTip1.SetToolTip(this.multiLogLabel, "Pick Yes if logs aren\'t found (avoid using on QA as it will be slow)!");
            // 
            // helperLabel
            // 
            this.helperLabel.AutoSize = true;
            this.helperLabel.BackColor = System.Drawing.Color.Transparent;
            this.helperLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helperLabel.ForeColor = System.Drawing.Color.White;
            this.helperLabel.Location = new System.Drawing.Point(167, 463);
            this.helperLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.helperLabel.Name = "helperLabel";
            this.helperLabel.Size = new System.Drawing.Size(733, 32);
            this.helperLabel.TabIndex = 21;
            this.helperLabel.Text = "Hover over different parts of the program for tooltips !";
            this.toolTip1.SetToolTip(this.helperLabel, "Just like this one !");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1173, 515);
            this.Controls.Add(this.helperLabel);
            this.Controls.Add(this.multiLogLabel);
            this.Controls.Add(this.multiLog);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.itList);
            this.Controls.Add(this.remainingFiles);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.rgTokenNotUsedLabel);
            this.Controls.Add(this.vendorIDNotUsedLabel);
            this.Controls.Add(this.doneLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.extractButton);
            this.Controls.Add(this.rgTokenBox);
            this.Controls.Add(this.envList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vendorBox);
            this.Controls.Add(this.tableBox);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "LEX";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button quitButton;
        public System.Windows.Forms.TextBox tableBox;
        public System.Windows.Forms.TextBox vendorBox;
        public System.Windows.Forms.ComboBox envList;
        public System.Windows.Forms.TextBox rgTokenBox;
        private System.Windows.Forms.Button extractButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label doneLabel;
        private System.Windows.Forms.Label vendorIDNotUsedLabel;
        private System.Windows.Forms.Label rgTokenNotUsedLabel;
        private System.Windows.Forms.Label versionLabel;
        public System.Windows.Forms.Label remainingFiles;
        public System.Windows.Forms.ComboBox itList;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ComboBox multiLog;
        private System.Windows.Forms.Label multiLogLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label helperLabel;
    }
}

