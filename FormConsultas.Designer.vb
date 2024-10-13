<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConsultas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        dgvResultados = New DataGridView()
        GroupBox1 = New GroupBox()
        cbMesesBeneficios = New ComboBox()
        dtpMemb = New DateTimePicker()
        cbCursos = New ComboBox()
        cbMejMiemb = New ComboBox()
        cbCurMiembro = New ComboBox()
        btnEjecutar = New Button()
        Panel1 = New Panel()
        rbBeneficioMensual = New RadioButton()
        rbElementosenCursos = New RadioButton()
        rbMejoresMiembros = New RadioButton()
        rbMiembrosconDeudas = New RadioButton()
        rbMiembrosenCursos = New RadioButton()
        Label1 = New Label()
        Splitter1 = New Splitter()
        Label2 = New Label()
        tbTotal = New TextBox()
        Label3 = New Label()
        tbBeneficios = New TextBox()
        CType(dgvResultados, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' dgvResultados
        ' 
        dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvResultados.Location = New Point(28, 377)
        dgvResultados.Name = "dgvResultados"
        dgvResultados.Size = New Size(758, 246)
        dgvResultados.TabIndex = 0
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(cbMesesBeneficios)
        GroupBox1.Controls.Add(dtpMemb)
        GroupBox1.Controls.Add(cbCursos)
        GroupBox1.Controls.Add(cbMejMiemb)
        GroupBox1.Controls.Add(cbCurMiembro)
        GroupBox1.Controls.Add(btnEjecutar)
        GroupBox1.Controls.Add(Panel1)
        GroupBox1.Font = New Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.White
        GroupBox1.Location = New Point(28, 76)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(758, 295)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Elegir tipo de Consulta:"
        ' 
        ' cbMesesBeneficios
        ' 
        cbMesesBeneficios.DropDownStyle = ComboBoxStyle.DropDownList
        cbMesesBeneficios.FormattingEnabled = True
        cbMesesBeneficios.Location = New Point(378, 178)
        cbMesesBeneficios.Name = "cbMesesBeneficios"
        cbMesesBeneficios.Size = New Size(288, 24)
        cbMesesBeneficios.TabIndex = 36
        ' 
        ' dtpMemb
        ' 
        dtpMemb.Format = DateTimePickerFormat.Short
        dtpMemb.Location = New Point(379, 70)
        dtpMemb.Name = "dtpMemb"
        dtpMemb.Size = New Size(287, 21)
        dtpMemb.TabIndex = 35
        ' 
        ' cbCursos
        ' 
        cbCursos.DropDownStyle = ComboBoxStyle.DropDownList
        cbCursos.FormattingEnabled = True
        cbCursos.Location = New Point(378, 140)
        cbCursos.Name = "cbCursos"
        cbCursos.Size = New Size(288, 24)
        cbCursos.TabIndex = 34
        ' 
        ' cbMejMiemb
        ' 
        cbMejMiemb.DropDownStyle = ComboBoxStyle.DropDownList
        cbMejMiemb.FormattingEnabled = True
        cbMejMiemb.IntegralHeight = False
        cbMejMiemb.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        cbMejMiemb.Location = New Point(378, 104)
        cbMejMiemb.Name = "cbMejMiemb"
        cbMejMiemb.Size = New Size(288, 24)
        cbMejMiemb.TabIndex = 34
        ' 
        ' cbCurMiembro
        ' 
        cbCurMiembro.DropDownStyle = ComboBoxStyle.DropDownList
        cbCurMiembro.FormattingEnabled = True
        cbCurMiembro.Location = New Point(378, 34)
        cbCurMiembro.Name = "cbCurMiembro"
        cbCurMiembro.Size = New Size(288, 24)
        cbCurMiembro.TabIndex = 34
        ' 
        ' btnEjecutar
        ' 
        btnEjecutar.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
        btnEjecutar.FlatStyle = FlatStyle.Popup
        btnEjecutar.Font = New Font("Cascadia Mono SemiBold", 12F, FontStyle.Bold)
        btnEjecutar.ForeColor = Color.WhiteSmoke
        btnEjecutar.Image = My.Resources.Resources.icono_flecha_derecha_grande
        btnEjecutar.ImageAlign = ContentAlignment.MiddleRight
        btnEjecutar.Location = New Point(378, 229)
        btnEjecutar.Name = "btnEjecutar"
        btnEjecutar.Padding = New Padding(10, 0, 25, 0)
        btnEjecutar.Size = New Size(288, 44)
        btnEjecutar.TabIndex = 33
        btnEjecutar.Text = "Ejecutar consulta"
        btnEjecutar.TextImageRelation = TextImageRelation.TextBeforeImage
        btnEjecutar.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(rbBeneficioMensual)
        Panel1.Controls.Add(rbElementosenCursos)
        Panel1.Controls.Add(rbMejoresMiembros)
        Panel1.Controls.Add(rbMiembrosconDeudas)
        Panel1.Controls.Add(rbMiembrosenCursos)
        Panel1.Location = New Point(87, 20)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(215, 218)
        Panel1.TabIndex = 0
        ' 
        ' rbBeneficioMensual
        ' 
        rbBeneficioMensual.AutoSize = True
        rbBeneficioMensual.Location = New Point(23, 158)
        rbBeneficioMensual.Name = "rbBeneficioMensual"
        rbBeneficioMensual.Size = New Size(165, 20)
        rbBeneficioMensual.TabIndex = 1
        rbBeneficioMensual.TabStop = True
        rbBeneficioMensual.Text = "Beneficios mensuales"
        rbBeneficioMensual.UseVisualStyleBackColor = True
        ' 
        ' rbElementosenCursos
        ' 
        rbElementosenCursos.AutoSize = True
        rbElementosenCursos.Location = New Point(23, 123)
        rbElementosenCursos.Name = "rbElementosenCursos"
        rbElementosenCursos.Size = New Size(158, 20)
        rbElementosenCursos.TabIndex = 0
        rbElementosenCursos.TabStop = True
        rbElementosenCursos.Text = "Elementos en Cursos"
        rbElementosenCursos.UseVisualStyleBackColor = True
        ' 
        ' rbMejoresMiembros
        ' 
        rbMejoresMiembros.AutoSize = True
        rbMejoresMiembros.Location = New Point(23, 88)
        rbMejoresMiembros.Name = "rbMejoresMiembros"
        rbMejoresMiembros.Size = New Size(137, 20)
        rbMejoresMiembros.TabIndex = 0
        rbMejoresMiembros.TabStop = True
        rbMejoresMiembros.Text = "Mejores Miembros"
        rbMejoresMiembros.UseVisualStyleBackColor = True
        ' 
        ' rbMiembrosconDeudas
        ' 
        rbMiembrosconDeudas.AutoSize = True
        rbMiembrosconDeudas.Location = New Point(23, 53)
        rbMiembrosconDeudas.Name = "rbMiembrosconDeudas"
        rbMiembrosconDeudas.Size = New Size(158, 20)
        rbMiembrosconDeudas.TabIndex = 0
        rbMiembrosconDeudas.TabStop = True
        rbMiembrosconDeudas.Text = "Membresías a vencer"
        rbMiembrosconDeudas.UseVisualStyleBackColor = True
        ' 
        ' rbMiembrosenCursos
        ' 
        rbMiembrosenCursos.AutoSize = True
        rbMiembrosenCursos.Location = New Point(23, 18)
        rbMiembrosenCursos.Name = "rbMiembrosenCursos"
        rbMiembrosenCursos.Size = New Size(151, 20)
        rbMiembrosenCursos.TabIndex = 0
        rbMiembrosenCursos.TabStop = True
        rbMiembrosenCursos.Text = "Miembros en Cursos"
        rbMiembrosenCursos.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cascadia Mono SemiBold", 20F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(27, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(159, 35)
        Label1.TabIndex = 12
        Label1.Text = "Consultas"
        ' 
        ' Splitter1
        ' 
        Splitter1.Location = New Point(0, 0)
        Splitter1.Name = "Splitter1"
        Splitter1.Size = New Size(3, 708)
        Splitter1.TabIndex = 13
        Splitter1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
        Label2.FlatStyle = FlatStyle.Popup
        Label2.Font = New Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(38, 642)
        Label2.Name = "Label2"
        Label2.Padding = New Padding(5, 5, 0, 0)
        Label2.Size = New Size(227, 33)
        Label2.TabIndex = 14
        Label2.Text = "Resultados encontrados:"
        ' 
        ' tbTotal
        ' 
        tbTotal.Font = New Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tbTotal.Location = New Point(273, 646)
        tbTotal.Name = "tbTotal"
        tbTotal.ReadOnly = True
        tbTotal.Size = New Size(125, 26)
        tbTotal.TabIndex = 15
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
        Label3.FlatStyle = FlatStyle.Popup
        Label3.Font = New Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(423, 642)
        Label3.Name = "Label3"
        Label3.Padding = New Padding(5, 5, 0, 0)
        Label3.Size = New Size(121, 33)
        Label3.TabIndex = 16
        Label3.Text = "Beneficios:"
        ' 
        ' tbBeneficios
        ' 
        tbBeneficios.Font = New Font("Cascadia Mono", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tbBeneficios.Location = New Point(550, 646)
        tbBeneficios.Name = "tbBeneficios"
        tbBeneficios.ReadOnly = True
        tbBeneficios.Size = New Size(224, 26)
        tbBeneficios.TabIndex = 17
        ' 
        ' FormConsultas
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(33), CByte(31), CByte(45))
        ClientSize = New Size(821, 708)
        Controls.Add(tbBeneficios)
        Controls.Add(Label3)
        Controls.Add(tbTotal)
        Controls.Add(Label2)
        Controls.Add(Splitter1)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Controls.Add(dgvResultados)
        Name = "FormConsultas"
        Text = "FormConsultas"
        CType(dgvResultados, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub


    Friend WithEvents dgvResultados As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnEjecutar As Button
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents rbElementosenCursos As RadioButton
    Friend WithEvents rbMejoresMiembros As RadioButton
    Friend WithEvents rbMiembrosconDeudas As RadioButton
    Friend WithEvents rbMiembrosenCursos As RadioButton
    Friend WithEvents cbCurMiembro As ComboBox
    Friend WithEvents dtpMemb As DateTimePicker
    Friend WithEvents cbMejMiemb As ComboBox
    Friend WithEvents cbCursos As ComboBox
    Friend WithEvents cbMesesBeneficios As ComboBox
    Friend WithEvents rbBeneficioMensual As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents tbTotal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbBeneficios As TextBox
End Class
