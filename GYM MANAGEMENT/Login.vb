
Imports System.Data.OleDb
Public Class Login
    Dim con As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\USER\Documents\PROJECT.mdb")
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            con.Open()
            Dim cmd As New OleDbCommand("SELECT * FROM PROJECT WHERE Username=? AND Password=? AND Role=?", con)
            cmd.Parameters.AddWithValue("?", txtUsername.Text)
            cmd.Parameters.AddWithValue("?", txtPassword.Text)
            cmd.Parameters.AddWithValue("?", cmbRole.Text)

            Dim reader As OleDbDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                MsgBox("Login successful as " & cmbRole.Text)
                General.Show()
                Me.Hide()
            Else
                MsgBox("Invalid login credentials or role.")
            End If
            con.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
            con.Close()
        End Try

    End Sub
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbRole.Items.Clear()
        cmbRole.Items.Add("Admin")
        cmbRole.Items.Add("Staff")
        cmbRole.SelectedIndex = 0 ' Default selection
    End Sub

    Private Sub lblUser_Click(sender As Object, e As EventArgs) Handles lblUser.Click

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub
End Class