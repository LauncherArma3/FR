Imports System
Imports System.IO
Imports System.ComponentModel
Imports Microsoft.Win32
Imports System.Diagnostics
Imports System.IO.PathTooLongException
Imports System.Net
Imports System.Text
Imports System.Security.Cryptography

Public Class Form1

    Dim website = "http://altisliferpg.livehost.fr/" 'Le lien du FTP ( La ou sont tout les fichier requie , update.txt etc ... )
    Dim servername = "AltisDEV" 'Le nom de votre serveur
    Dim mods = "AltisDEV" 'Le nom que votre pack mods sans le "@" ( ex:"CBA" ce qui donnera " @CBA " dans le dossier d'arma 3)
<<<<<<< HEAD
    Dim VALOR As String
    Dim VALOR2 As String
=======

>>>>>>> parent of 7b705d2... Revert "Revert "Revert "LauncherArma3FR"""
    Dim facebook As String = "https://www.facebook.com/pages/Altisdev-French-Website/1548888018673436"
    Dim twitter As String = "https://twitter.com/Altisdev"
    Dim youtube As String = "https://www.youtube.com/renildomarcio"
    Dim forum As String = "http://altisdev.com"

    Dim news = "news.txt" 'Le fichier .txt ou est inscript un petit message à afficher en haut du launcher
    Dim vlauncher As String = "vlauncher.txt" 'Le fichier ou est inscript dedans la dernière version du launcher
    Dim appdata As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & servername & "\" ' Destination ou le launcher a besoin de mettre les fichier.
    Dim textnews As String = "Loading ..." ' Le message de base si les news ne sont pas charger
    Dim noticias As String = news

    ' A ne pas changer sinon risque de crash !
    Dim destination As String = "" 'Ne pas changer :D
    Dim ligne As String 'Ne pas changer :D
    Dim nbr_ligne As String = 0 'Ne pas changer :D
    Dim number As String = 0 'Ne pas changer :D
    Dim dlauncher As String = Application.StartupPath & "\" 'Ne pas changer :D
    Dim fichier As String
<<<<<<< HEAD
    Dim vmods = "vmods.txt" 'Le fichier ou est inscript dedans la dernière version des mods
    Dim dmods As String = "mods" 'Le nom du dossier ou ce trouve les mods
    Dim user As String = Environment.UserName 'Detecte le nom d'utilisateur du PC



    Sub New()

        InitializeComponent()

        VALOR = GetSetting(My.Application.Info.AssemblyName, "CONFIG", "ULTIMO_VALOR")
        VALOR2 = GetSetting(My.Application.Info.AssemblyName, "CONFIG", "ULTIMO_VALOR2")

        If (VALOR2 <> Nothing) Then

            PositronTextBox2.Text = (VALOR2)

        End If
        If (VALOR <> Nothing) Then
            PositronTextBox1.Text = (VALOR)
        End If
    End Sub
=======
>>>>>>> parent of 7b705d2... Revert "Revert "Revert "LauncherArma3FR"""

    Private Function FValidaCampos() As Boolean

        If PositronTextBox1.Text = "" Then
            MsgBox("Remplissez le champ Nom!", MsgBoxStyle.Information, "Launcher AltisDEV")
            PositronTextBox1.Focus()
            Return False
        End If
        If PositronTextBox2.Text = "" Then
            MsgBox("Remplissez le champ Mot de passe!", MsgBoxStyle.Information, "Launcher AltisDEV")
            PositronTextBox2.Focus()
            Return False
        End If

        Return True
    End Function

    Function LoginIPB_By_RenildoMarcio(ByVal user As String, ByVal pass As String) As Boolean
        Dim logincookie As CookieContainer
<<<<<<< HEAD
        Dim postData As String = "auth_key=xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx&ips_username=" & user & "&ips_password=" & pass & "&rememberMe=1"
=======
        Dim postData As String = "auth_key=xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx&ips_username=" & user & "&ips_password=" & pass & "&rememberMe=1"
>>>>>>> parent of 7b705d2... Revert "Revert "Revert "LauncherArma3FR"""

        Dim tempCookies As New CookieContainer
        Dim encoding As New UTF8Encoding
        Dim byteData As Byte() = encoding.GetBytes(postData)

        Dim postReq As HttpWebRequest = DirectCast(WebRequest.Create("http://website.com/index.php?app=core&module=global&section=login&do=process"), HttpWebRequest)
        postReq.Method = "POST"
        postReq.KeepAlive = True
        postReq.CookieContainer = tempCookies
        postReq.ContentType = "application/x-www-form-urlencoded"
        postReq.Referer = "http://website.com/index.php?app=core&module=global&section=login&do=process"
        postReq.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.1; ru; rv:1.9.2.3) Gecko/20100401 Firefox/4.0 (.NET CLR 3.5.30729)"
        postReq.ContentLength = byteData.Length

        Dim postreqstream As Stream = postReq.GetRequestStream()
        postreqstream.Write(byteData, 0, byteData.Length)
        postreqstream.Close()
        Dim postresponse As HttpWebResponse
        On Error Resume Next
        postresponse = DirectCast(postReq.GetResponse(), HttpWebResponse)
        tempCookies.Add(postresponse.Cookies)
        logincookie = tempCookies
        Dim postreqreader As New StreamReader(postresponse.GetResponseStream())

        If postreqreader.ReadToEnd.Contains("Mon profil") Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub PositronButton1_Click(sender As Object, e As EventArgs) Handles PositronButton1.Click
