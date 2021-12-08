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

Friend Class Form1
    Inherits System.Windows.Forms.Form
    Dim FileWriter As StreamWriter
    Dim FileReader As StreamReader
    Dim Screen, ShowInfo As Integer
    Dim InicioTurno, FinTurno As String
    Dim TiempoTranscurrido As Integer
    Dim intX As Integer = 0
    Dim strEMailAdd() As String = Nothing
    Dim dblTPA1, dblTPE1, dblTPV1, dblTPA2, dblTPE2, dblTPV2, dblTPA3, dblTPE3, dblTPV3, dblTPA4, dblTPE4, dblTPV4 As Double
    Dim dblTPA5, dblTPE5, dblTPV5, dblTPA6, dblTPE6, dblTPV6, dblTPA7, dblTPE7, dblTPV7, dblTPA8, dblTPE8, dblTPV8 As Double
    Dim dblTPA9, dblTPE9, dblTPV9, dblTPA10, dblTPE10, dblTPV10, dblTPA11, dblTPE11, dblTPV11, dblTPA13, dblTPE13, dblTPV13 As Double
    Dim StrUsage As String
    Dim UsageTPA1, UsageTPE1, UsageTPV1, UsageTPA2, UsageTPE2, UsageTPV2, UsageTPA3, UsageTPE3, UsageTPV3, UsageTPA4, UsageTPE4, UsageTPV4 As Double
    Dim UsageTPA5, UsageTPE5, UsageTPV5, UsageTPA6, UsageTPE6, UsageTPV6, UsageTPA7, UsageTPE7, UsageTPV7, UsageTPA8, UsageTPE8, UsageTPV8 As Double
    Dim UsageTPA9, UsageTPE9, UsageTPV9, UsageTPA10, UsageTPE10, UsageTPV10, UsageTPA11, UsageTPE11, UsageTPV11, UsageTPA13, UsageTPE13, UsageTPV13 As Double
    Dim TVida As TimeSpan
    Dim Ttotal As Double = 0
    Dim TtotalE1 As Double = 0
    Dim TtotalE2 As Double = 0
    Dim strEstadoTimer As String
    Dim intTPA1, intTPE1, intTPV1, intTPA2, intTPE2, intTPV2, intTPA3, intTPE3, intTPV3, intTPA4, intTPE4, intTPV4, intTPA5, intTPE5, intTPV5 As Integer
    Dim intTPA6, intTPE6, intTPV6, intTPA7, intTPE7, intTPV7, intTPA8, intTPE8, intTPV8, intTPA9, intTPE9, intTPV9, intTPA10, intTPE10, intTPV10, intTPA11, intTPE11, intTPV11, intTPA13, intTPE13, intTPV13 As Integer
    Dim Master As Boolean
    Public Declare Function SetCursorPos Lib "user32" (ByVal X As Integer, ByVal Y As Integer) As Integer
    Public Const MOUSEEVENTF_LEFTDOWN = &H2
    Public Const MOUSEEVENTF_LEFTUP = &H4
    Private Const MOUSEEVENTF_RIGHTDOWN = &H8
    Private Const MOUSEEVENTF_RIGHTUP = &H10
    Declare Function apimouse_event Lib "user32.dll" Alias "mouse_event" (ByVal dwFlags As Int32, ByVal dX As Int32, ByVal dY As Int32, ByVal cButtons As Int32, ByVal dwExtraInfo As Int32) As Boolean

    Private Sub LPA1S_Click(sender As Object, e As EventArgs) Handles LPA1S.Click
        ShowInfoLines("01A") 'jala la info de la tabla
        Ttotal = dblTPA1 'Del tiempo que trae solo para display en formato xx:xx:xx no tiene efecto en la tabla 
        TVida = TimeSpan.FromSeconds(UsageTPA1)
        txtVidaE1.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")
    End Sub
    Private Sub LPV1S_Click(sender As Object, e As EventArgs) Handles LPV1S.Click
        ShowInfoLines("01V") 'jala la info de la tabla
        Ttotal = dblTPV1 'Del tiempo que trae solo para display en formato xx:xx:xx no tiene efecto en la tabla 
        TVida = TimeSpan.FromSeconds(UsageTPV1)
        txtVidaE1.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")
    End Sub
    Private Sub LPE1S_Click(sender As Object, e As EventArgs) Handles LPE1S.Click
        ShowInfoLines("01E") 'jala la info de la tabla
        Ttotal = dblTPE1 'Del tiempo que trae solo para display en formato xx:xx:xx no tiene efecto en la tabla 
        TVida = TimeSpan.FromSeconds(UsageTPE1)
        txtVidaE1.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")
    End Sub
    Private Sub LPA2S_Click(sender As Object, e As EventArgs) Handles LPA2S.Click
        ShowInfoLines("02A") 'jala la info de la tabla
        Ttotal = dblTPA2 'Del tiempo que trae solo para display en formato xx:xx:xx no tiene efecto en la tabla 
        TVida = TimeSpan.FromSeconds(UsageTPA2)
        txtVidaE1.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")
    End Sub
    Private Sub LPV2S_Click(sender As Object, e As EventArgs) Handles LPV2S.Click
        ShowInfoLines("02V") 'jala la info de la tabla
        Ttotal = dblTPV2 'Del tiempo que trae solo para display en formato xx:xx:xx no tiene efecto en la tabla 
        TVida = TimeSpan.FromSeconds(UsageTPV2)
        txtVidaE1.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")
    End Sub
    Private Sub LPE2S_Click(sender As Object, e As EventArgs) Handles LPE2S.Click
        ShowInfoLines("02E") 'jala la info de la tabla
        Ttotal = dblTPE2 'Del tiempo que trae solo para display en formato xx:xx:xx no tiene efecto en la tabla 
        TVida = TimeSpan.FromSeconds(UsageTPE2)
        txtVidaE1.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")
    End Sub
    Private Sub LPA3S_Click(sender As Object, e As EventArgs) Handles LPA3S.Click
        ShowInfoLines("03A") 'jala la info de la tabla
        Ttotal = dblTPA3 'Del tiempo que trae solo para display en formato xx:xx:xx no tiene efecto en la tabla 
        TVida = TimeSpan.FromSeconds(UsageTPA3)
        txtVidaE1.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")
    End Sub
    Private Sub LPV3S_Click(sender As Object, e As EventArgs) Handles LPV3S.Click
        ShowInfoLines("03V") 'jala la info de la tabla
        Ttotal = dblTPV3 'Del tiempo que trae solo para display en formato xx:xx:xx no tiene efecto en la tabla 
        TVida = TimeSpan.FromSeconds(UsageTPV3)
        txtVidaE1.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")
    End Sub
    Private Sub LPE3S_Click(sender As Object, e As EventArgs) Handles LPE3S.Click
        ShowInfoLines("03E") 'jala la info de la tabla
        Ttotal = dblTPE3 'Del tiempo que trae solo para display en formato xx:xx:xx no tiene efecto en la tabla 
        TVida = TimeSpan.FromSeconds(UsageTPE3)
        txtVidaE1.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")
    End Sub

    Private Sub LPA4S_Click(sender As Object, e As EventArgs) Handles LPA4S.Click
        ShowInfoLines("04A") 'jala la info de la tabla
        Ttotal = dblTPA4 'Del tiempo que trae solo para display en formato xx:xx:xx no tiene efecto en la tabla 
        TVida = TimeSpan.FromSeconds(UsageTPA4)
        txtVidaE1.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")
    End Sub

    Private Sub LPV4S_Click(sender As Object, e As EventArgs) Handles LPV4S.Click
        ShowInfoLines("04V") 'jala la info de la tabla
        Ttotal = dblTPV4 'Del tiempo que trae solo para display en formato xx:xx:xx no tiene efecto en la tabla 
        TVida = TimeSpan.FromSeconds(UsageTPV4)
        txtVidaE1.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")
    End Sub

    Private Sub LPE4S_Click(sender As Object, e As EventArgs) Handles LPE4S.Click
        ShowInfoLines("04E") 'jala la info de la tabla
        Ttotal = dblTPE4 'Del tiempo que trae solo para display en formato xx:xx:xx no tiene efecto en la tabla 
        TVida = TimeSpan.FromSeconds(UsageTPE4)
        txtVidaE1.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")
    End Sub

    Private Sub LPA5S_Click(sender As Object, e As EventArgs) Handles LPA5S.Click
        ShowInfoLines("05A") 'jala la info de la tabla
        Ttotal = dblTPA5 'Del tiempo que trae solo para display en formato xx:xx:xx no tiene efecto en la tabla 
        TVida = TimeSpan.FromSeconds(UsageTPA5)
        txtVidaE1.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")
    End Sub

    Private Sub LPV5S_Click(sender As Object, e As EventArgs) Handles LPV5S.Click
        ShowInfoLines("05V") 'jala la info de la tabla
        Ttotal = dblTPV5 'Del tiempo que trae solo para display en formato xx:xx:xx no tiene efecto en la tabla 
        TVida = TimeSpan.FromSeconds(UsageTPV5)
        txtVidaE1.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")

    End Sub

    Private Sub LPE5S_Click(sender As Object, e As EventArgs) Handles LPE5S.Click
        ShowInfoLines("05E") 'jala la info de la tabla
        Ttotal = dblTPE5 'Del tiempo que trae solo para display en formato xx:xx:xx no tiene efecto en la tabla 
        TVida = TimeSpan.FromSeconds(UsageTPE5)
        txtVidaE1.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")

    End Sub

    Private Sub LPA6S_Click(sender As Object, e As EventArgs) Handles LPA6S.Click
        ShowInfoLines("06A") 'jala la info de la tabla
        Ttotal = dblTPA6 'Del tiempo que trae solo para display en formato xx:xx:xx no tiene efecto en la tabla 
        TVida = TimeSpan.FromSeconds(UsageTPA6)
        txtVidaE2.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")
    End Sub

    Private Sub LPV6S_Click(sender As Object, e As EventArgs) Handles LPV6S.Click
        ShowInfoLines("06V") 'jala la info de la tabla
        Ttotal = dblTPV6 'Del tiempo que trae solo para display en formato xx:xx:xx no tiene efecto en la tabla 
        TVida = TimeSpan.FromSeconds(UsageTPV6)
        txtVidaE2.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")
    End Sub

    Private Sub LPE6S_Click(sender As Object, e As EventArgs) Handles LPE6S.Click
        ShowInfoLines("06E") 'jala la info de la tabla
        Ttotal = dblTPE6 'Del tiempo que trae solo para display en formato xx:xx:xx no tiene efecto en la tabla 
        TVida = TimeSpan.FromSeconds(UsageTPE6)
        txtVidaE2.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")
    End Sub

    Private Sub LPA7S_Click(sender As Object, e As EventArgs) Handles LPA7S.Click
        ShowInfoLines("07A") 'jala la info de la tabla
        Ttotal = dblTPA7 'Del tiempo que trae solo para display en formato xx:xx:xx no tiene efecto en la tabla 
        TVida = TimeSpan.FromSeconds(UsageTPA7)
        txtVidaE2.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")
    End Sub

    Private Sub LPV7S_Click(sender As Object, e As EventArgs) Handles LPV7S.Click
        ShowInfoLines("07V") 'jala la info de la tabla
        Ttotal = dblTPV7 'Del tiempo que trae solo para display en formato xx:xx:xx no tiene efecto en la tabla 
        TVida = TimeSpan.FromSeconds(UsageTPV7)
        txtVidaE2.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")

    End Sub

    Private Sub LPE7S_Click(sender As Object, e As EventArgs) Handles LPE7S.Click
        ShowInfoLines("07E") 'jala la info de la tabla
        Ttotal = dblTPE7 'Del tiempo que trae solo para display en formato xx:xx:xx no tiene efecto en la tabla 
        TVida = TimeSpan.FromSeconds(UsageTPE7)
        txtVidaE2.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")
    End Sub

    Private Sub LPA8S_Click(sender As Object, e As EventArgs) Handles LPA8S.Click
        ShowInfoLines("08A") 'jala la info de la tabla
        Ttotal = dblTPA8 'Del tiempo que trae solo para display en formato xx:xx:xx no tiene efecto en la tabla 
        TVida = TimeSpan.FromSeconds(UsageTPA8)
        txtVidaE2.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")
    End Sub

    Private Sub LPV8S_Click(sender As Object, e As EventArgs) Handles LPV8S.Click
        ShowInfoLines("08V") 'jala la info de la tabla
        Ttotal = dblTPV8 'Del tiempo que trae solo para display en formato xx:xx:xx no tiene efecto en la tabla 
        TVida = TimeSpan.FromSeconds(UsageTPV8)
        txtVidaE2.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")
    End Sub

    Private Sub LPE8S_Click(sender As Object, e As EventArgs) Handles LPE8S.Click
        ShowInfoLines("08E") 'jala la info de la tabla
        Ttotal = dblTPE8 'Del tiempo que trae solo para display en formato xx:xx:xx no tiene efecto en la tabla 
        TVida = TimeSpan.FromSeconds(UsageTPE8)
        txtVidaE2.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")
    End Sub

    Private Sub LPA9S_Click(sender As Object, e As EventArgs) Handles LPA9S.Click
        ShowInfoLines("09A") 'jala la info de la tabla
        Ttotal = dblTPA9 'Del tiempo que trae solo para display en formato xx:xx:xx no tiene efecto en la tabla 
        TVida = TimeSpan.FromSeconds(UsageTPA9)
        txtVidaE2.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")
    End Sub

    Private Sub LPV9S_Click(sender As Object, e As EventArgs) Handles LPV9S.Click
        ShowInfoLines("09V") 'jala la info de la tabla
        Ttotal = dblTPV9 'Del tiempo que trae solo para display en formato xx:xx:xx no tiene efecto en la tabla 
        TVida = TimeSpan.FromSeconds(UsageTPV9)
        txtVidaE2.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")
    End Sub

    Private Sub LPE9S_Click(sender As Object, e As EventArgs) Handles LPE9S.Click
        ShowInfoLines("09E") 'jala la info de la tabla
        Ttotal = dblTPE9 'Del tiempo que trae solo para display en formato xx:xx:xx no tiene efecto en la tabla 
        TVida = TimeSpan.FromSeconds(UsageTPE9)
        txtVidaE2.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")
    End Sub

    Private Sub LPA10S_Click(sender As Object, e As EventArgs) Handles LPA10S.Click
        ShowInfoLines("10A") 'jala la info de la tabla
        Ttotal = dblTPA10 'Del tiempo que trae solo para display en formato xx:xx:xx no tiene efecto en la tabla 
        TVida = TimeSpan.FromSeconds(UsageTPA10)
        txtVidaE2.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")
    End Sub

    Private Sub LPV10S_Click(sender As Object, e As EventArgs) Handles LPV10S.Click
        ShowInfoLines("10V") 'jala la info de la tabla
        Ttotal = dblTPV10 'Del tiempo que trae solo para display en formato xx:xx:xx no tiene efecto en la tabla 
        TVida = TimeSpan.FromSeconds(UsageTPV10)
        txtVidaE2.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")
    End Sub

    Private Sub LPE10S_Click(sender As Object, e As EventArgs) Handles LPE10S.Click
        ShowInfoLines("10E") 'jala la info de la tabla
        Ttotal = dblTPE10 'Del tiempo que trae solo para display en formato xx:xx:xx no tiene efecto en la tabla 
        TVida = TimeSpan.FromSeconds(UsageTPE10)
        txtVidaE2.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")
    End Sub

    Private Sub LPA11S_Click(sender As Object, e As EventArgs) Handles LPA11S.Click, LPA13S.Click
        ShowInfoLines("11A") 'jala la info de la tabla
        Ttotal = dblTPA11 'Del tiempo que trae solo para display en formato xx:xx:xx no tiene efecto en la tabla 
        TVida = TimeSpan.FromSeconds(UsageTPA11)
        txtVidaE2.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")
    End Sub

    Private Sub LPV11S_Click(sender As Object, e As EventArgs) Handles LPV11S.Click, LPV13S.Click
        ShowInfoLines("11V") 'jala la info de la tabla
        Ttotal = dblTPV11 'Del tiempo que trae solo para display en formato xx:xx:xx no tiene efecto en la tabla 
        TVida = TimeSpan.FromSeconds(UsageTPV11)
        txtVidaE2.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")
    End Sub

    Private Sub LPE11S_Click(sender As Object, e As EventArgs) Handles LPE11S.Click, LPE13S.Click
        ShowInfoLines("11E") 'jala la info de la tabla
        Ttotal = dblTPE11 'Del tiempo que trae solo para display en formato xx:xx:xx no tiene efecto en la tabla 
        TVida = TimeSpan.FromSeconds(UsageTPE11)
        txtVidaE2.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")
    End Sub

    Private Sub LPA13S_Click(sender As Object, e As EventArgs) Handles LPA13S.Click
        ShowInfoLines("13A") 'jala la info de la tabla
        Ttotal = dblTPA13 'Del tiempo que trae solo para display en formato xx:xx:xx no tiene efecto en la tabla 
        TVida = TimeSpan.FromSeconds(UsageTPA13)
        txtVidaE2.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")
    End Sub

    Private Sub LPV13S_Click(sender As Object, e As EventArgs) Handles LPV13S.Click
        ShowInfoLines("13V") 'jala la info de la tabla
        Ttotal = dblTPV13 'Del tiempo que trae solo para display en formato xx:xx:xx no tiene efecto en la tabla 
        TVida = TimeSpan.FromSeconds(UsageTPV13)
        txtVidaE2.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")
    End Sub

    Private Sub LPE13S_Click(sender As Object, e As EventArgs) Handles LPE13S.Click
        ShowInfoLines("13E") 'jala la info de la tabla
        Ttotal = dblTPE13 'Del tiempo que trae solo para display en formato xx:xx:xx no tiene efecto en la tabla 
        TVida = TimeSpan.FromSeconds(UsageTPE13)
        txtVidaE2.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")
    End Sub

    Private Sub BtnRevisarE1_Click(sender As Object, e As EventArgs) Handles btnRevisarE1.Click
        Revisar.Show()
    End Sub

    Private Sub GrdGrommet_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrdGrommet.CellDoubleClick
        Form2.lblID.Text = GrdGrommet.CurrentRow.Cells(0).Value.ToString
        Form2.Show()
        '  Dim Information As String = "select * from Tooling.CREATESET where  idCREATESET='" & GrdGrommet.CurrentRow.Cells(0).Value.ToString & "'ORDER BY idCREATESET DESC "
        'Hace consulta
        '  Try
        'db.SelectQueryReader(Information)
        'db.dReader.Read()

        'Form2.cmbTooling.Text = db.dReader.GetString(2).ToString
        'Form2.cmbColor.Text = db.dReader.GetString(3).ToString
        'Form2.cmbIdAnterior.Text = db.dReader.GetString(6).ToString
        'Form2.txtCantPlat.Text = db.dReader.GetValue(7).ToString

        '  Catch ex As Exception
        '   MessageBox.Show("Error al leer DataGrid")
        '  End Try

        'Dim query As String = "select * from Tooling.CONTROLSET where  SETID='" & GrdGrommet.CurrentRow.Cells(0).Value.ToString & "'"
        ''Hace consulta
        'Try
        '    db.SelectQueryReader(query)
        '    db.dReader.Read()
        '    frmNewGrommetSet.cmbTooling.Text = db.dReader.GetValue(2).ToString
        '    frmNewGrommetSet.cmbColor.Text = db.dReader.GetValue(3).ToString
        '    frmNewGrommetSet.cmbDiam.Text = db.dReader.GetValue(4).ToString
        '    frmNewGrommetSet.cmbRunner.Text = db.dReader.GetValue(6).ToString
        '    frmNewGrommetSet.cmbIDColor.Text = db.dReader.GetValue(7).ToString

        'Catch ex As Exception

        'End Try
        'frmNewGrommetSet.Show()
        'End If
        'Else
        'ResetAlarm.Show()
        'ResetAlarm.lblSetNum.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        'ResetAlarm.lblSize.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        'ResetAlarm.lblTipo.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        'ResetAlarm.txtPlatos.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        'ResetAlarm.lblProdAct.Text = DataGridView1.CurrentRow.Cells(12).Value.ToString
        'ResetAlarm.lblProdMax.Text = DataGridView1.CurrentRow.Cells(11).Value.ToString
        'ResetAlarm.lblPorcentaje.Text = DataGridView1.CurrentRow.Cells(9).Value
        'Dim Dataquery As String = "select * from Tooling.CONTROLSET where  SETID='" & DataGridView1.CurrentRow.Cells(0).Value.ToString & "'"
        'db.SelectQueryReader(Dataquery)
        'db.dReader.Read()
        'ResetAlarm.lblColor.Text = db.dReader.GetValue(3).ToString
        'ResetAlarm.lblDiam.Text = db.dReader.GetValue(4).ToString
        'ResetAlarm.lblRunner.Text = db.dReader.GetValue(6).ToString
        'ResetAlarm.cmbIDColor.Text = db.dReader.GetValue(7).ToString

        'End If
        'Else
        'MessageBox.Show("No tiene Privilegios")
        'End If


    End Sub

    Private Sub BtnRevisarE2_Click(sender As Object, e As EventArgs) Handles btnRevisarE2.Click
        Revisar.Show()
    End Sub

    Private Sub BtnRepararE2_Click(sender As Object, e As EventArgs) Handles btnRepararE2.Click
        Reparar.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub TmrChange_Tick(sender As Object, e As EventArgs) Handles tmrChange.Tick
        SetCursorPos(80, 100)
        Call apimouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
        Call apimouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
    End Sub


    Private Sub BtnRepTool_Click(sender As Object, e As EventArgs) Handles BtnRepTool.Click
        Reparar.Show()
    End Sub

    Private myConString As String
    Dim con As New MySqlConnection("server=10.56.12.100; user id=root; database=TimeReport2; port=3306; password=INGENIERIA")
    Dim db As New DBConnection()
    Dim g_IntSaveGrid As Integer
    Dim save As Double = 1
    Dim flagsave As Integer = 0
    Dim FILE_NAME_Logger As String = "C:\APP\TOOLING\Data\Logger.txt"
    Dim objWrtLOG As New System.IO.StreamWriter(FILE_NAME_Logger, True)
    Dim sDBtoFile As String = "C:\APP\TOOLING\Data\Running.txt"
    Dim StrFecha, StrHora, StrLinea, StrToolingID, StrEstado, StrVida, StrHr, StrUsoFile As String
    Dim StrUso As Double
    Dim StrDummy As String
    Dim TextLine As String = vbNullString
    Dim TestString As String = vbNullString
    Dim strDummyLine As String = vbNullString

    Private Sub TimerMain_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerMain.Tick
        GetTimers()
        DBtoFile()
        DBtoFileRead()
        UpdateTableFromToolin()
        LoadGrid()
    End Sub

    Public Function UpdateTableFromFile(ByVal StrFileNameTbl As String) As Double
        'Procesa la info del MyDebug si instalaste algun Tooling
        Dim DownTimeCnnStr As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\APP\TOOLING\Data\PINPACK.mdb;Persist Security Info=False;"
        Dim conn1 As New System.Data.OleDb.OleDbConnection(DownTimeCnnStr)
        Dim query As String '= "Select TMUERTO FROM REPORTES WHERE DEPTO='TESTING' AND (AREA ='Palomar' or AREA ='Palomar 33xx' ) and HORA_REPORTE >= #" + InicioTurno + "# AND HORA_TERMINO <= #" + FinTurno + " #"
        Dim queryupd As String
        Dim SPath As String = "c:\APP\TOOLING\DATA\"
        Dim sContent As String = vbNullString
        Dim sdir As String = "c:\Nueva carpeta"
        Dim strDummysDate, strDummysHr, strDummyLine, strDummyPrensa, strDummyArea, strDummyTurno, strDummyTool, strDummyPPAnt, strDummyPPNew, strDummGreenPlate, strDummyQtyLabD, strDummyLaine, strDummyTec, strDummyState, strDummyId, strDummyNumEmp As String
        strDummyId = ""
        SPath = StrFileNameTbl
        Try
            With My.Computer.FileSystem
                ' verifica si existe el path  
                If .FileExists(SPath) Then
                    ' lee todo el contenido  
                    Dim objReader As New System.IO.StreamReader(SPath)
                    Do While objReader.Peek() <> -1
                        TextLine = TextLine & objReader.ReadLine()
                        TestString = TextLine
                        Dim TestArray() As String = Split(TestString)
                        Dim LastNonEmpty As Integer = 0
                        Dim pm As String
                        For i As Integer = 0 To 1
                            If TestArray(i) <> "" Then
                                LastNonEmpty += 1
                                strDummysDate = TestArray(i)
                                strDummysHr = TestArray(i + 1)
                                pm = TestArray(i + 2)
                                strDummyTurno = TestArray(i + 3)
                                strDummyLine = TestArray(i + 4)
                                strDummyPrensa = TestArray(i + 5)
                                strDummyArea = TestArray(i + 6)
                                strDummyTool = TestArray(i + 7)
                                strDummyPPAnt = TestArray(i + 8)
                                strDummyPPNew = TestArray(i + 9)
                                strDummGreenPlate = TestArray(i + 10)
                                strDummyQtyLabD = TestArray(i + 11)
                                strDummyLaine = TestArray(i + 12)
                                strDummyNumEmp = TestArray(i + 13)
                                strDummyTec = TestArray(i + 14)
                                strDummyState = TestArray(i + 15)
                                StrUsage = TestArray(i + 16)   'Usage
                                StrUsage = StrUsage.Trim()
                                strDummysHr = strDummysHr + " " + pm
                                i = i + 1
                                ' TestArray(LastNonEmpty) = TestArray(i)
                            End If
                        Next
                        ReDim Preserve TestArray(LastNonEmpty)
                        '----------Modificacion para sacar el tiempo de uso del tooling que es reemplazado------------------------------------------
                        'Logica que hace la diferencia en segundos desde la fecha/hora que se capturo el Tooling
                        'hasta la fecha hora que lo esta bajando a la base
                        Dim FileTime, FileTimeEncontrado As DateTime 'FileTime es el que viene de MyDebug y FileEncontrado el que esta instalado
                        Dim SecDiff As Double 'Alacena la diferencia de MyDebug y cuando conectas ala HH
                        Dim StrHr, StrHrEncontrado As String
                        StrHr = strDummysDate + " " + strDummysHr
                        FileTime = Convert.ToDateTime(StrHr)
                        SecDiff = DateDiff(DateInterval.Second, FileTime, DateTime.Now)
                        'hay que hacer una busqueda de la linea que traiga el ultimo TOOLINGID instalado
                        conn1.Open()
                        query = "Select * FROM Tooling.INFOLINES WHERE INFOLINES.LINEA='" + strDummyLine + "' ORDER BY FECHA DESC"
                        db.SelectQueryReader(query)
                        'db.dReader.Read()
                        Dim Encontrado0, Encontrado1, Encontrado15, Encontrado6 As String
                        Dim Encontrado16 As Double
                        'identifica el reporte mas reciente para esa linea
                        ' db.dReader.Read()
                        Encontrado0 = db.dReader.GetValue(0) 'trae la fecha
                        Encontrado1 = db.dReader.GetValue(1) 'trae la hora
                        Encontrado16 = db.dReader.GetValue(17) 'trae la vida
                        Encontrado15 = db.dReader.GetString(16) 'trae el status
                        Encontrado6 = db.dReader.GetString(6) 'trae el ToolingID que se esta quitando
                        conn1.Close()
                        ' Ese TOOLINgID que haga una resta del tiempo que se instalo este nuevo y el tiempo del encontrado
                        StrHrEncontrado = Encontrado0 ' + " " + Encontrado1
                        FileTimeEncontrado = Convert.ToDateTime(StrHrEncontrado)
                        Dim ToolTotaltime As Double
                        ToolTotaltime = DateDiff(DateInterval.Second, FileTimeEncontrado, FileTime)
                        'Logica que calcula la eficiencia de quien esta instalando el tooling:
                        'Calcula cuantos minutos lo cambio antes o despues
                        Dim CalcEficiencia As Double
                        CalcEficiencia = ToolTotaltime - Convert.ToDouble(Encontrado16)
                        'en el insert de abajo que suba el resultado de la resta y update al tooling ID viejo
                        Dim strUsingU As String = "U"
                        conn1.Open()
                        query = "INSERT INTO Tooling.INFOLINES (FECHA,HORA,TURNO,LINEA,PRENSA,AREA, TOOLINGID,PPACKANT,PPACKNUEVO, GREENPLATE, QTYLABIOSDOBLADOS, QTYPINESDOBLADOS, QTYPINESQUEBRADOS, LAINA,EMPLEADO, INSTALO, ESTADO, VIDA, QUITO, DURATOTAL, EFICIENCIA) VALUES ('" & FileTime & "','" & strDummysHr & "', '" & strDummyTurno & "','" & strDummyLine & "','" & strDummyPrensa & "','" & strDummyArea & "','" & strDummyTool & "','" & strDummyPPAnt & "','" & strDummyPPNew & "','" & strDummGreenPlate & "','" & strDummyQtyLabD & "','" & strUsingU & "','" & strUsingU & "','" & strDummyLaine & "','" & strDummyNumEmp & "','" & strDummyTec & "','" & strDummyState & "','" & StrUsage & "','" & "EnUso" & "','" & "0" & "','" & "0" & "' )"
                        queryupd = "UPDATE Tooling.INFOLINES SET ESTADO = 'R', QUITO = '" & strDummyTec & "', DURATOTAL = '" & ToolTotaltime & "', EFICIENCIA = '" & CalcEficiencia & "' WHERE FECHA = #" & Encontrado0 & "# AND HORA = #" & Encontrado1 & "#"
                        If Encontrado15 = "D" Then
                            queryupd = "UPDATE Tooling.INFOLINES SET QUITO = '" & strDummyTec & "', DURATOTAL = '" & "0" & "', EFICIENCIA = '" & "0" & "' WHERE FECHA = #" & Encontrado0 & "# AND HORA = #" & Encontrado1 & "#"
                        End If
                        db.ModifyQuery(query)
                        db.CloseConnection()
                        'crea el LOG de lo que estas instalando
                        If TestString <> vbNullString Then
                            Using objWrtLOG As New System.IO.StreamWriter(FILE_NAME_Logger, True)
                                objWrtLOG.WriteLine(DateAndTime.Now + " Mydebug.DAT: " + TestString)
                                objWrtLOG.Close()
                            End Using
                        End If
                        db.ModifyQuery(queryupd)
                        db.CloseConnection()
                        TextLine = ""
                        '---------------------------------------------------------------------------------------------------------------------
                        conn1.Open()
                        query = "SELECT ESTADO FROM Tooling.RUNNING WHERE LINEA = '" + strDummyLine + "'"
                        db.SelectQueryReader(query)
                        ' db.dReader.Read()
                        Dim strEstado As String
                        strEstado = "X"
                        While db.dReader.Read()
                            strEstado = db.dReader.GetString(0)
                        End While
                        db.CloseConnection()
                        If strEstado = "X" Then
                            conn1.Open()
                            query = "INSERT INTO Tooling.RUNNING (FECHA,HORA,TURNO,LINEA,PRENSA,AREA,TOOLINGID,PPACKANT,PPACKNUEVO, GREENPLATE,QTYLABIOSDOBLADOS, LAINA,EMPLEADO ,INSTALO, ESTADO, VIDA) VALUES ('" & strDummysDate & "','" & strDummysHr & "', '" & strDummyTurno & "','" & strDummyLine & "','" & strDummyPrensa & "','" & strDummyArea & "','" & strDummyTool & "','" & strDummyPPAnt & "','" & strDummyPPNew & "','" & strDummGreenPlate & "','" & strDummyQtyLabD & "','" & strDummyLaine & "','" & strDummyNumEmp & "','" & strDummyTec & "','" & strDummyState & "','" & StrUsage & "' )"
                            db.SelectQueryReader(query)
                            ' db.dReader.Read()
                            db.CloseConnection()
                        Else
                            'Graba en la tabla Running la informacion del Tooling que estas instalando
                            If strEstado = "G" Or strEstado = "Y" Or strEstado = "R" Or strEstado = "D" Or strEstado = "U" Or strEstado = "P" Then
                                query = "UPDATE  Tooling.RUNNING SET FECHA = '" & strDummysDate & "',HORA = '" & strDummysHr & "',TURNO = '" & strDummyTurno & "',PRENSA='" & strDummyPrensa & "',AREA='" & strDummyArea & "',TOOLINGID='" & strDummyTool & "',PPACKANT='" & strDummyPPAnt & "',PPACKNUEVO='" & strDummyPPNew & "', GREENPLATE= '" & strDummGreenPlate & "',QTYLABIOSDOBLADOS='" & strDummyQtyLabD & "', LAINA='" & strDummyLaine & "',EMPLEADO='" & strDummyNumEmp & "',INSTALO='" & strDummyTec & "',ESTADO='" & strDummyState & "',VIDA='" & StrUsage & "'  WHERE RUNNING.LINEA='" + strDummyLine + "'"
                                db.SelectQueryReader(query)
                                ' db.dReader.Read()
                                db.CloseConnection()
                            End If
                            ' Graba en TOOLINES con "U" el que estas poniendo y manda a "R" el que quitaste
                            g_IntSaveGrid = 1
                            Dim accessU, accessR As String
                            accessR = "UPDATE Tooling.TOOLLINES SET STATUS = 'R' where TOOLINGID='" & Encontrado6 & "'"
                            accessU = "UPDATE Tooling.TOOLLINES SET STATUS = 'U' where TOOLINGID='" & strDummyTool & "'"
                            con.Open()
                            If Encontrado15 <> "D" Then
                                db.ModifyQuery(accessR)
                                db.CloseConnection()
                            End If
                            db.ModifyQuery(accessU)
                            db.CloseConnection()
                            g_IntSaveGrid = 0
                        End If
                        'Esta linea no hace nada, no recuerdo por que esta aqui
                        strDummyLine = strDummyLine + strDummyState + StrUsage
                    Loop
                    objReader.Close()
                Else
                    MsgBox("ruta inválida", MsgBoxStyle.Critical, "error")
                End If
            End With

            ' errores  
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
            intTPA1 = 0
            intTPE1 = 0
            intTPV1 = 0
        End Try
