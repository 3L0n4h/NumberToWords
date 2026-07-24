<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm
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
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.labelResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(102, 23)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(259, 20)
        Me.txtAmount.TabIndex = 6
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(11, 93)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(85, 13)
        Me.lblResult.TabIndex = 11
        Me.lblResult.Text = "Result in Words:"
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = True
        Me.lblFirst.Location = New System.Drawing.Point(47, 26)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(46, 13)
        Me.lblFirst.TabIndex = 9
        Me.lblFirst.Text = "Amount:"
        '
        'btnPlus
        '
        Me.btnPlus.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnPlus.Location = New System.Drawing.Point(99, 49)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(71, 33)
        Me.btnPlus.TabIndex = 8
        Me.btnPlus.Text = "Convert"
        Me.btnPlus.UseVisualStyleBackColor = False
        '
        'labelResult
        '
        Me.labelResult.BackColor = System.Drawing.Color.Transparent
        Me.labelResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labelResult.Location = New System.Drawing.Point(102, 93)
        Me.labelResult.Name = "labelResult"
        Me.labelResult.Size = New System.Drawing.Size(259, 101)
        Me.labelResult.TabIndex = 14
        '
        'frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 203)
        Me.Controls.Add(Me.labelResult)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblFirst)
        Me.Controls.Add(Me.btnPlus)
        Me.Name = "frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Convert Number to Words"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtAmount As TextBox
    Friend WithEvents lblResult As Label
    Friend WithEvents lblFirst As Label
    Friend WithEvents btnPlus As Button
    Friend WithEvents labelResult As Label
End Class
