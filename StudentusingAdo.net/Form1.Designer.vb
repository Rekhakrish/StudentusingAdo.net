<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lblstuid = New System.Windows.Forms.Label()
        Me.lblstuname = New System.Windows.Forms.Label()
        Me.Lbldob = New System.Windows.Forms.Label()
        Me.Lblclass = New System.Windows.Forms.Label()
        Me.Lblphno = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Lblsclname = New System.Windows.Forms.Label()
        Me.Lblarea = New System.Windows.Forms.Label()
        Me.TxtstuId = New System.Windows.Forms.TextBox()
        Me.Txtstuname = New System.Windows.Forms.TextBox()
        Me.Txtdob = New System.Windows.Forms.TextBox()
        Me.Txtclass = New System.Windows.Forms.TextBox()
        Me.Txtphno = New System.Windows.Forms.TextBox()
        Me.Txtschoolname = New System.Windows.Forms.TextBox()
        Me.Txtarea = New System.Windows.Forms.TextBox()
        Me.Combostatus = New System.Windows.Forms.ComboBox()
        Me.Btncreate = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(295, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Student Information"
        '
        'Lblstuid
        '
        Me.Lblstuid.AutoSize = True
        Me.Lblstuid.Location = New System.Drawing.Point(38, 61)
        Me.Lblstuid.Name = "Lblstuid"
        Me.Lblstuid.Size = New System.Drawing.Size(61, 15)
        Me.Lblstuid.TabIndex = 1
        Me.Lblstuid.Text = "Student Id"
        '
        'lblstuname
        '
        Me.lblstuname.AutoSize = True
        Me.lblstuname.Location = New System.Drawing.Point(38, 109)
        Me.lblstuname.Name = "lblstuname"
        Me.lblstuname.Size = New System.Drawing.Size(83, 15)
        Me.lblstuname.TabIndex = 2
        Me.lblstuname.Text = "Student Name"
        '
        'Lbldob
        '
        Me.Lbldob.AutoSize = True
        Me.Lbldob.Location = New System.Drawing.Point(38, 163)
        Me.Lbldob.Name = "Lbldob"
        Me.Lbldob.Size = New System.Drawing.Size(73, 15)
        Me.Lbldob.TabIndex = 3
        Me.Lbldob.Text = "Date of Birth"
        '
        'Lblclass
        '
        Me.Lblclass.AutoSize = True
        Me.Lblclass.Location = New System.Drawing.Point(38, 215)
        Me.Lblclass.Name = "Lblclass"
        Me.Lblclass.Size = New System.Drawing.Size(34, 15)
        Me.Lblclass.TabIndex = 4
        Me.Lblclass.Text = "Class"
        '
        'Lblphno
        '
        Me.Lblphno.AutoSize = True
        Me.Lblphno.Location = New System.Drawing.Point(399, 56)
        Me.Lblphno.Name = "Lblphno"
        Me.Lblphno.Size = New System.Drawing.Size(91, 15)
        Me.Lblphno.TabIndex = 5
        Me.Lblphno.Text = "Mobile Number"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(399, 212)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(39, 15)
        Me.lblStatus.TabIndex = 6
        Me.lblStatus.Text = "Status"
        '
        'Lblsclname
        '
        Me.Lblsclname.AutoSize = True
        Me.Lblsclname.Location = New System.Drawing.Point(399, 106)
        Me.Lblsclname.Name = "Lblsclname"
        Me.Lblsclname.Size = New System.Drawing.Size(78, 15)
        Me.Lblsclname.TabIndex = 7
        Me.Lblsclname.Text = "School Name"
        '
        'Lblarea
        '
        Me.Lblarea.AutoSize = True
        Me.Lblarea.Location = New System.Drawing.Point(399, 163)
        Me.Lblarea.Name = "Lblarea"
        Me.Lblarea.Size = New System.Drawing.Size(70, 15)
        Me.Lblarea.TabIndex = 8
        Me.Lblarea.Text = "School Area"
        '
        'TxtstuId
        '
        Me.TxtstuId.Location = New System.Drawing.Point(202, 53)
        Me.TxtstuId.Name = "TxtstuId"
        Me.TxtstuId.Size = New System.Drawing.Size(100, 23)
        Me.TxtstuId.TabIndex = 9
        '
        'Txtstuname
        '
        Me.Txtstuname.Location = New System.Drawing.Point(202, 106)
        Me.Txtstuname.Name = "Txtstuname"
        Me.Txtstuname.Size = New System.Drawing.Size(100, 23)
        Me.Txtstuname.TabIndex = 10
        '
        'Txtdob
        '
        Me.Txtdob.Location = New System.Drawing.Point(202, 163)
        Me.Txtdob.Name = "Txtdob"
        Me.Txtdob.Size = New System.Drawing.Size(100, 23)
        Me.Txtdob.TabIndex = 11
        '
        'Txtclass
        '
        Me.Txtclass.Location = New System.Drawing.Point(202, 212)
        Me.Txtclass.Name = "Txtclass"
        Me.Txtclass.Size = New System.Drawing.Size(100, 23)
        Me.Txtclass.TabIndex = 12
        '
        'Txtphno
        '
        Me.Txtphno.Location = New System.Drawing.Point(552, 53)
        Me.Txtphno.Name = "Txtphno"
        Me.Txtphno.Size = New System.Drawing.Size(100, 23)
        Me.Txtphno.TabIndex = 13
        '
        'Txtschoolname
        '
        Me.Txtschoolname.Location = New System.Drawing.Point(552, 101)
        Me.Txtschoolname.Name = "Txtschoolname"
        Me.Txtschoolname.Size = New System.Drawing.Size(100, 23)
        Me.Txtschoolname.TabIndex = 14
        '
        'Txtarea
        '
        Me.Txtarea.Location = New System.Drawing.Point(552, 155)
        Me.Txtarea.Name = "Txtarea"
        Me.Txtarea.Size = New System.Drawing.Size(100, 23)
        Me.Txtarea.TabIndex = 15
        '
        'Combostatus
        '
        Me.Combostatus.FormattingEnabled = True
        Me.Combostatus.Items.AddRange(New Object() {"Active", "InActive"})
        Me.Combostatus.Location = New System.Drawing.Point(552, 207)
        Me.Combostatus.Name = "Combostatus"
        Me.Combostatus.Size = New System.Drawing.Size(121, 23)
        Me.Combostatus.TabIndex = 16
        '
        'Btncreate
        '
        Me.Btncreate.Location = New System.Drawing.Point(46, 281)
        Me.Btncreate.Name = "Btncreate"
        Me.Btncreate.Size = New System.Drawing.Size(75, 23)
        Me.Btncreate.TabIndex = 17
        Me.Btncreate.Text = "Create"
        Me.Btncreate.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(187, 281)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.BtnUpdate.TabIndex = 18
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(333, 281)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 23)
        Me.BtnDelete.TabIndex = 19
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.Btncreate)
        Me.Controls.Add(Me.Combostatus)
        Me.Controls.Add(Me.Txtarea)
        Me.Controls.Add(Me.Txtschoolname)
        Me.Controls.Add(Me.Txtphno)
        Me.Controls.Add(Me.Txtclass)
        Me.Controls.Add(Me.Txtdob)
        Me.Controls.Add(Me.Txtstuname)
        Me.Controls.Add(Me.TxtstuId)
        Me.Controls.Add(Me.Lblarea)
        Me.Controls.Add(Me.Lblsclname)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Lblphno)
        Me.Controls.Add(Me.Lblclass)
        Me.Controls.Add(Me.Lbldob)
        Me.Controls.Add(Me.lblstuname)
        Me.Controls.Add(Me.Lblstuid)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Student Management System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Lblstuid As Label
    Friend WithEvents lblstuname As Label
    Friend WithEvents Lbldob As Label
    Friend WithEvents Lblclass As Label
    Friend WithEvents Lblphno As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents Lblsclname As Label
    Friend WithEvents Lblarea As Label
    Friend WithEvents TxtstuId As TextBox
    Friend WithEvents Txtstuname As TextBox
    Friend WithEvents Txtdob As TextBox
    Friend WithEvents Txtclass As TextBox
    Friend WithEvents Txtphno As TextBox
    Friend WithEvents Txtschoolname As TextBox
    Friend WithEvents Txtarea As TextBox
    Friend WithEvents Combostatus As ComboBox
    Friend WithEvents Btncreate As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button
End Class
