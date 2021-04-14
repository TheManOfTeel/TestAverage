Public Class Form1
    'declare yourexam 1 and 2 here
    'as class level vars
    'declare random obj here too

    Dim exam1, exam2 As Integer
    Dim rand As New Random

    Private Sub txtExam1_TextChanged(sender As Object, e As EventArgs) Handles txtExam1.TextChanged
        'generate a random exam1 score between 60 and 100
        exam1 = rand.Next(60, 100)
        exam2 = rand.Next(80, 100)
        'write exam1 on txtExam1
        txtExam1.Text = CStr(exam1)
        txtExam2.Text = CStr(exam2)
        'write the total on lblOutput
        lblOutout.Text = "The total is " & (exam1 + exam2).ToString


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim average As Double
        average = (exam1 + exam2) / 2
        MessageBox.Show("The average is " & average.ToString)
    End Sub
End Class
