namespace Chainski_Crypter.Forms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCmd = new System.Windows.Forms.TextBox();
            this.btnPayloadBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPayload = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSecondFolderRandom = new System.Windows.Forms.Button();
            this.txtSecondFolder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFoldername = new System.Windows.Forms.ComboBox();
            this.btnRegistrynameRandom = new System.Windows.Forms.Button();
            this.txtRegistryname = new System.Windows.Forms.TextBox();
            this.btnFoldernameRandom = new System.Windows.Forms.Button();
            this.btnFillenameRandom = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkInstall = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnVBC = new System.Windows.Forms.RadioButton();
            this.btnMsBuild = new System.Windows.Forms.RadioButton();
            this.btnItself = new System.Windows.Forms.RadioButton();
            this.btnInstallutil = new System.Windows.Forms.RadioButton();
            this.btnApplaunch = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnIcon = new System.Windows.Forms.Button();
            this.btnInformation = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnBuild = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCmd);
            this.groupBox1.Controls.Add(this.btnPayloadBrowse);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPayload);
            this.groupBox1.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Cyan;
            this.groupBox1.Location = new System.Drawing.Point(9, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Size = new System.Drawing.Size(422, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a file";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(326, 69);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "-Command Line:";
            // 
            // txtCmd
            // 
            this.txtCmd.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCmd.Enabled = false;
            this.txtCmd.Location = new System.Drawing.Point(106, 64);
            this.txtCmd.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtCmd.Name = "txtCmd";
            this.txtCmd.Size = new System.Drawing.Size(210, 23);
            this.txtCmd.TabIndex = 2;
            // 
            // btnPayloadBrowse
            // 
            this.btnPayloadBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayloadBrowse.ForeColor = System.Drawing.Color.Cyan;
            this.btnPayloadBrowse.Location = new System.Drawing.Point(326, 24);
            this.btnPayloadBrowse.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnPayloadBrowse.Name = "btnPayloadBrowse";
            this.btnPayloadBrowse.Size = new System.Drawing.Size(90, 24);
            this.btnPayloadBrowse.TabIndex = 0;
            this.btnPayloadBrowse.Text = "Choose File";
            this.btnPayloadBrowse.UseVisualStyleBackColor = true;
            this.btnPayloadBrowse.Click += new System.EventHandler(this.BtnPayloadBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "-Payload:";
            // 
            // txtPayload
            // 
            this.txtPayload.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPayload.Location = new System.Drawing.Point(106, 25);
            this.txtPayload.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtPayload.Name = "txtPayload";
            this.txtPayload.Size = new System.Drawing.Size(210, 23);
            this.txtPayload.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox2.Controls.Add(this.btnSecondFolderRandom);
            this.groupBox2.Controls.Add(this.txtSecondFolder);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtFoldername);
            this.groupBox2.Controls.Add(this.btnRegistrynameRandom);
            this.groupBox2.Controls.Add(this.txtRegistryname);
            this.groupBox2.Controls.Add(this.btnFoldernameRandom);
            this.groupBox2.Controls.Add(this.btnFillenameRandom);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtFilename);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Cyan;
            this.groupBox2.Location = new System.Drawing.Point(10, 146);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox2.Size = new System.Drawing.Size(419, 160);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Installation";
            // 
            // btnSecondFolderRandom
            // 
            this.btnSecondFolderRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecondFolderRandom.Location = new System.Drawing.Point(324, 96);
            this.btnSecondFolderRandom.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnSecondFolderRandom.Name = "btnSecondFolderRandom";
            this.btnSecondFolderRandom.Size = new System.Drawing.Size(78, 24);
            this.btnSecondFolderRandom.TabIndex = 10;
            this.btnSecondFolderRandom.Text = "Random";
            this.btnSecondFolderRandom.UseVisualStyleBackColor = true;
            this.btnSecondFolderRandom.Click += new System.EventHandler(this.BtnSecondFolderRandom_Click);
            // 
            // txtSecondFolder
            // 
            this.txtSecondFolder.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSecondFolder.Location = new System.Drawing.Point(105, 96);
            this.txtSecondFolder.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtSecondFolder.Multiline = true;
            this.txtSecondFolder.Name = "txtSecondFolder";
            this.txtSecondFolder.Size = new System.Drawing.Size(210, 23);
            this.txtSecondFolder.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 100);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "-Second folder";
            // 
            // txtFoldername
            // 
            this.txtFoldername.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtFoldername.FormattingEnabled = true;
            this.txtFoldername.Location = new System.Drawing.Point(105, 65);
            this.txtFoldername.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtFoldername.Name = "txtFoldername";
            this.txtFoldername.Size = new System.Drawing.Size(210, 23);
            this.txtFoldername.TabIndex = 9;
            // 
            // btnRegistrynameRandom
            // 
            this.btnRegistrynameRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrynameRandom.Location = new System.Drawing.Point(324, 124);
            this.btnRegistrynameRandom.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnRegistrynameRandom.Name = "btnRegistrynameRandom";
            this.btnRegistrynameRandom.Size = new System.Drawing.Size(78, 24);
            this.btnRegistrynameRandom.TabIndex = 4;
            this.btnRegistrynameRandom.Text = "Random";
            this.btnRegistrynameRandom.UseVisualStyleBackColor = true;
            this.btnRegistrynameRandom.Click += new System.EventHandler(this.BtnRegistrynameRandom_Click);
            // 
            // txtRegistryname
            // 
            this.txtRegistryname.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtRegistryname.Location = new System.Drawing.Point(105, 124);
            this.txtRegistryname.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtRegistryname.Multiline = true;
            this.txtRegistryname.Name = "txtRegistryname";
            this.txtRegistryname.Size = new System.Drawing.Size(210, 23);
            this.txtRegistryname.TabIndex = 7;
            // 
            // btnFoldernameRandom
            // 
            this.btnFoldernameRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoldernameRandom.Location = new System.Drawing.Point(324, 65);
            this.btnFoldernameRandom.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnFoldernameRandom.Name = "btnFoldernameRandom";
            this.btnFoldernameRandom.Size = new System.Drawing.Size(78, 25);
            this.btnFoldernameRandom.TabIndex = 3;
            this.btnFoldernameRandom.Text = "Random";
            this.btnFoldernameRandom.UseVisualStyleBackColor = true;
            this.btnFoldernameRandom.Click += new System.EventHandler(this.BtnFoldernameRandom_Click);
            // 
            // btnFillenameRandom
            // 
            this.btnFillenameRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFillenameRandom.Location = new System.Drawing.Point(324, 34);
            this.btnFillenameRandom.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnFillenameRandom.Name = "btnFillenameRandom";
            this.btnFillenameRandom.Size = new System.Drawing.Size(78, 24);
            this.btnFillenameRandom.TabIndex = 2;
            this.btnFillenameRandom.Text = "Random";
            this.btnFillenameRandom.UseVisualStyleBackColor = true;
            this.btnFillenameRandom.Click += new System.EventHandler(this.BtnFillenameRandom_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "-Registry name";
            // 
            // txtFilename
            // 
            this.txtFilename.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtFilename.Location = new System.Drawing.Point(105, 34);
            this.txtFilename.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtFilename.Multiline = true;
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(210, 23);
            this.txtFilename.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "-Folder name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "-File name";
            // 
            // chkInstall
            // 
            this.chkInstall.AutoSize = true;
            this.chkInstall.Location = new System.Drawing.Point(18, 125);
            this.chkInstall.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.chkInstall.Name = "chkInstall";
            this.chkInstall.Size = new System.Drawing.Size(15, 14);
            this.chkInstall.TabIndex = 1;
            this.chkInstall.UseVisualStyleBackColor = true;
            this.chkInstall.CheckedChanged += new System.EventHandler(this.ChkInstall_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox3.Controls.Add(this.btnVBC);
            this.groupBox3.Controls.Add(this.btnMsBuild);
            this.groupBox3.Controls.Add(this.btnItself);
            this.groupBox3.Controls.Add(this.btnInstallutil);
            this.groupBox3.Controls.Add(this.btnApplaunch);
            this.groupBox3.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Cyan;
            this.groupBox3.Location = new System.Drawing.Point(9, 320);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox3.Size = new System.Drawing.Size(421, 79);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Injection";
            // 
            // btnVBC
            // 
            this.btnVBC.AutoSize = true;
            this.btnVBC.Location = new System.Drawing.Point(287, 36);
            this.btnVBC.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnVBC.Name = "btnVBC";
            this.btnVBC.Size = new System.Drawing.Size(45, 19);
            this.btnVBC.TabIndex = 9;
            this.btnVBC.Text = "vbc";
            this.btnVBC.UseVisualStyleBackColor = true;
            this.btnVBC.CheckedChanged += new System.EventHandler(this.btnVBC_CheckedChanged);
            // 
            // btnMsBuild
            // 
            this.btnMsBuild.AutoSize = true;
            this.btnMsBuild.Location = new System.Drawing.Point(198, 36);
            this.btnMsBuild.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnMsBuild.Name = "btnMsBuild";
            this.btnMsBuild.Size = new System.Drawing.Size(71, 19);
            this.btnMsBuild.TabIndex = 8;
            this.btnMsBuild.Text = "MSBuild";
            this.btnMsBuild.UseVisualStyleBackColor = true;
            this.btnMsBuild.CheckedChanged += new System.EventHandler(this.btnMsBuild_CheckedChanged);
            // 
            // btnItself
            // 
            this.btnItself.AutoSize = true;
            this.btnItself.Location = new System.Drawing.Point(353, 36);
            this.btnItself.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnItself.Name = "btnItself";
            this.btnItself.Size = new System.Drawing.Size(54, 19);
            this.btnItself.TabIndex = 7;
            this.btnItself.Text = "Itself";
            this.btnItself.UseVisualStyleBackColor = true;
            this.btnItself.CheckedChanged += new System.EventHandler(this.BtnItself_CheckedChanged);
            // 
            // btnInstallutil
            // 
            this.btnInstallutil.AutoSize = true;
            this.btnInstallutil.Location = new System.Drawing.Point(106, 36);
            this.btnInstallutil.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnInstallutil.Name = "btnInstallutil";
            this.btnInstallutil.Size = new System.Drawing.Size(78, 19);
            this.btnInstallutil.TabIndex = 6;
            this.btnInstallutil.Text = "InstallUtil";
            this.btnInstallutil.UseVisualStyleBackColor = true;
            this.btnInstallutil.CheckedChanged += new System.EventHandler(this.BtnInstallutil_CheckedChanged);
            // 
            // btnApplaunch
            // 
            this.btnApplaunch.AutoSize = true;
            this.btnApplaunch.Checked = true;
            this.btnApplaunch.Location = new System.Drawing.Point(15, 36);
            this.btnApplaunch.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnApplaunch.Name = "btnApplaunch";
            this.btnApplaunch.Size = new System.Drawing.Size(86, 19);
            this.btnApplaunch.TabIndex = 5;
            this.btnApplaunch.TabStop = true;
            this.btnApplaunch.Text = "AppLaunch";
            this.btnApplaunch.UseVisualStyleBackColor = true;
            this.btnApplaunch.CheckedChanged += new System.EventHandler(this.BtnApplaunch_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox4.Controls.Add(this.btnIcon);
            this.groupBox4.Controls.Add(this.btnInformation);
            this.groupBox4.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Cyan;
            this.groupBox4.Location = new System.Drawing.Point(9, 415);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox4.Size = new System.Drawing.Size(421, 84);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Assembly";
            // 
            // btnIcon
            // 
            this.btnIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIcon.ForeColor = System.Drawing.Color.Cyan;
            this.btnIcon.Location = new System.Drawing.Point(301, 30);
            this.btnIcon.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnIcon.Name = "btnIcon";
            this.btnIcon.Size = new System.Drawing.Size(102, 34);
            this.btnIcon.TabIndex = 9;
            this.btnIcon.Text = "Icon";
            this.btnIcon.UseVisualStyleBackColor = true;
            this.btnIcon.Click += new System.EventHandler(this.BtnIcon_Click);
            // 
            // btnInformation
            // 
            this.btnInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformation.ForeColor = System.Drawing.Color.Cyan;
            this.btnInformation.Location = new System.Drawing.Point(15, 30);
            this.btnInformation.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Size = new System.Drawing.Size(102, 34);
            this.btnInformation.TabIndex = 8;
            this.btnInformation.Text = "Information";
            this.btnInformation.UseVisualStyleBackColor = true;
            this.btnInformation.Click += new System.EventHandler(this.BtnInformation_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox5.Controls.Add(this.btnBuild);
            this.groupBox5.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.Cyan;
            this.groupBox5.Location = new System.Drawing.Point(9, 501);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox5.Size = new System.Drawing.Size(421, 92);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Create Payload";
            // 
            // btnBuild
            // 
            this.btnBuild.Enabled = false;
            this.btnBuild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuild.ForeColor = System.Drawing.Color.Cyan;
            this.btnBuild.Location = new System.Drawing.Point(151, 32);
            this.btnBuild.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(115, 36);
            this.btnBuild.TabIndex = 10;
            this.btnBuild.Text = "Build";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.BtnBuild_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(441, 600);
            this.Controls.Add(this.chkInstall);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chainski Crypter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPayloadBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPayload;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkInstall;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegistrynameRandom;
        private System.Windows.Forms.TextBox txtRegistryname;
        private System.Windows.Forms.Button btnFoldernameRandom;
        private System.Windows.Forms.Button btnFillenameRandom;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton btnApplaunch;
        private System.Windows.Forms.ComboBox txtFoldername;
        private System.Windows.Forms.RadioButton btnItself;
        private System.Windows.Forms.RadioButton btnInstallutil;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnIcon;
        private System.Windows.Forms.Button btnInformation;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.Button btnSecondFolderRandom;
        private System.Windows.Forms.TextBox txtSecondFolder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCmd;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton btnVBC;
        private System.Windows.Forms.RadioButton btnMsBuild;
    }
}