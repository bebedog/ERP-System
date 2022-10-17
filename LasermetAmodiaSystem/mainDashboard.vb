Public Class mainDashboard
    Public Function checkifLoggedIn() As Boolean
        If loginScreen.accountNo Is Nothing Or loginScreen.firstName Is Nothing Or loginScreen.lastName Is Nothing Or loginScreen.emailAddress Is Nothing Or loginScreen.accountType Is Nothing Then
            'user did not log in.
            Return False
        Else
            'user logged in.
            Return True
        End If
    End Function




    Private Sub mainDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        If checkifLoggedIn() = True Then
            'events if program found user details
            Me.Text = Me.Text + " | " & loginScreen.firstName & " " & loginScreen.lastName & " | Account Type: " & loginScreen.accountType & " | E-mail Address: " & loginScreen.emailAddress & " | Department: " & loginScreen.department & ""
        Else
            MessageBox.Show("LAS could not find your details. Program is closing.", "Oops, something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            loginScreen.Close()
        End If
    End Sub

    Private Sub mainDashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        loginScreen.Close()
    End Sub

    Private Sub btnRFQ_Click(sender As Object, e As EventArgs) Handles btnRFQ.Click
        RFQ_Dashboard.Show()
        Me.Hide()
    End Sub
End Class