LastLine:
    End Function



    Public Function UpdateTableFromHH(ByVal StrFileNameTbl As String) As Double 'returna el numero de minutos de downtime
        ' Procesa el archivo de ToolRepair si reparaste algun tooling
        'Dim DownTimeCnnStr As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\APP\TOOLING\Data\PINPACK.mdb;Persist Security Info=False;" 'Jet OLEDB:Database" ' Password=INGENIERIA"        
        ' Dim conn1 As New System.Data.OleDb.OleDbConnection(DownTimeCnnStr)
        Dim query As String
        Dim SPath As String = "c:\APP\TOOLING\DATA\ToolOK.txt"

        Dim strDummysDate, strDummysHr, strDummyLine, strDummyPrensa, strDummyArea, strDummyTurno, strDummyTool, strDummyPPAnt, strDummyPPNew, strDummGreenPlate, strDummyQtyPinD, strDummyQtyPinQ, strDummyLaine, strDummyTec, strDummyState, strDummyId, strDummyEmpRep, strDummyFechaRep As String
        strDummyId = ""
        Try
            With My.Computer.FileSystem
                ' verifica si existe el path  
                If .FileExists(StrFileNameTbl) Then
                    g_IntSaveGrid = 1

                    ' lee todo el contenido del archivo ToolRepair  
                    Dim objReader As New System.IO.StreamReader(StrFileNameTbl)
                    Do While objReader.Peek() <> -1
                        TextLine = TextLine & objReader.ReadLine()
                        TestString = TextLine
                        Dim TestArray() As String = Split(TestString, ",")
                        Dim LastNonEmpty As Integer = 0
                        For i As Integer = 0 To 1
                            If TestArray(i) <> "" Then
                                LastNonEmpty += 1
                                strDummysDate = TestArray(i)
                                strDummysHr = TestArray(i + 1)
                                strDummyLine = TestArray(i + 2)
                                strDummyPrensa = TestArray(i + 3)
                                If StrFileNameTbl = "C:\APP\TOOLING\Data\ToolRepair1.ok" Or StrFileNameTbl = "C:\APP\TOOLING\Data\ToolRepair2.ok" Then
                                    strDummyQtyPinD = TestArray(i + 5)
                                    strDummyQtyPinQ = TestArray(i + 6)
                                    strDummyEmpRep = TestArray(i + 7)
                                    strDummyFechaRep = TestArray(i + 8)
                                    strDummyFechaRep = Convert.ToDateTime(strDummyFechaRep)
                                End If
                                i = i + 1
                            End If
                            Dim Encontrado0, Encontrado1 As String
                            Dim access1 As String = "UPDATE TOOLLINES SET STATUS = 'G' where TOOLINGID='" & strDummyLine & "'" 'Entran ToolBAD y ToolOK los deja en G

                            Dim access2 As String = "UPDATE TOOLLINES SET STATUS = '" & strDummysHr & "' where TOOLINGID='" & strDummyLine & "'" 'Entran ToolBAD y ToolOK los deja en R



                            If StrFileNameTbl = "C:\APP\TOOLING\Data\ToolOK.TXT" Then
                                db.ModifyQuery(access1)
                                db.CloseConnection()
                                access1 = ""
                                TextLine = ""

                            ElseIf StrFileNameTbl = "C:\APP\TOOLING\Data\ToolBAD.txt" Then
                                db.ModifyQuery(access2)
                                db.CloseConnection()
                                access2 = ""
                                TextLine = ""

                            ElseIf StrFileNameTbl = "C:\APP\TOOLING\Data\ToolRepair1.ok" Or StrFileNameTbl = "C:\APP\TOOLING\Data\ToolRepair2.ok" Then

                                '------------IDENTIFICA ULTIMO TOOLINGID INSTALADO ---
                                'Encuentra el ToolingID que se reparo con la ultima fecha del historial de toolings

                                query = "Select * FROM INFOLINES WHERE INFOLINES.TOOLINGID='" + strDummyLine + "' ORDER BY FECHA DESC, HORA DESC"
                                db.SelectQueryReader(query)

                                'identifica el reporte mas reciente para ese toolingid
                                ' db.dReader.Read()
                                Encontrado0 = db.dReader.GetValue(0) 'trae la fecha
                                Encontrado1 = db.dReader.GetValue(1) 'trae la hora

                                'Por si en e futuro quieren hacer algo si hay muchos pines danados
                                If Convert.ToInt16(strDummyQtyPinD) > 5 Or Convert.ToInt16(strDummyQtyPinQ) > 5 Then
                                    ' PinesBad()
                                End If

                                'Para la tabla del historial le agrega la info de la reparacion
                                Dim ProgressNFQuery As String = "UPDATE INFOLINES SET ESTADO = 'G', QTYPINESDOBLADOS = '" & strDummyQtyPinD & "', REPARO = '" & strDummyEmpRep & "', FECHAREP = #" & strDummyFechaRep & "#, QTYPINESQUEBRADOS = '" & strDummyQtyPinQ & "' WHERE FECHA = #" & Encontrado0 & "# AND HORA = #" & Encontrado1 & "#"

                                db.ModifyQuery(ProgressNFQuery)

                                'Crea el Log de la reparacion
                                If TestString <> vbNullString Then
                                    Using objWrtLOG As New System.IO.StreamWriter(FILE_NAME_Logger, True)
                                        objWrtLOG.WriteLine(DateAndTime.Now + " ToolRepair.ok: " + TestString)
                                        objWrtLOG.Close()
                                    End Using
                                End If
                                '-------------TERMINA DE IDENTIFICAR -----------
                                '-------------Inicia Si alguien se brinco un cambio ------------------

                                Dim queryByPass As String = "Select TOOLINGID FROM RUNNING WHERE TOOLINGID = '" + strDummyLine + "'"
                                db.SelectQueryReader(queryByPass)
                                ' db.dReader.Read()

                                If db.dReader.HasRows Then
                                    queryByPass = "UPDATE  RUNNING SET ESTADO='" & "D" & "'  WHERE RUNNING.TOOLINGID='" + strDummyLine + "'"
                                    db.ModifyQuery(queryByPass)
                                End If
                                db.dReader.Close()
                                '-------------Fin Si alguien se brinco un cambio ------------------


                                access2 = ""
                                TextLine = ""
                                con.Close()
                            End If




                        Next
                        ReDim Preserve TestArray(LastNonEmpty)

                    Loop


                    objReader.Close()
                    g_IntSaveGrid = 0


                Else
                    MsgBox("ruta inválida", MsgBoxStyle.Critical, "error")
                End If
            End With

            ' errores  
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
            intTPA1 = 0
            intTPE1 = 0
            intTPV1 = 0
        End Try

LastLine:
    End Function
    Public Sub PinesBad()

        MsgBox("se enviara un email")


    End Sub
    'OK
    Public Function ShowInfoLines(ByVal StrLine As String) As Double
        'En el click del boton de la prensa saca la info de la tabla para mostrarla en los detalles de la pantalla principal
        Dim Fecha As Date
        Dim Hora As Date
        Dim SPath As String = "c:\APP\TOOLING\DATA\"
        Dim sContent As String = vbNullString
        Dim sdir As String = "c:\Nueva carpeta"
        Dim strDummyPrensa, strDummyLine, strDummyArea, strDummyTurno, strDummyTool, strDummyPPAnt, strDummyPPNew, strDummGreenPlate, strDummyQtyLabD, strDummyLaine, strDummyTec, strDummyState, strNumEmp As String
        Try
            Dim query As String = "Select * FROM Tooling.RUNNING WHERE LINEA='" + StrLine + "'"
            db.SelectQueryReader(query)
            'db.dReader.Read()
            While db.dReader.Read()
                Fecha = db.dReader.GetDateTime(0)
                Hora = db.dReader.GetDateTime(1)
                strDummyTurno = db.dReader.GetString(2)
                strDummyLine = db.dReader.GetString(3)
                strDummyPrensa = db.dReader.GetString(4)
                strDummyArea = db.dReader.GetString(5)
                strDummyTool = db.dReader.GetString(6)
                strDummyPPAnt = db.dReader.GetString(7)
                strDummyPPNew = db.dReader.GetString(8)
                strDummGreenPlate = db.dReader.GetString(9)
                strDummyQtyLabD = db.dReader.GetString(10)
                strDummyLaine = db.dReader.GetString(11)
                strNumEmp = db.dReader.GetString(12)
                strDummyTec = db.dReader.GetString(13)
                strDummyState = db.dReader.GetString(14)

                EdtLine.Text = strDummyLine.Substring(0, 2)
                EdtPrensa.Text = strDummyPrensa
                EdtLado.Text = strDummyLine.Substring(2, 1)
                EdtHora.Text = Hora
                EdtFecha.Text = Fecha
                EdtTurno.Text = strDummyTurno
                EdtTooling.Text = strDummyTool
                EdtPPackAnt.Text = strDummyPPAnt
                EdtGreenPlate.Text = strDummGreenPlate
                EdtLaina.Text = strDummyLaine
                EdtTecnico.Text = strDummyTec
                EdNumEmpleado.Text = strNumEmp
                Label5.Text = strDummyState

                txtLineaE1.Text = strDummyLine.Substring(0, 2)
                txtPrenE1.Text = strDummyPrensa
                txtLadoE1.Text = strDummyLine.Substring(2, 1)
                txtHoraE1.Text = Hora
                txtFechE1.Text = Fecha
                txtTurnoE1.Text = strDummyTurno
                txtToolE1.Text = strDummyTool
                txtAntE1.Text = strDummyPPAnt
                txtGreenE1.Text = strDummGreenPlate
                txtLainaE1.Text = strDummyLaine
                txtTecE1.Text = strDummyTec
                txtEmplE1.Text = strNumEmp


                txtLineaE2.Text = strDummyLine.Substring(0, 2)
                txtPrensaE2.Text = strDummyPrensa
                txtLadoE2.Text = strDummyLine.Substring(2, 1)
                txtHoraE2.Text = Hora
                txtFechE2.Text = Fecha
                txtTurnoE2.Text = strDummyTurno
                txtToolE2.Text = strDummyTool
                txtAntE2.Text = strDummyPPAnt
                txtGreenE2.Text = strDummGreenPlate
                txtLainaE2.Text = strDummyLaine
                txtTecE2.Text = strDummyTec
                txtEmpE2.Text = strNumEmp

            End While

            db.CloseConnection()
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
            intTPA1 = 0
            intTPE1 = 0
            intTPV1 = 0
        End Try

