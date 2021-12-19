Public Class ControlPanel

    Private Sub ControlPanel_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If Login.GetLoginStatus Then
            lbl_loggedinuser.Text = "Logged in User = " & Login.GetLoggedInUser
        Else
            lbl_loggedinuser.Text = "Logged in user = none"
        End If
    End Sub

    Private Sub btn_manageparts_Click(sender As Object, e As EventArgs) Handles btn_manageparts.Click
        Me.Hide()
        ManageParts.Show()
    End Sub

    Private Sub btn_managemachines_Click(sender As Object, e As EventArgs) Handles btn_managemachines.Click
        MsgBox("Not available yet")
    End Sub
End Class