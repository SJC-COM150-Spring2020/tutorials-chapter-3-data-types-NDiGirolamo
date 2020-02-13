<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exercise4
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblGrade1 = New System.Windows.Forms.Label()
        Me.txtGrade1 = New System.Windows.Forms.TextBox()
        Me.lblGrade2 = New System.Windows.Forms.Label()
        Me.txtGrade2 = New System.Windows.Forms.TextBox()
        Me.btnAverage = New System.Windows.Forms.Button()
        Me.txtOut = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(59, 74)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(475, 45)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Find the Average of two grades"
        '
        'lblGrade1
        '
        Me.lblGrade1.AutoSize = True
        Me.lblGrade1.Font = New System.Drawing.Font("Segoe UI", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrade1.Location = New System.Drawing.Point(114, 169)
        Me.lblGrade1.Name = "lblGrade1"
        Me.lblGrade1.Size = New System.Drawing.Size(278, 40)
        Me.lblGrade1.TabIndex = 1
        Me.lblGrade1.Text = "Enter the First Grade"
        '
        'txtGrade1
        '
        Me.txtGrade1.Font = New System.Drawing.Font("Segoe UI", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrade1.Location = New System.Drawing.Point(413, 169)
        Me.txtGrade1.Name = "txtGrade1"
        Me.txtGrade1.Size = New System.Drawing.Size(100, 46)
        Me.txtGrade1.TabIndex = 2
        '
        'lblGrade2
        '
        Me.lblGrade2.AutoSize = True
        Me.lblGrade2.Font = New System.Drawing.Font("Segoe UI", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrade2.Location = New System.Drawing.Point(74, 254)
        Me.lblGrade2.Name = "lblGrade2"
        Me.lblGrade2.Size = New System.Drawing.Size(318, 40)
        Me.lblGrade2.TabIndex = 3
        Me.lblGrade2.Text = "Enter the Second Grade"
        '
        'txtGrade2
        '
        Me.txtGrade2.Font = New System.Drawing.Font("Segoe UI", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrade2.Location = New System.Drawing.Point(413, 254)
        Me.txtGrade2.Name = "txtGrade2"
        Me.txtGrade2.Size = New System.Drawing.Size(100, 46)
        Me.txtGrade2.TabIndex = 4
        '
        'btnAverage
        '
        Me.btnAverage.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAverage.FlatAppearance.BorderSize = 0
        Me.btnAverage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAverage.Font = New System.Drawing.Font("Segoe UI Semibold", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAverage.ForeColor = System.Drawing.Color.Navy
        Me.btnAverage.Location = New System.Drawing.Point(238, 350)
        Me.btnAverage.Name = "btnAverage"
        Me.btnAverage.Size = New System.Drawing.Size(275, 73)
        Me.btnAverage.TabIndex = 5
        Me.btnAverage.Text = "Calculate Average"
        Me.btnAverage.UseVisualStyleBackColor = False
        '
        'txtOut
        '
        Me.txtOut.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOut.Font = New System.Drawing.Font("Segoe UI", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOut.Location = New System.Drawing.Point(81, 475)
        Me.txtOut.Multiline = True
        Me.txtOut.Name = "txtOut"
        Me.txtOut.Size = New System.Drawing.Size(573, 56)
        Me.txtOut.TabIndex = 6
        '
        'Exercise4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(732, 596)
        Me.Controls.Add(Me.txtOut)
        Me.Controls.Add(Me.btnAverage)
        Me.Controls.Add(Me.txtGrade2)
        Me.Controls.Add(Me.lblGrade2)
        Me.Controls.Add(Me.txtGrade1)
        Me.Controls.Add(Me.lblGrade1)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Exercise4"
        Me.Text = "Finding the Average"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblGrade1 As Label
    Friend WithEvents txtGrade1 As TextBox
    Friend WithEvents lblGrade2 As Label
    Friend WithEvents txtGrade2 As TextBox
    Friend WithEvents btnAverage As Button
    Friend WithEvents txtOut As TextBox
End Class
