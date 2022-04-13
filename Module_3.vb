Imports System.Data.SqlClient

Module Module_3
    Public conexion As New SqlConnection
    Public comando As New SqlCommand
    Public estado As String

    Sub enlace()
        Try
            conexion.ConnectionString = "Data Source=LAPTOP-MF64POFJ;Initial Catalog=Aplicacion_Productos;Integrated Security=True"
            conexion.Open()
            estado = "Conectado"
        Catch ex As Exception
            estado = "Desconectado"
        End Try
    End Sub
End Module
