<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.EmployeeDGV = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DepartmentCb = New System.Windows.Forms.ComboBox()
        Me.PositionCb = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GenderCb = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ContactTb = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.EmpAddressTb = New System.Windows.Forms.TextBox()
        Me.EmpNameTb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.EmployeeDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Button9)
        Me.Panel1.Controls.Add(Me.EmployeeDGV)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.DepartmentCb)
        Me.Panel1.Controls.Add(Me.PositionCb)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.GenderCb)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.ContactTb)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.EmpAddressTb)
        Me.Panel1.Controls.Add(Me.EmpNameTb)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(0, 98)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1300, 602)
        Me.Panel1.TabIndex = 0
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.LightBlue
        Me.Button9.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(40, 553)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(166, 37)
        Me.Button9.TabIndex = 27
        Me.Button9.Text = "Clear Text"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'EmployeeDGV
        '
        Me.EmployeeDGV.AllowUserToAddRows = False
        Me.EmployeeDGV.AllowUserToDeleteRows = False
        Me.EmployeeDGV.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.EmployeeDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmployeeDGV.GridColor = System.Drawing.Color.Gainsboro
        Me.EmployeeDGV.Location = New System.Drawing.Point(266, 48)
        Me.EmployeeDGV.Name = "EmployeeDGV"
        Me.EmployeeDGV.ReadOnly = True
        Me.EmployeeDGV.RowHeadersWidth = 51
        Me.EmployeeDGV.RowTemplate.Height = 24
        Me.EmployeeDGV.Size = New System.Drawing.Size(1002, 499)
        Me.EmployeeDGV.TabIndex = 21
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightBlue
        Me.Button3.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(817, 553)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(92, 37)
        Me.Button3.TabIndex = 20
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightBlue
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(719, 553)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 37)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Edit"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightBlue
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(621, 553)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 37)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DepartmentCb
        '
        Me.DepartmentCb.FormattingEnabled = True
        Me.DepartmentCb.Items.AddRange(New Object() {"IT", "Quality Assurance", "Human Resource", "Security", "Culinary"})
        Me.DepartmentCb.Location = New System.Drawing.Point(17, 491)
        Me.DepartmentCb.Name = "DepartmentCb"
        Me.DepartmentCb.Size = New System.Drawing.Size(224, 24)
        Me.DepartmentCb.TabIndex = 17
        '
        'PositionCb
        '
        Me.PositionCb.FormattingEnabled = True
        Me.PositionCb.Items.AddRange(New Object() {"Project Manager", "Hiring Manager", "Tech Lead", "Junior Assistant", "Junior Developer", "Senior Developer", "Creative Director", "Graphic Designer", "Film Editor", "Logo Designer", "Animator", "Advertising Specialist", "Security Chief", "Secuirty Guard", "Head Chef", "Sous Chef", "Server", "Janitor"})
        Me.PositionCb.Location = New System.Drawing.Point(16, 408)
        Me.PositionCb.Name = "PositionCb"
        Me.PositionCb.Size = New System.Drawing.Size(224, 24)
        Me.PositionCb.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label7.Location = New System.Drawing.Point(12, 459)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 31)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Department"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label6.Location = New System.Drawing.Point(12, 376)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 31)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Position"
        '
        'GenderCb
        '
        Me.GenderCb.FormattingEnabled = True
        Me.GenderCb.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.GenderCb.Location = New System.Drawing.Point(17, 146)
        Me.GenderCb.Name = "GenderCb"
        Me.GenderCb.Size = New System.Drawing.Size(224, 24)
        Me.GenderCb.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label5.Location = New System.Drawing.Point(12, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 31)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Gender"
        '
        'ContactTb
        '
        Me.ContactTb.Location = New System.Drawing.Point(19, 321)
        Me.ContactTb.Name = "ContactTb"
        Me.ContactTb.Size = New System.Drawing.Size(224, 22)
        Me.ContactTb.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label4.Location = New System.Drawing.Point(14, 289)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 31)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Contact"
        '
        'EmpAddressTb
        '
        Me.EmpAddressTb.Location = New System.Drawing.Point(19, 231)
        Me.EmpAddressTb.Name = "EmpAddressTb"
        Me.EmpAddressTb.Size = New System.Drawing.Size(224, 22)
        Me.EmpAddressTb.TabIndex = 9
        '
        'EmpNameTb
        '
        Me.EmpNameTb.Location = New System.Drawing.Point(17, 59)
        Me.EmpNameTb.Name = "EmpNameTb"
        Me.EmpNameTb.Size = New System.Drawing.Size(227, 22)
        Me.EmpNameTb.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label2.Location = New System.Drawing.Point(14, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 31)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkCyan
        Me.Label3.Location = New System.Drawing.Point(12, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 31)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Employee Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 38)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Manage Employee"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.LightBlue
        Me.Button5.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(607, 40)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(92, 37)
        Me.Button5.TabIndex = 22
        Me.Button5.Text = "Open"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.LightBlue
        Me.Button6.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(705, 40)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(92, 37)
        Me.Button6.TabIndex = 23
        Me.Button6.Text = "Close"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.LightBlue
        Me.Button7.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(803, 40)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(92, 37)
        Me.Button7.TabIndex = 24
        Me.Button7.Text = "Refresh"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(625, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(248, 28)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Connection Test Controls"
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.LightBlue
        Me.Button10.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(1182, 28)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(105, 37)
        Me.Button10.TabIndex = 41
        Me.Button10.Text = "X"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.LightBlue
        Me.Button11.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Location = New System.Drawing.Point(1071, 28)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(105, 37)
        Me.Button11.TabIndex = 42
        Me.Button11.Text = "Home"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.ClientSize = New System.Drawing.Size(1299, 700)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Employee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.EmployeeDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PositionCb As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GenderCb As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ContactTb As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents EmpAddressTb As TextBox
    Friend WithEvents EmpNameTb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DepartmentCb As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents EmployeeDGV As DataGridView
    Friend WithEvents Button7 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
End Class
