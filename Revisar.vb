Public Class Revisar
    Dim db As New DBConnection()
    Dim StrBuscarTool As String
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub EdtEstatus_KeyDown(sender As Object, e As KeyEventArgs) Handles EdtEstatus.KeyDown
        If e.KeyCode = Keys.Enter Then
            If EdtEstatus.Text <> "" Then
                BuscarTooling()
            End If
        End If
    End Sub

    Public Sub BuscarTooling()
        Dim bFound As Boolean = False
        'Verifica que haya informacion ingresada
        If EdtEstatus.Text = "" Then
            Return
        End If
        'Primero busca en tabla de TecProd
        StrBuscarTool = "select STATUS from Tooling.TOOLLINES where TOOLINGID = '" & EdtEstatus.Text & "'"
        Try
            db.SelectQueryReader(StrBuscarTool)
            db.dReader.Read()
            If db.dReader.HasRows Then
                Dim status As String = db.dReader.GetString(0)
                If status = "U" Then
                    lblEstado.Text = "Tooling " + EdtEstatus.Text + " en uso"
                    EdtEstatus.Text = ""
                End If
                If status = "R" Then
                    lblEstado.Text = "Tooling " + EdtEstatus.Text + " por reparar"
                    EdtEstatus.Text = ""
                End If
                If status = "G" Then
                    lblEstado.Text = "Tooling " + EdtEstatus.Text + " bueno"
                    EdtEstatus.Text = ""
                End If
                If status = "D" Then
                    lblEstado.Text = "Tooling" + EdtEstatus.Text + "esta desabilitado"
                    EdtEstatus.Text = ""
                End If
                bFound = True
            Else
                MessageBox.Show("El Tooling " + EdtEstatus.Text + " capturado No existe")
                EdtEstatus.Text = ""
            End If
        Catch
            MessageBox.Show("Error al consultar informacion en la base de datos.", " EdtEstatus", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            db.CloseConnection()

        End Try

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Close()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If EdtEstatus.Text <> "" Then
            BuscarTooling()
        End If
    End Sub


End Class