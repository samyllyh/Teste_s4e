Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing
Imports System.Diagnostics.Eventing.Reader
Imports Teste_s4e.S4EDataSetTableAdapters

Public Class Form1
    Private connection As SqlConnection
    Private command As SqlCommand
    Private da As SqlDataAdapter
    Private dr As SqlDataReader

    Private strSQL As String


    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

        Try
            connection = New SqlConnection("Data Source=DESKTOP-TRVTAH5\SQLEXPRESS;Initial Catalog=S4E;Integrated Security=True")
            connection.Open()

            strSQL = "SELECT * FROM associados WHERE CPF = @Cpf"
            command = New SqlCommand(strSQL, connection)
            command.Parameters.AddWithValue("@cpf", txtCpf.Text)

            Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

            If (count > 0) Then 'verifica se ja existe um cpf
                MsgBox("Este CPF ja esta cadastrado")
            Else
                strSQL = "INSERT INTO associados (Nome,CPF,DataNascimento) VALUES (@NOME, @Cpf, @DATANASCIMENTO); SELECT SCOPE_IDENTITY();"

                command = New SqlCommand(strSQL, connection)
                command.Parameters.AddWithValue("@NOME", txtNome.Text)
                command.Parameters.AddWithValue("@CPF", txtCpf.Text)
                command.Parameters.AddWithValue("@DATANASCIMENTO", DateTimePicker1.Text)

                Dim IdAsso As Integer = Convert.ToInt32(command.ExecuteScalar())
                command.ExecuteNonQuery()
                RelacionamentoAssociadoEmpresa()


                MessageBox.Show("Adicionado com sucesso!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
            command.Clone()
            connection = Nothing
            command = Nothing
        End Try
    End Sub

    Private Sub RelacionamentoAssociadoEmpresa()
        Try
            connection = New SqlConnection("Data Source=DESKTOP-TRVTAH5\SQLEXPRESS;Initial Catalog=S4E;Integrated Security=True")
            connection.Open()

            Dim empre As String = "SELECT * FROM empresas WHERE CNPJ = @cnpj; SELECT SCOPE_IDENTITY();"
            command = New SqlCommand(empre, connection)
            command.Parameters.AddWithValue("@cnpj", txtCNPJasso.Text)
            Dim IdEmp As Integer = Convert.ToInt32(command.ExecuteScalar())

            Dim asso As String = "SELECT * FROM associados WHERE CPF = @IdAsso"
            command = New SqlCommand(asso, connection)
            command.Parameters.AddWithValue("@IdAsso", txtCpf.Text)
            Dim IdAssociado As Integer = Convert.ToInt32(command.ExecuteScalar())

            Dim relacionamento As String = "INSERT INTO Relacionamento (Id_empre, Id_asso) VALUES (@IdEmp, @IdAssociado)"
            command = New SqlCommand(relacionamento, connection)
            command.Parameters.AddWithValue("@IdEmp", IdEmp)
            command.Parameters.AddWithValue("@IdAssociado", IdAssociado)

            command.ExecuteNonQuery()
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
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
    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click 'consultar associado por Id
        Try
            connection = New SqlConnection("Data Source=DESKTOP-TRVTAH5\SQLEXPRESS;Initial Catalog=S4E;Integrated Security=True")
            connection.Open()

            strSQL = "SELECT * FROM associados WHERE Id_associado = '" & txtId.Text & "'"

            da = New SqlDataAdapter(strSQL, connection)
            Using dr = New DataTable()
                da.Fill(dr)
                DataGridView1.DataSource = dr
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
            connection = Nothing
            command = Nothing
            dr = Nothing
        End Try
    End Sub
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Try
            connection = New SqlConnection("Data Source=DESKTOP-TRVTAH5\SQLEXPRESS;Initial Catalog=S4E;Integrated Security=True")
            connection.Open()

            strSQL = "UPDATE associados SET NOME = @NOME, CPF = @CPF, DATANASCIMENTO = @DATANASCIMENTO WHERE Id_associado = @ID"

            command = New SqlCommand(strSQL, connection)
            command.Parameters.AddWithValue("@Id", txtId.Text)
            command.Parameters.AddWithValue("@NOME", txtNome.Text)
            command.Parameters.AddWithValue("@CPF", txtCpf.Text)
            command.Parameters.AddWithValue("@DATANASCIMENTO", DateTimePicker1.Text)

            command.ExecuteNonQuery()
            MessageBox.Show("Editado com sucesso!")
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
            ExluirRelacionamentoAssociadoEmpresa()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
            command.Clone()
            connection = Nothing
            command = Nothing
        End Try
    End Sub

    Private Sub ExluirRelacionamentoAssociadoEmpresa()
        Try
            connection = New SqlConnection("Data Source=DESKTOP-TRVTAH5\SQLEXPRESS;Initial Catalog=S4E;Integrated Security=True")
            connection.Open()

            strSQL = "DELETE Relacionamento WHERE Id_asso = @Id"

            command = New SqlCommand(strSQL, connection)
            command.Parameters.AddWithValue("@Id", txtId.Text)

            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ExibirEmpresa.Click 'exibir todas as empresas

        Try
            connection = New SqlConnection("Data Source=DESKTOP-TRVTAH5\SQLEXPRESS;Initial Catalog=S4E;Integrated Security=True")

            strSQL = "SELECT * FROM empresas"

            command = New SqlCommand(strSQL, connection)
            da = New SqlDataAdapter(strSQL, connection)
            connection.Open()
            Dim ds As New DataSet
            da.Fill(ds)

            DataGridView2.DataSource = ds.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
            command.Clone()
            connection = Nothing
            command = Nothing
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AddEmp.Click 'adicionar empresa
        Try
            connection = New SqlConnection("Data Source=DESKTOP-TRVTAH5\SQLEXPRESS;Initial Catalog=S4E;Integrated Security=True")
            connection.Open()

            strSQL = "SELECT * FROM empresas WHERE CNPJ = @CNPJ"
            command = New SqlCommand(strSQL, connection)
            command.Parameters.AddWithValue("@CNPJ", txtCnpj.Text)

            Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())

            If (count > 0) Then
                MsgBox("Este CNPJ ja esta cadastrado")
            Else
                strSQL = "INSERT INTO empresas (Nome,CNPJ) VALUES (@NOME, @CNPJ)"

                command = New SqlCommand(strSQL, connection)
                command.Parameters.AddWithValue("@NOME", txtNomeEmp.Text)
                command.Parameters.AddWithValue("@CNPJ", txtCnpj.Text)
                command.ExecuteNonQuery()

                RelacionamentoEmpresaAssociado()
                MessageBox.Show("Adicionado com sucesso!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
            command.Clone()
            connection = Nothing
            command = Nothing
        End Try
    End Sub

    Private Sub RelacionamentoEmpresaAssociado()
        Try
            connection = New SqlConnection("Data Source=DESKTOP-TRVTAH5\SQLEXPRESS;Initial Catalog=S4E;Integrated Security=True")
            connection.Open()

            Dim empre As String = "SELECT * FROM empresas WHERE CNPJ = @cnpj; SELECT SCOPE_IDENTITY();"
            command = New SqlCommand(empre, connection)
            command.Parameters.AddWithValue("@cnpj", txtCnpj.Text)
            Dim IdEmp As Integer = Convert.ToInt32(command.ExecuteScalar())

            Dim asso As String = "SELECT * FROM associados WHERE CPF = @IdAsso"
            command = New SqlCommand(asso, connection)
            command.Parameters.AddWithValue("@IdAsso", txtCpfAssociado.Text)
            Dim IdAssociado As Integer = Convert.ToInt32(command.ExecuteScalar())

            Dim relacionamento As String = "INSERT INTO Relacionamento (Id_empre, Id_asso) VALUES (@IdEmp, @IdAssociado)"
            command = New SqlCommand(relacionamento, connection)
            command.Parameters.AddWithValue("@IdEmp", IdEmp)
            command.Parameters.AddWithValue("@IdAssociado", IdAssociado)

            command.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles EditarEmpresa.Click 'editar empresa
        Try
            connection = New SqlConnection("Data Source=DESKTOP-TRVTAH5\SQLEXPRESS;Initial Catalog=S4E;Integrated Security=True")
            connection.Open()

            strSQL = "UPDATE empresas SET NOME = @NOME, CNPJ = @CNPJ WHERE Id_empresa = @ID"

            command = New SqlCommand(strSQL, connection)
            command.Parameters.AddWithValue("@Id", txtIdEmp.Text)
            command.Parameters.AddWithValue("@NOME", txtNomeEmp.Text)
            command.Parameters.AddWithValue("@CNPJ", txtCnpj.Text)


            command.ExecuteNonQuery()
            MessageBox.Show("Excluido com sucesso!")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
            command.Clone()
            connection = Nothing
            command = Nothing
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ExcluirEmp.Click 'deletar empresa
        Try
            connection = New SqlConnection("Data Source=DESKTOP-TRVTAH5\SQLEXPRESS;Initial Catalog=S4E;Integrated Security=True")

            strSQL = "DELETE empresas WHERE Id_empresa = @ID"

            command = New SqlCommand(strSQL, connection)
            command.Parameters.AddWithValue("@ID", txtIdEmp.Text)

            ExluirRelacionamentoEmpresaAssociado()
            connection.Open()

            command.ExecuteNonQuery()

            MessageBox.Show("exluido com sucesso!")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
            command.Clone()
            connection = Nothing
            command = Nothing
        End Try
    End Sub

    Private Sub ExluirRelacionamentoEmpresaAssociado()
        Try
            connection = New SqlConnection("Data Source=DESKTOP-TRVTAH5\SQLEXPRESS;Initial Catalog=S4E;Integrated Security=True")
            connection.Open()

            strSQL = "DELETE Relacionamento WHERE Id_empre = @IdEmp"

            command = New SqlCommand(strSQL, connection)
            command.Parameters.AddWithValue("@IdEmp", txtIdEmp.Text)

            command.ExecuteNonQuery()
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles ConsultarIDEmp.Click 'pesquisar empresa por Id
        Try
            connection = New SqlConnection("Data Source=DESKTOP-TRVTAH5\SQLEXPRESS;Initial Catalog=S4E;Integrated Security=True")
            connection.Open()

            strSQL = "SELECT * FROM empresas WHERE Id_empresa = '" & txtIdEmp.Text & "'"

            da = New SqlDataAdapter(strSQL, connection)
            Using dr = New DataTable()
                da.Fill(dr)
                DataGridView2.DataSource = dr
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
            connection = Nothing
            command = Nothing
            dr = Nothing
        End Try
    End Sub
End Class