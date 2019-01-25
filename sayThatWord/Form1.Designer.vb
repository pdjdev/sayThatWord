<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.WordLabel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ControlPanel = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TBPanel = New System.Windows.Forms.Panel()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ResetBT = New System.Windows.Forms.Button()
        Me.FormTitle = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CloseButton = New System.Windows.Forms.Panel()
        Me.BottomPanel = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.PracModeBTB = New System.Windows.Forms.Panel()
        Me.PracModeBT = New System.Windows.Forms.Label()
        Me.TestModeBTB = New System.Windows.Forms.Panel()
        Me.TestModeBT = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ResizePanel = New System.Windows.Forms.Panel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.ControlPanel.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TBPanel.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        Me.TopPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.BottomPanel.SuspendLayout()
        Me.PracModeBTB.SuspendLayout()
        Me.TestModeBTB.SuspendLayout()
        Me.SuspendLayout()
        '
        'WordLabel
        '
        Me.WordLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WordLabel.Font = New System.Drawing.Font("맑은 고딕 Semilight", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.WordLabel.Location = New System.Drawing.Point(30, 0)
        Me.WordLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.WordLabel.Name = "WordLabel"
        Me.WordLabel.Size = New System.Drawing.Size(611, 86)
        Me.WordLabel.TabIndex = 0
        Me.WordLabel.Text = "sayThatWord"
        Me.WordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(103, 9)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 39)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "입력 (Enter)"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Font = New System.Drawing.Font("맑은 고딕", 20.14286!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(611, 36)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(2, 9)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 39)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "통과 (Esc)"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoCheck = False
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(15, 29)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(62, 19)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "무작위"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(110, 9)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(97, 39)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "힌트 (Ctrl + D)"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ControlPanel
        '
        Me.ControlPanel.Controls.Add(Me.Panel5)
        Me.ControlPanel.Controls.Add(Me.Panel4)
        Me.ControlPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ControlPanel.Location = New System.Drawing.Point(30, 133)
        Me.ControlPanel.Name = "ControlPanel"
        Me.ControlPanel.Size = New System.Drawing.Size(611, 58)
        Me.ControlPanel.TabIndex = 6
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.LinkLabel2)
        Me.Panel5.Controls.Add(Me.CheckBox2)
        Me.Panel5.Controls.Add(Me.CheckBox1)
        Me.Panel5.Controls.Add(Me.Button1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(402, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(209, 58)
        Me.Panel5.TabIndex = 8
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(15, 9)
        Me.CheckBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(45, 19)
        Me.CheckBox2.TabIndex = 5
        Me.CheckBox2.Text = "TTS"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Button3)
        Me.Panel4.Controls.Add(Me.Button2)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(240, 58)
        Me.Panel4.TabIndex = 7
        '
        'TBPanel
        '
        Me.TBPanel.BackColor = System.Drawing.Color.Gray
        Me.TBPanel.Controls.Add(Me.TextBox1)
        Me.TBPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TBPanel.Location = New System.Drawing.Point(30, 86)
        Me.TBPanel.Name = "TBPanel"
        Me.TBPanel.Size = New System.Drawing.Size(611, 47)
        Me.TBPanel.TabIndex = 7
        '
        'MainPanel
        '
        Me.MainPanel.BackColor = System.Drawing.Color.White
        Me.MainPanel.Controls.Add(Me.WordLabel)
        Me.MainPanel.Controls.Add(Me.TBPanel)
        Me.MainPanel.Controls.Add(Me.ControlPanel)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(1, 31)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Padding = New System.Windows.Forms.Padding(30, 0, 30, 0)
        Me.MainPanel.Size = New System.Drawing.Size(671, 191)
        Me.MainPanel.TabIndex = 8
        '
        'TopPanel
        '
        Me.TopPanel.BackColor = System.Drawing.Color.White
        Me.TopPanel.Controls.Add(Me.Panel2)
        Me.TopPanel.Controls.Add(Me.FormTitle)
        Me.TopPanel.Controls.Add(Me.Panel1)
        Me.TopPanel.Controls.Add(Me.CloseButton)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(1, 1)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(671, 30)
        Me.TopPanel.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ResetBT)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(30, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel2.Size = New System.Drawing.Size(90, 30)
        Me.Panel2.TabIndex = 14
        '
        'ResetBT
        '
        Me.ResetBT.Dock = System.Windows.Forms.DockStyle.Left
        Me.ResetBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ResetBT.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ResetBT.Location = New System.Drawing.Point(3, 3)
        Me.ResetBT.Name = "ResetBT"
        Me.ResetBT.Size = New System.Drawing.Size(75, 24)
        Me.ResetBT.TabIndex = 13
        Me.ResetBT.Text = "초기화..."
        Me.ResetBT.UseVisualStyleBackColor = True
        '
        'FormTitle
        '
        Me.FormTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormTitle.Font = New System.Drawing.Font("맑은 고딕", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FormTitle.Location = New System.Drawing.Point(30, 0)
        Me.FormTitle.Name = "FormTitle"
        Me.FormTitle.Size = New System.Drawing.Size(611, 30)
        Me.FormTitle.TabIndex = 0
        Me.FormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.sayThatWord.My.Resources.Resources.small_stw_icon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(30, 30)
        Me.Panel1.TabIndex = 12
        '
        'CloseButton
        '
        Me.CloseButton.BackgroundImage = Global.sayThatWord.My.Resources.Resources.bt_close2
        Me.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CloseButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.CloseButton.Location = New System.Drawing.Point(641, 0)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(30, 30)
        Me.CloseButton.TabIndex = 11
        '
        'BottomPanel
        '
        Me.BottomPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BottomPanel.BackgroundImage = Global.sayThatWord.My.Resources.Resources.shadow
        Me.BottomPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BottomPanel.Controls.Add(Me.LinkLabel1)
        Me.BottomPanel.Controls.Add(Me.PracModeBTB)
        Me.BottomPanel.Controls.Add(Me.TestModeBTB)
        Me.BottomPanel.Controls.Add(Me.Label3)
        Me.BottomPanel.Controls.Add(Me.ResizePanel)
        Me.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomPanel.Location = New System.Drawing.Point(1, 222)
        Me.BottomPanel.Name = "BottomPanel"
        Me.BottomPanel.Size = New System.Drawing.Size(671, 32)
        Me.BottomPanel.TabIndex = 9
        '
        'LinkLabel1
        '
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.LinkLabel1.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(573, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.LinkLabel1.Size = New System.Drawing.Size(66, 32)
        Me.LinkLabel1.TabIndex = 16
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "정보..."
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PracModeBTB
        '
        Me.PracModeBTB.BackColor = System.Drawing.Color.Transparent
        Me.PracModeBTB.Controls.Add(Me.PracModeBT)
        Me.PracModeBTB.Dock = System.Windows.Forms.DockStyle.Left
        Me.PracModeBTB.Location = New System.Drawing.Point(179, 0)
        Me.PracModeBTB.Name = "PracModeBTB"
        Me.PracModeBTB.Size = New System.Drawing.Size(110, 32)
        Me.PracModeBTB.TabIndex = 15
        '
        'PracModeBT
        '
        Me.PracModeBT.BackColor = System.Drawing.Color.Transparent
        Me.PracModeBT.Dock = System.Windows.Forms.DockStyle.Top
        Me.PracModeBT.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.PracModeBT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PracModeBT.Location = New System.Drawing.Point(0, 0)
        Me.PracModeBT.Name = "PracModeBT"
        Me.PracModeBT.Size = New System.Drawing.Size(110, 30)
        Me.PracModeBT.TabIndex = 11
        Me.PracModeBT.Text = "연습 모드"
        Me.PracModeBT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TestModeBTB
        '
        Me.TestModeBTB.BackColor = System.Drawing.Color.Transparent
        Me.TestModeBTB.Controls.Add(Me.TestModeBT)
        Me.TestModeBTB.Dock = System.Windows.Forms.DockStyle.Left
        Me.TestModeBTB.Location = New System.Drawing.Point(69, 0)
        Me.TestModeBTB.Name = "TestModeBTB"
        Me.TestModeBTB.Size = New System.Drawing.Size(110, 32)
        Me.TestModeBTB.TabIndex = 14
        '
        'TestModeBT
        '
        Me.TestModeBT.BackColor = System.Drawing.Color.Transparent
        Me.TestModeBT.Dock = System.Windows.Forms.DockStyle.Top
        Me.TestModeBT.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.TestModeBT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TestModeBT.Location = New System.Drawing.Point(0, 0)
        Me.TestModeBT.Name = "TestModeBT"
        Me.TestModeBT.Size = New System.Drawing.Size(110, 30)
        Me.TestModeBT.TabIndex = 11
        Me.TestModeBT.Text = "시험 모드"
        Me.TestModeBT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Label3.Size = New System.Drawing.Size(69, 32)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "모드 설정"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ResizePanel
        '
        Me.ResizePanel.BackColor = System.Drawing.Color.Transparent
        Me.ResizePanel.BackgroundImage = Global.sayThatWord.My.Resources.Resources.edge
        Me.ResizePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ResizePanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.ResizePanel.Location = New System.Drawing.Point(639, 0)
        Me.ResizePanel.Name = "ResizePanel"
        Me.ResizePanel.Size = New System.Drawing.Size(32, 32)
        Me.ResizePanel.TabIndex = 10
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel2.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.LinkLabel2.LinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LinkLabel2.Location = New System.Drawing.Point(57, 10)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(31, 15)
        Me.LinkLabel2.TabIndex = 17
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "설정"
        Me.LinkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Form1
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(673, 255)
        Me.Controls.Add(Me.MainPanel)
        Me.Controls.Add(Me.TopPanel)
        Me.Controls.Add(Me.BottomPanel)
        Me.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(500, 200)
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "sayThatWord"
        Me.ControlPanel.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.TBPanel.ResumeLayout(False)
        Me.TBPanel.PerformLayout()
        Me.MainPanel.ResumeLayout(False)
        Me.TopPanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.BottomPanel.ResumeLayout(False)
        Me.PracModeBTB.ResumeLayout(False)
        Me.TestModeBTB.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WordLabel As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button3 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ControlPanel As Panel
    Friend WithEvents TBPanel As Panel
    Friend WithEvents MainPanel As Panel
    Friend WithEvents BottomPanel As Panel
    Friend WithEvents ResizePanel As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TopPanel As Panel
    Friend WithEvents CloseButton As Panel
    Friend WithEvents FormTitle As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents PracModeBTB As Panel
    Friend WithEvents PracModeBT As Label
    Friend WithEvents TestModeBTB As Panel
    Friend WithEvents TestModeBT As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ResetBT As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
End Class
