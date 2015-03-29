Imports System.Net
Imports System.ComponentModel

Public Class Form1
    Dim autoupdate As String = My.Settings.CheckForUpdate
    Dim latestversion As String = "1.0.0.0"
    Dim downlink As String
    Dim vlauncher As String = "http://pastebin.com/raw.php?i=FgUgEfMt"
    Dim vdownload As String = "http://pastebin.com/raw.php?i=TkYj2SdZ"
    Dim servername = "AltisDEV"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If autoupdate = "True" Then
            Dim Str As System.IO.Stream
            Dim srRead As System.IO.StreamReader
            Dim Str2 As System.IO.Stream
            Dim srRead2 As System.IO.StreamReader

            Try

                Dim req As System.Net.WebRequest = System.Net.WebRequest.Create(vlauncher)
                Dim resp As System.Net.WebResponse = req.GetResponse
                Str = resp.GetResponseStream
                srRead = New System.IO.StreamReader(Str)

                latestversion = srRead.ReadToEnd
                My.Settings.LatestVersion = latestversion
            Catch ex As Exception
                MsgBox("Could recieve latest version!" & vbNewLine & " Please check your internet connection!", MsgBoxStyle.Information, "Auto Update")

            Finally

            End Try

            Try

                Dim req2 As System.Net.WebRequest = System.Net.WebRequest.Create(vdownload)
                Dim resp2 As System.Net.WebResponse = req2.GetResponse
                Str2 = resp2.GetResponseStream
                srRead2 = New System.IO.StreamReader(Str2)

                downlink = srRead2.ReadToEnd
            Catch ex As Exception

            End Try
        Else
        End If



        LatestVersionL.Text = latestversion
        MyVersionL.Text = "1.0.0.0"

        If LatestVersionL.Text = "1.0.0.0" Then
            MyVersionL.ForeColor = Color.Green
        Else
            MsgBox("Update available!", MsgBoxStyle.Information, "Auto Update")
            MyVersionL.ForeColor = Color.Red
            DownloadButton.Visible = True
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            My.Settings.CheckForUpdate = "True"
            My.Settings.Save()
        Else
            My.Settings.CheckForUpdate = "False"
            My.Settings.Save()
        End If
    End Sub

    Private Sub DownloadButton_Click(sender As Object, e As EventArgs) Handles DownloadButton.Click
        Dim client As WebClient = New WebClient
        AddHandler client.DownloadProgressChanged, AddressOf Me.client_DownloadProgressChanged
        AddHandler client.DownloadFileCompleted, AddressOf Me.client_DownloadFileCompleted
        ' Starts the download
        client.DownloadFileAsync(New Uri(downlink), Application.StartupPath + "/" & servername & ".exe")
        DownloadButton.Text = "Download In Process"
        DownloadButton.Enabled = False
    End Sub

    Private Sub DownloadLink_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)

    End Sub

    Private Sub client_DownloadProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString)
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString)
        Dim percentage As Double = (bytesIn / (totalBytes * 100))
        If loadingbar.Value = 100 Then
            loadingbar.Value = loadingbar.Value - 1
        Else
            loadingbar.Value = loadingbar.Value + 1
        End If
    End Sub

    Private Sub client_DownloadFileCompleted(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs)
        loadingbar.Value = loadingbar.Value + 1
        MsgBox("Download Completed", MsgBoxStyle.Information, "Auto Update")
        DownloadButton.Text = "Start Download"
        DownloadButton.Enabled = True
        Application.Exit()
        Process.Start("AltisDEV.exe")
    End Sub
End Class
