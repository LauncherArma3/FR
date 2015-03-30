Imports System
Imports System.IO
Imports System.ComponentModel
Imports Microsoft.Win32
Imports System.Diagnostics
Imports System.IO.PathTooLongException
Imports System.Net

Public Class Form2
    Dim website = "http://altisliferpg.livehost.fr/" 'Le lien du FTP ( La ou sont tout les fichier requie , update.txt etc ... )
    Dim servername = "AltisDEV" 'Le nom de votre serveur
    Dim mods = "AltisDEV" 'Le nom que votre pack mods sans le "@" ( ex:"CBA" ce qui donnera " @CBA " dans le dossier d'arma 3)

    'Information de votre serveur moddé ( A changer aussi :D )'
    Dim forum As String = "http://altisdev.com" ' Le forum, site ou autre 
    Dim facebook As String = "https://www.facebook.com/pages/Altisdev-French-Website/1548888018673436"
    Dim twitter As String = "https://twitter.com/Altisdev"
    Dim youtube As String = "https://www.youtube.com/renildomarcio"
    Dim ipserveur As String = "37.187.149.179:2302" 'L'ip de votre serveur arma 3
    Dim servpassword As String = "none" 'Le mods de passe de votre serveur arma 3 ( si vous n'en avez pas laissé " none " )
    Dim teamspeak As String = "teamspeak1.mtxserv.fr" 'L'ip de votre TeamSpeak (sans port !)
    Dim TSport As String = "10030" 'Le port de votre TS si besoin. ( Si vous n'avez pas de port pour votre TS mettez " none " ex:    Dim TSport = "none"  )


    'Pas important pour vous :D (mais vous pouvez changer si vous savez ce que vous faite ! ) :D'
    Dim donwlodmodsbr = "C:/Launcher/"
    Dim news = "news.txt" 'Le fichier .txt ou est inscript un petit message à afficher en haut du launcher
    Dim vmods = "vmods.txt" 'Le fichier ou est inscript dedans la dernière version des mods
    Dim vlauncher As String = "vlauncher.txt" 'Le fichier ou est inscript dedans la dernière version du launcher
    Dim dmods As String = "mods" 'Le nom du dossier ou ce trouve les mods
    Dim appdata As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & servername & "\" ' Destination ou le launcher a besoin de mettre les fichier.
    Dim user As String = Environment.UserName 'Detecte le nom d'utilisateur du PC
    Dim textnews As String = "Loading ..." ' Le message de base si les news ne sont pas charger



    ' A ne pas changer sinon risque de crash !
    Dim destination As String = "" 'Ne pas changer :D
    Dim ligne As String 'Ne pas changer :D
    Dim nbr_ligne As String = 0 'Ne pas changer :D
    Dim number As String = 0 'Ne pas changer :D
    Dim dlauncher As String = Application.StartupPath & "\" 'Ne pas changer :D
    Dim fichier As String
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.ImageLocation = "http://cache.www.gametracker.com/server_info/" & ipserveur & "/b_350_20_692108_381007_FFFFFF_000000.png"

        If My.Computer.FileSystem.FileExists(dlauncher & "UP.exe") Then
            My.Computer.FileSystem.DeleteFile(dlauncher & "UP.exe")
        End If
        If My.Computer.FileSystem.FileExists(dlauncher & "update.txt") Then
            My.Computer.FileSystem.DeleteFile(dlauncher & "update.txt")
        End If
        If My.Computer.FileSystem.FileExists(dlauncher & "site.txt") Then
            My.Computer.FileSystem.DeleteFile(dlauncher & "site.txt")
        End If
        PositronTheme1.Text = "Launcher " & servername

        downloadmods.Text = "Chargement..."
        versao.Text = "Version du launcher: " & Application.ProductVersion
        updatemods.RunWorkerAsync() ' On vois si il n'y a pas de mise à jour des mods
        My.Computer.FileSystem.CreateDirectory(appdata) 'On crée un dossier pour y placer tout ce don le launcher a besoin
        user_log.Text = "Identifié en tant que :  " & user  ' Un truc pas utile :D
        If My.Computer.FileSystem.FileExists(appdata & "destination.a3") Then ' On verifie si la destination à deja été choisi
            destination = My.Computer.FileSystem.ReadAllText(appdata & "destination.a3")
            destino.Text = "Destination d'Arma3: "" " & destination & " """
            If My.Computer.FileSystem.FileExists(destination & "arma3.exe") Then
            Else
                MsgBox("La destination d'Arma3 n'est pas valide !")
            End If
        Else

            If MsgBox("Aucune destination selectionné pour Arma3, voulez vous la selectionner ?", MsgBoxStyle.YesNo, "Destination Arma3 non dispo.") = vbYes Then
                FolderBrowserDialog1.ShowDialog()
                destination = FolderBrowserDialog1.SelectedPath & "\"
                My.Computer.FileSystem.WriteAllText(appdata & "destination.a3", destination, False)
                If My.Computer.FileSystem.FileExists(destination & "arma3.exe") Then
                Else
                    MsgBox("La destination choisi n'est pas valide !")
                End If
                destino.Text = "Destination d'Arma3: "" " & destination & " """
                downloadmods.Enabled = True
            End If
        End If


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
        Form2Load.RunWorkerAsync()
    End Sub

    Private Sub PositronButton1_Click(sender As Object, e As EventArgs) Handles registroarma3.Click
        FolderBrowserDialog1.ShowDialog()
        destination = FolderBrowserDialog1.SelectedPath & "\"
        My.Computer.FileSystem.WriteAllText(appdata & "destination.a3", destination, False)
        destino.Text = "Destination d'Arma3: "" " & destination & " """
        If My.Computer.FileSystem.FileExists(destination & "arma3.exe") Then
        Else
            MsgBox("La destination choisi n'est pas valide !")
        End If
    End Sub

    Private Sub PositronButton8_Click(sender As Object, e As EventArgs) Handles credits.Click
        Me.Hide()
        credits.Show() 'Crédit ne pas changer SVP !
    End Sub

    Private Sub updatemods_DoWork(sender As Object, e As DoWorkEventArgs) Handles updatemods.DoWork 'Verifie si il y a une mise à jour des mods
        If My.Computer.FileSystem.FileExists(appdata & vmods) Then
            My.Computer.FileSystem.DeleteFile(appdata & vmods)
        End If
        My.Computer.Network.DownloadFile(website & vmods, appdata & vmods)
        If My.Computer.FileSystem.FileExists(donwlodmodsbr & "basepack.txt") Then
            Dim file1 = My.Computer.FileSystem.ReadAllText(appdata & vmods)
            Dim file2 = My.Computer.FileSystem.ReadAllText(donwlodmodsbr & "basepack.txt")
            'On verifie si les deux fichiers corresponde
            If file1 = file2 Then
            Else

                If MsgBox("Une mise à jour des mods est disponible." & vbNewLine & "Voulez vous effectuer cette mise à jour ?" & vbNewLine & vbNewLine & "Acienne version des mods: " & file2 & vbNewLine & "Nouvelle version des mods: " & file1, MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation) = vbYes Then
                    ' On fait la mise à jour des mods
                    If My.Computer.FileSystem.FileExists(donwlodmodsbr & "basepack.txt") Then
                        My.Computer.FileSystem.DeleteFile(donwlodmodsbr & "basepack.txt")
                    End If
                    My.Computer.FileSystem.RenameFile(appdata & vmods, "basepack.txt")
                End If

            End If
        End If

        updatelauncher.RunWorkerAsync() 'On vois si il y à une mise à jour launcher
    End Sub

    Private Sub update_DoWork(sender As Object, e As DoWorkEventArgs) Handles updatelauncher.DoWork
        If My.Computer.FileSystem.FileExists(appdata & vlauncher) Then
            My.Computer.FileSystem.DeleteFile(appdata & vlauncher)
        End If
        My.Computer.Network.DownloadFile(website & vlauncher, appdata & vlauncher)

        Dim file3 = My.Computer.FileSystem.ReadAllText(appdata & vlauncher)
        Dim file4 = Application.ProductVersion
        'On verifie si les deux fichiers corresponde
        If file3 = file4 Then
        Else

            If MsgBox("Une mise à jour du launcher est disponible." & vbNewLine & "Voulez vous effectuer cette mise à jour ?" & vbNewLine & vbNewLine & "Acienne version du launcher: " & file4 & vbNewLine & "Nouvelle version du launcher: " & file3, MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation) = vbYes Then
                ' On fait la mise à jour du launcher!
                DownloadUpdateLauncher.RunWorkerAsync()
            End If

        End If
        Message.RunWorkerAsync() 'Lance ce qu'il faut pour afficher les news
    End Sub

    Private Sub PositronButton3_Click(sender As Object, e As EventArgs) Handles attmods.Click
        If downloadmods.Text = "Chargement..." Then
            MsgBox("Veuillez patienter, une action est déjà en cours..." & vbNewLine)
        Else

            If downloadmods.Enabled = False Then
                downloadmods.Enabled = True
            End If
            If My.Computer.FileSystem.FileExists(donwlodmodsbr & "basepack.txt") Then

                If My.Computer.FileSystem.FileExists(appdata & "destination.a3") Then
                    My.Computer.FileSystem.CreateDirectory(destination & "@" & mods)
                    My.Computer.FileSystem.CreateDirectory(destination & "@" & mods & "\addons\")
                Else
                    MsgBox("Attention !" & vbNewLine & "Il faut d'abord choisir une destination pour arma 3", MsgBoxStyle.Exclamation)
                End If
                Dim filenumber() As String = File.ReadAllLines("C:/Launcher/updatepack.txt")
                number = filenumber.Length
                Dim sr As New StreamReader("C:/Launcher/updatepack.txt")
                Dim dlist As New StreamReader("C:/Launcher/delete.txt") 'ne pas changer !
                Dim list As String
                list = dlist.ReadLine()
                'Script de base de donné
                If number = 0 Then
                    MsgBox("Aucune mise à jour disponible !")
                Else

                    'On cache les trucs inutile
                    PictureBox2.Visible = False
                    'On montre ce qui est utile
                    PositronProgressBar1.Visible = True
                    PositronProgressBar2.Visible = True
                    ft.Visible = True
                    nft.Visible = True
                    fr.Visible = True
                    'On bloque les bouton inutiles
                    downloadmods.Enabled = False
                    attmods.Enabled = False
                    'PositronButton4.Enabled = False

                    While sr.Peek <> -1
                        ligne = sr.ReadLine()
                        If My.Computer.FileSystem.FileExists(destination & "@" & mods & "\addons\" & ligne) Then
                            My.Computer.FileSystem.DeleteFile(destination & "@" & mods & "\addons\" & ligne)
                        End If

                        Dim Client As WebClient = New WebClient
                        AddHandler Client.DownloadFileCompleted, AddressOf client_DownloadCompleted
                        AddHandler Client.DownloadProgressChanged, AddressOf client_ProgressChanged
                        Client.DownloadFileAsync(New Uri(website & dmods & "/" & ligne), destination & "@" & mods & "\addons\" & ligne)

                    End While
                    fr.Text = "Mods total à télécharger: " & number

                    If list = "" Then
                    Else

                    End If
                End If
            Else
                MsgBox("Il faut d'abord installer les mods !")
            End If
        End If
    End Sub

    Private Sub PositronButton2_Click(sender As Object, e As EventArgs) Handles downloadmods.Click
        If My.Computer.FileSystem.FileExists(donwlodmodsbr & "basepack.txt") Then

            If My.Computer.FileSystem.FileExists(appdata & "destination.a3") Then
                My.Computer.FileSystem.CreateDirectory(destination & "@" & mods)
                My.Computer.FileSystem.CreateDirectory(destination & "@" & mods & "\addons\")
            Else
                MsgBox("Attention !" & vbNewLine & "Il faut d'abord choisir une destination pour arma 3", MsgBoxStyle.Exclamation)
            End If
            Dim filenumber() As String = File.ReadAllLines("C:/Launcher/basepack.txt")
            number = filenumber.Length
            Dim sr As New StreamReader("C:/Launcher/basepack.txt")
            'Script de base de donné
            If number = 0 Then
                MsgBox("Aucune mise à jour disponible !")
            Else

                'On cache les trucs inutile
                PictureBox2.Visible = False
                'On montre ce qui est utile
                PositronProgressBar1.Visible = True
                PositronProgressBar2.Visible = True
                ft.Visible = True
                nft.Visible = True
                fr.Visible = True
                'On bloque les bouton inutiles
                downloadmods.Enabled = False
                attmods.Enabled = False
                'PositronButton4.Enabled = False


                While sr.Peek <> -1
                    ligne = sr.ReadLine()
                    If My.Computer.FileSystem.FileExists(destination & "@" & mods & "\addons\" & ligne) Then
                        My.Computer.FileSystem.DeleteFile(destination & "@" & mods & "\addons\" & ligne)
                    End If

                    Dim Client As WebClient = New WebClient
                    AddHandler Client.DownloadFileCompleted, AddressOf client_DownloadCompleted
                    AddHandler Client.DownloadProgressChanged, AddressOf client_ProgressChanged
                    Client.DownloadFileAsync(New Uri(website & dmods & "/" & ligne), destination & "@" & mods & "\addons\" & ligne)

                End While
                fr.Text = "Mods total à télécharger: " & number
            End If

        End If
    End Sub

    Private Sub client_ProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
        'Ne pas toucher
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())

        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())

        Dim percentage As Double = bytesIn / totalBytes * 100
        PositronProgressBar1.Value = Int32.Parse(Math.Truncate(percentage).ToString())
    End Sub

    Private Sub client_DownloadCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        ' Ne pas toucher ! 
        nbr_ligne += 1
        ft.Text = "Mod(s) téléchargé: " & nbr_ligne - 3
        nft.Text = "Mod(s) restant(s): " & number - nbr_ligne + 3

        If nbr_ligne - 3 > 1 Then
            PositronProgressBar2.Value = (nbr_ligne - 3) * 100 / number
        End If
        If number - nbr_ligne + 3 = 0 Then
            attmods.Enabled = True
            'PositronButton4.Enabled = True
        End If
        If number = 0 Then
            downloadmods.Text = "Télécharger tout les mods"
            downloadmods.Enabled = True
        End If



    End Sub

    Private Sub PositronButton5_Click(sender As Object, e As EventArgs) Handles entraserver.Click
        'Bouton Lancer Arma 3
        If My.Computer.FileSystem.FileExists(donwlodmodsbr & "basepack.txt") Then
            If PositronProgressBar2.Visible = False Then
                If My.Computer.FileSystem.FileExists(destination & "arma3.exe") Then
                    If servpassword = "none" Then
                        Process.Start(destination & "arma3.exe", "-mod=@" & servername & "-connect=" & ipserveur & "-password=" & servpassword)
                    Else
                        Process.Start(destination & "arma3.exe", "-mod=@" & "-connect=" & ipserveur)
                    End If
                Else
                    MsgBox("Veuillez choisir la bonne destination d'arma 3 avant de faire cela !")
                End If
            Else
                If PositronProgressBar2.Value = 100 Then
                    If My.Computer.FileSystem.FileExists(destination & "arma3.exe") Then
                        If servpassword = "none" Then
                            Process.Start(destination & "arma3.exe", "-mod=@" & servername & "-connect=" & ipserveur & "-password=" & servpassword)
                        Else
                            Process.Start(destination & "arma3.exe", "-mod=@" & servername & "-connect=" & ipserveur)
                        End If
                    Else
                        MsgBox("Veuillez choisir la bonne destination d'arma 3 avant de faire cela !")
                    End If
                Else
                    MsgBox("Veillez attendre la fin du téléchargement des mods !")
                End If
            End If
        Else
            MsgBox("Veillez télécharger les mods avant de démarer Arma 3")
        End If
    End Sub

    Private Sub PositronButton7_Click(sender As Object, e As EventArgs) Handles siteweb.Click
        'Bouton Forum
        Process.Start(forum)
    End Sub

    Private Sub PositronButton6_Click(sender As Object, e As EventArgs) Handles ts3.Click
        'Bouton TeamSpeak
        If TSport = "none" Then
            Process.Start("ts3server://" & teamspeak)
        Else
            Process.Start("ts3server://" & teamspeak & "?port=" & TSport)
        End If
    End Sub

    Private Sub Message_DoWork(sender As Object, e As DoWorkEventArgs) Handles Message.DoWork
        'Message news !
        If My.Computer.FileSystem.FileExists(appdata & news) Then
            My.Computer.FileSystem.DeleteFile(appdata & news)
        End If
        My.Computer.Network.DownloadFile(website & news, appdata & news)
        textnews = My.Computer.FileSystem.ReadAllText(appdata & news)
        'FlatTextBox1.Text = "Message du staff: " & textnews
    End Sub

    Private Sub deletemods_DoWork(sender As Object, e As DoWorkEventArgs) Handles deletemods.DoWork
        'Fonction qui sert a surprimer des mods au cas ou
        Dim deletelist As New StreamReader("C:/Launcher/delete.txt") 'ne pas changer !
        Dim delete As String
        While deletelist.Peek <> -1
            delete = deletelist.ReadLine()
            If delete = "" Then
            Else
                If My.Computer.FileSystem.FileExists(destination & "@" & mods & "\addons\" & delete) Then
                    My.Computer.FileSystem.DeleteFile(destination & "@" & mods & "\addons\" & delete)
                End If
            End If
        End While
    End Sub

    Private Sub DownloadUpdateLauncher_DoWork(sender As Object, e As DoWorkEventArgs) Handles DownloadUpdateLauncher.DoWork
        'Télécharge le nouveau launcher
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

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Process.Start(facebook)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Process.Start(twitter)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Process.Start(youtube)
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Process.Start(forum)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Process.Start(forum)
    End Sub

    Private Sub PositronButton9_Click(sender As Object, e As EventArgs) Handles PositronButton9.Click
        Application.Exit()
    End Sub

    Private Sub Form2Load_DoWork(sender As Object, e As DoWorkEventArgs) Handles Form2Load.DoWork

    End Sub

    Private Sub attlauncher_Click(sender As Object, e As EventArgs) Handles attlauncher.Click
        DownloadUpdateLauncher.RunWorkerAsync()
    End Sub
End Class