Public Class credits
    Dim hogamer As String = "http://altisdev.com/index.php?/user/1-hogamer/"
    Dim mrdarkskil As String = "http://altisdev.com/index.php?/user/668-mrdarkskil/"
    Dim renildomarcio As String = "http://altisdev.com/index.php?/user/1809-renildomarcio/"
    Dim launcherarma3 As String = "https://github.com/LauncherArma3"
    Private Sub PositronButton1_Click(sender As Object, e As EventArgs) Handles PositronButton1.Click
        Me.Close()
        Form2.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start(hogamer)
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start(mrdarkskil)
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Process.Start(renildomarcio)
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Process.Start(launcherarma3)
    End Sub

    Private Sub PositronTheme1_Click(sender As Object, e As EventArgs) Handles PositronTheme1.Click

    End Sub
End Class