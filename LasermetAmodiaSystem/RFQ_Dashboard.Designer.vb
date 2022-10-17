<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RFQ_Dashboard
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
        Me.btnNewRequest = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnNewRequest
        '
        Me.btnNewRequest.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewRequest.Location = New System.Drawing.Point(12, 12)
        Me.btnNewRequest.Name = "btnNewRequest"
        Me.btnNewRequest.Size = New System.Drawing.Size(150, 150)
        Me.btnNewRequest.TabIndex = 1
        Me.btnNewRequest.Text = "New Request"
        Me.btnNewRequest.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(168, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 150)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "View Requests"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(324, 13)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(150, 150)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'RFQ_Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 175)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnNewRequest)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(503, 214)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(503, 214)
        Me.Name = "RFQ_Dashboard"
        Me.Text = "RFQ_Dashboard"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnNewRequest As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnExit As Button
End Class
