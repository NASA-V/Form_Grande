Public Class Form_2
    Private ReadOnly txt_contraseña As Object
    Private txt_usuario As Object

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim usuario As String
        Dim contraseña As Integer
        usuario = txt_usuario.text
        contraseña = txt_contraseña.text

        If (usuario = "reichel") And (contraseña = "1234") Then
        End If

        MsgBox("Usuario o contraseña incorrecta")

    End Sub
End Class
