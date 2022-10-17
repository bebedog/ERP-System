Imports Microsoft.Office.Interop
Imports MySql.Data.MySqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO

Public Class RFQ_view_for_non_admin

    Dim table As New DataSet
    Dim table2 As New DataSet
    Dim tableName As String
    Dim selectedRefNo As String
    Dim requestorName As String
    Dim requestoremailAddress As String
    Dim quotationDetails() As String


    'START Functions
    Public Sub AdjustComponentsSizes()

    End Sub
    Public Sub SetBtn(ByRef buttonName As Button, StatusEnabled As Boolean, StatusVisible As Boolean, Optional ByVal x As Integer = -1, Optional ByVal y As Integer = -1)
        buttonName.Enabled = StatusEnabled
        buttonName.Visible = StatusVisible
        If x = -1 Or y = -1 Then
        Else
            buttonName.Location = New Point(x, y)
        End If
    End Sub
    Public Function prepareDatabase(ByVal databaseName As String, ByVal operation As String, ByVal queryCommand As String) As Boolean
        Dim cb As New MySqlConnectionStringBuilder
        cb.UserID = "testAccount"
        cb.Server = "192.168.0.142"
        cb.Database = databaseName
        cb.Password = "LaserJailer123!"
        Dim conn As MySqlConnection = New MySqlConnection(cb.ConnectionString)
        If operation = "ADD/REMOVE" Then
        ElseIf operation = "UPDATE" Then
            Try
                conn.Open()
                Dim stm As String = queryCommand
                Dim cmd As MySqlCommand = New MySqlCommand(stm, conn)
                cmd.ExecuteNonQuery()
                Dim htmlbody As String = "<h1 style=""color: #5e9ca0;"">Lasermet Amodia System</h1>
                                          <p>Hi, Jayson. Your manager/direct supervisor has approved your quotation request with reference number: xxxxx.</p>
                                          <p>&nbsp;</p>
                                          <p>This is an automated message.</p>
                                          <p>&nbsp;</p>"
                Dim emailsubject As String = "" & selectedRefNo.ToUpper & " has been approved!"
                send_Email_thru_Outlook(emailsubject, htmlbody, requestoremailAddress)
                MessageBox.Show(
                                "Ref No.: " & selectedRefNo & " by " & requestorName & " is approved. An email was sent to recepient to notify them of the progress",
                                "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                table.Clear()
                DataGridView1.DataSource = table
                clearView()
                showRequestMadeByUser(loginScreen.accountType)
                Return True
            Catch ex As Exception
                MessageBox.Show(ex.ToString, "Oops, something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            Finally
                conn.Close()
            End Try
        ElseIf operation = "QUERY" Then
        End If
    End Function
    Public Sub send_Email_thru_Outlook(ByVal sSubject As String, ByVal sHTML_Body As String, ByVal sRecipient As String)
        Try
            'create outlook application 
            Dim oApps As New Outlook.Application

            'create a new mail item.
            Dim oMsg As Outlook.MailItem = DirectCast(oApps.CreateItem(Outlook.OlItemType.olMailItem), Outlook.MailItem)

            'email subject here
            oMsg.Subject = sSubject

            'add body of the email
            oMsg.HTMLBody = sHTML_Body

            'recepient here
            Dim oRecips As Outlook.Recipients = DirectCast(oMsg.Recipients, Outlook.Recipients)
            Dim oRecip As Outlook.Recipient = DirectCast(oRecips.Add(sRecipient), Outlook.Recipient)
            oRecip.Resolve()

            'Send
            oMsg.Send()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Public Sub setForm()
        Me.CenterToParent()
        Me.MaximizeBox = False
        Me.MinimizeBox = False
    End Sub
    Public Sub clearView()
        table2.Clear()
        dgvRequest.DataSource = table2
    End Sub
    Public Sub setFormAccordingToAdminRights()
        Console.WriteLine(loginScreen.accountType)
        If loginScreen.accountType = "requestor" Then
            Me.Text = "" & loginScreen.firstName & "'s Requests"
            btnApprove.Visible = False
            btnReturn.Visible = False
            tbComments.Visible = False
            btnApprove.Enabled = False
            btnReturn.Enabled = False
            tbComments.Enabled = False
            btnReapply.Visible = False
        ElseIf loginScreen.accountType = "purchaser" Then
            Me.Text = "" & loginScreen.department & " Team's Requests"
            btnApprove.Visible = False
            btnReturn.Visible = False
            tbComments.Visible = False
            btnApprove.Enabled = False
            btnReturn.Enabled = False
            tbComments.Enabled = False
            SetBtn(btnImportCSV, False, True, 12, 186)
            SetBtn(btnExportToCSV, False, True, 121, 186)
            dgvRequest.Visible = False
            btnReapply.Visible = False
        ElseIf loginScreen.accountType = "approver" Then
            Me.Text = "Lasermet R&D Requests"
            btnApprove.Visible = True
            btnReturn.Visible = True
            tbComments.Visible = True
            btnApprove.Enabled = False
            btnReturn.Enabled = False
            tbComments.Enabled = False
            btnReapply.Visible = False
        End If
    End Sub
    Public Sub setDataGridViewProperty(ByRef datagridviewname As DataGridView)
        'Disables the ability of users to resize columns.
        datagridviewname.AllowUserToResizeColumns = False

        'Disables the ability of users to resize rows.
        datagridviewname.AllowUserToResizeRows = False

        'Wraps column size according to content width.
        datagridviewname.DefaultCellStyle.WrapMode = DataGridViewTriState.True

        'Aligns the Headers to Middle Center
        datagridviewname.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        datagridviewname.MultiSelect = False

        If loginScreen.accountType = "requestor" Or loginScreen.accountType = "approver" Then
            datagridviewname.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Else
            datagridviewname.SelectionMode = DataGridViewSelectionMode.CellSelect
        End If
    End Sub
    Public Function adjustFormAccordingToSizeOfDataGridView(ByRef datagridviewname As DataGridView) As Integer
        datagridviewname.RowHeadersVisible = False
        Dim width As Integer = 0
        For Each column As DataGridViewColumn In datagridviewname.Columns
            If (column.Visible = True) Then
                width += column.Width
            End If
        Next
        Return (width + 3)
    End Function
    Public Function queryEmailAddressOfRequestor() As String
        Dim cb As New MySqlConnectionStringBuilder
        cb.Database = "lasermetamodiasystemdatabase"
        cb.Server = "192.168.0.142"
        cb.UserID = "testAccount"
        cb.Password = "LaserJailer123!"
        Dim stm As String = "SELECT emailAddress from las_accounts WHERE "
    End Function
    Public Sub showRequestMadeByUser(ByVal accountType As String)
        Dim cb As New MySqlConnectionStringBuilder
        cb.Database = "lasermetamodiasystemdatabase"
        cb.Server = "192.168.0.142"
        cb.UserID = "testAccount"
        cb.Password = "LaserJailer123!"
        Dim stm As String
        If accountType = "requestor" Then
            stm = "   SELECT concat('rfq-',referencenumber) AS 'Ref. No.', 
                      date_format(datecreated, '%d/%m/%Y') AS 'Date Created',
                      IF(approved = 1, 'Approved', IF(approved = 2, 'Denied', 'Approval Pending')) AS Status,
                      emailAddress,
                      tablename
                      FROM quotationrequests
                      WHERE requestor = '" & loginScreen.firstName & " " & loginScreen.lastName & "' 
"
        ElseIf accountType = "approver" Then
            stm = "   SELECT concat('rfq-',referencenumber) AS 'Ref. No.', 
                      date_format(datecreated, '%d/%m/%Y') AS 'Date Created',
                      requestor AS Requestor,
                      IF(approved = 1, 'Approved', 'Not Yet Approved') AS Status,
                      emailAddress,
                      tablename
                      FROM quotationrequests
                      WHERE department = '" & loginScreen.department & "' AND approved = '0'
"
        ElseIf accountType = "purchaser" Then
            stm = "   SELECT concat('rfq-',referencenumber) AS 'Ref. No.', 
                      requestor AS Requestor,
                      IF(approved = 1, 'Approved', IF(approved = 2, 'Denied',IF(approved = 3, 'Under Process', 'Not Yet Viewed'))) AS Status,
                      emailAddress,
                      tablename
                      FROM quotationrequests
                      WHERE approved = '1' OR approved = '3'
"
        End If
        Using conn As MySqlConnection = New MySqlConnection(cb.ConnectionString)
            Using cmd As MySqlCommand = conn.CreateCommand()
                conn.Open()
                cmd.CommandText = stm
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim ds As DataSet = New DataSet
                da.Fill(table)
                DataGridView1.DataSource = table.Tables(0)
                DataGridView1.Columns(DataGridView1.Columns.Count - 1).Visible = False
                DataGridView1.Columns(DataGridView1.Columns.Count - 2).Visible = False
            End Using
        End Using
    End Sub
    Public Sub viewSpecificRequest(ByVal requestTableName As String)
        Dim cb1 As New MySqlConnectionStringBuilder
        cb1.Database = "rfq_database"
        cb1.Server = "192.168.0.142"
        cb1.UserID = "testAccount"
        cb1.Password = "LaserJailer123!"
        Dim stm As String = "   SELECT 
                                partnumber as 'Part No.',
                                itemname as 'Item Name',
                                specification as 'Specification',
                                quantity as 'Qty.',
                                manufacturer as 'Manufacturer',
                                recommendedSupplier as 'Recommended Supplier',
                                notes as 'Notes'

                                FROM `" & requestTableName & "`;"

        Using conn As MySqlConnection = New MySqlConnection(cb1.ConnectionString)
            Using cmd As MySqlCommand = conn.CreateCommand()
                conn.Open()
                cmd.CommandText = stm
                Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
                Dim ds As DataSet = New DataSet
                da.Fill(table2)
                dgvRequest.DataSource = table2.Tables(0)
                conn.Close()
            End Using
        End Using
    End Sub
    Public Sub denyRequest()
        Dim cb As New MySqlConnectionStringBuilder
        If tbComments.Text = "" Or tbComments.Text = "Type comments here." Then
            'Comments are empty.
            Dim results As DialogResult = MessageBox.Show("You are about to return this request to its origin without a comment." + Environment.NewLine +
                                                          "Do you want to proceed?", "No comments attached", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If results = DialogResult.Yes Then
                'send email here
                Dim msgSubject As String = "" & tableName.ToUpper & " has been denied."
                Dim automatedMsg As String = "<p><strong>Lasermet Amodia System</strong></p>
                                              <p>Your Quotation Request was denied by your direct supervisor/manager with the following comments:</p>
                                              <blockquote>
                                              <p>" & loginScreen.lastName & " did not leave any comment.</p>
                                              </blockquote>
                                              <p>This is an automated message from Lasermet Amodia System</p>"

                send_Email_thru_Outlook(msgSubject, automatedMsg, requestoremailAddress)
                cb.Database = "lasermetamodiasystemdatabase"
                cb.UserID = "testAccount"
                cb.Server = "192.168.0.142"
                cb.Password = "LaserJailer123!"
                Dim stm As String = "UPDATE `quotationrequests` SET `approved` = '2' WHERE (`referencenumber` = '" & selectedRefNo.Substring(4, 5) & "');"
                Dim conn As New MySqlConnection(cb.ConnectionString)
                Try
                    conn.Open()
                    Dim cmd As MySqlCommand = New MySqlCommand(stm, conn)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("The request you selected has been successfuly denied and requestor is notified via email.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                Finally
                    conn.Close()
                End Try
            ElseIf DialogResult.No Then
                tbComments.Select()
            End If
        Else
            'send email here
            Dim msgSubject As String = "" & tableName.ToUpper & " has been denied."
            Dim automatedMsg As String = "<p><strong>Lasermet Amodia System</strong></p>
                                              <p>Your Quotation Request was denied by your direct supervisor/manager with the following comments:</p>
                                              <blockquote>
                                              <p>" & tbComments.Text & "</p>
                                              </blockquote>
                                              <p>This is an automated message from Lasermet Amodia System</p>"

            send_Email_thru_Outlook(msgSubject, automatedMsg, requestoremailAddress)
            cb.Database = "lasermetamodiasystemdatabase"
            cb.UserID = "testAccount"
            cb.Server = "192.168.0.142"
            cb.Password = "LaserJailer123!"
            Dim stm As String = "UPDATE `quotationrequests` SET `approved` = '2' WHERE (`referencenumber` = '" & selectedRefNo.Substring(4, 5) & "');"
            Dim conn As New MySqlConnection(cb.ConnectionString)
            Try
                conn.Open()
                Dim cmd As MySqlCommand = New MySqlCommand(stm, conn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("The request you selected has been successfuly denied and requestor is notified via email.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            Finally
                conn.Close()
            End Try
        End If

    End Sub
    Public Sub reApplyRequest()
        Dim cb As New MySqlConnectionStringBuilder
        cb.Database = "lasermetamodiasystemdatabase"
        cb.UserID = "testAccount"
        cb.Password = "LaserJailer123!"
        cb.Server = "192.168.0.142"

        Dim stm As String = "UPDATE `quotationrequests` SET `approved` = '0' WHERE (`referencenumber` = '" & selectedRefNo.Substring(4, 5) & "');"
        Dim conn As MySqlConnection = New MySqlConnection(cb.ConnectionString)
        Try
            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(stm, conn)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Your request has been successfully re-applied.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            conn.Close()
        End Try
    End Sub
    Public Sub SaveChangesToTable()
        'save datagridview to dataset
        Dim cb As New MySqlConnectionStringBuilder
        cb.Database = "rfq_database"
        cb.Server = "192.168.0.142"
        cb.UserID = "testAccount"
        cb.Password = "LaserJailer123!"
        Dim v As Integer = dgvRequest.Rows.Count - 1 'Number of items
        Dim colIndex As Integer = dgvRequest.Columns.Count - 1
        ReDim quotationDetails(colIndex)
        Dim conn As MySqlConnection = New MySqlConnection(cb.ConnectionString)
        Dim truncateCommand As String = "TRUNCATE `rfq_database`.`" & tableName & "`;"
        Dim stm As String
        Try
            conn.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(truncateCommand, conn)
            cmd.ExecuteNonQuery()
            For row = 0 To dgvRequest.Rows.Count - 2
                stm = "
                   INSERT INTO `rfq_database`.`" & tableName.ToLower & "` 
                   (`partnumber`, `itemname`, `specification`, `quantity`, `manufacturer`, `recommendedSupplier`, `notes`)
                   VALUES (
                "
                For col = 0 To dgvRequest.Columns.Count - 1
                    quotationDetails(col) = dgvRequest(col, row).Value.ToString
                    stm = stm + "'" & quotationDetails(col) & "',"
                    'VALUES ('1', '1', '1', '1', '1', '1', '1');
                Next
                stm = stm.Substring(0, stm.Count() - 2) + "');"
                Dim cmd2 As MySqlCommand = New MySqlCommand(stm, conn)
                cmd2.ExecuteNonQuery()
            Next

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            conn.Close()
        End Try
    End Sub
    Public Sub approveRequest(ByVal status As String)
        If status = "3" Then
            Dim result As DialogResult = MessageBox.Show("Request with the reference number: xxxx will be now marked as 'Processed'", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim cb As New MySqlConnectionStringBuilder
            cb.Database = "lasermetamodiasystemdatabase"
            cb.Password = "LaserJailer123!"
            cb.UserID = "testAccount"
            cb.Server = "192.168.0.142"
            Dim conn As MySqlConnection = New MySqlConnection(cb.ConnectionString)

            Dim stm As String = "UPDATE `quotationrequests` 
                                           SET `approved` = '" & status & "' 
                                           WHERE (`referencenumber` = '" & selectedRefNo.Substring(4, 5) & "');
                                          "
            Dim cmd As MySqlCommand = New MySqlCommand(stm, conn)
            cmd.ExecuteReader()
        Else
            Dim result As DialogResult = MessageBox.Show("You are about to approve this Quotation Request." + Environment.NewLine +
                                     "Please confirm.", "Request Approval", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            If result = DialogResult.OK Then
                'approval code here
                Dim bDatabaseName As String = "lasermetamodiasystemdatabase"
                Dim bQueryCommand As String = "UPDATE `quotationrequests` 
                                           SET `approved` = '" & status & "' 
                                           WHERE (`referencenumber` = '" & selectedRefNo.Substring(4, 5) & "');
                                          "
                If prepareDatabase(bDatabaseName, "UPDATE", bQueryCommand) = True Then

                Else
                    MessageBox.Show("Window is closing.", "Oops, something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                End If
            Else
            End If
        End If

    End Sub
    Public Sub bottomBorder(ByRef _borders As Excel.Borders)
        _borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlLineStyle.xlContinuous
        _borders.Color = Color.Black
    End Sub

    Public Sub exportExcel()
        'opens an instance of excel
        Dim xlApp As Excel.Application = New Excel.Application()
        'opens the specified workbook
        Dim xlWorkBook As Excel.Workbook = xlApp.Workbooks.Open("D:\LasermetAmodiaSystem\LasermetAmodiaSystem\LasermetAmodiaSystem\Resources\lasermetRFQFormat.xlsx")
        'makes the workbook invisible (not showing in another window)
        xlApp.Visible = True
        Dim xlWorkSheets As Excel.Sheets = xlWorkBook.Worksheets
        Dim xlWorkSheet As Excel.Worksheet = CType(xlWorkSheets("Sheet1"), Excel.Worksheet)
        Dim columnHeaders() = {"Part No.", "Item Name", "Specification", "Qty", "Manufacturer", "Recommended Supplier", "Notes"}
        Try
            For rows = 0 To dgvRequest.Rows.Count - 2
                For cols = 0 To dgvRequest.Columns.Count - 1
                    'Console.WriteLine(columnHeaders(cols) + ": " + dgvRequest.Rows(rows).Cells(cols).Value.ToString)
                    xlWorkSheet.Cells(13 + rows, cols + 2) = dgvRequest.Rows(rows).Cells(cols).Value.ToString
                Next
                If rows = dgvRequest.Rows.Count - 2 Then
                    Dim x As Integer = 14 + rows
                    Dim cell1 As Object = "" & x.ToString & ":" & x.ToString & ""
                    xlWorkSheet.Range(cell1).Delete()

                    'Add UOM Column
                    xlWorkSheet.Range("F:F").Insert(Excel.XlInsertShiftDirection.xlShiftToRight)
                    xlWorkSheet.Cells(12, 6) = "UOM"

                    'Format Excel Sheet
                    Dim cell2 As Object = "A12:L" & 12 + (rows + 1).ToString & ""
                    xlWorkSheet.Range(cell2).BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlMedium)
                Else
                    Dim x As Integer = 14 + rows
                    Dim cell1 As Object = "" & x.ToString & ":" & x.ToString & ""
                    xlWorkSheet.Range(cell1).Insert(Excel.XlInsertShiftDirection.xlShiftDown)
                End If
            Next
            'Point to User's MyDocs
            Dim filePath As String
            filePath = Path.Combine(
                        My.Computer.FileSystem.SpecialDirectories.MyDocuments, "" & selectedRefNo.ToString & "")
            'Save file.
            xlWorkBook.SaveAs(filePath)
            'Opens My Documents folder.
            Process.Start(My.Computer.FileSystem.SpecialDirectories.MyDocuments)
            approveRequest("3")
            clearView()
            showRequestMadeByUser(loginScreen.accountType)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            xlApp.DisplayAlerts = False
            xlWorkBook.Close()
            xlApp.Quit()
        End Try
    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
            MessageBox.Show("Exception Occured while releasing object " & ex.ToString())
        Finally
            GC.Collect()
        End Try
    End Sub
    'END FUNCTION
    Private Sub RFQ_view_for_non_admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'set form properties.
        setForm()

        'set buttons visibility according to account type.
        setFormAccordingToAdminRights()

        'view all entries from requests table according to account type.
        showRequestMadeByUser(loginScreen.accountType)

        'find the width of the requests datagridview. This is the basis of the width of the form.
        Dim adjustWidth As Integer = adjustFormAccordingToSizeOfDataGridView(DataGridView1)

        'saves the initial width of the datagridview before adjusting it to its new width.
        Dim previousWidth As Integer = DataGridView1.Width
        DataGridView1.Width = adjustWidth

        'Sets the property of the requests datagridview
        setDataGridViewProperty(DataGridView1)

        adjustFormAccordingToSizeOfDataGridView(dgvRequest)
        setDataGridViewProperty(dgvRequest)

    End Sub
    Private Sub RFQ_view_for_non_admin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        RFQ_Dashboard.Show()
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex = -1 Then Return
        tableName = DataGridView1.Rows(e.RowIndex).Cells(DataGridView1.Columns.Count - 1).Value.ToString
        selectedRefNo = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
        requestorName = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
        requestoremailAddress = DataGridView1.Rows(e.RowIndex).Cells(DataGridView1.Columns.Count - 2).Value.ToString
        btnApprove.Text = "Approve " & selectedRefNo.ToUpper & " by " & requestorName & ""
        If loginScreen.accountType = "purchaser" Then
            tbComments.Enabled = False
            btnApprove.Enabled = False
            btnReturn.Enabled = False
            btnImportCSV.Enabled = True
            btnExportToCSV.Enabled = True
        Else
            tbComments.Enabled = True
            btnApprove.Enabled = True
            btnReturn.Enabled = True
        End If
        If DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString = "Denied" Then
            btnReapply.Enabled = True
            btnReapply.Visible = True
            btnReapply.Location = New Point(627, 574)
        Else
            btnReapply.Enabled = False
            btnReapply.Visible = False
        End If

        clearView()
        viewSpecificRequest(tableName)
    End Sub
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        denyRequest()
        DataGridView1.ClearSelection()
        tbComments.Enabled = False
        btnApprove.Enabled = False
        btnReturn.Enabled = False
        table.Clear()
        DataGridView1.DataSource = table
        clearView()
        showRequestMadeByUser(loginScreen.accountType)
    End Sub
    Private Sub btnApprove_Click(sender As Object, e As EventArgs) Handles btnApprove.Click
        approveRequest("1")
    End Sub
    Private Sub btnReapply_Click(sender As Object, e As EventArgs) Handles btnReapply.Click
        Dim result As DialogResult = MessageBox.Show("You are about to re-apply this QR for another approval.", "Appeal Denied Status", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If result = DialogResult.Yes Then
            SaveChangesToTable()
            reApplyRequest()
            table.Clear()
            DataGridView1.DataSource = table
            clearView()
            showRequestMadeByUser(loginScreen.accountType)
            btnReapply.Visible = False
        Else

        End If
    End Sub
    Private Sub btnImportCSV_Click(sender As Object, e As EventArgs) Handles btnImportCSV.Click
    End Sub
    Private Sub btnExportToCSV_Click(sender As Object, e As EventArgs) Handles btnExportToCSV.Click

        'dgvRequest.Visible = True
        'btnImportCSV.Visible = False
        'ExportBrowser.Filter = "Excel Files (*.xlsx)|*.xlsx|All files(*.*)|*.*"
        'ExportBrowser.FilterIndex = 1
        'ExportBrowser.RestoreDirectory = True
        'ExportBrowser.FileName = selectedRefNo.ToUpper
        'If ExportBrowser.ShowDialog() = DialogResult.OK Then
        exportExcel()
        'End If

    End Sub
End Class