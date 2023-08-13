Imports System.Threading
Public Class SplashScreen1

    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Me.ApplicationTitle.Text = "a"
        Dim mainForm As New frmIMAXCal()
        mainForm.Show()
        Me.Hide()
    End Sub

    Private Sub Version_Click(sender As Object, e As EventArgs) Handles Version.Click

    End Sub
End Class
