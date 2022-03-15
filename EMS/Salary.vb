Imports MySql.Data.MySqlClient
Public Class Salary
    Dim Con As New MySqlConnection("host=127.0.0.1; user=root; database=employeedb")
    'Load Module
    Private Sub Salary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VisFalse()
    End Sub
    'Search Button
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        FetchEmployeeData()
        VisTrue()
    End Sub

    'Home Button
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Dim mainForm = New MainForm
        mainForm.Show()
    End Sub

    'View Button: For Viewing Salary!!
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If EmpPosLbl.Text = "" Then
            MsgBox("Select an Employee")
        ElseIf WorkedTb.Text = "" Or Convert.ToInt32(WorkedTb.Text) > 28 Then
            MsgBox("Enter a valid number of days! [ 1-28 ]")
        Else
            Calculate()
        End If
    End Sub

    'Print Button
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("This feature is currently unavailable")
    End Sub

    'Clear Button
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ResetForm()
        VisFalse()
    End Sub

    'Methods
    Private Sub FetchEmployeeData()
        If EmpIdTb.Text = "" Then
            MsgBox("Employee id required!")
        Else
            Try
                Con.Open()
                Dim Query = "select * from employee where id = " & EmpIdTb.Text & " "
                Dim cmd As MySqlCommand
                cmd = New MySqlCommand(Query, Con)
                Dim dt As DataTable
                dt = New DataTable
                Dim sda As MySqlDataAdapter
                sda = New MySqlDataAdapter(cmd)
                sda.Fill(dt)
                For Each dr As DataRow In dt.Rows
                    EmpNameLbl.Text = dr(1).ToString()
                    EmpPosLbl.Text = dr(5).ToString()
                    EmpDepLbl.Text = dr(6).ToString()

                    'Make Label Visible
                    VisTrue()
                Next
                Con.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    'Reset Form
    Private Sub ResetForm()
        EmpIdTb.Text = ""
        EmpNameLbl.Text = ""
        EmpPosLbl.Text = ""
        EmpDepLbl.Text = ""
        WorkedTb.Text = ""
        SalaryTb.Text = ""
    End Sub

    'Label Visibile: True
    Private Sub VisTrue()
        EmpNameLbl.Visible = True
        EmpPosLbl.Visible = True
        EmpDepLbl.Visible = True

    End Sub

    'Label Visible False
    Private Sub VisFalse()
        EmpNameLbl.Visible = False
        EmpPosLbl.Visible = False
        EmpDepLbl.Visible = False

    End Sub

    'Calculate Salary
    Dim DailyPay
    Dim total
    Private Sub Calculate()
        If EmpPosLbl.Text = "Project Manager" Then
            DailyPay = 120
        ElseIf EmpPosLbl.Text = "Hiring Manager" Then
            DailyPay = 120
        ElseIf EmpPosLbl.Text = "Tech Lead" Then
            DailyPay = 110
        ElseIf EmpPosLbl.Text = "Junior Assistant" Then
            DailyPay = 60
        ElseIf EmpPosLbl.Text = "Junior Developer" Then
            DailyPay = 65
        ElseIf EmpPosLbl.Text = "Senior Developer" Then
            DailyPay = 100
        ElseIf EmpPosLbl.Text = "Creative Director" Then
            DailyPay = 110
        ElseIf EmpPosLbl.Text = "Graphic Designer" Then
            DailyPay = 65
        ElseIf EmpPosLbl.Text = "Film Editor" Then
            DailyPay = 70
        ElseIf EmpPosLbl.Text = "Logo Designer" Then
            DailyPay = 65
        ElseIf EmpPosLbl.Text = "Animator" Then
            DailyPay = 80
        ElseIf EmpPosLbl.Text = "Advertising Specialist" Then
            DailyPay = 95
        ElseIf EmpPosLbl.Text = "Security Chief" Then
            DailyPay = 85
        ElseIf EmpPosLbl.Text = "Security Guard" Then
            DailyPay = 65
        ElseIf EmpPosLbl.Text = "Head Chef" Then
            DailyPay = 90
        ElseIf EmpPosLbl.Text = "Sous Chef" Then
            DailyPay = 70
        ElseIf EmpPosLbl.Text = "Server" Then
            DailyPay = 30
        ElseIf EmpPosLbl.Text = "Janitor" Then
            DailyPay = 25
        End If

        Try
            'Calculate
            total = DailyPay * Convert.ToInt32(WorkedTb.Text)
            SalaryTb.Text = "Employee ID:   " + EmpIdTb.Text + vbCrLf + "Employee Name:   " + EmpNameLbl.Text + vbCrLf + "Position:   " + EmpPosLbl.Text + vbCrLf + "Department:   " + EmpDepLbl.Text + vbCrLf + "Days Worked:   " + WorkedTb.Text + vbCrLf + "Daily Pay:   " + Convert.ToString(DailyPay) + vbCrLf + "Total Amount:   " + "$" + Convert.ToString(total)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Exit Application
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("Employee Management System", New Font("Century gothic", 25), Brushes.SkyBlue, 180, 40)
        e.Graphics.DrawString("***Confidential Information***", New Font("Arial", 20), Brushes.Crimson, 200, 100)
        e.Graphics.DrawString(("Employee ID:   " + EmpIdTb.Text + vbCrLf + "Employee Name: " + EmpNameLbl.Text + vbCrLf + "Employee Position: " + EmpPosLbl.Text + vbCrLf + "Department:   " + EmpDepLbl.Text + vbCrLf + "Days Worked:   " + WorkedTb.Text + vbCrLf + "Daily Pay:   " + Convert.ToString(DailyPay) + vbCrLf + "Total Amount:   " + "$" + Convert.ToString(total)), New Font("Arial", 20), Brushes.Black, 150, 190)

        e.Graphics.DrawString("------------END------------", New Font("Century gothic", 15), Brushes.SkyBlue, 150, 500)
    End Sub
End Class