LastLine:
    End Function

    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        Dim objIniFileAppSetup As New IniFile("c:\app\Tooling\SETUP.INI")
        Dim strSTATIONSetup As String
        strSTATIONSetup = objIniFileAppSetup.GetString("TOOLSTATION", "STATION", "0")

        If strSTATIONSetup = "1" Then
            TabHistorial.SelectedIndex = 3
            lblEstacion.Text = "Estacion 1"
            Master = False
            Button1.Visible = False

            Me.FormBorderStyle = False
            MenuStrip1.Visible = False
        ElseIf strSTATIONSetup = "2" Then
            TabHistorial.SelectedIndex = 4
            lblEstacion.Text = "Estacion 2"
            Master = False
            Button1.Visible = False

            Me.FormBorderStyle = False
            MenuStrip1.Visible = False
        Else
            TabHistorial.SelectedIndex = 0
            lblEstacion.Text = "Estacion Principal"
            Master = True
        End If
        'Main LOAD
        If System.IO.File.Exists("C:\APP\TOOLING\Data\Running.txt") = True Then
            System.IO.File.Delete("C:\APP\TOOLING\Data\Running.txt")
        End If
        GetTimers() 'Vacia en variables el valor de los segundos de cada prensa, solo para el display en la pantala principal

        DBtoFile()  'Crea un archivo txt con la info de lo que se esta corriendo
        DBtoFileRead() ' Lee el archivo de texto para actualizar las demas tablas
        UpdateGrid() 'Actualiza el Grid por si hubo algun cambio
        LoadGrid()
        'Escribe en el Log
        objWrtLOG.WriteLine(DateAndTime.Now + " Inicaliza Aplicacion APPDIPPER")
        objWrtLOG.Close()

    End Sub
    'OK esta solo jala para la peestana Ajustes, hay que probarla
    Public Function ReadTableStatus() As Double
        Dim DownTimeCnnStr As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\APP\TOOLING\Data\PINPACK.mdb;Persist Security Info=False;"
        Dim conn1 As New System.Data.OleDb.OleDbConnection(DownTimeCnnStr)
        Dim query As String
        Dim SPath As String = "c:\APP\TOOLING\DATA\"
        Dim strDummyState As String = vbNullString
        Dim strDummyUsage As String = vbNullString

        '--------------
        DBtoFile()

        DBtoFileRead()


        Dim testLAZ As Integer = 0
        If testLAZ = 1 Then
            Try
                conn1.Open()

                query = "Select RUNNING.ESTADO, RUNNING.LINEA, RUNNING.VIDA FROM RUNNING"
                Dim cmd3 As New System.Data.OleDb.OleDbCommand(query, conn1)
                Dim reader3 As OleDbDataReader = cmd3.ExecuteReader
                Dim strEstado As String

                strEstado = "X"
                While reader3.Read()
                    strDummyState = reader3.GetString(0)
                    strDummyLine = reader3.GetString(1)
                    strDummyUsage = reader3.GetString(2)
                    strDummyLine = strDummyLine + strDummyState + strDummyUsage
                    If strDummyLine.Contains("01") Then
                        UpdateTableStatusLine1(strDummyLine)
                    End If

                    If strDummyLine.Contains("02") Then
                        UpdateTableStatusLine2(strDummyLine)
                    End If

                    If strDummyLine.Contains("03") Then
                        UpdateTableStatusLine3(strDummyLine)
                    End If

                    If strDummyLine.Contains("04") Then
                        UpdateTableStatusLine4(strDummyLine)
                    End If

                    If strDummyLine.Contains("05") Then
                        UpdateTableStatusLine5(strDummyLine)
                    End If

                    If strDummyLine.Contains("06") Then
                        UpdateTableStatusLine6(strDummyLine)
                    End If

                    If strDummyLine.Contains("07") Then
                        UpdateTableStatusLine7(strDummyLine)
                    End If

                    If strDummyLine.Contains("08") Then
                        UpdateTableStatusLine8(strDummyLine)
                    End If

                    If strDummyLine.Contains("09") Then
                        UpdateTableStatusLine9(strDummyLine)
                    End If

                    If strDummyLine.Contains("10") Then
                        UpdateTableStatusLine10(strDummyLine)
                    End If

                    If strDummyLine.Contains("11") Then
                        UpdateTableStatusLine10(strDummyLine)
                    End If

                    If strDummyLine.Contains("13") Then
                        UpdateTableStatusLine10(strDummyLine)
                    End If

                End While

                conn1.Close()
                ' errores  
            Catch ex As Exception
                MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
            End Try
        End If
LastLine:
    End Function

    'Lo usa la pestana Ajustes cuando deshabilitas una Linea
    Public Function UpdateTableStatusColor(ByVal StrFileNameTbl As String) As Double
        Dim DownTimeCnnStr As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\APP\TOOLING\Data\PINPACK.mdb;Persist Security Info=False;"
        Dim conn1 As New System.Data.OleDb.OleDbConnection(DownTimeCnnStr)
        Dim query As String
        Dim SPath As String = "c:\APP\TOOLING\DATA\"
        Dim sContent As String = vbNullString
        Dim strDummyLine, strDummyState, StrTool, StrIDD As String

        strDummyLine = StrFileNameTbl.Remove(3, 1)
        strDummyState = StrFileNameTbl.Remove(0, 3)

        SPath = StrFileNameTbl
        StrIDD = ""
        StrTool = ""
        Try


            conn1.Open()
            query = "UPDATE  RUNNING SET ESTADO = '" & strDummyState & "' WHERE RUNNING.LINEA='" + strDummyLine + "'"
            Dim cmd1 As New System.Data.OleDb.OleDbCommand(query, conn1)
            cmd1.ExecuteNonQuery()
            conn1.Close()

            conn1.Open()

            query = "Select RUNNING.TOOLINGID FROM RUNNING WHERE RUNNING.LINEA='" + strDummyLine + "'"
            Dim cmd3 As New System.Data.OleDb.OleDbCommand(query, conn1)
            Dim reader3 As OleDbDataReader = cmd3.ExecuteReader
            Dim strEstado As String


            While reader3.Read()
                StrTool = reader3.GetString(0)
                ' StrIDD = reader3.GetString(1)
            End While
            conn1.Close()

            If StrTool <> "" And strDummyState = "R" Then
                '------------IDENTIFICA ULTIMO TOOLINGID INSTALADO ---
                'Encuentra el ToolingID que se reparo con la ultima fecha
                conn1.Open()
                query = "Select * FROM INFOLINES WHERE INFOLINES.TOOLINGID='" + StrTool + "' ORDER BY FECHA DESC, HORA DESC"
                Dim cmd13 As New System.Data.OleDb.OleDbCommand(query, conn1)
                Dim reader13 As OleDbDataReader = cmd13.ExecuteReader
                Dim Encontrado0, Encontrado1 As String

                'identifica el reporte mas reciente para ese toolingid
                reader13.Read()
                Encontrado0 = reader13.GetValue(0) 'trae la fecha
                Encontrado1 = reader13.GetValue(1) 'trae la hora


                Dim access3 As String = "UPDATE INFOLINES SET ESTADO = '" & strDummyState & "', QUITO = 'PorReparar' WHERE FECHA = #" & Encontrado0 & "# AND HORA = #" & Encontrado1 & "#"
                Dim cmd4 As New OleDbCommand(access3, conn1)
                cmd4.ExecuteNonQuery()
                access3 = ""
                conn1.Close()
                '-------------TERMINA DE IDENTIFICAR -----------
            End If

            'Manda el Tooling a R cuando deshabilitas la linea
            If StrFileNameTbl.Contains("R") Then

                Dim access As String
                access = "UPDATE TOOLLINES SET STATUS = 'R' where TOOLINGID='" & StrTool & "'"
                db.ModifyQuery(access)
                db.CloseConnection()
            End If

            strEstado = "X"
            strDummyLine = SPath
            If strDummyLine.Contains("01") Then
                UpdateTableStatusLine1(StrFileNameTbl)
            End If

            If strDummyLine.Contains("02") Then
                UpdateTableStatusLine2(StrFileNameTbl)
            End If

            If strDummyLine.Contains("03") Then
                UpdateTableStatusLine3(StrFileNameTbl)
            End If

            If strDummyLine.Contains("04") Then
                UpdateTableStatusLine4(StrFileNameTbl)
            End If

            If strDummyLine.Contains("05") Then
                UpdateTableStatusLine5(StrFileNameTbl)
            End If

            If strDummyLine.Contains("06") Then
                UpdateTableStatusLine6(StrFileNameTbl)
            End If

            If strDummyLine.Contains("07") Then
                UpdateTableStatusLine7(StrFileNameTbl)
            End If

            If strDummyLine.Contains("08") Then
                UpdateTableStatusLine8(StrFileNameTbl)
            End If

            If strDummyLine.Contains("09") Then
                UpdateTableStatusLine9(StrFileNameTbl)
            End If

            If strDummyLine.Contains("10") Then
                UpdateTableStatusLine10(StrFileNameTbl)
            End If

            If strDummyLine.Contains("11") Then
                UpdateTableStatusLine10(StrFileNameTbl)
            End If

            If strDummyLine.Contains("13") Then
                UpdateTableStatusLine10(StrFileNameTbl)
            End If
            ' errores  
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try

        UpdateGrid()

LastLine:
    End Function

    Public Function UpdateTableStatusLine1(ByVal StrFileNameTbl As String) As Double  'Actualiza los colores de los botones
        Dim strDummyLine, strDummyState, strDummyUsage As String

        Dim charLenght As Integer
        charLenght = StrFileNameTbl.Length

        'Separa el String
        strDummyLine = StrFileNameTbl.Remove(3, charLenght - 3)
        strDummyState = Mid(StrFileNameTbl, 4, 1)
        strDummyUsage = StrFileNameTbl.Remove(0, 4)

        Try
            If StrFileNameTbl.Contains("01") Then
                If StrFileNameTbl.Contains("01A") Then
                    UsageTPA1 = Convert.ToDouble(strDummyUsage)
                    If strDummyState = "U" Or strDummyState = "G" Then
                        LPA1.BackColor = Color.Green
                        LPA1S.BackColor = Color.Green
                        Ajustes.L01A.BackColor = Color.Green
                         PA1T.ForeColor = Color.Black
                    End If
                    If strDummyState = "Y" Then
                        LPA1.BackColor = Color.Yellow
                        LPA1S.BackColor = Color.Yellow
                        Ajustes.L01A.BackColor = Color.Yellow
                    End If
                    If strDummyState = "P" Then
                        LPA1.BackColor = Color.DodgerBlue
                        LPA1S.BackColor = Color.DodgerBlue
                        Ajustes.L01A.BackColor = Color.DodgerBlue
                    End If
                    If strDummyState = "R" Then
                        LPA1.BackColor = Color.Red
                        LPA1S.BackColor = Color.Red
                        Ajustes.L01A.BackColor = Color.Red
                        PA1T.ForeColor = Color.White
                    End If
                    If strDummyState = "D" Then
                        LPA1.BackColor = Color.Blue
                        LPA1S.BackColor = Color.Blue
                        Ajustes.L01A.BackColor = Color.Blue
                    End If
                End If
                If StrFileNameTbl.Contains("01E") Then
                    UsageTPE1 = Convert.ToDouble(strDummyUsage)
                    If strDummyState = "U" Or strDummyState = "G" Then
                        LPE1.BackColor = Color.Green
                        LPE1S.BackColor = Color.Green
                        Ajustes.L01E.BackColor = Color.Green
                        PE1T.ForeColor = Color.Black
                    End If
                    If strDummyState = "Y" Then
                        LPE1.BackColor = Color.Yellow
                        LPE1S.BackColor = Color.Yellow
                        Ajustes.L01E.BackColor = Color.Yellow
                    End If
                    If strDummyState = "P" Then
                        LPE1.BackColor = Color.DodgerBlue
                        LPE1S.BackColor = Color.DodgerBlue
                        Ajustes.L01E.BackColor = Color.DodgerBlue
                    End If
                    If strDummyState = "R" Then
                        LPE1.BackColor = Color.Red
                        LPE1S.BackColor = Color.Red
                        Ajustes.L01E.BackColor = Color.Red
                        PE1T.ForeColor = Color.White
                    End If
                    If strDummyState = "D" Then
                        LPE1.BackColor = Color.Blue
                        LPE1S.BackColor = Color.Blue
                        Ajustes.L01E.BackColor = Color.Blue
                    End If
                End If

                If StrFileNameTbl.Contains("01V") Then
                    UsageTPV1 = Convert.ToDouble(strDummyUsage)
                    If strDummyState = "U" Or strDummyState = "G" Then
                        LPV1.BackColor = Color.Green
                        LPV1S.BackColor = Color.Green
                        Ajustes.L01V.BackColor = Color.Green
                        PV1T.ForeColor = Color.Black
                    End If
                    If strDummyState = "Y" Then
                        LPV1.BackColor = Color.Yellow
                        LPV1S.BackColor = Color.Yellow
                        Ajustes.L01V.BackColor = Color.Yellow
                    End If
                    If strDummyState = "P" Then
                        LPV1.BackColor = Color.DodgerBlue
                        LPV1S.BackColor = Color.DodgerBlue
                        Ajustes.L01V.BackColor = Color.DodgerBlue
                    End If
                    If strDummyState = "R" Then
                        LPV1.BackColor = Color.Red
                        LPV1S.BackColor = Color.Red
                        Ajustes.L01V.BackColor = Color.Red
                        PV1T.ForeColor = Color.White
                    End If
                    If strDummyState = "D" Then
                        LPV1.BackColor = Color.Blue
                        LPV1S.BackColor = Color.Blue
                        Ajustes.L01V.BackColor = Color.Blue
                    End If
                End If
            End If
            ' errores  
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try

LastLine:
    End Function
    Public Function UpdateTableStatusLine2(ByVal StrFileNameTbl As String) As Double  'Actualiza los colores de los botones
        Dim strDummyLine, strDummyState, strDummyUsage As String

        Dim charLenght As Integer
        charLenght = StrFileNameTbl.Length


        strDummyLine = StrFileNameTbl.Remove(3, charLenght - 3)
        strDummyState = Mid(StrFileNameTbl, 4, 1)
        strDummyUsage = StrFileNameTbl.Remove(0, 4)

        Try
            If StrFileNameTbl.Contains("02") Then
                If StrFileNameTbl.Contains("02A") Then
                    UsageTPA2 = Convert.ToDouble(strDummyUsage)
                    If strDummyState = "U" Or strDummyState = "G" Then
                        LPA2.BackColor = Color.Green
                        LPA2S.BackColor = Color.Green
                        Ajustes.L02A.BackColor = Color.Green
                        PA2T.ForeColor = Color.Black
                    End If
                    If strDummyState = "Y" Then
                        LPA2.BackColor = Color.Yellow
                        LPA2S.BackColor = Color.Yellow
                        Ajustes.L02A.BackColor = Color.Yellow
                    End If
                    If strDummyState = "P" Then
                        LPA2.BackColor = Color.DodgerBlue
                        LPA2S.BackColor = Color.DodgerBlue
                        Ajustes.L02A.BackColor = Color.DodgerBlue
                    End If
                    If strDummyState = "R" Then
                        LPA2.BackColor = Color.Red
                        LPA2S.BackColor = Color.Red
                        Ajustes.L02A.BackColor = Color.Red
                        PA2T.ForeColor = Color.White
                    End If
                    If strDummyState = "D" Then
                        LPA2.BackColor = Color.Blue
                        LPA2S.BackColor = Color.Blue
                        Ajustes.L02A.BackColor = Color.Blue
                    End If
                End If
                If StrFileNameTbl.Contains("02E") Then
                    UsageTPE2 = Convert.ToDouble(strDummyUsage)
                    If strDummyState = "U" Or strDummyState = "G" Then
                        LPE2.BackColor = Color.Green
                        LPE2S.BackColor = Color.Green
                        Ajustes.L02E.BackColor = Color.Green
                        PE2T.ForeColor = Color.Black
                    End If
                    If strDummyState = "Y" Then
                        LPE2.BackColor = Color.Yellow
                        LPE2S.BackColor = Color.Yellow
                        Ajustes.L02E.BackColor = Color.Yellow
                    End If
                    If strDummyState = "P" Then
                        LPE2.BackColor = Color.DodgerBlue
                        LPE2S.BackColor = Color.DodgerBlue
                        Ajustes.L02E.BackColor = Color.DodgerBlue
                    End If
                    If strDummyState = "R" Then
                        LPE2.BackColor = Color.Red
                        LPE2S.BackColor = Color.Red
                        Ajustes.L02E.BackColor = Color.Red
                        PE2T.ForeColor = Color.White
                    End If
                    If strDummyState = "D" Then
                        LPE2.BackColor = Color.Blue
                        LPE2S.BackColor = Color.Blue
                        Ajustes.L02E.BackColor = Color.Blue
                    End If
                End If

                If StrFileNameTbl.Contains("02V") Then
                    UsageTPV2 = Convert.ToDouble(strDummyUsage)
                    If strDummyState = "U" Or strDummyState = "G" Then
                        LPV2.BackColor = Color.Green
                        LPV2S.BackColor = Color.Green
                        Ajustes.L02V.BackColor = Color.Green
                        PV2T.ForeColor = Color.Black
                    End If
                    If strDummyState = "Y" Then
                        LPV2.BackColor = Color.Yellow
                        LPV2S.BackColor = Color.Yellow
                        Ajustes.L02V.BackColor = Color.Yellow
                    End If
                    If strDummyState = "P" Then
                        LPV2.BackColor = Color.DodgerBlue
                        LPV2S.BackColor = Color.DodgerBlue
                        Ajustes.L02V.BackColor = Color.DodgerBlue
                    End If
                    If strDummyState = "R" Then
                        LPV2.BackColor = Color.Red
                        LPV2S.BackColor = Color.Red
                        Ajustes.L02V.BackColor = Color.Red
                        PV2T.ForeColor = Color.White
                    End If
                    If strDummyState = "D" Then
                        LPV2.BackColor = Color.Blue
                        LPV2S.BackColor = Color.Blue
                        Ajustes.L02V.BackColor = Color.Blue
                    End If
                End If
            End If
            ' errores  
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try

LastLine:
    End Function
    Public Function UpdateTableStatusLine3(ByVal StrFileNameTbl As String) As Double  'Actualiza los colores de los botones
        Dim strDummyLine, strDummyState, strDummyUsage As String

        Dim charLenght As Integer
        charLenght = StrFileNameTbl.Length


        strDummyLine = StrFileNameTbl.Remove(3, charLenght - 3)
        strDummyState = Mid(StrFileNameTbl, 4, 1)
        strDummyUsage = StrFileNameTbl.Remove(0, 4)

        Try
            If StrFileNameTbl.Contains("03") Then
                If StrFileNameTbl.Contains("03A") Then
                    UsageTPA3 = Convert.ToDouble(strDummyUsage)
                    If strDummyState = "U" Or strDummyState = "G" Then
                        LPA3.BackColor = Color.Green
                        LPA3S.BackColor = Color.Green
                        Ajustes.L03A.BackColor = Color.Green
                        PA3T.ForeColor = Color.Black
                    End If
                    If strDummyState = "Y" Then
                        LPA3.BackColor = Color.Yellow
                        LPA3S.BackColor = Color.Yellow
                        Ajustes.L03A.BackColor = Color.Yellow
                    End If
                    If strDummyState = "P" Then
                        LPA3.BackColor = Color.DodgerBlue
                        LPA3S.BackColor = Color.DodgerBlue
                        Ajustes.L03A.BackColor = Color.DodgerBlue
                    End If
                    If strDummyState = "R" Then
                        LPA3.BackColor = Color.Red
                        LPA3S.BackColor = Color.Red
                        Ajustes.L03A.BackColor = Color.Red
                        PA3T.ForeColor = Color.White
                    End If
                    If strDummyState = "D" Then
                        LPA3.BackColor = Color.Blue
                        LPA3S.BackColor = Color.Blue
                        Ajustes.L03A.BackColor = Color.Blue
                    End If
                End If
                If StrFileNameTbl.Contains("03E") Then
                    UsageTPE3 = Convert.ToDouble(strDummyUsage)
                    If strDummyState = "U" Or strDummyState = "G" Then
                        LPE3.BackColor = Color.Green
                        LPE3S.BackColor = Color.Green
                        Ajustes.L03E.BackColor = Color.Green
                        PE3T.ForeColor = Color.Black
                    End If
                    If strDummyState = "Y" Then
                        LPE3.BackColor = Color.Yellow
                        LPE3S.BackColor = Color.Yellow
                        Ajustes.L03E.BackColor = Color.Yellow
                    End If
                    If strDummyState = "P" Then
                        LPE3.BackColor = Color.DodgerBlue
                        LPE3S.BackColor = Color.DodgerBlue
                        Ajustes.L03E.BackColor = Color.DodgerBlue
                    End If
                    If strDummyState = "R" Then
                        LPE3.BackColor = Color.Red
                        LPE3S.BackColor = Color.Red
                        Ajustes.L03E.BackColor = Color.Red
                        PE3T.ForeColor = Color.White
                    End If
                    If strDummyState = "D" Then
                        LPE3.BackColor = Color.Blue
                        LPE3S.BackColor = Color.Blue
                        Ajustes.L03E.BackColor = Color.Blue
                    End If
                End If

                If StrFileNameTbl.Contains("03V") Then
                    UsageTPV3 = Convert.ToDouble(strDummyUsage)
                    If strDummyState = "U" Or strDummyState = "G" Then
                        LPV3.BackColor = Color.Green
                        LPV3S.BackColor = Color.Green
                        Ajustes.L03V.BackColor = Color.Green
                        PV3T.ForeColor = Color.Black
                    End If
                    If strDummyState = "Y" Then
                        LPV3.BackColor = Color.Yellow
                        LPV3S.BackColor = Color.Yellow
                        Ajustes.L03V.BackColor = Color.Yellow
                    End If
                    If strDummyState = "P" Then
                        LPV3.BackColor = Color.DodgerBlue
                        LPV3S.BackColor = Color.DodgerBlue
                        Ajustes.L03V.BackColor = Color.DodgerBlue
                    End If
                    If strDummyState = "R" Then
                        LPV3.BackColor = Color.Red
                        LPV3S.BackColor = Color.Red
                        Ajustes.L03V.BackColor = Color.Red
                        PV3T.ForeColor = Color.White
                    End If
                    If strDummyState = "D" Then
                        LPV3.BackColor = Color.Blue
                        LPV3S.BackColor = Color.Blue
                        Ajustes.L03V.BackColor = Color.Blue
                    End If
                End If
            End If
            ' errores  
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try

