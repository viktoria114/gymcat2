﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrudElementos1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        dgvListadoElementos = New DataGridView()
        GroupBox2 = New GroupBox()
        PictureBox1 = New PictureBox()
        cbOpciones = New ComboBox()
        tbBuscar = New TextBox()
        btnAgregar = New Button()
        btnBorrar = New Button()
        btnEditar = New Button()
        Label1 = New Label()
        CType(dgvListadoElementos, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvListadoElementos
        ' 
        dgvListadoElementos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvListadoElementos.BackgroundColor = SystemColors.ButtonShadow
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = Color.Black
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgvListadoElementos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgvListadoElementos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvListadoElementos.DefaultCellStyle = DataGridViewCellStyle2
        dgvListadoElementos.Location = New Point(19, 64)
        dgvListadoElementos.MultiSelect = False
        dgvListadoElementos.Name = "dgvListadoElementos"
        dgvListadoElementos.ReadOnly = True
        DataGridViewCellStyle3.ForeColor = Color.Black
        dgvListadoElementos.RowsDefaultCellStyle = DataGridViewCellStyle3
        dgvListadoElementos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvListadoElementos.Size = New Size(751, 379)
        dgvListadoElementos.TabIndex = 3
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(PictureBox1)
        GroupBox2.Controls.Add(cbOpciones)
        GroupBox2.Controls.Add(tbBuscar)
        GroupBox2.Controls.Add(dgvListadoElementos)
        GroupBox2.Font = New Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox2.ForeColor = Color.White
        GroupBox2.Location = New Point(27, 158)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(788, 456)
        GroupBox2.TabIndex = 5
        GroupBox2.TabStop = False
        GroupBox2.Text = "Listado de Elementos y Máquinas"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.file
        PictureBox1.Location = New Point(16, 18)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(35, 38)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' cbOpciones
        ' 
        cbOpciones.DropDownStyle = ComboBoxStyle.DropDownList
        cbOpciones.FormattingEnabled = True
        cbOpciones.Items.AddRange(New Object() {"Nombre", "Modelo", "Precio", "Tipo", "Fecha de Compra", "Stock", "Marca", "Estado"})
        cbOpciones.Location = New Point(440, 27)
        cbOpciones.Name = "cbOpciones"
        cbOpciones.Size = New Size(214, 24)
        cbOpciones.TabIndex = 5
        ' 
        ' tbBuscar
        ' 
        tbBuscar.Location = New Point(60, 27)
        tbBuscar.Name = "tbBuscar"
        tbBuscar.Size = New Size(374, 21)
        tbBuscar.TabIndex = 4
        ' 
        ' btnAgregar
        ' 
        btnAgregar.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
        btnAgregar.FlatStyle = FlatStyle.Popup
        btnAgregar.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        btnAgregar.ForeColor = Color.WhiteSmoke
        btnAgregar.Image = My.Resources.Resources.icono_item_agregar
        btnAgregar.ImageAlign = ContentAlignment.MiddleRight
        btnAgregar.Location = New Point(27, 84)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New Size(101, 44)
        btnAgregar.TabIndex = 6
        btnAgregar.Text = "Agregar"
        btnAgregar.TextAlign = ContentAlignment.MiddleLeft
        btnAgregar.UseVisualStyleBackColor = False
        ' 
        ' btnBorrar
        ' 
        btnBorrar.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
        btnBorrar.FlatStyle = FlatStyle.Popup
        btnBorrar.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        btnBorrar.ForeColor = Color.White
        btnBorrar.Image = My.Resources.Resources.icono_item_eliminar
        btnBorrar.ImageAlign = ContentAlignment.MiddleRight
        btnBorrar.Location = New Point(241, 84)
        btnBorrar.Name = "btnBorrar"
        btnBorrar.Size = New Size(101, 44)
        btnBorrar.TabIndex = 7
        btnBorrar.Text = "Eliminar"
        btnBorrar.TextAlign = ContentAlignment.MiddleLeft
        btnBorrar.UseVisualStyleBackColor = False
        ' 
        ' btnEditar
        ' 
        btnEditar.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
        btnEditar.FlatStyle = FlatStyle.Popup
        btnEditar.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        btnEditar.ForeColor = Color.White
        btnEditar.Image = My.Resources.Resources.icono_item_editar
        btnEditar.ImageAlign = ContentAlignment.MiddleRight
        btnEditar.Location = New Point(134, 84)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(101, 44)
        btnEditar.TabIndex = 8
        btnEditar.Text = "Editar"
        btnEditar.TextAlign = ContentAlignment.MiddleLeft
        btnEditar.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cascadia Mono SemiBold", 20F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(27, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(335, 35)
        Label1.TabIndex = 11
        Label1.Text = "Elementos Deportivos"
        ' 
        ' CrudElementos1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(33), CByte(31), CByte(45))
        ClientSize = New Size(835, 626)
        Controls.Add(Label1)
        Controls.Add(btnEditar)
        Controls.Add(btnBorrar)
        Controls.Add(btnAgregar)
        Controls.Add(GroupBox2)
        Name = "CrudElementos1"
        Text = "CrudElementos1"
        CType(dgvListadoElementos, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Friend WithEvents dgvListadoElementos As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents tbBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbOpciones As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
