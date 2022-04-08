<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_17
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TxtApellidos = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtNombreActual = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtUsuario.Location = New System.Drawing.Point(0, 391)
        Me.TxtUsuario.Multiline = True
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(781, 40)
        Me.TxtUsuario.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(0, 348)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(781, 43)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Nombre de usuario"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtTelefono.Location = New System.Drawing.Point(0, 308)
        Me.TxtTelefono.Multiline = True
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(781, 40)
        Me.TxtTelefono.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 265)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(781, 43)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Telefono"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtCorreo.Location = New System.Drawing.Point(0, 225)
        Me.TxtCorreo.Multiline = True
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(781, 40)
        Me.TxtCorreo.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(781, 43)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Correo electronico"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(369, 448)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(154, 48)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Actualizar datos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TxtApellidos
        '
        Me.TxtApellidos.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtApellidos.Location = New System.Drawing.Point(0, 142)
        Me.TxtApellidos.Multiline = True
        Me.TxtApellidos.Name = "TxtApellidos"
        Me.TxtApellidos.Size = New System.Drawing.Size(781, 40)
        Me.TxtApellidos.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(781, 51)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Apellidos"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2.UseWaitCursor = True
        '
        'TxtNombre
        '
        Me.TxtNombre.Dock = System.Windows.Forms.DockStyle.Top
        Me.TxtNombre.Location = New System.Drawing.Point(0, 51)
        Me.TxtNombre.Multiline = True
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(781, 40)
        Me.TxtNombre.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(781, 51)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Nombre "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.UseWaitCursor = True
        '
        'Button1
        '
        Me.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button1.Location = New System.Drawing.Point(7, 448)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 48)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtNombreActual
        '
        Me.TxtNombreActual.Location = New System.Drawing.Point(188, 469)
        Me.TxtNombreActual.Multiline = True
        Me.TxtNombreActual.Name = "TxtNombreActual"
        Me.TxtNombreActual.Size = New System.Drawing.Size(107, 27)
        Me.TxtNombreActual.TabIndex = 24
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(579, 446)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(145, 53)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "Agregar datos"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(150, 446)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(192, 20)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Introdusca Nombre actual"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 513)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TxtNombreActual)
        Me.Controls.Add(Me.TxtUsuario)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtTelefono)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtCorreo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TxtApellidos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtTelefono As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TxtApellidos As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtNombreActual As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label6 As Label
End Class
