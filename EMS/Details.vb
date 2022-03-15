Imports MySql.Data.MySqlClient
Public Class Details
    'Establish Connection to Database
    Dim Con As New MySqlConnection("host=127.0.0.1; user=root; database=employeedb")

    'Load Module
    Private Sub Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Search Button
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        FetchEmployeeData()
    End Sub

    'Reset Button
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ResetForm()
        VisFalse()
    End Sub

    'Home Button
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Hide()
        Dim mainForm = New MainForm
        mainForm.Show()
    End Sub

    'Print Button
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("This feature is currently unavailable")
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
                    EmpAddressLbl.Text = dr(2).ToString()
                    EmpGenderLbl.Text = dr(3).ToString()
                    EmpContactLbl.Text = dr(4).ToString()
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
        EmpNameLbl.Text = "Name"
        EmpAddressLbl.Text = "Address"
        EmpGenderLbl.Text = "Gender"
        EmpContactLbl.Text = "Contact"
        EmpPosLbl.Text = "Position"
        EmpDepLbl.Text = "Department"
    End Sub

    'Label Visibile: True
    Private Sub VisTrue()
        EmpNameLbl.Visible = True
        EmpAddressLbl.Visible = True
        EmpGenderLbl.Visible = True
        EmpContactLbl.Visible = True
        EmpPosLbl.Visible = True
        EmpDepLbl.Visible = True

    End Sub

    'Label Visible False
    Private Sub VisFalse()
        EmpNameLbl.Visible = False
        EmpAddressLbl.Visible = False
        EmpGenderLbl.Visible = False
        EmpContactLbl.Visible = False
        EmpPosLbl.Visible = False
        EmpDepLbl.Visible = False

    End Sub

    'Exit Application
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Application.Exit()
    End Sub
End Class