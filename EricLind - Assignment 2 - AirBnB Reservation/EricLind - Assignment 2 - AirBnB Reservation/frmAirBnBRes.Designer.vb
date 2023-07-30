<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAirBnbRes
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmAirBnbRes))
        lblFormTitle = New Label()
        lblFormSubTitle = New Label()
        lblNumNightsDisp = New Label()
        lblCostStayDisp = New Label()
        btnDisp = New Button()
        btnClear = New Button()
        btnExit = New Button()
        PictureBox1 = New PictureBox()
        txtNumNights = New TextBox()
        lblTotCost = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblFormTitle
        ' 
        lblFormTitle.AutoSize = True
        lblFormTitle.Font = New Font("Cooper Black", 24.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblFormTitle.Location = New Point(454, 26)
        lblFormTitle.Name = "lblFormTitle"
        lblFormTitle.Size = New Size(276, 36)
        lblFormTitle.TabIndex = 0
        lblFormTitle.Text = "Orlando AirBnB"
        lblFormTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblFormSubTitle
        ' 
        lblFormSubTitle.AutoSize = True
        lblFormSubTitle.Font = New Font("Cooper Black", 14.25F, FontStyle.Italic, GraphicsUnit.Point)
        lblFormSubTitle.Location = New Point(475, 74)
        lblFormSubTitle.Name = "lblFormSubTitle"
        lblFormSubTitle.Size = New Size(235, 21)
        lblFormSubTitle.TabIndex = 1
        lblFormSubTitle.Text = "Only $XX.XX per night"
        ' 
        ' lblNumNightsDisp
        ' 
        lblNumNightsDisp.AutoSize = True
        lblNumNightsDisp.Font = New Font("Century Gothic", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblNumNightsDisp.Location = New Point(427, 154)
        lblNumNightsDisp.Name = "lblNumNightsDisp"
        lblNumNightsDisp.Size = New Size(149, 21)
        lblNumNightsDisp.TabIndex = 2
        lblNumNightsDisp.Text = "Number of Nights:"
        lblNumNightsDisp.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lblCostStayDisp
        ' 
        lblCostStayDisp.AutoSize = True
        lblCostStayDisp.Font = New Font("Century Gothic", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblCostStayDisp.Location = New Point(469, 213)
        lblCostStayDisp.Name = "lblCostStayDisp"
        lblCostStayDisp.Size = New Size(107, 21)
        lblCostStayDisp.TabIndex = 3
        lblCostStayDisp.Text = "Cost of Stay:"
        lblCostStayDisp.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' btnDisp
        ' 
        btnDisp.Location = New Point(420, 339)
        btnDisp.Name = "btnDisp"
        btnDisp.Size = New Size(105, 35)
        btnDisp.TabIndex = 4
        btnDisp.Text = "Display Cost"
        btnDisp.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(531, 339)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(105, 35)
        btnClear.TabIndex = 5
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(642, 339)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(105, 35)
        btnExit.TabIndex = 6
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(7, 8)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(352, 435)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' txtNumNights
        ' 
        txtNumNights.Font = New Font("Century Gothic", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtNumNights.Location = New Point(659, 156)
        txtNumNights.Name = "txtNumNights"
        txtNumNights.Size = New Size(41, 27)
        txtNumNights.TabIndex = 8
        txtNumNights.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblTotCost
        ' 
        lblTotCost.AutoSize = True
        lblTotCost.Font = New Font("Century Gothic", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        lblTotCost.Location = New Point(623, 213)
        lblTotCost.Name = "lblTotCost"
        lblTotCost.Size = New Size(77, 21)
        lblTotCost.TabIndex = 9
        lblTotCost.Text = "$9999.99"
        lblTotCost.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' frmAirBnbRes
        ' 
        AcceptButton = btnDisp
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gold
        CancelButton = btnClear
        ClientSize = New Size(800, 450)
        Controls.Add(lblTotCost)
        Controls.Add(txtNumNights)
        Controls.Add(PictureBox1)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnDisp)
        Controls.Add(lblCostStayDisp)
        Controls.Add(lblNumNightsDisp)
        Controls.Add(lblFormSubTitle)
        Controls.Add(lblFormTitle)
        Name = "frmAirBnbRes"
        Text = "AirBnB Reservations"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblFormTitle As Label
    Friend WithEvents lblFormSubTitle As Label
    Friend WithEvents lblNumNightsDisp As Label
    Friend WithEvents lblCostStayDisp As Label
    Friend WithEvents btnDisp As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtNumNights As TextBox
    Friend WithEvents lblTotCost As Label
End Class
