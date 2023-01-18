﻿namespace Chainski_Crypter.Forms
{
    partial class FormChangeIcon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangeIcon));
            this.pictureIcon = new System.Windows.Forms.PictureBox();
            this.s = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIcon = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureIcon
            // 
            this.pictureIcon.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureIcon.Location = new System.Drawing.Point(85, 44);
            this.pictureIcon.Margin = new System.Windows.Forms.Padding(2);
            this.pictureIcon.Name = "pictureIcon";
            this.pictureIcon.Size = new System.Drawing.Size(64, 64);
            this.pictureIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureIcon.TabIndex = 8;
            this.pictureIcon.TabStop = false;
            // 
            // s
            // 
            this.s.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.s.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s.ForeColor = System.Drawing.Color.Cyan;
            this.s.Location = new System.Drawing.Point(283, 13);
            this.s.Margin = new System.Windows.Forms.Padding(2);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(85, 25);
            this.s.TabIndex = 5;
            this.s.Text = "Choose Icon";
            this.s.UseVisualStyleBackColor = true;
            this.s.Click += new System.EventHandler(this.S_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Cyan;
            this.label8.Location = new System.Drawing.Point(9, 21);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Icon Path";
            // 
            // txtIcon
            // 
            this.txtIcon.BackColor = System.Drawing.Color.DarkSlateGray;
            this.txtIcon.Location = new System.Drawing.Point(85, 16);
            this.txtIcon.Margin = new System.Windows.Forms.Padding(2);
            this.txtIcon.Name = "txtIcon";
            this.txtIcon.Size = new System.Drawing.Size(194, 20);
            this.txtIcon.TabIndex = 6;
            // 
            // FormChangeIcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(373, 127);
            this.Controls.Add(this.pictureIcon);
            this.Controls.Add(this.s);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIcon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormChangeIcon";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Change Icon";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormChangeIcon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureIcon;
        private System.Windows.Forms.Button s;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtIcon;
    }
}