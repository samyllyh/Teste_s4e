Imports System.Data.SqlClient

Public Class Form1
    Private connection As SqlConnection
    Private command As SqlCommand
    Private da As SqlDataAdapter
    Private dr As SqlDataReader

    Private strSQL As String

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Try
            connection = New SqlConnection("Data Source=DESKTOP-TRVTAH5\SQLEXPRESS;Initial Catalog=S4E;Integrated Security=True")

            strSQL = "INSERT INTO associados (Nome,CPF,DataNascimento) VALUES (@NOME, @Cpf, @DATANASCIMENTO)"

            command = New SqlCommand(strSQL, connection)
            command.Parameters.AddWithValue("@NOME", txtNome.Text)
            command.Parameters.AddWithValue("@CPF", txtCPF.Text)
            command.Parameters.AddWithValue("@DATANASCIMENTO", DateTimePicker1.Text)
            connection.Open()
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
            command.Clone()
            connection = Nothing
            command = Nothing
        End Try
    End Sub

    Private Sub BtnExibir_Click(sender As Object, e As EventArgs) Handles BtnExibir.Click
        Try
            connection = New SqlConnection("Data Source=DESKTOP-TRVTAH5\SQLEXPRESS;Initial Catalog=S4E;Integrated Security=True")

            strSQL = "SELECT * FROM associados"

            command = New SqlCommand(strSQL, connection)
            da = New SqlDataAdapter(strSQL, connection)
            connection.Open()
            Dim ds As New DataSet
            da.Fill(ds)

            DataGridView1.DataSource = ds.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
            command.Clone()
            connection = Nothing
            command = Nothing
        End Try
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Try
            connection = New SqlConnection("Data Source=DESKTOP-TRVTAH5\SQLEXPRESS;Initial Catalog=S4E;Integrated Security=True")

            strSQL = "SELECT * FROM associados WHERE Id_associado = @ID"

            command = New SqlCommand(strSQL, connection)
            command.Parameters.AddWithValue("@Id", txtId.Text)
            connection.Open()

            dr = command.ExecuteReader
            Do While dr.Read
                txtNome.Text = dr("Nome")
                txtCPF.Text = dr("CPF")
                lebal6.Text = dr("DataNascimento")
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
            command.Clone()
            connection = Nothing
            command = Nothing
            dr = Nothing
        End Try
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Try
            connection = New SqlConnection("Data Source=DESKTOP-TRVTAH5\SQLEXPRESS;Initial Catalog=S4E;Integrated Security=True")

            strSQL = "UPDATE associados SET NOME = @NOME, CPF = @CPF, DATANASCIMENTO = @DATANASCIMENTO WHERE Id_associado = @ID"

            command = New SqlCommand(strSQL, connection)
            command.Parameters.AddWithValue("@Id", txtId.Text)
            command.Parameters.AddWithValue("@NOME", txtNome.Text)
            command.Parameters.AddWithValue("@CPF", txtCpf.Text)
            command.Parameters.AddWithValue("@DATANASCIMENTO", lebal6.Text)

            connection.Open()
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
            command.Clone()
            connection = Nothing
            command = Nothing
        End Try
    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Try
            connection = New SqlConnection("Data Source=DESKTOP-TRVTAH5\SQLEXPRESS;Initial Catalog=S4E;Integrated Security=True")

            strSQL = "DELETE associados WHERE Id_associado = @ID"

            command = New SqlCommand(strSQL, connection)
            command.Parameters.AddWithValue("@ID", txtId.Text)

            connection.Open()
            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
            command.Clone()
            connection = Nothing
            command = Nothing
        End Try
    End Sub
End Class