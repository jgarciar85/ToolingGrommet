Imports System.Data.OleDb
Public Class Password

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnCambiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambiar.Click
        Dim DownTimeCnnStr As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\APP\TOOLING\Data\PINPACK.mdb;Persist Security Info=False;" 'Jet OLEDB:Database" ' Password=INGENIERIA"        
        Dim conn1 As New System.Data.OleDb.OleDbConnection(DownTimeCnnStr)

        Dim Updquery As String = "UPDATE ADMIN SET [PASSWORD]= '" & TextBox1.Text & "' WHERE ID= '" & PassNumEmp.Text & "'"
        conn1.Open()
        If TextBox1.Text = TextBox2.Text Then

            Dim cmd1 As New System.Data.OleDb.OleDbCommand(Updquery, conn1)
            cmd1.ExecuteNonQuery()
            conn1.Close()
            MsgBox("Se cambio la contraseña con exito.")
            Me.Close()

        Else
            MsgBox("Contraseña no coincide")
        End If

        TextBox1.Text = ""
        TextBox2.Text = ""

    End Sub
End Class