LastLine:
    End Function
    Public Function UpdateTableStatusLine4(ByVal StrFileNameTbl As String) As Double  'Actualiza los colores de los botones
        Dim strDummyLine, strDummyState, strDummyUsage As String

        Dim charLenght As Integer
        charLenght = StrFileNameTbl.Length

        strDummyLine = StrFileNameTbl.Remove(3, charLenght - 3)
        strDummyState = Mid(StrFileNameTbl, 4, 1)
        strDummyUsage = StrFileNameTbl.Remove(0, 4)

        Try
            If StrFileNameTbl.Contains("04") Then
                If StrFileNameTbl.Contains("04A") Then
                    UsageTPA4 = Convert.ToDouble(strDummyUsage)
                    If strDummyState = "U" Or strDummyState = "G" Then
                        LPA4.BackColor = Color.Green
                        LPA4S.BackColor = Color.Green
                        Ajustes.L04A.BackColor = Color.Green
                        PA4T.ForeColor = Color.Black
                    End If
                    If strDummyState = "Y" Then
                        LPA4.BackColor = Color.Yellow
                        LPA4S.BackColor = Color.Yellow
                        Ajustes.L04A.BackColor = Color.Yellow
                    End If
                    If strDummyState = "P" Then
                        LPA4.BackColor = Color.DodgerBlue
                        LPA4S.BackColor = Color.DodgerBlue
                        Ajustes.L04A.BackColor = Color.DodgerBlue
                    End If
                    If strDummyState = "R" Then
                        LPA4.BackColor = Color.Red
                        LPA4S.BackColor = Color.Red
                        Ajustes.L04A.BackColor = Color.Red
                        PA4T.ForeColor = Color.White
                    End If
                    If strDummyState = "D" Then
                        LPA4.BackColor = Color.Blue
                        LPA4S.BackColor = Color.Blue
                        Ajustes.L04A.BackColor = Color.Blue
                    End If
                End If
                If StrFileNameTbl.Contains("04E") Then
                    UsageTPE4 = Convert.ToDouble(strDummyUsage)
                    If strDummyState = "U" Or strDummyState = "G" Then
                        LPE4.BackColor = Color.Green
                        LPE4S.BackColor = Color.Green
                        Ajustes.L04E.BackColor = Color.Green
                        PE4T.ForeColor = Color.Black
                    End If
                    If strDummyState = "Y" Then
                        LPE4.BackColor = Color.Yellow
                        LPE4S.BackColor = Color.Yellow
                        Ajustes.L04E.BackColor = Color.Yellow
                    End If
                    If strDummyState = "P" Then
                        LPE4.BackColor = Color.DodgerBlue
                        LPE4S.BackColor = Color.DodgerBlue
                        Ajustes.L04E.BackColor = Color.DodgerBlue
                    End If
                    If strDummyState = "R" Then
                        LPE4.BackColor = Color.Red
                        LPE4S.BackColor = Color.Red
                        Ajustes.L04E.BackColor = Color.Red
                        PE4T.ForeColor = Color.White
                    End If
                    If strDummyState = "D" Then
                        LPE4.BackColor = Color.Blue
                        LPE4S.BackColor = Color.Blue
                        Ajustes.L04E.BackColor = Color.Blue
                    End If
                End If

                If StrFileNameTbl.Contains("04V") Then
                    UsageTPV4 = Convert.ToDouble(strDummyUsage)
                    If strDummyState = "U" Or strDummyState = "G" Then
                        LPV4.BackColor = Color.Green
                        LPV4S.BackColor = Color.Green
                        Ajustes.L04V.BackColor = Color.Green
                        PV4T.ForeColor = Color.Black
                    End If
                    If strDummyState = "Y" Then
                        LPV4.BackColor = Color.Yellow
                        LPV4S.BackColor = Color.Yellow
                        Ajustes.L04V.BackColor = Color.Yellow
                    End If
                    If strDummyState = "P" Then
                        LPV4.BackColor = Color.DodgerBlue
                        LPV4S.BackColor = Color.DodgerBlue
                        Ajustes.L04V.BackColor = Color.DodgerBlue
                    End If
                    If strDummyState = "R" Then
                        LPV4.BackColor = Color.Red
                        LPV4S.BackColor = Color.Red
                        Ajustes.L04V.BackColor = Color.Red
                        PV4T.ForeColor = Color.White
                    End If
                    If strDummyState = "D" Then
                        LPV4.BackColor = Color.Blue
                        LPV4S.BackColor = Color.Blue
                        Ajustes.L04V.BackColor = Color.Blue
                    End If
                End If
            End If
            ' errores  
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try

LastLine:
    End Function
    Public Function UpdateTableStatusLine5(ByVal StrFileNameTbl As String) As Double  'Actualiza los colores de los botones
        Dim strDummyLine, strDummyState, strDummyUsage As String

        Dim charLenght As Integer
        charLenght = StrFileNameTbl.Length

        strDummyLine = StrFileNameTbl.Remove(3, charLenght - 3)
        strDummyState = Mid(StrFileNameTbl, 4, 1)
        strDummyUsage = StrFileNameTbl.Remove(0, 4)

        Try
            If StrFileNameTbl.Contains("05") Then
                If StrFileNameTbl.Contains("05A") Then
                    UsageTPA5 = Convert.ToDouble(strDummyUsage)
                    If strDummyState = "U" Or strDummyState = "G" Then
                        LPA5.BackColor = Color.Green
                        LPA5S.BackColor = Color.Green
                        Ajustes.L05A.BackColor = Color.Green
                        PA5T.ForeColor = Color.Black
                    End If
                    If strDummyState = "Y" Then
                        LPA5.BackColor = Color.Yellow
                        LPA5S.BackColor = Color.Yellow
                        Ajustes.L05A.BackColor = Color.Yellow
                    End If
                    If strDummyState = "P" Then
                        LPA5.BackColor = Color.DodgerBlue
                        LPA5S.BackColor = Color.DodgerBlue
                        Ajustes.L05A.BackColor = Color.DodgerBlue
                    End If
                    If strDummyState = "R" Then
                        LPA5.BackColor = Color.Red
                        LPA5S.BackColor = Color.Red
                        Ajustes.L05A.BackColor = Color.Red
                        PA5T.ForeColor = Color.White
                    End If
                    If strDummyState = "D" Then
                        LPA5.BackColor = Color.Blue
                        LPA5S.BackColor = Color.Blue
                        Ajustes.L05A.BackColor = Color.Blue
                    End If
                End If
                If StrFileNameTbl.Contains("05E") Then
                    UsageTPE5 = Convert.ToDouble(strDummyUsage)
                    If strDummyState = "U" Or strDummyState = "G" Then
                        LPE5.BackColor = Color.Green
                        LPE5S.BackColor = Color.Green
                        Ajustes.L05E.BackColor = Color.Green
                        PE5T.ForeColor = Color.Black
                    End If
                    If strDummyState = "Y" Then
                        LPE5.BackColor = Color.Yellow
                        LPE5S.BackColor = Color.Yellow
                        Ajustes.L05E.BackColor = Color.Yellow
                    End If
                    If strDummyState = "P" Then
                        LPE5.BackColor = Color.DodgerBlue
                        LPE5S.BackColor = Color.DodgerBlue
                        Ajustes.L05E.BackColor = Color.DodgerBlue
                    End If
                    If strDummyState = "R" Then
                        LPE5.BackColor = Color.Red
                        LPE5S.BackColor = Color.Red
                        Ajustes.L05E.BackColor = Color.Red
                        PE5T.ForeColor = Color.White
                    End If
                    If strDummyState = "D" Then
                        LPE5.BackColor = Color.Blue
                        LPE5S.BackColor = Color.Blue
                        Ajustes.L05E.BackColor = Color.Blue
                    End If
                End If

                If StrFileNameTbl.Contains("05V") Then
                    UsageTPV5 = Convert.ToDouble(strDummyUsage)
                    If strDummyState = "U" Or strDummyState = "G" Then
                        LPV5.BackColor = Color.Green
                        LPV5S.BackColor = Color.Green
                        Ajustes.L05V.BackColor = Color.Green
                        PV5T.ForeColor = Color.Black
                    End If
                    If strDummyState = "Y" Then
                        LPV5.BackColor = Color.Yellow
                        LPV5S.BackColor = Color.Yellow
                        Ajustes.L05V.BackColor = Color.Yellow
                    End If
                    If strDummyState = "P" Then
                        LPV5.BackColor = Color.DodgerBlue
                        LPV5S.BackColor = Color.DodgerBlue
                        Ajustes.L05V.BackColor = Color.DodgerBlue
                    End If
                    If strDummyState = "R" Then
                        LPV5.BackColor = Color.Red
                        LPV5S.BackColor = Color.Red
                        Ajustes.L05V.BackColor = Color.Red
                        PV5T.ForeColor = Color.White
                    End If
                    If strDummyState = "D" Then
                        LPV5.BackColor = Color.Blue
                        LPV5S.BackColor = Color.Blue
                        Ajustes.L05V.BackColor = Color.Blue
                    End If
                End If
            End If
            ' errores  
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try

LastLine:
    End Function
    Public Function UpdateTableStatusLine6(ByVal StrFileNameTbl As String) As Double  'Actualiza los colores de los botones
        Dim strDummyLine, strDummyState, strDummyUsage As String

        Dim charLenght As Integer
        charLenght = StrFileNameTbl.Length

        strDummyLine = StrFileNameTbl.Remove(3, charLenght - 3)
        strDummyState = Mid(StrFileNameTbl, 4, 1)
        strDummyUsage = StrFileNameTbl.Remove(0, 4)

        Try
            If StrFileNameTbl.Contains("06") Then
                If StrFileNameTbl.Contains("06A") Then
                    UsageTPA6 = Convert.ToDouble(strDummyUsage)
                    If strDummyState = "U" Or strDummyState = "G" Then
                        LPA6.BackColor = Color.Green
                        LPA6S.BackColor = Color.Green
                        Ajustes.L06A.BackColor = Color.Green
                        PA6T.ForeColor = Color.Black
                    End If
                    If strDummyState = "Y" Then
                        LPA6.BackColor = Color.Yellow
                        LPA6S.BackColor = Color.Yellow
                        Ajustes.L06A.BackColor = Color.Yellow
                    End If
                    If strDummyState = "P" Then
                        LPA6.BackColor = Color.DodgerBlue
                        LPA6S.BackColor = Color.DodgerBlue
                        Ajustes.L06A.BackColor = Color.DodgerBlue
                    End If
                    If strDummyState = "R" Then
                        LPA6.BackColor = Color.Red
                        LPA6S.BackColor = Color.Red
                        Ajustes.L06A.BackColor = Color.Red
                        PA6T.ForeColor = Color.White
                    End If
                    If strDummyState = "D" Then
                        LPA6.BackColor = Color.Blue
                        LPA6S.BackColor = Color.Blue
                        Ajustes.L06A.BackColor = Color.Blue
                    End If
                End If
                If StrFileNameTbl.Contains("06E") Then
                    UsageTPE6 = Convert.ToDouble(strDummyUsage)
                    If strDummyState = "U" Or strDummyState = "G" Then
                        LPE6.BackColor = Color.Green
                        LPE6S.BackColor = Color.Green
                        Ajustes.L06E.BackColor = Color.Green
                        PE6T.ForeColor = Color.Black
                    End If
                    If strDummyState = "Y" Then
                        LPE6.BackColor = Color.Yellow
                        LPE6S.BackColor = Color.Yellow
                        Ajustes.L06E.BackColor = Color.Yellow
                    End If
                    If strDummyState = "P" Then
                        LPE6.BackColor = Color.DodgerBlue
                        LPE6S.BackColor = Color.DodgerBlue
                        Ajustes.L06E.BackColor = Color.DodgerBlue
                    End If
                    If strDummyState = "R" Then
                        LPE6.BackColor = Color.Red
                        LPE6S.BackColor = Color.Red
                        Ajustes.L06E.BackColor = Color.Red
                        PE6T.ForeColor = Color.White
                    End If
                    If strDummyState = "D" Then
                        LPE6.BackColor = Color.Blue
                        LPE6S.BackColor = Color.Blue
                        Ajustes.L06E.BackColor = Color.Blue
                    End If
                End If

                If StrFileNameTbl.Contains("06V") Then
                    UsageTPV6 = Convert.ToDouble(strDummyUsage)
                    If strDummyState = "U" Or strDummyState = "G" Then
                        LPV6.BackColor = Color.Green
                        LPV6S.BackColor = Color.Green
                        Ajustes.L06V.BackColor = Color.Green
                        PV6T.ForeColor = Color.Black
                    End If
                    If strDummyState = "Y" Then
                        LPV6.BackColor = Color.Yellow
                        LPV6S.BackColor = Color.Yellow
                        Ajustes.L06V.BackColor = Color.Yellow
                    End If
                    If strDummyState = "P" Then
                        LPV6.BackColor = Color.DodgerBlue
                        LPV6S.BackColor = Color.DodgerBlue
                        Ajustes.L06V.BackColor = Color.DodgerBlue
                    End If
                    If strDummyState = "R" Then
                        LPV6.BackColor = Color.Red
                        LPV6S.BackColor = Color.Red
                        Ajustes.L06V.BackColor = Color.Red
                        PV6T.ForeColor = Color.White
                    End If
                    If strDummyState = "D" Then
                        LPV6.BackColor = Color.Blue
                        LPV6S.BackColor = Color.Blue
                        Ajustes.L06V.BackColor = Color.Blue
                    End If
                End If
            End If
            ' errores  
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try

LastLine:
    End Function
    Public Function UpdateTableStatusLine7(ByVal StrFileNameTbl As String) As Double  'Actualiza los colores de los botones
        Dim strDummyLine, strDummyState, strDummyUsage As String

        Dim charLenght As Integer
        charLenght = StrFileNameTbl.Length

        strDummyLine = StrFileNameTbl.Remove(3, charLenght - 3)
        strDummyState = Mid(StrFileNameTbl, 4, 1)
        strDummyUsage = StrFileNameTbl.Remove(0, 4)

        Try
            If StrFileNameTbl.Contains("07") Then
                If StrFileNameTbl.Contains("07A") Then
                    UsageTPA7 = Convert.ToDouble(strDummyUsage)
                    If strDummyState = "U" Or strDummyState = "G" Then
                        LPA7.BackColor = Color.Green
                        LPA7S.BackColor = Color.Green
                        Ajustes.L07A.BackColor = Color.Green
                        PA7T.ForeColor = Color.Black
                    End If
                    If strDummyState = "Y" Then
                        LPA7.BackColor = Color.Yellow
                        LPA7S.BackColor = Color.Yellow
                        Ajustes.L07A.BackColor = Color.Yellow
                    End If
                    If strDummyState = "P" Then
                        LPA7.BackColor = Color.DodgerBlue
                        LPA7S.BackColor = Color.DodgerBlue
                        Ajustes.L07A.BackColor = Color.DodgerBlue
                    End If
                    If strDummyState = "R" Then
                        LPA7.BackColor = Color.Red
                        LPA7S.BackColor = Color.Red
                        Ajustes.L07A.BackColor = Color.Red
                        PA7T.ForeColor = Color.White
                    End If
                    If strDummyState = "D" Then
                        LPA7.BackColor = Color.Blue
                        LPA7S.BackColor = Color.Blue
                        Ajustes.L07A.BackColor = Color.Blue
                    End If
                End If
                If StrFileNameTbl.Contains("07E") Then
                    UsageTPE7 = Convert.ToDouble(strDummyUsage)
                    If strDummyState = "U" Or strDummyState = "G" Then
                        LPE7.BackColor = Color.Green
                        LPE7S.BackColor = Color.Green
                        Ajustes.L07E.BackColor = Color.Green
                        PE7T.ForeColor = Color.Black
                    End If
                    If strDummyState = "Y" Then
                        LPE7.BackColor = Color.Yellow
                        LPE7S.BackColor = Color.Yellow
                        Ajustes.L07E.BackColor = Color.Yellow
                    End If
                    If strDummyState = "P" Then
                        LPE7.BackColor = Color.DodgerBlue
                        LPE7S.BackColor = Color.DodgerBlue
                        Ajustes.L07E.BackColor = Color.DodgerBlue
                    End If
                    If strDummyState = "R" Then
                        LPE7.BackColor = Color.Red
                        LPE7S.BackColor = Color.Red
                        Ajustes.L07E.BackColor = Color.Red
                        PE7T.ForeColor = Color.White
                    End If
                    If strDummyState = "D" Then
                        LPE7.BackColor = Color.Blue
                        LPE7S.BackColor = Color.Blue
                        Ajustes.L07E.BackColor = Color.Blue
                    End If
                End If

                If StrFileNameTbl.Contains("07V") Then
                    UsageTPV7 = Convert.ToDouble(strDummyUsage)
                    If strDummyState = "U" Or strDummyState = "G" Then
                        LPV7.BackColor = Color.Green
                        LPV7S.BackColor = Color.Green
                        Ajustes.L07V.BackColor = Color.Green
                        PV7T.ForeColor = Color.Black
                    End If
                    If strDummyState = "Y" Then
                        LPV7.BackColor = Color.Yellow
                        LPV7S.BackColor = Color.Yellow
                        Ajustes.L07V.BackColor = Color.Yellow
                    End If
                    If strDummyState = "P" Then
                        LPV7.BackColor = Color.DodgerBlue
                        LPV7S.BackColor = Color.DodgerBlue
                        Ajustes.L07V.BackColor = Color.DodgerBlue
                    End If
                    If strDummyState = "R" Then
                        LPV7.BackColor = Color.Red
                        LPV7S.BackColor = Color.Red
                        Ajustes.L07V.BackColor = Color.Red
                        PV7T.ForeColor = Color.White
                    End If
                    If strDummyState = "D" Then
                        LPV7.BackColor = Color.Blue
                        LPV7S.BackColor = Color.Blue
                        Ajustes.L07V.BackColor = Color.Blue
                    End If
                End If
            End If
            ' errores  
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try

LastLine:
    End Function

    Public Function UpdateTableStatusLine8(ByVal StrFileNameTbl As String) As Double  'Actualiza los colores de los botones
        Dim strDummyLine, strDummyState, strDummyUsage As String

        Dim charLenght As Integer
        charLenght = StrFileNameTbl.Length

        strDummyLine = StrFileNameTbl.Remove(3, charLenght - 3)
        strDummyState = Mid(StrFileNameTbl, 4, 1)
        strDummyUsage = StrFileNameTbl.Remove(0, 4)

        Try
            If StrFileNameTbl.Contains("08") Then
                If StrFileNameTbl.Contains("08A") Then
                    UsageTPA8 = Convert.ToDouble(strDummyUsage)
                    If strDummyState = "U" Or strDummyState = "G" Then
                        LPA8.BackColor = Color.Green
                        LPA8S.BackColor = Color.Green
                        Ajustes.L08A.BackColor = Color.Green
                        PA8T.ForeColor = Color.Black
                    End If
                    If strDummyState = "Y" Then
                        LPA8.BackColor = Color.Yellow
                        LPA8s.BackColor = Color.Yellow
                        Ajustes.L08A.BackColor = Color.Yellow
                    End If
                    If strDummyState = "P" Then
                        LPA8.BackColor = Color.DodgerBlue
                        LPA8S.BackColor = Color.DodgerBlue
                        Ajustes.L08A.BackColor = Color.DodgerBlue
                    End If
                    If strDummyState = "R" Then
                        LPA8.BackColor = Color.Red
                        LPA8S.BackColor = Color.Red
                        Ajustes.L08A.BackColor = Color.Red
                        PA8T.ForeColor = Color.White
                    End If
                    If strDummyState = "D" Then
                        LPA8.BackColor = Color.Blue
                        LPA8S.BackColor = Color.Blue
                        Ajustes.L08A.BackColor = Color.Blue
                    End If
                End If
                If StrFileNameTbl.Contains("08E") Then
                    UsageTPE8 = Convert.ToDouble(strDummyUsage)
                    If strDummyState = "U" Or strDummyState = "G" Then
                        LPE8.BackColor = Color.Green
                        LPE8S.BackColor = Color.Green
                        Ajustes.L08E.BackColor = Color.Green
                        PE8T.ForeColor = Color.Black
                    End If
                    If strDummyState = "Y" Then
                        LPE8.BackColor = Color.Yellow
                        LPE8S.BackColor = Color.Yellow
                        Ajustes.L08E.BackColor = Color.Yellow
                    End If
                    If strDummyState = "P" Then
                        LPE8.BackColor = Color.DodgerBlue
                        LPE8S.BackColor = Color.DodgerBlue
                        Ajustes.L08E.BackColor = Color.DodgerBlue
                    End If
                    If strDummyState = "R" Then
                        LPE8.BackColor = Color.Red
                        LPE8S.BackColor = Color.Red
                        Ajustes.L08E.BackColor = Color.Red
                        PE8T.ForeColor = Color.White
                    End If
                    If strDummyState = "D" Then
                        LPE8.BackColor = Color.Blue
                        LPE8S.BackColor = Color.Blue
                        Ajustes.L08E.BackColor = Color.Blue
                    End If
                End If

                If StrFileNameTbl.Contains("08V") Then
                    UsageTPV8 = Convert.ToDouble(strDummyUsage)
                    If strDummyState = "U" Or strDummyState = "G" Then
                        LPV8.BackColor = Color.Green
                        LPV8S.BackColor = Color.Green
                        Ajustes.L08V.BackColor = Color.Green
                        PV8T.ForeColor = Color.Black
                    End If
                    If strDummyState = "Y" Then
                        LPV8.BackColor = Color.Yellow
                        LPV8S.BackColor = Color.Yellow
                        Ajustes.L08V.BackColor = Color.Yellow
                    End If
                    If strDummyState = "P" Then
                        LPV8.BackColor = Color.DodgerBlue
                        LPV8S.BackColor = Color.DodgerBlue
                        Ajustes.L08V.BackColor = Color.DodgerBlue
                    End If
                    If strDummyState = "R" Then
                        LPV8.BackColor = Color.Red
                        LPV8S.BackColor = Color.Red
                        Ajustes.L08V.BackColor = Color.Red
                        PV8T.ForeColor = Color.White
                    End If
                    If strDummyState = "D" Then
                        LPV8.BackColor = Color.Blue
                        LPV8S.BackColor = Color.Blue
                        Ajustes.L08V.BackColor = Color.Blue
                    End If
                End If
            End If
            ' errores  
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try

