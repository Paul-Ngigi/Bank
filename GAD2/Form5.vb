Imports System.Data
Imports System.Data.OleDb

Public Class Form5
    Private conn As OleDbConnection
    Private adpt As OleDbDataAdapter
    Private cmd As OleDbCommandBuilder
    Private myds As DataSet

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=C:\Users\Paul\Desktop\Bank\Bank.mdb")
            Dim command As String
            command = "INSERT INTO customer(Name,DOB,Age,Type_of_account,Nationality,Address,Mobile_Num,Marital_Status,Income,Occupation,Religion) VALUES(nameTextBox,dobTextBox,ageTextBox,accountTypeTextBox,nationalityTextBox,addressTextBox,mobileTextBox,maritalStatTextBox,incomeTextBox,occupationTextBox,religionTextBox)"
            conn.Open()
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand(command, conn)
            cmd.Parameters.AddWithValue("Name", nameTextBox.Text)
            cmd.Parameters.AddWithValue("DOB", dobTextBox.Text)
            cmd.Parameters.AddWithValue("Age", ageTextBox.Text)
            cmd.Parameters.AddWithValue("Type_of_account", accountTypeTextBox.Text)
            cmd.Parameters.AddWithValue("Nationality", nationalityTextBox.Text)
            cmd.Parameters.AddWithValue("Address", addressTextBox.Text)
            cmd.Parameters.AddWithValue("Mobile_Num", mobileTextBox.Text)
            cmd.Parameters.AddWithValue("Marital_Status", maritalStatTextBox.Text)
            cmd.Parameters.AddWithValue("Income", incomeTextBox.Text)
            cmd.Parameters.AddWithValue("Occupation", occupationTextBox.Text)
            cmd.Parameters.AddWithValue("Religion", religionTextBox.Text)
            cmd.ExecuteNonQuery()
            MsgBox("Success")
        Catch exceptionObject As Exception
            MessageBox.Show(exceptionObject.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        conn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=C:\Users\Paul\Desktop\Bank\Bank.mdb")
        Dim command As String
        command = "Update [customer] set [Name] = '" & nameTextBox.Text & "', [DOB] = '" & dobTextBox.Text & "',[Age] = '" & ageTextBox.Text & "',[Type_Of_Account] = '" & accountTypeTextBox.Text & "',[Nationality] = '" & nationalityTextBox.Text & "',[Address] = '" & addressTextBox.Text & "',[Mobile_Num] = '" & mobileTextBox.Text & "',[Marital_Status] = '" & maritalStatTextBox.Text & "',[Income] = '" & incomeTextBox.Text & "',[Occupation] = '" & occupationTextBox.Text & "',[Religion] = '" & religionTextBox.Text & "',[Category] = '" & "',[Mail_ID] = '" & nameTextBox.Text & "'Where [acc_id] = " & accountIdTextBox.Text & " "
        conn.Open()
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(command, conn)
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            nameTextBox.Clear()
        Catch exceptionObject As Exception
            MessageBox.Show(exceptionObject.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim num As Integer
        Randomize()
        num = Int(Rnd() * 500) + 1
        accountIdTextBox.Text = num
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form6.Show()
    End Sub

End Class
