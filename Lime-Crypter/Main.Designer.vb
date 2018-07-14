<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.PvForm1 = New Lime_Crypter.PVForm()
        Me.PvButton1 = New Lime_Crypter.PVButton()
        Me.PvTabControl_Side1 = New Lime_Crypter.PVTabControl_Side()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.PvEmbeddedButton1 = New Lime_Crypter.PVEmbeddedButton()
        Me.PvGroupbox4 = New Lime_Crypter.PVGroupbox()
        Me.chkBindOnce = New Lime_Crypter.PVCheckbox()
        Me.chkBind = New Lime_Crypter.PVCheckbox()
        Me.txtBind = New Lime_Crypter.PVTextbox()
        Me.btnBind = New Lime_Crypter.PVButton()
        Me.PvGroupbox3 = New Lime_Crypter.PVGroupbox()
        Me.chkRegasm = New Lime_Crypter.PVRadiobutton()
        Me.chkItself = New Lime_Crypter.PVRadiobutton()
        Me.txtPayload = New Lime_Crypter.PVTextbox()
        Me.btnPayload = New Lime_Crypter.PVButton()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.PvGroupbox2 = New Lime_Crypter.PVGroupbox()
        Me.chkDelay = New Lime_Crypter.PVCheckbox()
        Me.chkPump = New Lime_Crypter.PVCheckbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.numPump = New Lime_Crypter.PVNumericUD()
        Me.chkZoneIden = New Lime_Crypter.PVCheckbox()
        Me.numDelay = New Lime_Crypter.PVNumericUD()
        Me.chkAntiVM = New Lime_Crypter.PVCheckbox()
        Me.chkAntiTask = New Lime_Crypter.PVCheckbox()
        Me.chkAntiWireshark = New Lime_Crypter.PVCheckbox()
        Me.PvGroupbox1 = New Lime_Crypter.PVGroupbox()
        Me.chkDrop = New Lime_Crypter.PVCheckbox()
        Me.txtDropName = New Lime_Crypter.PVTextbox()
        Me.txtDropPath = New System.Windows.Forms.ComboBox()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.chkAssembly = New Lime_Crypter.PVCheckbox()
        Me.picIcon = New System.Windows.Forms.PictureBox()
        Me.chkIcon = New Lime_Crypter.PVCheckbox()
        Me.btnAssemblyRandom = New Lime_Crypter.PVButton()
        Me.btnAssemblyClone = New Lime_Crypter.PVButton()
        Me.numAssembly4 = New Lime_Crypter.PVNumericUD()
        Me.numAssembly3 = New Lime_Crypter.PVNumericUD()
        Me.numAssembly2 = New Lime_Crypter.PVNumericUD()
        Me.numAssembly1 = New Lime_Crypter.PVNumericUD()
        Me.txtAssemblyTrademark = New Lime_Crypter.PVTextbox()
        Me.txtAssemblyCopyright = New Lime_Crypter.PVTextbox()
        Me.txtAssemblyProduct = New Lime_Crypter.PVTextbox()
        Me.txtAssemblyCompany = New Lime_Crypter.PVTextbox()
        Me.txtAssemblyDescription = New Lime_Crypter.PVTextbox()
        Me.txtAssemblyTitle = New Lime_Crypter.PVTextbox()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.btnBuild = New Lime_Crypter.PVButton()
        Me.txtLog = New System.Windows.Forms.RichTextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picNyanCat = New System.Windows.Forms.PictureBox()
        Me.PvForm1.SuspendLayout()
        Me.PvTabControl_Side1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.PvGroupbox4.SuspendLayout()
        Me.PvGroupbox3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.PvGroupbox2.SuspendLayout()
        Me.PvGroupbox1.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage7.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.picNyanCat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PvForm1
        '
        Me.PvForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.PvForm1.Controls.Add(Me.PvButton1)
        Me.PvForm1.Controls.Add(Me.PvTabControl_Side1)
        Me.PvForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PvForm1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.PvForm1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.PvForm1.Location = New System.Drawing.Point(0, 0)
        Me.PvForm1.MinimumSize = New System.Drawing.Size(305, 150)
        Me.PvForm1.Name = "PvForm1"
        Me.PvForm1.Size = New System.Drawing.Size(911, 517)
        Me.PvForm1.TabIndex = 0
        Me.PvForm1.Text = "Lime Crypter"
        '
        'PvButton1
        '
        Me.PvButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.PvButton1.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.PvButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.PvButton1.Location = New System.Drawing.Point(873, 3)
        Me.PvButton1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.PvButton1.Name = "PvButton1"
        Me.PvButton1.Size = New System.Drawing.Size(22, 22)
        Me.PvButton1.TabIndex = 4
        Me.PvButton1.Text = "X"
        '
        'PvTabControl_Side1
        '
        Me.PvTabControl_Side1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.PvTabControl_Side1.Controls.Add(Me.TabPage3)
        Me.PvTabControl_Side1.Controls.Add(Me.TabPage4)
        Me.PvTabControl_Side1.Controls.Add(Me.TabPage6)
        Me.PvTabControl_Side1.Controls.Add(Me.TabPage7)
        Me.PvTabControl_Side1.Controls.Add(Me.TabPage1)
        Me.PvTabControl_Side1.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.PvTabControl_Side1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.PvTabControl_Side1.ItemSize = New System.Drawing.Size(50, 100)
        Me.PvTabControl_Side1.Location = New System.Drawing.Point(12, 43)
        Me.PvTabControl_Side1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.PvTabControl_Side1.Multiline = True
        Me.PvTabControl_Side1.Name = "PvTabControl_Side1"
        Me.PvTabControl_Side1.SelectedIndex = 0
        Me.PvTabControl_Side1.Size = New System.Drawing.Size(887, 462)
        Me.PvTabControl_Side1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.PvTabControl_Side1.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.PvEmbeddedButton1)
        Me.TabPage3.Controls.Add(Me.PvGroupbox4)
        Me.TabPage3.Controls.Add(Me.PvGroupbox3)
        Me.TabPage3.Location = New System.Drawing.Point(104, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(779, 454)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "File"
        '
        'PvEmbeddedButton1
        '
        Me.PvEmbeddedButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.PvEmbeddedButton1.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.PvEmbeddedButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.PvEmbeddedButton1.Location = New System.Drawing.Point(15, 341)
        Me.PvEmbeddedButton1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.PvEmbeddedButton1.Name = "PvEmbeddedButton1"
        Me.PvEmbeddedButton1.Size = New System.Drawing.Size(565, 61)
        Me.PvEmbeddedButton1.TabIndex = 4
        Me.PvEmbeddedButton1.Text = "Recommended Settings"
        '
        'PvGroupbox4
        '
        Me.PvGroupbox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.PvGroupbox4.Controls.Add(Me.chkBindOnce)
        Me.PvGroupbox4.Controls.Add(Me.chkBind)
        Me.PvGroupbox4.Controls.Add(Me.txtBind)
        Me.PvGroupbox4.Controls.Add(Me.btnBind)
        Me.PvGroupbox4.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.PvGroupbox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.PvGroupbox4.Location = New System.Drawing.Point(15, 198)
        Me.PvGroupbox4.MinimumSize = New System.Drawing.Size(20, 20)
        Me.PvGroupbox4.Name = "PvGroupbox4"
        Me.PvGroupbox4.Size = New System.Drawing.Size(565, 115)
        Me.PvGroupbox4.TabIndex = 3
        Me.PvGroupbox4.Text = " Bind File"
        '
        'chkBindOnce
        '
        Me.chkBindOnce.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.chkBindOnce.Checked = False
        Me.chkBindOnce.Enabled = False
        Me.chkBindOnce.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.chkBindOnce.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.chkBindOnce.Location = New System.Drawing.Point(293, 3)
        Me.chkBindOnce.MinimumSize = New System.Drawing.Size(20, 20)
        Me.chkBindOnce.Name = "chkBindOnce"
        Me.chkBindOnce.Size = New System.Drawing.Size(125, 30)
        Me.chkBindOnce.TabIndex = 17
        Me.chkBindOnce.Text = "Once"
        '
        'chkBind
        '
        Me.chkBind.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.chkBind.Checked = False
        Me.chkBind.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.chkBind.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.chkBind.Location = New System.Drawing.Point(108, 3)
        Me.chkBind.MinimumSize = New System.Drawing.Size(20, 20)
        Me.chkBind.Name = "chkBind"
        Me.chkBind.Size = New System.Drawing.Size(125, 30)
        Me.chkBind.TabIndex = 16
        Me.chkBind.Text = "Enable"
        '
        'txtBind
        '
        Me.txtBind.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.txtBind.BorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtBind.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBind.Enabled = False
        Me.txtBind.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.txtBind.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtBind.InteriorColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtBind.Location = New System.Drawing.Point(17, 58)
        Me.txtBind.MinimumSize = New System.Drawing.Size(20, 20)
        Me.txtBind.Multiline = True
        Me.txtBind.Name = "txtBind"
        Me.txtBind.Size = New System.Drawing.Size(381, 34)
        Me.txtBind.TabIndex = 1
        Me.txtBind.Text = "..."
        '
        'btnBind
        '
        Me.btnBind.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.btnBind.Enabled = False
        Me.btnBind.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.btnBind.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnBind.Location = New System.Drawing.Point(441, 56)
        Me.btnBind.MinimumSize = New System.Drawing.Size(20, 20)
        Me.btnBind.Name = "btnBind"
        Me.btnBind.Size = New System.Drawing.Size(97, 36)
        Me.btnBind.TabIndex = 0
        Me.btnBind.Text = "Browser"
        '
        'PvGroupbox3
        '
        Me.PvGroupbox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.PvGroupbox3.Controls.Add(Me.chkRegasm)
        Me.PvGroupbox3.Controls.Add(Me.chkItself)
        Me.PvGroupbox3.Controls.Add(Me.txtPayload)
        Me.PvGroupbox3.Controls.Add(Me.btnPayload)
        Me.PvGroupbox3.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.PvGroupbox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.PvGroupbox3.Location = New System.Drawing.Point(15, 17)
        Me.PvGroupbox3.MinimumSize = New System.Drawing.Size(20, 20)
        Me.PvGroupbox3.Name = "PvGroupbox3"
        Me.PvGroupbox3.Size = New System.Drawing.Size(565, 158)
        Me.PvGroupbox3.TabIndex = 2
        Me.PvGroupbox3.Text = " Payload"
        '
        'chkRegasm
        '
        Me.chkRegasm.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.chkRegasm.Checked = False
        Me.chkRegasm.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.chkRegasm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.chkRegasm.Location = New System.Drawing.Point(202, 101)
        Me.chkRegasm.MinimumSize = New System.Drawing.Size(20, 20)
        Me.chkRegasm.Name = "chkRegasm"
        Me.chkRegasm.Size = New System.Drawing.Size(196, 30)
        Me.chkRegasm.TabIndex = 3
        Me.chkRegasm.Text = "Inject Regasm"
        '
        'chkItself
        '
        Me.chkItself.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.chkItself.Checked = True
        Me.chkItself.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.chkItself.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.chkItself.Location = New System.Drawing.Point(17, 101)
        Me.chkItself.MinimumSize = New System.Drawing.Size(20, 20)
        Me.chkItself.Name = "chkItself"
        Me.chkItself.Size = New System.Drawing.Size(193, 30)
        Me.chkItself.TabIndex = 2
        Me.chkItself.Text = "Inject Itself"
        '
        'txtPayload
        '
        Me.txtPayload.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.txtPayload.BorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtPayload.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPayload.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.txtPayload.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtPayload.InteriorColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtPayload.Location = New System.Drawing.Point(17, 46)
        Me.txtPayload.MinimumSize = New System.Drawing.Size(20, 20)
        Me.txtPayload.Multiline = True
        Me.txtPayload.Name = "txtPayload"
        Me.txtPayload.Size = New System.Drawing.Size(381, 34)
        Me.txtPayload.TabIndex = 1
        Me.txtPayload.Text = "..."
        '
        'btnPayload
        '
        Me.btnPayload.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.btnPayload.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.btnPayload.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnPayload.Location = New System.Drawing.Point(441, 44)
        Me.btnPayload.MinimumSize = New System.Drawing.Size(20, 20)
        Me.btnPayload.Name = "btnPayload"
        Me.btnPayload.Size = New System.Drawing.Size(97, 36)
        Me.btnPayload.TabIndex = 0
        Me.btnPayload.Text = "Browser"
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.TabPage4.Controls.Add(Me.PvGroupbox2)
        Me.TabPage4.Controls.Add(Me.PvGroupbox1)
        Me.TabPage4.Location = New System.Drawing.Point(104, 4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(779, 454)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Settings"
        '
        'PvGroupbox2
        '
        Me.PvGroupbox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.PvGroupbox2.Controls.Add(Me.chkDelay)
        Me.PvGroupbox2.Controls.Add(Me.chkPump)
        Me.PvGroupbox2.Controls.Add(Me.Label4)
        Me.PvGroupbox2.Controls.Add(Me.Label3)
        Me.PvGroupbox2.Controls.Add(Me.numPump)
        Me.PvGroupbox2.Controls.Add(Me.chkZoneIden)
        Me.PvGroupbox2.Controls.Add(Me.numDelay)
        Me.PvGroupbox2.Controls.Add(Me.chkAntiVM)
        Me.PvGroupbox2.Controls.Add(Me.chkAntiTask)
        Me.PvGroupbox2.Controls.Add(Me.chkAntiWireshark)
        Me.PvGroupbox2.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.PvGroupbox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.PvGroupbox2.Location = New System.Drawing.Point(17, 174)
        Me.PvGroupbox2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.PvGroupbox2.Name = "PvGroupbox2"
        Me.PvGroupbox2.Size = New System.Drawing.Size(566, 234)
        Me.PvGroupbox2.TabIndex = 1
        Me.PvGroupbox2.Text = " Miscellaneous"
        '
        'chkDelay
        '
        Me.chkDelay.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.chkDelay.Checked = False
        Me.chkDelay.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.chkDelay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.chkDelay.Location = New System.Drawing.Point(304, 166)
        Me.chkDelay.MinimumSize = New System.Drawing.Size(20, 20)
        Me.chkDelay.Name = "chkDelay"
        Me.chkDelay.Size = New System.Drawing.Size(109, 30)
        Me.chkDelay.TabIndex = 11
        Me.chkDelay.Text = " Delay"
        '
        'chkPump
        '
        Me.chkPump.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.chkPump.Checked = False
        Me.chkPump.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.chkPump.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.chkPump.Location = New System.Drawing.Point(304, 109)
        Me.chkPump.MinimumSize = New System.Drawing.Size(20, 20)
        Me.chkPump.Name = "chkPump"
        Me.chkPump.Size = New System.Drawing.Size(109, 30)
        Me.chkPump.TabIndex = 10
        Me.chkPump.Text = " Pump"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(518, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 26)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "SEC"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(518, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 26)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "KB"
        '
        'numPump
        '
        Me.numPump.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.numPump.ButtonChange = 1
        Me.numPump.Enabled = False
        Me.numPump.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.numPump.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.numPump.Location = New System.Drawing.Point(419, 109)
        Me.numPump.Maximum = 1000
        Me.numPump.Minimum = 10
        Me.numPump.MinimumSize = New System.Drawing.Size(20, 20)
        Me.numPump.Name = "numPump"
        Me.numPump.Size = New System.Drawing.Size(93, 30)
        Me.numPump.TabIndex = 6
        Me.numPump.Text = "PvNumericUD6"
        Me.numPump.Value = 10
        '
        'chkZoneIden
        '
        Me.chkZoneIden.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.chkZoneIden.Checked = False
        Me.chkZoneIden.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.chkZoneIden.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.chkZoneIden.Location = New System.Drawing.Point(304, 49)
        Me.chkZoneIden.MinimumSize = New System.Drawing.Size(20, 20)
        Me.chkZoneIden.Name = "chkZoneIden"
        Me.chkZoneIden.Size = New System.Drawing.Size(259, 30)
        Me.chkZoneIden.TabIndex = 5
        Me.chkZoneIden.Text = "Delete Zone-Identifier"
        '
        'numDelay
        '
        Me.numDelay.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.numDelay.ButtonChange = 1
        Me.numDelay.Enabled = False
        Me.numDelay.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.numDelay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.numDelay.Location = New System.Drawing.Point(419, 166)
        Me.numDelay.Maximum = 1000
        Me.numDelay.Minimum = 5
        Me.numDelay.MinimumSize = New System.Drawing.Size(20, 20)
        Me.numDelay.Name = "numDelay"
        Me.numDelay.Size = New System.Drawing.Size(93, 30)
        Me.numDelay.TabIndex = 3
        Me.numDelay.Text = "PvNumericUD1"
        Me.numDelay.Value = 5
        '
        'chkAntiVM
        '
        Me.chkAntiVM.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.chkAntiVM.Checked = False
        Me.chkAntiVM.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.chkAntiVM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.chkAntiVM.Location = New System.Drawing.Point(8, 166)
        Me.chkAntiVM.MinimumSize = New System.Drawing.Size(20, 20)
        Me.chkAntiVM.Name = "chkAntiVM"
        Me.chkAntiVM.Size = New System.Drawing.Size(278, 30)
        Me.chkAntiVM.TabIndex = 2
        Me.chkAntiVM.Text = " Anti Virtual Machines"
        '
        'chkAntiTask
        '
        Me.chkAntiTask.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.chkAntiTask.Checked = False
        Me.chkAntiTask.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.chkAntiTask.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.chkAntiTask.Location = New System.Drawing.Point(8, 109)
        Me.chkAntiTask.MinimumSize = New System.Drawing.Size(20, 20)
        Me.chkAntiTask.Name = "chkAntiTask"
        Me.chkAntiTask.Size = New System.Drawing.Size(278, 30)
        Me.chkAntiTask.TabIndex = 1
        Me.chkAntiTask.Text = " Anti Task Manager"
        '
        'chkAntiWireshark
        '
        Me.chkAntiWireshark.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.chkAntiWireshark.Checked = False
        Me.chkAntiWireshark.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.chkAntiWireshark.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.chkAntiWireshark.Location = New System.Drawing.Point(8, 49)
        Me.chkAntiWireshark.MinimumSize = New System.Drawing.Size(20, 20)
        Me.chkAntiWireshark.Name = "chkAntiWireshark"
        Me.chkAntiWireshark.Size = New System.Drawing.Size(278, 30)
        Me.chkAntiWireshark.TabIndex = 0
        Me.chkAntiWireshark.Text = " Anti Wireshark"
        '
        'PvGroupbox1
        '
        Me.PvGroupbox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.PvGroupbox1.Controls.Add(Me.chkDrop)
        Me.PvGroupbox1.Controls.Add(Me.txtDropName)
        Me.PvGroupbox1.Controls.Add(Me.txtDropPath)
        Me.PvGroupbox1.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.PvGroupbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.PvGroupbox1.Location = New System.Drawing.Point(17, 21)
        Me.PvGroupbox1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.PvGroupbox1.Name = "PvGroupbox1"
        Me.PvGroupbox1.Size = New System.Drawing.Size(566, 119)
        Me.PvGroupbox1.TabIndex = 0
        Me.PvGroupbox1.Text = " Installation"
        '
        'chkDrop
        '
        Me.chkDrop.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.chkDrop.Checked = False
        Me.chkDrop.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.chkDrop.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.chkDrop.Location = New System.Drawing.Point(135, 5)
        Me.chkDrop.MinimumSize = New System.Drawing.Size(20, 20)
        Me.chkDrop.Name = "chkDrop"
        Me.chkDrop.Size = New System.Drawing.Size(130, 30)
        Me.chkDrop.TabIndex = 15
        Me.chkDrop.Text = "Enable"
        '
        'txtDropName
        '
        Me.txtDropName.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.txtDropName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtDropName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDropName.Enabled = False
        Me.txtDropName.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.txtDropName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtDropName.InteriorColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtDropName.Location = New System.Drawing.Point(228, 73)
        Me.txtDropName.MinimumSize = New System.Drawing.Size(20, 20)
        Me.txtDropName.Multiline = True
        Me.txtDropName.Name = "txtDropName"
        Me.txtDropName.Size = New System.Drawing.Size(199, 26)
        Me.txtDropName.TabIndex = 2
        Me.txtDropName.Text = "Filename.exe"
        '
        'txtDropPath
        '
        Me.txtDropPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtDropPath.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtDropPath.Enabled = False
        Me.txtDropPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtDropPath.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtDropPath.Items.AddRange(New Object() {"Appdata", "Temp", "UserProfile"})
        Me.txtDropPath.Location = New System.Drawing.Point(8, 65)
        Me.txtDropPath.Name = "txtDropPath"
        Me.txtDropPath.Size = New System.Drawing.Size(146, 34)
        Me.txtDropPath.TabIndex = 1
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.TabPage6.Controls.Add(Me.chkAssembly)
        Me.TabPage6.Controls.Add(Me.picIcon)
        Me.TabPage6.Controls.Add(Me.chkIcon)
        Me.TabPage6.Controls.Add(Me.btnAssemblyRandom)
        Me.TabPage6.Controls.Add(Me.btnAssemblyClone)
        Me.TabPage6.Controls.Add(Me.numAssembly4)
        Me.TabPage6.Controls.Add(Me.numAssembly3)
        Me.TabPage6.Controls.Add(Me.numAssembly2)
        Me.TabPage6.Controls.Add(Me.numAssembly1)
        Me.TabPage6.Controls.Add(Me.txtAssemblyTrademark)
        Me.TabPage6.Controls.Add(Me.txtAssemblyCopyright)
        Me.TabPage6.Controls.Add(Me.txtAssemblyProduct)
        Me.TabPage6.Controls.Add(Me.txtAssemblyCompany)
        Me.TabPage6.Controls.Add(Me.txtAssemblyDescription)
        Me.TabPage6.Controls.Add(Me.txtAssemblyTitle)
        Me.TabPage6.Location = New System.Drawing.Point(104, 4)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(779, 454)
        Me.TabPage6.TabIndex = 3
        Me.TabPage6.Text = "Assembly"
        '
        'chkAssembly
        '
        Me.chkAssembly.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.chkAssembly.Checked = False
        Me.chkAssembly.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.chkAssembly.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.chkAssembly.Location = New System.Drawing.Point(17, 14)
        Me.chkAssembly.MinimumSize = New System.Drawing.Size(20, 20)
        Me.chkAssembly.Name = "chkAssembly"
        Me.chkAssembly.Size = New System.Drawing.Size(189, 30)
        Me.chkAssembly.TabIndex = 14
        Me.chkAssembly.Text = "Enable"
        '
        'picIcon
        '
        Me.picIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picIcon.Enabled = False
        Me.picIcon.ErrorImage = Nothing
        Me.picIcon.InitialImage = Nothing
        Me.picIcon.Location = New System.Drawing.Point(615, 84)
        Me.picIcon.Name = "picIcon"
        Me.picIcon.Size = New System.Drawing.Size(96, 96)
        Me.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picIcon.TabIndex = 13
        Me.picIcon.TabStop = False
        '
        'chkIcon
        '
        Me.chkIcon.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.chkIcon.Checked = False
        Me.chkIcon.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.chkIcon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.chkIcon.Location = New System.Drawing.Point(615, 17)
        Me.chkIcon.MinimumSize = New System.Drawing.Size(20, 20)
        Me.chkIcon.Name = "chkIcon"
        Me.chkIcon.Size = New System.Drawing.Size(118, 30)
        Me.chkIcon.TabIndex = 12
        Me.chkIcon.Text = "Icon"
        '
        'btnAssemblyRandom
        '
        Me.btnAssemblyRandom.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.btnAssemblyRandom.Enabled = False
        Me.btnAssemblyRandom.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.btnAssemblyRandom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnAssemblyRandom.Location = New System.Drawing.Point(402, 326)
        Me.btnAssemblyRandom.MinimumSize = New System.Drawing.Size(20, 20)
        Me.btnAssemblyRandom.Name = "btnAssemblyRandom"
        Me.btnAssemblyRandom.Size = New System.Drawing.Size(109, 42)
        Me.btnAssemblyRandom.TabIndex = 11
        Me.btnAssemblyRandom.Text = "Random"
        '
        'btnAssemblyClone
        '
        Me.btnAssemblyClone.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.btnAssemblyClone.Enabled = False
        Me.btnAssemblyClone.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.btnAssemblyClone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnAssemblyClone.Location = New System.Drawing.Point(402, 258)
        Me.btnAssemblyClone.MinimumSize = New System.Drawing.Size(20, 20)
        Me.btnAssemblyClone.Name = "btnAssemblyClone"
        Me.btnAssemblyClone.Size = New System.Drawing.Size(109, 42)
        Me.btnAssemblyClone.TabIndex = 10
        Me.btnAssemblyClone.Text = "Clone"
        '
        'numAssembly4
        '
        Me.numAssembly4.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.numAssembly4.ButtonChange = 1
        Me.numAssembly4.Enabled = False
        Me.numAssembly4.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.numAssembly4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.numAssembly4.Location = New System.Drawing.Point(299, 384)
        Me.numAssembly4.Maximum = 100
        Me.numAssembly4.Minimum = 1
        Me.numAssembly4.MinimumSize = New System.Drawing.Size(20, 20)
        Me.numAssembly4.Name = "numAssembly4"
        Me.numAssembly4.Size = New System.Drawing.Size(53, 30)
        Me.numAssembly4.TabIndex = 9
        Me.numAssembly4.Text = "PvNumericUD5"
        Me.numAssembly4.Value = 0
        '
        'numAssembly3
        '
        Me.numAssembly3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.numAssembly3.ButtonChange = 1
        Me.numAssembly3.Enabled = False
        Me.numAssembly3.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.numAssembly3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.numAssembly3.Location = New System.Drawing.Point(202, 384)
        Me.numAssembly3.Maximum = 100
        Me.numAssembly3.Minimum = 1
        Me.numAssembly3.MinimumSize = New System.Drawing.Size(20, 20)
        Me.numAssembly3.Name = "numAssembly3"
        Me.numAssembly3.Size = New System.Drawing.Size(53, 30)
        Me.numAssembly3.TabIndex = 8
        Me.numAssembly3.Text = "PvNumericUD4"
        Me.numAssembly3.Value = 0
        '
        'numAssembly2
        '
        Me.numAssembly2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.numAssembly2.ButtonChange = 1
        Me.numAssembly2.Enabled = False
        Me.numAssembly2.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.numAssembly2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.numAssembly2.Location = New System.Drawing.Point(108, 384)
        Me.numAssembly2.Maximum = 100
        Me.numAssembly2.Minimum = 1
        Me.numAssembly2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.numAssembly2.Name = "numAssembly2"
        Me.numAssembly2.Size = New System.Drawing.Size(53, 30)
        Me.numAssembly2.TabIndex = 7
        Me.numAssembly2.Text = "PvNumericUD3"
        Me.numAssembly2.Value = 0
        '
        'numAssembly1
        '
        Me.numAssembly1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.numAssembly1.ButtonChange = 1
        Me.numAssembly1.Enabled = False
        Me.numAssembly1.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.numAssembly1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.numAssembly1.Location = New System.Drawing.Point(17, 384)
        Me.numAssembly1.Maximum = 100
        Me.numAssembly1.Minimum = 1
        Me.numAssembly1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.numAssembly1.Name = "numAssembly1"
        Me.numAssembly1.Size = New System.Drawing.Size(53, 30)
        Me.numAssembly1.TabIndex = 6
        Me.numAssembly1.Text = "PvNumericUD2"
        Me.numAssembly1.Value = 0
        '
        'txtAssemblyTrademark
        '
        Me.txtAssemblyTrademark.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.txtAssemblyTrademark.BorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtAssemblyTrademark.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAssemblyTrademark.Enabled = False
        Me.txtAssemblyTrademark.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.txtAssemblyTrademark.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtAssemblyTrademark.InteriorColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtAssemblyTrademark.Location = New System.Drawing.Point(17, 326)
        Me.txtAssemblyTrademark.MinimumSize = New System.Drawing.Size(20, 20)
        Me.txtAssemblyTrademark.Multiline = True
        Me.txtAssemblyTrademark.Name = "txtAssemblyTrademark"
        Me.txtAssemblyTrademark.Size = New System.Drawing.Size(335, 26)
        Me.txtAssemblyTrademark.TabIndex = 5
        Me.txtAssemblyTrademark.Text = "Trademark"
        '
        'txtAssemblyCopyright
        '
        Me.txtAssemblyCopyright.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.txtAssemblyCopyright.BorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtAssemblyCopyright.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAssemblyCopyright.Enabled = False
        Me.txtAssemblyCopyright.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.txtAssemblyCopyright.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtAssemblyCopyright.InteriorColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtAssemblyCopyright.Location = New System.Drawing.Point(17, 275)
        Me.txtAssemblyCopyright.MinimumSize = New System.Drawing.Size(20, 20)
        Me.txtAssemblyCopyright.Multiline = True
        Me.txtAssemblyCopyright.Name = "txtAssemblyCopyright"
        Me.txtAssemblyCopyright.Size = New System.Drawing.Size(335, 26)
        Me.txtAssemblyCopyright.TabIndex = 4
        Me.txtAssemblyCopyright.Text = "Copyright"
        '
        'txtAssemblyProduct
        '
        Me.txtAssemblyProduct.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.txtAssemblyProduct.BorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtAssemblyProduct.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAssemblyProduct.Enabled = False
        Me.txtAssemblyProduct.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.txtAssemblyProduct.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtAssemblyProduct.InteriorColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtAssemblyProduct.Location = New System.Drawing.Point(17, 225)
        Me.txtAssemblyProduct.MinimumSize = New System.Drawing.Size(20, 20)
        Me.txtAssemblyProduct.Multiline = True
        Me.txtAssemblyProduct.Name = "txtAssemblyProduct"
        Me.txtAssemblyProduct.Size = New System.Drawing.Size(335, 26)
        Me.txtAssemblyProduct.TabIndex = 3
        Me.txtAssemblyProduct.Text = "Product"
        '
        'txtAssemblyCompany
        '
        Me.txtAssemblyCompany.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.txtAssemblyCompany.BorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtAssemblyCompany.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAssemblyCompany.Enabled = False
        Me.txtAssemblyCompany.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.txtAssemblyCompany.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtAssemblyCompany.InteriorColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtAssemblyCompany.Location = New System.Drawing.Point(17, 175)
        Me.txtAssemblyCompany.MinimumSize = New System.Drawing.Size(20, 20)
        Me.txtAssemblyCompany.Multiline = True
        Me.txtAssemblyCompany.Name = "txtAssemblyCompany"
        Me.txtAssemblyCompany.Size = New System.Drawing.Size(335, 26)
        Me.txtAssemblyCompany.TabIndex = 2
        Me.txtAssemblyCompany.Text = "Company"
        '
        'txtAssemblyDescription
        '
        Me.txtAssemblyDescription.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.txtAssemblyDescription.BorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtAssemblyDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAssemblyDescription.Enabled = False
        Me.txtAssemblyDescription.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.txtAssemblyDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtAssemblyDescription.InteriorColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtAssemblyDescription.Location = New System.Drawing.Point(17, 121)
        Me.txtAssemblyDescription.MinimumSize = New System.Drawing.Size(20, 20)
        Me.txtAssemblyDescription.Multiline = True
        Me.txtAssemblyDescription.Name = "txtAssemblyDescription"
        Me.txtAssemblyDescription.Size = New System.Drawing.Size(335, 26)
        Me.txtAssemblyDescription.TabIndex = 1
        Me.txtAssemblyDescription.Text = "Description"
        '
        'txtAssemblyTitle
        '
        Me.txtAssemblyTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.txtAssemblyTitle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(110, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.txtAssemblyTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAssemblyTitle.Enabled = False
        Me.txtAssemblyTitle.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.txtAssemblyTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.txtAssemblyTitle.InteriorColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtAssemblyTitle.Location = New System.Drawing.Point(17, 69)
        Me.txtAssemblyTitle.MinimumSize = New System.Drawing.Size(20, 20)
        Me.txtAssemblyTitle.Multiline = True
        Me.txtAssemblyTitle.Name = "txtAssemblyTitle"
        Me.txtAssemblyTitle.Size = New System.Drawing.Size(335, 26)
        Me.txtAssemblyTitle.TabIndex = 0
        Me.txtAssemblyTitle.Text = "Title"
        '
        'TabPage7
        '
        Me.TabPage7.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.TabPage7.Controls.Add(Me.btnBuild)
        Me.TabPage7.Controls.Add(Me.txtLog)
        Me.TabPage7.Location = New System.Drawing.Point(104, 4)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(779, 454)
        Me.TabPage7.TabIndex = 4
        Me.TabPage7.Text = "Build"
        '
        'btnBuild
        '
        Me.btnBuild.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.btnBuild.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.btnBuild.ForeColor = System.Drawing.Color.FromArgb(CType(CType(146, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnBuild.Location = New System.Drawing.Point(13, 301)
        Me.btnBuild.MinimumSize = New System.Drawing.Size(20, 20)
        Me.btnBuild.Name = "btnBuild"
        Me.btnBuild.Size = New System.Drawing.Size(97, 36)
        Me.btnBuild.TabIndex = 1
        Me.btnBuild.Text = "Build"
        '
        'txtLog
        '
        Me.txtLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.txtLog.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtLog.Location = New System.Drawing.Point(13, 16)
        Me.txtLog.Name = "txtLog"
        Me.txtLog.Size = New System.Drawing.Size(571, 254)
        Me.txtLog.TabIndex = 0
        Me.txtLog.Text = ""
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.picNyanCat)
        Me.TabPage1.Location = New System.Drawing.Point(104, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(779, 454)
        Me.TabPage1.TabIndex = 5
        Me.TabPage1.Text = "About"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 329)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(306, 26)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "https://github.com/NYAN-x-CAT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 303)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Coded By :NYAN CAT"
        '
        'picNyanCat
        '
        Me.picNyanCat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picNyanCat.ErrorImage = Nothing
        Me.picNyanCat.Image = Global.Lime_Crypter.My.Resources.Resources.nyancat
        Me.picNyanCat.InitialImage = Nothing
        Me.picNyanCat.Location = New System.Drawing.Point(0, 0)
        Me.picNyanCat.Name = "picNyanCat"
        Me.picNyanCat.Size = New System.Drawing.Size(779, 454)
        Me.picNyanCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picNyanCat.TabIndex = 1
        Me.picNyanCat.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 517)
        Me.Controls.Add(Me.PvForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(305, 150)
        Me.Name = "Main"
        Me.Text = "Main"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.PvForm1.ResumeLayout(False)
        Me.PvTabControl_Side1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.PvGroupbox4.ResumeLayout(False)
        Me.PvGroupbox4.PerformLayout()
        Me.PvGroupbox3.ResumeLayout(False)
        Me.PvGroupbox3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.PvGroupbox2.ResumeLayout(False)
        Me.PvGroupbox2.PerformLayout()
        Me.PvGroupbox1.ResumeLayout(False)
        Me.PvGroupbox1.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.TabPage6.PerformLayout()
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.picNyanCat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PvForm1 As PVForm
    Friend WithEvents PvTabControl_Side1 As PVTabControl_Side
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents TabPage7 As TabPage
    Friend WithEvents txtPayload As PVTextbox
    Friend WithEvents btnPayload As PVButton
    Friend WithEvents PvGroupbox1 As PVGroupbox
    Friend WithEvents txtDropName As PVTextbox
    Friend WithEvents PvGroupbox2 As PVGroupbox
    Friend WithEvents chkAntiVM As PVCheckbox
    Friend WithEvents chkAntiTask As PVCheckbox
    Friend WithEvents chkAntiWireshark As PVCheckbox
    Friend WithEvents numDelay As PVNumericUD
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents picIcon As PictureBox
    Friend WithEvents chkIcon As PVCheckbox
    Friend WithEvents btnAssemblyRandom As PVButton
    Friend WithEvents btnAssemblyClone As PVButton
    Friend WithEvents numAssembly4 As PVNumericUD
    Friend WithEvents numAssembly3 As PVNumericUD
    Friend WithEvents numAssembly2 As PVNumericUD
    Friend WithEvents numAssembly1 As PVNumericUD
    Friend WithEvents txtAssemblyTrademark As PVTextbox
    Friend WithEvents txtAssemblyCopyright As PVTextbox
    Friend WithEvents txtAssemblyProduct As PVTextbox
    Friend WithEvents txtAssemblyCompany As PVTextbox
    Friend WithEvents txtAssemblyDescription As PVTextbox
    Friend WithEvents txtAssemblyTitle As PVTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents numPump As PVNumericUD
    Friend WithEvents chkZoneIden As PVCheckbox
    Friend WithEvents chkDelay As PVCheckbox
    Friend WithEvents chkPump As PVCheckbox
    Friend WithEvents PvGroupbox4 As PVGroupbox
    Friend WithEvents txtBind As PVTextbox
    Friend WithEvents btnBind As PVButton
    Friend WithEvents PvGroupbox3 As PVGroupbox
    Friend WithEvents txtLog As RichTextBox
    Friend WithEvents btnBuild As PVButton
    Friend WithEvents PvButton1 As PVButton
    Friend WithEvents chkAssembly As PVCheckbox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PvEmbeddedButton1 As PVEmbeddedButton
    Friend WithEvents txtDropPath As ComboBox
    Friend WithEvents picNyanCat As PictureBox
    Friend WithEvents chkRegasm As PVRadiobutton
    Friend WithEvents chkItself As PVRadiobutton
    Friend WithEvents chkDrop As PVCheckbox
    Friend WithEvents chkBind As PVCheckbox
    Friend WithEvents chkBindOnce As PVCheckbox
End Class
