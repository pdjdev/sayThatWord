Public Class TTSOption
    Private Sub TTSOption_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox1.Items.AddRange(getVoices().ToArray)
        ComboBox1.Text = My.Settings.TTSEngine

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        My.Settings.TTSEngine = ComboBox1.Text
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CallTTS("This is a test speech of sayThatWord's TTS Engine Setting.", ComboBox1.Text, False)
    End Sub
End Class