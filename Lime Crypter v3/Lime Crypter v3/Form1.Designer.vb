<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.HuraForm1 = New Lime_Crypter_v3.HuraForm()
        Me.txtPayloadType = New Lime_Crypter_v3.HuraAlertBox()
        Me.btnStartBuild = New Lime_Crypter_v3.HuraButton()
        Me.btnExit = New Lime_Crypter_v3.HuraButton()
        Me.txtPayload = New Lime_Crypter_v3.HuraTextBox()
        Me.btnSelectPayload = New Lime_Crypter_v3.HuraButton()
        Me.HuraForm1.SuspendLayout()
        Me.SuspendLayout()
        '
        'HuraForm1
        '
        Me.HuraForm1.AccentColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HuraForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HuraForm1.ColorScheme = Lime_Crypter_v3.HuraForm.ColorSchemes.Dark
        Me.HuraForm1.Controls.Add(Me.txtPayloadType)
        Me.HuraForm1.Controls.Add(Me.btnStartBuild)
        Me.HuraForm1.Controls.Add(Me.btnExit)
        Me.HuraForm1.Controls.Add(Me.txtPayload)
        Me.HuraForm1.Controls.Add(Me.btnSelectPayload)
        Me.HuraForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HuraForm1.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.HuraForm1.ForeColor = System.Drawing.Color.Gray
        Me.HuraForm1.Location = New System.Drawing.Point(0, 0)
        Me.HuraForm1.Name = "HuraForm1"
        Me.HuraForm1.Size = New System.Drawing.Size(769, 227)
        Me.HuraForm1.TabIndex = 0
        Me.HuraForm1.Text = "Lime Crypter | Main"
        '
        'txtPayloadType
        '
        Me.txtPayloadType.AlertStyle = Lime_Crypter_v3.HuraAlertBox.Style.Simple
        Me.txtPayloadType.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.txtPayloadType.Location = New System.Drawing.Point(206, 132)
        Me.txtPayloadType.Name = "txtPayloadType"
        Me.txtPayloadType.Size = New System.Drawing.Size(200, 40)
        Me.txtPayloadType.TabIndex = 4
        Me.txtPayloadType.Text = "Payload Type:"
        Me.txtPayloadType.Visible = False
        '
        'btnStartBuild
        '
        Me.btnStartBuild.BackColor = System.Drawing.Color.Transparent
        Me.btnStartBuild.BaseColour = System.Drawing.Color.Black
        Me.btnStartBuild.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnStartBuild.Enabled = False
        Me.btnStartBuild.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btnStartBuild.HoverColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnStartBuild.Location = New System.Drawing.Point(12, 177)
        Me.btnStartBuild.Name = "btnStartBuild"
        Me.btnStartBuild.PressedColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnStartBuild.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStartBuild.Size = New System.Drawing.Size(172, 38)
        Me.btnStartBuild.TabIndex = 3
        Me.btnStartBuild.Text = ":: BUILDER ::"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.BaseColour = System.Drawing.Color.Black
        Me.btnExit.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnExit.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btnExit.HoverColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExit.Location = New System.Drawing.Point(585, 177)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.PressedColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnExit.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnExit.Size = New System.Drawing.Size(172, 38)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = ":: EXIT ::"
        '
        'txtPayload
        '
        Me.txtPayload.BackColor = System.Drawing.Color.Transparent
        Me.txtPayload.BackgroundColour = System.Drawing.Color.Black
        Me.txtPayload.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.txtPayload.Location = New System.Drawing.Point(206, 87)
        Me.txtPayload.MaxLength = 32767
        Me.txtPayload.Multiline = False
        Me.txtPayload.Name = "txtPayload"
        Me.txtPayload.ReadOnly = False
        Me.txtPayload.Size = New System.Drawing.Size(551, 38)
        Me.txtPayload.Style = Lime_Crypter_v3.HuraTextBox.Styles.Normal
        Me.txtPayload.TabIndex = 1
        Me.txtPayload.Text = "..."
        Me.txtPayload.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtPayload.TextColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.txtPayload.UseSystemPasswordChar = False
        '
        'btnSelectPayload
        '
        Me.btnSelectPayload.BackColor = System.Drawing.Color.Transparent
        Me.btnSelectPayload.BaseColour = System.Drawing.Color.Black
        Me.btnSelectPayload.BorderColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnSelectPayload.FontColour = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.btnSelectPayload.HoverColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSelectPayload.Location = New System.Drawing.Point(12, 87)
        Me.btnSelectPayload.Name = "btnSelectPayload"
        Me.btnSelectPayload.PressedColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnSelectPayload.ProgressColour = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSelectPayload.Size = New System.Drawing.Size(172, 38)
        Me.btnSelectPayload.TabIndex = 0
        Me.btnSelectPayload.Text = ":: Select Payload ::"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 227)
        Me.Controls.Add(Me.HuraForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.HuraForm1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HuraForm1 As HuraForm
    Friend WithEvents btnSelectPayload As HuraButton
    Friend WithEvents txtPayload As HuraTextBox
    Friend WithEvents btnStartBuild As HuraButton
    Friend WithEvents btnExit As HuraButton
    Friend WithEvents txtPayloadType As HuraAlertBox
End Class
