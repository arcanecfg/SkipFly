'Got the idea from an old JS snippet on my computer.
'Don't know who the author is but credits to him/her.
'I simply rewrote it in VB.NET.
' - Arcanecfg (www.YouTube.com/Arcanecfg)

' # SkipFly
' -- Lets you bypass AdFly links.
Imports System.Net
Imports System.Text

Public Class frmMain

    'https://adf.ly/PNDe3
    Private Sub btnGetLink_Click(sender As Object, e As EventArgs) Handles btnGetLink.Click
        Try
            Dim adfClient As New WebClient()
            Dim rawStr As String = adfClient.DownloadString(txtAdfly.Text)
            Dim lineStr As String() = rawStr.Split(Environment.NewLine.ToCharArray, System.StringSplitOptions.RemoveEmptyEntries)
            Dim reqStr As String = String.Empty
            For i As Integer = 0 To lineStr.Count - 1
                If lineStr(i).Contains("ysmm") Then
                    reqStr = lineStr(i)
                End If
            Next
            reqStr = reqStr.Replace(" ", "")
            reqStr = reqStr.Remove(0, 9).Replace("'", "").Replace(";", "")
            Dim D As String = String.Empty
            Dim F As String = String.Empty
            For x As Integer = 0 To reqStr.Length - 1
                If x Mod 2 = 0 Then
                    D += reqStr(x)
                Else
                    F = reqStr(x) + F
                End If
            Next
            reqStr = D + F
            Dim linkFinal As String = System.Text.Encoding.ASCII.GetString(Convert.FromBase64String(reqStr)).Remove(0, 2)
            txtAdfly.Text = linkFinal
            If cbClipboard.Checked = True Then
                Clipboard.SetText(linkFinal)
            End If
            If cbOpen.Checked = True Then
                System.Diagnostics.Process.Start(linkFinal)
            End If
        Catch
            MessageBox.Show("An error occured, make sure the link is right.", "SkipFly Error", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub linkYouTube_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkYouTube.LinkClicked
        System.Diagnostics.Process.Start("https://www.youtube.com/user/ArcaneCfg")
    End Sub


    Private Sub linkWastedWolf_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkWastedWolf.LinkClicked
        System.Diagnostics.Process.Start("http://www.wastedwolf.com/")
    End Sub
End Class
