Imports System.ComponentModel

Public Class ConfigForm

    Private Sub ConfigForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UnicodeChk.Checked = Form1.readUTF
        ReverseChk.Checked = Form1.reverse
        ShowCharChk.Checked = Form1.showChar

        If Form1.range(0) = -1 Then
            RangeChk.Checked = False
        Else
            RangeChk.Checked = True
            Num1.Value = Form1.range(0)
            Num2.Value = Form1.range(1)
        End If

        Label1.Text = Form1.wordDBName

        Form1.Disabled()
        UpdateSet()
    End Sub

    Private Sub UpdateSet()
        If Not ReverseChk.Checked Then
            Label6.Text = "첫째 열-질문 / 둘째 열-답"
        Else
            Label6.Text = "첫째 열-답 / 둘째 열-질문"
        End If

        Num1.Enabled = RangeChk.Checked
        Num2.Enabled = RangeChk.Checked

    End Sub

    Private Sub ConfigForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'testActive = True
        'loadWordDB(readDB)
        'showWord()
        'TBPanel.Enabled = True
        'ControlPanel.Enabled = True
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RangeChk.Checked And Num2.Value < Num1.Value Then
            MsgBox("올바른 범위를 설정해 주세요.")
            GoTo donothing
        End If

        Form1.reverse = ReverseChk.Checked
        Form1.showChar = ShowCharChk.Checked

        If RangeChk.Checked Then
            With Form1
                .range(0) = Num1.Value
                .range(1) = Num2.Value
            End With
        Else
            Form1.range(0) = -1
        End If

        '파일 불러오기 (중요)
        Try
            If UnicodeChk.Checked Then
                Form1.readDB = My.Computer.FileSystem.ReadAllText(Form1.readLoc, System.Text.Encoding.UTF8)
            Else
                Form1.readDB = My.Computer.FileSystem.ReadAllText(Form1.readLoc, System.Text.Encoding.GetEncoding(949))
            End If

            Form1.readUTF = UnicodeChk.Checked
        Catch ex As Exception
            MsgBox(ex.Message + vbCr + vbCr + "현재 해당 파일을 이미 사용하고 있는지(예: 엑셀 등) 확인해 주십시오.", vbCritical)
            GoTo donothing
        End Try


        Form1.StartTest()
        Me.Close()

donothing:
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Form1.testActive = False Then
            Me.Hide()
            Form1.locateWord()
        End If
    End Sub

    Private Sub OptionChanged(sender As Object, e As EventArgs) Handles ReverseChk.CheckedChanged, RangeChk.CheckedChanged
        UpdateSet()
    End Sub
End Class