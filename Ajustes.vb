
Imports System.Globalization
Imports System.Data.OleDb
Imports System.IO
Imports CDO.CdoConfiguration
Imports CDO
Public Class Ajustes
    Dim db As New DBConnection()
    Dim StrPermisos, StrRecibeEmail As String
    Dim FILE_NAME_Logger As String = "C:\APP\TOOLING\Logger.txt"
    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        If txtNombre.Text = "" Or txtNumero.Text = "" Or txtApellido.Text = "" Then
            MsgBox("Es necesario que llenes toda la informacion")
            Return
        End If
        Try
            Dim access As String = "INSERT INTO Tooling.ADMIN (IDLOGIN, PASSWORD, NOMBRE, APELLIDO, EMAIL, RECIBEEMAIL, MENU)  VALUES ('" & txtNumero.Text & "','" & txtNumero.Text & "', '" & txtNombre.Text & "','" & txtApellido.Text & "','" & txtEmail.Text & "','" & StrRecibeEmail & "','" & StrPermisos & "' )"
            db.ModifyQuery(access)
            MsgBox("Se realizaron los cambios, Si es un nuevo usuario la contrasena temporal es su numero de empleado.")
            '  GenTecnicosFile() 'Generara el archivo on los tecnicos
        Catch ex As Exception
            MessageBox.Show("Error al conectarse a la Base de Datos de Tecnicos. Vuelve a Intentarlo")
        Finally
            db.CloseConnection()
            Me.Close()
        End Try
        Me.Close()
    End Sub

    Private Sub btnLineDis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLineDis.Click
        Dim Encontrado0, Encontrado1, Encontrado15 As String
        Dim Encontrado16 As Double

        If MsgBox(txtNumEm.Text + " " + txtNom.Text + " estas deshabilitando la linea: " & txtLineDis.Text & " , se enviara un correo informando a los supervisores que has deshabilitado esta linea. Estas seguro de continuar", MsgBoxStyle.YesNoCancel, "Deshabilitar Lineas") = MsgBoxResult.Yes Then

            Try
                Dim query As String = "Select * FROM Tooling.INFOLINES WHERE INFOLINES.LINEA='" + txtLineDis.Text + "' ORDER BY FECHA DESC, HORA DESC"
                db.SelectQueryReader(query)
                db.dReader.Read()
                If db.dReader.HasRows Then
                    'identifica el reporte mas reciente para esa linea
                    Encontrado0 = db.dReader.GetDateTime(0).ToString("yyyy-MM-dd HH:mm:ss") 'trae la fecha
                    Encontrado1 = db.dReader.GetDateTime(1).ToString("yyyy-MM-dd HH:mm:ss") 'trae la hora
                    Encontrado16 = db.dReader.GetValue(17) 'trae la vida
                    Encontrado15 = db.dReader.GetString(16) 'trae el status
                    Dim queryupd As String = "UPDATE Tooling.INFOLINES SET ESTADO = '" & "D" & "',QUITO = '" & txtNom.Text & "', DURATOTAL = '" & "0" & "', EFICIENCIA = '" & "0" & "' WHERE FECHA = '" & Encontrado0 & "' AND HORA = '" & Encontrado1 & "'"
                    db.ModifyQuery(queryupd)
                    Dim queryupd2 As String = "UPDATE  Tooling.RUNNING SET ESTADO='" & "D" & "', TOOLINGID='" & "NTOOL-01" & "'  WHERE RUNNING.LINEA='" + txtLineDis.Text + "'"
                    db.ModifyQuery(queryupd2)
                    Form1.ReadTableStatus()
                Else
                    MessageBox.Show("No pudimos obtener DATOS.", "Error en Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Error al consultar la base de datos. Verifique la conexión.", "Error en Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                db.CloseConnection()
            End Try
            'Obtiene el turno correspondiente
        End If
    End Sub

    Private Sub btnEnvReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnvReport.Click
        If MsgBox(txtNumEm.Text + " " + txtNom.Text + " se enviara un correo con el Reporte de las ultimas 12 Horas, deseas continuar ?", MsgBoxStyle.YesNoCancel, "Deshabilitar Lineas") = MsgBoxResult.Yes Then
            Form1.Mailer()
        End If
    End Sub



    Private Sub Ajustes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim colRemovedTabas As New Collection()
        Dim TabPage1 As TabPage
        Form1.ReadTableStatus()

        TabPage1 = tabAjustes.TabPages(1)
        colRemovedTabas.Add(tabAjustes, TabPage1.Name)

        If txtPrivilegios.Text.Contains("ABCD") Then

        Else
            tabAjustes.Controls.Remove(tabDeshabilitar)
            tabAjustes.Controls.Remove(tabTecnicos)
            tabAjustes.Controls.Remove(tabTooling)
            tabAjustes.Controls.Remove(tabReporte)
        End If


    End Sub

    Private Sub L01A_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L01A.Click
        txtLineDis.Text = "01A"
    End Sub

    Private Sub L01V_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L01V.Click
        txtLineDis.Text = "01V"
    End Sub

    Private Sub L01E_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L01E.Click
        txtLineDis.Text = "01E"
    End Sub

    Private Sub L02A_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L02A.Click
        txtLineDis.Text = "02A"
    End Sub

    Private Sub L02V_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L02V.Click
        txtLineDis.Text = "02V"
    End Sub

    Private Sub L02E_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L02E.Click
        txtLineDis.Text = "02E"
    End Sub

    Private Sub L03A_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L03A.Click
        txtLineDis.Text = "03A"
    End Sub

    Private Sub L03V_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L03V.Click
        txtLineDis.Text = "03V"
    End Sub

    Private Sub L03E_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L03E.Click
        txtLineDis.Text = "03E"
    End Sub

    Private Sub L04A_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L04A.Click
        txtLineDis.Text = "04A"
    End Sub

    Private Sub L04V_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L04V.Click
        txtLineDis.Text = "04V"
    End Sub

    Private Sub L04E_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L04E.Click
        txtLineDis.Text = "04E"
    End Sub

    Private Sub L05A_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L05A.Click
        txtLineDis.Text = "05A"
    End Sub

    Private Sub L05V_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L05V.Click
        txtLineDis.Text = "05V"
    End Sub

    Private Sub L05E_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L05E.Click
        txtLineDis.Text = "05E"
    End Sub

    Private Sub L06A_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L06A.Click
        txtLineDis.Text = "06A"
    End Sub

    Private Sub L06V_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L06V.Click
        txtLineDis.Text = "06V"
    End Sub

    Private Sub L06E_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L06E.Click
        txtLineDis.Text = "06E"
    End Sub

    Private Sub L07A_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L07A.Click
        txtLineDis.Text = "07A"
    End Sub

    Private Sub L07V_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L07V.Click
        txtLineDis.Text = "07V"
    End Sub

    Private Sub L07E_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L07E.Click
        txtLineDis.Text = "07E"
    End Sub

    Private Sub L08A_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L08A.Click
        txtLineDis.Text = "08A"
    End Sub

    Private Sub L08V_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L08V.Click
        txtLineDis.Text = "08V"
    End Sub

    Private Sub L08E_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L08E.Click
        txtLineDis.Text = "08E"
    End Sub

    Private Sub L09A_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L09A.Click
        txtLineDis.Text = "09A"
    End Sub

    Private Sub L09V_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L09V.Click
        txtLineDis.Text = "09V"
    End Sub

    Private Sub L09E_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L09E.Click
        txtLineDis.Text = "09E"
    End Sub

    Private Sub L10A_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L10A.Click, L11A.Click, L13A.Click
        txtLineDis.Text = "10A"
    End Sub

    Private Sub L10V_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L10V.Click, L11V.Click, L13V.Click
        txtLineDis.Text = "10V"
    End Sub

    Private Sub L10E_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L10E.Click, L11E.Click, L13E.Click
        txtLineDis.Text = "10E"
    End Sub
    Private Sub L11A_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L11A.Click
        txtLineDis.Text = "11A"
    End Sub

    Private Sub L11V_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L11V.Click
        txtLineDis.Text = "11V"
    End Sub

    Private Sub L11E_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles L11E.Click
        txtLineDis.Text = "11E"
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub rbEmailNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbEmailNo.CheckedChanged
        StrRecibeEmail = "0"
        txtEmail.Text = "n"
        lblEmail.Visible = False
        txtEmail.Visible = False

    End Sub

    Private Sub rbEmailSi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbEmailSi.CheckedChanged
        StrRecibeEmail = "1"
        lblEmail.Visible = True
        txtEmail.Visible = True
        txtEmail.Focus()
    End Sub

    Private Sub rbTecnico_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTecnico.CheckedChanged
        StrPermisos = "C"
    End Sub

    Private Sub rbAdministrador_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAdministrador.CheckedChanged
        StrPermisos = "ABCD"
    End Sub

    Private Sub TxtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero.KeyPress
        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub BntLineaPM_Click(sender As Object, e As EventArgs) Handles bntLineaPM.Click
        Dim Encontrado0, Encontrado1, Encontrado15 As String
        Dim Encontrado16 As Double

        If MsgBox(txtNumEm.Text + " " + txtNom.Text + " estas activando en PM la linea: " & txtLineDis.Text & " , se enviara un correo informando a los supervisores que has puesto en PM esta linea. Estas seguro de continuar", MsgBoxStyle.YesNoCancel, "Deshabilitar Lineas") = MsgBoxResult.Yes Then

            Try
                Dim query As String = "Select * FROM Tooling.INFOLINES WHERE INFOLINES.LINEA='" + txtLineDis.Text + "' ORDER BY FECHA DESC, HORA DESC"
                db.SelectQueryReader(query)
                db.dReader.Read()
                If db.dReader.HasRows Then
                    'identifica el reporte mas reciente para esa linea
                    Encontrado0 = db.dReader.GetDateTime(0).ToString("yyyy-MM-dd HH:mm:ss") 'trae la fecha
                    Encontrado1 = db.dReader.GetDateTime(1).ToString("yyyy-MM-dd HH:mm:ss") 'trae la hora
                    Encontrado16 = db.dReader.GetValue(17) 'trae la vida
                    Encontrado15 = db.dReader.GetString(16) 'trae el status
                    Dim queryupd As String = "UPDATE Tooling.INFOLINES SET ESTADO = '" & "P" & "',QUITO = '" & txtNom.Text & "', DURATOTAL = '" & "0" & "', EFICIENCIA = '" & "0" & "' WHERE FECHA = '" & Encontrado0 & "' AND HORA = '" & Encontrado1 & "'"
                    db.ModifyQuery(queryupd)
                    Dim queryupd2 As String = "UPDATE  Tooling.RUNNING SET ESTADO='" & "P" & "', TOOLINGID='" & "NTOOL-01" & "'  WHERE RUNNING.LINEA='" + txtLineDis.Text + "'"
                    db.ModifyQuery(queryupd2)
                    Form1.ReadTableStatus()
                Else
                    MessageBox.Show("No pudimos obtener DATOS.", "Error en Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Error al consultar la base de datos. Verifique la conexión.", "Error en Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                db.CloseConnection()
            End Try
            'Obtiene el turno correspondiente
        End If
    End Sub

    Private Sub BtnHabilita_Click(sender As Object, e As EventArgs) Handles btnHabilita.Click
        Dim Encontrado0, Encontrado1, Encontrado15 As String
        Dim Encontrado16 As Double

        If MsgBox(txtNumEm.Text + " " + txtNom.Text + " estas deshabilitando la linea: " & txtLineDis.Text & " , se enviara un correo informando a los supervisores que has deshabilitado esta linea. Estas seguro de continuar", MsgBoxStyle.YesNoCancel, "Deshabilitar Lineas") = MsgBoxResult.Yes Then

            Try
                Dim query As String = "Select * FROM Tooling.INFOLINES WHERE INFOLINES.LINEA='" + txtLineDis.Text + "' ORDER BY FECHA DESC, HORA DESC"
                db.SelectQueryReader(query)
                db.dReader.Read()
                If db.dReader.HasRows Then
                    'identifica el reporte mas reciente para esa linea
                    Encontrado0 = db.dReader.GetDateTime(0).ToString("yyyy-MM-dd HH:mm:ss") 'trae la fecha
                    Encontrado1 = db.dReader.GetDateTime(1).ToString("yyyy-MM-dd HH:mm:ss") 'trae la hora
                    Encontrado16 = db.dReader.GetValue(17) 'trae la vida
                    Encontrado15 = db.dReader.GetString(16) 'trae el status
                    Dim queryupd As String = "UPDATE Tooling.INFOLINES SET ESTADO = '" & "G" & "',QUITO = '" & txtNom.Text & "', DURATOTAL = '" & "0" & "', EFICIENCIA = '" & "0" & "' WHERE FECHA = '" & Encontrado0 & "' AND HORA = '" & Encontrado1 & "'"
                    db.ModifyQuery(queryupd)
                    Dim queryupd2 As String = "UPDATE  Tooling.RUNNING SET ESTADO='" & "G" & "'  WHERE RUNNING.LINEA='" + txtLineDis.Text + "'"
                    db.ModifyQuery(queryupd2)
                    Form1.ReadTableStatus()
                Else
                    MessageBox.Show("No pudimos obtener DATOS.", "Error en Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Error al consultar la base de datos. Verifique la conexión.", "Error en Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                db.CloseConnection()
            End Try
            'Obtiene el turno correspondiente
        End If
    End Sub

    Private Sub BtnAlta_Click(sender As Object, e As EventArgs) Handles btnAlta.Click
        If txtTipoT.Text = "" Or txtID.Text = "" Or cmbDesc.Text = "" Or txtVida.Text = "" Then
            MsgBox("Debe capturar toda la informacion solicitada")
            Return
        End If

        Try
            Dim access As String = "INSERT INTO Tooling.TOOLLINES (TIPOTOOLING, TOOLINGID, DESCRIPCION, STATUS, VIDA) VALUES ('" & txtTipoT.Text & "','" & txtID.Text & "', '" & cmbDesc.Text & "','G','" & txtVida.Text & "')"
            db.ModifyQuery(access)

            MsgBox("Se realizaron los cambios.")
            '  GenTecnicosFile() 'Generara el archivo on los tecnicos
            Me.Close()
        Catch ex As Exception
            MsgBox("Error al conectarse a la Base de Datos de ToolingID. Vuelve a Intentarlo", MsgBoxStyle.OkOnly, "Error")
            Return
        Finally
            db.CloseConnection()

        End Try


    End Sub

End Class


