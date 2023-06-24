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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtCpf = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Turquoise
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 350)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(487, 235)
        Me.DataGridView1.TabIndex = 0
        '
        'BtnExibir
        '
        Me.BtnExibir.Location = New System.Drawing.Point(167, 164)
        Me.BtnExibir.Name = "BtnExibir"
        Me.BtnExibir.Size = New System.Drawing.Size(114, 35)
        Me.BtnExibir.TabIndex = 1
        Me.BtnExibir.Text = "Exibir Associados"
        Me.BtnExibir.UseVisualStyleBackColor = True
        '
        'lebal6
        '
        Me.lebal6.AutoSize = True
        Me.lebal6.Location = New System.Drawing.Point(12, 118)
        Me.lebal6.Name = "lebal6"
        Me.lebal6.Size = New System.Drawing.Size(89, 13)
        Me.lebal6.TabIndex = 4
        Me.lebal6.Text = "Data Nascimento"
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(12, 164)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(114, 35)
        Me.BtnAdd.TabIndex = 9
        Me.BtnAdd.Text = "Adicionar Associados"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Location = New System.Drawing.Point(12, 219)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(114, 35)
        Me.BtnEditar.TabIndex = 10
        Me.BtnEditar.Text = "Editar Associados"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(12, 277)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(114, 35)
        Me.btnExcluir.TabIndex = 11
        Me.btnExcluir.Text = "Excluir Associados"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(167, 219)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(114, 35)
        Me.btnConsultar.TabIndex = 12
        Me.btnConsultar.Text = "Consultar Associados"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(118, 111)
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
        Me.DataGridView2.Location = New System.Drawing.Point(877, 350)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(487, 235)
        Me.DataGridView2.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1213, 164)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 35)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Adicionar Empresas"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1213, 205)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(114, 35)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Editar Empresas"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1213, 246)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(114, 35)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Excluir Empresas"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(1064, 164)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(114, 35)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "Exibir Empresas"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(1064, 205)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(114, 35)
        Me.Button5.TabIndex = 21
        Me.Button5.Text = "Consultar Emrpesas"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Nome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "CPF"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "ID"
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(118, 33)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 20)
        Me.txtId.TabIndex = 26
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(118, 59)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(100, 20)
        Me.txtNome.TabIndex = 27
        '
        'txtCpf
        '
        Me.txtCpf.Location = New System.Drawing.Point(118, 85)
        Me.txtCpf.Name = "txtCpf"
        Me.txtCpf.Size = New System.Drawing.Size(100, 20)
        Me.txtCpf.TabIndex = 28
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1376, 629)
        Me.Controls.Add(Me.txtCpf)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.lebal6)
        Me.Controls.Add(Me.BtnExibir)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Naosei"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtCpf As TextBox
End Class
