<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmIMAXCal
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmIMAXCal))
        picIMAX = New PictureBox()
        lblTitle = New Label()
        lblNumTicket = New Label()
        cmbSeatSelect = New ComboBox()
        txtNumTicket = New TextBox()
        btnSubmit = New Button()
        btnClear = New Button()
        lblPriceDisplay = New Label()
        CType(picIMAX, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picIMAX
        ' 
        picIMAX.Image = CType(resources.GetObject("picIMAX.Image"), Image)
        picIMAX.Location = New Point(-4, -3)
        picIMAX.Name = "picIMAX"
        picIMAX.Size = New Size(405, 458)
        picIMAX.SizeMode = PictureBoxSizeMode.StretchImage
        picIMAX.TabIndex = 0
        picIMAX.TabStop = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.BackColor = Color.DodgerBlue
        lblTitle.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lblTitle.ForeColor = SystemColors.Control
        lblTitle.Location = New Point(472, 39)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(257, 32)
        lblTitle.TabIndex = 1
        lblTitle.Text = "IMAX Theatre Tickets"
        ' 
        ' lblNumTicket
        ' 
        lblNumTicket.AutoSize = True
        lblNumTicket.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblNumTicket.Location = New Point(525, 163)
        lblNumTicket.Name = "lblNumTicket"
        lblNumTicket.Size = New Size(154, 21)
        lblNumTicket.TabIndex = 2
        lblNumTicket.Text = "Number of Tickets:"
        lblNumTicket.Visible = False
        ' 
        ' cmbSeatSelect
        ' 
        cmbSeatSelect.DropDownStyle = ComboBoxStyle.DropDownList
        cmbSeatSelect.FormattingEnabled = True
        cmbSeatSelect.Items.AddRange(New Object() {"Matinee $16", "Evening $27"})
        cmbSeatSelect.Location = New Point(540, 104)
        cmbSeatSelect.Name = "cmbSeatSelect"
        cmbSeatSelect.Size = New Size(121, 23)
        cmbSeatSelect.TabIndex = 3
        ' 
        ' txtNumTicket
        ' 
        txtNumTicket.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        txtNumTicket.Location = New Point(579, 208)
        txtNumTicket.Name = "txtNumTicket"
        txtNumTicket.Size = New Size(43, 33)
        txtNumTicket.TabIndex = 4
        txtNumTicket.Visible = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.DodgerBlue
        btnSubmit.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnSubmit.ForeColor = Color.White
        btnSubmit.Location = New Point(517, 260)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(166, 48)
        btnSubmit.TabIndex = 5
        btnSubmit.Text = "Cost"
        btnSubmit.UseVisualStyleBackColor = False
        btnSubmit.Visible = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.DodgerBlue
        btnClear.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnClear.ForeColor = Color.White
        btnClear.Location = New Point(517, 315)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(166, 48)
        btnClear.TabIndex = 6
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        btnClear.Visible = False
        ' 
        ' lblPriceDisplay
        ' 
        lblPriceDisplay.AutoSize = True
        lblPriceDisplay.BackColor = Color.DodgerBlue
        lblPriceDisplay.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblPriceDisplay.ForeColor = SystemColors.Control
        lblPriceDisplay.Location = New Point(508, 383)
        lblPriceDisplay.Name = "lblPriceDisplay"
        lblPriceDisplay.Size = New Size(182, 21)
        lblPriceDisplay.TabIndex = 7
        lblPriceDisplay.Text = "$XXX.XX for the tickets"
        lblPriceDisplay.TextAlign = ContentAlignment.MiddleCenter
        lblPriceDisplay.Visible = False
        ' 
        ' frmIMAXCal
        ' 
        AcceptButton = btnSubmit
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.None
        CancelButton = btnClear
        ClientSize = New Size(800, 450)
        Controls.Add(lblPriceDisplay)
        Controls.Add(btnClear)
        Controls.Add(btnSubmit)
        Controls.Add(txtNumTicket)
        Controls.Add(cmbSeatSelect)
        Controls.Add(lblNumTicket)
        Controls.Add(lblTitle)
        Controls.Add(picIMAX)
        DoubleBuffered = True
        Name = "frmIMAXCal"
        Text = "Purchase IMAX Theatre Tickets"
        CType(picIMAX, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picIMAX As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblNumTicket As Label
    Friend WithEvents cmbSeatSelect As ComboBox
    Friend WithEvents txtNumTicket As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblPriceDisplay As Label
End Class
