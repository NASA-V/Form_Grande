Imports System.Data
Imports System.Data.SqlClient
Public Class Form_16
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enlace()

    End Sub

    Private formularioactual As Form = Nothing
    Private Sub abrirformhijo(formulariohijo As Form)
        If formularioactual IsNot Nothing Then formularioactual.Close()
        formularioactual = formulariohijo
        formulariohijo.TopLevel = False
        formulariohijo.FormBorderStyle = FormBorderStyle.None
        formulariohijo.Dock = DockStyle.Fill
        Panelformulariohijo.Controls.Add(formulariohijo)
        Panelformulariohijo.Tag = formulariohijo
        formulariohijo.BringToFront()
        formulariohijo.Show()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        abrirformhijo(New Form_17())
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        abrirformhijo(New Form_18())
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form_19.Show()

    End Sub

    Private Sub Panelformulariohijo_Paint(sender As Object, e As PaintEventArgs) Handles Panelformulariohijo.Paint

    End Sub
End Class
