<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistorialTooling
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
        Me.lbltoolingHist = New System.Windows.Forms.Label
        Me.GridHistTool = New System.Windows.Forms.DataGridView
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.btnHistorial = New System.Windows.Forms.Button
        Me.lblToolH = New System.Windows.Forms.Label
        CType(Me.GridHistTool, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbltoolingHist
        '
        Me.lbltoolingHist.AutoSize = True
        Me.lbltoolingHist.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltoolingHist.Location = New System.Drawing.Point(122, 39)
        Me.lbltoolingHist.Name = "lbltoolingHist"
        Me.lbltoolingHist.Size = New System.Drawing.Size(54, 16)
        Me.lbltoolingHist.TabIndex = 0
        Me.lbltoolingHist.Text = "Tooling"
        '
        'GridHistTool
        '
        Me.GridHistTool.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.GridHistTool.AllowUserToAddRows = False
        Me.GridHistTool.AllowUserToDeleteRows = False
        Me.GridHistTool.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridHistTool.Location = New System.Drawing.Point(20, 102)
        Me.GridHistTool.Name = "GridHistTool"
        Me.GridHistTool.ReadOnly = True
        Me.GridHistTool.Size = New System.Drawing.Size(1076, 176)
        Me.GridHistTool.TabIndex = 1
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(488, 303)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(142, 33)
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnHistorial
        '
        Me.btnHistorial.Location = New System.Drawing.Point(488, 63)
        Me.btnHistorial.Name = "btnHistorial"
        Me.btnHistorial.Size = New System.Drawing.Size(142, 33)
        Me.btnHistorial.TabIndex = 3
        Me.btnHistorial.Text = "Ver Historial"
        Me.btnHistorial.UseVisualStyleBackColor = True
        '
        'lblToolH
        '
        Me.lblToolH.AutoSize = True
        Me.lblToolH.Location = New System.Drawing.Point(764, 27)
        Me.lblToolH.Name = "lblToolH"
        Me.lblToolH.Size = New System.Drawing.Size(0, 13)
        Me.lblToolH.TabIndex = 4
        Me.lblToolH.Visible = False
        '
        'HistorialTooling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1118, 355)
        Me.Controls.Add(Me.lblToolH)
        Me.Controls.Add(Me.btnHistorial)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.GridHistTool)
        Me.Controls.Add(Me.lbltoolingHist)
        Me.Name = "HistorialTooling"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historial de Tooling"
        CType(Me.GridHistTool, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbltoolingHist As System.Windows.Forms.Label
    Friend WithEvents GridHistTool As System.Windows.Forms.DataGridView
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnHistorial As System.Windows.Forms.Button
    Friend WithEvents lblToolH As System.Windows.Forms.Label
End Class
