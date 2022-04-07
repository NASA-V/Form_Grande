Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Form_5
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim datos As String = "SELECT COUNT(*) FROM USUARIO WHERE USUARIO ='" & txtusuario.Text & "' and CONTRASENA ='" & txtcontrasena.Text & "' "
            comando = New SqlCommand(datos, conexion)
            comando.CommandType = CommandType.Text
            Dim n = comando.ExecuteScalar()
            If (n > 0) Then
                MsgBox("INICIO DE SESION CORRECTO" & n)
                Form_7.Show()
                Me.Hide()

            Else
                MsgBox("USUARIO NO EXISTE" & n)

            End If

        Catch ex As Exception
            MsgBox("ERROR")
        End Try






    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enlace()
        Label3.Text = estado
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form_6.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form_8.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form_7.Show()


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Form_9.Show()
    End Sub
End Class
