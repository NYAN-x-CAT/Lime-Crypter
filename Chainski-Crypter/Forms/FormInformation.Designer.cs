namespace Chainski_Crypter.Forms
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
            this.btnRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandom.Location = new System.Drawing.Point(365, 144);
            this.btnRandom.Margin = new System.Windows.Forms.Padding(2);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(82, 31);
            this.btnRandom.TabIndex = 22;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.BtnRandom_Click);
            // 
            // btnClone
            // 
            this.btnClone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClone.Location = new System.Drawing.Point(451, 144);
            this.btnClone.Margin = new System.Windows.Forms.Padding(2);
            this.btnClone.Name = "btnClone";
            this.btnClone.Size = new System.Drawing.Size(82, 31);
            this.btnClone.TabIndex = 21;
            this.btnClone.Text = "Clone...";
            this.btnClone.UseVisualStyleBackColor = true;
            this.btnClone.Click += new System.EventHandler(this.BtnClone_Click);
            // 
            // assemblyPrivatePart
            // 
            this.assemblyPrivatePart.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.assemblyPrivatePart.Location = new System.Drawing.Point(499, 92);
            this.assemblyPrivatePart.Margin = new System.Windows.Forms.Padding(2);
            this.assemblyPrivatePart.Name = "assemblyPrivatePart";
            this.assemblyPrivatePart.Size = new System.Drawing.Size(36, 23);
            this.assemblyPrivatePart.TabIndex = 19;
            // 
            // assemblyBuildPart
            // 
            this.assemblyBuildPart.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.assemblyBuildPart.Location = new System.Drawing.Point(455, 92);
            this.assemblyBuildPart.Margin = new System.Windows.Forms.Padding(2);
            this.assemblyBuildPart.Name = "assemblyBuildPart";
            this.assemblyBuildPart.Size = new System.Drawing.Size(36, 23);
            this.assemblyBuildPart.TabIndex = 18;
            // 
            // assemblyMinorVersion
            // 
            this.assemblyMinorVersion.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.assemblyMinorVersion.Location = new System.Drawing.Point(411, 92);
            this.assemblyMinorVersion.Margin = new System.Windows.Forms.Padding(2);
            this.assemblyMinorVersion.Name = "assemblyMinorVersion";
            this.assemblyMinorVersion.Size = new System.Drawing.Size(36, 23);
            this.assemblyMinorVersion.TabIndex = 17;
            // 
            // assemblyMajorVersion
            // 
            this.assemblyMajorVersion.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.assemblyMajorVersion.Location = new System.Drawing.Point(369, 92);
            this.assemblyMajorVersion.Margin = new System.Windows.Forms.Padding(2);
            this.assemblyMajorVersion.Name = "assemblyMajorVersion";
            this.assemblyMajorVersion.Size = new System.Drawing.Size(36, 23);
            this.assemblyMajorVersion.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 138);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Company";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 95);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Version";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(288, 53);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Trademark";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Copyright";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Title";
            // 
            // txtProduct
            // 
            this.txtProduct.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtProduct.Location = new System.Drawing.Point(99, 136);
            this.txtProduct.Margin = new System.Windows.Forms.Padding(2);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(166, 23);
            this.txtProduct.TabIndex = 8;
            // 
            // txtCompany
            // 
            this.txtCompany.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCompany.Location = new System.Drawing.Point(99, 92);
            this.txtCompany.Margin = new System.Windows.Forms.Padding(2);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(166, 23);
            this.txtCompany.TabIndex = 7;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtDescription.Location = new System.Drawing.Point(99, 51);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(166, 23);
            this.txtDescription.TabIndex = 6;
            // 
            // txtTrademark
            // 
            this.txtTrademark.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTrademark.Location = new System.Drawing.Point(369, 48);
            this.txtTrademark.Margin = new System.Windows.Forms.Padding(2);
            this.txtTrademark.Name = "txtTrademark";
            this.txtTrademark.Size = new System.Drawing.Size(166, 23);
            this.txtTrademark.TabIndex = 5;
            // 
            // txtCopyright
            // 
            this.txtCopyright.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCopyright.Location = new System.Drawing.Point(369, 9);
            this.txtCopyright.Margin = new System.Windows.Forms.Padding(2);
            this.txtCopyright.Name = "txtCopyright";
            this.txtCopyright.Size = new System.Drawing.Size(166, 23);
            this.txtCopyright.TabIndex = 9;
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtTitle.Location = new System.Drawing.Point(99, 9);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(166, 23);
            this.txtTitle.TabIndex = 4;
            // 
            // FormInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(547, 201);
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
            this.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Cyan;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
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