Public Class resultForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub resultForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Form1.resetTest()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim filedialog As New SaveFileDialog With {
            .Title = "저장할 위치를 지정해 주세요",
            .Filter = "텍스트 파일|*.txt",
            .InitialDirectory = My.Application.Info.DirectoryPath
        }

        If filedialog.ShowDialog = DialogResult.OK Then

            Dim savedata As String = Nothing

            For Each i In ListBox1.Items
                savedata += i.ToString + vbCr
            Next

            My.Computer.FileSystem.WriteAllText(filedialog.FileName, savedata, False, System.Text.Encoding.GetEncoding(949))
            MsgBox("저장이 완료 되었습니다", vbInformation)

        End If
    End Sub

    Private Sub resultForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class