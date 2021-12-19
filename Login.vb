Public Class Login
    Public User As String = "MRP"
    Public Password As String = "1234"
    Public LoggedIn As Boolean = False
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        If txb_username.Text = User Then
            If txb_password.Text = Password Then
                LoggedIn = True
                Me.Hide()
                ControlPanel.Show()
            Else
                LoggedIn = False
            End If
        Else
            LoggedIn = False
        End If
        If LoggedIn = False Then
            MsgBox("Username or password incorrect")
        End If
    End Sub

    Public Function GetLoginStatus() As Boolean
        Return LoggedIn
    End Function

    Public Function GetLoggedInUser() As String
        Return User
    End Function

End Class
