Imports System.IO
Imports System.Text

Public Class Form1
    Public readDB As String = Nothing
    Public readLoc As String = Nothing
    Public readUTF As Boolean = False
    Dim wordDB As New List(Of String)
    Public wordIndex As Integer = 0
    Dim wordLoc As String = My.Application.Info.DirectoryPath + "\words.txt"
    Public wordDBName As String = Nothing

    Public wrongIndex As New List(Of Integer)
    Dim nowWord As String = Nothing '현재의 단어(질문)
    Dim nowAnswer As String = Nothing '현재의 정답

    Dim loaded As Boolean = False
    Dim loc As Point

    Public testActive As Boolean = False

    Public range(1) As Integer
    Public reverse As Boolean = False

    Dim mode As String = "test"
    Public showChar As Boolean = True
    Dim allowedChar() As String = {",", ".", "/", "&", "-", "_", "[", "]", "(", ")", "!", "~", "'", "<", ">", "{", "}", "\", "`", "*"}

#Region "Aero 그림자 효과 (Vista이상)"

    Protected Overrides Sub OnHandleCreated(e As EventArgs)
        CreateDropShadow(Me)
        MyBase.OnHandleCreated(e)
    End Sub

#End Region

#Region "페이드 효과" 'Load시 Opacity=0 꼭하기

    Private Sub FadeInEffect(sender As Object, e As EventArgs) Handles MyBase.Shown
        Refresh()
        FadeIn(Me, 1)
        Disabled()
        'locateWord()
    End Sub

    Private Sub FadeOutEffect(sender As Object, e As EventArgs) Handles MyBase.Closing
        FadeOut(Me)
    End Sub
#End Region

    Private Sub FormDrag_MouseDown(sender As Object, e As MouseEventArgs) Handles TopPanel.MouseDown,
        BottomPanel.MouseDown, FormTitle.MouseDown, MainPanel.MouseDown, WordLabel.MouseDown, ControlPanel.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            loc = e.Location
        End If
    End Sub

    Private Sub FormDrag_MouseMove(sender As Object, e As MouseEventArgs) Handles TopPanel.MouseMove,
        BottomPanel.MouseMove, FormTitle.MouseMove, MainPanel.MouseMove, WordLabel.MouseMove, ControlPanel.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location += e.Location - loc
        End If
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        range(0) = -1
        Opacity = 0
        TBPanel.Height = TextBox1.Height + dpicalc(Me, 2)
        modeDrawer()
    End Sub

    '시험 다 치고 다시 칠때
    Sub continueTest()
        resetTest(False)
        ConfigForm.Dispose()
        ConfigForm.ShowDialog(Me)
    End Sub

    '시험 초기화
    Sub resetTest(loadword As Boolean) '초기화 후 단어 부르기/안부르기

        wordIndex = 0
        wrongIndex.Clear()
        TextBox1.Text = Nothing

        If loadword Then
            loadWordDB(readDB)
            showWord()
        End If

    End Sub

    Sub modeDrawer()
        Select Case mode
            Case "test"
                PracModeBT.BackColor = Color.Transparent
                PracModeBT.ForeColor = Color.Gray
                PracModeBTB.BackColor = Color.Transparent
                TestModeBT.BackColor = Color.White
                TestModeBT.ForeColor = Color.Black
                TestModeBTB.BackColor = Color.FromArgb(69, 69, 69)
            Case "prac"
                PracModeBT.BackColor = Color.White
                PracModeBT.ForeColor = Color.Black
                PracModeBTB.BackColor = Color.FromArgb(69, 69, 69)
                TestModeBT.BackColor = Color.Transparent
                TestModeBT.ForeColor = Color.Gray
                TestModeBTB.BackColor = Color.Transparent
        End Select
    End Sub

    Sub locateWord()

        Dim ignoreTask As Boolean = False

        Dim filedialog As New OpenFileDialog With {
            .Title = "단어장 텍스트 파일을 선택해 주세요",
            .Filter = "텍스트,tsv 파일|*.txt;*.tsv",
            .InitialDirectory = My.Application.Info.DirectoryPath
        }

        If filedialog.ShowDialog = DialogResult.OK Then

            readLoc = filedialog.FileName

            If My.Computer.FileSystem.FileExists(readLoc) Then

                '용량 1메가 넘을때
                If My.Computer.FileSystem.GetFileInfo(readLoc).Length > 1000000 Then
                    If MsgBox("읽으려는 파일의 용량이 큽니다. 계속하시겠습니까?", vbExclamation + vbYesNo) = vbNo Then
                        ignoreTask = True
                    End If
                End If

                wordDBName = filedialog.SafeFileName.Replace(My.Computer.FileSystem.GetFileInfo(readLoc).Extension, Nothing)

            Else
                MsgBox("선택한 파일이 존재하지 않습니다.", vbCritical)
                ignoreTask = True

            End If

        Else
            ignoreTask = True
        End If

        If Not ignoreTask Then
            '도중안빠져나옴 -> Config 표시
            ConfigForm.Dispose()
            ConfigForm.ShowDialog(Me)

        Else
            Disabled()
        End If

    End Sub

    Sub StartTest()

        loadWordDB(readDB)
    End Sub

    Sub Disabled()
        ResetBT.Visible = False
        WordLabel.Text = "여기를 눌러 단어 파일 열기"
        testActive = False
        TBPanel.Enabled = False
        ControlPanel.Enabled = False
    End Sub

    Sub loadWordDB(db As String)
        Dim errorLv As Boolean = False

        wordDB.Clear()

        For Each word As String In db.Split(vbCr)
            If Not word = Nothing And word.Contains(vbTab) Then wordDB.Add(word)
        Next

        '범위 자르기
        If Not range(0) = -1 Then

            If wordDB.Count < range(1) Then
                If MsgBox("범위를 실제 데이터를 벗어난 것 같습니다." + vbCr + "범위를 무시하시겠습니까?", vbCritical + vbYesNo) = vbYes Then
                    range(0) = -1
                Else
                    errorLv = True
                End If
            Else
                wordDB = wordDB.GetRange(range(0) - 1, range(1) - range(0) + 1)
            End If

        End If

        If wordDB.Count > 0 Then
            If CheckBox1.Checked Then
                wordDB = Shuffle(wordDB)
            End If
        Else
            errorLv = True
            MsgBox("word 데이터를 제대로 불러올 수 없었습니다", vbCritical)
        End If

        If errorLv Then
            Disabled()
            ConfigForm.Dispose()
            ConfigForm.ShowDialog(Me)
        Else
            '여기가 사실 Enabled()임
            ResetBT.Visible = True
            testActive = True
            showWord()
            TBPanel.Enabled = True
            ControlPanel.Enabled = True
        End If

    End Sub

    Function Shuffle(ByVal item As List(Of String)) As List(Of String)
        Dim r As New Random
        Dim exclusive() As Integer = Enumerable.Range(0, item.Count).OrderBy(Function(n) r.Next(item.Count + 1)).ToArray()
        Dim shuffled As List(Of String) = New List(Of String)

        Array.ForEach(exclusive, Sub(e) shuffled.Add(item(e)))

        Return shuffled
    End Function

    Sub showWord()

        Text = "sayThatWord :: 총 " + wordDB.Count.ToString + "중 " + (wordIndex + 1).ToString + "번째 (" + wordDBName + ")"

        Dim tmp1 As String() = Split(wordDB(wordIndex), vbTab)
        tmp1(0) = tmp1(0).Replace(vbLf, "").Replace(vbCr, "")

        '따옴표 제거 작업
        For i = 0 To 1
            If tmp1(i)(0) = """" Then tmp1(i) = tmp1(i).Substring(1)
            If tmp1(i)(tmp1(i).Length - 1) = """" Then tmp1(i) = tmp1(i).Substring(0, tmp1(i).Length - 1)
        Next

        '반전
        If Not reverse Then
            nowWord = tmp1(0)
            nowAnswer = tmp1(1)
        Else
            nowWord = tmp1(1)
            nowAnswer = tmp1(0)
        End If

        WordLabel.ForeColor = Color.Black
        WordLabel.Text = nowWord


        If mode = "prac" Then
            ShowHint()
        End If

    End Sub

    Sub chkAnswer()
        If TextBox1.Text = nowAnswer Then
            If CheckBox2.Checked Then

                CallTTS(nowAnswer, My.Settings.TTSEngine, False)
            End If
            My.Computer.Audio.Play(My.Resources.ok, AudioPlayMode.Background)
            nextWord()
            TBPanel.BackColor = Color.MediumSeaGreen
        Else
            'MsgBox("오답입니다.", vbCritical)
            My.Computer.Audio.Play(My.Resources.oops, AudioPlayMode.Background)
            TextBox1.SelectAll()
            TBPanel.BackColor = Color.Red
        End If
    End Sub

    Sub nextWord()
        If wordIndex >= wordDB.Count - 1 Then
            '시험 끝
            resultForm.Close()

            'MsgBox("시험 완료" + vbCr + "맞은 문제: " + (wordDB.Count - wrongIndex.Count).ToString + vbCr + "틀린 문제: " + wrongIndex.Count.ToString)

            resultForm.resultLabel.Text = "맞은 문제: " _
                + (wordDB.Count - wrongIndex.Count).ToString _
                + " | 틀린 문제: " + wrongIndex.Count.ToString

            For Each i As Integer In wrongIndex
                resultForm.ListBox1.Items.Add(wordDB(i))
            Next

            resultForm.ShowDialog(Me)
        Else
            'MsgBox("정답입니다. 다음 문제로 넘어갑니다", vbInformation)
            wordIndex += 1
            TextBox1.Text = Nothing
            showWord()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        chkAnswer()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        passWord()
    End Sub

    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles CheckBox1.Click
        If wordIndex > 0 Then
            If MsgBox("시험이 초기화됩니다. 변경하시겠습니까?", vbQuestion + vbYesNo) = vbNo Then
                GoTo donothing
            End If
        End If

        CheckBox1.Checked = Not CheckBox1.Checked

        resetTest(True)

donothing:
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ShowHint()
    End Sub

    Sub passWord()
        If MsgBox("정말 패스하시겠습니까? (오답으로 간주됩니다)", vbQuestion + vbYesNo) = vbYes Then
            MsgBox("정답은 '" + nowAnswer + "' 였습니다...")
            wrongIndex.Add(wordIndex)
            nextWord()
        End If
    End Sub

    Sub ShowHint()
        Dim hintText As String = Nothing

        If mode = "prac" Then
            If CheckBox2.Checked Then CallTTS(nowAnswer, My.Settings.TTSEngine, True)
            hintText = nowAnswer
        Else
            For i = 0 To nowAnswer.Length

                If i = 1 Then hintText = nowAnswer(0)
                If i > 1 Then
                    If nowAnswer(i - 1) = " " Then
                        hintText += " "
                    Else
                        Dim matched As Boolean = False

                        If showChar Then
                            For Each str As String In allowedChar
                                If nowAnswer(i - 1) = str Then
                                    hintText += str
                                    matched = True
                                    Exit For
                                End If
                            Next
                        End If

                        If Not matched Then hintText += "?"
                    End If
                End If
            Next
        End If

        WordLabel.Text = hintText
        WordLabel.ForeColor = Color.DodgerBlue

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (e.Control AndAlso (e.KeyCode = Keys.D)) Then
            ShowHint()
        ElseIf e.KeyCode = Keys.Escape Then
            passWord()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TBPanel.BackColor = Color.FromArgb(69, 69, 69)
        WordLabel.ForeColor = Color.Black
        If Not (WordLabel.Text = nowWord) Then WordLabel.Text = nowWord
    End Sub

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter
        TBPanel.BackColor = Color.FromArgb(69, 69, 69)
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        TBPanel.BackColor = Color.Gray
    End Sub

    Private Sub ResizePanel_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ResizePanel.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Size = New Size(Me.PointToClient(MousePosition).X, Me.PointToClient(MousePosition).Y)
        End If
    End Sub

    Private Sub Form1_TextChanged(sender As Object, e As EventArgs) Handles MyBase.TextChanged
        FormTitle.Text = Text
    End Sub

    Private Sub WordLabel_Click(sender As Object, e As EventArgs) Handles WordLabel.Click
        If testActive = False Then
            locateWord()
        End If
    End Sub

    Private Sub Form1_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseWheel
        If My.Computer.Keyboard.CtrlKeyDown Then
            If e.Delta > 0 Then
                WordLabel.Font = New Font(WordLabel.Font.FontFamily, WordLabel.Font.Size + 2)
            Else
                If (WordLabel.Font.Size - 1) > 0 Then WordLabel.Font = New Font(WordLabel.Font.FontFamily, WordLabel.Font.Size - 2)
            End If
        End If
    End Sub

    Private Sub TestModeBT_Click(sender As Object, e As EventArgs) Handles TestModeBT.Click
        If Not mode = "test" Then

            If wordIndex > 0 Then

                If MsgBox("시험이 초기화됩니다. 변경하시겠습니까?", vbQuestion + vbYesNo) = vbNo Then

                    GoTo donothing

                End If

            End If

            mode = "test"
            modeDrawer()
            resetTest(True)

        End If
donothing:
    End Sub

    Private Sub PracModeBT_Click(sender As Object, e As EventArgs) Handles PracModeBT.Click
        If Not mode = "prac" Then

            If wordIndex > 0 Then

                If MsgBox("시험이 초기화됩니다. 변경하시겠습니까?", vbQuestion + vbYesNo) = vbNo Then

                    GoTo donothing

                End If

            End If

            mode = "prac"
            modeDrawer()
            resetTest(True)

        End If
donothing:
    End Sub

    Private Sub ResetBT_Click(sender As Object, e As EventArgs) Handles ResetBT.Click
        If MsgBox("정말로 시험을 중단하고 초기화하시겠습니까?", vbQuestion + vbYesNo) = vbYes Then
            Disabled()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim infotxt As String = "sayThatWord (세이뎃워드) Beta 1.0v" + vbCr
        infotxt += vbCr + "간단 영단어 퀴즈 프로그램"
        infotxt += vbCr + "제작 PBJSoftware"
        infotxt += vbCr + "이 프로그램에 관한 건의사항이나 문의사항이 있으시다면" _
            + vbCr + "http://blog.pbj.kr 혹은 pdj5096@gmail.com으로 알려주세요." + vbCr
        infotxt += vbCr + "sayThatWord는 탭으로 분리된 텍스트 양식의 단어장을 사용합니다. 엑셀과 같은 스프레드시트에서 저장 옵션을 '*.txt (탭으로 분리)' 혹은 '*.tsv (탭으로 구분된 값)' 으로 저장하신 후 불러오시면 이용이 가능합니다."

        MsgBox(infotxt, vbInformation, "정보")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        TTSOption.Dispose()
        TTSOption.ShowDialog(Me)
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            If My.Settings.TTSEngine = Nothing Then
                MsgBox("TTS 엔진을 설정해 주십시오", vbExclamation)
                CheckBox2.Checked = False
            End If
        End If
    End Sub
End Class
