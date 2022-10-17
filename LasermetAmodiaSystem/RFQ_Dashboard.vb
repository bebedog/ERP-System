Public Class RFQ_Dashboard
    Private Sub RFQ_Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        Me.Text = "Request for Quotation | " & loginScreen.firstName & " " & loginScreen.lastName & " | Department: " & loginScreen.department & ""

    End Sub

    Private Sub btnNewRequest_Click(sender As Object, e As EventArgs) Handles btnNewRequest.Click
        RequestForQuotation.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub RFQ_Dashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        mainDashboard.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RFQ_view_for_non_admin.Show()
        Me.Hide()
    End Sub
End Class