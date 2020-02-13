<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exercise1
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
        Me.txtIn = New System.Windows.Forms.TextBox()
        Me.btnArea = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOut = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtIn
        '
        Me.txtIn.Location = New System.Drawing.Point(573, 98)
        Me.txtIn.Multiline = True
        Me.txtIn.Name = "txtIn"
        Me.txtIn.Size = New System.Drawing.Size(98, 65)
        Me.txtIn.TabIndex = 0
        '
        'btnArea
        '
        Me.btnArea.BackColor = System.Drawing.Color.Indigo
        Me.btnArea.FlatAppearance.BorderSize = 0
        Me.btnArea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArea.Font = New System.Drawing.Font("Segoe UI Semibold", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArea.ForeColor = System.Drawing.Color.White
        Me.btnArea.Location = New System.Drawing.Point(203, 241)
        Me.btnArea.Name = "btnArea"
        Me.btnArea.Size = New System.Drawing.Size(393, 94)
        Me.btnArea.TabIndex = 1
        Me.btnArea.Text = "Calculate Area"
        Me.btnArea.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(88, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(455, 50)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter the Side of a Square:"
        '
        'txtOut
        '
        Me.txtOut.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOut.Location = New System.Drawing.Point(60, 412)
        Me.txtOut.Multiline = True
        Me.txtOut.Name = "txtOut"
        Me.txtOut.Size = New System.Drawing.Size(646, 77)
        Me.txtOut.TabIndex = 3
        '
        'Exercise1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(797, 561)
        Me.Controls.Add(Me.txtOut)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnArea)
        Me.Controls.Add(Me.txtIn)
        Me.Name = "Exercise1"
        Me.Text = "Area of a Square"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtIn As TextBox
    Friend WithEvents btnArea As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtOut As TextBox
End Class
