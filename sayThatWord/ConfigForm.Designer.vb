<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfigForm
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfigForm))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ShowCharChk = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Num2 = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Num1 = New System.Windows.Forms.NumericUpDown()
        Me.RangeChk = New System.Windows.Forms.CheckBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ReverseChk = New System.Windows.Forms.CheckBox()
        Me.UnicodeChk = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        CType(Me.Num2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Num1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(264, 210)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 37)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "시작하기"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(222, 44)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(146, 25)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "다른 단어장 불러오기..."
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("맑은 고딕", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("맑은 고딕", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "단어장 파일"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.UnicodeChk)
        Me.Panel1.Controls.Add(Me.ShowCharChk)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Num2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Num1)
        Me.Panel1.Controls.Add(Me.RangeChk)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.ReverseChk)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(20)
        Me.Panel1.Size = New System.Drawing.Size(391, 205)
        Me.Panel1.TabIndex = 7
        '
        'ShowCharChk
        '
        Me.ShowCharChk.AutoSize = True
        Me.ShowCharChk.Location = New System.Drawing.Point(23, 172)
        Me.ShowCharChk.Name = "ShowCharChk"
        Me.ShowCharChk.Size = New System.Drawing.Size(237, 19)
        Me.ShowCharChk.TabIndex = 18
        Me.ShowCharChk.Text = "힌트에서 문장 기호(-,~,( ) 등) 보여주기"
        Me.ShowCharChk.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(23, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 23)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "첫째 열-질문 / 둘째 열-답"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(335, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 15)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "까지"
        '
        'Num2
        '
        Me.Num2.Location = New System.Drawing.Point(283, 137)
        Me.Num2.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.Num2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Num2.Name = "Num2"
        Me.Num2.Size = New System.Drawing.Size(50, 23)
        Me.Num2.TabIndex = 15
        Me.Num2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(249, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "부터"
        '
        'Num1
        '
        Me.Num1.Location = New System.Drawing.Point(197, 137)
        Me.Num1.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.Num1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Num1.Name = "Num1"
        Me.Num1.Size = New System.Drawing.Size(50, 23)
        Me.Num1.TabIndex = 13
        Me.Num1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'RangeChk
        '
        Me.RangeChk.AutoSize = True
        Me.RangeChk.Location = New System.Drawing.Point(197, 112)
        Me.RangeChk.Name = "RangeChk"
        Me.RangeChk.Size = New System.Drawing.Size(78, 19)
        Me.RangeChk.TabIndex = 12
        Me.RangeChk.Text = "범위 설정"
        Me.RangeChk.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(23, 102)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(345, 1)
        Me.Panel3.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("맑은 고딕", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 19)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "세부 설정"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(23, 38)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(345, 1)
        Me.Panel2.TabIndex = 9
        '
        'ReverseChk
        '
        Me.ReverseChk.AutoSize = True
        Me.ReverseChk.Location = New System.Drawing.Point(23, 112)
        Me.ReverseChk.Name = "ReverseChk"
        Me.ReverseChk.Size = New System.Drawing.Size(135, 19)
        Me.ReverseChk.TabIndex = 8
        Me.ReverseChk.Text = "질문-정답 순서 반전"
        Me.ReverseChk.UseVisualStyleBackColor = True
        '
        'UnicodeChk
        '
        Me.UnicodeChk.Font = New System.Drawing.Font("맑은 고딕", 7.0!)
        Me.UnicodeChk.Location = New System.Drawing.Point(268, 166)
        Me.UnicodeChk.Name = "UnicodeChk"
        Me.UnicodeChk.Size = New System.Drawing.Size(100, 30)
        Me.UnicodeChk.TabIndex = 19
        Me.UnicodeChk.Text = "UTF-8 인코딩" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(깨질시 체크)"
        Me.UnicodeChk.UseVisualStyleBackColor = True
        '
        'ConfigForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(391, 258)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ConfigForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "시험 설정"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Num2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Num1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ReverseChk As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Num2 As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Num1 As NumericUpDown
    Friend WithEvents RangeChk As CheckBox
    Friend WithEvents ShowCharChk As CheckBox
    Friend WithEvents UnicodeChk As CheckBox
End Class
