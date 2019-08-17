using Lime_Crypter.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lime_Crypter.Forms
{
    public partial class FormInformation : Form
    {
        private readonly RandomFileInfo randomFileInfo;
        private readonly RandomCharacters randomCharacters;

        public FormInformation()
        {
            this.randomCharacters = new RandomCharacters();
            this.randomFileInfo = new RandomFileInfo(randomCharacters);
            InitializeComponent();
        }

        private void BtnRandom_Click(object sender, EventArgs e)
        {
            var newInfo = randomFileInfo.getRandomFileInfo();
            txtTitle.Text = newInfo.Title;
            txtDescription.Text = newInfo.Description;
            txtProduct.Text = newInfo.Product;
            txtCompany.Text = newInfo.Company;
            txtCopyright.Text = newInfo.Copyright;
            txtTrademark.Text = newInfo.Trademark;
            assemblyMajorVersion.Text = newInfo.MajorVersion;
            assemblyMinorVersion.Text = newInfo.MinorVersion;
            assemblyBuildPart.Text = newInfo.BuildPart;
            assemblyPrivatePart.Text = newInfo.PrivatePart;
        }

        private void BtnClone_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Executable (*.exe)|*.exe";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileVersionInfo = FileVersionInfo.GetVersionInfo(openFileDialog.FileName);

                    txtTitle.Text = fileVersionInfo.InternalName ?? string.Empty;
                    txtDescription.Text = fileVersionInfo.FileDescription ?? string.Empty;
                    txtProduct.Text = fileVersionInfo.CompanyName ?? string.Empty;
                    txtCompany.Text = fileVersionInfo.ProductName ?? string.Empty;
                    txtCopyright.Text = fileVersionInfo.LegalCopyright ?? string.Empty;
                    txtTrademark.Text = fileVersionInfo.LegalTrademarks ?? string.Empty;

                    var version = fileVersionInfo.FileMajorPart;
                    assemblyMajorVersion.Text = fileVersionInfo.FileMajorPart.ToString();
                    assemblyMinorVersion.Text = fileVersionInfo.FileMinorPart.ToString();
                    assemblyBuildPart.Text = fileVersionInfo.FileBuildPart.ToString();
                    assemblyPrivatePart.Text = fileVersionInfo.FilePrivatePart.ToString();
                }
            }
        }
    }
}
