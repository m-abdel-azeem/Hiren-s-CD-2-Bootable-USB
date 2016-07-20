Public Class About

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("mailto:mohamad.abdelazeem@sa.bb.com?subject=Bug_report/Suggestion(sent via tool)")
    End Sub

    Private Sub About_Load(sender As Object, e As EventArgs) Handles Me.Load
        Version_lbl.Text = "2.2"
        copyright_lbl.Text = ""
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("http://sourceforge.net/p/hirenscd2bootableusb")
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Process.Start("https://www.facebook.com/pages/Hirens-CD-2-Bootable-USB/1440129386302328")
    End Sub
End Class