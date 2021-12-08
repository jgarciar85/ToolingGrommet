Public Class Reparar
    Dim db As New DBConnection()
    Dim StrBuscarTool As String


    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Close()

    End Sub

    Private Sub TxtLabDob_MouseClick(sender As Object, e As MouseEventArgs) Handles txtLabDob.MouseClick
        'Labios Doblados
        Keyboard.lblFlag.Text = "txtLabDob"
        Keyboard.Show()
    End Sub

    Private Sub TxtPinesDob_MouseClick(sender As Object, e As MouseEventArgs) Handles txtPinesDob.MouseClick
        'Pines doblados
        Keyboard.lblFlag.Text = "txtPinesDob"
        Keyboard.Show()
    End Sub

    Private Sub TxtPinesQueb_MouseClick(sender As Object, e As MouseEventArgs) Handles txtPinesQueb.MouseClick
        'Pines quebrados
        Keyboard.lblFlag.Text = "txtPinesQueb"
        Keyboard.Show()
    End Sub

    Public Sub UpdateGrdTool()
        'Actualiza el Grid de la pestana

        Dim ToolQry As String = "Select TIPOTOOLING, TOOLINGID, DESCRIPCION, STATUS, VIDA FROM Tooling.TOOLLINES WHERE STATUS ='R'"
        Dim TablaToolQry As New DataTable
        Dim tabla As New DataTable
        Try
            db.SelectQueryDataSet(ToolQry)
            tabla = db.dDataSet.Tables(0)
            TablaToolQry.Columns.Add("Tipo de Tooling", Type.GetType("System.String"))
            TablaToolQry.Columns.Add("ToolingID", Type.GetType("System.String"))
            TablaToolQry.Columns.Add("Descpripcion", Type.GetType("System.String"))
            TablaToolQry.Columns.Add("Status", Type.GetType("System.String"))
            TablaToolQry.Columns.Add("Vida", Type.GetType("System.String"))
        Catch ex As Exception

        Finally
            db.CloseConnection()
        End Try
        Dim columnas As DataColumnCollection = TablaToolQry.Columns

        Dim RowTemp As DataRow
        Dim LastNonEmpty As Integer = 0
        For i As Integer = 0 To tabla.Rows.Count - 1
            RowTemp = TablaToolQry.NewRow
            RowTemp(columnas(0)) = tabla.Rows(i)(0).ToString()
            RowTemp(columnas(1)) = tabla.Rows(i)(1).ToString()
            RowTemp(columnas(2)) = tabla.Rows(i)(2).ToString()
            RowTemp(columnas(3)) = tabla.Rows(i)(3).ToString()
            RowTemp(columnas(4)) = tabla.Rows(i)(4).ToString()
            TablaToolQry.Rows.Add(RowTemp)
        Next i
        tabla.Clear()
        GrdTool.DataSource = TablaToolQry.DefaultView
        GrdTool.Columns(0).Width = 280
        GrdTool.Columns(1).Width = 230
        GrdTool.Columns(2).Width = 300
        GrdTool.Columns(3).Width = 200
        GrdTool.Columns(4).Width = 200


        'Actualiza el Grid de la pestana

    End Sub

    Private Sub Reparar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateGrdTool()
        TimerRepair.Enabled = True
    End Sub

    Private Sub EdtEmpRep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles edtEmpRep.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub EdLabQueb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPinesDob.KeyPress
        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub EdLabDob_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPinesQueb.KeyPress
        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub EdtToolRep_KeyPress(sender As Object, e As KeyEventArgs) Handles EdtToolRep.KeyDown
        'If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
        '    e.KeyChar = ""
        'End If
        If e.KeyCode = Keys.Enter Then
            If EdtToolRep.Text <> "" Then
                BuscarTooling()
            End If
        End If
    End Sub

    Private Sub EdtEmpRep_TextChanged(sender As Object, e As EventArgs) Handles edtEmpRep.TextChanged
        If Len(edtEmpRep.Text) = 10 Then
            edtEmpRep.Text = Mid(edtEmpRep.Text, 2, 8)
            edtEmpRep.Enabled = False
        End If
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        If edtEmpRep.Text = "" Or EdtToolRep.Text = "" Or txtPinesQueb.Text = "" Or txtPinesDob.Text = "" Then
            MsgBox("Por favor, complete la informacion.", MsgBoxStyle.OkOnly, "Error")
            Return
        End If

        Try
            Dim access1 As String = "UPDATE Tooling.TOOLLINES SET STATUS = 'G' where TOOLINGID='" & EdtToolRep.Text & "'"
            db.ModifyQuery(access1)
            db.CloseConnection()

            Dim access2 As String = "UPDATE Tooling.INFOLINES SET QTYLABIOSDOBLADOS = '" & txtLabDob.Text & "', QTYPINESDOBLADOS='" & txtPinesDob.Text & "', QTYPINESQUEBRADOS='" & txtPinesQueb.Text & "',ESTADO='G', REPARO='" & edtEmpRep.Text & "', FECHAREP='" & DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") & "' where TOOLINGID='" & EdtToolRep.Text & "' and REPARO IS NULL"
            db.ModifyQuery(access2)
            db.CloseConnection()


            edtEmpRep.Text = ""
            EdtToolRep.Text = ""
            txtPinesQueb.Text = ""
            txtPinesDob.Text = ""
            txtLabDob.Text = ""
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error al consultar la base de datos. Verifique la conexión.", "Error en Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GrdTool_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrdTool.CellContentClick
        EdtToolRep.Text = GrdTool.CurrentRow.Cells(1).Value.ToString
    End Sub

    Private Sub TxtLabDob_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLabDob.KeyPress
        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Public Sub BuscarTooling()
        Dim bFound As Boolean = False
        'Verifica que haya informacion ingresada

        'Primero busca en tabla de TecProd
        StrBuscarTool = "select STATUS from Tooling.TOOLLINES where TOOLINGID = '" & EdtToolRep.Text & "'"
        Try
            db.SelectQueryReader(StrBuscarTool)
            db.dReader.Read()
            If db.dReader.HasRows Then
                Dim status As String = db.dReader.GetString(0)
                If status = "U" Then
                    MessageBox.Show("Tooling " + EdtToolRep.Text + " en uso")
                    EdtToolRep.Text = ""
                End If
                If status = "R" Then
                    EdtToolRep.Enabled = False
                    Return
                End If
                If status = "G" Then
                    MessageBox.Show("Tooling " + EdtToolRep.Text + " bueno")
                    EdtToolRep.Text = ""
                End If
                bFound = True
            Else
                MessageBox.Show("El Tooling " + EdtToolRep.Text + " capturado No existe")
                EdtToolRep.Text = ""
            End If
        Catch
            MessageBox.Show("Error al consultar informacion en la base de datos.", " EdtEstatus", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            db.CloseConnection()

        End Try

    End Sub

    Private Sub TimerMain_Tick(sender As Object, e As EventArgs) Handles TimerRepair.Tick
        UpdateGrdTool()

    End Sub
End Class