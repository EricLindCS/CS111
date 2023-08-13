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
        lblTitle.Location = New Point(541, 60)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(41, 15)
        lblTitle.TabIndex = 1
        lblTitle.Text = "Label1"
        ' 
        ' lblNumTicket
        ' 
        lblNumTicket.AutoSize = True
        lblNumTicket.Location = New Point(529, 132)
        lblNumTicket.Name = "lblNumTicket"
        lblNumTicket.Size = New Size(41, 15)
        lblNumTicket.TabIndex = 2
        lblNumTicket.Text = "Label2"
        ' 
        ' cmbSeatSelect
        ' 
        cmbSeatSelect.FormattingEnabled = True
        cmbSeatSelect.Location = New Point(522, 100)
        cmbSeatSelect.Name = "cmbSeatSelect"
        cmbSeatSelect.Size = New Size(121, 23)
        cmbSeatSelect.TabIndex = 3
        ' 
        ' txtNumTicket
        ' 
        txtNumTicket.Location = New Point(543, 202)
        txtNumTicket.Name = "txtNumTicket"
        txtNumTicket.Size = New Size(100, 23)
        txtNumTicket.TabIndex = 4
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(541, 267)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(75, 23)
        btnSubmit.TabIndex = 5
        btnSubmit.Text = "Button1"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(544, 316)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 23)
        btnClear.TabIndex = 6
        btnClear.Text = "Button2"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' lblPriceDisplay
        ' 
        lblPriceDisplay.AutoSize = True
        lblPriceDisplay.Location = New Point(530, 375)
        lblPriceDisplay.Name = "lblPriceDisplay"
        lblPriceDisplay.Size = New Size(41, 15)
        lblPriceDisplay.TabIndex = 7
        lblPriceDisplay.Text = "Label3"
        ' 
        ' frmIMAXCal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.None
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
        Text = "Purchase IMAX Theater Tickets"
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
