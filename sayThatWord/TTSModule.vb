Imports System.Speech.Synthesis

Module TTSModule
    Sub CallTTS(text As String, voice As String)
        Dim speaker As New SpeechSynthesizer()
        speaker.Rate = 0
        speaker.Volume = 100

        Try
            speaker.SelectVoice(voice)
            speaker.Speak(text)
        Catch
            MsgBox("지원하는 TTS 엔진이 없거나 TTS 기능이 비활성화 되어 있습니다.", vbExclamation)
        End Try
    End Sub

    Sub showVoices()
        Dim b As New System.Speech.Synthesis.SpeechSynthesizer
        For Each voice As System.Speech.Synthesis.InstalledVoice In b.GetInstalledVoices()
            MsgBox(voice.VoiceInfo.Name)
        Next
    End Sub
End Module
