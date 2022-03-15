Imports MySql.Data.MySqlClient
Public Class Employee
    'Establish Connection to Database
    Dim Con As New MySqlConnection("host=127.0.0.1; user=root; database=employeedb")

    'Populate Table with dataset
    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
    End Sub



    'Connection Open Test
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Con.Open()
            MessageBox.Show("Connected to Database!")
            Con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Connection Close Test
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Con.Close()
            MessageBox.Show("Connection Closed!")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Refresh Button
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Populate()

    End Sub

    'Clear Text
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Clear()

    End Sub

    'Home Button
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Hide()
        Dim mainForm = New MainForm
        mainForm.Show()
    End Sub

    'Add button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If EmpNameTb.Text = "" Or EmpAddressTb.Text = "" Or ContactTb.Text = "" Or GenderCb.Text = "" Or PositionCb.Text = "" Or DepartmentCb.Text = "" Then
            MsgBox("Missing Fields")
        Else
            Try
                Con.Open()
                Dim Query As String
                Query = "insert into employee values('""','" & EmpNameTb.Text & "','" & EmpAddressTb.Text & "','" & GenderCb.SelectedItem.ToString() & "','" & ContactTb.Text & "','" & PositionCb.SelectedItem.ToString() & "','" & DepartmentCb.SelectedItem.ToString() & "')"
                Dim cmd As MySqlCommand
                cmd = New MySqlCommand(Query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Employee Added")
                Con.Close()

                'Populate
                Populate()

                'Clear
                Clear()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    'Delete Button
    Dim key = 0
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If key = 0 Then
            MsgBox("Select a row to delete!")
        Else
            Try
                Con.Open()
                Dim Query As String
                Query = "delete from employee where id = " & key & " "
                Dim cmd As MySqlCommand
                cmd = New MySqlCommand(Query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Employee deleted successfully!")
                Con.Close()

                'Refresh
                Populate()

                'Clear
                Clear()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    'Edit Button
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If EmpNameTb.Text = "" Or EmpAddressTb.Text = "" Or ContactTb.Text = "" Then
            MsgBox("Missing Fields")
        Else
            Try
                Con.Open()
                Dim Query As String
                Query = "update employee set EmpName='" & EmpNameTb.Text & "', EmpAddress='" & EmpAddressTb.Text & "', Gender='" & GenderCb.SelectedItem.ToString() & "', Contact='" & ContactTb.Text & "', Position='" & PositionCb.SelectedItem.ToString() & "', Department='" & DepartmentCb.SelectedItem.ToString() & "' where id = " & key & " "
                Dim cmd As New MySqlCommand(Query, Con)
                cmd.ExecuteNonQuery()
                MsgBox("Updated Successfully")
                Con.Close()

                'Refresh
                Populate()

                'Clear
                Clear()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    'Methods
    'Populate Method
    Private Sub Populate()
        Try
            Con.Open()
            Dim sql = "select * from employee"
            Dim adapter As MySqlDataAdapter
            adapter = New MySqlDataAdapter(sql, Con)
            Dim builder As MySqlCommandBuilder
            builder = New MySqlCommandBuilder(adapter)
            Dim ds As DataSet
            ds = New DataSet
            adapter.Fill(ds)
            EmployeeDGV.DataSource = ds.Tables(0)
            Con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Clear Method
    Private Sub Clear()
        EmpNameTb.Clear()
        EmpAddressTb.Clear()
        GenderCb.SelectedIndex = -1
        ContactTb.Clear()
        PositionCb.SelectedIndex = -1
        DepartmentCb.SelectedIndex = -1
        key = 0
    End Sub

    Private Sub EmployeeDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles EmployeeDGV.CellMouseClick
        Dim row As DataGridViewRow = EmployeeDGV.Rows(e.RowIndex)
        key = Convert.ToInt32(row.Cells(0).Value.ToString())
        EmpNameTb.Text = row.Cells(1).Value.ToString()
        EmpAddressTb.Text = row.Cells(2).Value.ToString()
        GenderCb.SelectedItem = row.Cells(3).Value.ToString()
        ContactTb.Text = row.Cells(4).Value.ToString()
        PositionCb.SelectedItem = row.Cells(5).Value.ToString()
        DepartmentCb.SelectedItem = row.Cells(6).Value.ToString()
    End Sub

    'Exit
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Application.Exit()
    End Sub
End Class