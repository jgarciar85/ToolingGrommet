Imports System.Globalization
Imports System.Data.OleDb
Imports System.IO
Public Class Registro
    Private Sub btnRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegistrar.Click
        Dim FILE_NAME As String = "C:\APP\Tooling\DATA\Tecnicos.DAT"

        Dim StrTec, Strdum1, Strdum2 As String
        Dim Tecflag As Integer = 1

        Dim myStream As System.IO.StreamReader = New System.IO.StreamReader(FILE_NAME)
        Dim Line1 As String = ""



        If txtNombre.Text <> "" And txtNumero.Text <> "" Then
            Do
                Line1 = myStream.ReadLine()  'Read everyline of the ToolBAD.txt file
                If Line1 Is Nothing Then
                    Exit Do
                End If
                Dim sAry As String() = Split(Line1, ",")  ' separate the fields <strong class="highlight">of</strong> the current row
                Strdum1 = sAry(0)
                Strdum2 = sAry(1)

                If (Strdum1 = txtNumero.Text) Then
                    MsgBox("Este tecnico ya esta Registrado")
                    Tecflag = 0
                End If

            Loop



        Else
            MsgBox("Captura los campos")
        End If
        myStream.Close()

        Dim objWriter As New System.IO.StreamWriter(FILE_NAME, True)
        If Tecflag = 1 Then
            StrTec = txtNumero.Text + "," + txtNombre.Text

            objWriter.WriteLine(StrTec)
            If System.IO.File.Exists(FILE_NAME) = False Then
                System.IO.File.Create(FILE_NAME).Dispose()
            End If
        End If

        objWriter.Close()
        Me.Close()
    End Sub
End Class