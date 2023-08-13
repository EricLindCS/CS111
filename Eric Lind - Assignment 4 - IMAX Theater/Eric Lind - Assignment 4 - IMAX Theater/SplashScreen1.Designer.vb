<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen1
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
    Friend WithEvents ApplicationTitle As Label
    Friend WithEvents MainLayoutPanel As TableLayoutPanel

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(SplashScreen1))
        MainLayoutPanel = New TableLayoutPanel()
        Label1 = New Label()
        DetailsLayoutPanel = New TableLayoutPanel()
        Version = New Label()
        Copyright = New Label()
        ApplicationTitle = New Label()
        Timer1 = New Timer(components)
        MainLayoutPanel.SuspendLayout()
        DetailsLayoutPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' MainLayoutPanel
        ' 
        MainLayoutPanel.BackgroundImage = CType(resources.GetObject("MainLayoutPanel.BackgroundImage"), Image)
        MainLayoutPanel.BackgroundImageLayout = ImageLayout.None
        MainLayoutPanel.ColumnCount = 2
        MainLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 243F))
        MainLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 100F))
        MainLayoutPanel.Controls.Add(Label1, 0, 1)
        MainLayoutPanel.Controls.Add(DetailsLayoutPanel, 1, 1)
        MainLayoutPanel.Controls.Add(ApplicationTitle, 1, 0)
        MainLayoutPanel.Dock = DockStyle.Fill
        MainLayoutPanel.Location = New Point(0, 0)
        MainLayoutPanel.Name = "MainLayoutPanel"
        MainLayoutPanel.RowCount = 2
        MainLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 218F))
        MainLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 38F))
        MainLayoutPanel.Size = New Size(496, 303)
        MainLayoutPanel.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(17, 250)
        Label1.Name = "Label1"
        Label1.Size = New Size(208, 20)
        Label1.TabIndex = 2
        Label1.Text = "Version 1.00"
        ' 
        ' DetailsLayoutPanel
        ' 
        DetailsLayoutPanel.Anchor = AnchorStyles.None
        DetailsLayoutPanel.BackColor = Color.Transparent
        DetailsLayoutPanel.ColumnCount = 1
        DetailsLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 142F))
        DetailsLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 142F))
        DetailsLayoutPanel.Controls.Add(Version, 0, 0)
        DetailsLayoutPanel.Controls.Add(Copyright, 0, 1)
        DetailsLayoutPanel.Location = New Point(246, 221)
        DetailsLayoutPanel.Name = "DetailsLayoutPanel"
        DetailsLayoutPanel.RowCount = 2
        DetailsLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 33F))
        DetailsLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 33F))
        DetailsLayoutPanel.Size = New Size(247, 79)
        DetailsLayoutPanel.TabIndex = 1
        ' 
        ' Version
        ' 
        Version.Anchor = AnchorStyles.None
        Version.BackColor = Color.Transparent
        Version.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Version.Location = New Point(15, 9)
        Version.Name = "Version"
        Version.Size = New Size(216, 20)
        Version.TabIndex = 1
        Version.Text = "Version 1.00"
        ' 
        ' Copyright
        ' 
        Copyright.Anchor = AnchorStyles.None
        Copyright.BackColor = Color.Transparent
        Copyright.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Copyright.Location = New Point(15, 39)
        Copyright.Name = "Copyright"
        Copyright.Size = New Size(216, 40)
        Copyright.TabIndex = 2
        Copyright.Text = "Copyright © 2023"
        ' 
        ' ApplicationTitle
        ' 
        ApplicationTitle.Anchor = AnchorStyles.None
        ApplicationTitle.BackColor = Color.Transparent
        ApplicationTitle.Font = New Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        ApplicationTitle.Location = New Point(258, 11)
        ApplicationTitle.Name = "ApplicationTitle"
        ApplicationTitle.Size = New Size(222, 195)
        ApplicationTitle.TabIndex = 0
        ApplicationTitle.Text = "IMAX Theatre"
        ApplicationTitle.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 3500
        ' 
        ' SplashScreen1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(496, 303)
        ControlBox = False
        Controls.Add(MainLayoutPanel)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "SplashScreen1"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        MainLayoutPanel.ResumeLayout(False)
        DetailsLayoutPanel.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents DetailsLayoutPanel As TableLayoutPanel
    Friend WithEvents Version As Label
    Friend WithEvents Copyright As Label
End Class
