<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAHK
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
        Me.lbLoc = New System.Windows.Forms.ListBox()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.btnKill = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ahkReadMe = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbLoc
        '
        Me.lbLoc.FormattingEnabled = True
        Me.lbLoc.Items.AddRange(New Object() {"Service Desk", "Swanston Library", "Brunswick Library", "Bundoora Library"})
        Me.lbLoc.Location = New System.Drawing.Point(43, 45)
        Me.lbLoc.Name = "lbLoc"
        Me.lbLoc.Size = New System.Drawing.Size(338, 69)
        Me.lbLoc.TabIndex = 0
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(43, 120)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(79, 49)
        Me.btnSelect.TabIndex = 1
        Me.btnSelect.Text = "Select"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'btnKill
        '
        Me.btnKill.Location = New System.Drawing.Point(219, 120)
        Me.btnKill.Name = "btnKill"
        Me.btnKill.Size = New System.Drawing.Size(77, 49)
        Me.btnKill.TabIndex = 2
        Me.btnKill.Text = "Kill open AHK scripts"
        Me.btnKill.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(302, 120)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(79, 49)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(79, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Select your current location"
        '
        'ahkReadMe
        '
        Me.ahkReadMe.Location = New System.Drawing.Point(129, 121)
        Me.ahkReadMe.Name = "ahkReadMe"
        Me.ahkReadMe.Size = New System.Drawing.Size(84, 48)
        Me.ahkReadMe.TabIndex = 5
        Me.ahkReadMe.Text = "Readme"
        Me.ahkReadMe.UseVisualStyleBackColor = True
        '
        'frmAHK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 190)
        Me.Controls.Add(Me.ahkReadMe)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnKill)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.lbLoc)
        Me.Name = "frmAHK"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbLoc As System.Windows.Forms.ListBox
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents btnKill As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ahkReadMe As System.Windows.Forms.Button
End Class
