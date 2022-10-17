Imports MySql.Data.MySqlClient

Public Class loginScreen

    Public accountNo As String
    Public firstName As String
    Public lastName As String
    Public password As String
    Public emailAddress As String
    Public accountType As String
    Public department As String

    Public Function LoginQuery() As Boolean
        Dim cs As String = "Database=lasermetamodiasystemdatabase;Data Source=192.168.0.142;User Id=testAccount;Password=LaserJailer123!"
        Dim conn As New MySqlConnection(cs)
        Dim numberOfResults As Integer = 0
        Try
            conn.Open()

            Dim stm As String = "SELECT * FROM las_accounts where lastName='" & tbUsername.Text & "' AND password='" & tbPassword.Text & "'"
            Dim cmd As MySqlCommand = New MySqlCommand(stm, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read
                numberOfResults += 1
                accountNo = reader.GetString("accountNo")
                firstName = reader.GetString("firstName")
                lastName = reader.GetString("lastName")
                password = reader.GetString("password")
                emailAddress = reader.GetString("emailAddress")
                accountType = reader.GetString("accountType")
                department = reader.GetString("department")
            End While

            If numberOfResults = 1 Then
                'loginQueryMatch
                Return True

            Else
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False
        Finally
            conn.Close()

        End Try
    End Function


    Private Sub loginScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If LoginQuery() = True Then
            MessageBox.Show("Welcome, " & firstName & " " & lastName & "! | Account No: " & accountNo & " | " + Environment.NewLine + "E-mail address: " & emailAddress & " | " & department & "",
                            "Login Successful.",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
            Console.WriteLine("{0} {1} | Account ID: {2} | E-mail Address: {3} | Account Type: {4} | Department: {5}", firstName, lastName, accountNo, emailAddress, accountType, department)
            Me.Hide()
            mainDashboard.Show()
        Else
            MessageBox.Show("Incorrect username or password.")
        End If
    End Sub
End Class
