<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGhtlag
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.labCnt = New System.Windows.Forms.Label
        Me.txtCnt = New System.Windows.Forms.TextBox
        Me.txtTil = New System.Windows.Forms.TextBox
        Me.labTil = New System.Windows.Forms.Label
        Me.txtRes = New System.Windows.Forms.TextBox
        Me.labRes = New System.Windows.Forms.Label
        Me.btnOutput = New System.Windows.Forms.Button
        Me.labCvp = New System.Windows.Forms.Label
        Me.txtCvp = New System.Windows.Forms.TextBox
        Me.labDict = New System.Windows.Forms.Label
        Me.cmbDict = New System.Windows.Forms.ComboBox
        Me.btnExit = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'labCnt
        '
        Me.labCnt.AutoSize = True
        Me.labCnt.Location = New System.Drawing.Point(12, 9)
        Me.labCnt.Name = "labCnt"
        Me.labCnt.Size = New System.Drawing.Size(72, 12)
        Me.labCnt.TabIndex = 0
        Me.labCnt.Text = "參與人數(&C):"
        '
        'txtCnt
        '
        Me.txtCnt.Location = New System.Drawing.Point(90, 6)
        Me.txtCnt.Name = "txtCnt"
        Me.txtCnt.Size = New System.Drawing.Size(100, 22)
        Me.txtCnt.TabIndex = 1
        Me.txtCnt.Text = "2"
        '
        'txtTil
        '
        Me.txtTil.Location = New System.Drawing.Point(249, 6)
        Me.txtTil.Name = "txtTil"
        Me.txtTil.Size = New System.Drawing.Size(100, 22)
        Me.txtTil.TabIndex = 2
        Me.txtTil.Text = "1"
        '
        'labTil
        '
        Me.labTil.AutoSize = True
        Me.labTil.Location = New System.Drawing.Point(196, 9)
        Me.labTil.Name = "labTil"
        Me.labTil.Size = New System.Drawing.Size(47, 12)
        Me.labTil.TabIndex = 3
        Me.labTil.Text = "階數(&T):"
        '
        'txtRes
        '
        Me.txtRes.Location = New System.Drawing.Point(12, 63)
        Me.txtRes.MaxLength = 1073741824
        Me.txtRes.Multiline = True
        Me.txtRes.Name = "txtRes"
        Me.txtRes.ReadOnly = True
        Me.txtRes.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtRes.Size = New System.Drawing.Size(770, 493)
        Me.txtRes.TabIndex = 4
        Me.txtRes.WordWrap = False
        '
        'labRes
        '
        Me.labRes.AutoSize = True
        Me.labRes.Location = New System.Drawing.Point(12, 39)
        Me.labRes.Name = "labRes"
        Me.labRes.Size = New System.Drawing.Size(48, 12)
        Me.labRes.TabIndex = 5
        Me.labRes.Text = "結果(&R):"
        '
        'btnOutput
        '
        Me.btnOutput.Location = New System.Drawing.Point(591, 34)
        Me.btnOutput.Name = "btnOutput"
        Me.btnOutput.Size = New System.Drawing.Size(75, 23)
        Me.btnOutput.TabIndex = 6
        Me.btnOutput.Text = "輸出(&E)"
        Me.btnOutput.UseVisualStyleBackColor = True
        '
        'labCvp
        '
        Me.labCvp.AutoSize = True
        Me.labCvp.Location = New System.Drawing.Point(355, 9)
        Me.labCvp.Name = "labCvp"
        Me.labCvp.Size = New System.Drawing.Size(70, 12)
        Me.labCvp.TabIndex = 8
        Me.labCvp.Text = "轉彎機率(&P):"
        '
        'txtCvp
        '
        Me.txtCvp.Location = New System.Drawing.Point(431, 6)
        Me.txtCvp.Name = "txtCvp"
        Me.txtCvp.Size = New System.Drawing.Size(100, 22)
        Me.txtCvp.TabIndex = 7
        Me.txtCvp.Text = "0"
        '
        'labDict
        '
        Me.labDict.AutoSize = True
        Me.labDict.Location = New System.Drawing.Point(537, 9)
        Me.labDict.Name = "labDict"
        Me.labDict.Size = New System.Drawing.Size(48, 12)
        Me.labDict.TabIndex = 9
        Me.labDict.Text = "方向(&D):"
        '
        'cmbDict
        '
        Me.cmbDict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDict.FormattingEnabled = True
        Me.cmbDict.Items.AddRange(New Object() {"上下", "左右"})
        Me.cmbDict.Location = New System.Drawing.Point(591, 6)
        Me.cmbDict.Name = "cmbDict"
        Me.cmbDict.Size = New System.Drawing.Size(121, 20)
        Me.cmbDict.TabIndex = 10
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(672, 34)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "結束(&X)"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmGhtlag
        '
        Me.AcceptButton = Me.btnOutput
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(794, 568)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.cmbDict)
        Me.Controls.Add(Me.labDict)
        Me.Controls.Add(Me.labCvp)
        Me.Controls.Add(Me.txtCvp)
        Me.Controls.Add(Me.btnOutput)
        Me.Controls.Add(Me.labRes)
        Me.Controls.Add(Me.txtRes)
        Me.Controls.Add(Me.labTil)
        Me.Controls.Add(Me.txtTil)
        Me.Controls.Add(Me.txtCnt)
        Me.Controls.Add(Me.labCnt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGhtlag"
        Me.Text = "鬼腳圖"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labCnt As System.Windows.Forms.Label
    Friend WithEvents txtCnt As System.Windows.Forms.TextBox
    Friend WithEvents txtTil As System.Windows.Forms.TextBox
    Friend WithEvents labTil As System.Windows.Forms.Label
    Friend WithEvents txtRes As System.Windows.Forms.TextBox
    Friend WithEvents labRes As System.Windows.Forms.Label
    Friend WithEvents btnOutput As System.Windows.Forms.Button
    Friend WithEvents labCvp As System.Windows.Forms.Label
    Friend WithEvents txtCvp As System.Windows.Forms.TextBox
    Friend WithEvents labDict As System.Windows.Forms.Label
    Friend WithEvents cmbDict As System.Windows.Forms.ComboBox
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