LastLine:
    End Function
    Public Function UpdateTableStatusLine9(ByVal StrFileNameTbl As String) As Double  'Actualiza los colores de los botones
        Dim strDummyLine, strDummyState, strDummyUsage As String

        Dim charLenght As Integer
        charLenght = StrFileNameTbl.Length

        strDummyLine = StrFileNameTbl.Remove(3, charLenght - 3)
        strDummyState = Mid(StrFileNameTbl, 4, 1)
        strDummyUsage = StrFileNameTbl.Remove(0, 4)

        Try
            If StrFileNameTbl.Contains("09") Then
                If StrFileNameTbl.Contains("09A") Then
                    UsageTPA9 = Convert.ToDouble(strDummyUsage)
                    If strDummyState = "U" Or strDummyState = "G" Then
                        LPA9.BackColor = Color.Green
                        LPA9S.BackColor = Color.Green
                        Ajustes.L09A.BackColor = Color.Green
                        PA9T.ForeColor = Color.Black
                    End If
                    If strDummyState = "Y" Then
                        LPA9.BackColor = Color.Yellow
                        LPA9S.BackColor = Color.Yellow
                        Ajustes.L09A.BackColor = Color.Yellow
                    End If
                    If strDummyState = "P" Then
                        LPA9.BackColor = Color.DodgerBlue
                        LPA9S.BackColor = Color.DodgerBlue
                        Ajustes.L09A.BackColor = Color.DodgerBlue
                    End If
                    If strDummyState = "R" Then
                        LPA9.BackColor = Color.Red
                        LPA9S.BackColor = Color.Red
                        Ajustes.L09A.BackColor = Color.Red
                        PA9T.ForeColor = Color.White
                    End If
                    If strDummyState = "D" Then
                        LPA9.BackColor = Color.Blue
                        LPA9S.BackColor = Color.Blue
                        Ajustes.L09A.BackColor = Color.Blue
                    End If
                End If
                If StrFileNameTbl.Contains("09E") Then
                    UsageTPE9 = Convert.ToDouble(strDummyUsage)
                    If strDummyState = "U" Or strDummyState = "G" Then
                        LPE9.BackColor = Color.Green
                        LPE9S.BackColor = Color.Green
                        Ajustes.L09E.BackColor = Color.Green
                        PE9T.ForeColor = Color.Black
                    End If
                    If strDummyState = "Y" Then
                        LPE9.BackColor = Color.Yellow
                        LPE9S.BackColor = Color.Yellow
                        Ajustes.L09E.BackColor = Color.Yellow
                    End If
                    If strDummyState = "P" Then
                        LPE9.BackColor = Color.DodgerBlue
                        LPE9S.BackColor = Color.DodgerBlue
                        Ajustes.L09E.BackColor = Color.DodgerBlue
                    End If
                    If strDummyState = "R" Then
                        LPE9.BackColor = Color.Red
                        LPE9S.BackColor = Color.Red
                        Ajustes.L09E.BackColor = Color.Red
                        PE9T.ForeColor = Color.White
                    End If
                    If strDummyState = "D" Then
                        LPE9.BackColor = Color.Blue
                        LPE9S.BackColor = Color.Blue
                        Ajustes.L09E.BackColor = Color.Blue
                    End If
                End If

                If StrFileNameTbl.Contains("09V") Then
                    UsageTPV9 = Convert.ToDouble(strDummyUsage)
                    If strDummyState = "U" Or strDummyState = "G" Then
                        LPV9.BackColor = Color.Green
                        LPV9S.BackColor = Color.Green
                        Ajustes.L09V.BackColor = Color.Green
                        PV9T.ForeColor = Color.Black
                    End If
                    If strDummyState = "Y" Then
                        LPV9.BackColor = Color.Yellow
                        LPV9S.BackColor = Color.Yellow
                        Ajustes.L09V.BackColor = Color.Yellow
                    End If
                    If strDummyState = "P" Then
                        LPV9.BackColor = Color.DodgerBlue
                        LPV9S.BackColor = Color.DodgerBlue
                        Ajustes.L09V.BackColor = Color.DodgerBlue
                    End If
                    If strDummyState = "R" Then
                        LPV9.BackColor = Color.Red
                        LPV9S.BackColor = Color.Red
                        Ajustes.L09V.BackColor = Color.Red
                        PV9T.ForeColor = Color.White
                    End If
                    If strDummyState = "D" Then
                        LPV9.BackColor = Color.Blue
                        LPV9S.BackColor = Color.Blue
                        Ajustes.L09V.BackColor = Color.Blue
                    End If
                End If
            End If
            ' errores  
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try

LastLine:
    End Function

    Public Function UpdateTableStatusLine10(ByVal StrFileNameTbl As String) As Double  'Actualiza los colores de los botones
        Dim strDummyLine, strDummyState, strDummyUsage As String

        Dim charLenght As Integer
        charLenght = StrFileNameTbl.Length

        strDummyLine = StrFileNameTbl.Remove(3, charLenght - 3)
        strDummyState = Mid(StrFileNameTbl, 4, 1)
        strDummyUsage = StrFileNameTbl.Remove(0, 4)

        Try
            If StrFileNameTbl.Contains("10") Then
                If StrFileNameTbl.Contains("10A") Then
                    UsageTPA10 = Convert.ToDouble(strDummyUsage)
                    If strDummyState = "U" Or strDummyState = "G" Then
                        LPA10.BackColor = Color.Green
                        LPA10S.BackColor = Color.Green
                        Ajustes.L10A.BackColor = Color.Green
                        PA10T.ForeColor = Color.Black
                    End If
                    If strDummyState = "Y" Then
                        LPA10.BackColor = Color.Yellow
                        LPA10S.BackColor = Color.Yellow
                        Ajustes.L10A.BackColor = Color.Yellow
                    End If
                    If strDummyState = "P" Then
                        LPA10.BackColor = Color.DodgerBlue
                        LPA10S.BackColor = Color.DodgerBlue
                        Ajustes.L10A.BackColor = Color.DodgerBlue
                    End If
                    If strDummyState = "R" Then
                        LPA10.BackColor = Color.Red
                        LPA10S.BackColor = Color.Red
                        Ajustes.L10A.BackColor = Color.Red
                        PA10T.ForeColor = Color.White
                    End If
                    If strDummyState = "D" Then
                        LPA10.BackColor = Color.Blue
                        LPA10S.BackColor = Color.Blue
                        Ajustes.L10A.BackColor = Color.Blue
                    End If
                End If
                If StrFileNameTbl.Contains("10E") Then
                    UsageTPE10 = Convert.ToDouble(strDummyUsage)
                    If strDummyState = "U" Or strDummyState = "G" Then
                        LPE10.BackColor = Color.Green
                        LPE10S.BackColor = Color.Green
                        Ajustes.L10E.BackColor = Color.Green
                        PE10T.ForeColor = Color.Black
                    End If
                    If strDummyState = "Y" Then
                        LPE10.BackColor = Color.Yellow
                        LPE10S.BackColor = Color.Yellow
                        Ajustes.L10E.BackColor = Color.Yellow
                    End If
                    If strDummyState = "P" Then
                        LPE10.BackColor = Color.DodgerBlue
                        LPE10S.BackColor = Color.DodgerBlue
                        Ajustes.L10E.BackColor = Color.DodgerBlue
                    End If
                    If strDummyState = "R" Then
                        LPE10.BackColor = Color.Red
                        LPE10S.BackColor = Color.Red
                        Ajustes.L10E.BackColor = Color.Red
                        PE10T.ForeColor = Color.White
                    End If
                    If strDummyState = "D" Then
                        LPE10.BackColor = Color.Blue
                        LPE10S.BackColor = Color.Blue
                        Ajustes.L10E.BackColor = Color.Blue
                    End If
                End If

                If StrFileNameTbl.Contains("10V") Then
                    UsageTPV10 = Convert.ToDouble(strDummyUsage)
                    If strDummyState = "U" Or strDummyState = "G" Then
                        LPV10.BackColor = Color.Green
                        LPV10S.BackColor = Color.Green
                        Ajustes.L10V.BackColor = Color.Green
                        PV10T.ForeColor = Color.Black
                    End If
                    If strDummyState = "Y" Then
                        LPV10.BackColor = Color.Yellow
                        LPV10S.BackColor = Color.Yellow
                        Ajustes.L10V.BackColor = Color.Yellow
                    End If
                    If strDummyState = "P" Then
                        LPV10.BackColor = Color.DodgerBlue
                        LPV10S.BackColor = Color.DodgerBlue
                        Ajustes.L10V.BackColor = Color.DodgerBlue
                    End If
                    If strDummyState = "R" Then
                        LPV10.BackColor = Color.Red
                        LPV10S.BackColor = Color.Red
                        Ajustes.L10V.BackColor = Color.Red
                        PV10T.ForeColor = Color.White
                    End If
                    If strDummyState = "D" Then
                        LPV10.BackColor = Color.Blue
                        LPV10S.BackColor = Color.Blue
                        Ajustes.L10V.BackColor = Color.Blue
                    End If
                End If
            End If
            ' errores  
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try

LastLine:
    End Function

    Public Function UpdateTableStatusLine11(ByVal StrFileNameTbl As String) As Double  'Actualiza los colores de los botones
        Dim strDummyLine, strDummyState, strDummyUsage As String

        Dim charLenght As Integer
        charLenght = StrFileNameTbl.Length

        strDummyLine = StrFileNameTbl.Remove(3, charLenght - 3)
        strDummyState = Mid(StrFileNameTbl, 4, 1)
        strDummyUsage = StrFileNameTbl.Remove(0, 4)

        Try
            If StrFileNameTbl.Contains("11") Then
                If StrFileNameTbl.Contains("11A") Then
                    UsageTPA11 = Convert.ToDouble(strDummyUsage)
                    If strDummyState = "U" Or strDummyState = "G" Then
                        LPA11.BackColor = Color.Green
                        LPA11S.BackColor = Color.Green
                        Ajustes.L11A.BackColor = Color.Green
                        PA11T.ForeColor = Color.Black
                    End If
                    If strDummyState = "Y" Then
                        LPA11.BackColor = Color.Yellow
                        LPA11S.BackColor = Color.Yellow
                        Ajustes.L11A.BackColor = Color.Yellow
                    End If
                    If strDummyState = "P" Then
                        LPA11.BackColor = Color.DodgerBlue
                        LPA11S.BackColor = Color.DodgerBlue
                        Ajustes.L11A.BackColor = Color.DodgerBlue
                    End If
                    If strDummyState = "R" Then
                        LPA11.BackColor = Color.Red
                        LPA11S.BackColor = Color.Red
                        Ajustes.L11A.BackColor = Color.Red
                        PA11T.ForeColor = Color.White
                    End If
                    If strDummyState = "D" Then
                        LPA11.BackColor = Color.Blue
                        LPA11S.BackColor = Color.Blue
                        Ajustes.L11A.BackColor = Color.Blue
                    End If
                End If
                If StrFileNameTbl.Contains("11E") Then
                    UsageTPE11 = Convert.ToDouble(strDummyUsage)
                    If strDummyState = "U" Or strDummyState = "G" Then
                        LPE11.BackColor = Color.Green
                        LPE11S.BackColor = Color.Green
                        Ajustes.L11E.BackColor = Color.Green
                        PE11T.ForeColor = Color.Black
                    End If
                    If strDummyState = "Y" Then
                        LPE11.BackColor = Color.Yellow
                        LPE11S.BackColor = Color.Yellow
                        Ajustes.L11E.BackColor = Color.Yellow
                    End If
                    If strDummyState = "P" Then
                        LPE11.BackColor = Color.DodgerBlue
                        LPE11S.BackColor = Color.DodgerBlue
                        Ajustes.L11E.BackColor = Color.DodgerBlue
                    End If
                    If strDummyState = "R" Then
                        LPE11.BackColor = Color.Red
                        LPE11S.BackColor = Color.Red
                        Ajustes.L11E.BackColor = Color.Red
                        PE11T.ForeColor = Color.White
                    End If
                    If strDummyState = "D" Then
                        LPE11.BackColor = Color.Blue
                        LPE11S.BackColor = Color.Blue
                        Ajustes.L11E.BackColor = Color.Blue
                    End If
                End If

                If StrFileNameTbl.Contains("11V") Then
                    UsageTPV11 = Convert.ToDouble(strDummyUsage)
                    If strDummyState = "U" Or strDummyState = "G" Then
                        LPV11.BackColor = Color.Green
                        LPV11S.BackColor = Color.Green
                        Ajustes.L11V.BackColor = Color.Green
                        PV11T.ForeColor = Color.Black
                    End If
                    If strDummyState = "Y" Then
                        LPV11.BackColor = Color.Yellow
                        LPV11S.BackColor = Color.Yellow
                        Ajustes.L11V.BackColor = Color.Yellow
                    End If
                    If strDummyState = "P" Then
                        LPV11.BackColor = Color.DodgerBlue
                        LPV11S.BackColor = Color.DodgerBlue
                        Ajustes.L11V.BackColor = Color.DodgerBlue
                    End If
                    If strDummyState = "R" Then
                        LPV11.BackColor = Color.Red
                        LPV11S.BackColor = Color.Red
                        Ajustes.L11V.BackColor = Color.Red
                        PV11T.ForeColor = Color.White
                    End If
                    If strDummyState = "D" Then
                        LPV11.BackColor = Color.Blue
                        LPV11S.BackColor = Color.Blue
                        Ajustes.L11V.BackColor = Color.Blue
                    End If
                End If
            End If
            ' errores  
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try

LastLine:
    End Function

    Public Function UpdateTableStatusLine13(ByVal StrFileNameTbl As String) As Double  'Actualiza los colores de los botones
        Dim strDummyLine, strDummyState, strDummyUsage As String

        Dim charLenght As Integer
        charLenght = StrFileNameTbl.Length

        strDummyLine = StrFileNameTbl.Remove(3, charLenght - 3)
        strDummyState = Mid(StrFileNameTbl, 4, 1)
        strDummyUsage = StrFileNameTbl.Remove(0, 4)

        Try
            If StrFileNameTbl.Contains("13") Then
                If StrFileNameTbl.Contains("13A") Then
                    UsageTPA13 = Convert.ToDouble(strDummyUsage)
                    If strDummyState = "U" Or strDummyState = "G" Then
                        LPA13.BackColor = Color.Green
                        LPA13S.BackColor = Color.Green
                        Ajustes.L13A.BackColor = Color.Green
                        PA13T.ForeColor = Color.Black
                    End If
                    If strDummyState = "Y" Then
                        LPA13.BackColor = Color.Yellow
                        LPA13S.BackColor = Color.Yellow
                        Ajustes.L13A.BackColor = Color.Yellow
                    End If
                    If strDummyState = "P" Then
                        LPA13.BackColor = Color.DodgerBlue
                        LPA13S.BackColor = Color.DodgerBlue
                        Ajustes.L13A.BackColor = Color.DodgerBlue
                    End If
                    If strDummyState = "R" Then
                        LPA13.BackColor = Color.Red
                        LPA13S.BackColor = Color.Red
                        Ajustes.L13A.BackColor = Color.Red
                        PA13T.ForeColor = Color.White
                    End If
                    If strDummyState = "D" Then
                        LPA13.BackColor = Color.Blue
                        LPA13S.BackColor = Color.Blue
                        Ajustes.L13A.BackColor = Color.Blue
                    End If
                End If
                If StrFileNameTbl.Contains("13E") Then
                    UsageTPE13 = Convert.ToDouble(strDummyUsage)
                    If strDummyState = "U" Or strDummyState = "G" Then
                        LPE13.BackColor = Color.Green
                        LPE13S.BackColor = Color.Green
                        Ajustes.L13E.BackColor = Color.Green
                        PE13T.ForeColor = Color.Black
                    End If
                    If strDummyState = "Y" Then
                        LPE13.BackColor = Color.Yellow
                        LPE13S.BackColor = Color.Yellow
                        Ajustes.L13E.BackColor = Color.Yellow
                    End If
                    If strDummyState = "P" Then
                        LPE13.BackColor = Color.DodgerBlue
                        LPE13S.BackColor = Color.DodgerBlue
                        Ajustes.L13E.BackColor = Color.DodgerBlue
                    End If
                    If strDummyState = "R" Then
                        LPE13.BackColor = Color.Red
                        LPE13S.BackColor = Color.Red
                        Ajustes.L13E.BackColor = Color.Red
                        PE13T.ForeColor = Color.White
                    End If
                    If strDummyState = "D" Then
                        LPE13.BackColor = Color.Blue
                        LPE13S.BackColor = Color.Blue
                        Ajustes.L13E.BackColor = Color.Blue
                    End If
                End If

                If StrFileNameTbl.Contains("13V") Then
                    UsageTPV13 = Convert.ToDouble(strDummyUsage)
                    If strDummyState = "U" Or strDummyState = "G" Then
                        LPV13.BackColor = Color.Green
                        LPV13S.BackColor = Color.Green
                        Ajustes.L13V.BackColor = Color.Green
                        PV13T.ForeColor = Color.Black
                    End If
                    If strDummyState = "Y" Then
                        LPV13.BackColor = Color.Yellow
                        LPV13S.BackColor = Color.Yellow
                        Ajustes.L13V.BackColor = Color.Yellow
                    End If
                    If strDummyState = "P" Then
                        LPV13.BackColor = Color.DodgerBlue
                        LPV13S.BackColor = Color.DodgerBlue
                        Ajustes.L13V.BackColor = Color.DodgerBlue
                    End If
                    If strDummyState = "R" Then
                        LPV13.BackColor = Color.Red
                        LPV13S.BackColor = Color.Red
                        Ajustes.L13V.BackColor = Color.Red
                        PV13T.ForeColor = Color.White
                    End If
                    If strDummyState = "D" Then
                        LPV13.BackColor = Color.Blue
                        LPV13S.BackColor = Color.Blue
                        Ajustes.L13V.BackColor = Color.Blue
                    End If
                End If
            End If
            ' errores  
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try

LastLine:
    End Function

    Public Function CreateGoodTooling() As Integer
        'crea el archivo TXT los Tooling buenos en la tabla 

        Dim DownTimeCnnStr As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\APP\TOOLING\Data\PINPACK.mdb;Persist Security Info=False;" 'Jet OLEDB:Database" ' Password=INGENIERIA"        
        Dim conn1 As New System.Data.OleDb.OleDbConnection(DownTimeCnnStr)
        Dim SPath As String = "c:\APP\TOOLING\DATA\"
        Dim sContent As String = vbNullString
        Dim dt As New DataTable
        Dim DataSet1 As New DataSet()
        Dim StrTIpTool1 As String
        Dim StrId1 As String
        Dim StrDesc1 As String
        Dim StrTool1 As String
        Dim StrDummy As String
        Dim StUsage As String


        'Declara el archivo de texto de los buenos
        Dim FILE_NAME_ToolOK As String = "C:\APP\TOOLING\Data\ToolOK.TXT"

        'Declara la bandera que usara el Comunica
        '      Dim FILE_NAME_ToolOKflag As String = "C:\APP\TOOLING\Data\ToolOKflag.txt"
        System.IO.File.Delete(FILE_NAME_ToolOK)
        Try

            Dim access As String
            access = "Select * FROM TOOLLINES WHERE TOOLLINES.STATUS= 'G'"

            conn1.Open()
            Dim cmd2 As New System.Data.OleDb.OleDbCommand(access, conn1)
            Dim reader2 As OleDbDataReader = cmd2.ExecuteReader


            If System.IO.File.Exists(FILE_NAME_ToolOK) = False Then
                System.IO.File.Create(FILE_NAME_ToolOK).Dispose()
            End If
            Dim objWrtToolOK As New System.IO.StreamWriter(FILE_NAME_ToolOK, True)

            'Lee toda la tabla con los G y crea el archivo de texto
            While reader2.Read()
                StrTIpTool1 = reader2.GetString(2)
                StrId1 = reader2.GetString(3)
                StrDesc1 = reader2.GetString(4)
                StrTool1 = reader2.GetString(5)
                StUsage = reader2.GetString(6)
                StrDummy = StrTIpTool1 + "," + StrTool1 + "," + StrId1 + "," + StrDesc1 + "," + StUsage
                objWrtToolOK.WriteLine(StrDummy) 'Writes status G from table to ToolOK.txt
            End While
            objWrtToolOK.Close()

            conn1.Close()

        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
            intTPA1 = 0
            intTPE1 = 0
            intTPV1 = 0
        End Try

        'Este flag es solo para el cominuca
        'Dim objWrtToolOKflag As New System.IO.StreamWriter(FILE_NAME_ToolOKflag, True)
        'objWrtToolOKflag.WriteLine("Created ToolOK.txt")
        'objWrtToolOKflag.Close()

    End Function



    Public Function ShowGrid() As Double
        'Este no recuerdo de donde viene C me hce que no esta en uso

        Dim DownTimeCnnStr As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\APP\TOOLING\Data\PINPACK.mdb;Persist Security Info=False;" 'Jet OLEDB:Database" ' Password=INGENIERIA"        
        Dim conn1 As New System.Data.OleDb.OleDbConnection(DownTimeCnnStr)
        Dim query As String = "Select TMUERTO FROM REPORTES WHERE DEPTO='TESTING' AND (AREA ='Palomar' or AREA ='Palomar 33xx' ) and HORA_REPORTE >= #" + InicioTurno + "# AND HORA_TERMINO <= #" + FinTurno + " #"

        Dim SPath As String = "c:\APP\TOOLING\DATA\"
        Dim sContent As String = vbNullString
        Dim sdir As String = "c:\Nueva carpeta"

        Dim dt As New DataTable


        Dim DataSet1 As New DataSet()

        Try


            query = "Select * FROM TOOLLINES"
            Dim OleDBConn1 As System.Data.OleDb.OleDbConnection = New System.Data.OleDb.OleDbConnection(DownTimeCnnStr)
            Dim OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter = New System.Data.OleDb.OleDbDataAdapter(query, OleDBConn1)
            OleDBConn1.Open()

            OleDbDataAdapter1.Fill(DataSet1, "TOOLLINES")
            GridTooling.DataSource = DataSet1.Tables("TOOLLINES")
            OleDBConn1.Close()



        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
            intTPA1 = 0
            intTPE1 = 0
            intTPV1 = 0
        End Try

