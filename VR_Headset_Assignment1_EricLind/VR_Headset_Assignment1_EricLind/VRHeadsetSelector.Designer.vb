<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VRHeadsetSelector
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
        btnCrown = New Button()
        btnEarbud = New Button()
        btnExit = New Button()
        picCrown = New PictureBox()
        picEarbud = New PictureBox()
        Label1 = New Label()
        CType(picCrown, ComponentModel.ISupportInitialize).BeginInit()
        CType(picEarbud, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnCrown
        ' 
        btnCrown.Location = New Point(155, 338)
        btnCrown.Name = "btnCrown"
        btnCrown.Size = New Size(90, 30)
        btnCrown.TabIndex = 0
        btnCrown.Text = "VR Crown"
        btnCrown.UseVisualStyleBackColor = True
        ' 
        ' btnEarbud
        ' 
        btnEarbud.Location = New Point(555, 338)
        btnEarbud.Name = "btnEarbud"
        btnEarbud.Size = New Size(90, 30)
        btnEarbud.TabIndex = 1
        btnEarbud.Text = "VR Earbud"
        btnEarbud.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(355, 381)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(90, 30)
        btnExit.TabIndex = 2
        btnExit.Text = "Exit Window"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' picCrown
        ' 
        picCrown.Location = New Point(75, 80)
        picCrown.Name = "picCrown"
        picCrown.Size = New Size(250, 250)
        picCrown.TabIndex = 3
        picCrown.TabStop = False
        ' 
        ' picEarbud
        ' 
        picEarbud.Location = New Point(475, 80)
        picEarbud.Name = "picEarbud"
        picEarbud.Size = New Size(250, 250)
        picEarbud.TabIndex = 4
        picEarbud.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(298, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(205, 39)
        Label1.TabIndex = 5
        Label1.Text = "VR Forward"
        ' 
        ' VRHeadsetSelector
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(picEarbud)
        Controls.Add(picCrown)
        Controls.Add(btnExit)
        Controls.Add(btnEarbud)
        Controls.Add(btnCrown)
        Name = "VRHeadsetSelector"
        Text = "Virtal Reality Headsets"
        CType(picCrown, ComponentModel.ISupportInitialize).EndInit()
        CType(picEarbud, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCrown As Button
    Friend WithEvents btnEarbud As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents picCrown As PictureBox
    Friend WithEvents picEarbud As PictureBox
    Friend WithEvents Label1 As Label
End Class
