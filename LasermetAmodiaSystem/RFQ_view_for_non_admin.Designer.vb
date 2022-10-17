<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RFQ_view_for_non_admin
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.rightClickMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ApproveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeclineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvRequest = New System.Windows.Forms.DataGridView()
        Me.tbComments = New System.Windows.Forms.RichTextBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnApprove = New System.Windows.Forms.Button()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.btnReapply = New System.Windows.Forms.Button()
        Me.btnExportToCSV = New System.Windows.Forms.Button()
        Me.btnImportCSV = New System.Windows.Forms.Button()
        Me.ExportBrowser = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.saveAsFile = New System.Windows.Forms.SaveFileDialog()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.rightClickMenu.SuspendLayout()
        CType(Me.dgvRequest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(242, 168)
        Me.DataGridView1.TabIndex = 0
        '
        'rightClickMenu
        '
        Me.rightClickMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApproveToolStripMenuItem, Me.DeclineToolStripMenuItem})
        Me.rightClickMenu.Name = "rightClickMenu"
        Me.rightClickMenu.Size = New System.Drawing.Size(120, 48)
        '
        'ApproveToolStripMenuItem
        '
        Me.ApproveToolStripMenuItem.Name = "ApproveToolStripMenuItem"
        Me.ApproveToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.ApproveToolStripMenuItem.Text = "Approve"
        '
        'DeclineToolStripMenuItem
        '
        Me.DeclineToolStripMenuItem.Name = "DeclineToolStripMenuItem"
        Me.DeclineToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.DeclineToolStripMenuItem.Text = "Decline"
        '
        'dgvRequest
        '
        Me.dgvRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRequest.Location = New System.Drawing.Point(12, 186)
        Me.dgvRequest.Name = "dgvRequest"
        Me.dgvRequest.Size = New System.Drawing.Size(718, 382)
        Me.dgvRequest.TabIndex = 1
        '
        'tbComments
        '
        Me.tbComments.Location = New System.Drawing.Point(121, 574)
        Me.tbComments.Name = "tbComments"
        Me.tbComments.Size = New System.Drawing.Size(500, 95)
        Me.tbComments.TabIndex = 3
        Me.tbComments.Text = "Type comments here."
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.Red
        Me.btnReturn.ForeColor = System.Drawing.Color.White
        Me.btnReturn.Location = New System.Drawing.Point(12, 574)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(103, 95)
        Me.btnReturn.TabIndex = 4
        Me.btnReturn.Text = "Return to Requestor"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'btnApprove
        '
        Me.btnApprove.BackColor = System.Drawing.Color.ForestGreen
        Me.btnApprove.ForeColor = System.Drawing.Color.White
        Me.btnApprove.Location = New System.Drawing.Point(627, 574)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(103, 95)
        Me.btnApprove.TabIndex = 4
        Me.btnApprove.Text = "Approve"
        Me.btnApprove.UseVisualStyleBackColor = False
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 681)
        Me.Splitter1.TabIndex = 5
        Me.Splitter1.TabStop = False
        '
        'btnReapply
        '
        Me.btnReapply.BackColor = System.Drawing.Color.ForestGreen
        Me.btnReapply.ForeColor = System.Drawing.Color.White
        Me.btnReapply.Location = New System.Drawing.Point(736, 186)
        Me.btnReapply.Name = "btnReapply"
        Me.btnReapply.Size = New System.Drawing.Size(103, 95)
        Me.btnReapply.TabIndex = 4
        Me.btnReapply.Text = "Re-Apply for Approval"
        Me.btnReapply.UseVisualStyleBackColor = False
        '
        'btnExportToCSV
        '
        Me.btnExportToCSV.BackColor = System.Drawing.Color.ForestGreen
        Me.btnExportToCSV.ForeColor = System.Drawing.Color.White
        Me.btnExportToCSV.Location = New System.Drawing.Point(845, 473)
        Me.btnExportToCSV.Name = "btnExportToCSV"
        Me.btnExportToCSV.Size = New System.Drawing.Size(103, 95)
        Me.btnExportToCSV.TabIndex = 4
        Me.btnExportToCSV.Text = "Export to Excel"
        Me.btnExportToCSV.UseVisualStyleBackColor = False
        Me.btnExportToCSV.Visible = False
        '
        'btnImportCSV
        '
        Me.btnImportCSV.BackColor = System.Drawing.Color.ForestGreen
        Me.btnImportCSV.ForeColor = System.Drawing.Color.White
        Me.btnImportCSV.Location = New System.Drawing.Point(736, 473)
        Me.btnImportCSV.Name = "btnImportCSV"
        Me.btnImportCSV.Size = New System.Drawing.Size(103, 95)
        Me.btnImportCSV.TabIndex = 4
        Me.btnImportCSV.Text = "Import from Excel"
        Me.btnImportCSV.UseVisualStyleBackColor = False
        Me.btnImportCSV.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "ImportBrowser"
        '
        'RFQ_view_for_non_admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1036, 681)
        Me.Controls.Add(Me.btnImportCSV)
        Me.Controls.Add(Me.btnExportToCSV)
        Me.Controls.Add(Me.btnReapply)
        Me.Controls.Add(Me.btnApprove)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.tbComments)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.dgvRequest)
        Me.Controls.Add(Me.DataGridView1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "RFQ_view_for_non_admin"
        Me.Text = "View Requests"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.rightClickMenu.ResumeLayout(False)
        CType(Me.dgvRequest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents rightClickMenu As ContextMenuStrip
    Friend WithEvents ApproveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeclineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgvRequest As DataGridView
    Friend WithEvents tbComments As RichTextBox
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnApprove As Button
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents btnReapply As Button
    Friend WithEvents btnExportToCSV As Button
    Friend WithEvents btnImportCSV As Button
    Friend WithEvents ExportBrowser As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents saveAsFile As SaveFileDialog
End Class
