<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tooling
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtTipoT = New System.Windows.Forms.TextBox
        Me.cmbDesc = New System.Windows.Forms.ComboBox
        Me.txtID = New System.Windows.Forms.TextBox
        Me.btnAlta = New System.Windows.Forms.Button
        Me.lblADMIN = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo de Tooling"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(232, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Alta de nuevos Tooling"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tooling ID"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Descripcion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 4
        '
        'txtTipoT
        '
        Me.txtTipoT.Location = New System.Drawing.Point(99, 74)
        Me.txtTipoT.Name = "txtTipoT"
        Me.txtTipoT.Size = New System.Drawing.Size(133, 20)
        Me.txtTipoT.TabIndex = 5
        '
        'cmbDesc
        '
        Me.cmbDesc.FormattingEnabled = True
        Me.cmbDesc.Items.AddRange(New Object() {"PIN PACK", "GRATE PLATE"})
        Me.cmbDesc.Location = New System.Drawing.Point(99, 164)
        Me.cmbDesc.Name = "cmbDesc"
        Me.cmbDesc.Size = New System.Drawing.Size(133, 21)
        Me.cmbDesc.TabIndex = 7
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(99, 123)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(133, 20)
        Me.txtID.TabIndex = 8
        '
        'btnAlta
        '
        Me.btnAlta.Location = New System.Drawing.Point(111, 215)
        Me.btnAlta.Name = "btnAlta"
        Me.btnAlta.Size = New System.Drawing.Size(75, 23)
        Me.btnAlta.TabIndex = 9
        Me.btnAlta.Text = "Aceptar"
        Me.btnAlta.UseVisualStyleBackColor = True
        '
        'lblADMIN
        '
        Me.lblADMIN.AutoSize = True
        Me.lblADMIN.Location = New System.Drawing.Point(228, 280)
        Me.lblADMIN.Name = "lblADMIN"
        Me.lblADMIN.Size = New System.Drawing.Size(0, 13)
        Me.lblADMIN.TabIndex = 10
        '
        'Tooling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 302)
        Me.Controls.Add(Me.lblADMIN)
        Me.Controls.Add(Me.btnAlta)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.cmbDesc)
        Me.Controls.Add(Me.txtTipoT)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Tooling"
        Me.Text = "Alta de Tooling"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTipoT As System.Windows.Forms.TextBox
    Friend WithEvents cmbDesc As System.Windows.Forms.ComboBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents btnAlta As System.Windows.Forms.Button
    Friend WithEvents lblADMIN As System.Windows.Forms.Label
End Class
