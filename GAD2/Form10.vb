Imports System.Data
Imports System.Data.OleDb

Public Class Form10
    Private conn As OleDbConnection
    Private adpt As OleDbDataAdapter
    Private cmd As OleDbCommandBuilder
    Private myds As DataSet

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=C:\Users\Paul\Desktop\Bank\Bank.mdb")
            Dim command As String
            command = "INSERT INTO emp(empnm,dept,sal,mob,mail,empid) VALUES (TextBox1,TextBox2,TextBox3,TextBox4,TextBox5,TextBox6)"
            conn.Open()
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand(command, conn)
            cmd.Parameters.AddWithValue("empnm", TextBox1.Text)
            cmd.Parameters.AddWithValue("dept", TextBox3.Text)
            cmd.Parameters.AddWithValue("sal", TextBox2.Text)
            cmd.Parameters.AddWithValue("mob", TextBox4.Text)
            cmd.Parameters.AddWithValue("mail", TextBox5.Text)
            cmd.Parameters.AddWithValue("empid", TextBox6.Text)
            cmd.ExecuteNonQuery()
        Catch exceptionObject As Exception
            MessageBox.Show(exceptionObject.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        conn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=C:\Users\Paul\Desktop\Bank\Bank.mdb")
        Dim command As String
        command = "Update [emp] set [empnm] = '" & TextBox1.Text & "',[dept] = '" & TextBox2.Text & "'[sal] = '" & TextBox3.Text & "'[mail] = '" & TextBox5.Text & "' Where [mob] = " & TextBox4.Text & " "
        conn.Open()
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(command, conn)
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            TextBox1.Clear()
        Catch exceptionObject As Exception
            MessageBox.Show(exceptionObject.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form11.Show()
    End Sub
End Class