<<<<<<< HEAD
        Application.Exit()
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If PositronCheckBox1.Checked = True Then

            SaveSetting(Application.ProductName, Application.ProductName, "CheckBox1", PositronCheckBox1.Checked)
            SaveSetting(My.Application.Info.AssemblyName, "CONFIG", "ULTIMO_VALOR2", PositronTextBox2.Text)
        Else
            PositronTextBox2.Clear()
            SaveSetting(My.Application.Info.AssemblyName, "CONFIG", "ULTIMO_VALOR2", PositronTextBox2.Text)
            SaveSetting(Application.ProductName, Application.ProductName, "CheckBox1", PositronCheckBox1.Checked)

        End If
    End Sub
    Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)

        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())

        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())

        Dim percentage As Double = bytesIn / totalBytes * 100

    End Sub

    Private Sub client_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)

        nbr_ligne += 1


        If nbr_ligne - 3 > 1 Then

        End If
        If number - nbr_ligne + 3 = 0 Then

        End If
        If number = 0 Then

        End If



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Computer.FileSystem.FileExists(dlauncher & "UP.exe") Then
            My.Computer.FileSystem.DeleteFile(dlauncher & "UP.exe")
        End If
        If My.Computer.FileSystem.FileExists(dlauncher & "update.txt") Then
            My.Computer.FileSystem.DeleteFile(dlauncher & "update.txt")
        End If
        If My.Computer.FileSystem.FileExists(dlauncher & "site.txt") Then
            My.Computer.FileSystem.DeleteFile(dlauncher & "site.txt")
        End If
=======
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Message.RunWorkerAsync() 'Lance ce qu'il faut pour afficher les news 

>>>>>>> parent of 7b705d2... Revert "Revert "Revert "LauncherArma3FR"""
        If My.Computer.FileSystem.FileExists(appdata & news) Then
            My.Computer.FileSystem.DeleteFile(appdata & news)
        End If
        My.Computer.Network.DownloadFile(website & news, appdata & news)
        textnews = My.Computer.FileSystem.ReadAllText(appdata & news)


        ListView1.View = View.Details
        ListView1.Columns.Add("Date", 100)
        ListView1.Columns.Add("Catégorie", 100)
        ListView1.Columns.Add("Message", 200)

        Try
            ' Declare StreamReader and pass the Path of the ini file to be read as a Parameter
            ' Message.RunWorkerAsync() 'Lance ce qu'il faut pour afficher les news
            Dim MyStream As New StreamReader(appdata & "\news.txt")
            ' A string array to hold each line as it is read
            Dim strTemp() As String
            '  Code that reads the file line by line
            Do While MyStream.Peek <> -1 ' Use Peek to read the file until there are no more lines
                Dim LVItem As New ListViewItem
                ' Split the line using the -  delimiter
                strTemp = MyStream.ReadLine.Split("-"c)
                ' Assign the content of the first element of the array to the first column
                LVItem.Text = strTemp(0).ToString
                ' Then add the item to the ListView
                ListView1.Items.Add(LVItem)
                ' Assign the content of the second element to the next column
                LVItem.SubItems.Add(strTemp(1).ToString)
                '  Check if there is a third section.  If so, assign it to the next column
                If strTemp.Length > 2 Then LVItem.SubItems.Add(strTemp(2).ToString)
            Loop

            MyStream.Close() ' Close the StreamReader
        Catch ex As Exception
            MessageBox.Show("Error reading file." & ex.Message)
        End Try
<<<<<<< HEAD
        My.Computer.FileSystem.CreateDirectory("C:/Launcher/")

        If My.Computer.FileSystem.FileExists("C:/Launcher/listpack.txt") Then
            My.Computer.FileSystem.DeleteFile("C:/Launcher/listpack.txt")
        Else
        End If
        My.Computer.FileSystem.WriteAllText("C:/Launcher/listpack.txt", "updatepack.txt" & vbNewLine & "basepack.txt" & vbNewLine & "delete.txt", False)

        Dim src As New StreamReader("C:/Launcher/listpack.txt")


        While src.Peek <> -1
            ligne = src.ReadLine()
            If My.Computer.FileSystem.FileExists("C:/Launcher" & ligne) Then
                My.Computer.FileSystem.DeleteFile("C:/Launcher/" & ligne)
            Else
            End If
            Dim Download As WebClient = New WebClient
            AddHandler Download.DownloadProgressChanged, AddressOf client_ProgressChanged
            AddHandler Download.DownloadFileCompleted, AddressOf client_DownloadCompleted
            Download.DownloadFileAsync(New Uri(website & ligne), "C:/Launcher/" & ligne)
        End While
        Form1Load.RunWorkerAsync()
    End Sub


