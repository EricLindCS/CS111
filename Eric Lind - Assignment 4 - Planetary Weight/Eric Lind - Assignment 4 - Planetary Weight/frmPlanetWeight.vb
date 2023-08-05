Public Class frmPlanetWeight
    Private Sub frmPlanetWeight_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim convFactorMars As Decimal = 0.377
        Dim convFactorVenus As Decimal = 0.907
        Dim enteredWeight As Decimal
        Dim convFactorUsed As Decimal
        Dim finalLbs As Decimal
        Dim finalKg As Decimal
        Dim planetUsed As String

        If IsNumeric(txtWeightBox.Text) Then
            enteredWeight = Convert.ToDecimal(txtWeightBox.Text)

            If (enteredWeight > 0) Then
                If (radioMars.Checked) Then
                    convFactorUsed = convFactorMars
                    planetUsed = "Mars"
                End If
                If (radioVenus.Checked) Then
                    convFactorUsed = convFactorVenus
                    planetUsed = "Venus"
                End If

                finalKg = convFactorUsed * enteredWeight
                finalLbs = convFactorUsed * finalKg * 0.454

                lblDisplayWeight.Text = "Your weight on " & planetUsed & " is " & finalLbs.ToString() & " lbs or " & finalKg.ToString() & " kg."
            Else
                MsgBox("Your entered " & enteredWeight.ToString() & ". Please enter a positive value.")
                txtWeightBox.Text = ""
                lblDisplayWeight.Text = ""
                txtWeightBox.Focus()

            End If
        Else
            MsgBox("Enter the weight you weigh on earth in pounds", , "Input error")
            txtWeightBox.Text = ""
            lblDisplayWeight.Text = ""
            txtWeightBox.Focus()

        End If


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtWeightBox.Text = ""
        lblDisplayWeight.Text = ""
        txtWeightBox.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
