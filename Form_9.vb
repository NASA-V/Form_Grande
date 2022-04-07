Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Form_9
    Public horizontal As Integer = 50
    Public vertical As Integer = 50
    Public supern(99) As Label
    Public descrpcion(99) As Label
    Public precio(99) As Label
    Public botonsuma(99) As Button
    Public botonresta(99) As Button
    Public campo(99) As TextBox
    Public total(99) As TextBox
    ' Public disponible(99) As Label
    'Dim TextBoxArray(6) As TextBox


    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try


            Dim a = 0
            For x = 1 To 6

                Dim datos As New SqlDataAdapter("SELECT * FROM Articulos  WHERE _id='" & Form_7.almacena(x) & "'", conexion)
                    Dim ds As New DataSet()
                    datos.Fill(ds, "Articulos")
                    TextBox1.Text = Form_7.almacena(x)
                    supern(x) = New Label
                    supern(x).Text = ds.Tables("Articulos").Rows(a).Item(4)
                    supern(x).TextAlign = ContentAlignment.MiddleCenter
                    supern(x).BorderStyle = BorderStyle.FixedSingle
                    supern(x).Font = New Font("Arial", 10, FontStyle.Bold)
                    supern(x).Location = New Point(horizontal, vertical)
                    Me.Controls.Add(supern(x))
                    vertical = vertical + 30

                    descrpcion(x) = New Label
                    descrpcion(x).Text = ds.Tables("Articulos").Rows(a).Item(0)
                    descrpcion(x).TextAlign = ContentAlignment.MiddleCenter
                    descrpcion(x).BorderStyle = BorderStyle.FixedSingle
                    descrpcion(x).Font = New Font("Arial", 10, FontStyle.Bold)
                    descrpcion(x).Location = New Point(horizontal, vertical)
                    Me.Controls.Add(descrpcion(x))
                    vertical = vertical + 30

                    precio(x) = New Label
                    precio(x).Text = ds.Tables("Articulos").Rows(a).Item(1)
                    precio(x).TextAlign = ContentAlignment.MiddleCenter
                    precio(x).BorderStyle = BorderStyle.FixedSingle
                    precio(x).Font = New Font("Arial", 10, FontStyle.Bold)
                    precio(x).Location = New Point(horizontal, vertical)
                    Me.Controls.Add(precio(x))
                    vertical = vertical + 30

                    botonresta(x) = New Button
                    botonresta(x).Text = "-"
                    botonresta(x).Width = 60
                    botonresta(x).Height = 20
                    botonresta(x).Location = New Point(100, vertical)
                    Me.Controls.Add(botonresta(x))


                campo(x) = New TextBox
                    campo(x).Text = 1
                    campo(x).Location = New Point(180, vertical)

                    Me.Controls.Add(campo(x))

                total(x) = New TextBox
                total(x).Text = campo(x).Text
                total(x).Location = New Point(400, vertical)

                Me.Controls.Add(total(x))

                botonsuma(x) = New Button
                    botonsuma(x).Text = "+"
                    botonsuma(x).Width = 60
                    botonsuma(x).Height = 20
                    botonsuma(x).Location = New Point(300, vertical)
                    Me.Controls.Add(botonsuma(x))
                    vertical = vertical + 100


                Select Case x
                    Case 1
                        AddHandler botonresta(1).Click, AddressOf Me.accion1
                        AddHandler botonsuma(1).Click, AddressOf Me.accion11
                    Case 2
                        AddHandler botonresta(2).Click, AddressOf Me.accion2
                        AddHandler botonsuma(2).Click, AddressOf Me.accion22
                    Case 3
                        AddHandler botonresta(3).Click, AddressOf Me.accion3
                        AddHandler botonsuma(3).Click, AddressOf Me.accion33
                    Case 4
                        AddHandler botonresta(4).Click, AddressOf Me.accion4
                        AddHandler botonsuma(4).Click, AddressOf Me.accion44
                    Case 5
                        AddHandler botonresta(5).Click, AddressOf Me.accion5
                        AddHandler botonsuma(5).Click, AddressOf Me.accion55
                    Case 6
                        AddHandler botonresta(6).Click, AddressOf Me.accion6
                        AddHandler botonsuma(6).Click, AddressOf Me.accion66
                    Case Else

                End Select

            Next

        Catch ex As Exception
            MsgBox("Id no existe")
            ' txt1.Text = "Id ya existe " & ex.Message
        End Try

    End Sub

    Private Sub accion1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If campo(1).Text > 1 Then
            campo(1).Text = campo(1).Text - 1
            total(1).Text = campo(1).Text * precio(1).Text
        End If
    End Sub
    Private Sub accion2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If campo(2).Text > 1 Then
            campo(2).Text = campo(2).Text - 1
            total(2).Text = campo(2).Text * precio(2).Text
        End If
    End Sub
    Private Sub accion3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If campo(3).Text > 1 Then
            campo(3).Text = campo(3).Text - 1
            total(3).Text = campo(3).Text * precio(3).Text
        End If
    End Sub
    Private Sub accion4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If campo(4).Text > 1 Then
            campo(4).Text = campo(4).Text - 1
            total(4).Text = campo(4).Text * precio(4).Text
        End If
    End Sub
    Private Sub accion5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If campo(5).Text > 1 Then
            campo(5).Text = campo(5).Text - 1
            total(5).Text = campo(5).Text * precio(5).Text
        End If
    End Sub
    Private Sub accion6(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If campo(6).Text > 1 Then
            campo(6).Text = campo(6).Text - 1
            total(6).Text = campo(6).Text * precio(6).Text
        End If

    End Sub



    Private Sub accion11(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If campo(1).Text < 20 Then
            campo(1).Text = campo(1).Text + 1
            total(1).Text = campo(1).Text * precio(1).Text
        End If
    End Sub
    Private Sub accion22(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If campo(2).Text < 20 Then
            campo(2).Text = campo(2).Text + 1
            total(2).Text = campo(2).Text * precio(2).Text
        End If
    End Sub
    Private Sub accion33(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If campo(3).Text < 20 Then
            campo(3).Text = campo(3).Text + 1
            total(3).Text = campo(3).Text * precio(3).Text
        End If
    End Sub
    Private Sub accion44(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If campo(4).Text < 20 Then
            campo(4).Text = campo(4).Text + 1
            total(4).Text = campo(4).Text * precio(4).Text
        End If
    End Sub
    Private Sub accion55(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If campo(5).Text < 20 Then
            campo(5).Text = campo(5).Text + 1
            total(5).Text = campo(5).Text * precio(5).Text
        End If
    End Sub
    Private Sub accion66(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If campo(6).Text < 20 Then
            campo(6).Text = campo(6).Text + 1
            total(6).Text = campo(6).Text * precio(6).Text
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class