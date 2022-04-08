Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Exchange.WebServices.Data

Public Class Form_17

    Public Sub Actualizar()

        Dim actualiza As String = "update  Perfil  Set  Nombre='" & TxtNombre.Text & "', Apellidos='" & TxtApellidos.Text & "', Telefono= '" & TxtTelefono.Text & "', Usuario = '" & TxtUsuario.Text & "', [Correo Electronico]= '" & TxtCorreo.Text & "' Where Nombre = '" & TxtNombreActual.Text & "'"
        comando = New SqlCommand(actualiza, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        MsgBox("Listo")

    End Sub


    Public Sub agregar()

        Dim adaptador As New SqlCommand("insert into Perfil values(" & TxtNombre.Text & ",'" & TxtApellidos.Text & "','" & TxtTelefono.Text & "','" & TxtUsuario.Text & "','" & TxtCorreo.Text & "')", conexion)
        adaptador.ExecuteNonQuery()
        MsgBox("Registro exitoso")


    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Actualizar()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enlace()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        agregar()
    End Sub
End Class