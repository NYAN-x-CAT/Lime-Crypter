Imports System.Drawing.Drawing2D
'|===========================================================|
'|===|  PixelVision
'| Creator: LordPankake
'| HF Account: http://www.hackforums.net/member.php?action=profile&uid=1828119
'| Created: 8/23/2014, Last edited: 9/6/2014
'|===========================================================|
#Region "Base Classes"
Public Class ThemedControl : Inherits Control
    Public D As New DrawUtils
    Public State As MouseState = MouseState.None
    Public Pal As Palette
    Protected Overrides Sub OnPaintBackground(ByVal e As System.Windows.Forms.PaintEventArgs)
    End Sub
    Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
        MyBase.OnMouseEnter(e)
        State = MouseState.Over
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseDown(e)
        State = MouseState.Down
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
        MyBase.OnMouseLeave(e)
        State = MouseState.None
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseUp(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseUp(e)
        State = MouseState.Over
        Invalidate()
    End Sub
    Protected Overrides Sub OnTextChanged(ByVal e As System.EventArgs)
        MyBase.OnTextChanged(e)
        Invalidate()
    End Sub
    Sub New()
        MyBase.New()
        MinimumSize = New Size(20, 20)
        ForeColor = Color.FromArgb(146, 149, 152)
        Font = New Font("Segoe UI", 10.0F)
        DoubleBuffered = True
        Pal = New Palette
        Pal.ColHighest = Color.FromArgb(100, 110, 120)
        Pal.ColHigh = Color.FromArgb(65, 70, 75)
        Pal.ColMed = Color.FromArgb(40, 42, 45)
        Pal.ColDim = Color.FromArgb(30, 32, 35)
        Pal.ColDark = Color.FromArgb(15, 17, 19)
        BackColor = Pal.ColDim
    End Sub
End Class
Public Class ThemedTrackbar : Inherits TrackBar
    Public D As New DrawUtils
    Public State As MouseState = MouseState.None
    Public Pal As Palette
    Protected Overrides Sub OnPaintBackground(ByVal e As System.Windows.Forms.PaintEventArgs)
    End Sub
    Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
        MyBase.OnMouseEnter(e)
        State = MouseState.Over
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseDown(e)
        State = MouseState.Down
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
        MyBase.OnMouseLeave(e)
        State = MouseState.None
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseUp(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseUp(e)
        State = MouseState.Over
        Invalidate()
    End Sub
    Protected Overrides Sub OnTextChanged(ByVal e As System.EventArgs)
        MyBase.OnTextChanged(e)
        Invalidate()
    End Sub
    Sub New()
        MyBase.New()
        MinimumSize = New Size(20, 20)
        ForeColor = Color.FromArgb(146, 149, 152)
        Font = New Font("Segoe UI", 10.0F)
        DoubleBuffered = True
        Pal = New Palette
        Pal.ColHighest = Color.FromArgb(100, 110, 120)
        Pal.ColHigh = Color.FromArgb(65, 70, 75)
        Pal.ColMed = Color.FromArgb(40, 42, 45)
        Pal.ColDim = Color.FromArgb(30, 32, 35)
        Pal.ColDark = Color.FromArgb(15, 17, 19)
        BackColor = Pal.ColDim
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint Or ControlStyles.DoubleBuffer, True)
    End Sub
End Class
Public Class ThemedTextbox : Inherits TextBox
    Public D As New DrawUtils
    Public State As MouseState = MouseState.None
    Public Pal As Palette
    Protected Overrides Sub OnPaintBackground(ByVal e As System.Windows.Forms.PaintEventArgs)
    End Sub
    Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
        MyBase.OnMouseEnter(e)
        State = MouseState.Over
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseDown(e)
        State = MouseState.Down
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
        MyBase.OnMouseLeave(e)
        State = MouseState.None
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseUp(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseUp(e)
        State = MouseState.Over
        Invalidate()
    End Sub
    Protected Overrides Sub OnTextChanged(ByVal e As System.EventArgs)
        MyBase.OnTextChanged(e)
        Invalidate()
    End Sub
    Sub New()
        MyBase.New()
        MinimumSize = New Size(20, 20)
        ForeColor = Color.FromArgb(146, 149, 152)
        Font = New Font("Segoe UI", 10.0F)
        DoubleBuffered = True
        Pal = New Palette
        Pal.ColHighest = Color.FromArgb(100, 110, 120)
        Pal.ColHigh = Color.FromArgb(65, 70, 75)
        Pal.ColMed = Color.FromArgb(40, 42, 45)
        Pal.ColDim = Color.FromArgb(30, 32, 35)
        Pal.ColDark = Color.FromArgb(15, 17, 19)
        BackColor = Pal.ColDim
    End Sub
End Class
Public Class ThemedContainer : Inherits ContainerControl
    Public D As New DrawUtils
    Protected Drag As Boolean = True
    Public State As MouseState = MouseState.None
    Protected TopCap As Boolean = False
    Protected SizeCap As Boolean = False
    Public Pal As Palette
    Protected MouseP As Point = New Point(0, 0)
    Protected TopGrip As Integer
    Protected Overrides Sub OnPaintBackground(ByVal e As System.Windows.Forms.PaintEventArgs)
    End Sub
    Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
        MyBase.OnMouseEnter(e)
        State = MouseState.Over
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseDown(e)
        State = MouseState.Down
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If New Rectangle(0, 0, Width, TopGrip).Contains(e.Location) Then
                TopCap = True : MouseP = e.Location
            ElseIf Drag And New Rectangle(Width - 15, Height - 15, 15, 15).Contains(e.Location) Then
                SizeCap = True : MouseP = e.Location
            End If
        End If
    End Sub
    Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
        MyBase.OnMouseLeave(e)
        State = MouseState.None
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseUp(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseUp(e)
        State = MouseState.Over
        TopCap = False
        If Drag Then
            SizeCap = False
        End If

    End Sub
    Protected Overrides Sub OnMouseMove(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseMove(e)

        If TopCap Then
            Parent.Location = MousePosition - MouseP
        End If
        If Drag And SizeCap Then
            MouseP = e.Location
            Parent.Size = New Size(MouseP)
            Invalidate()
        End If

    End Sub
    Protected Overrides Sub OnTextChanged(ByVal e As System.EventArgs)
        MyBase.OnTextChanged(e)
        Invalidate()
    End Sub
    Sub New()
        MyBase.New()
        MinimumSize = New Size(20, 20)
        ForeColor = Color.FromArgb(146, 149, 152)
        Font = New Font("Trebuchet MS", 10.0F)
        DoubleBuffered = True
        Pal = New Palette
        Pal.ColHighest = Color.FromArgb(100, 110, 120)
        Pal.ColHigh = Color.FromArgb(65, 70, 75)
        Pal.ColMed = Color.FromArgb(40, 42, 45)
        Pal.ColDim = Color.FromArgb(30, 32, 35)
        Pal.ColDark = Color.FromArgb(15, 17, 19)
        BackColor = Pal.ColDim
    End Sub
End Class
Public Class ThemedTabControl : Inherits TabControl
    Public D As New DrawUtils
    Public State As MouseState = MouseState.None
    Public Pal As Palette
    Protected Overrides Sub OnPaintBackground(ByVal e As System.Windows.Forms.PaintEventArgs)
    End Sub
    Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
        MyBase.OnMouseEnter(e)
        State = MouseState.Over
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseDown(e)
        State = MouseState.Down
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
        MyBase.OnMouseLeave(e)
        State = MouseState.None
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseUp(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseUp(e)
        State = MouseState.Over
        Invalidate()
    End Sub
    Protected Overrides Sub OnTextChanged(ByVal e As System.EventArgs)
        MyBase.OnTextChanged(e)
        Invalidate()
    End Sub
    Sub New()
        MyBase.New()
        MinimumSize = New Size(20, 20)
        ForeColor = Color.FromArgb(146, 149, 152)
        Font = New Font("Segoe UI", 10.0F)
        DoubleBuffered = True
        Pal = New Palette
        Pal.ColHighest = Color.FromArgb(100, 110, 120)
        Pal.ColHigh = Color.FromArgb(65, 70, 75)
        Pal.ColMed = Color.FromArgb(40, 42, 45)
        Pal.ColDim = Color.FromArgb(30, 32, 35)
        Pal.ColDark = Color.FromArgb(15, 17, 19)
        BackColor = Pal.ColDim
        Alignment = TabAlignment.Top
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint Or ControlStyles.DoubleBuffer, True)
    End Sub
End Class
Public Class ThemedListControl : Inherits ListBox
    Public D As New DrawUtils
    Public State As MouseState = MouseState.None
    Public Pal As Palette
    Protected Overrides Sub OnPaintBackground(ByVal e As System.Windows.Forms.PaintEventArgs)
    End Sub
    Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
        MyBase.OnMouseEnter(e)
        State = MouseState.Over
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseDown(e)
        State = MouseState.Down
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
        MyBase.OnMouseLeave(e)
        State = MouseState.None
        Invalidate()
    End Sub
    Protected Overrides Sub OnMouseUp(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseUp(e)
        State = MouseState.Over
        Invalidate()
    End Sub
    Protected Overrides Sub OnTextChanged(ByVal e As System.EventArgs)
        MyBase.OnTextChanged(e)
        Invalidate()
    End Sub
    Sub New()
        MyBase.New()
        MinimumSize = New Size(20, 20)
        ForeColor = Color.FromArgb(146, 149, 152)
        Font = New Font("Segoe UI", 10.0F)
        DoubleBuffered = True
        Pal = New Palette
        Pal.ColHighest = Color.FromArgb(100, 110, 120)
        Pal.ColHigh = Color.FromArgb(65, 70, 75)
        Pal.ColMed = Color.FromArgb(40, 42, 45)
        Pal.ColDim = Color.FromArgb(30, 32, 35)
        Pal.ColDark = Color.FromArgb(15, 17, 19)
        BackColor = Pal.ColDim
    End Sub
End Class
#End Region
#Region "Theme"
Public Class PVForm : Inherits ThemedContainer
    Sub New()
        MyBase.New()
        MinimumSize = New Size(305, 150)
        Dock = DockStyle.Fill
        TopGrip = 30
        Font = New Font("Segoe UI", 10.0F)
        BackColor = Color.FromArgb(21, 23, 25)
    End Sub
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim G As Graphics = e.Graphics
        MyBase.OnPaint(e)
        Try
            Me.ParentForm.TransparencyKey = Color.Fuchsia
            Me.ParentForm.MinimumSize = MinimumSize
            If Not Me.ParentForm.FormBorderStyle = FormBorderStyle.None Then
                Me.ParentForm.FormBorderStyle = FormBorderStyle.None
            End If
        Catch ex As Exception : End Try
        G.Clear(Me.ParentForm.TransparencyKey)

        '| Main drawing
        Dim BorderRect As New Rectangle(0, 0, Width - 1, Height - 1)
        Dim BorderInnerRect As New Rectangle(1, 1, Width - 3, Height - 3)
        G.FillRectangle(New SolidBrush(Pal.ColDim), BorderRect)

        '|=========================|
        '| The top textured bit of the theme is 'first'
        '| The second area for menu objects is 'second'
        '|=========================|
        '| Top Rect
        Dim FirstTexturedRect As New Rectangle(0, 0, Width - 1, TopGrip)
        Dim FirstDiagonalHatch As New HatchBrush(HatchStyle.DarkUpwardDiagonal, Pal.ColDim, Color.Transparent)
        Dim FirstLGB As New LinearGradientBrush(New Point(0, 0), New Point(0, TopGrip), Pal.ColHigh, Pal.ColDim)
        Dim FirstShineRect As New Rectangle(0, 0, Width - 1, TopGrip / 2)
        Dim FirstShineLGB As New LinearGradientBrush(New Point(0, 0), New Point(0, TopGrip * (3 / 5)), Color.FromArgb(120, Pal.ColHighest), Color.FromArgb(10, Pal.ColHighest))
        Dim test As New LinearGradientBrush(New Point(0, 0), New Point(0, TopGrip * (3 / 5)), Color.FromArgb(60, Pal.ColDim), Color.FromArgb(10, Pal.ColDim))
        G.FillRectangle(FirstLGB, FirstTexturedRect)
        G.FillRectangle(FirstDiagonalHatch, FirstTexturedRect)
        G.FillRectangle(test, FirstShineRect)
        G.FillRectangle(FirstShineLGB, FirstShineRect)
        G.DrawLine(New Pen(Color.FromArgb(150, Color.Black)), New Point(0, TopGrip), New Point(Width - 1, TopGrip))
        G.DrawLine(New Pen(Color.FromArgb(60, Pal.ColHighest)), New Point(0, TopGrip + 1), New Point(Width - 1, TopGrip + 1))


        '| Second Top Rect
        Dim SecondMenuHeight As Integer = TopGrip * 2.4
        Dim SecondMenuRect As New Rectangle(0, TopGrip, Width - 1, SecondMenuHeight)
        Dim BlahRect As New Rectangle(0, SecondMenuHeight - 20, Width - 1, 22)
        Dim SecondLGB As New LinearGradientBrush(New Point(0, SecondMenuHeight - 20), New Point(0, SecondMenuHeight - 10 + 22), Pal.ColDim, Pal.ColDark)
        G.FillRectangle(SecondLGB, BlahRect)
        G.DrawLine(New Pen(Color.FromArgb(150, Color.Black)), New Point(0, SecondMenuHeight), New Point(Width - 1, SecondMenuHeight))
        G.DrawLine(New Pen(Color.FromArgb(60, Pal.ColHighest)), New Point(0, SecondMenuHeight + 1), New Point(Width - 1, SecondMenuHeight + 1))

        '| Below Second Top Rect
        G.FillRectangle(New SolidBrush(Color.FromArgb(150, Pal.ColDark)), New Rectangle(0, SecondMenuHeight, Width - 1, Height - SecondMenuHeight))

        '| Borders and finalizations
        G.DrawRectangle(Pens.Black, BorderRect)
        G.DrawRectangle(New Pen(Color.FromArgb(60, Pal.ColHighest)), BorderInnerRect)
        D.DrawTextWithShadow(G, New Rectangle(5, 0, Width - 31, TopGrip), Text, Font, HorizontalAlignment.Left, Color.FromArgb(120, Color.WhiteSmoke), Color.Black)
    End Sub
End Class
Public Class PVEmbeddedButton : Inherits ThemedControl
    Sub New()
        MyBase.New()
        Font = New Font("Trebuchet MS", 10.0F)
    End Sub
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim G As Graphics = e.Graphics
        MyBase.OnPaint(e)
        Try
            BackColor = Me.Parent.BackColor
        Catch ex As Exception : End Try
        G.Clear(BackColor)
        G.SmoothingMode = SmoothingMode.HighQuality


        Dim BorderRect As New Rectangle(0, 0, Width - 1, Height - 1)
        Dim BorderInnerRect As New Rectangle(1, 1, Width - 3, Height - 3)
        Dim ButtonRect As New Rectangle(5, 5, Width - 11, Height - 11)


        '| Drawing the button's hole into the form (Whats the whole that a button goes into? There even a name for that???)
        Dim Out1Path As GraphicsPath = D.RoundRect(BorderRect, 3)
        Dim Out2Path As GraphicsPath = D.RoundRect(BorderInnerRect, 5)
        Dim Out2LGB As New LinearGradientBrush(New Point(0, 0), New Point(0, Height), Color.FromArgb(150, Color.Black), Color.FromArgb(60, Pal.ColDim))
        G.FillRectangle(New SolidBrush(Color.FromArgb(35, Color.Black)), BorderInnerRect)
        G.DrawPath(New Pen(Out2LGB, 3), Out2Path)
        G.DrawPath(New Pen(Color.FromArgb(100, Pal.ColHighest)), Out1Path)

        '| Drawing the button
        Dim InnerButtonWidth As Integer = 10
        Dim ButtonPath As GraphicsPath = D.RoundRect(ButtonRect, 4)
        Dim ButtonInnerPath As GraphicsPath = D.RoundRect(New Rectangle(ButtonRect.X + InnerButtonWidth, ButtonRect.Y, ButtonRect.Width - (InnerButtonWidth * 2), ButtonRect.Height), 4)
        Dim ButtonHighlightPath As GraphicsPath = D.RoundRect(New Rectangle(ButtonRect.X, ButtonRect.Y + 1, ButtonRect.Width, ButtonRect.Height - 2), 4)
        Select Case State
            Case MouseState.None
                G.FillPath(New SolidBrush(Color.FromArgb(100, Pal.ColDim)), ButtonPath)
                G.FillPath(New SolidBrush(Pal.ColDim), ButtonInnerPath)
                D.FillGradientBeam(G, Color.FromArgb(20, Color.Black), Color.FromArgb(20, Pal.ColHighest), ButtonRect, GradientAlignment.Vertical)
            Case MouseState.Over
                G.FillPath(New SolidBrush(Color.FromArgb(255, Pal.ColDim)), ButtonPath)
                G.FillPath(New SolidBrush(Color.FromArgb(Pal.ColDim.R + 10, Pal.ColDim.G + 10, Pal.ColDim.B + 10)), ButtonInnerPath)
                D.FillGradientBeam(G, Color.FromArgb(20, Color.Black), Color.FromArgb(20, Pal.ColHighest), ButtonRect, GradientAlignment.Vertical)
            Case MouseState.Down
                G.FillPath(New SolidBrush(Color.FromArgb(70, Pal.ColDim)), ButtonPath)
                G.FillPath(New SolidBrush(Pal.ColDim), ButtonInnerPath)
                G.FillPath(New SolidBrush(Color.FromArgb(50, Pal.ColDark)), ButtonInnerPath)
                D.FillGradientBeam(G, Color.FromArgb(35, Color.Black), Color.FromArgb(14, Pal.ColHighest), ButtonRect, GradientAlignment.Vertical)
        End Select
        If State = MouseState.Down Then
            ButtonHighlightPath = D.RoundRect(New Rectangle(ButtonRect.X, ButtonRect.Y + 1, ButtonRect.Width, ButtonRect.Height - 1), 4)
            G.DrawPath(New Pen(Color.FromArgb(100, Color.Black), 3), ButtonHighlightPath)
            D.DrawTextWithShadow(G, BorderInnerRect, Text, Font, HorizontalAlignment.Center, Color.FromArgb(200, Pal.ColHighest), Color.Black)

        Else
            G.DrawPath(New Pen(Color.FromArgb(60, Pal.ColHighest)), ButtonHighlightPath)
            D.DrawTextWithShadow(G, BorderInnerRect, Text, Font, HorizontalAlignment.Center, Color.FromArgb(120, Color.WhiteSmoke), Color.Black)

        End If
        G.DrawPath(Pens.Black, ButtonPath)

    End Sub
End Class
Public Class PVButton : Inherits ThemedControl
    Sub New()
        MyBase.New()
        Font = New Font("Trebuchet MS", 10.0F)
    End Sub
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim G As Graphics = e.Graphics
        MyBase.OnPaint(e)
        Try
            BackColor = Me.Parent.BackColor
        Catch ex As Exception : End Try
        G.Clear(BackColor)
        G.SmoothingMode = SmoothingMode.HighQuality

        '| Drawing the button
        Dim ButtonRect As New Rectangle(0, 0, Width - 1, Height - 1)
        Dim Roundness As Integer = 4
        If Size.Width <= 30 And Size.Height <= 30 Then
            Roundness = 2
        End If
        Dim ButtonPath As GraphicsPath = D.RoundRect(ButtonRect, Roundness)
        Dim ButtonHighlightPath As GraphicsPath = D.RoundRect(New Rectangle(ButtonRect.X, ButtonRect.Y + 1, ButtonRect.Width, ButtonRect.Height - 2), 4)
        Select Case State
            Case MouseState.None
                G.FillPath(New SolidBrush(Color.FromArgb(100, Pal.ColDim)), ButtonPath)
                G.FillPath(New SolidBrush(Pal.ColDim), ButtonPath)
                D.FillGradientBeam(G, Color.FromArgb(20, Color.Black), Color.FromArgb(20, Pal.ColHighest), ButtonRect, GradientAlignment.Vertical)
            Case MouseState.Over
                G.FillPath(New SolidBrush(Color.FromArgb(255, Pal.ColDim)), ButtonPath)
                G.FillPath(New SolidBrush(Color.FromArgb(Pal.ColDim.R + 10, Pal.ColDim.G + 10, Pal.ColDim.B + 10)), ButtonPath)
                D.FillGradientBeam(G, Color.FromArgb(20, Color.Black), Color.FromArgb(20, Pal.ColHighest), ButtonRect, GradientAlignment.Vertical)
            Case MouseState.Down
                G.FillPath(New SolidBrush(Color.FromArgb(70, Pal.ColDim)), ButtonPath)
                G.FillPath(New SolidBrush(Pal.ColDim), ButtonPath)
                G.FillPath(New SolidBrush(Color.FromArgb(50, Pal.ColDark)), ButtonPath)
                D.FillGradientBeam(G, Color.FromArgb(35, Color.Black), Color.FromArgb(14, Pal.ColHighest), ButtonRect, GradientAlignment.Vertical)
        End Select
        If State = MouseState.Down Then
            ButtonHighlightPath = D.RoundRect(New Rectangle(ButtonRect.X, ButtonRect.Y + 1, ButtonRect.Width, ButtonRect.Height - 1), 4)
            G.DrawPath(New Pen(Color.FromArgb(100, Color.Black), 3), ButtonHighlightPath)
            D.DrawTextWithShadow(G, ButtonRect, Text, Font, HorizontalAlignment.Center, Color.FromArgb(200, Pal.ColHighest), Color.Black)

        Else
            G.DrawPath(New Pen(Color.FromArgb(60, Pal.ColHighest)), ButtonHighlightPath)
            D.DrawTextWithShadow(G, ButtonRect, Text, Font, HorizontalAlignment.Center, Color.FromArgb(120, Color.WhiteSmoke), Color.Black)

        End If
        G.DrawPath(Pens.Black, ButtonPath)

    End Sub
End Class
Public Class PVGroupbox : Inherits ThemedContainer
    Sub New()
        MyBase.New()
        Font = New Font("Trebuchet MS", 10.0F)
    End Sub
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim G As Graphics = e.Graphics
        MyBase.OnPaint(e)
        Try
            BackColor = Me.Parent.BackColor
        Catch ex As Exception

        End Try
        G.Clear(BackColor)
        G.SmoothingMode = SmoothingMode.HighQuality


        Dim BorderRect As New Rectangle(0, 0, Width - 1, Height - 1)
        Dim BorderInnerRect As New Rectangle(1, 1, Width - 3, Height - 3)

        '| Pretty much the same as the button, minus the button itself. Looked good as a container.
        Dim Out1Path As GraphicsPath = D.RoundRect(BorderRect, 3)
        Dim Out2Path As GraphicsPath = D.RoundRect(BorderInnerRect, 5)
        Dim Out2LGB As New LinearGradientBrush(New Point(0, 0), New Point(0, Height), Color.FromArgb(150, Color.Black), Color.FromArgb(60, Pal.ColDim))
        G.FillRectangle(New SolidBrush(Color.FromArgb(35, Color.FromArgb(0, 0, 10))), BorderInnerRect)
        G.DrawPath(New Pen(Out2LGB, 3), Out2Path)
        G.DrawPath(New Pen(Color.FromArgb(100, Pal.ColHighest)), Out1Path)

        '| Drawing the text area
        If Text.Length > 0 Then
            Dim TextRect As New Rectangle(1, 1, G.MeasureString(Text, Font).ToSize.Width, G.MeasureString(Text, Font).ToSize.Height + 5)
            Dim TextInnerRect As New Rectangle(1, 2, G.MeasureString(Text, Font).ToSize.Width, G.MeasureString(Text, Font).ToSize.Height + 5 - 1)
            Dim TextInnerRect2 As New Rectangle(1, 1, G.MeasureString(Text, Font).ToSize.Width, G.MeasureString(Text, Font).ToSize.Height + 5 - 1)
            Dim TextDropshadow As New Rectangle(2, 2, G.MeasureString(Text, Font).ToSize.Width - 1, G.MeasureString(Text, Font).ToSize.Height + 4)


            Dim TextPath As GraphicsPath = D.RoundRect(TextRect, 3)
            Dim TextInnerPath As GraphicsPath = D.RoundRect(TextInnerRect, 3)
            Dim TextInnerPath2 As GraphicsPath = D.RoundRect(TextInnerRect2, 3)
            Dim TextDSPath As GraphicsPath = D.RoundRect(TextDropshadow, 3)

            G.DrawPath(New Pen(Color.Black, 2), TextDSPath)
            G.FillPath(New SolidBrush(Pal.ColDim), TextPath)
            G.DrawPath(New Pen(Color.FromArgb(45, Pal.ColHighest)), TextInnerPath)
            G.DrawPath(New Pen(Color.FromArgb(30, Pal.ColHighest)), TextInnerPath2)
            G.DrawPath(New Pen(Color.Black), TextPath)
            D.DrawTextWithShadow(G, New Rectangle(TextInnerRect.X - 10, TextInnerRect.Y + 1, TextInnerRect.Width + 20, TextInnerRect.Height - 4), Text, Font, HorizontalAlignment.Center, Color.FromArgb(120, Color.WhiteSmoke), Color.Black)
        End If
    End Sub
End Class
Public Class PVTextbox : Inherits ThemedTextbox
    Public Property BorderColor As Color = Color.FromArgb(200, Pal.ColHighest)
    Public Property InteriorColor As Color = Color.FromArgb(150, Color.WhiteSmoke)
    Sub New()
        MyBase.New()
        SetStyle(ControlStyles.UserPaint, True)
        SetStyle(ControlStyles.OptimizedDoubleBuffer, True)

        BackColor = Pal.ColDark
        BorderStyle = Windows.Forms.BorderStyle.None
        Multiline = True
        Font = New Font("Trebuchet MS", 10.0F)
    End Sub
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim G As Graphics = e.Graphics
        MyBase.OnPaint(e)

        If Not Multiline Then
            Height = 21
        End If

        G.Clear(BackColor)
        G.SmoothingMode = SmoothingMode.HighQuality

        Dim BorderRect As New Rectangle(0, 0, Width - 1, Height - 1)
        Dim BorderInnerRect As New Rectangle(1, 1, Width - 3, Height - 3)
        Dim ButtonRect As New Rectangle(5, 5, Width - 11, Height - 11)


        '| Drawing the textbox
        Dim Out1Path As GraphicsPath = D.RoundRect(BorderRect, 3)
        Dim Out2Path As GraphicsPath = D.RoundRect(BorderInnerRect, 5)
        Dim Out2LGB As New LinearGradientBrush(New Point(0, 0), New Point(0, Height), Color.FromArgb(150, Color.Black), Color.FromArgb(60, Pal.ColDim))
        G.FillRectangle(New SolidBrush(Color.FromArgb(35, Color.Black)), BorderInnerRect)
        G.DrawPath(New Pen(Out2LGB, 3), Out2Path)
        G.DrawPath(New Pen(Color.FromArgb(100, Pal.ColHighest)), Out1Path)


        'My D.drawText method seemed to cause issues.
        G.DrawString(Text, Font, New SolidBrush(InteriorColor), New Point(3, 2))
    End Sub
End Class
Public Class PVTabControl_Top : Inherits ThemedTabControl
    Sub New()
        MyBase.New()
        ItemSize = New Size(0, 60)
        Padding = New Size(18, 0)
        Font = New Font("Trebuchet MS", 10.0F)
    End Sub
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim G As Graphics = e.Graphics
        MyBase.OnPaint(e)
        Try
            BackColor = Me.Parent.BackColor
            G.Clear(Me.Parent.BackColor)
        Catch ex As Exception
            G.Clear(Pal.ColDim)
        End Try
        G.SmoothingMode = SmoothingMode.HighQuality

        '| Drawing the base Container
        Dim OffsetY As Integer = 58
        Dim ContBorderRect As New Rectangle(0, OffsetY, Width - 1, Height - 1 - OffsetY)
        Dim ContBorderInnerRect As New Rectangle(1, OffsetY + 1, Width - 3, Height - 3 - OffsetY)
        Dim ContPath1 As GraphicsPath = D.RoundRect(ContBorderRect, 3)
        Dim ContPath2 As GraphicsPath = D.RoundRect(ContBorderInnerRect, 5)
        Dim ContPath2LGB As New LinearGradientBrush(New Point(0, 0), New Point(0, Height), Color.FromArgb(200, Color.Black), Color.FromArgb(60, Pal.ColDim))
        G.FillRectangle(New SolidBrush(Color.FromArgb(35, Color.Black)), ContBorderInnerRect)
        G.DrawPath(New Pen(ContPath2LGB, 3), ContPath2)
        G.DrawPath(New Pen(Color.FromArgb(100, Pal.ColHighest)), ContPath1)

        For i = 0 To TabCount - 1
            '| Drawinh the tabs
            Dim TabRectBase As Rectangle = GetTabRect(i)
            Dim ButtonOffset As Integer = 7
            Dim XOFF As Integer = 2
            Dim TabRect As New Rectangle(XOFF + TabRectBase.X, TabRectBase.Y, TabRectBase.Width - 1 - XOFF * 2, TabRectBase.Height - 1 - ButtonOffset)
            Dim TabInnerRect As New Rectangle(XOFF + TabRectBase.X + 1, TabRectBase.Y + 1, TabRectBase.Width - 3 - XOFF * 2, TabRectBase.Height - 3 - ButtonOffset)
            Dim TabInnerButtonRect As New Rectangle(XOFF + TabRectBase.X + 5, TabRectBase.Y + 5, TabRectBase.Width - 11 - XOFF * 2, TabRectBase.Height - 11 - ButtonOffset)

            '| Drawing the tab button's hole into the form (Whats the whole that a button goes into? There even a name for that???)
            Dim TabRectPath As GraphicsPath = D.RoundRect(TabRect, 3)
            Dim TabInnerRectPath As GraphicsPath = D.RoundRect(TabInnerRect, 5)
            Dim TabInnerRectPathLGB As New LinearGradientBrush(New Point(0, 0), New Point(0, Height), Color.FromArgb(150, Color.Black), Color.FromArgb(60, Pal.ColDim))
            G.FillRectangle(New SolidBrush(Color.FromArgb(35, Color.Black)), TabInnerRect)
            G.DrawPath(New Pen(TabInnerRectPathLGB, 3), TabInnerRectPath)
            G.DrawPath(New Pen(Color.FromArgb(100, Pal.ColHighest)), TabRectPath)

            '| Drawing the tab button
            Dim InnerButtonWidth As Integer = 10
            Dim TabInnerButtonPath As GraphicsPath = D.RoundRect(TabInnerButtonRect, 4)
            Dim TabInnermostButtonPath As GraphicsPath = D.RoundRect(New Rectangle(TabInnerButtonRect.X + InnerButtonWidth, TabInnerButtonRect.Y, TabInnerButtonRect.Width - (InnerButtonWidth * 2), TabInnerButtonRect.Height), 4)
            Dim TabInnerButtonHighlightPath As GraphicsPath = D.RoundRect(New Rectangle(TabInnerButtonRect.X, TabInnerButtonRect.Y + 1, TabInnerButtonRect.Width, TabInnerButtonRect.Height - 2), 4)

            If i = SelectedIndex Then
                G.FillPath(New SolidBrush(Color.FromArgb(70, Pal.ColDim)), TabInnerButtonPath)
                G.FillPath(New SolidBrush(Pal.ColDim), TabInnermostButtonPath)
                G.FillPath(New SolidBrush(Color.FromArgb(50, Pal.ColDark)), TabInnermostButtonPath)
                D.FillGradientBeam(G, Color.FromArgb(35, Color.Black), Color.FromArgb(14, Pal.ColHighest), TabInnerButtonRect, GradientAlignment.Vertical)
                TabInnerButtonHighlightPath = D.RoundRect(New Rectangle(TabInnerButtonRect.X, TabInnerButtonRect.Y + 1, TabInnerButtonRect.Width, TabInnerButtonRect.Height - 1), 4)
                G.DrawPath(New Pen(Color.FromArgb(100, Color.Black), 3), TabInnerButtonHighlightPath)
                D.DrawTextWithShadow(G, TabInnerRect, TabPages(i).Text, Font, HorizontalAlignment.Center, Color.FromArgb(200, Pal.ColHighest), Color.Black)
            Else
                G.FillPath(New SolidBrush(Color.FromArgb(100, Pal.ColDim)), TabInnerButtonPath)
                G.FillPath(New SolidBrush(Pal.ColDim), TabInnermostButtonPath)
                D.FillGradientBeam(G, Color.FromArgb(20, Color.Black), Color.FromArgb(20, Pal.ColHighest), TabInnerButtonRect, GradientAlignment.Vertical)
                G.DrawPath(New Pen(Color.FromArgb(60, Pal.ColHighest)), TabInnerButtonHighlightPath)
                D.DrawTextWithShadow(G, TabInnerRect, TabPages(i).Text, Font, HorizontalAlignment.Center, Color.FromArgb(120, Color.WhiteSmoke), Color.Black)
            End If

            G.DrawPath(New Pen(Color.FromArgb(60, Pal.ColHighest)), TabInnerButtonHighlightPath)
            D.DrawTextWithShadow(G, TabInnerRect, Text, Font, HorizontalAlignment.Center, Color.FromArgb(120, Color.WhiteSmoke), Color.Black)
            G.DrawPath(Pens.Black, TabInnerButtonPath)

            '| Changes the tab's BG color to match the surroundings.
            Try
                Dim ParentCol As Color = Me.Parent.BackColor
                Dim MixCol As Color = Pal.ColDark
                MixCol = Color.FromArgb((MixCol.R + ParentCol.R) / 2, (MixCol.G + ParentCol.G) / 2, (MixCol.B + ParentCol.B) / 2)
                TabPages(i).BackColor = MixCol
            Catch : End Try
        Next
    End Sub
End Class
Public Class PVTabControl_Side : Inherits ThemedTabControl
    Sub New()
        MyBase.New()
        Alignment = TabAlignment.Left
        DoubleBuffered = True
        SizeMode = TabSizeMode.Fixed
        ItemSize = New Size(50, 100)
        Font = New Font("Trebuchet MS", 10.0F)
    End Sub
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim G As Graphics = e.Graphics
        MyBase.OnPaint(e)
        Try

            BackColor = Me.Parent.BackColor
            G.Clear(Me.Parent.BackColor)
        Catch ex As Exception
            G.Clear(Pal.ColDim)
        End Try
        G.SmoothingMode = SmoothingMode.HighQuality

        '| Drawing the base Container
        Dim ContXOffset As Integer = 100
        Dim ContBorderRect As New Rectangle(ContXOffset, 0, Width - 1 - ContXOffset, Height - 1)
        Dim ContBorderInnerRect As New Rectangle(ContXOffset + 1, 1, Width - 3 - ContXOffset, Height - 3)
        Dim ContPath1 As GraphicsPath = D.RoundRect(ContBorderRect, 3)
        Dim ContPath2 As GraphicsPath = D.RoundRect(ContBorderInnerRect, 5)
        Dim ContPath2LGB As New LinearGradientBrush(New Point(0, 0), New Point(0, Height), Color.FromArgb(200, Color.Black), Color.FromArgb(60, Pal.ColDim))
        G.FillRectangle(New SolidBrush(Color.FromArgb(35, Color.Black)), ContBorderInnerRect)
        G.DrawPath(New Pen(ContPath2LGB, 3), ContPath2)
        G.DrawPath(New Pen(Color.FromArgb(100, Pal.ColHighest)), ContPath1)

        For i = 0 To TabCount - 1
            '| Drawinh the tabs
            Dim TabRectBase As Rectangle = GetTabRect(i)
            Dim WidthOffset As Integer = 3
            Dim YOffset As Integer = 2
            Dim XOffset As Integer = -2

            Dim TabRect As New Rectangle(XOffset + TabRectBase.X, YOffset + TabRectBase.Y, TabRectBase.Width - 1 - WidthOffset, TabRectBase.Height - 1 - YOffset)
            Dim TabInnerRect As New Rectangle(XOffset + TabRectBase.X + 1, YOffset + TabRectBase.Y + 1, TabRectBase.Width - 3 - WidthOffset, TabRectBase.Height - 3 - YOffset)
            Dim TabInnerButtonRect As New Rectangle(XOffset + TabRectBase.X + 5, YOffset + TabRectBase.Y + 5, TabRectBase.Width - 11 - WidthOffset, TabRectBase.Height - 11 - YOffset)

            '| Drawing the tab button's hole into the form (Whats the whole that a button goes into? There even a name for that???)
            Dim TabRectPath As GraphicsPath = D.RoundRect(TabRect, 3)
            Dim TabInnerRectPath As GraphicsPath = D.RoundRect(TabInnerRect, 5)
            Dim TabInnerRectPathLGB As New LinearGradientBrush(New Point(0, 0), New Point(0, Height), Color.FromArgb(150, Color.Black), Color.FromArgb(60, Pal.ColDim))
            G.FillRectangle(New SolidBrush(Color.FromArgb(35, Color.Black)), TabInnerRect)
            G.DrawPath(New Pen(TabInnerRectPathLGB, 3), TabInnerRectPath)
            G.DrawPath(New Pen(Color.FromArgb(100, Pal.ColHighest)), TabRectPath)

            '| Drawing the tab button
            Dim InnerButtonWidth As Integer = 10
            Dim TabInnerButtonPath As GraphicsPath = D.RoundRect(TabInnerButtonRect, 4)
            Dim TabInnermostButtonPath As GraphicsPath = D.RoundRect(New Rectangle(TabInnerButtonRect.X + InnerButtonWidth, TabInnerButtonRect.Y, TabInnerButtonRect.Width - (InnerButtonWidth * 2), TabInnerButtonRect.Height), 4)
            Dim TabInnerButtonHighlightPath As GraphicsPath = D.RoundRect(New Rectangle(TabInnerButtonRect.X, TabInnerButtonRect.Y + 1, TabInnerButtonRect.Width, TabInnerButtonRect.Height - 2), 4)

            If i = SelectedIndex Then
                G.FillPath(New SolidBrush(Color.FromArgb(70, Pal.ColDim)), TabInnerButtonPath)
                G.FillPath(New SolidBrush(Pal.ColDim), TabInnermostButtonPath)
                G.FillPath(New SolidBrush(Color.FromArgb(50, Pal.ColDark)), TabInnermostButtonPath)
                D.FillGradientBeam(G, Color.FromArgb(35, Color.Black), Color.FromArgb(14, Pal.ColHighest), TabInnerButtonRect, GradientAlignment.Vertical)
                TabInnerButtonHighlightPath = D.RoundRect(New Rectangle(TabInnerButtonRect.X, TabInnerButtonRect.Y + 1, TabInnerButtonRect.Width, TabInnerButtonRect.Height - 1), 4)
                G.DrawPath(New Pen(Color.FromArgb(100, Color.Black), 3), TabInnerButtonHighlightPath)
                D.DrawTextWithShadow(G, TabInnerRect, TabPages(i).Text, Font, HorizontalAlignment.Center, Color.FromArgb(200, Pal.ColHighest), Color.Black)
            Else
                G.FillPath(New SolidBrush(Color.FromArgb(100, Pal.ColDim)), TabInnerButtonPath)
                G.FillPath(New SolidBrush(Pal.ColDim), TabInnermostButtonPath)
                D.FillGradientBeam(G, Color.FromArgb(20, Color.Black), Color.FromArgb(20, Pal.ColHighest), TabInnerButtonRect, GradientAlignment.Vertical)
                G.DrawPath(New Pen(Color.FromArgb(60, Pal.ColHighest)), TabInnerButtonHighlightPath)
                D.DrawTextWithShadow(G, TabInnerRect, TabPages(i).Text, Font, HorizontalAlignment.Center, Color.FromArgb(120, Color.WhiteSmoke), Color.Black)
            End If

            G.DrawPath(New Pen(Color.FromArgb(60, Pal.ColHighest)), TabInnerButtonHighlightPath)
            D.DrawTextWithShadow(G, TabInnerRect, Text, Font, HorizontalAlignment.Center, Color.FromArgb(120, Color.WhiteSmoke), Color.Black)
            G.DrawPath(Pens.Black, TabInnerButtonPath)

            '| Changes the tab's BG color to match the surroundings.
            Try
                Dim ParentCol As Color = Me.Parent.BackColor
                Dim MixCol As Color = Pal.ColDark
                MixCol = Color.FromArgb((MixCol.R + ParentCol.R) / 2, (MixCol.G + ParentCol.G) / 2, (MixCol.B + ParentCol.B) / 2)
                TabPages(i).BackColor = MixCol
            Catch : End Try
        Next
    End Sub
End Class
Public Class PVProgressBar : Inherits ThemedControl
    Private PValue As Integer = 50
    Public Property Value() As Integer
        Get
            Return PValue
        End Get
        Set(ByVal value As Integer)
            Invalidate()
            PValue = value
        End Set
    End Property
    Public Property Minimum As Integer = 0
    Public Property Maximum As Integer = 100
    Sub New()
        MyBase.New()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.UserPaint Or ControlStyles.ResizeRedraw, True)
        BackColor = Pal.ColDark
        MinimumSize = New Size(21, 21)
        Font = New Font("Trebuchet MS", 10.0F)
        Value = 50
    End Sub
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim G As Graphics = e.Graphics
        MyBase.OnPaint(e)
        'Height = 30
        ' Height = 21
        '| If lazy, put back to 21, else
        '| http://cdns2.freepik.com/foto-gratuito/barra-di-avanzamento-ui_29-20000356.jpg
        Dim ProgHeight As Integer = 21

        G.Clear(BackColor)
        Try
            Dim s As String = (Me.Parent).GetType().Name
            If s.Contains("PVGroupbox") Then
                G.FillRectangle(New SolidBrush(Color.FromArgb(39, Pal.ColDim)), New Rectangle(0, 0, Width, Height))
            End If
        Catch ex As Exception

        End Try

        G.SmoothingMode = SmoothingMode.HighQuality
        Dim BorderRect As New Rectangle(0, 0, Width - 1, ProgHeight - 1)
        Dim BorderInnerRect As New Rectangle(1, 1, Width - 3, ProgHeight - 3)
        Dim ButtonRect As New Rectangle(5, 5, Width - 11, ProgHeight - 11)
        '| Drawing the BG / assigning main variables
        Dim Out1Path As GraphicsPath = D.RoundRect(BorderRect, 3)
        Dim Out2Path As GraphicsPath = D.RoundRect(BorderInnerRect, 5)
        Dim Out2LGB As New LinearGradientBrush(New Point(0, 0), New Point(0, ProgHeight), Color.FromArgb(150, Color.Black), Color.FromArgb(60, Pal.ColDim))
        G.DrawPath(New Pen(Out2LGB, 3), Out2Path)
        D.FillDualGradPath(G, Color.FromArgb(100, Color.Black), Color.Transparent, BorderRect, Out2Path, GradientAlignment.Horizontal)
        '| Drawing the bar
        Dim BarRect As New Rectangle(2, 2, ValueToPercentage(PValue) * Width - 4, ProgHeight - 5)
        If PValue > 0 Then
            Dim BarPath As GraphicsPath = D.RoundRect(BarRect, 3)
            Dim BarHighlightPath As GraphicsPath = D.RoundRect(New Rectangle(BarRect.X, BarRect.Y, BarRect.Width, BarRect.Height / 2), 4)
            Dim BarHighlightLGB As New LinearGradientBrush(New Point(0, 0), New Point(0, BarRect.Height / 2 + 1), Color.FromArgb(60, Color.AliceBlue), Color.FromArgb(100, Color.White))
            Dim DiagonalHatch As HatchBrush = New HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.Transparent, Color.FromArgb(15, Color.AliceBlue))
            D.FillDualGradPath(G, Color.FromArgb(45, 75, 210), Color.FromArgb(65, 135, 255), BarRect, BarPath, GradientAlignment.Horizontal)
            G.FillPath(DiagonalHatch, BarPath)
            G.FillPath(BarHighlightLGB, BarHighlightPath)
            D.FillDualGradPath(G, Color.FromArgb(140, Color.FromArgb(10, 30, 100)), Color.FromArgb(10, Color.FromArgb(20, 50, 160)), BarRect, BarPath, GradientAlignment.Horizontal)
            G.DrawPath(New Pen(Pal.ColDark), BarPath)
        End If
        G.DrawPath(New Pen(Color.FromArgb(100, Pal.ColHighest)), Out1Path)
        If True Then
            Dim BarText As String = FormatPercent(ValueToPercentage(PValue)).Replace(".00", "")
            Dim TextSize As Size = G.MeasureString(BarText, Font).ToSize
            If Height < 38 Then
                Dim Opacity As Integer = 0
                Opacity = ValueToPercentage(PValue) * 500
                If Opacity > 255 Then
                    Opacity = 255
                End If

                D.DrawTextWithShadow(G, New Rectangle(BarRect.Width - TextSize.Width, 0, 100, BarRect.Height + 3), BarText, Font, HorizontalAlignment.Left, Color.FromArgb(Opacity, Color.White), Color.FromArgb(Opacity, Color.Black))
            Else
                Dim PercentPath As New GraphicsPath
                Dim StartX As Integer = Width - 51
                With PercentPath
                    .AddLine(New Point(StartX, 20), New Point(StartX + 20, 38))
                    .AddLine(New Point(StartX + 20, 38), New Point(StartX + 50, 38))
                    .AddLine(New Point(StartX + 50, 38), New Point(StartX + 50, 19))
                End With

                G.SmoothingMode = SmoothingMode.None
                G.FillRectangle(New SolidBrush(Pal.ColDark), New Rectangle(StartX, 20, 50, 1))
                G.DrawLine(New Pen(Pal.ColDark), New Point(StartX + 49, 17), New Point(StartX + 49, 19))
                G.SmoothingMode = SmoothingMode.HighQuality

                Dim FillLGB As New LinearGradientBrush(New Point(0, 19), New Point(0, 39), Color.FromArgb(100, Pal.ColDim), Color.FromArgb(85, Color.Black))
                G.FillPath(FillLGB, PercentPath)
                D.DrawTextWithShadow(G, New Rectangle(Width - TextSize.Width, 13, 100, 30), BarText, Font, HorizontalAlignment.Left, Color.FromArgb(140, Color.WhiteSmoke), Pal.ColDark)
                G.DrawPath(New Pen(Color.FromArgb(100, Pal.ColHighest)), PercentPath)
            End If
        End If
    End Sub
    Private Function ValueToPercentage(val As Integer) As Single
        Dim min = Minimum
        Dim max = Maximum
        Return (val - min) / (max - min)
        'vertical:  Return 1 - (value - min) / (max - min)
    End Function
End Class
Public Class PVNumericUD : Inherits ThemedControl
    Private WithEvents TxtBox As New PVTextbox
    Private WithEvents BtnUp As New PVButton
    Private WithEvents BtnDown As New PVButton
    Public Property ButtonChange As Integer = 1
    Public Property Minimum As Integer = 1
    Public Property Maximum As Integer = 100

    '| Used the MouseDown event because it doesn't use a delay like the click one does.
    Protected Sub BtnUp_Down(ByVal Sender As Object, ByVal e As System.EventArgs) Handles BtnUp.MouseDown
        Value = Value + ButtonChange
    End Sub
    Protected Sub BtnDown_Down(ByVal Sender As Object, ByVal e As System.EventArgs) Handles BtnDown.MouseDown
        Value = Value - ButtonChange
    End Sub

    Public Property Value() As Integer
        Get
            Dim Ret As Integer = 0
            Try : Ret = CInt(TxtBox.Text) : Catch ex As Exception : End Try
            Return Ret
        End Get
        Set(ByVal val As Integer)
            If val <= Maximum And val >= Minimum Then
                TxtBox.Text = val
                Invalidate()
            End If
        End Set
    End Property
    Sub New()
        MyBase.New()
        Size = New Point(300, 300)
        Font = New Font("Trebuchet MS", 10.0F)
        TxtBox.Text = 0
        Controls.Add(TxtBox)
        Controls.Add(BtnUp)
        Controls.Add(BtnDown)
    End Sub
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim G As Graphics = e.Graphics
        MyBase.OnPaint(e)
        G.Clear(Me.Parent.BackColor)
        Height = 30
        BtnUp.MinimumSize = New Size(15, 15)
        BtnUp.Size = New Size(10, 10)
        BtnUp.Location = New Point(Size.Width - BtnUp.Width, 0)
        BtnUp.Font = New Font("Trebuchet MS", 10.0F)
        BtnUp.Text = "ᴧ"
        BtnDown.MinimumSize = New Size(15, 15)
        BtnDown.Size = New Size(10, 10)
        BtnDown.Location = New Point(Size.Width - BtnUp.Width, BtnUp.Size.Height)
        BtnDown.Font = New Font("Trebuchet MS", 10.0F, FontStyle.Bold)
        BtnDown.Text = "v"
        TxtBox.Location = New Point(0, 0)
        TxtBox.Multiline = True
        TxtBox.Height = 30
        TxtBox.Width = BtnUp.Location.X - 2
    End Sub
End Class
Public Class PVCheckbox : Inherits ThemedControl
    Public Property Checked As Boolean
    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseDown(e)
        Checked = Not Checked
        BackColor = Color.FromArgb(21, 23, 25)
    End Sub
    Sub New()
        MyBase.New()
        Font = New Font("Trebuchet MS", 10.0F)
    End Sub
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Try
            BackColor = Me.Parent.BackColor
        Catch ex As Exception : End Try
        Dim G As Graphics = e.Graphics
        MyBase.OnPaint(e)
        G.Clear(BackColor)
        G.SmoothingMode = SmoothingMode.HighQuality

        Height = 30
        Dim x As New Rectangle(0, 0, Height - 2, Height - 2)
        Dim x2 As New Rectangle(0, 1, Height - 2, Height - 2)
        Dim y As GraphicsPath = D.RoundRect(x, 3)
        Dim y2 As GraphicsPath = D.RoundRect(x2, 3)

        G.DrawPath(New Pen(Pal.ColHigh), y2)
        G.FillPath(New SolidBrush(Pal.ColDark), y)
        G.DrawPath(New Pen(Color.FromArgb(200, Color.Black)), y)

        If Checked Then
            Dim chkPoly As Rectangle = New Rectangle(1 + (Height - 6) / 4, 1 + (Height - 6) / 4, (Height - 6) \ 2 + 2, (Height - 6) \ 2 + 4)
            Dim Poly As New GraphicsPath
            With Poly
                .AddLine(New Point(chkPoly.X, chkPoly.Y + chkPoly.Height \ 2), New Point(chkPoly.X + chkPoly.Width \ 2, chkPoly.Y + chkPoly.Height))
                .AddLine(New Point(chkPoly.X + chkPoly.Width \ 2, chkPoly.Y + chkPoly.Height), New Point(chkPoly.X + chkPoly.Width, chkPoly.Y - 2))
            End With
            G.DrawPath(New Pen(Color.FromArgb(255, Pal.ColHighest), 2), Poly)
        End If

        D.DrawTextWithShadow(G, New Rectangle(Height, 0, Width - Height, Height - 4), Text, Font, HorizontalAlignment.Left, Pal.ColHighest, Color.Black)
    End Sub
End Class
Public Class PVRadiobutton : Inherits ThemedControl
    Public Property Checked As Boolean
    Protected Overrides Sub OnMouseDown(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseDown(e)
        For Each Cont As Control In Parent.Controls
            If TypeOf Cont Is PVRadiobutton Then
                DirectCast(Cont, PVRadiobutton).Checked = False
                Cont.Invalidate()
            End If
        Next
        Checked = True
    End Sub
    Sub New()
        MyBase.New()
        Font = New Font("Trebuchet MS", 10.0F)
        BackColor = Color.FromArgb(21, 23, 25)
    End Sub
    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim G As Graphics = e.Graphics
        MyBase.OnPaint(e)
        Try
            BackColor = Me.Parent.BackColor
        Catch ex As Exception : End Try
        G.Clear(BackColor)
        G.SmoothingMode = SmoothingMode.HighQuality

        Height = 30
        Dim x As New Rectangle(0, 0, Height - 2, Height - 2)
        Dim x2 As New Rectangle(0, 1, Height - 2, Height - 2)


        G.DrawEllipse(New Pen(Pal.ColHigh), x2)
        G.FillEllipse(New SolidBrush(Pal.ColDark), x)
        G.DrawEllipse(New Pen(Color.FromArgb(200, Color.Black)), x)

        If Checked Then
            Dim x3 As New Rectangle(3, 3, Height - 8, Height - 8)
            G.FillEllipse(New SolidBrush(Pal.ColHighest), x3)
        End If

        D.DrawTextWithShadow(G, New Rectangle(Height, 0, Width, Height - 4), Text, Font, HorizontalAlignment.Left, Pal.ColHighest, Color.Black)

    End Sub
End Class
Public Class PVListbox : Inherits ThemedListControl
    Public Property TextAlignment As HorizontalAlignment = HorizontalAlignment.Center
    Sub New()
        MyBase.New()
        IntegralHeight = False
        ItemHeight = 24
        Font = New Font("Segoe UI Semilight", 12.0F)
        ForeColor = Pal.ColHighest
        DrawMode = DrawMode.OwnerDrawVariable
        BorderStyle = BorderStyle.None
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint Or ControlStyles.DoubleBuffer, True)
    End Sub

    Protected Sub OnItemPaint(ByVal G As Graphics, ByVal i As Integer)
        Dim FirstItemOffset As Integer = 0
        Dim RectOffset As Integer = 1
        If i = 0 Then
            FirstItemOffset = 3
        End If
        Dim ItemRect As New Rectangle(4, RectOffset + FirstItemOffset + i * ItemHeight, Width - 10, ItemHeight - (RectOffset * 2) - (FirstItemOffset) - 0)
        Dim ButtonPath As GraphicsPath = D.RoundRect(ItemRect, 4)
        Dim ButtonInnerPath As GraphicsPath = D.RoundRect(New Rectangle(ItemRect.X, ItemRect.Y, ItemRect.Width, ItemRect.Height), 4)
        Dim ButtonHighlightPath As GraphicsPath = D.RoundRect(New Rectangle(ItemRect.X, ItemRect.Y + 1, ItemRect.Width, ItemRect.Height - 2), 4)

        G.FillPath(New SolidBrush(Color.FromArgb(100, Pal.ColDim)), ButtonPath)
        G.FillPath(New SolidBrush(Pal.ColDim), ButtonInnerPath)
        If i = SelectedIndex Then
            G.FillPath(New SolidBrush(Color.FromArgb(50, 50, 170, 250)), ButtonInnerPath)
        End If

        If i = SelectedIndex Then
            G.DrawPath(New Pen(Color.FromArgb(160, Pal.ColHighest)), ButtonHighlightPath)
            G.DrawPath(Pens.Black, ButtonPath)
            D.FillGradientBeam(G, Color.FromArgb(40, Color.Black), Color.FromArgb(30, Pal.ColHighest), ItemRect, GradientAlignment.Vertical)
        Else
            G.DrawPath(New Pen(Color.FromArgb(60, Pal.ColHighest)), ButtonHighlightPath)
            G.DrawPath(Pens.Black, ButtonPath)
            D.FillGradientBeam(G, Color.FromArgb(20, Color.Black), Color.FromArgb(20, Pal.ColHighest), ItemRect, GradientAlignment.Vertical)
        End If

        Dim TextCol As Color = Color.WhiteSmoke
        If i = SelectedIndex Then : TextCol = Color.FromArgb(50, 170, 250) : End If
        D.DrawTextWithShadow(G, ItemRect, Items(i).ToString(), Font, TextAlignment, TextCol, Color.Black)
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim G As Graphics = e.Graphics
        MyBase.OnPaint(e)
        G.Clear(Me.Parent.BackColor)
        G.SmoothingMode = SmoothingMode.HighQuality
        BorderStyle = BorderStyle.None



        Dim BorderRect As New Rectangle(0, 0, Width - 1, Height - 1)
        Dim BorderInnerRect As New Rectangle(1, 1, Width - 3, Height - 3)
        Dim ButtonRect As New Rectangle(3, 1, Width - 7, Height - 3)


        '| Drawing the button's hole into the form (Whats the whole that a button goes into? There even a name for that???)
        Dim Out1Path As GraphicsPath = D.RoundRect(BorderRect, 3)
        Dim Out2Path As GraphicsPath = D.RoundRect(BorderInnerRect, 5)
        Dim Out2LGB As New LinearGradientBrush(New Point(0, 0), New Point(0, Height), Color.FromArgb(150, Color.Black), Color.FromArgb(60, Pal.ColDim))
        G.FillRectangle(New SolidBrush(Color.FromArgb(35, Color.Black)), BorderInnerRect)
        G.DrawPath(New Pen(Out2LGB, 3), Out2Path)
        G.DrawPath(New Pen(Color.FromArgb(100, Pal.ColHighest)), Out1Path)

        '| Drawing the button
        Dim ButtonPath As GraphicsPath = D.RoundRect(ButtonRect, 4)
        Dim ButtonInnerPath As GraphicsPath = D.RoundRect(New Rectangle(ButtonRect.X, ButtonRect.Y, ButtonRect.Width, ButtonRect.Height), 4)
        Dim ButtonHighlightPath As GraphicsPath = D.RoundRect(New Rectangle(ButtonRect.X, ButtonRect.Y + 1, ButtonRect.Width, ButtonRect.Height - 2), 4)
        If False Then
            G.FillPath(New SolidBrush(Color.FromArgb(100, Pal.ColDim)), ButtonPath)
            G.FillPath(New SolidBrush(Pal.ColDim), ButtonInnerPath)
            D.FillGradientBeam(G, Color.FromArgb(20, Color.Black), Color.FromArgb(20, Pal.ColHighest), ButtonRect, GradientAlignment.Vertical)

            G.DrawPath(New Pen(Color.FromArgb(60, Pal.ColHighest)), ButtonHighlightPath)
            G.DrawPath(Pens.Black, ButtonPath)
        End If



        Dim x As Integer = 0
        For Each i As Object In Items
            OnItemPaint(G, x)
            x += 1
        Next
    End Sub
End Class
#End Region

#Region "Theme Utility Stuff"
Public Class Palette
    Public ColHighest As Color
    Public ColHigh As Color
    Public ColMed As Color
    Public ColDim As Color
    Public ColDark As Color
End Class
Public Enum MouseState As Byte
    None = 0
    Over = 1
    Down = 2
    Block = 3
End Enum
Public Enum GradientAlignment As Byte
    Vertical = 0
    Horizontal = 1
End Enum
Public Class DrawUtils
    Public Sub FillGradientBeam(ByVal g As Graphics, ByVal Col1 As Color, ByVal Col2 As Color, ByVal rect As Rectangle, ByVal align As GradientAlignment)
        Dim stored As SmoothingMode = g.SmoothingMode
        Dim Blend As New ColorBlend
        g.SmoothingMode = SmoothingMode.HighQuality
        Select Case align
            Case GradientAlignment.Vertical
                Dim PathGradient As New LinearGradientBrush(New Point(rect.X, rect.Y), New Point(rect.X + rect.Width - 1, rect.Y), Color.Black, Color.Black)
                Blend.Positions = {0, 1 / 2, 1}
                Blend.Colors = {Col1, Col2, Col1}
                PathGradient.InterpolationColors = Blend
                g.FillRectangle(PathGradient, rect)
            Case GradientAlignment.Horizontal
                Dim PathGradient As New LinearGradientBrush(New Point(rect.X, rect.Y), New Point(rect.X, rect.Y + rect.Height), Color.Black, Color.Black)
                Blend.Positions = {0, 1 / 2, 1}
                Blend.Colors = {Col1, Col2, Col1}
                PathGradient.InterpolationColors = Blend
                PathGradient.RotateTransform(0)
                g.FillRectangle(PathGradient, rect)
        End Select
        g.SmoothingMode = stored
    End Sub
    Public Sub DrawTextWithShadow(ByVal G As Graphics, ByVal ContRect As Rectangle, ByVal Text As String, ByVal TFont As Font, ByVal TAlign As HorizontalAlignment, ByVal TColor As Color, ByVal BColor As Color)
        DrawText(G, New Rectangle(ContRect.X + 1, ContRect.Y + 1, ContRect.Width, ContRect.Height), Text, TFont, TAlign, BColor)
        DrawText(G, ContRect, Text, TFont, TAlign, TColor)
    End Sub
    Public Sub FillDualGradPath(ByVal g As Graphics, ByVal Col1 As Color, ByVal Col2 As Color, ByVal rect As Rectangle, ByVal gp As GraphicsPath, ByVal align As GradientAlignment)
        Dim stored As SmoothingMode = g.SmoothingMode
        Dim Blend As New ColorBlend
        g.SmoothingMode = SmoothingMode.HighQuality
        Select Case align
            Case GradientAlignment.Vertical
                Dim PathGradient As New LinearGradientBrush(New Point(rect.X, rect.Y), New Point(rect.X + rect.Width - 1, rect.Y), Color.Black, Color.Black)
                Blend.Positions = {0, 1 / 2, 1}
                Blend.Colors = {Col1, Col2, Col1}
                PathGradient.InterpolationColors = Blend
                g.FillPath(PathGradient, gp)
            Case GradientAlignment.Horizontal
                Dim PathGradient As New LinearGradientBrush(New Point(rect.X, rect.Y), New Point(rect.X, rect.Y + rect.Height), Color.Black, Color.Black)
                Blend.Positions = {0, 1 / 2, 1}
                Blend.Colors = {Col1, Col2, Col1}
                PathGradient.InterpolationColors = Blend
                PathGradient.RotateTransform(0)
                g.FillPath(PathGradient, gp)
        End Select
        g.SmoothingMode = stored
    End Sub
    Public Sub DrawText(ByVal G As Graphics, ByVal ContRect As Rectangle, ByVal Text As String, ByVal TFont As Font, ByVal TAlign As HorizontalAlignment, ByVal TColor As Color)
        If String.IsNullOrEmpty(Text) Then Return
        Dim TextSize As Size = G.MeasureString(Text, TFont).ToSize
        Dim CenteredY As Integer = ContRect.Height \ 2 - TextSize.Height \ 2
        Select Case TAlign
            Case HorizontalAlignment.Left
                Dim sf As New StringFormat
                sf.LineAlignment = StringAlignment.Near
                sf.Alignment = StringAlignment.Near
                G.DrawString(Text, TFont, New SolidBrush(TColor), New Rectangle(ContRect.X, ContRect.Y + ContRect.Height / 2 - TextSize.Height / 2, ContRect.Width, ContRect.Height), sf)
            Case HorizontalAlignment.Right
                Dim sf As New StringFormat
                sf.LineAlignment = StringAlignment.Far
                sf.Alignment = StringAlignment.Far
                G.DrawString(Text, TFont, New SolidBrush(TColor), New Rectangle(ContRect.X, ContRect.Y, ContRect.Width, ContRect.Height / 2 + TextSize.Height / 2), sf)
            Case HorizontalAlignment.Center
                Dim sf As New StringFormat
                sf.LineAlignment = StringAlignment.Center
                sf.Alignment = StringAlignment.Center
                G.DrawString(Text, TFont, New SolidBrush(TColor), ContRect, sf)
        End Select
    End Sub
    Public Function RoundRect(ByVal Rectangle As Rectangle, ByVal Curve As Integer) As GraphicsPath
        Dim Path As New GraphicsPath
        Dim ArcRectangleWidth As Integer = Curve * 2
        With Path
            .AddArc(New Rectangle(Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -180, 90)
            .AddArc(New Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -90, 90)
            .AddArc(New Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 0, 90)
            .AddArc(New Rectangle(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 90, 90)
            .AddLine(New Point(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y), New Point(Rectangle.X, Curve + Rectangle.Y))
        End With
        Return Path
    End Function
    Public Function RoundedTopRect(ByVal Rectangle As Rectangle, ByVal Curve As Integer) As GraphicsPath
        Dim Path As GraphicsPath = New GraphicsPath()
        Dim ArcRectangleWidth As Integer = Curve * 2
        With Path
            .AddArc(New Rectangle(Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -180, 90)
            .AddArc(New Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -90, 90)
            .AddLine(New Point(Rectangle.X + Rectangle.Width, Rectangle.Y + ArcRectangleWidth), New Point(Rectangle.X + Rectangle.Width, Rectangle.Y + Rectangle.Height))
            .AddLine(New Point(Rectangle.X, Rectangle.Height + Rectangle.Y), New Point(Rectangle.X, Rectangle.Y + Curve))
        End With
        Return Path
    End Function
End Class
#End Region