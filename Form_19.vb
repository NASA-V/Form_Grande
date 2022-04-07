Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Form4

    Private Sub login(Usuario As String, Contraseña As String)

        Dim consulta As String = "select * from Usuario Where Usuario=@Usuario and Contraseña=@Contraseña"
        Dim basedatos As SqlDataAdapter
        Dim tabla As New DataTable
        comando = New SqlClient.SqlCommand(consulta, conexion)
        comando.Parameters.AddWithValue("@Usuario", Usuario)
        comando.Parameters.AddWithValue("@Contraseña", Contraseña)
        basedatos = New SqlDataAdapter(comando)
        tabla = New DataTable()
        basedatos.Fill(tabla)

        If tabla.Rows.Count = 1 Then
            Me.Hide()
            Form1.Show()
        Else
            MsgBox("El usuario y/o la contraseña no existe")


        End If



    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form5.Show()

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enlace()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        login(TextBoxUsuario.Text, TextBoxContraseña.Text)
    End Sub


End Class