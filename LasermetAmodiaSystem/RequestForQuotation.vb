Imports MySql.Data.MySqlClient

Public Class RequestForQuotation
    Public departmentShortString As String
    Public dateNow As String
    Public rfqDatabaseTitle As String
    Public quotationDetails() As String
    'FUNCTIONS STARTS HERE

    Public Function sendRequestToQuotationRequest() As Boolean
        Dim cs As String = "Database=lasermetamodiasystemdatabase;Data Source=192.168.0.142;User Id=testAccount;Password=LaserJailer123!"
        Dim conn As New MySqlConnection(cs)
        Dim dateNow As String = dtpDateTimeNow.Value.ToString("yyyy-MM-dd HH:mm:ss")
        Dim dateNowForTitle As String = dtpDateTimeNow.Value.ToString("yyyyMMdd")


        Try
            conn.Open()
            Dim stm As String

            dateNow = dtpDateTimeNow.Value.ToString("yyyyMMdd")
            If loginScreen.department = "Electronics" Then
                departmentShortString = "E"
            ElseIf loginScreen.department = "Mechanical" Then
                departmentShortString = "M"
            End If
            Dim refNo As String = tbRefNo.Text.Substring(4, 5)
            rfqDatabaseTitle = "QR" & departmentShortString & "-" & dateNow & "-" & tbRefNo.Text & ""
            If tbBudgetCode.Text = "" Then                                                                                                    'rfq-xxxxx
                stm = "INSERT INTO `quotationrequests` (`referencenumber`, `requestor`, `department`, `datecreated`, `tablename`,`emailAddress`) VALUES ('" & refNo & "', '" & tbRequestor.Text & "', '" & tbDept.Text & "', '" & dateNow & "', '" & rfqDatabaseTitle.ToLower & "', '" & loginScreen.emailAddress & "');"
            Else
                stm = "INSERT INTO `quotationrequests` (`referencenumber`, `requestor`, `budgetcode`, `department`, `datecreated`, `tablename`,`emailAddress`) VALUES ('" & tbRefNo.Text & "', '" & tbRequestor.Text & "', '" & tbBudgetCode.Text & "', '" & tbDept.Text & "', '" & dateNow & "', '" & rfqDatabaseTitle.ToLower & "', '" & loginScreen.emailAddress & "');"
            End If

            Dim cmd As MySqlCommand = New MySqlCommand(stm, conn)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False
        Finally
            conn.Close()
        End Try
    End Function
    Public Function createNewQuotationRequest() As Boolean
        Dim cs As String = "Database=rfq_database;Data Source=192.168.0.142;User Id=testAccount;Password=LaserJailer123!"
        Dim conn As New MySqlConnection(cs)
        Try
            dateNow = dtpDateTimeNow.Value.ToString("yyyyMMdd")
            conn.Open()
            Dim stm As String = "CREATE TABLE `rfq_database`.`" & rfqDatabaseTitle & "` (
                                 `no` INT NOT NULL AUTO_INCREMENT,
                                 `partnumber` VARCHAR(45) NULL,
                                 `itemname` VARCHAR(45) NULL,
                                 `specification` VARCHAR(45) NULL,
                                 `quantity` VARCHAR(45) NULL,
                                 `manufacturer` VARCHAR(45) NULL,
                                 `recommendedSupplier` VARCHAR(45) NULL,
                                 `notes` VARCHAR(45) NULL,
                                 PRIMARY KEY (`no`));"
            Dim cmd As MySqlCommand = New MySqlCommand(stm, conn)
            cmd.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False
        Finally
            conn.Close()
        End Try
    End Function
    Public Function writeDetailsToQuotationRequest() As Boolean
        Dim cs As String = "Database=rfq_database;Data Source=192.168.0.142;User Id=testAccount;Password=LaserJailer123!"
        Dim conn As New MySqlConnection(cs)
        Dim v As Integer = dgvRequests.Rows.Count - 1 'Number of items
        Dim colIndex As Integer = dgvRequests.Columns.Count - 1
        ReDim quotationDetails(colIndex)
        Dim stm As String
        Try
            conn.Open()
            For row = 0 To dgvRequests.Rows.Count - 2
                stm = "
                   INSERT INTO `rfq_database`.`" & rfqDatabaseTitle.ToLower & "` 
                   (`partnumber`, `itemname`, `specification`, `quantity`, `manufacturer`, `recommendedSupplier`, `notes`)
                   VALUES (
                "
                For col = 0 To dgvRequests.Columns.Count - 1
                    quotationDetails(col) = dgvRequests(col, row).Value.ToString
                    stm = stm + "'" & quotationDetails(col) & "',"
                    'VALUES ('1', '1', '1', '1', '1', '1', '1');
                Next
                stm = stm.Substring(0, stm.Count() - 2) + "');"
                Dim cmd As MySqlCommand = New MySqlCommand(stm, conn)
                cmd.ExecuteNonQuery()
            Next
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Return False
        Finally
            conn.Close()
        End Try
    End Function
    Public Function checkMostRecentReferenceNumber() As String
        Dim cs As String = "Database=lasermetamodiasystemdatabase;Data Source=192.168.0.142;User Id=testAccount;Password=LaserJailer123!"
        Dim conn As New MySqlConnection(cs)
        Try
            conn.Open()
            Dim stm As String = "SELECT referencenumber FROM quotationrequests"
            Dim cmd As MySqlCommand = New MySqlCommand(stm, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            Dim highestReferenceNumber As String = "0"
            While reader.Read
                highestReferenceNumber = "rfq-" + (reader.GetInt32("referencenumber") + 1).ToString
            End While
            Return highestReferenceNumber
        Catch ex As Exception
            Return 0
        End Try
    End Function
    'FUNCTIONS ENDS HERE

    Private Sub RequestForQuotation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        Me.Text = "Request for Quotation | " & loginScreen.firstName & " " & loginScreen.lastName & " | Department: " & loginScreen.department & ""

        tbDept.Text = loginScreen.department
        tbRequestor.Text = "" & loginScreen.firstName & " " & loginScreen.lastName & ""

        tbDept.Enabled = False
        tbRequestor.Enabled = False

        tbRefNo.Text = (checkMostRecentReferenceNumber()).ToString
        tbRefNo.Enabled = False

        dtpDateTimeNow.Enabled = False

    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        If dgvRequests.Rows.Count > 1 Then
            If sendRequestToQuotationRequest() = True Then
                If createNewQuotationRequest() = True Then
                    writeDetailsToQuotationRequest()
                    MessageBox.Show("Request successfuly sent to database!", "Request sent!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Me.Close()
            Else
                MessageBox.Show("Request could not be saved. Please contact administrator.", "Oops, something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            End If
        Else
            MessageBox.Show("You can't send a blank request!", "Please write something.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If dgvRequests.Rows.Count > 1 Then
            Dim response As DialogResult = MessageBox.Show("Details will not be saved if you exit this window." + Environment.NewLine + "Are you sure you want to exit?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If response = DialogResult.Yes Then
                'yes button is selected.
                Me.Close()
            Else

            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub RequestForQuotation_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        RFQ_Dashboard.Show()
    End Sub

    Private Sub checkRefNo_CheckedChanged(sender As Object, e As EventArgs) Handles checkRefNo.CheckedChanged
        If checkRefNo.CheckState = CheckState.Checked Then
            tbDept.Enabled = True
            tbRequestor.Enabled = True
            tbRefNo.Enabled = True
        Else
            tbDept.Enabled = False
            tbRequestor.Enabled = False
            tbRefNo.Enabled = False
        End If
    End Sub
End Class