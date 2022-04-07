Imports System.Data.Sql
Imports System.Data.SqlClient

Module Module1
    Public conexion As New SqlConnection
    Public comando As New SqlCommand
    Public reader As SqlDataReader


    Function enlace()
        Dim salida As String = "Conectado"
        Try
            conexion.ConnectionString = "Data Source=DESKTOP-0703VUV;Initial Catalog=Aplicacion_productos;Integrated Security=True"
            conexion.Open()
            MsgBox("conectado")

        Catch ex As Exception
            salida = "no se puede conectar" + ex.ToString()

        End Try
        Return salida
    End Function


End Module
