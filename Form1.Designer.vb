<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        result = New TextBox()
        btnpt = New Button()
        btn0 = New Button()
        btn00 = New Button()
        btn1 = New Button()
        btn2 = New Button()
        btn3 = New Button()
        btn4 = New Button()
        btn5 = New Button()
        btn6 = New Button()
        btn7 = New Button()
        btn8 = New Button()
        btn9 = New Button()
        btnplus = New Button()
        btnminus = New Button()
        btnmultiply = New Button()
        btndivide = New Button()
        btnclear = New Button()
        btndelete = New Button()
        btnequal = New Button()
        SuspendLayout()
        ' 
        ' result
        ' 
        result.Font = New Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        result.ForeColor = SystemColors.ActiveCaptionText
        result.Location = New Point(12, 12)
        result.Multiline = True
        result.Name = "result"
        result.Size = New Size(543, 49)
        result.TabIndex = 0
        ' 
        ' btnpt
        ' 
        btnpt.BackColor = Color.LightGray
        btnpt.Font = New Font("MS Reference Sans Serif", 10.2F)
        btnpt.ForeColor = SystemColors.ActiveCaptionText
        btnpt.Location = New Point(12, 292)
        btnpt.Name = "btnpt"
        btnpt.Size = New Size(94, 69)
        btnpt.TabIndex = 1
        btnpt.Text = "."
        btnpt.UseVisualStyleBackColor = False
        ' 
        ' btn0
        ' 
        btn0.BackColor = Color.LightGray
        btn0.Font = New Font("MS Reference Sans Serif", 10.2F)
        btn0.ForeColor = SystemColors.ActiveCaptionText
        btn0.Location = New Point(112, 292)
        btn0.Name = "btn0"
        btn0.Size = New Size(94, 69)
        btn0.TabIndex = 2
        btn0.Text = "0"
        btn0.UseVisualStyleBackColor = False
        ' 
        ' btn00
        ' 
        btn00.BackColor = Color.LightGray
        btn00.Font = New Font("MS Reference Sans Serif", 10.2F)
        btn00.ForeColor = SystemColors.ActiveCaptionText
        btn00.Location = New Point(212, 292)
        btn00.Name = "btn00"
        btn00.Size = New Size(94, 69)
        btn00.TabIndex = 3
        btn00.Text = "00"
        btn00.UseVisualStyleBackColor = False
        ' 
        ' btn1
        ' 
        btn1.BackColor = Color.LightGray
        btn1.Font = New Font("MS Reference Sans Serif", 10.2F)
        btn1.ForeColor = SystemColors.ActiveCaptionText
        btn1.Location = New Point(12, 217)
        btn1.Name = "btn1"
        btn1.Size = New Size(94, 69)
        btn1.TabIndex = 6
        btn1.Text = "1"
        btn1.UseVisualStyleBackColor = False
        ' 
        ' btn2
        ' 
        btn2.BackColor = Color.LightGray
        btn2.Font = New Font("MS Reference Sans Serif", 10.2F)
        btn2.ForeColor = SystemColors.ActiveCaptionText
        btn2.Location = New Point(112, 217)
        btn2.Name = "btn2"
        btn2.Size = New Size(94, 69)
        btn2.TabIndex = 5
        btn2.Text = "2"
        btn2.UseVisualStyleBackColor = False
        ' 
        ' btn3
        ' 
        btn3.BackColor = Color.LightGray
        btn3.Font = New Font("MS Reference Sans Serif", 10.2F)
        btn3.ForeColor = SystemColors.ActiveCaptionText
        btn3.Location = New Point(212, 217)
        btn3.Name = "btn3"
        btn3.Size = New Size(94, 69)
        btn3.TabIndex = 4
        btn3.Text = "3"
        btn3.UseVisualStyleBackColor = False
        ' 
        ' btn4
        ' 
        btn4.BackColor = Color.LightGray
        btn4.Font = New Font("MS Reference Sans Serif", 10.2F)
        btn4.ForeColor = SystemColors.ActiveCaptionText
        btn4.Location = New Point(12, 142)
        btn4.Name = "btn4"
        btn4.Size = New Size(94, 69)
        btn4.TabIndex = 12
        btn4.Text = "4"
        btn4.UseVisualStyleBackColor = False
        ' 
        ' btn5
        ' 
        btn5.BackColor = Color.LightGray
        btn5.Font = New Font("MS Reference Sans Serif", 10.2F)
        btn5.ForeColor = SystemColors.ActiveCaptionText
        btn5.Location = New Point(112, 142)
        btn5.Name = "btn5"
        btn5.Size = New Size(94, 69)
        btn5.TabIndex = 11
        btn5.Text = "5"
        btn5.UseVisualStyleBackColor = False
        ' 
        ' btn6
        ' 
        btn6.BackColor = Color.LightGray
        btn6.Font = New Font("MS Reference Sans Serif", 10.2F)
        btn6.ForeColor = SystemColors.ActiveCaptionText
        btn6.Location = New Point(212, 142)
        btn6.Name = "btn6"
        btn6.Size = New Size(94, 69)
        btn6.TabIndex = 10
        btn6.Text = "6"
        btn6.UseVisualStyleBackColor = False
        ' 
        ' btn7
        ' 
        btn7.BackColor = Color.LightGray
        btn7.Font = New Font("MS Reference Sans Serif", 10.2F)
        btn7.ForeColor = SystemColors.ActiveCaptionText
        btn7.Location = New Point(12, 67)
        btn7.Name = "btn7"
        btn7.Size = New Size(94, 69)
        btn7.TabIndex = 9
        btn7.Text = "7"
        btn7.UseVisualStyleBackColor = False
        ' 
        ' btn8
        ' 
        btn8.BackColor = Color.LightGray
        btn8.Font = New Font("MS Reference Sans Serif", 10.2F)
        btn8.ForeColor = SystemColors.ActiveCaptionText
        btn8.Location = New Point(112, 67)
        btn8.Name = "btn8"
        btn8.Size = New Size(94, 69)
        btn8.TabIndex = 8
        btn8.Text = "8"
        btn8.UseVisualStyleBackColor = False
        ' 
        ' btn9
        ' 
        btn9.BackColor = Color.LightGray
        btn9.Font = New Font("MS Reference Sans Serif", 10.2F)
        btn9.ForeColor = SystemColors.ActiveCaptionText
        btn9.Location = New Point(212, 67)
        btn9.Name = "btn9"
        btn9.Size = New Size(94, 69)
        btn9.TabIndex = 7
        btn9.Text = "9"
        btn9.UseVisualStyleBackColor = False
        ' 
        ' btnplus
        ' 
        btnplus.BackColor = Color.LightGray
        btnplus.Font = New Font("MS Reference Sans Serif", 10.2F)
        btnplus.ForeColor = SystemColors.ActiveCaptionText
        btnplus.Location = New Point(361, 67)
        btnplus.Name = "btnplus"
        btnplus.Size = New Size(94, 69)
        btnplus.TabIndex = 14
        btnplus.Text = "+"
        btnplus.UseVisualStyleBackColor = False
        ' 
        ' btnminus
        ' 
        btnminus.BackColor = Color.LightGray
        btnminus.Font = New Font("MS Reference Sans Serif", 10.2F)
        btnminus.ForeColor = SystemColors.ActiveCaptionText
        btnminus.Location = New Point(461, 67)
        btnminus.Name = "btnminus"
        btnminus.Size = New Size(94, 69)
        btnminus.TabIndex = 13
        btnminus.Text = "-"
        btnminus.UseVisualStyleBackColor = False
        ' 
        ' btnmultiply
        ' 
        btnmultiply.BackColor = Color.LightGray
        btnmultiply.Font = New Font("MS Reference Sans Serif", 10.2F)
        btnmultiply.ForeColor = SystemColors.ActiveCaptionText
        btnmultiply.Location = New Point(361, 142)
        btnmultiply.Name = "btnmultiply"
        btnmultiply.Size = New Size(94, 69)
        btnmultiply.TabIndex = 16
        btnmultiply.Text = "x"
        btnmultiply.UseVisualStyleBackColor = False
        ' 
        ' btndivide
        ' 
        btndivide.BackColor = Color.LightGray
        btndivide.Font = New Font("MS Reference Sans Serif", 10.2F)
        btndivide.ForeColor = SystemColors.ActiveCaptionText
        btndivide.Location = New Point(461, 142)
        btndivide.Name = "btndivide"
        btndivide.Size = New Size(94, 69)
        btndivide.TabIndex = 15
        btndivide.Text = "÷"
        btndivide.UseVisualStyleBackColor = False
        ' 
        ' btnclear
        ' 
        btnclear.BackColor = Color.LightGray
        btnclear.Font = New Font("MS Reference Sans Serif", 10.2F)
        btnclear.ForeColor = SystemColors.ActiveCaptionText
        btnclear.Location = New Point(361, 217)
        btnclear.Name = "btnclear"
        btnclear.Size = New Size(94, 69)
        btnclear.TabIndex = 18
        btnclear.Text = "CE"
        btnclear.UseVisualStyleBackColor = False
        ' 
        ' btndelete
        ' 
        btndelete.BackColor = Color.LightGray
        btndelete.Font = New Font("MS Reference Sans Serif", 10.2F)
        btndelete.ForeColor = SystemColors.ActiveCaptionText
        btndelete.Location = New Point(461, 217)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(94, 69)
        btndelete.TabIndex = 17
        btndelete.Text = "⌫"
        btndelete.UseVisualStyleBackColor = False
        ' 
        ' btnequal
        ' 
        btnequal.BackColor = Color.LightGray
        btnequal.Font = New Font("MS Reference Sans Serif", 10.2F)
        btnequal.ForeColor = SystemColors.ActiveCaptionText
        btnequal.Location = New Point(361, 292)
        btnequal.Name = "btnequal"
        btnequal.Size = New Size(194, 69)
        btnequal.TabIndex = 19
        btnequal.Text = "="
        btnequal.UseVisualStyleBackColor = False
        ' 
        ' Calculator
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(567, 381)
        Controls.Add(btnequal)
        Controls.Add(btnclear)
        Controls.Add(btndelete)
        Controls.Add(btnmultiply)
        Controls.Add(btndivide)
        Controls.Add(btnplus)
        Controls.Add(btnminus)
        Controls.Add(btn4)
        Controls.Add(btn5)
        Controls.Add(btn6)
        Controls.Add(btn7)
        Controls.Add(btn8)
        Controls.Add(btn9)
        Controls.Add(btn1)
        Controls.Add(btn2)
        Controls.Add(btn3)
        Controls.Add(btn00)
        Controls.Add(btn0)
        Controls.Add(btnpt)
        Controls.Add(result)
        Cursor = Cursors.Hand
        Name = "Calculator"
        StartPosition = FormStartPosition.Manual
        Text = "Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents result As TextBox
    Friend WithEvents btnpt As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btn00 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btnplus As Button
    Friend WithEvents btnminus As Button
    Friend WithEvents btnmultiply As Button
    Friend WithEvents btndivide As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnequal As Button

End Class
