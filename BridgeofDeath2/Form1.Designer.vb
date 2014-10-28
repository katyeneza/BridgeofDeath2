<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnApproach = New System.Windows.Forms.Button()
        Me.lblFate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnApproach
        '
        Me.btnApproach.Location = New System.Drawing.Point(74, 46)
        Me.btnApproach.Name = "btnApproach"
        Me.btnApproach.Size = New System.Drawing.Size(142, 46)
        Me.btnApproach.TabIndex = 0
        Me.btnApproach.Text = "Approach the Bridge"
        Me.btnApproach.UseVisualStyleBackColor = True
        '
        'lblFate
        '
        Me.lblFate.AutoSize = True
        Me.lblFate.Location = New System.Drawing.Point(126, 137)
        Me.lblFate.Name = "lblFate"
        Me.lblFate.Size = New System.Drawing.Size(39, 13)
        Me.lblFate.TabIndex = 1
        Me.lblFate.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblFate)
        Me.Controls.Add(Me.btnApproach)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnApproach As System.Windows.Forms.Button
    Friend WithEvents lblFate As System.Windows.Forms.Label

End Class
