<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnRFQ = New System.Windows.Forms.Button()
        Me.btnPR = New System.Windows.Forms.Button()
        Me.btnWithdrawal = New System.Windows.Forms.Button()
        Me.btnRFMC = New System.Windows.Forms.Button()
        Me.btnRFMU = New System.Windows.Forms.Button()
        Me.btnSAGE = New System.Windows.Forms.Button()
        Me.btnLeaveReq = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRFQ
        '
        Me.btnRFQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRFQ.Location = New System.Drawing.Point(12, 12)
        Me.btnRFQ.Name = "btnRFQ"
        Me.btnRFQ.Size = New System.Drawing.Size(150, 150)
        Me.btnRFQ.TabIndex = 0
        Me.btnRFQ.Text = "RFQ (Request for Quotation)"
        Me.btnRFQ.UseVisualStyleBackColor = True
        '
        'btnPR
        '
        Me.btnPR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPR.Location = New System.Drawing.Point(168, 13)
        Me.btnPR.Name = "btnPR"
        Me.btnPR.Size = New System.Drawing.Size(150, 150)
        Me.btnPR.TabIndex = 1
        Me.btnPR.Text = "Purchase Request"
        Me.btnPR.UseVisualStyleBackColor = True
        '
        'btnWithdrawal
        '
        Me.btnWithdrawal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWithdrawal.Location = New System.Drawing.Point(324, 13)
        Me.btnWithdrawal.Name = "btnWithdrawal"
        Me.btnWithdrawal.Size = New System.Drawing.Size(150, 150)
        Me.btnWithdrawal.TabIndex = 2
        Me.btnWithdrawal.Text = "Item/Parts Withdrawal"
        Me.btnWithdrawal.UseVisualStyleBackColor = True
        '
        'btnRFMC
        '
        Me.btnRFMC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRFMC.Location = New System.Drawing.Point(480, 13)
        Me.btnRFMC.Name = "btnRFMC"
        Me.btnRFMC.Size = New System.Drawing.Size(150, 150)
        Me.btnRFMC.TabIndex = 3
        Me.btnRFMC.Text = "RFMC (Request for Master File Creation)"
        Me.btnRFMC.UseVisualStyleBackColor = True
        '
        'btnRFMU
        '
        Me.btnRFMU.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRFMU.Location = New System.Drawing.Point(636, 12)
        Me.btnRFMU.Name = "btnRFMU"
        Me.btnRFMU.Size = New System.Drawing.Size(150, 150)
        Me.btnRFMU.TabIndex = 4
        Me.btnRFMU.Text = "RFMU (Request for Master File Update)"
        Me.btnRFMU.UseVisualStyleBackColor = True
        '
        'btnSAGE
        '
        Me.btnSAGE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSAGE.Location = New System.Drawing.Point(792, 12)
        Me.btnSAGE.Name = "btnSAGE"
        Me.btnSAGE.Size = New System.Drawing.Size(150, 150)
        Me.btnSAGE.TabIndex = 5
        Me.btnSAGE.Text = "SAGE Form Generator"
        Me.btnSAGE.UseVisualStyleBackColor = True
        '
        'btnLeaveReq
        '
        Me.btnLeaveReq.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLeaveReq.Location = New System.Drawing.Point(948, 12)
        Me.btnLeaveReq.Name = "btnLeaveReq"
        Me.btnLeaveReq.Size = New System.Drawing.Size(150, 150)
        Me.btnLeaveReq.TabIndex = 6
        Me.btnLeaveReq.Text = "Leave Request"
        Me.btnLeaveReq.UseVisualStyleBackColor = True
        '
        'mainDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1117, 175)
        Me.Controls.Add(Me.btnLeaveReq)
        Me.Controls.Add(Me.btnSAGE)
        Me.Controls.Add(Me.btnRFMU)
        Me.Controls.Add(Me.btnRFMC)
        Me.Controls.Add(Me.btnWithdrawal)
        Me.Controls.Add(Me.btnPR)
        Me.Controls.Add(Me.btnRFQ)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1133, 214)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1133, 214)
        Me.Name = "mainDashboard"
        Me.Text = "Main Dashboard"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnRFQ As Button
    Friend WithEvents btnPR As Button
    Friend WithEvents btnWithdrawal As Button
    Friend WithEvents btnRFMC As Button
    Friend WithEvents btnRFMU As Button
    Friend WithEvents btnSAGE As Button
    Friend WithEvents btnLeaveReq As Button
End Class
