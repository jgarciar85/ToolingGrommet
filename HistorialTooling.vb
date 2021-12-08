Imports System.Data.OleDb
Public Class HistorialTooling

    Private Sub HistorialTooling_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        GridHistTool.Visible = False
        btnHistorial.Visible = False
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnHistorial_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHistorial.Click
        Dim DownTimeCnnStr As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\APP\TOOLING\Data\PINPACK.mdb;Persist Security Info=False;" 'Jet OLEDB:Database" ' Password=INGENIERIA"        
        Dim conn1 As New System.Data.OleDb.OleDbConnection(DownTimeCnnStr)

        btnHistorial.Visible = False
        GridHistTool.Visible = True

        Dim DsetHist As New DataSet()
        DsetHist.Clear()

        conn1.Open()
        Dim Dadapter As New OleDbDataAdapter("SELECT FECHA, TURNO, LINEA, PRENSA, TOOLINGID, QTYLABIOSDOBLADOS, LAINA, EMPLEADO, INSTALO, VIDA, QUITO, DURATOTAL, REPARO, FECHAREP, QTYPINESDOBLADOS, QTYPINESQUEBRADOS FROM INFOLINES WHERE TOOLINGID='" + lblToolH.Text + "' ORDER BY FECHA DESC", conn1)
        Dadapter.Fill(DsetHist, "TOOLHIST")
        GridHistTool.DataSource = DsetHist.Tables("TOOLHIST").DefaultView
        conn1.Close()

    End Sub
End Class