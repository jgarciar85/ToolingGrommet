<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reparar
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reparar))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.edtEmpRep = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPinesQueb = New System.Windows.Forms.TextBox()
        Me.txtPinesDob = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.EdtToolRep = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GrdTool = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLabDob = New System.Windows.Forms.TextBox()
        Me.TimerRepair = New System.Windows.Forms.Timer(Me.components)
        CType(Me.GrdTool, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'edtEmpRep
        '
        Me.edtEmpRep.AcceptsReturn = True
        Me.edtEmpRep.AcceptsTab = True
        Me.edtEmpRep.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edtEmpRep.Location = New System.Drawing.Point(277, 111)
        Me.edtEmpRep.Name = "edtEmpRep"
        Me.edtEmpRep.Size = New System.Drawing.Size(270, 40)
        Me.edtEmpRep.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(327, 43)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "NUM. EMPLEADO: "
        '
        'txtPinesQueb
        '
        Me.txtPinesQueb.AcceptsReturn = True
        Me.txtPinesQueb.AcceptsTab = True
        Me.txtPinesQueb.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPinesQueb.Location = New System.Drawing.Point(1078, 227)
        Me.txtPinesQueb.Name = "txtPinesQueb"
        Me.txtPinesQueb.Size = New System.Drawing.Size(175, 40)
        Me.txtPinesQueb.TabIndex = 4
        '
        'txtPinesDob
        '
        Me.txtPinesDob.AcceptsReturn = True
        Me.txtPinesDob.AcceptsTab = True
        Me.txtPinesDob.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPinesDob.Location = New System.Drawing.Point(1078, 171)
        Me.txtPinesDob.Name = "txtPinesDob"
        Me.txtPinesDob.Size = New System.Drawing.Size(175, 40)
        Me.txtPinesDob.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(608, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(464, 43)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "CANTIDAD PINES QUEBRADOS"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(608, 174)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(464, 40)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "CANTIDAD PINES DOBLADOS"
        '
        'BtnBack
        '
        Me.BtnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBack.Location = New System.Drawing.Point(837, 679)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(224, 64)
        Me.BtnBack.TabIndex = 19
        Me.BtnBack.Text = "CERRAR"
        '
        'BtnOK
        '
        Me.BtnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOK.Location = New System.Drawing.Point(174, 679)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(256, 64)
        Me.BtnOK.TabIndex = 17
        Me.BtnOK.Text = "ACEPTAR"
        '
        'EdtToolRep
        '
        Me.EdtToolRep.AcceptsReturn = True
        Me.EdtToolRep.AcceptsTab = True
        Me.EdtToolRep.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EdtToolRep.Location = New System.Drawing.Point(277, 174)
        Me.EdtToolRep.Name = "EdtToolRep"
        Me.EdtToolRep.Size = New System.Drawing.Size(270, 40)
        Me.EdtToolRep.TabIndex = 2
        '
        'Label39
        '
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(125, 180)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(215, 40)
        Me.Label39.TabIndex = 20
        Me.Label39.Text = "TOOLING: "
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Trebuchet MS", 69.75!, System.Drawing.FontStyle.Bold)
        Me.Label18.Image = CType(resources.GetObject("Label18.Image"), System.Drawing.Image)
        Me.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label18.Location = New System.Drawing.Point(31, 9)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(198, 86)
        Me.Label18.TabIndex = 21
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Bold)
        Me.Label19.ForeColor = System.Drawing.Color.Navy
        Me.Label19.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label19.Location = New System.Drawing.Point(248, 9)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(938, 71)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "REPARACION DE TOOLING"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GrdTool
        '
        Me.GrdTool.AllowUserToAddRows = False
        Me.GrdTool.AllowUserToDeleteRows = False
        Me.GrdTool.AllowUserToResizeColumns = False
        Me.GrdTool.AllowUserToResizeRows = False
        Me.GrdTool.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrdTool.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GrdTool.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GrdTool.DefaultCellStyle = DataGridViewCellStyle2
        Me.GrdTool.Location = New System.Drawing.Point(12, 304)
        Me.GrdTool.MultiSelect = False
        Me.GrdTool.Name = "GrdTool"
        Me.GrdTool.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrdTool.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.GrdTool.RowHeadersVisible = False
        Me.GrdTool.RowHeadersWidth = 10
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrdTool.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.GrdTool.RowTemplate.Height = 40
        Me.GrdTool.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrdTool.Size = New System.Drawing.Size(1241, 369)
        Me.GrdTool.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(608, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(477, 40)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "CANTIDAD LABIOS DOBLADOS"
        '
        'txtLabDob
        '
        Me.txtLabDob.AcceptsReturn = True
        Me.txtLabDob.AcceptsTab = True
        Me.txtLabDob.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLabDob.Location = New System.Drawing.Point(1078, 108)
        Me.txtLabDob.Name = "txtLabDob"
        Me.txtLabDob.Size = New System.Drawing.Size(175, 40)
        Me.txtLabDob.TabIndex = 25
        '
        'TimerRepair
        '
        Me.TimerRepair.Interval = 40000
        '
        'Reparar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1324, 741)
        Me.Controls.Add(Me.txtLabDob)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GrdTool)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.edtEmpRep)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPinesQueb)
        Me.Controls.Add(Me.txtPinesDob)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.EdtToolRep)
        Me.Controls.Add(Me.Label39)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Reparar"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Keyboard"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GrdTool, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents edtEmpRep As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPinesQueb As TextBox
    Friend WithEvents txtPinesDob As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnOK As Button
    Friend WithEvents EdtToolRep As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Private WithEvents GrdTool As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLabDob As TextBox
    Friend WithEvents TimerRepair As Timer
End Class
