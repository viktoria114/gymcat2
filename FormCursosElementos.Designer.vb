﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCursosElementos
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
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        btnInscribir = New Button()
        btnDesinscribir = New Button()
        GroupBox1 = New GroupBox()
        dgvElementosDentro = New DataGridView()
        GroupBox2 = New GroupBox()
        dgvElementosFuera = New DataGridView()
        lbProfesorCurso = New Label()
        lbDiasCurso = New Label()
        lbPrecioCurso = New Label()
        lbHorariosCurso = New Label()
        lbCursos = New Label()
        cbOpciones = New ComboBox()
        dgvListadoCursos = New DataGridView()
        tbBuscar = New TextBox()
        btnGuardar = New Button()
        btnCancelar = New Button()
        GroupBox3 = New GroupBox()
        lbDesinscripciones = New Label()
        Label2 = New Label()
        lbInscripciones = New Label()
        tbMeses = New TextBox()
        btnReducirMeses = New Button()
        btnAumentarMeses = New Button()
        Label1 = New Label()
        Label3 = New Label()
        GroupBox1.SuspendLayout()
        CType(dgvElementosDentro, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(dgvElementosFuera, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvListadoCursos, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnInscribir
        ' 
        btnInscribir.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
        btnInscribir.FlatStyle = FlatStyle.Popup
        btnInscribir.Font = New Font("Cascadia Mono SemiBold", 11F, FontStyle.Bold)
        btnInscribir.ForeColor = SystemColors.Control
        btnInscribir.Image = My.Resources.Resources.icono_flecha_izquierda
        btnInscribir.ImageAlign = ContentAlignment.MiddleLeft
        btnInscribir.Location = New Point(446, 364)
        btnInscribir.Name = "btnInscribir"
        btnInscribir.Padding = New Padding(5, 0, 0, 0)
        btnInscribir.Size = New Size(154, 34)
        btnInscribir.TabIndex = 2
        btnInscribir.Text = " Inscribir"
        btnInscribir.UseVisualStyleBackColor = False
        ' 
        ' btnDesinscribir
        ' 
        btnDesinscribir.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
        btnDesinscribir.FlatStyle = FlatStyle.Popup
        btnDesinscribir.Font = New Font("Cascadia Mono SemiBold", 11F, FontStyle.Bold)
        btnDesinscribir.ForeColor = SystemColors.Control
        btnDesinscribir.Image = My.Resources.Resources.icono_flecha_derecha
        btnDesinscribir.ImageAlign = ContentAlignment.MiddleLeft
        btnDesinscribir.Location = New Point(446, 404)
        btnDesinscribir.Name = "btnDesinscribir"
        btnDesinscribir.Padding = New Padding(5, 0, 0, 0)
        btnDesinscribir.Size = New Size(154, 34)
        btnDesinscribir.TabIndex = 2
        btnDesinscribir.Text = "  Desinscribir"
        btnDesinscribir.TextAlign = ContentAlignment.MiddleRight
        btnDesinscribir.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(dgvElementosDentro)
        GroupBox1.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        GroupBox1.ForeColor = SystemColors.ButtonHighlight
        GroupBox1.Location = New Point(38, 297)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(402, 221)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Cursos Inscritos"
        ' 
        ' dgvElementosDentro
        ' 
        dgvElementosDentro.AllowUserToAddRows = False
        dgvElementosDentro.AllowUserToDeleteRows = False
        dgvElementosDentro.AllowUserToOrderColumns = True
        dgvElementosDentro.AllowUserToResizeRows = False
        dgvElementosDentro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvElementosDentro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvElementosDentro.Location = New Point(6, 22)
        dgvElementosDentro.MultiSelect = False
        dgvElementosDentro.Name = "dgvElementosDentro"
        dgvElementosDentro.ReadOnly = True
        DataGridViewCellStyle5.ForeColor = SystemColors.ControlText
        dgvElementosDentro.RowsDefaultCellStyle = DataGridViewCellStyle5
        dgvElementosDentro.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvElementosDentro.Size = New Size(390, 193)
        dgvElementosDentro.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(dgvElementosFuera)
        GroupBox2.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        GroupBox2.ForeColor = SystemColors.ButtonHighlight
        GroupBox2.Location = New Point(606, 297)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(189, 221)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        GroupBox2.Text = "Cursos Disponibes"
        ' 
        ' dgvElementosFuera
        ' 
        dgvElementosFuera.AllowUserToAddRows = False
        dgvElementosFuera.AllowUserToDeleteRows = False
        dgvElementosFuera.AllowUserToResizeRows = False
        dgvElementosFuera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvElementosFuera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvElementosFuera.Location = New Point(6, 22)
        dgvElementosFuera.MultiSelect = False
        dgvElementosFuera.Name = "dgvElementosFuera"
        dgvElementosFuera.ReadOnly = True
        DataGridViewCellStyle6.ForeColor = SystemColors.ControlText
        dgvElementosFuera.RowsDefaultCellStyle = DataGridViewCellStyle6
        dgvElementosFuera.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvElementosFuera.Size = New Size(177, 193)
        dgvElementosFuera.TabIndex = 0
        ' 
        ' lbProfesorCurso
        ' 
        lbProfesorCurso.AutoSize = True
        lbProfesorCurso.Font = New Font("Cascadia Mono SemiBold", 14F)
        lbProfesorCurso.ForeColor = SystemColors.Control
        lbProfesorCurso.Location = New Point(300, 551)
        lbProfesorCurso.Name = "lbProfesorCurso"
        lbProfesorCurso.Size = New Size(111, 25)
        lbProfesorCurso.TabIndex = 31
        lbProfesorCurso.Text = "Profesor:"
        lbProfesorCurso.Visible = False
        ' 
        ' lbDiasCurso
        ' 
        lbDiasCurso.AutoSize = True
        lbDiasCurso.Font = New Font("Cascadia Mono SemiBold", 14F)
        lbDiasCurso.ForeColor = SystemColors.Control
        lbDiasCurso.Location = New Point(300, 521)
        lbDiasCurso.Name = "lbDiasCurso"
        lbDiasCurso.Size = New Size(166, 25)
        lbDiasCurso.TabIndex = 30
        lbDiasCurso.Text = "Dias de clase:"
        lbDiasCurso.Visible = False
        ' 
        ' lbPrecioCurso
        ' 
        lbPrecioCurso.AutoSize = True
        lbPrecioCurso.Font = New Font("Cascadia Mono SemiBold", 14F)
        lbPrecioCurso.ForeColor = SystemColors.Control
        lbPrecioCurso.Location = New Point(38, 581)
        lbPrecioCurso.Name = "lbPrecioCurso"
        lbPrecioCurso.Size = New Size(89, 25)
        lbPrecioCurso.TabIndex = 29
        lbPrecioCurso.Text = "Precio:"
        lbPrecioCurso.Visible = False
        ' 
        ' lbHorariosCurso
        ' 
        lbHorariosCurso.AutoSize = True
        lbHorariosCurso.Font = New Font("Cascadia Mono SemiBold", 14F)
        lbHorariosCurso.ForeColor = SystemColors.Control
        lbHorariosCurso.Location = New Point(38, 551)
        lbHorariosCurso.Name = "lbHorariosCurso"
        lbHorariosCurso.Size = New Size(111, 25)
        lbHorariosCurso.TabIndex = 27
        lbHorariosCurso.Text = "Horarios:"
        lbHorariosCurso.Visible = False
        ' 
        ' lbCursos
        ' 
        lbCursos.AutoSize = True
        lbCursos.Font = New Font("Cascadia Mono SemiBold", 14F)
        lbCursos.ForeColor = SystemColors.Control
        lbCursos.Location = New Point(38, 521)
        lbCursos.Name = "lbCursos"
        lbCursos.Size = New Size(78, 25)
        lbCursos.TabIndex = 26
        lbCursos.Text = "Curso:"
        lbCursos.Visible = False
        ' 
        ' cbOpciones
        ' 
        cbOpciones.DropDownStyle = ComboBoxStyle.DropDownList
        cbOpciones.FormattingEnabled = True
        cbOpciones.Items.AddRange(New Object() {"Nombre", "Apellido", "DNI"})
        cbOpciones.Location = New Point(606, 94)
        cbOpciones.Name = "cbOpciones"
        cbOpciones.Size = New Size(186, 23)
        cbOpciones.TabIndex = 25
        ' 
        ' dgvListadoCursos
        ' 
        dgvListadoCursos.AllowUserToAddRows = False
        dgvListadoCursos.AllowUserToDeleteRows = False
        dgvListadoCursos.AllowUserToResizeRows = False
        dgvListadoCursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvListadoCursos.BackgroundColor = SystemColors.ButtonShadow
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = SystemColors.Control
        DataGridViewCellStyle7.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle7.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = Color.Black
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.True
        dgvListadoCursos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        dgvListadoCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvListadoCursos.Location = New Point(30, 123)
        dgvListadoCursos.MultiSelect = False
        dgvListadoCursos.Name = "dgvListadoCursos"
        dgvListadoCursos.ReadOnly = True
        DataGridViewCellStyle8.ForeColor = Color.Black
        dgvListadoCursos.RowsDefaultCellStyle = DataGridViewCellStyle8
        dgvListadoCursos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvListadoCursos.Size = New Size(570, 168)
        dgvListadoCursos.TabIndex = 6
        ' 
        ' tbBuscar
        ' 
        tbBuscar.Location = New Point(30, 94)
        tbBuscar.Name = "tbBuscar"
        tbBuscar.Size = New Size(570, 23)
        tbBuscar.TabIndex = 4
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
        btnGuardar.Enabled = False
        btnGuardar.FlatStyle = FlatStyle.Popup
        btnGuardar.Font = New Font("Cascadia Mono SemiBold", 11F, FontStyle.Bold)
        btnGuardar.ForeColor = SystemColors.Control
        btnGuardar.Image = My.Resources.Resources.icono_item_guardar
        btnGuardar.ImageAlign = ContentAlignment.MiddleLeft
        btnGuardar.Location = New Point(446, 484)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Padding = New Padding(5, 0, 0, 0)
        btnGuardar.Size = New Size(154, 34)
        btnGuardar.TabIndex = 2
        btnGuardar.Text = " Guardar"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' btnCancelar
        ' 
        btnCancelar.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
        btnCancelar.Enabled = False
        btnCancelar.FlatStyle = FlatStyle.Popup
        btnCancelar.Font = New Font("Cascadia Mono SemiBold", 11F, FontStyle.Bold)
        btnCancelar.ForeColor = SystemColors.Control
        btnCancelar.Image = My.Resources.Resources.icono_item_eliminar
        btnCancelar.ImageAlign = ContentAlignment.MiddleLeft
        btnCancelar.Location = New Point(446, 444)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Padding = New Padding(5, 0, 0, 0)
        btnCancelar.Size = New Size(154, 34)
        btnCancelar.TabIndex = 2
        btnCancelar.Text = " Cancelar"
        btnCancelar.UseVisualStyleBackColor = False
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(lbDesinscripciones)
        GroupBox3.Controls.Add(Label2)
        GroupBox3.Controls.Add(lbInscripciones)
        GroupBox3.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox3.ForeColor = SystemColors.ButtonHighlight
        GroupBox3.Location = New Point(606, 123)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(189, 168)
        GroupBox3.TabIndex = 3
        GroupBox3.TabStop = False
        GroupBox3.Text = "Cambios sin Guardar"
        ' 
        ' lbDesinscripciones
        ' 
        lbDesinscripciones.AutoSize = True
        lbDesinscripciones.Dock = DockStyle.Top
        lbDesinscripciones.Font = New Font("Cascadia Mono", 9.75F)
        lbDesinscripciones.ForeColor = SystemColors.Control
        lbDesinscripciones.Location = New Point(3, 36)
        lbDesinscripciones.Name = "lbDesinscripciones"
        lbDesinscripciones.Size = New Size(144, 17)
        lbDesinscripciones.TabIndex = 27
        lbDesinscripciones.Text = "Desinscripciones:"
        lbDesinscripciones.Visible = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(596, -258)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 17)
        Label2.TabIndex = 0
        Label2.Text = "Label1"
        ' 
        ' lbInscripciones
        ' 
        lbInscripciones.AutoSize = True
        lbInscripciones.Dock = DockStyle.Top
        lbInscripciones.Font = New Font("Cascadia Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbInscripciones.ForeColor = SystemColors.Control
        lbInscripciones.Location = New Point(3, 19)
        lbInscripciones.Name = "lbInscripciones"
        lbInscripciones.Size = New Size(120, 17)
        lbInscripciones.TabIndex = 26
        lbInscripciones.Text = "Inscripciones:"
        lbInscripciones.Visible = False
        ' 
        ' tbMeses
        ' 
        tbMeses.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
        tbMeses.Font = New Font("Cascadia Mono", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tbMeses.ForeColor = Color.White
        tbMeses.Location = New Point(499, 326)
        tbMeses.Name = "tbMeses"
        tbMeses.Size = New Size(48, 32)
        tbMeses.TabIndex = 32
        tbMeses.Text = "1"
        tbMeses.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnReducirMeses
        ' 
        btnReducirMeses.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
        btnReducirMeses.FlatStyle = FlatStyle.Popup
        btnReducirMeses.Location = New Point(460, 326)
        btnReducirMeses.Name = "btnReducirMeses"
        btnReducirMeses.Size = New Size(33, 32)
        btnReducirMeses.TabIndex = 33
        btnReducirMeses.UseVisualStyleBackColor = False
        ' 
        ' btnAumentarMeses
        ' 
        btnAumentarMeses.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
        btnAumentarMeses.FlatStyle = FlatStyle.Popup
        btnAumentarMeses.Location = New Point(553, 326)
        btnAumentarMeses.Name = "btnAumentarMeses"
        btnAumentarMeses.Size = New Size(33, 32)
        btnAumentarMeses.TabIndex = 33
        btnAumentarMeses.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cascadia Mono SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(450, 304)
        Label1.Name = "Label1"
        Label1.Size = New Size(147, 16)
        Label1.TabIndex = 27
        Label1.Text = "Meses de Inscripcion"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Cascadia Mono SemiBold", 20F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(40, 32)
        Label3.Name = "Label3"
        Label3.Size = New Size(319, 35)
        Label3.TabIndex = 34
        Label3.Text = "Elementos de Cursos"
        ' 
        ' FormCursosElementos
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(33), CByte(31), CByte(45))
        ClientSize = New Size(824, 626)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(btnAumentarMeses)
        Controls.Add(btnReducirMeses)
        Controls.Add(tbMeses)
        Controls.Add(dgvListadoCursos)
        Controls.Add(cbOpciones)
        Controls.Add(tbBuscar)
        Controls.Add(lbProfesorCurso)
        Controls.Add(lbDiasCurso)
        Controls.Add(lbPrecioCurso)
        Controls.Add(lbHorariosCurso)
        Controls.Add(lbCursos)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(btnDesinscribir)
        Controls.Add(btnCancelar)
        Controls.Add(btnGuardar)
        Controls.Add(btnInscribir)
        Name = "FormCursosElementos"
        Text = "Form2"
        GroupBox1.ResumeLayout(False)
        CType(dgvElementosDentro, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        CType(dgvElementosFuera, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvListadoCursos, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub


    Friend WithEvents btnInscribir As Button
    Friend WithEvents btnDesinscribir As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lbProfesorCurso As Label
    Friend WithEvents lbDiasCurso As Label
    Friend WithEvents lbPrecioCurso As Label
    Friend WithEvents lbHorariosCurso As Label
    Friend WithEvents lbCursos As Label
    Friend WithEvents cbOpciones As ComboBox
    Friend WithEvents dgvListadoCursos As DataGridView
    Friend WithEvents tbBuscar As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents dgvElementosFuera As DataGridView
    Friend WithEvents dgvElementosDentro As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lbDesinscripciones As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbInscripciones As Label
    Friend WithEvents tbMeses As TextBox
    Friend WithEvents btnReducirMeses As Button
    Friend WithEvents btnAumentarMeses As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
End Class
