namespace Lime_Crypter.Forms
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
            this.btnItself = new System.Windows.Forms.RadioButton();
            this.btnRegsvcs = new System.Windows.Forms.RadioButton();
            this.btnRegasm = new System.Windows.Forms.RadioButton();
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
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCmd);
            this.groupBox1.Controls.Add(this.btnPayloadBrowse);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPayload);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(540, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a file";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(474, 90);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(22, 21);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "-Command Line:";
            // 
            // txtCmd
            // 
            this.txtCmd.Enabled = false;
            this.txtCmd.Location = new System.Drawing.Point(158, 86);
            this.txtCmd.Name = "txtCmd";
            this.txtCmd.Size = new System.Drawing.Size(276, 26);
            this.txtCmd.TabIndex = 2;
            // 
            // btnPayloadBrowse
            // 
            this.btnPayloadBrowse.Location = new System.Drawing.Point(474, 34);
            this.btnPayloadBrowse.Name = "btnPayloadBrowse";
            this.btnPayloadBrowse.Size = new System.Drawing.Size(45, 28);
            this.btnPayloadBrowse.TabIndex = 0;
            this.btnPayloadBrowse.Text = "...";
            this.btnPayloadBrowse.UseVisualStyleBackColor = true;
            this.btnPayloadBrowse.Click += new System.EventHandler(this.BtnPayloadBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "-Payload:";
            // 
            // txtPayload
            // 
            this.txtPayload.Location = new System.Drawing.Point(158, 34);
            this.txtPayload.Name = "txtPayload";
            this.txtPayload.Size = new System.Drawing.Size(276, 26);
            this.txtPayload.TabIndex = 0;
            // 
            // groupBox2
            // 
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
            this.groupBox2.Location = new System.Drawing.Point(13, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(539, 212);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Installation";
            // 
            // btnSecondFolderRandom
            // 
            this.btnSecondFolderRandom.Location = new System.Drawing.Point(473, 129);
            this.btnSecondFolderRandom.Name = "btnSecondFolderRandom";
            this.btnSecondFolderRandom.Size = new System.Drawing.Size(45, 28);
            this.btnSecondFolderRandom.TabIndex = 10;
            this.btnSecondFolderRandom.Text = "...";
            this.btnSecondFolderRandom.UseVisualStyleBackColor = true;
            this.btnSecondFolderRandom.Click += new System.EventHandler(this.BtnSecondFolderRandom_Click);
            // 
            // txtSecondFolder
            // 
            this.txtSecondFolder.Location = new System.Drawing.Point(157, 129);
            this.txtSecondFolder.Multiline = true;
            this.txtSecondFolder.Name = "txtSecondFolder";
            this.txtSecondFolder.Size = new System.Drawing.Size(276, 28);
            this.txtSecondFolder.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "-Second folder";
            // 
            // txtFoldername
            // 
            this.txtFoldername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtFoldername.FormattingEnabled = true;
            this.txtFoldername.Location = new System.Drawing.Point(157, 87);
            this.txtFoldername.Name = "txtFoldername";
            this.txtFoldername.Size = new System.Drawing.Size(276, 28);
            this.txtFoldername.TabIndex = 9;
            // 
            // btnRegistrynameRandom
            // 
            this.btnRegistrynameRandom.Location = new System.Drawing.Point(473, 166);
            this.btnRegistrynameRandom.Name = "btnRegistrynameRandom";
            this.btnRegistrynameRandom.Size = new System.Drawing.Size(45, 28);
            this.btnRegistrynameRandom.TabIndex = 4;
            this.btnRegistrynameRandom.Text = "...";
            this.btnRegistrynameRandom.UseVisualStyleBackColor = true;
            this.btnRegistrynameRandom.Click += new System.EventHandler(this.BtnRegistrynameRandom_Click);
            // 
            // txtRegistryname
            // 
            this.txtRegistryname.Location = new System.Drawing.Point(157, 166);
            this.txtRegistryname.Multiline = true;
            this.txtRegistryname.Name = "txtRegistryname";
            this.txtRegistryname.Size = new System.Drawing.Size(276, 28);
            this.txtRegistryname.TabIndex = 7;
            // 
            // btnFoldernameRandom
            // 
            this.btnFoldernameRandom.Location = new System.Drawing.Point(473, 87);
            this.btnFoldernameRandom.Name = "btnFoldernameRandom";
            this.btnFoldernameRandom.Size = new System.Drawing.Size(45, 28);
            this.btnFoldernameRandom.TabIndex = 3;
            this.btnFoldernameRandom.Text = "...";
            this.btnFoldernameRandom.UseVisualStyleBackColor = true;
            this.btnFoldernameRandom.Click += new System.EventHandler(this.BtnFoldernameRandom_Click);
            // 
            // btnFillenameRandom
            // 
            this.btnFillenameRandom.Location = new System.Drawing.Point(473, 44);
            this.btnFillenameRandom.Name = "btnFillenameRandom";
            this.btnFillenameRandom.Size = new System.Drawing.Size(45, 28);
            this.btnFillenameRandom.TabIndex = 2;
            this.btnFillenameRandom.Text = "...";
            this.btnFillenameRandom.UseVisualStyleBackColor = true;
            this.btnFillenameRandom.Click += new System.EventHandler(this.BtnFillenameRandom_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "-Registry name";
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(157, 44);
            this.txtFilename.Multiline = true;
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(276, 28);
            this.txtFilename.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "-Folder name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "-File name";
            // 
            // chkInstall
            // 
            this.chkInstall.AutoSize = true;
            this.chkInstall.Location = new System.Drawing.Point(23, 167);
            this.chkInstall.Name = "chkInstall";
            this.chkInstall.Size = new System.Drawing.Size(22, 21);
            this.chkInstall.TabIndex = 1;
            this.chkInstall.UseVisualStyleBackColor = true;
            this.chkInstall.CheckedChanged += new System.EventHandler(this.ChkInstall_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnItself);
            this.groupBox3.Controls.Add(this.btnRegsvcs);
            this.groupBox3.Controls.Add(this.btnRegasm);
            this.groupBox3.Location = new System.Drawing.Point(23, 427);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(529, 106);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Injection";
            // 
            // btnItself
            // 
            this.btnItself.AutoSize = true;
            this.btnItself.Location = new System.Drawing.Point(433, 49);
            this.btnItself.Name = "btnItself";
            this.btnItself.Size = new System.Drawing.Size(69, 24);
            this.btnItself.TabIndex = 7;
            this.btnItself.Text = "Itself";
            this.btnItself.UseVisualStyleBackColor = true;
            this.btnItself.CheckedChanged += new System.EventHandler(this.BtnItself_CheckedChanged);
            // 
            // btnRegsvcs
            // 
            this.btnRegsvcs.AutoSize = true;
            this.btnRegsvcs.Location = new System.Drawing.Point(223, 49);
            this.btnRegsvcs.Name = "btnRegsvcs";
            this.btnRegsvcs.Size = new System.Drawing.Size(98, 24);
            this.btnRegsvcs.TabIndex = 6;
            this.btnRegsvcs.Text = "RegSvcs";
            this.btnRegsvcs.UseVisualStyleBackColor = true;
            this.btnRegsvcs.CheckedChanged += new System.EventHandler(this.BtnRegsvcs_CheckedChanged);
            // 
            // btnRegasm
            // 
            this.btnRegasm.AutoSize = true;
            this.btnRegasm.Checked = true;
            this.btnRegasm.Location = new System.Drawing.Point(19, 49);
            this.btnRegasm.Name = "btnRegasm";
            this.btnRegasm.Size = new System.Drawing.Size(96, 24);
            this.btnRegasm.TabIndex = 5;
            this.btnRegasm.TabStop = true;
            this.btnRegasm.Text = "RegAsm";
            this.btnRegasm.UseVisualStyleBackColor = true;
            this.btnRegasm.CheckedChanged += new System.EventHandler(this.BtnRegasm_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnIcon);
            this.groupBox4.Controls.Add(this.btnInformation);
            this.groupBox4.Location = new System.Drawing.Point(22, 553);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(530, 100);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Assembly";
            // 
            // btnIcon
            // 
            this.btnIcon.Location = new System.Drawing.Point(353, 40);
            this.btnIcon.Name = "btnIcon";
            this.btnIcon.Size = new System.Drawing.Size(130, 46);
            this.btnIcon.TabIndex = 9;
            this.btnIcon.Text = "Icon";
            this.btnIcon.UseVisualStyleBackColor = true;
            this.btnIcon.Click += new System.EventHandler(this.BtnIcon_Click);
            // 
            // btnInformation
            // 
            this.btnInformation.Location = new System.Drawing.Point(38, 40);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Size = new System.Drawing.Size(130, 46);
            this.btnInformation.TabIndex = 8;
            this.btnInformation.Text = "Information";
            this.btnInformation.UseVisualStyleBackColor = true;
            this.btnInformation.Click += new System.EventHandler(this.BtnInformation_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnBuild);
            this.groupBox5.Location = new System.Drawing.Point(22, 670);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(530, 79);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Build";
            // 
            // btnBuild
            // 
            this.btnBuild.Enabled = false;
            this.btnBuild.Location = new System.Drawing.Point(197, 29);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(130, 28);
            this.btnBuild.TabIndex = 10;
            this.btnBuild.Text = "...";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.BtnBuild_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 765);
            this.Controls.Add(this.chkInstall);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lime Crypter";
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
        private System.Windows.Forms.RadioButton btnRegasm;
        private System.Windows.Forms.ComboBox txtFoldername;
        private System.Windows.Forms.RadioButton btnItself;
        private System.Windows.Forms.RadioButton btnRegsvcs;
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
    }
}