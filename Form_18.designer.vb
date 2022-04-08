<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_18
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtContraN = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtConfirmCon = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtContraActual = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(477, 390)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(154, 48)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Guardar cambios"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button1.Location = New System.Drawing.Point(169, 390)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 48)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtContraN
        '
        Me.TxtContraN.Location = New System.Drawing.Point(12, 194)
        Me.TxtContraN.Multiline = True
        Me.TxtContraN.Name = "TxtContraN"
        Me.TxtContraN.Size = New System.Drawing.Size(769, 40)
        Me.TxtContraN.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 248)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(769, 51)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Confirmar la nueva contraseña"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label2.UseWaitCursor = True
        '
        'TxtConfirmCon
        '
        Me.TxtConfirmCon.Location = New System.Drawing.Point(12, 314)
        Me.TxtConfirmCon.Multiline = True
        Me.TxtConfirmCon.Name = "TxtConfirmCon"
        Me.TxtConfirmCon.Size = New System.Drawing.Size(769, 40)
        Me.TxtConfirmCon.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(769, 51)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Contraseña nueva"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.UseWaitCursor = True
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(769, 51)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Contraseña Vieja"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label3.UseWaitCursor = True
        '
        'TxtContraActual
        '
        Me.TxtContraActual.Location = New System.Drawing.Point(12, 74)
        Me.TxtContraActual.Multiline = True
        Me.TxtContraActual.Name = "TxtContraActual"
        Me.TxtContraActual.Size = New System.Drawing.Size(769, 40)
        Me.TxtContraActual.TabIndex = 18
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TxtContraActual)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtContraN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtConfirmCon)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtContraN As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtConfirmCon As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtContraActual As TextBox
End Class
