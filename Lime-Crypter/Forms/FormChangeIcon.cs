using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lime_Crypter.Forms
{
    public partial class FormChangeIcon : Form
    {
        public FormChangeIcon()
        {
            InitializeComponent();
        }

        private void S_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Icon (*.ico)|*.ico";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtIcon.Text = openFileDialog.FileName;
                    pictureIcon.ImageLocation = openFileDialog.FileName;
                    pictureIcon.BorderStyle = BorderStyle.FixedSingle;
                }
                else
                {
                    txtIcon.Text = string.Empty;
                    pictureIcon.ImageLocation = string.Empty;
                }
            }
        }
    }
}