LastLine:
    End Function

    Private Sub LPA1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LPA1.Click 'Trae la info de lo que esta instalado en cada prensa
        ShowInfoLines("01A") 'jala la info de la tabla

        Ttotal = dblTPA1 'Del tiempo que trae solo para display en formato xx:xx:xx no tiene efecto en la tabla 
        TVida = TimeSpan.FromSeconds(UsageTPA1)
        EdtVida.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")


    End Sub

    Private Sub LPV1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LPV1.Click
        ShowInfoLines("01V")
        Ttotal = dblTPV1
        TVida = TimeSpan.FromSeconds(UsageTPV1)
        EdtVida.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")


    End Sub

    Private Sub LPE1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LPE1.Click
        ShowInfoLines("01E")
        Ttotal = dblTPE1
        TVida = TimeSpan.FromSeconds(UsageTPE1)
        EdtVida.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")


    End Sub

    Private Sub LPA2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LPA2.Click
        ShowInfoLines("02A")
        Ttotal = dblTPA2
        TVida = TimeSpan.FromSeconds(UsageTPA2)
        EdtVida.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")



    End Sub

    Private Sub LPV2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LPV2.Click
        ShowInfoLines("02V")
        Ttotal = dblTPV2
        TVida = TimeSpan.FromSeconds(UsageTPV2)
        EdtVida.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")



    End Sub

    Private Sub LPE2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LPE2.Click
        ShowInfoLines("02E")
        Ttotal = dblTPE2
        TVida = TimeSpan.FromSeconds(UsageTPE2)
        EdtVida.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")



    End Sub

    Private Sub LPA3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LPA3.Click
        ShowInfoLines("03A")
        Ttotal = dblTPA3
        TVida = TimeSpan.FromSeconds(UsageTPA3)
        EdtVida.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")



    End Sub

    Private Sub LPV3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LPV3.Click
        ShowInfoLines("03V")
        Ttotal = dblTPV3
        TVida = TimeSpan.FromSeconds(UsageTPV3)
        EdtVida.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")


    End Sub

    Private Sub LPE3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LPE3.Click
        ShowInfoLines("03E")
        Ttotal = dblTPE3
        TVida = TimeSpan.FromSeconds(UsageTPE3)
        EdtVida.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")



    End Sub

    Private Sub LPA4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LPA4.Click
        ShowInfoLines("04A")
        Ttotal = dblTPA4
        TVida = TimeSpan.FromSeconds(UsageTPA4)
        EdtVida.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")



    End Sub

    Private Sub LPV4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LPV4.Click
        ShowInfoLines("04V")
        Ttotal = dblTPV4
        TVida = TimeSpan.FromSeconds(UsageTPV4)
        EdtVida.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")


    End Sub

    Private Sub LPE4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LPE4.Click
        ShowInfoLines("04E")
        Ttotal = dblTPE4
        TVida = TimeSpan.FromSeconds(UsageTPE4)
        EdtVida.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")


    End Sub

    Private Sub LPA5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LPA5.Click
        ShowInfoLines("05A")
        Ttotal = dblTPA5
        TVida = TimeSpan.FromSeconds(UsageTPA5)
        EdtVida.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")


    End Sub

    Private Sub LPV5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LPV5.Click
        ShowInfoLines("05V")
        Ttotal = dblTPV5
        TVida = TimeSpan.FromSeconds(UsageTPV5)
        EdtVida.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")


    End Sub

    Private Sub LPE5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LPE5.Click
        ShowInfoLines("05E")
        Ttotal = dblTPE5
        TVida = TimeSpan.FromSeconds(UsageTPE5)
        EdtVida.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")


    End Sub

    Private Sub LPA6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LPA6.Click
        ShowInfoLines("06A")
        Ttotal = dblTPA6
        TVida = TimeSpan.FromSeconds(UsageTPA6)
        EdtVida.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")


    End Sub

    Private Sub LPV6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LPV6.Click
        ShowInfoLines("06V")
        Ttotal = dblTPV6
        TVida = TimeSpan.FromSeconds(UsageTPV6)
        EdtVida.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")


    End Sub

    Private Sub LPE6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LPE6.Click
        ShowInfoLines("06E")
        Ttotal = dblTPE6
        TVida = TimeSpan.FromSeconds(UsageTPE6)
        EdtVida.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")


    End Sub

    Private Sub LPA7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LPA7.Click
        ShowInfoLines("07A")
        Ttotal = dblTPA7
        TVida = TimeSpan.FromSeconds(UsageTPA7)
        EdtVida.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")


    End Sub

    Private Sub LPV7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LPV7.Click
        ShowInfoLines("07V")
        Ttotal = dblTPV7
        TVida = TimeSpan.FromSeconds(UsageTPV7)
        EdtVida.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")


    End Sub

    Private Sub LPE7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LPE7.Click
        ShowInfoLines("07E")
        Ttotal = dblTPE7
        TVida = TimeSpan.FromSeconds(UsageTPE7)
        EdtVida.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")


    End Sub

    Private Sub LPA8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LPA8.Click
        ShowInfoLines("08A")
        Ttotal = dblTPA8
        TVida = TimeSpan.FromSeconds(UsageTPA8)
        EdtVida.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")


    End Sub

    Private Sub LPV8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LPV8.Click
        ShowInfoLines("08V")
        Ttotal = dblTPV8
        TVida = TimeSpan.FromSeconds(UsageTPV8)
        EdtVida.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")


    End Sub

    Private Sub LPE8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LPE8.Click
        ShowInfoLines("08E")
        Ttotal = dblTPE8
        TVida = TimeSpan.FromSeconds(UsageTPE8)
        EdtVida.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")


    End Sub
    Private Sub LPA9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LPA9.Click
        ShowInfoLines("09A")
        Ttotal = dblTPA9
        TVida = TimeSpan.FromSeconds(UsageTPA9)
        EdtVida.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")


    End Sub

    Private Sub LPV9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LPV9.Click
        ShowInfoLines("09V")
        Ttotal = dblTPV9
        TVida = TimeSpan.FromSeconds(UsageTPV9)
        EdtVida.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")


    End Sub

    Private Sub LPE9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LPE9.Click
        ShowInfoLines("09E")
        Ttotal = dblTPE9
        TVida = TimeSpan.FromSeconds(UsageTPE9)
        EdtVida.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")


    End Sub

    Private Sub LPA10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LPA10.Click
        ShowInfoLines("10A")
        Ttotal = dblTPA10
        TVida = TimeSpan.FromSeconds(UsageTPA10)
        EdtVida.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")


    End Sub

    Private Sub LPV10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LPV10.Click
        ShowInfoLines("10V")
        Ttotal = dblTPV10
        TVida = TimeSpan.FromSeconds(UsageTPV10)
        EdtVida.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")
    End Sub

    Private Sub LPE10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LPE10.Click
        ShowInfoLines("10E")
        Ttotal = dblTPE10
        TVida = TimeSpan.FromSeconds(UsageTPE10)
        EdtVida.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")
    End Sub


    Private Sub LPA11_Click(sender As System.Object, e As EventArgs) Handles LPA11.Click
        ShowInfoLines("11A")
        Ttotal = dblTPA11
        TVida = TimeSpan.FromSeconds(UsageTPA11)
        EdtVida.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")
    End Sub

    Private Sub LPV11_Click(sender As System.Object, e As EventArgs) Handles LPV11.Click
        ShowInfoLines("11V")
        Ttotal = dblTPV11
        TVida = TimeSpan.FromSeconds(UsageTPV11)
        EdtVida.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")
    End Sub

    Private Sub LPE11_Click(sender As System.Object, e As EventArgs) Handles LPE11.Click
        ShowInfoLines("11E")
        Ttotal = dblTPE11
        TVida = TimeSpan.FromSeconds(UsageTPE11)
        EdtVida.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")

    End Sub

    Private Sub LPA13_Click(sender As System.Object, e As EventArgs) Handles LPA13.Click
        ShowInfoLines("13A")
        Ttotal = dblTPA13
        TVida = TimeSpan.FromSeconds(UsageTPA13)
        EdtVida.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")
    End Sub

    Private Sub LPV13_Click(sender As System.Object, e As EventArgs) Handles LPV13.Click
        ShowInfoLines("13V")
        Ttotal = dblTPV13
        TVida = TimeSpan.FromSeconds(UsageTPV13)
        EdtVida.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")
    End Sub

    Private Sub LPE13_Click(sender As System.Object, e As EventArgs) Handles LPE13.Click
        ShowInfoLines("13E")
        Ttotal = dblTPE13
        TVida = TimeSpan.FromSeconds(UsageTPE13)
        EdtVida.Text = TVida.Hours.ToString.PadLeft(2, "0"c) & ":" & TVida.Minutes.ToString.PadLeft(2, "0c") & ":" & TVida.Seconds.ToString.PadLeft(2, "0c")

    End Sub

    Private Sub Timer4_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        'Actualiza cada segundo la etiqueta de Hora y Dia
        'Muestra el tiempo total del Tooling en cada linea
        If Label5.Text = "D" Then
            EdtTiempoTotal.Text = "DISABLED"
        Else
            Ttotal = Ttotal + 1
            Dim Time As TimeSpan = TimeSpan.FromSeconds(Ttotal)
            EdtTiempoTotal.Text = Time.Hours.ToString.PadLeft(2, "0"c) & ":" & Time.Minutes.ToString.PadLeft(2, "0c") & ":" & Time.Seconds.ToString.PadLeft(2, "0c")
            Label3.Text = ""

            txtUsoE1.Text = Time.Hours.ToString.PadLeft(2, "0"c) & ":" & Time.Minutes.ToString.PadLeft(2, "0c") & ":" & Time.Seconds.ToString.PadLeft(2, "0c")

            txtUsoE2.Text = Time.Hours.ToString.PadLeft(2, "0"c) & ":" & Time.Minutes.ToString.PadLeft(2, "0c") & ":" & Time.Seconds.ToString.PadLeft(2, "0c")

        End If

        '-------------------Inicia Botones con tiempo de Tooling solo como Display -------------------------------
        Dim TimePA1T As TimeSpan = TimeSpan.FromSeconds(dblTPA1)
        PA1T.Text = TimePA1T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePA1T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePA1T.Seconds.ToString.PadLeft(2, "0c")
        PA1T.BackColor = LPA1.BackColor
        PA1TS.Text = TimePA1T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePA1T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePA1T.Seconds.ToString.PadLeft(2, "0c")
        PA1TS.BackColor = LPA1.BackColor
        dblTPA1 = dblTPA1 + 1

        Dim TimePV1T As TimeSpan = TimeSpan.FromSeconds(dblTPV1)
        PV1T.Text = TimePV1T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePV1T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePV1T.Seconds.ToString.PadLeft(2, "0c")
        PV1T.BackColor = LPV1.BackColor
        PV1TS.Text = TimePV1T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePV1T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePV1T.Seconds.ToString.PadLeft(2, "0c")
        PV1TS.BackColor = LPV1.BackColor
        dblTPV1 = dblTPV1 + 1

        Dim TimePE1T As TimeSpan = TimeSpan.FromSeconds(dblTPE1)
        PE1T.Text = TimePE1T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePE1T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePE1T.Seconds.ToString.PadLeft(2, "0c")
        PE1T.BackColor = LPE1.BackColor
        PE1TS.Text = TimePE1T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePE1T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePE1T.Seconds.ToString.PadLeft(2, "0c")
        PE1TS.BackColor = LPE1.BackColor
        dblTPE1 = dblTPE1 + 1

        Dim TimePA2T As TimeSpan = TimeSpan.FromSeconds(dblTPA2)
        PA2T.Text = TimePA2T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePA2T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePA2T.Seconds.ToString.PadLeft(2, "0c")
        PA2T.BackColor = LPA2.BackColor
        PA2TS.Text = TimePA2T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePA2T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePA2T.Seconds.ToString.PadLeft(2, "0c")
        PA2TS.BackColor = LPA2.BackColor
        dblTPA2 = dblTPA2 + 1

        Dim TimePV2T As TimeSpan = TimeSpan.FromSeconds(dblTPV2)
        PV2T.Text = TimePV2T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePV2T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePV2T.Seconds.ToString.PadLeft(2, "0c")
        PV2T.BackColor = LPV2.BackColor
        PV2TS.Text = TimePV2T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePV2T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePV2T.Seconds.ToString.PadLeft(2, "0c")
        PV2TS.BackColor = LPV2.BackColor
        dblTPV2 = dblTPV2 + 1

        Dim TimePE2T As TimeSpan = TimeSpan.FromSeconds(dblTPE2)
        PE2T.Text = TimePE2T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePE2T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePE2T.Seconds.ToString.PadLeft(2, "0c")
        PE2T.BackColor = LPE2.BackColor
        PE2TS.Text = TimePE2T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePE2T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePE2T.Seconds.ToString.PadLeft(2, "0c")
        PE2TS.BackColor = LPE2.BackColor
        dblTPE2 = dblTPE2 + 1

        Dim TimePA3T As TimeSpan = TimeSpan.FromSeconds(dblTPA3)
        PA3T.Text = TimePA3T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePA3T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePA3T.Seconds.ToString.PadLeft(2, "0c")
        PA3T.BackColor = LPA3.BackColor
        PA3TS.Text = TimePA3T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePA3T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePA3T.Seconds.ToString.PadLeft(2, "0c")
        PA3TS.BackColor = LPA3.BackColor
        dblTPA3 = dblTPA3 + 1

        Dim TimePV3T As TimeSpan = TimeSpan.FromSeconds(dblTPV3)
        PV3T.Text = TimePV3T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePV3T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePV3T.Seconds.ToString.PadLeft(2, "0c")
        PV3T.BackColor = LPV3.BackColor
        PV3TS.Text = TimePV3T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePV3T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePV3T.Seconds.ToString.PadLeft(2, "0c")
        PV3TS.BackColor = LPV3.BackColor
        dblTPV3 = dblTPV3 + 1

        Dim TimePE3T As TimeSpan = TimeSpan.FromSeconds(dblTPE3)
        PE3T.Text = TimePE3T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePE3T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePE3T.Seconds.ToString.PadLeft(2, "0c")
        PE3T.BackColor = LPE3.BackColor
        PE3TS.Text = TimePE3T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePE3T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePE3T.Seconds.ToString.PadLeft(2, "0c")
        PE3TS.BackColor = LPE3.BackColor
        dblTPE3 = dblTPE3 + 1

        Dim TimePA4T As TimeSpan = TimeSpan.FromSeconds(dblTPA4)
        PA4T.Text = TimePA4T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePA4T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePA4T.Seconds.ToString.PadLeft(2, "0c")
        PA4T.BackColor = LPA4.BackColor
        PA4TS.Text = TimePA4T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePA4T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePA4T.Seconds.ToString.PadLeft(2, "0c")
        PA4TS.BackColor = LPA4.BackColor
        dblTPA4 = dblTPA4 + 1

        Dim TimePV4T As TimeSpan = TimeSpan.FromSeconds(dblTPV4)
        PV4T.Text = TimePV4T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePV4T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePV4T.Seconds.ToString.PadLeft(2, "0c")
        PV4T.BackColor = LPV4.BackColor
        PV4TS.Text = TimePV4T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePV4T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePV4T.Seconds.ToString.PadLeft(2, "0c")
        PV4TS.BackColor = LPV4.BackColor
        dblTPV4 = dblTPV4 + 1

        Dim TimePE4T As TimeSpan = TimeSpan.FromSeconds(dblTPE4)
        PE4T.Text = TimePE4T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePE4T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePE4T.Seconds.ToString.PadLeft(2, "0c")
        PE4T.BackColor = LPE4.BackColor
        PE4TS.Text = TimePE4T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePE4T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePE4T.Seconds.ToString.PadLeft(2, "0c")
        PE4TS.BackColor = LPE4.BackColor
        dblTPE4 = dblTPE4 + 1

        Dim TimePA5T As TimeSpan = TimeSpan.FromSeconds(dblTPA5)
        PA5T.Text = TimePA5T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePA5T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePA5T.Seconds.ToString.PadLeft(2, "0c")
        PA5T.BackColor = LPA5.BackColor
        PA5TS.Text = TimePA5T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePA5T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePA5T.Seconds.ToString.PadLeft(2, "0c")
        PA5TS.BackColor = LPA5.BackColor
        dblTPA5 = dblTPA5 + 1

        Dim TimePV5T As TimeSpan = TimeSpan.FromSeconds(dblTPV5)
        PV5T.Text = TimePV5T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePV5T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePV5T.Seconds.ToString.PadLeft(2, "0c")
        PV5T.BackColor = LPV5.BackColor
        PV5TS.Text = TimePV5T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePV5T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePV5T.Seconds.ToString.PadLeft(2, "0c")
        PV5TS.BackColor = LPV5.BackColor
        dblTPV5 = dblTPV5 + 1

        Dim TimePE5T As TimeSpan = TimeSpan.FromSeconds(dblTPE5)
        PE5T.Text = TimePE5T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePE5T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePE5T.Seconds.ToString.PadLeft(2, "0c")
        PE5T.BackColor = LPE5.BackColor
        PE5TS.Text = TimePE5T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePE5T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePE5T.Seconds.ToString.PadLeft(2, "0c")
        PE5TS.BackColor = LPE5.BackColor
        dblTPE5 = dblTPE5 + 1

        Dim TimePA6T As TimeSpan = TimeSpan.FromSeconds(dblTPA6)
        PA6T.Text = TimePA6T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePA6T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePA6T.Seconds.ToString.PadLeft(2, "0c")
        PA6T.BackColor = LPA6.BackColor
        PA6TS.Text = TimePA6T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePA6T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePA6T.Seconds.ToString.PadLeft(2, "0c")
        PA6TS.BackColor = LPA6.BackColor
        dblTPA6 = dblTPA6 + 1

        Dim TimePV6T As TimeSpan = TimeSpan.FromSeconds(dblTPV6)
        PV6T.Text = TimePV6T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePV6T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePV6T.Seconds.ToString.PadLeft(2, "0c")
        PV6T.BackColor = LPV6.BackColor
        PV6TS.Text = TimePV6T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePV6T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePV6T.Seconds.ToString.PadLeft(2, "0c")
        PV6TS.BackColor = LPV6.BackColor
        dblTPV6 = dblTPV6 + 1

        Dim TimePE6T As TimeSpan = TimeSpan.FromSeconds(dblTPE6)
        PE6T.Text = TimePE6T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePE6T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePE6T.Seconds.ToString.PadLeft(2, "0c")
        PE6T.BackColor = LPE6.BackColor
        PE6TS.Text = TimePE6T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePE6T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePE6T.Seconds.ToString.PadLeft(2, "0c")
        PE6TS.BackColor = LPE6.BackColor
        dblTPE6 = dblTPE6 + 1

        Dim TimePA7T As TimeSpan = TimeSpan.FromSeconds(dblTPA7)
        PA7T.Text = TimePA7T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePA7T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePA7T.Seconds.ToString.PadLeft(2, "0c")
        PA7T.BackColor = LPA7.BackColor
        PA7TS.Text = TimePA7T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePA7T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePA7T.Seconds.ToString.PadLeft(2, "0c")
        PA7TS.BackColor = LPA7.BackColor
        dblTPA7 = dblTPA7 + 1

        Dim TimePV7T As TimeSpan = TimeSpan.FromSeconds(dblTPV7)
        PV7T.Text = TimePV7T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePV7T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePV7T.Seconds.ToString.PadLeft(2, "0c")
        PV7T.BackColor = LPV7.BackColor
        PV7TS.Text = TimePV7T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePV7T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePV7T.Seconds.ToString.PadLeft(2, "0c")
        PV7TS.BackColor = LPV7.BackColor
        dblTPV7 = dblTPV7 + 1

        Dim TimePE7T As TimeSpan = TimeSpan.FromSeconds(dblTPE7)
        PE7T.Text = TimePE7T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePE7T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePE7T.Seconds.ToString.PadLeft(2, "0c")
        PE7T.BackColor = LPE7.BackColor
        PE7TS.Text = TimePE7T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePE7T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePE7T.Seconds.ToString.PadLeft(2, "0c")
        PE7TS.BackColor = LPE7.BackColor
        dblTPE7 = dblTPE7 + 1

        Dim TimePA8T As TimeSpan = TimeSpan.FromSeconds(dblTPA8)
        PA8T.Text = TimePA8T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePA8T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePA8T.Seconds.ToString.PadLeft(2, "0c")
        PA8T.BackColor = LPA8.BackColor
        PA8TS.Text = TimePA8T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePA8T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePA8T.Seconds.ToString.PadLeft(2, "0c")
        PA8TS.BackColor = LPA8.BackColor
        dblTPA8 = dblTPA8 + 1

        Dim TimePV8T As TimeSpan = TimeSpan.FromSeconds(dblTPV8)
        PV8T.Text = TimePV8T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePV8T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePV8T.Seconds.ToString.PadLeft(2, "0c")
        PV8T.BackColor = LPV8.BackColor
        PV8TS.Text = TimePV8T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePV8T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePV8T.Seconds.ToString.PadLeft(2, "0c")
        PV8TS.BackColor = LPV8.BackColor
        dblTPV8 = dblTPV8 + 1

        Dim TimePE8T As TimeSpan = TimeSpan.FromSeconds(dblTPE8)
        PE8T.Text = TimePE8T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePE8T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePE8T.Seconds.ToString.PadLeft(2, "0c")
        PE8T.BackColor = LPE8.BackColor
        PE8TS.Text = TimePE8T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePE8T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePE8T.Seconds.ToString.PadLeft(2, "0c")
        PE8TS.BackColor = LPE8.BackColor
        dblTPE8 = dblTPE8 + 1

        Dim TimePA9T As TimeSpan = TimeSpan.FromSeconds(dblTPA9)
        PA9T.Text = TimePA9T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePA9T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePA9T.Seconds.ToString.PadLeft(2, "0c")
        PA9T.BackColor = LPA9.BackColor
        PA9TS.Text = TimePA9T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePA9T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePA9T.Seconds.ToString.PadLeft(2, "0c")
        PA9TS.BackColor = LPA9.BackColor
        dblTPA9 = dblTPA9 + 1

        Dim TimePV9T As TimeSpan = TimeSpan.FromSeconds(dblTPV9)
        PV9T.Text = TimePV9T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePV9T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePV9T.Seconds.ToString.PadLeft(2, "0c")
        PV9T.BackColor = LPV9.BackColor
        PV9TS.Text = TimePV9T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePV9T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePV9T.Seconds.ToString.PadLeft(2, "0c")
        PV9TS.BackColor = LPV9.BackColor
        dblTPV9 = dblTPV9 + 1

        Dim TimePE9T As TimeSpan = TimeSpan.FromSeconds(dblTPE9)
        PE9T.Text = TimePE9T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePE9T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePE9T.Seconds.ToString.PadLeft(2, "0c")
        PE9T.BackColor = LPE9.BackColor
        PE9TS.Text = TimePE9T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePE9T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePE9T.Seconds.ToString.PadLeft(2, "0c")
        PE9TS.BackColor = LPE9.BackColor
        dblTPE9 = dblTPE9 + 1

        Dim TimePA10T As TimeSpan = TimeSpan.FromSeconds(dblTPA10)
        PA10T.Text = TimePA10T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePA10T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePA10T.Seconds.ToString.PadLeft(2, "0c")
        PA10T.BackColor = LPA10.BackColor
        PA10TS.Text = TimePA10T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePA10T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePA10T.Seconds.ToString.PadLeft(2, "0c")
        PA10TS.BackColor = LPA10.BackColor
        dblTPA10 = dblTPA10 + 1

        Dim TimePV10T As TimeSpan = TimeSpan.FromSeconds(dblTPV10)
        PV10T.Text = TimePV10T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePV10T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePV10T.Seconds.ToString.PadLeft(2, "0c")
        PV10T.BackColor = LPV10.BackColor
        PV10TS.Text = TimePV10T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePV10T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePV10T.Seconds.ToString.PadLeft(2, "0c")
        PV10TS.BackColor = LPV10.BackColor
        dblTPV10 = dblTPV10 + 1

        Dim TimePE10T As TimeSpan = TimeSpan.FromSeconds(dblTPE10)
        PE10T.Text = TimePE10T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePE10T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePE10T.Seconds.ToString.PadLeft(2, "0c")
        PE10T.BackColor = LPE10.BackColor
        PE10TS.Text = TimePE10T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePE10T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePE10T.Seconds.ToString.PadLeft(2, "0c")
        PE10TS.BackColor = LPE10.BackColor
        dblTPE10 = dblTPE10 + 1

        Dim TimePA11T As TimeSpan = TimeSpan.FromSeconds(dblTPA11)
        PA11T.Text = TimePA11T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePA11T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePA11T.Seconds.ToString.PadLeft(2, "0c")
        PA11T.BackColor = LPA11.BackColor
        PA11TS.Text = TimePA11T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePA11T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePA11T.Seconds.ToString.PadLeft(2, "0c")
        PA11TS.BackColor = LPA11.BackColor
        dblTPA11 = dblTPA11 + 1

        Dim TimePV11T As TimeSpan = TimeSpan.FromSeconds(dblTPV11)
        PV11T.Text = TimePV11T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePV11T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePV11T.Seconds.ToString.PadLeft(2, "0c")
        PV11T.BackColor = LPV11.BackColor
        PV11TS.Text = TimePV11T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePV11T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePV11T.Seconds.ToString.PadLeft(2, "0c")
        PV11TS.BackColor = LPV11.BackColor
        dblTPV11 = dblTPV11 + 1

        Dim TimePE11T As TimeSpan = TimeSpan.FromSeconds(dblTPE11)
        PE11T.Text = TimePE11T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePE11T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePE11T.Seconds.ToString.PadLeft(2, "0c")
        PE11T.BackColor = LPE11.BackColor
        PE11TS.Text = TimePE11T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePE11T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePE11T.Seconds.ToString.PadLeft(2, "0c")
        PE11TS.BackColor = LPE11.BackColor
        dblTPE11 = dblTPE11 + 1

        Dim TimePA13T As TimeSpan = TimeSpan.FromSeconds(dblTPA13)
        PA13T.Text = TimePA13T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePA11T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePA11T.Seconds.ToString.PadLeft(2, "0c")
        PA13T.BackColor = LPA13.BackColor
        PA13TS.Text = TimePA13T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePA11T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePA11T.Seconds.ToString.PadLeft(2, "0c")
        PA13TS.BackColor = LPA13.BackColor
        dblTPA13 = dblTPA13 + 1

        Dim TimePV13T As TimeSpan = TimeSpan.FromSeconds(dblTPV13)
        PV13T.Text = TimePV13T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePV11T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePV11T.Seconds.ToString.PadLeft(2, "0c")
        PV13T.BackColor = LPV13.BackColor
        PV13TS.Text = TimePV13T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePV11T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePV11T.Seconds.ToString.PadLeft(2, "0c")
        PV13TS.BackColor = LPV13.BackColor
        dblTPV13 = dblTPV13 + 1

        Dim TimePE13T As TimeSpan = TimeSpan.FromSeconds(dblTPE13)
        PE13T.Text = TimePE13T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePE11T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePE11T.Seconds.ToString.PadLeft(2, "0c")
        PE13T.BackColor = LPE13.BackColor
        PE13TS.Text = TimePE13T.Hours.ToString.PadLeft(2, "0"c) & ":" & TimePE11T.Minutes.ToString.PadLeft(2, "0c") & ":" & TimePE11T.Seconds.ToString.PadLeft(2, "0c")
        PE13TS.BackColor = LPE13.BackColor
        dblTPE13 = dblTPE13 + 1
        '-------------------Finaliza Botones con tiempo de Tooling solo como Display -------------------------------

        'Muestra la fecha y hora en la pantalla princpal arriba lado izquierdo
        Dim ci As New CultureInfo("en-us")
        FECHA.Text = Now.ToString("M/dd/yyyy", ci)
        HORA.Text = Now.ToString("H:mm:ss", ci)

        'Si son las 6:00 envia el reporte por email
        Dim TimeMailer As DateTime = TimeOfDay
        If TimeMailer = "#06:00:00 AM#" Or TimeMailer = "#06:00:00 PM#" Then
            If Master = True Then
                Mailer()
            End If
        End If

    End Sub

    Private Function GetTimers() As Integer
        'Logica que hace la diferencia en segundos desde la fecha/hora que se capturo el Tooling
        'hasta la fecha hora que lo esta bajando a la base
        '--------get timers ------
        Dim FileTime As DateTime
        Dim SecDiff As Double
        Dim StrHr As String
        Dim strDummyLine As String
        Dim strDummyFecha, strDummyHora As Date
        Dim strDummyVida As Double
        Dim strDummyState As String
        Try
            Dim query As String = "Select FECHA, HORA, LINEA, VIDA, ESTADO FROM Tooling.RUNNING"
            db.SelectQueryReader(query)

            'REVISAR
            While db.dReader.Read()
                StrHr = db.dReader.GetDateTime(0)
                strDummyHora = db.dReader.GetDateTime(1)
                strDummyLine = db.dReader.GetString(2)
                strDummyVida = db.dReader.GetValue(3)
                strDummyState = db.dReader.GetString(4)
                ' StrHr = strDummyFecha + " " + strDummyHora  'Junta la fecha y la hora

                FileTime = Convert.ToDateTime(StrHr)
                SecDiff = DateDiff(DateInterval.Second, FileTime, DateTime.Now)

                'Vacia la diferencia en segundos para el display unicamente
                If strDummyLine.Contains("01") Then
                    If strDummyLine.Contains("V") Then
                        dblTPV1 = SecDiff
                    End If

                    If strDummyLine.Contains("E") Then
                        dblTPE1 = SecDiff
                    End If
                    If strDummyLine.Contains("A") Then
                        dblTPA1 = SecDiff
                    End If
                End If

                If strDummyLine.Contains("02") Then
                    If strDummyLine.Contains("V") Then
                        dblTPV2 = SecDiff
                    End If
                    If strDummyLine.Contains("E") Then
                        dblTPE2 = SecDiff
                    End If
                    If strDummyLine.Contains("A") Then
                        dblTPA2 = SecDiff
                    End If
                End If

                If strDummyLine.Contains("03") Then
                    If strDummyLine.Contains("V") Then
                        dblTPV3 = SecDiff
                    End If
                    If strDummyLine.Contains("E") Then
                        dblTPE3 = SecDiff
                    End If
                    If strDummyLine.Contains("A") Then
                        dblTPA3 = SecDiff
                    End If
                End If

                If strDummyLine.Contains("04") Then
                    If strDummyLine.Contains("V") Then
                        dblTPV4 = SecDiff
                    End If
                    If strDummyLine.Contains("E") Then
                        dblTPE4 = SecDiff
                    End If
                    If strDummyLine.Contains("A") Then
                        dblTPA4 = SecDiff
                    End If
                End If

                If strDummyLine.Contains("05") Then
                    If strDummyLine.Contains("V") Then
                        dblTPV5 = SecDiff
                    End If
                    If strDummyLine.Contains("E") Then
                        dblTPE5 = SecDiff
                    End If
                    If strDummyLine.Contains("A") Then
                        dblTPA5 = SecDiff
                    End If
                End If

                If strDummyLine.Contains("06") Then
                    If strDummyLine.Contains("V") Then
                        dblTPV6 = SecDiff
                    End If
                    If strDummyLine.Contains("E") Then
                        dblTPE6 = SecDiff
                    End If
                    If strDummyLine.Contains("A") Then
                        dblTPA6 = SecDiff
                    End If
                End If

                If strDummyLine.Contains("07") Then
                    If strDummyLine.Contains("V") Then
                        dblTPV7 = SecDiff
                    End If
                    If strDummyLine.Contains("E") Then
                        dblTPE7 = SecDiff
                    End If
                    If strDummyLine.Contains("A") Then
                        dblTPA7 = SecDiff
                    End If
                End If

                If strDummyLine.Contains("08") Then
                    If strDummyLine.Contains("V") Then
                        dblTPV8 = SecDiff
                    End If
                    If strDummyLine.Contains("E") Then
                        dblTPE8 = SecDiff
                    End If
                    If strDummyLine.Contains("A") Then
                        dblTPA8 = SecDiff
                    End If
                End If

                If strDummyLine.Contains("09") Then
                    If strDummyLine.Contains("V") Then
                        dblTPV9 = SecDiff
                    End If
                    If strDummyLine.Contains("E") Then
                        dblTPE9 = SecDiff
                    End If
                    If strDummyLine.Contains("A") Then
                        dblTPA9 = SecDiff
                    End If
                End If

                If strDummyLine.Contains("10") Then
                    If strDummyLine.Contains("V") Then
                        dblTPV10 = SecDiff
                    End If
                    If strDummyLine.Contains("E") Then
                        dblTPE10 = SecDiff
                    End If
                    If strDummyLine.Contains("A") Then
                        dblTPA10 = SecDiff
                    End If
                End If

                If strDummyLine.Contains("11") Then
                    If strDummyLine.Contains("V") Then
                        dblTPV11 = SecDiff
                    End If
                    If strDummyLine.Contains("E") Then
                        dblTPE11 = SecDiff
                    End If
                    If strDummyLine.Contains("A") Then
                        dblTPA11 = SecDiff
                    End If
                End If

                If strDummyLine.Contains("13") Then
                    If strDummyLine.Contains("V") Then
                        dblTPV13 = SecDiff
                    End If
                    If strDummyLine.Contains("E") Then
                        dblTPE13 = SecDiff
                    End If
                    If strDummyLine.Contains("A") Then
                        dblTPA13 = SecDiff
                    End If
                End If

            End While
            db.CloseConnection()
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
    End Function


    Public Sub LoadGrid()
        'Actualiza el Grid de la pestana

        Dim SetQry As String = "SELECT idCREATESET, fechabaja_ant, tooling, color, diametro, tiperunner,IDcolor,cantidad, tipo, status FROM Tooling.CREATESET"
        Dim TablaToolQry As New DataTable
        Dim tabla As New DataTable
        Dim tabla2 As New DataTable
        Try
            db.SelectQueryDataSet(SetQry)
            tabla = db.dDataSet.Tables(0)
            TablaToolQry.Columns.Add("ID", Type.GetType("System.String"))
            TablaToolQry.Columns.Add("FechaBajaAnterior", Type.GetType("System.String"))
            TablaToolQry.Columns.Add("tooling", Type.GetType("System.String"))
            TablaToolQry.Columns.Add("color", Type.GetType("System.String"))
            TablaToolQry.Columns.Add("diametro", Type.GetType("System.String"))
            TablaToolQry.Columns.Add("tiperunner", Type.GetType("System.String"))
            TablaToolQry.Columns.Add("IDcolor", Type.GetType("System.String"))
            TablaToolQry.Columns.Add("cantidad", Type.GetType("System.String"))
            TablaToolQry.Columns.Add("tipo", Type.GetType("System.String"))
            TablaToolQry.Columns.Add("status", Type.GetType("System.String"))
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
            RowTemp(columnas(5)) = tabla.Rows(i)(5).ToString()
            RowTemp(columnas(6)) = tabla.Rows(i)(6).ToString()
            RowTemp(columnas(7)) = tabla.Rows(i)(7).ToString()
            RowTemp(columnas(8)) = tabla.Rows(i)(8).ToString()
            RowTemp(columnas(9)) = tabla.Rows(i)(9).ToString()
            TablaToolQry.Rows.Add(RowTemp)
        Next i
        tabla.Clear()
        GrdGrommet.DataSource = TablaToolQry.DefaultView

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''
         'Actualiza el Grid de la pestana

        Dim SetQryChange As String = "SELECT EMPLEADO, LINEA, NUEVOSOLICITADO, LAINALADO1, LAINALADO2, FECHASOLICITUD FROM Tooling.CAMBIO WHERE STATUS='Open'"
        Dim TablaChangeQry As New DataTable
        Dim tablaChange As New DataTable
        Try
            db.SelectQueryDataSet(SetQryChange)
            tabla2 = db.dDataSet.Tables(0)
            TablaChangeQry.Columns.Add("EMPLEADO", Type.GetType("System.String"))
            TablaChangeQry.Columns.Add("LINEA", Type.GetType("System.String"))
            TablaChangeQry.Columns.Add("NUEVO SOLICITADO", Type.GetType("System.String"))
            TablaChangeQry.Columns.Add("LAINA 1ER LADO", Type.GetType("System.String"))
            TablaChangeQry.Columns.Add("LAINA 2DO LADO", Type.GetType("System.String"))
            TablaChangeQry.Columns.Add("FECHASOLICITUD", Type.GetType("System.String"))
        Catch ex As Exception

        Finally
            db.CloseConnection()
        End Try
        Dim columnascambio As DataColumnCollection = TablaChangeQry.Columns
        Dim RowTemp2 As DataRow
        Dim LastNonEmpty2 As Integer = 0
        For i As Integer = 0 To tabla2.Rows.Count - 1
            RowTemp2 = TablaChangeQry.NewRow
            RowTemp2(columnascambio(0)) = tabla2.Rows(i)(0).ToString()
            RowTemp2(columnascambio(1)) = tabla2.Rows(i)(1).ToString()
            RowTemp2(columnascambio(2)) = tabla2.Rows(i)(2).ToString()
            RowTemp2(columnascambio(3)) = tabla2.Rows(i)(3).ToString()
            RowTemp2(columnascambio(4)) = tabla2.Rows(i)(4).ToString()
            RowTemp2(columnascambio(5)) = tabla2.Rows(i)(5).ToString()
            TablaChangeQry.Rows.Add(RowTemp2)
        Next i
        tabla2.Clear()
        GridChangeTool.DataSource = TablaChangeQry.DefaultView

        GridChangeTool.Columns(0).Width = 100
        GridChangeTool.Columns(1).Width = 80
        GridChangeTool.Columns(2).Width = 100
        GridChangeTool.Columns(3).Width = 100
        GridChangeTool.Columns(4).Width = 100
        GridChangeTool.Columns(5).Width = 200


        GridChangeTool2.DataSource = TablaChangeQry.DefaultView
        GridChangeTool2.Columns(0).Width = 100
        GridChangeTool2.Columns(1).Width = 80
        GridChangeTool2.Columns(2).Width = 100
        GridChangeTool2.Columns(3).Width = 100
        GridChangeTool2.Columns(4).Width = 100
        GridChangeTool2.Columns(5).Width = 200
    End Sub
    Public Sub UpdateGrid()
        'Actualiza el Grid de la pestana

        Dim ToolQry As String = "Select TIPOTOOLING, TOOLINGID, DESCRIPCION, STATUS, VIDA FROM Tooling.TOOLLINES"
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
        GridTooling.DataSource = TablaToolQry.DefaultView

        'Actualiza el Grid de la pestana

    End Sub

    Public Sub Mailer()
        'Envia el correo a las 6:00

        Dim db As New DBConnection()
        Dim emailflag As Integer = 0
        Dim LineXX As String
        Dim EmailAdd As String
        Dim C_ToolID, V_ToolID, E_ToolID, C_HoraCamb, V_HoraCamb, E_HoraCamb, C_PDob, V_PDob, E_PDob, C_PQueb, V_PQueb, E_PQueb As String

        Dim strEMailTo As String = Nothing
        Try
            Dim queryEmail As String = "select EMAIL from Tooling.ADMIN where RECIBEEMAIL = '1'"
            db.SelectQueryReader(queryEmail)
            intX = 0
            While db.dReader.Read()
                If Not IsDBNull(db.dReader.GetValue(0)) Then
                    ReDim Preserve strEMailAdd(intX)
                    strEMailAdd(intX) = db.dReader.GetValue(0)
                    intX += 1
                End If
            End While
            strEMailTo = String.Join(",", strEMailAdd)
        Catch ex As Exception
        Finally
            db.CloseConnection()
        End Try

        Dim Time As String = DateAdd("h", -12, Now)
        Dim TimeFormat As String = Format(CDate(Time), "yyyy-MM-dd HH:mm:ss")
        Dim Days As String = DateAdd("d", -1, Now).ToString("yyyy-MM-dd")

        Dim TecQuery As String = "SELECT distinct(INSTALO) from Tooling.INFOLINES where FECHA >= " & "'" & TimeFormat & "'"
        db.SelectQueryReader(TecQuery)
        Dim TecToday(5) As String
        Dim T As Integer = 0

        While db.dReader.Read()
            T = T + 1
            TecToday(T) = db.dReader.GetString(0)

        End While


        Dim oMsg As CDO.Message = New CDO.Message()
        oMsg.From = "Reporte Tooling <Reporte@ToolingKemet.com>"
        oMsg.To = EmailAdd
        oMsg.To = "juanrodriguez@kemet.com"
        oMsg.Subject = "Reporte de Tooling Diario"

        Dim sHtml As String = "<HTML>" &
         "<HEAD>" &
         "<TITLE>Reporte Diario de uso de Tooling</TITLE>" &
         "</HEAD>" &
         "<H1 style='font-family:verdana'>Reporte Diario de uso de Tooling:</H1>" &
         "<BODY><P>"

        For e As Integer = 1 To T
            sHtml = sHtml + "<table border=2>" &
                        "<tr><th colspan=3>Nombre del Tecnico: " & TecToday(e) & "       Fecha: " & Date.Now.ToShortDateString & "</th></tr>" &
                        "<tr>"

            For i As Integer = 1 To 10
                If i < 10 Then
                    LineXX = "0" + Convert.ToString(i)
                End If
                LineXX = LineXX + "%"

                Dim query As String = "select FECHA, LINEA, PRENSA, TOOLINGID, GREENPLATE, QTYLABIOSDOBLADOS, LAINA, EMPLEADO, INSTALO, ESTADO, VIDA, QUITO, DURATOTAL, REPARO, FECHAREP, QTYPINESDOBLADOS, QTYPINESQUEBRADOS from Tooling.INFOLINES where FECHA >= " & "'" & Time & "' and LINEA like '" & LineXX & "' and INSTALO = '" & TecToday(e) & "' ORDER BY FECHA ASC"
                db.SelectQueryReader(query)
                db.dReader.Read()

                Dim StrFecha, StrLinea, StrPrensa, StrToolingid, StrGreenP, StrLabD, StrPinD, StrPinQ, StrLaina, StrEmpleado, StrINSTALO, StrEstado, StrVida, StrQuita, StrDuratotal, StrEficiencia, StrRep, StrFechaRep As String

                Dim HeaderFlag As Integer

                If db.dReader.HasRows Then
                    emailflag = 1
                    HeaderFlag = 0
                    sHtml = sHtml & "<th>" &
                               "<table border=2>" &
                               "<thead>" &
                               "<tr>" &
                               "<th colspan=3>Linea #" & i & "</th>" &
                               "<th colspan=2>Pines</th>" &
                               "</tr>" &
                               "</thead>" &
                               "<tr>" &
                               "<th></th>" &
                               "<th>Tooling ID</th>" &
                               "<th>Hora Inst.</th>" &
                               "<th>Dob.</th>" &
                               "<th>Queb.</th>" &
                               "</tr>" &
                               "<tbody>"

                End If
                'Se abre la coneccion y se crea el query para la tabla de Tooling Report

                While db.dReader.Read()
                    If HeaderFlag = 1 Then
                        sHtml = sHtml & "</tbody></table></th>" &
                                "<th>" &
                               "<table border=2>" &
                               "<thead>" &
                               "<tr>" &
                               "<th colspan=3>Linea #" & i & "</th>" &
                               "<th colspan=2>Pines</th>" &
                               "</tr>" &
                               "</thead>" &
                               "<tr>" &
                               "<th></th>" &
                               "<th>Tooling ID</th>" &
                               "<th>Hora Inst.</th>" &
                               "<th>Dob.</th>" &
                               "<th>Queb.</th>" &
                               "</tr>" &
                               "<tbody>"
                        HeaderFlag = 0
                    End If

                    StrFecha = Convert.ToString(db.dReader.GetDateTime(0).ToShortTimeString)
                    StrLinea = Convert.ToString(db.dReader.GetValue(1))
                    StrPrensa = Convert.ToString(db.dReader.GetValue(2))
                    StrToolingid = Convert.ToString(db.dReader.GetValue(3))
                    StrPinD = Convert.ToString(db.dReader.GetValue(15))
                    StrPinQ = Convert.ToString(db.dReader.GetValue(16))

                    If StrPrensa = "CARGADO" Then
                        C_ToolID = StrToolingid
                        C_HoraCamb = StrFecha
                        C_PDob = StrPinD
                        C_PQueb = StrPinQ
                        sHtml = sHtml & "<tr><td>C</td>" &
                               "<td>" & C_ToolID & "</td>" &
                               "<td>" & C_HoraCamb & "</td>" &
                               "<td>" & C_PDob & "</td>" &
                               "<td>" & C_PQueb & "</td>" &
                               "</tr>"
                    ElseIf StrPrensa = "VOLTEO" Then
                        V_ToolID = StrToolingid
                        V_HoraCamb = StrFecha
                        V_PDob = StrPinD
                        V_PQueb = StrPinQ
                        sHtml = sHtml & "<tr><td>V</td>" &
                               "<td>" & V_ToolID & "</td>" &
                               "<td>" & V_HoraCamb & "</td>" &
                               "<td>" & V_PDob & "</td>" &
                               "<td>" & V_PQueb & "</td>" &
                               "</tr>"

                    ElseIf StrPrensa = "EXPULSION" Then
                        E_ToolID = StrToolingid
                        E_HoraCamb = StrFecha
                        E_PDob = StrPinD
                        E_PQueb = StrPinQ
                        sHtml = sHtml & "<tr><td>E</td>" &
                               "<td>" & E_ToolID & "</td>" &
                               "<td>" & E_HoraCamb & "</td>" &
                               "<td>" & E_PDob & "</td>" &
                               "<td>" & E_PQueb & "</td>" &
                               "</tr>"
                        HeaderFlag = 1
                    End If
                End While
                If db.dReader.HasRows Then
                    sHtml = sHtml & "</tbody>" &
                               "</table>" &
                               "</tr>"
                End If
                If i = 10 Then
                    sHtml = sHtml & "</tr>" &
                                     "<tr>"
                End If
            Next
            'Cierra la tabla del pinpackero
            sHtml = sHtml & "</tr>" &
            "</table>"
        Next
        sHtml = sHtml & "<P style='font-family:verdana'> Reporte Generado Automaticamente con el detalle de las ultimas 12 horas. </P>" &
                        "<P style='font-family:verdana'> Control de Tooling. </P>" &
                        "</BODY>" &
                        "</HTML>"
        'Envio del email con la informacion del CDO 
        oMsg.HTMLBody = sHtml
        If emailflag = 1 Then
            Dim iConfg As CDO.Configuration = New CDO.Configuration()

            Dim oFields As ADODB.Fields
            oFields = iConfg.Fields  'Comentariar cuando se hacen pruebas

            Dim oField As ADODB.Field
            oField = oFields("http://schemas.microsoft.com/cdo/configuration/sendusing")
            oField.Value = 2
            oField = oFields("http://schemas.microsoft.com/cdo/configuration/smtpserver")
            oField.Value = "SMTPGW.KEMET.COM"
            oFields.Update()
            oMsg.Configuration = iConfg
            oMsg.Send()
            iConfg = Nothing
            oFields = Nothing
            oField = Nothing
            emailflag = 0
        End If
        oMsg = Nothing
        sHtml = Nothing
        db.CloseConnection()
    End Sub

    Private Sub AjustesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjustesToolStripMenuItem.Click
        'Manda pedir el Login en el Menu
        Login.Show()
    End Sub

    Public Sub DBtoFile()
        'Baja la info de la tabla Running a un archivo de texto cada minuto para mantener actualizada la info
        Dim objWrtDBtoFile As New System.IO.StreamWriter(sDBtoFile, False)
        Dim FileTime As DateTime
        Dim sContent As String = vbNullString
        Try
            Dim access As String = "Select FECHA, HORA, LINEA, TOOLINGID, ESTADO, VIDA FROM Tooling.RUNNING ORDER BY LINEA ASC"
            db.SelectQueryReader(access)
            db.SelectQueryDataSet(access)
            Dim dt As New DataTable("access")
            dt = db.dDataSet.Tables(0)
            db.CloseConnection()
            'y despues en el while te encargas de realizar puros updates. Para evitar ese problema de tener que abrir de nuevo el dataReader
            For i As Integer = 0 To dt.Rows.Count - 1
                StrHr = dt.Rows(i).Item(0).ToString
                'StrHora = dt.Rows(i).Item(1).ToString.Substring(10, 11)
                StrLinea = dt.Rows(i).Item(2).ToString
                StrToolingID = dt.Rows(i).Item(3).ToString
                StrEstado = dt.Rows(i).Item(4).ToString
                StrVida = dt.Rows(i).Item(5).ToString
                'StrHr = StrFecha + " " + StrHora
                FileTime = Convert.ToDateTime(StrHr)
                StrUso = DateDiff(DateInterval.Second, FileTime, DateTime.Now)
                If StrUso < 0 Then
                    StrUso = 0
                End If
                If StrUso > StrVida And StrEstado <> "D" Then
                    StrEstado = "R"
                    Dim UpdToolLines As String = "UPDATE Tooling.TOOLLINES SET STATUS = 'R' where TOOLINGID='" & StrToolingID & "'"
                    db.ModifyQuery(UpdToolLines)
                    Dim UpdRunning As String = "UPDATE Tooling.RUNNING SET ESTADO= '" & StrEstado & "' where RUNNING.LINEA= '" & StrLinea & "'"
                    db.ModifyQuery(UpdRunning)
                End If
                StrDummy = StrHr + "," + StrLinea + "," + StrToolingID + "," + StrEstado + "," + StrVida + "," + Convert.ToString(StrUso)
                objWrtDBtoFile.WriteLine(StrDummy)
            Next
            objWrtDBtoFile.Close()
            db.CloseConnection()
        Catch ex As Exception
            MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
        End Try
        If System.IO.File.Exists(sDBtoFile) = True Then
            'No activar JR
            'System.IO.File.Delete(sDBtoFile)

        End If
        ' TmrDbToFile.Enabled = True
    End Sub

    Private Sub TmrDbToFile_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TmrDbToFile.Tick
        'Timer que corre una vez por minutopara crear los archivos y actualizar el display
        GetTimers()
        DBtoFile()
        DBtoFileRead()
        UpdateGrid()
        UpdateTableFromToolin()
        LoadGrid()
    End Sub

    Public Function UpdateTableFromToolin() As Double
        'Obtiene el turno correspondiente
        Dim Turno As String
        Dim TimeMailer As DateTime = TimeOfDay
        If TimeMailer >= "#06:00:00 AM#" And TimeMailer <= "#05:59:59 PM#" Then
            Turno = "1"
        Else
            Turno = "2"
        End If
        Dim query As String
        Dim queryupd As String
        Dim ci As New CultureInfo("en-us")
        Dim Ahora As Date
        Ahora = Now
        Dim SPath As String
        Dim localFileToolin As String = "C:\APP\TOOLING\DATA\Mydebug.tmp"
        Dim strDummysDate, strDummysHr, strDummySet, strDummyNPart, strDummyBatch, strDummyLine, strDummysEmpl, strDummysPPackAnt, strDummysPPackNew, strDummysGreen As String
        Dim strDummysTurno, strDummyPrensa, strDummyArea, strDummyLinea, strUnion As String
        Dim strEstado As String
        Dim queryTool As String
        SPath = "C:\APP\TOOLING\DATA\Mydebug.dat"
        Try
            With My.Computer.FileSystem
                If .FileExists(localFileToolin) Then
                    GoTo tmp

                End If
                ' verifica si existe el path  
                If .FileExists(SPath) Then
                    File.Delete(localFileToolin)
                    File.Move(SPath, localFileToolin)
