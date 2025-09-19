<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Classes
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
        Me.txtClassName = New System.Windows.Forms.TextBox()
        Me.cmbTrainer = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblClassName = New System.Windows.Forms.Label()
        Me.lblTrainer = New System.Windows.Forms.Label()
        Me.lblSchedule = New System.Windows.Forms.Label()
        Me.dtpSchedule = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'txtClassName
        '
        Me.txtClassName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClassName.Location = New System.Drawing.Point(265, 54)
        Me.txtClassName.Name = "txtClassName"
        Me.txtClassName.Size = New System.Drawing.Size(100, 38)
        Me.txtClassName.TabIndex = 1
        '
        'cmbTrainer
        '
        Me.cmbTrainer.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTrainer.FormattingEnabled = True
        Me.cmbTrainer.Location = New System.Drawing.Point(265, 143)
        Me.cmbTrainer.Name = "cmbTrainer"
        Me.cmbTrainer.Size = New System.Drawing.Size(121, 39)
        Me.cmbTrainer.TabIndex = 3
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(265, 320)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(121, 66)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblClassName
        '
        Me.lblClassName.AutoSize = True
        Me.lblClassName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClassName.Location = New System.Drawing.Point(55, 54)
        Me.lblClassName.Name = "lblClassName"
        Me.lblClassName.Size = New System.Drawing.Size(178, 32)
        Me.lblClassName.TabIndex = 9
        Me.lblClassName.Text = "Class Name"
        '
        'lblTrainer
        '
        Me.lblTrainer.AutoSize = True
        Me.lblTrainer.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrainer.Location = New System.Drawing.Point(84, 146)
        Me.lblTrainer.Name = "lblTrainer"
        Me.lblTrainer.Size = New System.Drawing.Size(112, 32)
        Me.lblTrainer.TabIndex = 10
        Me.lblTrainer.Text = "Trainer"
        '
        'lblSchedule
        '
        Me.lblSchedule.AutoSize = True
        Me.lblSchedule.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSchedule.Location = New System.Drawing.Point(71, 227)
        Me.lblSchedule.Name = "lblSchedule"
        Me.lblSchedule.Size = New System.Drawing.Size(143, 32)
        Me.lblSchedule.TabIndex = 11
        Me.lblSchedule.Text = "Schedule"
        '
        'dtpSchedule
        '
        Me.dtpSchedule.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpSchedule.Location = New System.Drawing.Point(265, 222)
        Me.dtpSchedule.Name = "dtpSchedule"
        Me.dtpSchedule.Size = New System.Drawing.Size(328, 38)
        Me.dtpSchedule.TabIndex = 12
        '
        'Classes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GYM_MANAGEMENT.My.Resources.Resources.gym
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(642, 439)
        Me.Controls.Add(Me.dtpSchedule)
        Me.Controls.Add(Me.lblSchedule)
        Me.Controls.Add(Me.lblTrainer)
        Me.Controls.Add(Me.lblClassName)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cmbTrainer)
        Me.Controls.Add(Me.txtClassName)
        Me.Name = "Classes"
        Me.Text = "Classes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtClassName As System.Windows.Forms.TextBox
    Friend WithEvents cmbTrainer As System.Windows.Forms.ComboBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblClassName As System.Windows.Forms.Label
    Friend WithEvents lblTrainer As System.Windows.Forms.Label
    Friend WithEvents lblSchedule As System.Windows.Forms.Label
    Friend WithEvents dtpSchedule As System.Windows.Forms.DateTimePicker
End Class
