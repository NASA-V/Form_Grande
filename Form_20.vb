Imports System.Data
Imports System.Data.SqlClient

Public Class Form5

    Public Sub registro()

        Try

            Dim consulta As String = "INSERT INTO Usuario VALUES(@Usuario, @Contraseña)"
            comando = New SqlClient.SqlCommand(consulta, conexion)
            comando.Parameters.AddWithValue("@Usuario", TxtUsuario.Text.ToUpper)
            comando.Parameters.AddWithValue("@Contraseña", TxtContraseña.Text.ToUpper)
            comando.ExecuteNonQuery()
            MsgBox("Registro exitoso")

        Catch ex As Exception

            MsgBox("No se pudo registrar")
            ' txt1.Text = "ID ya existe" & ex.Message



        End Try
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        registro()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enlace()
    End Sub
End Class