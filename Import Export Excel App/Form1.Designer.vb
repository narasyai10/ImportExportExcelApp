<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        ButtonCreateData = New Button()
        Label1 = New Label()
        TextBoxNumberOfRows = New TextBox()
        ButtonClear = New Button()
        ButtonExportToExcel = New Button()
        ButtonImportFromExcel = New Button()
        DataGridView1 = New DataGridView()
        No = New DataGridViewTextBoxColumn()
        Full_Name = New DataGridViewTextBoxColumn()
        Gender = New DataGridViewTextBoxColumn()
        Phone_Number = New DataGridViewTextBoxColumn()
        City = New DataGridViewTextBoxColumn()
        SaveFileDialog1 = New SaveFileDialog()
        OpenFileDialog1 = New OpenFileDialog()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ButtonCreateData
        ' 
        ButtonCreateData.BackColor = Color.RoyalBlue
        ButtonCreateData.ForeColor = SystemColors.ControlLightLight
        ButtonCreateData.Location = New Point(12, 12)
        ButtonCreateData.Name = "ButtonCreateData"
        ButtonCreateData.Size = New Size(94, 33)
        ButtonCreateData.TabIndex = 0
        ButtonCreateData.Text = "Make Data"
        ButtonCreateData.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(112, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 20)
        Label1.TabIndex = 1
        Label1.Text = "Number Of Rows :"
        ' 
        ' TextBoxNumberOfRows
        ' 
        TextBoxNumberOfRows.Location = New Point(247, 18)
        TextBoxNumberOfRows.Name = "TextBoxNumberOfRows"
        TextBoxNumberOfRows.Size = New Size(68, 27)
        TextBoxNumberOfRows.TabIndex = 2
        TextBoxNumberOfRows.Text = "10"
        ' 
        ' ButtonClear
        ' 
        ButtonClear.BackColor = Color.Red
        ButtonClear.ForeColor = SystemColors.ControlLightLight
        ButtonClear.Location = New Point(321, 12)
        ButtonClear.Name = "ButtonClear"
        ButtonClear.Size = New Size(196, 33)
        ButtonClear.TabIndex = 3
        ButtonClear.Text = "Clear and Default Column"
        ButtonClear.UseVisualStyleBackColor = False
        ' 
        ' ButtonExportToExcel
        ' 
        ButtonExportToExcel.BackColor = Color.ForestGreen
        ButtonExportToExcel.ForeColor = SystemColors.ControlLightLight
        ButtonExportToExcel.Location = New Point(523, 12)
        ButtonExportToExcel.Name = "ButtonExportToExcel"
        ButtonExportToExcel.Size = New Size(136, 33)
        ButtonExportToExcel.TabIndex = 4
        ButtonExportToExcel.Text = "Export To Excel"
        ButtonExportToExcel.UseVisualStyleBackColor = False
        ' 
        ' ButtonImportFromExcel
        ' 
        ButtonImportFromExcel.BackColor = Color.DarkSeaGreen
        ButtonImportFromExcel.ForeColor = SystemColors.ControlLightLight
        ButtonImportFromExcel.Location = New Point(665, 12)
        ButtonImportFromExcel.Name = "ButtonImportFromExcel"
        ButtonImportFromExcel.Size = New Size(155, 33)
        ButtonImportFromExcel.TabIndex = 5
        ButtonImportFromExcel.Text = "Import From Excel"
        ButtonImportFromExcel.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {No, Full_Name, Gender, Phone_Number, City})
        DataGridView1.Location = New Point(15, 51)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(805, 485)
        DataGridView1.TabIndex = 6
        ' 
        ' No
        ' 
        No.HeaderText = "No"
        No.MinimumWidth = 6
        No.Name = "No"
        ' 
        ' Full_Name
        ' 
        Full_Name.HeaderText = "Nama Lengkap"
        Full_Name.MinimumWidth = 6
        Full_Name.Name = "Full_Name"
        ' 
        ' Gender
        ' 
        Gender.HeaderText = "Jenis Kelamin"
        Gender.MinimumWidth = 6
        Gender.Name = "Gender"
        ' 
        ' Phone_Number
        ' 
        Phone_Number.HeaderText = "No. Telp"
        Phone_Number.MinimumWidth = 6
        Phone_Number.Name = "Phone_Number"
        ' 
        ' City
        ' 
        City.HeaderText = "Kota"
        City.MinimumWidth = 6
        City.Name = "City"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(835, 550)
        Controls.Add(DataGridView1)
        Controls.Add(ButtonImportFromExcel)
        Controls.Add(ButtonExportToExcel)
        Controls.Add(ButtonClear)
        Controls.Add(TextBoxNumberOfRows)
        Controls.Add(Label1)
        Controls.Add(ButtonCreateData)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ButtonCreateData As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxNumberOfRows As TextBox
    Friend WithEvents ButtonClear As Button
    Friend WithEvents ButtonExportToExcel As Button
    Friend WithEvents ButtonImportFromExcel As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents Full_Name As DataGridViewTextBoxColumn
    Friend WithEvents Gender As DataGridViewTextBoxColumn
    Friend WithEvents Phone_Number As DataGridViewTextBoxColumn
    Friend WithEvents City As DataGridViewTextBoxColumn

End Class
