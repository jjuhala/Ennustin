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
        Me.tx_i = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.lb_i = New System.Windows.Forms.ListBox
        Me.lb_p = New System.Windows.Forms.ListBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lb_r = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.lb_perc = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'tx_i
        '
        Me.tx_i.BackColor = System.Drawing.Color.Black
        Me.tx_i.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tx_i.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_i.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.tx_i.Location = New System.Drawing.Point(270, 4)
        Me.tx_i.Name = "tx_i"
        Me.tx_i.Size = New System.Drawing.Size(73, 29)
        Me.tx_i.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Type ""random"" numbers (0-9) here:"
        '
        'lb_i
        '
        Me.lb_i.BackColor = System.Drawing.Color.Black
        Me.lb_i.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lb_i.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lb_i.FormattingEnabled = True
        Me.lb_i.Location = New System.Drawing.Point(80, 63)
        Me.lb_i.Name = "lb_i"
        Me.lb_i.Size = New System.Drawing.Size(50, 455)
        Me.lb_i.TabIndex = 3
        '
        'lb_p
        '
        Me.lb_p.BackColor = System.Drawing.Color.Black
        Me.lb_p.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lb_p.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lb_p.FormattingEnabled = True
        Me.lb_p.Location = New System.Drawing.Point(136, 63)
        Me.lb_p.Name = "lb_p"
        Me.lb_p.Size = New System.Drawing.Size(52, 455)
        Me.lb_p.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Your input"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(133, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Predicted input"
        '
        'lb_r
        '
        Me.lb_r.AutoSize = True
        Me.lb_r.Location = New System.Drawing.Point(222, 155)
        Me.lb_r.Name = "lb_r"
        Me.lb_r.Size = New System.Drawing.Size(94, 13)
        Me.lb_r.TabIndex = 8
        Me.lb_r.Text = "predicted correctly"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(198, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "First 10 are ignored ( learning)"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.GreenYellow
        Me.Button1.Location = New System.Drawing.Point(239, 72)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 32)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lb_perc
        '
        Me.lb_perc.AutoSize = True
        Me.lb_perc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_perc.ForeColor = System.Drawing.Color.GreenYellow
        Me.lb_perc.Location = New System.Drawing.Point(244, 130)
        Me.lb_perc.Name = "lb_perc"
        Me.lb_perc.Size = New System.Drawing.Size(48, 25)
        Me.lb_perc.TabIndex = 11
        Me.lb_perc.Text = "--%"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(354, 563)
        Me.Controls.Add(Me.lb_perc)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lb_r)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lb_p)
        Me.Controls.Add(Me.lb_i)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tx_i)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Ennustin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tx_i As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lb_i As System.Windows.Forms.ListBox
    Friend WithEvents lb_p As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lb_r As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lb_perc As System.Windows.Forms.Label

End Class
