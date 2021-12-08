Option Strict Off
Option Explicit On
Imports System.Globalization
Imports System.Data.OleDb
Imports System.IO
Imports Microsoft.VisualBasic.Devices
Imports System.Collections
Imports System.Web
Imports System.Net.Mail
Imports CDO.CdoConfiguration
Imports CDO
Imports MySql.Data
Imports MySql.Data.MySqlClient
Imports MySql.Data.Types
Imports System.Data.SqlClient
Public Class Form2

    Dim db As New DBConnection()


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ID As String = lblID.Text
        Dim Information As String = "select * from Tooling.CREATESET where  idCREATESET='" & ID & "'"
        Dim rbRetAnt, rbRev, rbGolpes, rbArmaSet, rbTalquear, rbPrensar, rbSopletear, rbPintar, rbCurar, rbDesarmado, rbAltaDB, rbRevTec, rbEntrega, rbEnvio As Boolean
        'Hace consulta
        Try
            db.SelectQueryReader(Information)
            db.dReader.Read()

            'txtFechaRevGauge.Text = db.dReader.GetDateTime(1).ToString
            If Not IsDBNull(db.dReader.GetValue(2)) Then txtTooling.Text = db.dReader.GetString(2).ToString
            If Not IsDBNull(db.dReader.GetValue(3)) Then txtColor.Text = db.dReader.GetString(3).ToString
            If Not IsDBNull(db.dReader.GetValue(4)) Then txtDiametro.Text = db.dReader.GetString(4).ToString
            If Not IsDBNull(db.dReader.GetValue(6)) Then txtIdAnterior.Text = db.dReader.GetString(6).ToString
            If Not IsDBNull(db.dReader.GetValue(7)) Then txtCantPlat.Text = db.dReader.GetValue(7).ToString

            Dim TipeN = db.dReader.GetString(8).ToString
            If TipeN = "Nuevo" Then
                rbNuevo.Checked = True
            End If
            If TipeN = "Reaccondicionado" Then
                rbReac.Checked = True
            End If
            If TipeN = "NA" Then
                rbNA.Checked = True
            End If
            ' STATUS  txtFechaRevGauge.Text = db.dReader.GetString(9).ToString

            If Not IsDBNull(db.dReader.GetValue(10)) Then txtNpart.Text = db.dReader.GetString(10).ToString
            If Not IsDBNull(db.dReader.GetValue(11)) Then txtIdAnterior.Text = db.dReader.GetString(11).ToString
            If Not IsDBNull(db.dReader.GetValue(12)) Then rbRetAnt = db.dReader.GetBoolean(12)
            If rbRetAnt = True Then
                rbRetAntSI.Checked = True
            End If
            If rbRetAnt = False Then
                rbRetAntNO.Checked = True
            End If
            If Not IsDBNull(db.dReader.GetValue(13)) Then txtFechaRetAnt.Text = db.dReader.GetDateTime(13).ToString
            If Not IsDBNull(db.dReader.GetValue(14)) Then txtFechaRevGauge.Text = db.dReader.GetString(14).ToString
            If Not IsDBNull(db.dReader.GetValue(15)) Then txtFechaRevGauge.Text = db.dReader.GetString(15).ToString
            If Not IsDBNull(db.dReader.GetValue(16)) Then rbRev = db.dReader.GetBoolean(16)
            If rbRev = True Then
                rbRevGaugeBuenos.Checked = True
            End If
            If rbRev = False Then
                rbRetAntNO.Checked = True
            End If
            If Not IsDBNull(db.dReader.GetValue(27)) Then txtFechaRevGauge.Text = db.dReader.GetDateTime(17).ToString
            If Not IsDBNull(db.dReader.GetValue(28)) Then txtFechaRevGauge.Text = db.dReader.GetString(18).ToString
            If Not IsDBNull(db.dReader.GetValue(29)) Then rbGolpes = db.dReader.GetBoolean(19)
            If rbGolpes = True Then
                rbRetAntSI.Checked = True
            End If
            If rbGolpes = False Then
                rbRetAntNO.Checked = True
            End If
            If Not IsDBNull(db.dReader.GetValue(20)) Then txtFechaSinGolpes.Text = db.dReader.GetDateTime(20).ToString
            If Not IsDBNull(db.dReader.GetValue(21)) Then txtFechaRevGauge.Text = db.dReader.GetString(21).ToString
            If Not IsDBNull(db.dReader.GetValue(22)) Then rbRetAnt = db.dReader.GetBoolean(22)
            If rbRetAnt = True Then
                rbRetAntSI.Checked = True
            End If
            If rbRetAnt = False Then
                rbRetAntNO.Checked = True
            End If
            If Not IsDBNull(db.dReader.GetValue(23)) Then txtFechaArmaSet.Text = db.dReader.GetDateTime(23).ToString
            If Not IsDBNull(db.dReader.GetValue(24)) Then txtFechaRevGauge.Text = db.dReader.GetString(24).ToString
            If Not IsDBNull(db.dReader.GetValue(25)) Then rbArmaSet = db.dReader.GetBoolean(25)
            If rbArmaSet = True Then
                rbRetAntSI.Checked = True
            End If
            If rbArmaSet = False Then
                rbRetAntNO.Checked = True
            End If
            If Not IsDBNull(db.dReader.GetValue(26)) Then txtEmpTalquear.Text = db.dReader.GetDateTime(26).ToString
            If Not IsDBNull(db.dReader.GetValue(27)) Then txtFechaRevGauge.Text = db.dReader.GetString(27).ToString
            If Not IsDBNull(db.dReader.GetValue(28)) Then rbTalquear = db.dReader.GetBoolean(28)
            If rbTalquear = True Then
                rbRetAntSI.Checked = True
            End If
            If rbTalquear = False Then
                rbRetAntNO.Checked = True
            End If
            If Not IsDBNull(db.dReader.GetValue(29)) Then txtEmpSopletear.Text = db.dReader.GetDateTime(29).ToString
            If Not IsDBNull(db.dReader.GetValue(30)) Then txtFechaRevGauge.Text = db.dReader.GetString(30).ToString
            If Not IsDBNull(db.dReader.GetValue(31)) Then rbSopletear = db.dReader.GetBoolean(31)
            If rbSopletear = True Then
                rbRetAntSI.Checked = True
            End If
            If rbSopletear = False Then
                rbRetAntNO.Checked = True
            End If
            If Not IsDBNull(db.dReader.GetValue(32)) Then txtFechaPintar.Text = db.dReader.GetDateTime(32).ToString
            If Not IsDBNull(db.dReader.GetValue(33)) Then txtFechaRevGauge.Text = db.dReader.GetString(33).ToString
            If Not IsDBNull(db.dReader.GetValue(34)) Then rbPintar = db.dReader.GetBoolean(34)
            If rbPintar = True Then
                rbRetAntSI.Checked = True
            End If
            If rbPintar = False Then
                rbRetAntNO.Checked = True
            End If
            If Not IsDBNull(db.dReader.GetValue(35)) Then txtFechaCurar.Text = db.dReader.GetDateTime(35).ToString
            If Not IsDBNull(db.dReader.GetValue(36)) Then txtFechaRevGauge.Text = db.dReader.GetString(36).ToString
            If Not IsDBNull(db.dReader.GetValue(37)) Then rbCurar = db.dReader.GetBoolean(37)
            If rbCurar = True Then
                rbRetAntSI.Checked = True
            End If
            If rbCurar = False Then
                rbRetAntNO.Checked = True
            End If
            If Not IsDBNull(db.dReader.GetValue(38)) Then txtFechaDesarmado.Text = db.dReader.GetDateTime(38).ToString
            If Not IsDBNull(db.dReader.GetValue(39)) Then txtFechaRevGauge.Text = db.dReader.GetString(39).ToString
            If Not IsDBNull(db.dReader.GetValue(40)) Then rbDesarmado = db.dReader.GetBoolean(40)
            If rbDesarmado = True Then
                rbRetAntSI.Checked = True
            End If
            If rbDesarmado = False Then
                rbRetAntNO.Checked = True
            End If
            If Not IsDBNull(db.dReader.GetValue(41)) Then txtFechaAltaDB.Text = db.dReader.GetDateTime(41).ToString
            If Not IsDBNull(db.dReader.GetValue(42)) Then txtFechaRevGauge.Text = db.dReader.GetString(42).ToString
            If Not IsDBNull(db.dReader.GetValue(43)) Then rbAltaDB = db.dReader.GetBoolean(43)
            If rbAltaDB = True Then
                rbRetAntSI.Checked = True
            End If
            If rbAltaDB = False Then
                rbRetAntNO.Checked = True
            End If
            If Not IsDBNull(db.dReader.GetValue(44)) Then txtFechaRevTec.Text = db.dReader.GetDateTime(44).ToString
            If Not IsDBNull(db.dReader.GetValue(45)) Then txtFechaRevGauge.Text = db.dReader.GetString(45).ToString
            If Not IsDBNull(db.dReader.GetValue(46)) Then rbRevTec = db.dReader.GetBoolean(46)
            If rbRevTec = True Then
                rbRetAntSI.Checked = True
            End If
            If rbRevTec = False Then
                rbRetAntNO.Checked = True
            End If
            If Not IsDBNull(db.dReader.GetValue(47)) Then txtEmpEntregar.Text = db.dReader.GetDateTime(47).ToString
            If Not IsDBNull(db.dReader.GetValue(48)) Then txtFechaRevGauge.Text = db.dReader.GetString(48).ToString
            If Not IsDBNull(db.dReader.GetValue(48)) Then rbEnvio = db.dReader.GetBoolean(49).ToString
            If rbEnvio = True Then
                rbRetAntSI.Checked = True
            End If
            If rbEnvio = False Then
                rbRetAntNO.Checked = True
            End If
            If Not IsDBNull(db.dReader.GetValue(50)) Then txtFechaEnvio.Text = db.dReader.GetDateTime(50).ToString
            If Not IsDBNull(db.dReader.GetValue(51)) Then txtEmpEnvio.Text = db.dReader.GetString(51).ToString



        Catch ex As Exception
            MessageBox.Show("Error al leer DataGrid")
        End Try

    End Sub

    Private Sub txtEmpRevGauge_TextChanged(sender As Object, e As EventArgs) Handles txtEmpRevGauge.TextChanged
        If Len(txtEmpRevGauge.Text) = 10 Then
            txtEmpRevGauge.Text = Mid(txtEmpRevGauge.Text, 2, 8)


        End If
    End Sub
End Class