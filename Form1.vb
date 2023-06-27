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

    Public Class Empresa
        Public Property Id As Integer
        Public Property Nome As String

        Public Sub New(id As Integer, nome As String)
            Me.Id = id
            Me.Nome = nome
        End Sub
    End Class
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicializa a conexão com o banco de dados
        connection = New SqlConnection("Data Source=DESKTOP-TRVTAH5\SQLEXPRESS;Initial Catalog=S4E;Integrated Security=True")

        ' Carrega os dados do banco para o CheckedListBox
        LoadEmpresas()
    End Sub

    Private Sub LoadEmpresas()
        Try
            connection = New SqlConnection("Data Source=DESKTOP-TRVTAH5\SQLEXPRESS;Initial Catalog=S4E;Integrated Security=True")
            connection.Open()

            Dim query As String = "SELECT Nome FROM empresas"
            command = New SqlCommand(query, connection)

            Using reader As SqlDataReader = command.ExecuteReader()
                While reader.Read()
                    CheckedListBox1.Items.Add(reader("Nome").ToString())
                End While
            End Using

            connection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click 'adicionar associado

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
                strSQL = "INSERT INTO associados (Nome, CPF, DataNascimento) VALUES (@NOME, @Cpf, @DATANASCIMENTO); SELECT SCOPE_IDENTITY();"

                command = New SqlCommand(strSQL, connection)
                command.Parameters.AddWithValue("@NOME", txtNome.Text)
                command.Parameters.AddWithValue("@CPF", txtCpf.Text)
                command.Parameters.AddWithValue("@DATANASCIMENTO", DateTimePicker1.Text)

                Dim idAssociado As Integer = Convert.ToInt32(command.ExecuteScalar())

                ' Obter as empresas selecionadas do CheckedListBox
                Dim empresasSelecionadas As New List(Of String)()

                For Each index As Integer In CheckedListBox1.CheckedIndices
                    ' Recupere o ID da empresa usando o índice selecionado
                    Dim idEmpresa As Integer = GetCompanyIdByIndex(index)
                    empresasSelecionadas.Add(idEmpresa)
                Next

                ' Inserir o relacionamento do associado com as empresas selecionadas
                For Each empresa As String In empresasSelecionadas
                    Dim query As String = "INSERT INTO Relacionamento (Id_empre, Id_asso) VALUES ( @NomeEmpresa, @IdAssociado)"
                    command = New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@IdAssociado", idAssociado)
                    command.Parameters.AddWithValue("@NomeEmpresa", empresa)
                    command.ExecuteNonQuery()
                Next
            End If

            MessageBox.Show("Adicionado com sucesso!")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
            command.Clone()
            connection = Nothing
            command = Nothing
        End Try
    End Sub

    Private Function GetCompanyIdByIndex(index As Integer) As Integer
        If index >= 0 AndAlso index < CheckedListBox1.Items.Count Then
            ' Obter o nome da empresa selecionada
            Dim selectedEmpresa As String = CheckedListBox1.Items(index).ToString()

            ' Obter o ID da empresa a partir do banco de dados usando o nome da empresa
            Dim idEmpresa As Integer = -1 ' Valor padrão se não for possível obter o ID

            Dim connectionString As String = "Data Source=DESKTOP-TRVTAH5\SQLEXPRESS;Initial Catalog=S4E;Integrated Security=True"
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT Id_empresa FROM empresas WHERE Nome = @Nome"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Nome", selectedEmpresa)

                    Dim result As Object = command.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        idEmpresa = Convert.ToInt32(result)
                    End If
                End Using
            End Using

            Return idEmpresa
        End If

        Return -1 ' Valor padrão se nenhum item for selecionado ou o índice for inválido
    End Function

    Private Sub BtnExibir_Click(sender As Object, e As EventArgs) Handles BtnExibir.Click 'exibir todos os associados
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
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click 'editar associados
        Try
            ' Atualizar os dados cadastrais do associado

            Using connection As New SqlConnection("Data Source=DESKTOP-TRVTAH5\SQLEXPRESS;Initial Catalog=S4E;Integrated Security=True")
                connection.Open()
                strSQL = "UPDATE associados SET NOME = @NOME, CPF = @CPF, DATANASCIMENTO = @DATANASCIMENTO WHERE Id_associado = @ID"
                Using command As New SqlCommand(strSQL, connection)
                    command.Parameters.AddWithValue("@ID", txtId.Text)
                    command.Parameters.AddWithValue("@NOME", txtNome.Text)
                    command.Parameters.AddWithValue("@CPF", txtCpf.Text)
                    command.Parameters.AddWithValue("@DATANASCIMENTO", DateTimePicker1.Value)

                    command.ExecuteNonQuery()
                End Using
            End Using

            ' Remover as associações existentes do associado com empresas
            strSQL = "DELETE FROM Relacionamento WHERE Id_asso = @IdAssociado"
            Using connection As New SqlConnection("Data Source=DESKTOP-TRVTAH5\SQLEXPRESS;Initial Catalog=S4E;Integrated Security=True")
                connection.Open()
                Using command As New SqlCommand(strSQL, connection)
                    command.Parameters.AddWithValue("@IdAssociado", txtId.Text)

                    command.ExecuteNonQuery()
                End Using
            End Using

            ' Adicionar as novas associações do associado com empresas
            For Each item In CheckedListBox1.CheckedItems
                Dim idEmpresa As Integer = GetCompanyIdByName(item.ToString())

                If idEmpresa <> -1 Then
                    strSQL = "INSERT INTO Relacionamento (Id_empre, Id_asso) VALUES (@IdEmpresa, @IdAssociado)"
                    Using connection As New SqlConnection("Data Source=DESKTOP-TRVTAH5\SQLEXPRESS;Initial Catalog=S4E;Integrated Security=True")
                        connection.Open()
                        Using command As New SqlCommand(strSQL, connection)
                            command.Parameters.AddWithValue("@IdAssociado", txtId.Text)
                            command.Parameters.AddWithValue("@IdEmpresa", idEmpresa)

                            command.ExecuteNonQuery()
                        End Using
                    End Using
                End If
            Next

            MessageBox.Show("Alterações salvas com sucesso!")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
            command.Clone()
            connection = Nothing
            command = Nothing
        End Try
    End Sub

    Private Function GetCompanyIdByName(index As String) As Integer
        If index >= 0 AndAlso index < CheckedListBox1.Items.Count Then
            ' Obter o nome da empresa selecionada
            Dim selectedEmpresa As String = CheckedListBox1.Items(index).ToString()

            ' Obter o ID da empresa a partir do banco de dados usando o nome da empresa
            Dim idEmpresa As Integer = -1 ' Valor padrão se não for possível obter o ID

            Dim connectionString As String = "Data Source=DESKTOP-TRVTAH5\SQLEXPRESS;Initial Catalog=S4E;Integrated Security=True"
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT Id_empresa FROM empresas WHERE Nome = @Nome"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Nome", selectedEmpresa)

                    Dim result As Object = command.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        idEmpresa = Convert.ToInt32(result)
                    End If
                End Using
            End Using

            Return idEmpresa
        End If

        Return -1 ' Valor padrão se nenhum item for selecionado ou o índice for inválido
    End Function
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
    '-----------------------------------------AREA DA EMPRESA----------------------------------------------------
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inicializa a conexão com o banco de dados
        connection = New SqlConnection("Data Source=DESKTOP-TRVTAH5\SQLEXPRESS;Initial Catalog=S4E;Integrated Security=True")

        ' Carrega os dados do banco para o CheckedListBox
        LoadAssociados()
    End Sub

    Private Sub LoadAssociados()
        Try
            connection = New SqlConnection("Data Source=DESKTOP-TRVTAH5\SQLEXPRESS;Initial Catalog=S4E;Integrated Security=True")
            connection.Open()

            Dim query As String = "SELECT Nome FROM associados"
            command = New SqlCommand(query, connection)

            Using reader As SqlDataReader = command.ExecuteReader()
                While reader.Read()
                    CheckedListBox2.Items.Add(reader("Nome").ToString())
                End While
            End Using

            connection.Close()
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

                Dim idAssociado As Integer = Convert.ToInt32(command.ExecuteScalar())

                ' Obter as empresas selecionadas do CheckedListBox
                Dim associadioSelecionadas As New List(Of String)()

                For Each index As Integer In CheckedListBox1.CheckedIndices
                    ' Recupere o ID da empresa usando o índice selecionado
                    Dim idEmpresa As Integer = GetCompanyIdByIndex2(index)
                    associadioSelecionadas.Add(idEmpresa)
                Next

                ' Inserir o relacionamento do associado com as empresas selecionadas
                For Each empresa As String In associadioSelecionadas
                    Dim query As String = "INSERT INTO Relacionamento (Id_empre, Id_asso) VALUES ( @NomeEmpresa, @IdAssociado)"
                    command = New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@IdAssociado", idAssociado)
                    command.Parameters.AddWithValue("@NomeEmpresa", empresa)
                    command.ExecuteNonQuery()
                Next

                'RelacionamentoEmpresaAssociado()
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

    Private Function GetCompanyIdByIndex2(index As Integer) As Integer
        If index >= 0 AndAlso index < CheckedListBox1.Items.Count Then
            ' Obter o nome da empresa selecionada
            Dim selectedEmpresa As String = CheckedListBox1.Items(index).ToString()

            ' Obter o ID da empresa a partir do banco de dados usando o nome da empresa
            Dim idEmpresa As Integer = -1 ' Valor padrão se não for possível obter o ID

            Dim connectionString As String = "Data Source=DESKTOP-TRVTAH5\SQLEXPRESS;Initial Catalog=S4E;Integrated Security=True"
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT Id_associado FROM associados WHERE Nome = @Nome"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Nome", selectedEmpresa)

                    Dim result As Object = command.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        idEmpresa = Convert.ToInt32(result)
                    End If
                End Using
            End Using

            Return idEmpresa
        End If

        Return -1 ' Valor padrão se nenhum item for selecionado ou o índice for inválido
    End Function

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

            ' Remover as associações existentes da empresa com associado
            strSQL = "DELETE FROM Relacionamento WHERE Id_empre = @IdEmpresa"
            Using connection As New SqlConnection("Data Source=DESKTOP-TRVTAH5\SQLEXPRESS;Initial Catalog=S4E;Integrated Security=True")
                connection.Open()
                Using command As New SqlCommand(strSQL, connection)
                    command.Parameters.AddWithValue("@IdEmpresa", txtIdEmp.Text)

                    command.ExecuteNonQuery()
                End Using
            End Using

            ' Adicionar as novas associações da empresa com associado
            For Each item In CheckedListBox1.CheckedItems
                Dim idAssociado As Integer = GetCompanyIdByName2(item.ToString())

                If idAssociado <> -1 Then
                    strSQL = "INSERT INTO Relacionamento (Id_empre, Id_asso) VALUES (@IdEmpresa, @IdAssociado)"
                    Using connection As New SqlConnection("Data Source=DESKTOP-TRVTAH5\SQLEXPRESS;Initial Catalog=S4E;Integrated Security=True")
                        connection.Open()
                        Using command As New SqlCommand(strSQL, connection)
                            command.Parameters.AddWithValue("@IdAssociado", idAssociado)
                            command.Parameters.AddWithValue("@IdEmpresa", txtIdEmp.Text)

                            command.ExecuteNonQuery()
                        End Using
                    End Using
                End If
            Next
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

    Private Function GetCompanyIdByName2(index As String) As Integer
        If index >= 0 AndAlso index < CheckedListBox1.Items.Count Then
            ' Obter o nome do associado selecionada
            Dim selectedAssociado As String = CheckedListBox1.Items(index).ToString()

            ' Obter o ID do associado a partir do banco de dados usando o nome do associado
            Dim idAssociado As Integer = -1 ' Valor padrão se não for possível obter o ID

            Dim connectionString As String = "Data Source=DESKTOP-TRVTAH5\SQLEXPRESS;Initial Catalog=S4E;Integrated Security=True"
            Using connection As New SqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT Id_associado FROM associado WHERE Nome = @Nome"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Nome", selectedAssociado)

                    Dim result As Object = command.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        idAssociado = Convert.ToInt32(result)
                    End If
                End Using
            End Using

            Return idAssociado
        End If

        Return -1 ' Valor padrão se nenhum item for selecionado ou o índice for inválido
    End Function

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