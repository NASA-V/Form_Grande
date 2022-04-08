Imports System.Data.SqlClient

Module Module2
    Public conexion As New SqlConnection
    Public comando As New SqlCommand
    Public estado As String

    Sub enlace()
        Try
            conexion.ConnectionString = "Data Source=DMC;Initial Catalog=Aplicacion_Productos;Integrated Security=True"
            'string de conexion de reichel "Data Source=DESKTOP-1NNH67H;Initial Catalog=Aplicacion_Productos;Integrated Security=True"
            'string de conexion de diego Data Source=DMC;Initial Catalog=Aplicacion_Productos;Integrated Security=True
            conexion.Open()
            estado = "Conectado"
        Catch ex As Exception
            estado = "Desconectado"
        End Try
    End Sub
End Module
