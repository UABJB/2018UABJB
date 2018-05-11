<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lbNombres = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lbApellidos = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbNombres
        '
        Me.lbNombres.AutoSize = True
        Me.lbNombres.Location = New System.Drawing.Point(72, 40)
        Me.lbNombres.Name = "lbNombres"
        Me.lbNombres.Size = New System.Drawing.Size(49, 13)
        Me.lbNombres.TabIndex = 0
        Me.lbNombres.Text = "Nombres"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(166, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(121, 93)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegistrar.TabIndex = 2
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(166, 58)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 4
        '
        'lbApellidos
        '
        Me.lbApellidos.AutoSize = True
        Me.lbApellidos.Location = New System.Drawing.Point(72, 66)
        Me.lbApellidos.Name = "lbApellidos"
        Me.lbApellidos.Size = New System.Drawing.Size(49, 13)
        Me.lbApellidos.TabIndex = 3
        Me.lbApellidos.Text = "Apellidos"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(307, 129)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(22, 23)
        Me.btnCerrar.TabIndex = 5
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 164)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.lbApellidos)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lbNombres)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbNombres As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lbApellidos As Label
    Friend WithEvents btnCerrar As Button
End Class
