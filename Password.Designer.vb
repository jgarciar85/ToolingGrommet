<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Password
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.PassNumEmp = New System.Windows.Forms.TextBox
        Me.PassNueva = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.btnCambiar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        '
        'PassNumEmp
        '
        Me.PassNumEmp.Location = New System.Drawing.Point(138, 52)
        Me.PassNumEmp.Name = "PassNumEmp"
        Me.PassNumEmp.ReadOnly = True
        Me.PassNumEmp.Size = New System.Drawing.Size(131, 20)
        Me.PassNumEmp.TabIndex = 1
        '
        'PassNueva
        '
        Me.PassNueva.AutoSize = True
        Me.PassNueva.Location = New System.Drawing.Point(33, 88)
        Me.PassNueva.Name = "PassNueva"
        Me.PassNueva.Size = New System.Drawing.Size(99, 13)
        Me.PassNueva.TabIndex = 2
        Me.PassNueva.Text = "Nueva Contraseña:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Re-escribe la Contraseña:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(138, 116)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(131, 20)
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(138, 85)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(131, 20)
        Me.TextBox2.TabIndex = 2
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(6, 172)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(98, 33)
        Me.btnCerrar.TabIndex = 5
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnCambiar
        '
        Me.btnCambiar.Location = New System.Drawing.Point(171, 172)
        Me.btnCambiar.Name = "btnCambiar"
        Me.btnCambiar.Size = New System.Drawing.Size(98, 33)
        Me.btnCambiar.TabIndex = 4
        Me.btnCambiar.Text = "Cambiar"
        Me.btnCambiar.UseVisualStyleBackColor = True
        '
        'Password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnCambiar)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PassNueva)
        Me.Controls.Add(Me.PassNumEmp)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Password"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambiar Contrasena"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PassNumEmp As System.Windows.Forms.TextBox
    Friend WithEvents PassNueva As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnCambiar As System.Windows.Forms.Button
End Class
