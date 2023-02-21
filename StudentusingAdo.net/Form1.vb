Imports System.Data.SqlClient
Imports System.Reflection
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim con As SqlConnection = New SqlConnection("Data Source=nlti155\SQLEXPRESS;Initial Catalog=StudentInformation;Integrated Security=True")
    Private Sub Btncreate_Click(sender As Object, e As EventArgs) Handles Btncreate.Click
        Dim stuId As Integer = TxtstuId.Text
        Dim stuName As String = Txtstuname.Text
        Dim studob As Date = Txtdob.Text
        Dim stuclass As Integer = Txtclass.Text
        Dim phno As String = Txtphno.Text
        Dim schlname As String = Txtschoolname.Text
        Dim schlarea As String = Txtarea.Text
        Dim status As String = Combostatus.Text
        con.Open()
        Dim command As New SqlCommand("Insert into Studentdetails(Studentid,Studentname,class,schoolname,SchoolArea,Mobilenumber,dateofBirth,Status)values('" & stuId & "','" & stuName & "','" & stuclass & "','" & schlname & "','" & schlarea & "','" & phno & "','" & studob & "','" & status & "')", con)
        command.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Successfully Inserted")
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim stuId As Integer = TxtstuId.Text
        Dim stuName As String = Txtstuname.Text
        Dim studob As Date = Txtdob.Text
        Dim stuclass As Integer = Txtclass.Text
        Dim phno As String = Txtphno.Text
        Dim schlname As String = Txtschoolname.Text
        Dim schlarea As String = Txtarea.Text
        Dim status As String = Combostatus.Text

        con.Open()
        Dim command As New SqlCommand("update Studentdetails set Studentname ='" & stuName & "',class ='" & stuclass & "',schoolname ='" & schlname & "',SchoolArea ='" & schlarea & "',Mobilenumber ='" & phno & "',dateofBirth='" & studob & "',Status='" & status & "'Where Studentid='" & stuId & "'", con)
        command.ExecuteNonQuery()
        con.Close()
        MessageBox.Show("Successfully Updated")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If MessageBox.Show("Are you sure want to delete", "Deleted Document", MessageBoxButtons.YesNo) = DialogResult.Yes Then

            Dim stuId As Integer = TxtstuId.Text
            ' Dim status As String = Combostatus.Text
            con.Open()
            Dim command As New SqlCommand($"update Studentdetails set Status='InActive'  where Studentid= '{stuId}'  ", con)
            command.ExecuteNonQuery()
            MessageBox.Show("Successfully Deleted")
            con.Close()
        End If
    End Sub
End Class
