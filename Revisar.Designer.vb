<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Revisar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Revisar))
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblToolrev = New System.Windows.Forms.Label()
        Me.EdtEstatus = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblEstado
        '
        Me.lblEstado.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.Location = New System.Drawing.Point(29, 329)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(685, 56)
        Me.lblEstado.TabIndex = 18
        Me.lblEstado.Text = "Estado"
        Me.lblEstado.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblToolrev
        '
        Me.lblToolrev.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToolrev.Location = New System.Drawing.Point(154, 173)
        Me.lblToolrev.Name = "lblToolrev"
        Me.lblToolrev.Size = New System.Drawing.Size(432, 51)
        Me.lblToolrev.TabIndex = 19
        Me.lblToolrev.Text = "TOOLING A REVISAR: "
        '
        'EdtEstatus
        '
        Me.EdtEstatus.AcceptsReturn = True
        Me.EdtEstatus.AcceptsTab = True
        Me.EdtEstatus.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EdtEstatus.Location = New System.Drawing.Point(162, 242)
        Me.EdtEstatus.Name = "EdtEstatus"
        Me.EdtEstatus.Size = New System.Drawing.Size(405, 50)
        Me.EdtEstatus.TabIndex = 16
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.Font = New System.Drawing.Font("Trebuchet MS", 69.75!, System.Drawing.FontStyle.Bold)
        Me.Label18.Image = CType(resources.GetObject("Label18.Image"), System.Drawing.Image)
        Me.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label18.Location = New System.Drawing.Point(3, 4)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(198, 86)
        Me.Label18.TabIndex = 20
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Navy
        Me.Label19.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label19.Location = New System.Drawing.Point(59, 76)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(611, 86)
        Me.Label19.TabIndex = 21
        Me.Label19.Text = "REVISION DE TOOLING"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnBack
        '
        Me.BtnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBack.Location = New System.Drawing.Point(544, 665)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(170, 64)
        Me.BtnBack.TabIndex = 22
        Me.BtnBack.Text = "CERRAR"
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(244, 388)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(224, 64)
        Me.btnBuscar.TabIndex = 22
        Me.btnBuscar.Text = "BUSCAR"
        '
        'Revisar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 741)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.lblToolrev)
        Me.Controls.Add(Me.EdtEstatus)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Revisar"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Keyboard"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEstado As Label
    Friend WithEvents lblToolrev As Label
    Friend WithEvents EdtEstatus As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents BtnBack As Button
    Friend WithEvents btnBuscar As Button
End Class
