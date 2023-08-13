Option Strict On
Imports System.DirectoryServices.ActiveDirectory

Public Class frmIMAXCal

    Dim _matineePrice As Integer = 16
    Dim _eveningPrice As Integer = 27

    Private Sub frmIMAXCal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmbSeatSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSeatSelect.SelectedIndexChanged

        lblNumTicket.Visible = True
        lblPriceDisplay.Visible = True
        lblPriceDisplay.Text = ""
        txtNumTicket.Visible = True
        btnClear.Visible = True
        btnSubmit.Visible = True
        txtNumTicket.Focus()

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim intNumTickets As Integer
        Dim blnNumTicketsValid As Boolean = False
        Dim intSeatSelect As Integer
        Dim totalCost As Decimal

        blnNumTicketsValid = ValidateNumSeats()

        If (blnNumTicketsValid) Then
            intNumTickets = Convert.ToInt32(txtNumTicket.Text)
            intSeatSelect = cmbSeatSelect.SelectedIndex

            Select Case intSeatSelect
                Case 0
                    totalCost = _matineePrice * intNumTickets
                Case 1
                    totalCost = _eveningPrice * intNumTickets
            End Select

            lblPriceDisplay.Text = totalCost.ToString("C") & " for the tickets"
        End If

    End Sub

    Private Function ValidateNumSeats() As Boolean
        Dim intNumSeats As Integer
        Dim validCheck As Boolean = False
        Dim strMsg As String = "Please enter the number of seats you wish to purchase (Greater than 0)"
        Dim errorMsg As String = "Error"

        Try
            intNumSeats = Convert.ToInt32(txtNumTicket.Text)
            If intNumSeats > 0 Then
                validCheck = True
            Else
                MsgBox(strMsg, , errorMsg)
                txtNumTicket.Clear()
                txtNumTicket.Focus()
            End If

        Catch Exception As FormatException
            MsgBox(strMsg, , errorMsg)
            txtNumTicket.Clear()
            txtNumTicket.Focus()
        Catch Exception As OverflowException
            MsgBox(strMsg, , errorMsg)
            txtNumTicket.Clear()
            txtNumTicket.Focus()
        Catch Exception As SystemException
            MsgBox(strMsg, , errorMsg)
            txtNumTicket.Clear()
            txtNumTicket.Focus()
        End Try

        Return validCheck

    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        cmbSeatSelect.SelectedIndex = -1
        lblNumTicket.Visible = False
        lblPriceDisplay.Visible = False
        lblPriceDisplay.Text = ""
        txtNumTicket.Visible = False
        btnClear.Visible = False
        btnSubmit.Visible = False


    End Sub

    Private Sub lblPriceDisplay_Click(sender As Object, e As EventArgs) Handles lblPriceDisplay.Click

    End Sub
End Class
