Public Class Form1

    Private Sub btnApproach_Click(sender As Object, e As EventArgs) Handles btnApproach.Click
        Dim strName As String = InputBox("What is your name?", "Name")
        Dim strQuest As String = InputBox("What is your quest?", "Quest")
        Dim strRandomQuestionAnswer As String
        Dim intRandomQuestionNumber As Integer

        Dim strSecretName As String = "katreena"
        Dim strSecretQuest As String = "to seek the holy grail"

        Dim strRandomQ1 As String = "What is your favorite color?"
        Dim strRandomQ2 As String = "What is the flight speed of an unladen swallow?"
        Dim strRandomQ3 As String = "What is the capital of Assyria?"
        Dim strRandomQ4 As String = "What does oriflamme mean?"

        Dim strRandomQ1Answer1 As String = "blue"
        Dim strRandomQ1Answer2 As String = "purple"
        Dim strRandomQ2Answer As String = "25 mph"
        Dim strRandomQ3Answer As String = "Nineveh"
        Dim strRandomQ3Answer2 As String = "Assur"
        Dim strRandomQ4Answer As String = "a symbol that inspires devotion or courage"

        Randomize()
        intRandomQuestionNumber = Int((4 - 1 + 1) * Rnd() + 1)

        If intRandomQuestionNumber = 1 Then
            strRandomQuestionAnswer = InputBox(strRandomQ1)
        ElseIf intRandomQuestionNumber = 2 Then
            strRandomQuestionAnswer = InputBox(strRandomQ2)
        ElseIf intRandomQuestionNumber = 3 Then
            strRandomQuestionAnswer = InputBox(strRandomQ3)
        ElseIf intRandomQuestionNumber = 4 Then
            strRandomQuestionAnswer = InputBox(strRandomQ4)
        End If

        If strSecretName = strName And strSecretQuest = strQuest Then
            If intRandomQuestionNumber = 1 And (strRandomQuestionAnswer = strRandomQ1Answer1 Or strRandomQuestionAnswer = strRandomQ1Answer2) Then
                lblFate.Text = "You may cross the bridge."
            ElseIf intRandomQuestionNumber = 2 And strRandomQuestionAnswer = strRandomQ2Answer Then
                lblFate.Text = "You may cross the bridge."
            ElseIf intRandomQuestionNumber = 3 And (strRandomQuestionAnswer = strRandomQ3Answer Or strRandomQuestionAnswer = strRandomQ3Answer2) Then
                lblFate.Text = "You may cross the bridge."
            ElseIf intRandomQuestionNumber = 4 And strRandomQuestionAnswer = strRandomQ4Answer Then
                lblFate.Text = "You may cross the bridge."
            Else
                lblFate.Text = "You will die."
            End If
        Else
            lblFate.Text = "You will die."
        End If





    End Sub
End Class
