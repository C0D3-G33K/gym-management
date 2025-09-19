<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Subscriptions
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
        Me.IblMemberID = New System.Windows.Forms.Label()
        Me.lblPlanType = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblPaymentDate = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.dtpPaymentDate = New System.Windows.Forms.DateTimePicker()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dvgPayments = New System.Windows.Forms.DataGridView()
        Me.cboMemberID = New System.Windows.Forms.ComboBox()
        Me.cboPlanType = New System.Windows.Forms.ComboBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnBackToMembers = New System.Windows.Forms.Button()
        CType(Me.dvgPayments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IblMemberID
        '
        Me.IblMemberID.AutoSize = True
        Me.IblMemberID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IblMemberID.Location = New System.Drawing.Point(139, 89)
        Me.IblMemberID.Name = "IblMemberID"
        Me.IblMemberID.Size = New System.Drawing.Size(117, 25)
        Me.IblMemberID.TabIndex = 0
        Me.IblMemberID.Text = "Member ID"
        '
        'lblPlanType
        '
        Me.lblPlanType.AutoSize = True
        Me.lblPlanType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlanType.Location = New System.Drawing.Point(139, 139)
        Me.lblPlanType.Name = "lblPlanType"
        Me.lblPlanType.Size = New System.Drawing.Size(110, 25)
        Me.lblPlanType.TabIndex = 1
        Me.lblPlanType.Text = "Plan Type"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.Location = New System.Drawing.Point(139, 191)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(135, 25)
        Me.lblAmount.TabIndex = 2
        Me.lblAmount.Text = "Amount Paid"
        '
        'lblPaymentDate
        '
        Me.lblPaymentDate.AutoSize = True
        Me.lblPaymentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentDate.Location = New System.Drawing.Point(130, 240)
        Me.lblPaymentDate.Name = "lblPaymentDate"
        Me.lblPaymentDate.Size = New System.Drawing.Size(147, 25)
        Me.lblPaymentDate.TabIndex = 3
        Me.lblPaymentDate.Text = "Payment Date"
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(503, 186)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 30)
        Me.txtAmount.TabIndex = 4
        '
        'dtpPaymentDate
        '
        Me.dtpPaymentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPaymentDate.Location = New System.Drawing.Point(503, 235)
        Me.dtpPaymentDate.Name = "dtpPaymentDate"
        Me.dtpPaymentDate.Size = New System.Drawing.Size(351, 30)
        Me.dtpPaymentDate.TabIndex = 5
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(320, 312)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 31)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'dvgPayments
        '
        Me.dvgPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgPayments.Location = New System.Drawing.Point(159, 363)
        Me.dvgPayments.Name = "dvgPayments"
        Me.dvgPayments.RowTemplate.Height = 24
        Me.dvgPayments.Size = New System.Drawing.Size(564, 150)
        Me.dvgPayments.TabIndex = 7
        '
        'cboMemberID
        '
        Me.cboMemberID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMemberID.FormattingEnabled = True
        Me.cboMemberID.Location = New System.Drawing.Point(503, 81)
        Me.cboMemberID.Name = "cboMemberID"
        Me.cboMemberID.Size = New System.Drawing.Size(121, 33)
        Me.cboMemberID.TabIndex = 8
        '
        'cboPlanType
        '
        Me.cboPlanType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPlanType.FormattingEnabled = True
        Me.cboPlanType.Location = New System.Drawing.Point(503, 131)
        Me.cboPlanType.Name = "cboPlanType"
        Me.cboPlanType.Size = New System.Drawing.Size(121, 33)
        Me.cboPlanType.TabIndex = 9
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(789, 303)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 31)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnBackToMembers
        '
        Me.btnBackToMembers.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackToMembers.Location = New System.Drawing.Point(883, 464)
        Me.btnBackToMembers.Name = "btnBackToMembers"
        Me.btnBackToMembers.Size = New System.Drawing.Size(183, 34)
        Me.btnBackToMembers.TabIndex = 11
        Me.btnBackToMembers.Text = "Back To Members"
        Me.btnBackToMembers.UseVisualStyleBackColor = True
        '
        'Subscriptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GYM_MANAGEMENT.My.Resources.Resources.k
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1173, 541)
        Me.Controls.Add(Me.btnBackToMembers)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.cboPlanType)
        Me.Controls.Add(Me.cboMemberID)
        Me.Controls.Add(Me.dvgPayments)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dtpPaymentDate)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.lblPaymentDate)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.lblPlanType)
        Me.Controls.Add(Me.IblMemberID)
        Me.Name = "Subscriptions"
        Me.Text = "Subscriptions"
        CType(Me.dvgPayments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IblMemberID As System.Windows.Forms.Label
    Friend WithEvents lblPlanType As System.Windows.Forms.Label
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents lblPaymentDate As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents dtpPaymentDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents dvgPayments As System.Windows.Forms.DataGridView
    Friend WithEvents cboMemberID As System.Windows.Forms.ComboBox
    Friend WithEvents cboPlanType As System.Windows.Forms.ComboBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnBackToMembers As System.Windows.Forms.Button
End Class
