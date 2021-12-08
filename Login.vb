Public Class Login
    Dim db As New DBConnection()
    Dim query As String

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If txtLogin.Text = "" Or txtPass.Text = "" Then
            MessageBox.Show("Escribe tu numero de empleado y contrasena.")
        Else
            Try
                query = "SELECT * FROM Tooling.ADMIN WHERE IDLOGIN='" & txtLogin.Text & "' AND PASSWORD='" & txtPass.Text & "'"
                db.SelectQueryReader(query)
                Dim Privilegios, NumEmp, NomEmp As String
                If db.dReader.Read() Then
                    Privilegios = db.dReader(6)
                    NumEmp = db.dReader(0)
                    NomEmp = db.dReader(2)
                    Ajustes.txtPrivilegios.Text = Privilegios
                    Ajustes.txtNumEm.Text = NumEmp
                    Ajustes.txtNom.Text = NomEmp
                    Ajustes.Show()

                Else
                    MessageBox.Show("Numero de empleado o contrasena equivocados.")
                    txtLogin.Text = ""
                    txtPass.Text = ""
                    txtLogin.Focus()
                End If

            Catch ex As Exception
                MessageBox.Show("Error al conectarse a la Base de Datos de Administradores. Vuelve a Intentarlo")

            End Try
            db.CloseConnection()

            Me.Close()

        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        If txtLogin.Text = "" Or txtPass.Text = "" Then
            MessageBox.Show("Escribe tu numero de empleado y contrasena actual.")
        Else
            Dim conn As New System.Data.OleDb.OleDbConnection()
            conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\APP\TOOLING\Data\PINPACK.mdb;Persist Security Info=False;"

            Try
                Dim query As String = "SELECT * FROM ADMIN WHERE ADMIN.ID='" & txtLogin.Text & "' AND ADMIN.PASSWORD='" & txtPass.Text & "'"
                Dim querycom As New System.Data.OleDb.OleDbCommand(query)

                querycom.Connection = conn
                conn.Open()



                Dim queryRead As System.Data.OleDb.OleDbDataReader = querycom.ExecuteReader()

                If queryRead.Read() Then
                    Password.PassNumEmp.Text = txtLogin.Text
                    Password.Show()

                Else
                    MessageBox.Show("Numero de empleado o contrasena equivocados.")
                    txtLogin.Text = ""
                    txtPass.Text = ""
                    txtLogin.Focus()

                End If


            Catch ex As Exception
                MessageBox.Show("Error al conectarse a la Base de Datos de Administradores. Vuelve a Intentarlo")

            End Try
            conn.Close()
            Me.Close()
        End If



    End Sub

    Private Sub TxtLogin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLogin.KeyPress
        e.Handled = True
        If e.KeyChar = Chr(&H8) Or
           IsNumeric(e.KeyChar) Then
            e.Handled = False
        Else
        End If
    End Sub

    Private Sub TxtLogin_TextChanged(sender As Object, e As EventArgs) Handles txtLogin.TextChanged
        If Len(txtLogin.Text) = 10 Then
            txtLogin.Text = Mid(txtLogin.Text, 2, 8)
            txtLogin.Enabled = False
            txtPass.Focus()
        End If
    End Sub

    Private Sub TxtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged
        If Len(txtPass.Text) = 10 Then
            txtPass.Text = Mid(txtPass.Text, 2, 8)
            txtPass.Enabled = False
            Call OK_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub TxtLogin_KeyDown(sender As Object, e As KeyEventArgs) Handles txtLogin.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtLogin.Text <> "" Then
                txtLogin.Enabled = False
                txtPass.Focus()
            End If
        End If
    End Sub

    Private Sub TxtPass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtPass.Text <> "" Then
                txtPass.Enabled = False
                Call OK_Click(Nothing, Nothing)
            End If
        End If
    End Sub

    Private Sub TxtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress
        e.Handled = True
        If e.KeyChar = Chr(&H8) Or
           IsNumeric(e.KeyChar) Then
            e.Handled = False
        Else
        End If
    End Sub
End Class