=======

    End Sub

>>>>>>> parent of 7b705d2... Revert "Revert "Revert "LauncherArma3FR"""
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Process.Start("https://server.nitrado.net/fre/ArmA-3-Gameserver-mieten?pk_campaign=FRE_AltisDev")
    End Sub

    Private Sub PositronButton2_Click(sender As Object, e As EventArgs) Handles PositronButton2.Click
<<<<<<< HEAD
        If (PositronTextBox1.Text <> Nothing) Then
            SaveSetting(My.Application.Info.AssemblyName, "CONFIG", "ULTIMO_VALOR", PositronTextBox1.Text)
        Else
            MsgBox("Digite seu nome de usuario!")
        End If
        If PositronCheckBox1.Checked = True Then

        End If
        If FValidaCampos() = False Then Exit Sub
        If LoginIPB_By_RenildoMarcio(PositronTextBox1.Text, PositronTextBox2.Text) = True Then
            NotifyIcon1.ShowBalloonTip(500, "Bienvenue " & PositronTextBox1.Text & " à Launcher Arma3!", "Développé par RenildoMarcio", ToolTipIcon.Info)
=======
        If FValidaCampos() = False Then Exit Sub
        If LoginIPB_By_RenildoMarcio(PositronTextBox1.Text, PositronTextBox2.Text) = True Then
            MsgBox("Bienvenue " & PositronTextBox1.Text, MsgBoxStyle.Information, "Launcher AltisDEV")
>>>>>>> parent of 7b705d2... Revert "Revert "Revert "LauncherArma3FR"""
            Form2.Show()
            Me.Hide()
        Else : MsgBox("Connexion ou mot de passe incorrect ")
        End If
    End Sub

    Private Sub PositronButton4_Click(sender As Object, e As EventArgs) Handles PositronButton4.Click
<<<<<<< HEAD
        Process.Start("http://website.com/index.php?app=core&module=global&section=register")
    End Sub

    Private Sub PositronButton3_Click(sender As Object, e As EventArgs) Handles PositronButton3.Click
        Process.Start("http://website.com/index.php?app=core&module=global&section=lostpass")
=======
        Process.Start("http://altisdev.com/index.php?app=core&module=global&section=register")
    End Sub

    Private Sub PositronButton3_Click(sender As Object, e As EventArgs) Handles PositronButton3.Click
        Process.Start("http://altisdev.com/index.php?app=core&module=global&section=lostpass")
>>>>>>> parent of 7b705d2... Revert "Revert "Revert "LauncherArma3FR"""
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Process.Start(facebook)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Process.Start(twitter)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Process.Start(youtube)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Process.Start(forum)
    End Sub
<<<<<<< HEAD

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        
    End Sub
    Private Sub DownloadUpdateLauncher_DoWork(sender As Object, e As DoWorkEventArgs) Handles DownloadUpdateLauncher.DoWork
        If My.Computer.FileSystem.FileExists(dlauncher & "UP.exe") Then
            My.Computer.FileSystem.DeleteFile(dlauncher & "UP.exe")
        Else
            If My.Computer.FileSystem.FileExists(dlauncher & "update.txt") Then
                My.Computer.FileSystem.DeleteFile(dlauncher & "update.txt")
            End If
            My.Computer.FileSystem.WriteAllText(dlauncher & "update.txt", Application.ExecutablePath, False)
            My.Computer.FileSystem.WriteAllText(dlauncher & "site.txt", website & servername & ".exe", False)
            My.Computer.Network.DownloadFile(website & "UP.exe", dlauncher & "UP.exe")
            Process.Start(dlauncher & "UP.exe")
            Application.Exit()
        End If
    End Sub
    Private Sub update_DoWork(sender As Object, e As DoWorkEventArgs) Handles updatelauncher.DoWork
        If My.Computer.FileSystem.FileExists(appdata & vlauncher) Then
            My.Computer.FileSystem.DeleteFile(appdata & vlauncher)
        End If
        My.Computer.Network.DownloadFile(website & vlauncher, appdata & vlauncher)

        Dim file3 = My.Computer.FileSystem.ReadAllText(appdata & vlauncher)
        Dim file4 = Application.ProductVersion

        If file3 = file4 Then
        Else

            If MsgBox("Une mise à jour du launcher est disponible." & vbNewLine & "Voulez vous effectuer cette mise à jour ?" & vbNewLine & vbNewLine & "Acienne version du launcher: " & file4 & vbNewLine & "Nouvelle version du launcher: " & file3, MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation) = vbYes Then

                DownloadUpdateLauncher.RunWorkerAsync()
            End If

        End If

    End Sub

=======
>>>>>>> parent of 7b705d2... Revert "Revert "Revert "LauncherArma3FR"""
End Class
