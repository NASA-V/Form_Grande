Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Facturacion
    Public descripcion(99) As Label
    Public subtotall(99) As Label
    Public impuestol(99) As Label
    Public totall(99) As Label
    Public subtotaln(99) As TextBox
    Public impueston(99) As TextBox
    Public totaln(99) As TextBox


    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Vertical = 20
        Try



            Dim a = 0

            For x = 1 To 20

                If menub.almacena(x) > 0 Then
                    Dim datos As New SqlDataAdapter("SELECT * FROM Articulos  WHERE _id='" & carritomenu.alamcenaid(x) & "'", conexion)
                    Dim ds As New DataSet()
                    datos.Fill(ds, "Articulos")

                    descripcion(x) = New Label
                    descripcion(x).Text = ds.Tables("Articulos").Rows(a).Item(1)
                    descripcion(x).Size = New Size(100, 20)
                    descripcion(x).Location = New Point(100, vertical)
                    Me.Controls.Add(descripcion(x))
                    Vertical = Vertical + 20
                End If
            Next
            Dim n = 1
            Dim suma = 0
            Dim alm = 0
            For n = 1 To carritomenu.n

                suma = carritomenu.total(n).Text
                alm = alm + suma
                suma = 0


            Next
            subtotall(n) = New Label
            subtotall(n).Text = "subtotal"
            subtotall(n).Location = New Point(5, Vertical)
            Me.Controls.Add(subtotall(n))

            subtotaln(n) = New TextBox
            subtotaln(n).Text = alm
            subtotaln(n).Location = New Point(110, Vertical)
            Me.Controls.Add(subtotaln(n))


            Vertical = Vertical + 20
            impuestol(n) = New Label
            impuestol(n).Text = "Impuesto"
            impuestol(n).Location = New Point(5, Vertical)
            Me.Controls.Add(impuestol(n))

            impueston(n) = New TextBox
            impueston(n).Text = alm * 0.13
            impueston(n).Location = New Point(110, Vertical)
            Me.Controls.Add(impueston(n))

            Vertical = Vertical + 20
            totall(n) = New Label
            totall(n).Text = "Total"
            totall(n).Location = New Point(5, Vertical)
            Me.Controls.Add(totall(n))

            totaln(n) = New TextBox
            totaln(n).Text = alm + (alm * 0.13)
            totaln(n).Location = New Point(110, Vertical)
            Me.Controls.Add(totaln(n))






        Catch ex As Exception

        End Try
        ' que llame la descripcion del producto
        '  Dim suma = 0
        '  Dim alm = 0
        ' For x = 1 To carritomenu.n

        '  suma = carritomenu.total(x).Text
        '  alm = alm + suma
        '     suma = 0
        '    subtotal.Text = alm

        '   Next
        '   TOTAL.Text = subtotal.Text + (subtotal.Text * 0.13)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub subtotal_TextChanged(sender As Object, e As EventArgs)

    End Sub

End Class