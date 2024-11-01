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
        Me.txt_A = New System.Windows.Forms.TextBox()
        Me.txt_B = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_plus = New System.Windows.Forms.Button()
        Me.btn_moins = New System.Windows.Forms.Button()
        Me.btn_mult = New System.Windows.Forms.Button()
        Me.btn_div = New System.Windows.Forms.Button()
        Me.btn_equal = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_res = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_A
        '
        Me.txt_A.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_A.Location = New System.Drawing.Point(183, 80)
        Me.txt_A.Name = "txt_A"
        Me.txt_A.Size = New System.Drawing.Size(180, 49)
        Me.txt_A.TabIndex = 0
        '
        'txt_B
        '
        Me.txt_B.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_B.Location = New System.Drawing.Point(183, 181)
        Me.txt_B.Name = "txt_B"
        Me.txt_B.Size = New System.Drawing.Size(180, 49)
        Me.txt_B.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(106, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 42)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "B"
        '
        'btn_plus
        '
        Me.btn_plus.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_plus.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_plus.Location = New System.Drawing.Point(608, 68)
        Me.btn_plus.Name = "btn_plus"
        Me.btn_plus.Size = New System.Drawing.Size(66, 46)
        Me.btn_plus.TabIndex = 4
        Me.btn_plus.Text = "+"
        Me.btn_plus.UseVisualStyleBackColor = False
        '
        'btn_moins
        '
        Me.btn_moins.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_moins.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_moins.Location = New System.Drawing.Point(608, 137)
        Me.btn_moins.Name = "btn_moins"
        Me.btn_moins.Size = New System.Drawing.Size(66, 46)
        Me.btn_moins.TabIndex = 5
        Me.btn_moins.Text = "-"
        Me.btn_moins.UseVisualStyleBackColor = False
        '
        'btn_mult
        '
        Me.btn_mult.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_mult.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mult.Location = New System.Drawing.Point(608, 204)
        Me.btn_mult.Name = "btn_mult"
        Me.btn_mult.Size = New System.Drawing.Size(66, 46)
        Me.btn_mult.TabIndex = 6
        Me.btn_mult.Text = "*"
        Me.btn_mult.UseVisualStyleBackColor = False
        '
        'btn_div
        '
        Me.btn_div.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_div.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_div.Location = New System.Drawing.Point(608, 272)
        Me.btn_div.Name = "btn_div"
        Me.btn_div.Size = New System.Drawing.Size(66, 46)
        Me.btn_div.TabIndex = 7
        Me.btn_div.Text = "/"
        Me.btn_div.UseVisualStyleBackColor = False
        '
        'btn_equal
        '
        Me.btn_equal.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_equal.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_equal.Location = New System.Drawing.Point(113, 272)
        Me.btn_equal.Name = "btn_equal"
        Me.btn_equal.Size = New System.Drawing.Size(132, 46)
        Me.btn_equal.TabIndex = 8
        Me.btn_equal.Text = "="
        Me.btn_equal.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(106, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 42)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "A"
        '
        'lbl_res
        '
        Me.lbl_res.AutoSize = True
        Me.lbl_res.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_res.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_res.Location = New System.Drawing.Point(466, 377)
        Me.lbl_res.Name = "lbl_res"
        Me.lbl_res.Size = New System.Drawing.Size(140, 42)
        Me.lbl_res.TabIndex = 11
        Me.lbl_res.Text = "resultat"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 486)
        Me.Controls.Add(Me.lbl_res)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_equal)
        Me.Controls.Add(Me.btn_div)
        Me.Controls.Add(Me.btn_mult)
        Me.Controls.Add(Me.btn_moins)
        Me.Controls.Add(Me.btn_plus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_B)
        Me.Controls.Add(Me.txt_A)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_A As TextBox
    Friend WithEvents txt_B As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_plus As Button
    Friend WithEvents btn_moins As Button
    Friend WithEvents btn_mult As Button
    Friend WithEvents btn_div As Button
    Friend WithEvents btn_equal As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_res As Label
End Class
