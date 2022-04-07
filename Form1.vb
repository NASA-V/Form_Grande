Imports System.Data.SqlClient

Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enlace()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Dim fechav As String = Me.fecha.Text
            Dim num As Integer = Integer.Parse(numTa.Text)
            Dim cvv As String = Me.cvv.Text
            Dim nom As String = Me.nombre.Text
            Dim query As String = "insert into Metodo_de_Pago([Numero de Tarjeta],[Nombre], [Fecha de Vencimiento], [CVV]) values(@num, @nombre, @fechav, @cvv)"
            comando = New SqlCommand(query, conexion)
            comando.Parameters.AddWithValue("@num", num)
            comando.Parameters.AddWithValue("@nombre", nom)
            comando.Parameters.AddWithValue("@fechav", fechav)
            comando.Parameters.AddWithValue("@cvv", cvv)
            Dim n As Integer = comando.ExecuteNonQuery()
            If (n > 0) Then
                MsgBox("Agregado Correctamente")
                ''Form3.Show()
                Me.Hide()

            Else
                MsgBox("Error al agregar metodo de pago" & n)

            End If

        Catch ex As Exception
            MsgBox("ERROR")
        End Try
    End Sub
End Class