tmp:
                    ' lee todo el contenido  
                    Dim objReader As New System.IO.StreamReader(localFileToolin)

                    Do While objReader.Peek() <> -1
                        TextLine = objReader.ReadLine()
                        TestString = TextLine
                        Dim TestArray() As String = Split(TestString, ",")
                        Dim LastNonEmpty As Integer = 0
                        For i As Integer = 0 To 1
                            If TestArray(i) <> "" Then
                                'LastNonEmpty += 1
                                strDummysDate = TestArray(0)
                                strDummysHr = TestArray(1)
                                strDummyLine = TestArray(2)
                                If strDummyLine.Contains("A") Then
                                    strDummyLinea = "A"
                                End If
                                If strDummyLine.Contains("B") Then
                                    strDummyLinea = "V"
                                End If
                                If strDummyLine.Contains("C") Then
                                    strDummyLinea = "E"
                                End If
                                strUnion = strDummyLine.Substring(0, 2) + strDummyLinea
                                strDummysEmpl = Mid(TestArray(3), 2, 8)
                                strDummysPPackAnt = TestArray(4)
                                strDummysPPackNew = TestArray(5)
                                strDummysGreen = TestArray(6)
                                'text
                                strDummysTurno = Turno
                                If strDummyLine.Contains("A") Then
                                    strDummyPrensa = "CARGADO"
                                End If
                                If strDummyLine.Contains("B") Then
                                    strDummyPrensa = "VOLTEO"
                                End If
                                If strDummyLine.Contains("C") Then
                                    strDummyPrensa = "EXPULSION"
                                End If
                                strDummyArea = "COPPERING"
                                i = i + 1
                            End If
                        Next
                        '----------Modificacion para sacar el tiempo de uso del tooling que es reemplazado------------------------------------------
                        'Logica que hace la diferencia en segundos desde la fecha/hora que se capturo el Tooling
                        'hasta la fecha hora que lo esta bajando a la base
                        Dim FileTime, FileTimeEncontrado As DateTime 'FileTime es el que viene de MyDebug y FileEncontrado el que esta instalado
                        Dim SecDiff As Double 'Alacena la diferencia de MyDebug y cuando conectas ala HH
                        Dim StrHr, StrHrEncontrado As String
                        StrHr = strDummysDate + " " + strDummysHr
                        FileTime = Convert.ToDateTime(StrHr)
                        SecDiff = DateDiff(DateInterval.Second, FileTime, DateTime.Now)
                        Dim KHora As String = Format(CDate(strDummysHr), "HH:mm:ss")
                        Dim Kfecha As String = Format(CDate(strDummysDate), "yyyy-MM-dd")
                        Dim Ffech As String = Kfecha + " " + KHora
                        'hay que hacer una busqueda de la linea que traiga el ultimo TOOLINGID instalado
                        query = "Select * FROM Tooling.INFOLINES WHERE LINEA='" + strUnion + "' ORDER BY FECHA DESC"
                        db.SelectQueryReader(query)
                        Dim Encontrado0, Encontrado1, Encontrado15, Encontrado6 As String
                        Dim Encontrado16 As Integer

                        'identifica el reporte mas reciente para esa linea   
                        db.dReader.Read()
                        Encontrado0 = db.dReader.GetValue(0) 'trae la fecha
                        Encontrado1 = db.dReader.GetValue(1) 'trae la hora

                        Encontrado6 = db.dReader.GetString(6) 'trae el ToolingID que se esta quitando
                        ' Ese TOOLINgID que haga una resta del tiempo que se instalo este nuevo y el tiempo del encontrado
                        ''StrHrEncontrado = Encontrado0 ' + " " + Encontrado1
                        FileTimeEncontrado = Convert.ToDateTime(Encontrado0)

                        queryTool = "SELECT * FROM Tooling.TOOLLINES WHERE TOOLINGID='" + strDummysPPackNew + "'"
                        db.SelectQueryReader(queryTool)
                        db.dReader.Read()
                        Encontrado16 = db.dReader.GetValue(6) 'trae la vida
                        Encontrado15 = db.dReader.GetString(5) 'trae el status
                        Dim KEncontrado0 As String = Format(CDate(Encontrado0), "yyyy-MM-dd HH:mm:ss")


                        Dim ToolTotaltime As Integer

                        ToolTotaltime = DateDiff(DateInterval.Second, FileTimeEncontrado, FileTime)
                        'Logica que calcula la eficiencia de quien esta instalando el tooling:
                        'Calcula cuantos minutos lo cambio antes o despues
                        Dim CalcEficiencia As Double
                        CalcEficiencia = ToolTotaltime - Convert.ToDouble(Encontrado16)
                        'en el insert de abajo que suba el resultado de la resta y update al tooling ID viejo
                        Dim strUsingU As String = "U"
                        query = "INSERT INTO Tooling.INFOLINES (FECHA, HORA, TURNO, LINEA, PRENSA, AREA, TOOLINGID, PPACKANT, PPACKNUEVO, GREENPLATE, EMPLEADO, INSTALO, ESTADO, VIDA, QUITO, DURATOTAL, EFICIENCIA) VALUES ('" & Ffech & "','" & Ffech & "', '" & Turno & "','" & strUnion & "','" & strDummyPrensa & "','" & strDummyArea & "','" & strDummysPPackNew & "','" & strDummysPPackAnt & "','" & strDummysPPackNew & "','" & strDummysGreen & "','" & strDummysEmpl & "','" & strDummysEmpl & "','" & strUsingU & "','" & Encontrado16 & "','" & Encontrado6 & "','" & ToolTotaltime & "','" & CalcEficiencia & "')"
                        queryupd = "UPDATE Tooling.INFOLINES SET ESTADO = 'R', QUITO = '" & strDummysEmpl & "', DURATOTAL = '" & ToolTotaltime & "', EFICIENCIA = '" & CalcEficiencia & "' WHERE FECHA = '" & KEncontrado0 & "'" ''''AND HORA = #" & Encontrado1 & "#"
                        If Encontrado15 = "D" Then
                            queryupd = "UPDATE Tooling.INFOLINES SET QUITO = '" & strDummysEmpl & "', DURATOTAL = '" & "0" & "', EFICIENCIA = '" & "0" & "' WHERE FECHA = '" & KEncontrado0 & "'" ''' AND HORA = #" & Encontrado1 & "#"
                        End If
                        db.ModifyQuery(query)
                        db.ModifyQuery(queryupd)
                        db.CloseConnection()
                        TextLine = ""
                        '---------------------------------
                        'query = "SELECT STATUS FROM Tooling.TOOLLINES WHERE TOOLINGID = '" + strDummysPPackNew + "'"
                        query = "Select RUNNING.ESTADO FROM Tooling.RUNNING WHERE RUNNING.LINEA= '" + strUnion + "'"
                        db.SelectQueryReader(query)
                        strEstado = "X"
                        While db.dReader.Read()
                            strEstado = db.dReader.GetString(0)
                        End While
                        db.CloseConnection()

                        If strEstado = "X" Then
                            query = "INSERT INTO Tooling.RUNNING (FECHA,HORA,TURNO,LINEA,PRENSA,AREA,TOOLINGID,PPACKANT,PPACKNUEVO, GREENPLATE, EMPLEADO ,INSTALO, ESTADO, VIDA) VALUES ('" & Ffech & "','" & Ffech & "', '" & Turno & "','" & strUnion & "','" & strDummyPrensa & "','" & strDummyArea & "','" & strDummysPPackNew & "','" & strDummysPPackAnt & "','" & strDummysPPackNew & "','" & strDummysGreen & "','" & strDummysEmpl & "','" & strDummysEmpl & "','" & strEstado & "','" & Encontrado16 & "' )"
                            db.ModifyQuery(query)
                        Else
                            'Graba en la tabla Running la informacion del Tooling que estas instalando
                            If strEstado = "G" Or strEstado = "Y" Or strEstado = "R" Or strEstado = "D" Or strEstado = "U" Or strEstado = "P" Then
                                query = "UPDATE  Tooling.RUNNING SET FECHA ='" & Ffech & "', HORA ='" & Ffech & "', TURNO ='" & Turno & "', PRENSA='" & strDummyPrensa & "', AREA='" & strDummyArea & "', TOOLINGID='" & strDummysPPackNew & "', PPACKANT='" & strDummysPPackAnt & "', PPACKNUEVO='" & strDummysPPackNew & "', GREENPLATE= '" & strDummysGreen & "', EMPLEADO='" & strDummysEmpl & "', INSTALO='" & strDummysEmpl & "', ESTADO='G', VIDA='" & Encontrado16 & "'  WHERE LINEA='" + strUnion + "'"
                                db.ModifyQuery(query)
                            End If
                            ' Graba en TOOLINES con "U" el que estas poniendo y manda a "R" el que quitaste
                            g_IntSaveGrid = 1
                            Dim accessU, accessR As String
                            accessR = "UPDATE Tooling.TOOLLINES SET STATUS = 'R' where TOOLINGID='" & Encontrado6 & "'"
                            accessU = "UPDATE Tooling.TOOLLINES SET STATUS = 'U' where TOOLINGID='" & strDummysPPackNew & "'"

                            If Encontrado15 <> "D" Then
                                db.ModifyQuery(accessR)
                                db.CloseConnection()
                            End If
                            db.ModifyQuery(accessU)
                            db.CloseConnection()
                            g_IntSaveGrid = 0
                        End If
                    Loop
                    objReader.Close()
                    File.Delete(localFileToolin)
                End If
            End With
            ' errores   
        Catch ex As Exception
            'MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
            File.AppendAllText("c:\App\Tooling\data\logger.txt", Now + ", Error , " + strDummysPPackNew + " " + ex.Message.ToString + Chr(13) + Chr(10))
        End Try
