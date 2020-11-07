namespace RulesImporter
{
    partial class RulesImportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RulesImportForm));
            this.wizardControl1 = new AeroWizard.WizardControl();
            this.EntryPage = new AeroWizard.WizardPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AppRegistration = new AeroWizard.WizardPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.AppRegistrationDetails = new AeroWizard.WizardPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.localSentinelRepoDetailsPage = new AeroWizard.WizardPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtLocalRepoPath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ParseLocalRepo = new AeroWizard.WizardPage();
            this.lblRulesImported = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SentinelGitHubRepo = new AeroWizard.WizardPage();
            this.EndPage = new AeroWizard.WizardPage();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.EntryPage.SuspendLayout();
            this.AppRegistration.SuspendLayout();
            this.AppRegistrationDetails.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.localSentinelRepoDetailsPage.SuspendLayout();
            this.ParseLocalRepo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // wizardControl1
            // 
            this.wizardControl1.BackColor = System.Drawing.Color.White;
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wizardControl1.Location = new System.Drawing.Point(0, 0);
            this.wizardControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.Pages.Add(this.EntryPage);
            this.wizardControl1.Pages.Add(this.AppRegistration);
            this.wizardControl1.Pages.Add(this.AppRegistrationDetails);
            this.wizardControl1.Pages.Add(this.localSentinelRepoDetailsPage);
            this.wizardControl1.Pages.Add(this.ParseLocalRepo);
            this.wizardControl1.Pages.Add(this.SentinelGitHubRepo);
            this.wizardControl1.Pages.Add(this.EndPage);
            this.wizardControl1.Size = new System.Drawing.Size(1192, 879);
            this.wizardControl1.TabIndex = 0;
            // 
            // EntryPage
            // 
            this.EntryPage.AllowBack = false;
            this.EntryPage.Controls.Add(this.textBox1);
            this.EntryPage.Name = "EntryPage";
            this.EntryPage.NextPage = this.AppRegistration;
            this.EntryPage.Size = new System.Drawing.Size(1145, 689);
            this.EntryPage.TabIndex = 0;
            this.EntryPage.Text = "Welcome to Sentinel Analytics Rules Importer - SARI";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(61, 138);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(999, 391);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // AppRegistration
            // 
            this.AppRegistration.Controls.Add(this.textBox2);
            this.AppRegistration.Name = "AppRegistration";
            this.AppRegistration.Size = new System.Drawing.Size(1145, 689);
            this.AppRegistration.TabIndex = 1;
            this.AppRegistration.Text = "Create an app registration in Azure Active Directory";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(84, 76);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(967, 460);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // AppRegistrationDetails
            // 
            this.AppRegistrationDetails.Controls.Add(this.groupBox2);
            this.AppRegistrationDetails.Controls.Add(this.groupBox1);
            this.AppRegistrationDetails.Name = "AppRegistrationDetails";
            this.AppRegistrationDetails.Size = new System.Drawing.Size(1145, 689);
            this.AppRegistrationDetails.TabIndex = 5;
            this.AppRegistrationDetails.Text = "Add app registration and other details";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(74, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(951, 227);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Subscription and Sentinel details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "SubscriptionID:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(246, 153);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(650, 31);
            this.textBox6.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "TenantID:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(246, 113);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(650, 31);
            this.textBox5.TabIndex = 5;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(246, 33);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(650, 31);
            this.textBox7.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Resource group:";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(246, 73);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(650, 31);
            this.textBox8.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Workspace name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Location = new System.Drawing.Point(74, 302);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(951, 141);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "App registration details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "ClientID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "ClientSecret:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(246, 38);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(650, 31);
            this.textBox3.TabIndex = 0;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(246, 78);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(650, 31);
            this.textBox4.TabIndex = 2;
            // 
            // localSentinelRepoDetailsPage
            // 
            this.localSentinelRepoDetailsPage.Controls.Add(this.richTextBox1);
            this.localSentinelRepoDetailsPage.Controls.Add(this.button1);
            this.localSentinelRepoDetailsPage.Controls.Add(this.txtLocalRepoPath);
            this.localSentinelRepoDetailsPage.Controls.Add(this.label7);
            this.localSentinelRepoDetailsPage.Name = "localSentinelRepoDetailsPage";
            this.localSentinelRepoDetailsPage.Size = new System.Drawing.Size(1145, 689);
            this.localSentinelRepoDetailsPage.TabIndex = 6;
            this.localSentinelRepoDetailsPage.Text = "Path to the local Sentinel repo";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.richTextBox1.Location = new System.Drawing.Point(76, 33);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(834, 208);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "Please note that the tool requires you to point it to the local Detections folder" +
    " under the Sentinel local repo directory. Make sure the right folder path is sel" +
    "ected here. ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Choose folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLocalRepoPath
            // 
            this.txtLocalRepoPath.Location = new System.Drawing.Point(76, 443);
            this.txtLocalRepoPath.Name = "txtLocalRepoPath";
            this.txtLocalRepoPath.Size = new System.Drawing.Size(744, 31);
            this.txtLocalRepoPath.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(825, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Enter path to DETECTIONS folder manually below or choose folder by using the Choo" +
    "se Folder button.";
            // 
            // ParseLocalRepo
            // 
            this.ParseLocalRepo.Controls.Add(this.lblRulesImported);
            this.ParseLocalRepo.Controls.Add(this.dataGridView1);
            this.ParseLocalRepo.Name = "ParseLocalRepo";
            this.ParseLocalRepo.Size = new System.Drawing.Size(1145, 689);
            this.ParseLocalRepo.TabIndex = 2;
            this.ParseLocalRepo.Text = "Parse results on local repo path";
            this.ParseLocalRepo.Initialize += new System.EventHandler<AeroWizard.WizardPageInitEventArgs>(this.ParseLocalRepo_Initialize);
            // 
            // lblRulesImported
            // 
            this.lblRulesImported.AutoSize = true;
            this.lblRulesImported.Location = new System.Drawing.Point(17, 14);
            this.lblRulesImported.Name = "lblRulesImported";
            this.lblRulesImported.Size = new System.Drawing.Size(0, 25);
            this.lblRulesImported.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1103, 583);
            this.dataGridView1.TabIndex = 0;
            // 
            // SentinelGitHubRepo
            // 
            this.SentinelGitHubRepo.Name = "SentinelGitHubRepo";
            this.SentinelGitHubRepo.Size = new System.Drawing.Size(1145, 689);
            this.SentinelGitHubRepo.TabIndex = 3;
            this.SentinelGitHubRepo.Text = "Write to Sentinel";
            this.SentinelGitHubRepo.Initialize += new System.EventHandler<AeroWizard.WizardPageInitEventArgs>(this.SentinelGitHubRepo_Initialize);
            // 
            // EndPage
            // 
            this.EndPage.IsFinishPage = true;
            this.EndPage.Name = "EndPage";
            this.EndPage.Size = new System.Drawing.Size(1145, 689);
            this.EndPage.TabIndex = 4;
            this.EndPage.Text = "Rules import has completed";
            // 
            // RulesImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 879);
            this.Controls.Add(this.wizardControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RulesImportForm";
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.EntryPage.ResumeLayout(false);
            this.EntryPage.PerformLayout();
            this.AppRegistration.ResumeLayout(false);
            this.AppRegistration.PerformLayout();
            this.AppRegistrationDetails.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.localSentinelRepoDetailsPage.ResumeLayout(false);
            this.localSentinelRepoDetailsPage.PerformLayout();
            this.ParseLocalRepo.ResumeLayout(false);
            this.ParseLocalRepo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AeroWizard.WizardControl wizardControl1;
        private AeroWizard.WizardPage EntryPage;
        private AeroWizard.WizardPage AppRegistration;
        private AeroWizard.WizardPage ParseLocalRepo;
        private AeroWizard.WizardPage SentinelGitHubRepo;
        private AeroWizard.WizardPage EndPage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private AeroWizard.WizardPage AppRegistrationDetails;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label3;
        private AeroWizard.WizardPage localSentinelRepoDetailsPage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtLocalRepoPath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblRulesImported;
    }
}