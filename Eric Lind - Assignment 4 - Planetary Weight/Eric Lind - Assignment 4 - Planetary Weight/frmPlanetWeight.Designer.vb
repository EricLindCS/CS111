<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPlanetWeight
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmPlanetWeight))
        picGalaxy = New PictureBox()
        boxSelectPlanet = New GroupBox()
        radioMars = New RadioButton()
        radioVenus = New RadioButton()
        lblTitle = New Label()
        lblEnter = New Label()
        txtWeightBox = New TextBox()
        btnCalculate = New Button()
        btnClear = New Button()
        lblDisplayWeight = New Label()
        btnExit = New Button()
        CType(picGalaxy, ComponentModel.ISupportInitialize).BeginInit()
        boxSelectPlanet.SuspendLayout()
        SuspendLayout()
        ' 
        ' picGalaxy
        ' 
        picGalaxy.Image = CType(resources.GetObject("picGalaxy.Image"), Image)
        picGalaxy.Location = New Point(-2, -5)
        picGalaxy.Name = "picGalaxy"
        picGalaxy.Size = New Size(269, 366)
        picGalaxy.SizeMode = PictureBoxSizeMode.StretchImage
        picGalaxy.TabIndex = 0
        picGalaxy.TabStop = False
        ' 
        ' boxSelectPlanet
        ' 
        boxSelectPlanet.BackColor = Color.FloralWhite
        boxSelectPlanet.Controls.Add(radioMars)
        boxSelectPlanet.Controls.Add(radioVenus)
        boxSelectPlanet.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        boxSelectPlanet.Location = New Point(435, 147)
        boxSelectPlanet.Name = "boxSelectPlanet"
        boxSelectPlanet.Size = New Size(200, 100)
        boxSelectPlanet.TabIndex = 1
        boxSelectPlanet.TabStop = False
        boxSelectPlanet.Text = "Convert Weight"
        ' 
        ' radioMars
        ' 
        radioMars.AutoSize = True
        radioMars.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        radioMars.Location = New Point(28, 64)
        radioMars.Name = "radioMars"
        radioMars.Size = New Size(131, 24)
        radioMars.TabIndex = 1
        radioMars.TabStop = True
        radioMars.Text = "Weight on Mars"
        radioMars.UseVisualStyleBackColor = True
        ' 
        ' radioVenus
        ' 
        radioVenus.AutoSize = True
        radioVenus.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        radioVenus.Location = New Point(28, 28)
        radioVenus.Name = "radioVenus"
        radioVenus.Size = New Size(137, 24)
        radioVenus.TabIndex = 0
        radioVenus.TabStop = True
        radioVenus.Text = "Weight on Venus"
        radioVenus.UseVisualStyleBackColor = True
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("SWRomnt", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblTitle.Location = New Point(388, 28)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(294, 35)
        lblTitle.TabIndex = 2
        lblTitle.Text = "Venus or Mars?"
        ' 
        ' lblEnter
        ' 
        lblEnter.AutoSize = True
        lblEnter.Font = New Font("SWComp", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        lblEnter.Location = New Point(357, 92)
        lblEnter.Name = "lblEnter"
        lblEnter.Size = New Size(237, 25)
        lblEnter.TabIndex = 3
        lblEnter.Text = "Enter Weight (lbs):"
        ' 
        ' txtWeightBox
        ' 
        txtWeightBox.Font = New Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtWeightBox.Location = New Point(609, 92)
        txtWeightBox.Name = "txtWeightBox"
        txtWeightBox.Size = New Size(63, 26)
        txtWeightBox.TabIndex = 4
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(388, 310)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(85, 30)
        btnCalculate.TabIndex = 5
        btnCalculate.Text = "Display"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(492, 310)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(85, 30)
        btnClear.TabIndex = 6
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' lblDisplayWeight
        ' 
        lblDisplayWeight.AutoSize = True
        lblDisplayWeight.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblDisplayWeight.Location = New Point(329, 268)
        lblDisplayWeight.Name = "lblDisplayWeight"
        lblDisplayWeight.Size = New Size(407, 25)
        lblDisplayWeight.TabIndex = 7
        lblDisplayWeight.Text = "Your weight on XXXXX is XXXX lbs or XXXX kg"
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(596, 310)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(85, 30)
        btnExit.TabIndex = 9
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' frmPlanetWeight
        ' 
        AcceptButton = btnCalculate
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gold
        CancelButton = btnClear
        ClientSize = New Size(800, 361)
        Controls.Add(btnExit)
        Controls.Add(lblDisplayWeight)
        Controls.Add(btnClear)
        Controls.Add(btnCalculate)
        Controls.Add(txtWeightBox)
        Controls.Add(lblEnter)
        Controls.Add(lblTitle)
        Controls.Add(boxSelectPlanet)
        Controls.Add(picGalaxy)
        Name = "frmPlanetWeight"
        Text = "Planetary Weight Calculator"
        CType(picGalaxy, ComponentModel.ISupportInitialize).EndInit()
        boxSelectPlanet.ResumeLayout(False)
        boxSelectPlanet.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents boxSelectPlanet As GroupBox
    Friend WithEvents radioMars As RadioButton
    Friend WithEvents radioVenus As RadioButton
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblEnter As Label
    Friend WithEvents txtWeightBox As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Public WithEvents picGalaxy As PictureBox
    Public WithEvents lblDisplayWeight As Label
End Class
