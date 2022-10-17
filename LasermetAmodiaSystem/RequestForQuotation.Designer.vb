<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RequestForQuotation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgvRequests = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tbRefNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbRequestor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbDept = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbBudgetCode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpDateTimeNow = New System.Windows.Forms.DateTimePicker()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.checkRefNo = New System.Windows.Forms.CheckBox()
        Me.partNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.specification = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.manufacturer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.recommendedSupplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.notes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvRequests, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvRequests
        '
        Me.dgvRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRequests.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.partNumber, Me.itemName, Me.specification, Me.qty, Me.manufacturer, Me.recommendedSupplier, Me.notes})
        Me.dgvRequests.Location = New System.Drawing.Point(9, 179)
        Me.dgvRequests.Name = "dgvRequests"
        Me.dgvRequests.Size = New System.Drawing.Size(866, 296)
        Me.dgvRequests.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LasermetAmodiaSystem.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(260, 83)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'tbRefNo
        '
        Me.tbRefNo.Location = New System.Drawing.Point(80, 101)
        Me.tbRefNo.Name = "tbRefNo"
        Me.tbRefNo.Size = New System.Drawing.Size(192, 20)
        Me.tbRefNo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ref No.: "
        '
        'tbRequestor
        '
        Me.tbRequestor.Location = New System.Drawing.Point(80, 127)
        Me.tbRequestor.Name = "tbRequestor"
        Me.tbRequestor.Size = New System.Drawing.Size(192, 20)
        Me.tbRequestor.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Requestor: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Department: "
        '
        'tbDept
        '
        Me.tbDept.Location = New System.Drawing.Point(80, 153)
        Me.tbDept.Name = "tbDept"
        Me.tbDept.Size = New System.Drawing.Size(192, 20)
        Me.tbDept.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(354, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Budget Code: "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbBudgetCode
        '
        Me.tbBudgetCode.Location = New System.Drawing.Point(435, 127)
        Me.tbBudgetCode.Name = "tbBudgetCode"
        Me.tbBudgetCode.Size = New System.Drawing.Size(192, 20)
        Me.tbBudgetCode.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(356, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Date Created:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpDateTimeNow
        '
        Me.dtpDateTimeNow.Location = New System.Drawing.Point(435, 153)
        Me.dtpDateTimeNow.Name = "dtpDateTimeNow"
        Me.dtpDateTimeNow.Size = New System.Drawing.Size(192, 20)
        Me.dtpDateTimeNow.TabIndex = 10
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(9, 481)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(89, 32)
        Me.btnExport.TabIndex = 11
        Me.btnExport.Text = "Export to CSV"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(104, 481)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(89, 32)
        Me.btnSend.TabIndex = 11
        Me.btnSend.Text = "Send Request"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(786, 481)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(89, 32)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'checkRefNo
        '
        Me.checkRefNo.AutoSize = True
        Me.checkRefNo.Location = New System.Drawing.Point(278, 129)
        Me.checkRefNo.Name = "checkRefNo"
        Me.checkRefNo.Size = New System.Drawing.Size(60, 17)
        Me.checkRefNo.TabIndex = 12
        Me.checkRefNo.Text = "Unlock"
        Me.checkRefNo.UseVisualStyleBackColor = True
        '
        'partNumber
        '
        Me.partNumber.HeaderText = "Part Number"
        Me.partNumber.Name = "partNumber"
        '
        'itemName
        '
        Me.itemName.HeaderText = "Item Name"
        Me.itemName.Name = "itemName"
        '
        'specification
        '
        Me.specification.HeaderText = "Specification"
        Me.specification.Name = "specification"
        '
        'qty
        '
        Me.qty.HeaderText = "Quantity"
        Me.qty.Name = "qty"
        '
        'manufacturer
        '
        Me.manufacturer.HeaderText = "Manufacturer"
        Me.manufacturer.Name = "manufacturer"
        '
        'recommendedSupplier
        '
        Me.recommendedSupplier.HeaderText = "Recommended Supplier"
        Me.recommendedSupplier.Name = "recommendedSupplier"
        '
        'notes
        '
        Me.notes.HeaderText = "Notes"
        Me.notes.Name = "notes"
        '
        'RequestForQuotation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(887, 524)
        Me.Controls.Add(Me.checkRefNo)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.dtpDateTimeNow)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbBudgetCode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbDept)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbRequestor)
        Me.Controls.Add(Me.tbRefNo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dgvRequests)
        Me.Name = "RequestForQuotation"
        Me.Text = "RequestForQuotation"
        CType(Me.dgvRequests, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvRequests As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tbRefNo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbRequestor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbDept As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbBudgetCode As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpDateTimeNow As DateTimePicker
    Friend WithEvents btnExport As Button
    Friend WithEvents btnSend As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents checkRefNo As CheckBox
    Friend WithEvents partNumber As DataGridViewTextBoxColumn
    Friend WithEvents itemName As DataGridViewTextBoxColumn
    Friend WithEvents specification As DataGridViewTextBoxColumn
    Friend WithEvents qty As DataGridViewTextBoxColumn
    Friend WithEvents manufacturer As DataGridViewTextBoxColumn
    Friend WithEvents recommendedSupplier As DataGridViewTextBoxColumn
    Friend WithEvents notes As DataGridViewTextBoxColumn
End Class