LastLine:
    End Function


    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Public Sub DBtoFileRead()
        'Lee el archivo Running.txt y ajustar los colores de las lineas
        If System.IO.File.Exists(sDBtoFile) Then
            ' lee todo el contenido  
            Dim objReadRunning As New System.IO.StreamReader(sDBtoFile)
            Do While objReadRunning.Peek() <> -1
                TextLine = TextLine & objReadRunning.ReadLine() & vbNewLine
                TestString = TextLine
                Dim ArrayRunning() As String = Split(TestString, ",")
                Dim LastNonEmptyRunning As Integer = 0
                For i As Integer = 0 To 1
                    If ArrayRunning(i) <> "" Then
                        LastNonEmptyRunning += 1
                        StrFecha = ArrayRunning(i)
                        'StrHora = ArrayRunning(i + 1)
                        strDummyLine = ArrayRunning(i + 1)
                        StrToolingID = ArrayRunning(i + 2)
                        StrEstado = ArrayRunning(i + 3)
                        StrVida = ArrayRunning(i + 4)
                        StrUsoFile = ArrayRunning(i + 5).Trim()
                        i = i + 1
                        Dim StrEstadoY As String = StrVida - 1200
                        If Convert.ToDouble(StrUsoFile) > Convert.ToDouble(StrEstadoY) And Convert.ToDouble(StrUsoFile) < Convert.ToDouble(StrVida) Then
                            StrEstado = "Y"
                        End If
                        strDummyLine = strDummyLine + StrEstado + StrVida
                        If strDummyLine.Contains("01") Then
                            UpdateTableStatusLine1(strDummyLine)
                        End If
                        If strDummyLine.Contains("02") Then
                            UpdateTableStatusLine2(strDummyLine)
                        End If
                        If strDummyLine.Contains("03") Then
                            UpdateTableStatusLine3(strDummyLine)
                        End If
                        If strDummyLine.Contains("04") Then
                            UpdateTableStatusLine4(strDummyLine)
                        End If
                        If strDummyLine.Contains("05") Then
                            UpdateTableStatusLine5(strDummyLine)
                        End If
                        If strDummyLine.Contains("06") Then
                            UpdateTableStatusLine6(strDummyLine)
                        End If
                        If strDummyLine.Contains("07") Then
                            UpdateTableStatusLine7(strDummyLine)
                        End If
                        If strDummyLine.Contains("08") Then
                            UpdateTableStatusLine8(strDummyLine)
                        End If
                        If strDummyLine.Contains("09") Then
                            UpdateTableStatusLine9(strDummyLine)
                        End If
                        If strDummyLine.Contains("10") Then
                            UpdateTableStatusLine10(strDummyLine)
                        End If
                        If strDummyLine.Contains("11") Then
                            UpdateTableStatusLine11(strDummyLine)
                        End If
                        If strDummyLine.Contains("13") Then
                            UpdateTableStatusLine13(strDummyLine)
                        End If
                    End If
                Next
                TextLine = ""
                ReDim Preserve ArrayRunning(LastNonEmptyRunning)
            Loop
            objReadRunning.Close()
        End If
    End Sub
End Class