<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exercise2
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
        Me.lblBase = New System.Windows.Forms.Label()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.txtBase = New System.Windows.Forms.TextBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnArea = New System.Windows.Forms.Button()
        Me.txtOut = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblBase
        '
        Me.lblBase.AutoSize = True
        Me.lblBase.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBase.Location = New System.Drawing.Point(71, 181)
        Me.lblBase.Name = "lblBase"
        Me.lblBase.Size = New System.Drawing.Size(367, 37)
        Me.lblBase.TabIndex = 0
        Me.lblBase.Text = "Enter the Base of the Triangle:"
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeight.Location = New System.Drawing.Point(71, 258)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(393, 37)
        Me.lblHeight.TabIndex = 1
        Me.lblHeight.Text = "Enter the Height of the Triangle:"
        '
        'txtBase
        '
        Me.txtBase.Location = New System.Drawing.Point(501, 187)
        Me.txtBase.Name = "txtBase"
        Me.txtBase.Size = New System.Drawing.Size(100, 31)
        Me.txtBase.TabIndex = 2
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(501, 265)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(100, 31)
        Me.txtHeight.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(69, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(465, 50)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Find the Area of a Triangle"
        '
        'btnArea
        '
        Me.btnArea.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnArea.FlatAppearance.BorderSize = 0
        Me.btnArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArea.Font = New System.Drawing.Font("Segoe UI Semibold", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArea.ForeColor = System.Drawing.Color.Navy
        Me.btnArea.Location = New System.Drawing.Point(78, 352)
        Me.btnArea.Name = "btnArea"
        Me.btnArea.Size = New System.Drawing.Size(271, 71)
        Me.btnArea.TabIndex = 5
        Me.btnArea.Text = "Calculate Area"
        Me.btnArea.UseVisualStyleBackColor = False
        '
        'txtOut
        '
        Me.txtOut.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOut.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOut.Location = New System.Drawing.Point(78, 489)
        Me.txtOut.Multiline = True
        Me.txtOut.Name = "txtOut"
        Me.txtOut.Size = New System.Drawing.Size(654, 85)
        Me.txtOut.TabIndex = 6
        '
        'Exercise2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(824, 680)
        Me.Controls.Add(Me.txtOut)
        Me.Controls.Add(Me.btnArea)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.txtBase)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.lblBase)
        Me.Name = "Exercise2"
        Me.Text = "Area of a Triangle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBase As Label
    Friend WithEvents lblHeight As Label
    Friend WithEvents txtBase As TextBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnArea As Button
    Friend WithEvents txtOut As TextBox
End Class
