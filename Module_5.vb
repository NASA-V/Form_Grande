Imports System.Data.Sql
Imports System.Data.SqlClient

Module Module_5
    Public conexion As New SqlConnection
    Public comando As New SqlCommand
    Public estado As String

    Sub enlace()
        Try
            conexion.ConnectionString = "Data Source=DESKTOP-29HN5BE;Initial Catalog=COMPARADOR;Integrated Security=True"
            conexion.Open()
            estado = "Conectado"
        Catch ex As Exception
            estado = "Desconectado"
        End Try
    End Sub

End Module