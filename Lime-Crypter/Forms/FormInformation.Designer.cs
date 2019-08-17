namespace Lime_Crypter.Forms
{
    partial class FormInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInformation));
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnClone = new System.Windows.Forms.Button();
            this.assemblyPrivatePart = new System.Windows.Forms.NumericUpDown();
            this.assemblyBuildPart = new System.Windows.Forms.NumericUpDown();
            this.assemblyMinorVersion = new System.Windows.Forms.NumericUpDown();
            this.assemblyMajorVersion = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtTrademark = new System.Windows.Forms.TextBox();
            this.txtCopyright = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.assemblyPrivatePart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assemblyBuildPart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assemblyMinorVersion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assemblyMajorVersion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(469, 192);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(105, 42);
            this.btnRandom.TabIndex = 22;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.BtnRandom_Click);
            // 
            // btnClone
            // 
            this.btnClone.Location = new System.Drawing.Point(581, 192);
            this.btnClone.Name = "btnClone";
            this.btnClone.Size = new System.Drawing.Size(105, 42);
            this.btnClone.TabIndex = 21;
            this.btnClone.Text = "Clone...";
            this.btnClone.UseVisualStyleBackColor = true;
            this.btnClone.Click += new System.EventHandler(this.BtnClone_Click);
            // 
            // assemblyPrivatePart
            // 
            this.assemblyPrivatePart.Location = new System.Drawing.Point(642, 123);
            this.assemblyPrivatePart.Name = "assemblyPrivatePart";
            this.assemblyPrivatePart.Size = new System.Drawing.Size(46, 26);
            this.assemblyPrivatePart.TabIndex = 19;
            // 
            // assemblyBuildPart
            // 
            this.assemblyBuildPart.Location = new System.Drawing.Point(585, 123);
            this.assemblyBuildPart.Name = "assemblyBuildPart";
            this.assemblyBuildPart.Size = new System.Drawing.Size(46, 26);
            this.assemblyBuildPart.TabIndex = 18;
            // 
            // assemblyMinorVersion
            // 
            this.assemblyMinorVersion.Location = new System.Drawing.Point(528, 123);
            this.assemblyMinorVersion.Name = "assemblyMinorVersion";
            this.assemblyMinorVersion.Size = new System.Drawing.Size(46, 26);
            this.assemblyMinorVersion.TabIndex = 17;
            // 
            // assemblyMajorVersion
            // 
            this.assemblyMajorVersion.Location = new System.Drawing.Point(474, 123);
            this.assemblyMajorVersion.Name = "assemblyMajorVersion";
            this.assemblyMajorVersion.Size = new System.Drawing.Size(46, 26);
            this.assemblyMajorVersion.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Company";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(371, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Version";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(371, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Trademark";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Copyright";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Title";
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(127, 182);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(212, 26);
            this.txtProduct.TabIndex = 8;
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(127, 123);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(212, 26);
            this.txtCompany.TabIndex = 7;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(127, 68);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(212, 26);
            this.txtDescription.TabIndex = 6;
            // 
            // txtTrademark
            // 
            this.txtTrademark.Location = new System.Drawing.Point(474, 65);
            this.txtTrademark.Name = "txtTrademark";
            this.txtTrademark.Size = new System.Drawing.Size(212, 26);
            this.txtTrademark.TabIndex = 5;
            // 
            // txtCopyright
            // 
            this.txtCopyright.Location = new System.Drawing.Point(474, 12);
            this.txtCopyright.Name = "txtCopyright";
            this.txtCopyright.Size = new System.Drawing.Size(212, 26);
            this.txtCopyright.TabIndex = 9;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(127, 12);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(212, 26);
            this.txtTitle.TabIndex = 4;
            // 
            // FormInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 267);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnClone);
            this.Controls.Add(this.assemblyPrivatePart);
            this.Controls.Add(this.assemblyBuildPart);
            this.Controls.Add(this.assemblyMinorVersion);
            this.Controls.Add(this.assemblyMajorVersion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTrademark);
            this.Controls.Add(this.txtCopyright);
            this.Controls.Add(this.txtTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Information";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.assemblyPrivatePart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assemblyBuildPart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assemblyMinorVersion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assemblyMajorVersion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnClone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown assemblyPrivatePart;
        public System.Windows.Forms.NumericUpDown assemblyBuildPart;
        public System.Windows.Forms.NumericUpDown assemblyMinorVersion;
        public System.Windows.Forms.NumericUpDown assemblyMajorVersion;
        public System.Windows.Forms.TextBox txtProduct;
        public System.Windows.Forms.TextBox txtCompany;
        public System.Windows.Forms.TextBox txtDescription;
        public System.Windows.Forms.TextBox txtTrademark;
        public System.Windows.Forms.TextBox txtCopyright;
        public System.Windows.Forms.TextBox txtTitle;
    }
}