'Eric Lind

Option Strict On
Public Class frmAirBnbRes

    Const _airBnbPricePerDay As Double = 79.00

    Private Sub btnDisp_Click(sender As Object, e As EventArgs) Handles btnDisp.Click
        Dim strNumNights As String
        Dim intNumNights As Integer
        Dim decTotalCost As Double

        strNumNights = txtNumNights.Text
        intNumNights = Convert.ToInt32(strNumNights)
        decTotalCost = intNumNights * _airBnbPricePerDay
        lblTotCost.Text = decTotalCost.ToString("C")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNumNights.Clear()
        lblTotCost.Text = ""
        txtNumNights.Focus()

    End Sub

    Private Sub frmAirBnbRes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFormSubTitle.Text = "Only " & _airBnbPricePerDay & " per night"
        lblTotCost.Text = ""
        txtNumNights.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

End Class
