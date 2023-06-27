<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnExibir = New System.Windows.Forms.Button()
        Me.lebal6 = New System.Windows.Forms.Label()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.AddEmp = New System.Windows.Forms.Button()
        Me.EditarEmpresa = New System.Windows.Forms.Button()
        Me.ExcluirEmp = New System.Windows.Forms.Button()
        Me.ExibirEmpresa = New System.Windows.Forms.Button()
        Me.ConsultarIDEmp = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtCpf = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIdEmp = New System.Windows.Forms.TextBox()
        Me.txtNomeEmp = New System.Windows.Forms.TextBox()
        Me.txtCnpj = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCNPJasso = New System.Windows.Forms.TextBox()
        Me.txtEmpAsso = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNomeAsso = New System.Windows.Forms.TextBox()
        Me.txtCpfAssociado = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Turquoise
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(3, 118)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(542, 211)
        Me.DataGridView1.TabIndex = 0
        '
        'BtnExibir
        '
        Me.BtnExibir.Location = New System.Drawing.Point(567, 11)
        Me.BtnExibir.Name = "BtnExibir"
        Me.BtnExibir.Size = New System.Drawing.Size(114, 35)
        Me.BtnExibir.TabIndex = 1
        Me.BtnExibir.Text = "Exibir Associados"
        Me.BtnExibir.UseVisualStyleBackColor = True
        '
        'lebal6
        '
        Me.lebal6.AutoSize = True
        Me.lebal6.Location = New System.Drawing.Point(10, 99)
        Me.lebal6.Name = "lebal6"
        Me.lebal6.Size = New System.Drawing.Size(89, 13)
        Me.lebal6.TabIndex = 4
        Me.lebal6.Text = "Data Nascimento"
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(567, 63)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(114, 35)
        Me.BtnAdd.TabIndex = 9
        Me.BtnAdd.Text = "Adicionar Associados"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Location = New System.Drawing.Point(567, 118)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(114, 35)
        Me.BtnEditar.TabIndex = 10
        Me.BtnEditar.Text = "Editar Associados"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(567, 244)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(114, 35)
        Me.btnExcluir.TabIndex = 11
        Me.btnExcluir.Text = "Excluir Associados"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(567, 181)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(114, 35)
        Me.btnConsultar.TabIndex = 12
        Me.btnConsultar.Text = "Consultar Id Associados"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(116, 92)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(96, 20)
        Me.DateTimePicker1.TabIndex = 13
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.Turquoise
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(13, 114)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(542, 207)
        Me.DataGridView2.TabIndex = 16
        '
        'AddEmp
        '
        Me.AddEmp.Location = New System.Drawing.Point(577, 71)
        Me.AddEmp.Name = "AddEmp"
        Me.AddEmp.Size = New System.Drawing.Size(114, 35)
        Me.AddEmp.TabIndex = 17
        Me.AddEmp.Text = "Adicionar Empresas"
        Me.AddEmp.UseVisualStyleBackColor = True
        '
        'EditarEmpresa
        '
        Me.EditarEmpresa.Location = New System.Drawing.Point(577, 134)
        Me.EditarEmpresa.Name = "EditarEmpresa"
        Me.EditarEmpresa.Size = New System.Drawing.Size(114, 35)
        Me.EditarEmpresa.TabIndex = 18
        Me.EditarEmpresa.Text = "Editar Empresas"
        Me.EditarEmpresa.UseVisualStyleBackColor = True
        '
        'ExcluirEmp
        '
        Me.ExcluirEmp.Location = New System.Drawing.Point(577, 272)
        Me.ExcluirEmp.Name = "ExcluirEmp"
        Me.ExcluirEmp.Size = New System.Drawing.Size(114, 35)
        Me.ExcluirEmp.TabIndex = 19
        Me.ExcluirEmp.Text = "Excluir Empresas"
        Me.ExcluirEmp.UseVisualStyleBackColor = True
        '
        'ExibirEmpresa
        '
        Me.ExibirEmpresa.Location = New System.Drawing.Point(577, 20)
        Me.ExibirEmpresa.Name = "ExibirEmpresa"
        Me.ExibirEmpresa.Size = New System.Drawing.Size(114, 35)
        Me.ExibirEmpresa.TabIndex = 20
        Me.ExibirEmpresa.Text = "Exibir Empresas"
        Me.ExibirEmpresa.UseVisualStyleBackColor = True
        '
        'ConsultarIDEmp
        '
        Me.ConsultarIDEmp.Location = New System.Drawing.Point(577, 199)
        Me.ConsultarIDEmp.Name = "ConsultarIDEmp"
        Me.ConsultarIDEmp.Size = New System.Drawing.Size(114, 35)
        Me.ConsultarIDEmp.TabIndex = 21
        Me.ConsultarIDEmp.Text = "Consultar Id Emrpesas"
        Me.ConsultarIDEmp.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Nome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "CPF"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(14, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "ID"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(55, 11)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 20)
        Me.txtId.TabIndex = 26
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(55, 37)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(192, 20)
        Me.txtNome.TabIndex = 27
        '
        'txtCpf
        '
        Me.txtCpf.Location = New System.Drawing.Point(55, 67)
        Me.txtCpf.Name = "txtCpf"
        Me.txtCpf.Size = New System.Drawing.Size(192, 20)
        Me.txtCpf.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "ID empresa"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Nome empresa"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "CNPJ"
        '
        'txtIdEmp
        '
        Me.txtIdEmp.Location = New System.Drawing.Point(116, 28)
        Me.txtIdEmp.Name = "txtIdEmp"
        Me.txtIdEmp.Size = New System.Drawing.Size(100, 20)
        Me.txtIdEmp.TabIndex = 32
        '
        'txtNomeEmp
        '
        Me.txtNomeEmp.Location = New System.Drawing.Point(116, 54)
        Me.txtNomeEmp.Name = "txtNomeEmp"
        Me.txtNomeEmp.Size = New System.Drawing.Size(192, 20)
        Me.txtNomeEmp.TabIndex = 33
        '
        'txtCnpj
        '
        Me.txtCnpj.Location = New System.Drawing.Point(116, 86)
        Me.txtCnpj.Name = "txtCnpj"
        Me.txtCnpj.Size = New System.Drawing.Size(192, 20)
        Me.txtCnpj.TabIndex = 34
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txtCNPJasso)
        Me.Panel1.Controls.Add(Me.txtEmpAsso)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.BtnEditar)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.txtCpf)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.BtnAdd)
        Me.Panel1.Controls.Add(Me.BtnExibir)
        Me.Panel1.Controls.Add(Me.lebal6)
        Me.Panel1.Controls.Add(Me.btnConsultar)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtNome)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtId)
        Me.Panel1.Controls.Add(Me.btnExcluir)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(2, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(716, 332)
        Me.Panel1.TabIndex = 35
        '
        'txtCNPJasso
        '
        Me.txtCNPJasso.Location = New System.Drawing.Point(378, 37)
        Me.txtCNPJasso.Name = "txtCNPJasso"
        Me.txtCNPJasso.Size = New System.Drawing.Size(135, 20)
        Me.txtCNPJasso.TabIndex = 32
        '
        'txtEmpAsso
        '
        Me.txtEmpAsso.Location = New System.Drawing.Point(378, 11)
        Me.txtEmpAsso.Name = "txtEmpAsso"
        Me.txtEmpAsso.Size = New System.Drawing.Size(135, 20)
        Me.txtEmpAsso.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(293, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "CNPJ"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(293, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Nome Empresa"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtCpfAssociado)
        Me.Panel2.Controls.Add(Me.txtNomeAsso)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.txtCnpj)
        Me.Panel2.Controls.Add(Me.txtNomeEmp)
        Me.Panel2.Controls.Add(Me.DataGridView2)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtIdEmp)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.ConsultarIDEmp)
        Me.Panel2.Controls.Add(Me.ExibirEmpresa)
        Me.Panel2.Controls.Add(Me.ExcluirEmp)
        Me.Panel2.Controls.Add(Me.EditarEmpresa)
        Me.Panel2.Controls.Add(Me.AddEmp)
        Me.Panel2.Location = New System.Drawing.Point(2, 353)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(716, 332)
        Me.Panel2.TabIndex = 36
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(317, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Nome Associado"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(317, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 13)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "CPF Associado"
        '
        'txtNomeAsso
        '
        Me.txtNomeAsso.Location = New System.Drawing.Point(410, 28)
        Me.txtNomeAsso.Name = "txtNomeAsso"
        Me.txtNomeAsso.Size = New System.Drawing.Size(135, 20)
        Me.txtNomeAsso.TabIndex = 37
        '
        'txtCpfAssociado
        '
        Me.txtCpfAssociado.Location = New System.Drawing.Point(410, 51)
        Me.txtCpfAssociado.Name = "txtCpfAssociado"
        Me.txtCpfAssociado.Size = New System.Drawing.Size(135, 20)
        Me.txtCpfAssociado.TabIndex = 38
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(723, 709)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Naosei"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnExibir As Button
    Friend WithEvents lebal6 As Label
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnConsultar As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents AddEmp As Button
    Friend WithEvents EditarEmpresa As Button
    Friend WithEvents ExcluirEmp As Button
    Friend WithEvents ExibirEmpresa As Button
    Friend WithEvents ConsultarIDEmp As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtCpf As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtIdEmp As TextBox
    Friend WithEvents txtNomeEmp As TextBox
    Friend WithEvents txtCnpj As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCNPJasso As TextBox
    Friend WithEvents txtEmpAsso As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCpfAssociado As TextBox
    Friend WithEvents txtNomeAsso As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
End Class
