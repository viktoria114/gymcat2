<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCursospopup
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        tbNombreCurso = New TextBox()
        Label1 = New Label()
        tbPrecioCurso = New TextBox()
        tbDiasCurso = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        btnGuardar = New Button()
        btnCancelar = New Button()
        Label7 = New Label()
        tbIdProfesor = New TextBox()
        cbTurno = New ComboBox()
        cbDesde = New ComboBox()
        Label4 = New Label()
        Label8 = New Label()
        cbHasta = New ComboBox()
        SuspendLayout()
        ' 
        ' tbNombreCurso
        ' 
        tbNombreCurso.Location = New Point(193, 33)
        tbNombreCurso.Name = "tbNombreCurso"
        tbNombreCurso.Size = New Size(183, 23)
        tbNombreCurso.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        Label1.ForeColor = Color.WhiteSmoke
        Label1.Location = New Point(43, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(144, 17)
        Label1.TabIndex = 3
        Label1.Text = "Nombre del Curso:"
        ' 
        ' tbPrecioCurso
        ' 
        tbPrecioCurso.Location = New Point(193, 91)
        tbPrecioCurso.Name = "tbPrecioCurso"
        tbPrecioCurso.Size = New Size(183, 23)
        tbPrecioCurso.TabIndex = 5
        ' 
        ' tbDiasCurso
        ' 
        tbDiasCurso.Location = New Point(193, 122)
        tbDiasCurso.Name = "tbDiasCurso"
        tbDiasCurso.Size = New Size(183, 23)
        tbDiasCurso.TabIndex = 7
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        Label2.ForeColor = Color.WhiteSmoke
        Label2.Location = New Point(51, 63)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 17)
        Label2.TabIndex = 10
        Label2.Text = "Horarios:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        Label3.ForeColor = Color.WhiteSmoke
        Label3.Location = New Point(123, 92)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 17)
        Label3.TabIndex = 12
        Label3.Text = "Precio:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        Label5.ForeColor = Color.WhiteSmoke
        Label5.Location = New Point(59, 123)
        Label5.Name = "Label5"
        Label5.Size = New Size(128, 17)
        Label5.TabIndex = 13
        Label5.Text = "Dias de clases:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        Label6.ForeColor = Color.WhiteSmoke
        Label6.Location = New Point(131, 152)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 17)
        Label6.TabIndex = 15
        Label6.Text = "Turno:"
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
        btnGuardar.FlatStyle = FlatStyle.Popup
        btnGuardar.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        btnGuardar.ForeColor = Color.WhiteSmoke
        btnGuardar.ImageAlign = ContentAlignment.MiddleRight
        btnGuardar.Location = New Point(70, 234)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(91, 44)
        btnGuardar.TabIndex = 16
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' btnCancelar
        ' 
        btnCancelar.BackColor = Color.FromArgb(CByte(239), CByte(41), CByte(84))
        btnCancelar.FlatStyle = FlatStyle.Popup
        btnCancelar.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        btnCancelar.ForeColor = Color.WhiteSmoke
        btnCancelar.ImageAlign = ContentAlignment.MiddleRight
        btnCancelar.Location = New Point(241, 234)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(91, 44)
        btnCancelar.TabIndex = 17
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        Label7.ForeColor = Color.WhiteSmoke
        Label7.Location = New Point(51, 181)
        Label7.Name = "Label7"
        Label7.Size = New Size(136, 17)
        Label7.TabIndex = 19
        Label7.Text = "Id del Profesor:"
        ' 
        ' tbIdProfesor
        ' 
        tbIdProfesor.Location = New Point(193, 180)
        tbIdProfesor.Name = "tbIdProfesor"
        tbIdProfesor.Size = New Size(183, 23)
        tbIdProfesor.TabIndex = 18
        ' 
        ' cbTurno
        ' 
        cbTurno.DropDownStyle = ComboBoxStyle.DropDownList
        cbTurno.FormattingEnabled = True
        cbTurno.Items.AddRange(New Object() {"", "Mañana", "Tarde", "Noche"})
        cbTurno.Location = New Point(193, 151)
        cbTurno.Name = "cbTurno"
        cbTurno.Size = New Size(183, 23)
        cbTurno.TabIndex = 20
        ' 
        ' cbDesde
        ' 
        cbDesde.DropDownStyle = ComboBoxStyle.DropDownList
        cbDesde.FormattingEnabled = True
        cbDesde.Items.AddRange(New Object() {"", "0:00", "1:00", "2:00", "3:00", "4:00", "5:00", "6:00", "7:00", "8:00", "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00"})
        cbDesde.Location = New Point(193, 62)
        cbDesde.Name = "cbDesde"
        cbDesde.Size = New Size(57, 23)
        cbDesde.TabIndex = 21
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        Label4.ForeColor = Color.WhiteSmoke
        Label4.Location = New Point(131, 63)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 17)
        Label4.TabIndex = 23
        Label4.Text = "Desde:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold)
        Label8.ForeColor = Color.WhiteSmoke
        Label8.Location = New Point(256, 63)
        Label8.Name = "Label8"
        Label8.Size = New Size(56, 17)
        Label8.TabIndex = 24
        Label8.Text = "Hasta:"
        ' 
        ' cbHasta
        ' 
        cbHasta.DropDownStyle = ComboBoxStyle.DropDownList
        cbHasta.FormattingEnabled = True
        cbHasta.Items.AddRange(New Object() {"", "0:00", "1:00", "2:00", "3:00", "4:00", "5:00", "6:00", "7:00", "8:00", "9:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00"})
        cbHasta.Location = New Point(318, 61)
        cbHasta.Name = "cbHasta"
        cbHasta.Size = New Size(57, 23)
        cbHasta.TabIndex = 25
        ' 
        ' FormCursospopup
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(33), CByte(31), CByte(45))
        ClientSize = New Size(401, 319)
        Controls.Add(cbHasta)
        Controls.Add(Label8)
        Controls.Add(Label4)
        Controls.Add(cbDesde)
        Controls.Add(cbTurno)
        Controls.Add(Label7)
        Controls.Add(tbIdProfesor)
        Controls.Add(btnCancelar)
        Controls.Add(btnGuardar)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(tbDiasCurso)
        Controls.Add(tbPrecioCurso)
        Controls.Add(Label1)
        Controls.Add(tbNombreCurso)
        Name = "FormCursospopup"
        Text = "FormCursospopup"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents tbNombreCurso As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbPrecioCurso As TextBox
    Friend WithEvents tbDiasCurso As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents tbIdProfesor As TextBox
    Friend WithEvents cbTurno As ComboBox
    Friend WithEvents cbDesde As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cbHasta As ComboBox
End Class
