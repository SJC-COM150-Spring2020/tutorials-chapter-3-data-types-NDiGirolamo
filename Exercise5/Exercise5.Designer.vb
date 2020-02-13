<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exercise5
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
        Me.btnBegin = New System.Windows.Forms.Button()
        Me.txtOut = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Font = New System.Drawing.Font("Segoe UI", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArea.Location = New System.Drawing.Point(83, 68)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(516, 50)
        Me.lblArea.TabIndex = 0
        Me.lblArea.Text = "Calculate the Area of a Square"
        '
        'btnBegin
        '
        Me.btnBegin.BackColor = System.Drawing.Color.Indigo
        Me.btnBegin.FlatAppearance.BorderSize = 0
        Me.btnBegin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBegin.Font = New System.Drawing.Font("Segoe UI", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBegin.ForeColor = System.Drawing.Color.White
        Me.btnBegin.Location = New System.Drawing.Point(226, 168)
        Me.btnBegin.Name = "btnBegin"
        Me.btnBegin.Size = New System.Drawing.Size(253, 78)
        Me.btnBegin.TabIndex = 1
        Me.btnBegin.Text = "BEGIN"
        Me.btnBegin.UseVisualStyleBackColor = False
        '
        'txtOut
        '
        Me.txtOut.Font = New System.Drawing.Font("Segoe UI", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOut.Location = New System.Drawing.Point(92, 296)
        Me.txtOut.Multiline = True
        Me.txtOut.Name = "txtOut"
        Me.txtOut.Size = New System.Drawing.Size(507, 110)
        Me.txtOut.TabIndex = 2
        '
        'Exercise5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(697, 456)
        Me.Controls.Add(Me.txtOut)
        Me.Controls.Add(Me.btnBegin)
        Me.Controls.Add(Me.lblArea)
        Me.Name = "Exercise5"
        Me.Text = "Working with Input Boxes"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblArea As Label
    Friend WithEvents btnBegin As Button
    Friend WithEvents txtOut As TextBox
End Class
