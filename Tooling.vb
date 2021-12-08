Imports System.Globalization
Public Class Tooling

    Private Sub btnAlta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlta.Click
        Dim DownTimeCnnStr As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\APP\TOOLING\Data\PINPACK.mdb;Persist Security Info=False;" 'Jet OLEDB:Database" ' Password=INGENIERIA"        
        Dim conn1 As New System.Data.OleDb.OleDbConnection(DownTimeCnnStr)


        Dim ci As New CultureInfo("en-us")
        Dim FECHA, HORA As String
        FECHA = Now.ToString("M/dd/yyyy", ci)
        HORA = Now.ToString("H:mm:ss", ci)

        Dim access As String = "INSERT INTO TOOLLINES (FECHA,HORA,[TIPO DE TOOLING],TOOLINGID,DESCRIPCION,STATUS,ADMIN) VALUES ('" & FECHA & "','" & HORA & "','" & txtTipoT.Text & "','" & txtID.Text & "','" & cmbDesc.Text & "','" & "G" & "','" & lblADMIN.Text & "' )"


        conn1.Open()
        If txtID.Text <> "" And txtTipoT.Text <> "" And cmbDesc.Text <> "" Then
            Try


                Dim cmd1 As New System.Data.OleDb.OleDbCommand(access, conn1)
                cmd1.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Error al intentar agregar el Tooling. Vuelve a Intentarlo")
            End Try
        Else
            MessageBox.Show("Captura todos los campos")
        End If

        txtID.Text = ""
        txtTipoT.Text = ""
        cmbDesc.Text = ""


        conn1.Close()


    End Sub
End Class