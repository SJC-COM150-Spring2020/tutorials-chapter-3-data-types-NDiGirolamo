<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exercise3
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
        Me.lblArea = New System.Windows.Forms.Label()
        Me.txtRadius = New System.Windows.Forms.TextBox()
        Me.btnArea = New System.Windows.Forms.Button()
        Me.txtOut = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Font = New System.Drawing.Font("Segoe UI", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea.Location = New System.Drawing.Point(58, 148)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(391, 40)
        Me.lblArea.TabIndex = 0
        Me.lblArea.Text = "Enter the Radius of the Circle:"
        '
        'txtRadius
        '
        Me.txtRadius.Location = New System.Drawing.Point(478, 138)
        Me.txtRadius.Multiline = True
        Me.txtRadius.Name = "txtRadius"
        Me.txtRadius.Size = New System.Drawing.Size(100, 61)
        Me.txtRadius.TabIndex = 1
        '
        'btnArea
        '
        Me.btnArea.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnArea.FlatAppearance.BorderSize = 0
        Me.btnArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArea.Font = New System.Drawing.Font("Segoe UI Semibold", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArea.ForeColor = System.Drawing.Color.Navy
        Me.btnArea.Location = New System.Drawing.Point(65, 254)
        Me.btnArea.Name = "btnArea"
        Me.btnArea.Size = New System.Drawing.Size(287, 69)
        Me.btnArea.TabIndex = 2
        Me.btnArea.Text = "Calculate Area"
        Me.btnArea.UseVisualStyleBackColor = False
        '
        'txtOut
        '
        Me.txtOut.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOut.Font = New System.Drawing.Font("Segoe UI", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOut.Location = New System.Drawing.Point(65, 419)
        Me.txtOut.Name = "txtOut"
        Me.txtOut.Size = New System.Drawing.Size(638, 39)
        Me.txtOut.TabIndex = 3
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(56, 58)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(439, 45)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Calculate the Area of a Circle"
        '
        'Exercise3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(775, 514)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.txtOut)
        Me.Controls.Add(Me.btnArea)
        Me.Controls.Add(Me.txtRadius)
        Me.Controls.Add(Me.lblArea)
        Me.Name = "Exercise3"
        Me.Text = "Area of a Circle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblArea As Label
    Friend WithEvents txtRadius As TextBox
    Friend WithEvents btnArea As Button
    Friend WithEvents txtOut As TextBox
    Friend WithEvents lblTitle As Label
End Class
