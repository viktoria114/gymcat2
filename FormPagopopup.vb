Imports System.Reflection.Metadata
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational


Imports System.Data.Common
Imports System.Globalization
Imports iText.IO.Font.Constants
Imports iText.IO.Image
Imports iText.Kernel.Colors
Imports iText.Kernel.Font
Imports iText.Kernel.Pdf
Imports iText.Kernel.Pdf.Canvas.Draw
Imports iText.Layout
Imports iText.Layout.Element
Imports iText.Layout.Properties
Imports DocumentFormat.OpenXml.Vml
Imports Org.BouncyCastle.Asn1.Cmp


Public Class FormPagopopup

	Private _Conexion As Conexion
	Private Modo As String
	Private ListaInscripciones As New List(Of Curso_Pago)
	Private miConexion As New MySqlConnection("Server=localhost; Database=gymcat; Uid=root; Pwd=;")
	Private Nombre_Miembro As String
	Private DNI_Miembro As String
	Private Correo_Miembro As String
	Private Tabla As String
	Private total As Decimal
	Public TablaDataAdapter As MySqlDataAdapter
	Public GymcatDataSet As DataSet
	Public IDMovActual As Integer
	Public IdMiembro As Integer
	Public TipoMov As String
	Public NomCompleto As String

	Public Sub New(DNI_miembro1 As Integer, modo1 As String) 'CONSTRUCTOR PARA CUOTA Y MEMBRESIA
		InitializeComponent()
		Modo = modo1
		DNI_Miembro = DNI_miembro1
	End Sub

	Public Sub New(TipoMov1 As String)
		InitializeComponent()
		Modo = "Generico"
		btnPagar.Text = "Guardar"
		If TipoMov1 = "Ingresos" Then
			TipoMov = "Ingreso"
			If FormFinanzas._Conexion.esNuevo Then
				Me.Text = ("Nuevo Ingreso")
				dtpFechaMov.Text = ""
				cbFormaPago.Text = ""
				total = 0
				tbConcepto.Text = ""
				'fila("concepto") = modo + DNI_Miembro + " por " + cbMeses.Text + " mes/es"
			Else
				Dim fila As DataGridViewRow = FormFinanzas.dgvListadoFinanzas.CurrentRow
				Me.Text = ("Editar Empleado")
				FormFinanzas._Conexion.idFila = fila.Cells(0).Value
				dtpFechaMov.Text = fila.Cells(1).Value
				cbFormaPago.Text = fila.Cells(2).Value
				tbMonto.Text = fila.Cells(3).Value.ToString()
				tbConcepto.Text = fila.Cells(4).Value
			End If
		End If
		If TipoMov1 = "Egresos" Then
			TipoMov = "Egreso"
			If FormFinanzas._Conexion.esNuevo Then
				Me.Text = ("Nuevo Gasto")
				dtpFechaMov.Text = ""
				cbFormaPago.Text = ""
				total = 0
				tbConcepto.Text = ""
				'fila("concepto") = modo + DNI_Miembro + " por " + cbMeses.Text + " mes/es"
			Else
				Dim fila As DataGridViewRow = FormFinanzas.dgvListadoFinanzas.CurrentRow
				Me.Text = ("Editar Egreso")
				FormFinanzas._Conexion.idFila = fila.Cells(0).Value
				dtpFechaMov.Text = fila.Cells(1).Value
				tbMonto.Text = fila.Cells(2).Value.ToString()
				cbFormaPago.Text = fila.Cells(3).Value
				tbConcepto.Text = fila.Cells(4).Value
			End If
		End If
	End Sub

	Public Sub New(Lista As List(Of Curso_Pago), dni As String)
		InitializeComponent()
		DNI_Miembro = dni
		For Each n As Curso_Pago In Lista
			ListaInscripciones.Add(New Curso_Pago(n.ID_Curso, n.Nombre, n.Precio, n.Meses))
		Next
		Modo = "Inscripcion"
		Me.Width = 500
		Me.Height = 400
	End Sub


	Private Sub FormPagopopup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		gbInfoPago.Height = 83
		_Conexion = New Conexion()
		_Conexion.miConexion.Open()
		Dim comando As New MySqlCommand("SELECT * FROM ingresos order by ID_ingresos DESC", _Conexion.miConexion)

		Dim lector = comando.ExecuteReader
		lector.Read()
		IDMovActual = lector("ID_ingresos") + 1
		lector.Close()

		Dim comando1 As New MySqlCommand("SELECT * FROM miembros WHERE dni = @dni", _Conexion.miConexion)
		comando1.Parameters.AddWithValue("@dni", DNI_Miembro)

		Dim lector1 = comando1.ExecuteReader
		lector1.Read()
		If lector1.HasRows Then
			IdMiembro = lector1("ID_miembro")
			NomCompleto = lector1("nombre") + " " + lector1("apellido") + ", " + lector1("DNI").ToString
		End If
		lector1.Close()
		Me.Width = 930
		Me.Height = 585
		'gbInfoPago.Height = 103
		'btnPagar.Location = New Point(446, 483)
		'btnImprimir.Location = New Point(566, 483)
		'Me.Height = 626
		'Me.Width = 969
		'PanelBotones.Height = 455

		Select Case Modo
			Case "Cuota"
				lbTitulo.Text = "Couta de Miembro, ID " + IDMovActual.ToString

				cbMiembros.Enabled = False
				dtpFechaMov.Text = Today
				cbMiembros.Text = NomCompleto

				Cuota()

				'cbMiembros.Items.Clear()

				'miConexion.Open()
				'_Conexion.TablaDataAdapter = New MySqlDataAdapter()
				'_Conexion.TablaDataAdapter.SelectCommand = New MySqlCommand("SELECT ID_miembro,CONCAT(nombre,' ',apellido,' - ',DNI) AS 'Nmiembro',edad,fecha_inscripcion,duracion_membresia FROM miembros", miConexion)

				'_Conexion.GymcatDataSet = New DataSet()
				'_Conexion.GymcatDataSet.Tables.Add("TMiembros")
				'_Conexion.TablaDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
				'_Conexion.TablaDataAdapter.Fill(_Conexion.GymcatDataSet.Tables("TMiembros"))

				'cbMiembros.DataSource = _Conexion.GymcatDataSet.Tables("TMiembros").DefaultView
				'cbMiembros.DisplayMember = "Nmiembro"
				'cbMiembros.ValueMember = "ID_miembro"

			Case "Inscripcion"
				gbInfoMiembro.Hide()

				cbMiembros.Text = NomCompleto
				cbMiembros.Enabled = False

				lbTitulo.Text = "Inscripción a Cursos, ID " + IDMovActual.ToString


			Case "Membresia"

				gbInfoMiembro.Hide()

				lbTitulo.Text = "Membresia de nuevo Miembro, ID " + IDMovActual.ToString
				lector.Close()
				dtpFechaMov.Enabled = False
				dtpFechaMov.Text = nuevoMiembro.dtpInscripcion.Text
				cbMiembros.Text = nuevoMiembro.tbNombre.Text + " " + nuevoMiembro.tbApellido.Text + ", " + nuevoMiembro.tbDNI.Text
				cbMiembros.Enabled = False

				cbMeses.Text = nuevoMiembro.cbDuracMemb.Text
				cbMeses.Enabled = False

			Case "Generico"
				Me.Width = 500
				Me.Height = 400
				gbInfoPago.Height = 151
				gbInfoMiembro.Hide()
				PanelSelectorMiembro.Hide()
				PanelMeses.Hide()
				Label7.Hide()
				dgvFactura.Hide()
				'If TipoMov = "Ingreso" Then
				'	btnPagar.Location = New Point(62, 6)
				'ElseIf TipoMov = "Egreso" Then
				'	btnPagar.Location = New Point(165, 6)
				'End If
				'btnPagar.Location = New Point(82, 314)
				'btnImprimir.Location = New Point(214, 314)
				'Me.Height = 478
				'Me.Width = 475
				'PanelBotones.Height = 190

				lbTitulo.Text = "Nuevo " + TipoMov + ", ID " + IDMovActual.ToString
		End Select


		miConexion.Close()



	End Sub

	Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click

		Select Case Modo
			Case "Generico"
				If TipoMov = "Ingreso" Then
					FormFinanzas.GuardarIngresos()
				ElseIf TipoMov = "Egreso" Then
					FormFinanzas.GuardarEgresos()
				End If
				Me.Close()
			Case "Cuota"
				If cbMeses.Text = "" Then
					MsgBox("Elegir cantidad de meses!")
				Else
					ActualizarIngresos("Cuota de Miembro")

					Dim comando2 As New MySqlCommand("SELECT * FROM miembros WHERE dni = @dni", _Conexion.miConexion)
					comando2.Parameters.AddWithValue("@dni", DNI_Miembro)

					_Conexion.miConexion.Open()

					Dim lector2 = comando2.ExecuteReader
					lector2.Read()
					Dim durmem As Integer = lector2("duracion_membresia") + cbMeses.Text

					_Conexion.miConexion.Close()

					Dim comando3 As New MySqlCommand("UPDATE miembros SET duracion_membresia = @mem WHERE dni = @dni", _Conexion.miConexion)
					comando3.Parameters.AddWithValue("@dni", DNI_Miembro)
					comando3.Parameters.AddWithValue("@mem", durmem)

					_Conexion.miConexion.Open()
					comando3.ExecuteNonQuery()
					_Conexion.miConexion.Close()

					Me.Close()
					FormFinanzas.actualizardvg()
					actualizarMiembroMesIngreso()

				End If

			Case "Inscripcion"
				If cbMeses.Text = "" Then
					MsgBox("Elegir cantidad de meses!")
				Else

					ActualizarIngresos("Inscripción a Cursos")
					Me.Close()
					FormFinanzas.actualizardvg()
					actualizarMiembroMesIngreso()
				End If


			Case "Membresia"
				If cbMeses.Text = "" Then
					MsgBox("Elegir cantidad de meses!")
				Else

					ActualizarIngresos("Membresia de nuevo Miembro")
					Me.Close()
					FormFinanzas.actualizardvg()
					actualizarMiembroMesIngreso()
				End If
		End Select


	End Sub

	Private Sub Cuota()
		tbIDUltimoPago.Text = ""
		dtpUltimoPago.Text = ""
		cbDeudor.Checked = False
		dtpVencimiento.Text = ""

		tbIDUltimoPago.Enabled = False
		dtpUltimoPago.Enabled = False
		cbDeudor.Enabled = False
		dtpVencimiento.Enabled = False

		If miConexion.State = ConnectionState.Closed Then
			miConexion.Open()
		End If

		Dim consulta = "SELECT *, DATE_ADD(m.fecha_inscripcion, INTERVAL m.duracion_membresia MONTH) AS 'fecha_vencimiento'
		FROM miembros_mes_ingresos mi, miembros m, ingresos i WHERE m.ID_miembro = mi.FK_miembros
		AND i.ID_ingresos = mi.FK_ingresos AND m.DNI = @DNI AND i.fecha_pago = (SELECT MAX(i2.fecha_pago) FROM ingresos i2 
		JOIN miembros_mes_ingresos mi2 ON i2.ID_ingresos = mi2.FK_ingresos WHERE mi2.FK_miembros = m.ID_miembro);"
		Dim comando As New MySqlCommand(consulta, miConexion)
		comando.Parameters.AddWithValue("@DNI", DNI_Miembro)

		Dim lector = comando.ExecuteReader()

		While lector.Read
			If lector.HasRows Then
				tbIDUltimoPago.Text = lector("ID_ingresos")
				dtpUltimoPago.Text = lector("fecha_pago")
				cbDeudor.Checked = Convert.ToBoolean(lector("deudor"))
				dtpVencimiento.Text = lector("fecha_vencimiento")
				Nombre_Miembro = lector("nombre") + " " + lector("apellido")
				'DNI_Miembro = lector("DNI")
				Correo_Miembro = lector("correo")
			Else
				MsgBox("No se encontraron datos.")
			End If

		End While
		lector.Close()
		miConexion.Close()
	End Sub

	Private Sub cbMeses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMeses.SelectedIndexChanged
		dgvFactura.Rows.Clear()

		Dim precio As Integer = 15000 * cbMeses.Text

		Dim n = dgvFactura.Rows.Add

		total = 0

		Select Case Modo

			Case "Membresia"
				dgvFactura.Rows(n).Cells(0).Value = "Membresia"
				dgvFactura.Rows(n).Cells(1).Value = nuevoMiembro.tbCostoTotal.Text.ToString
				dgvFactura.Rows(n).Cells(2).Value = "*" + cbMeses.Text + " mes/es"
				total = nuevoMiembro.tbCostoTotal.Text * cbMeses.Text
			Case "Cuota"
				dgvFactura.Rows(n).Cells(0).Value = "Membresia"
				dgvFactura.Rows(n).Cells(1).Value = precio.ToString
				dgvFactura.Rows(n).Cells(2).Value = "*" + cbMeses.Text + " mes/es"

				cursos()

				miConexion.Open()
				Dim comando As New MySqlCommand("SELECT costo_total FROM miembros
					WHERE miembros.DNI = @dni
                                        ", _Conexion.miConexion)
				comando.Parameters.AddWithValue("@dni", DNI_Miembro)

				Dim lector = comando.ExecuteReader
				lector.Read()

				total = lector("costo_total") * cbMeses.Text

				lector.Close()
				miConexion.Close()
			Case "Inscripcion"
				cursosapagar(FormInscripciones.cursoactual)



		End Select


		dgvFactura.Rows.Add()
		n = dgvFactura.Rows.Add
		dgvFactura.Rows(n).Cells(0).Value = "Total"
		dgvFactura.Rows(n).Cells(1).Value = total * cbMeses.Text
		dgvFactura.Rows(n).Cells(2).Value = "*" + cbMeses.Text + " mes/es"



	End Sub

	Sub cursos()
		miConexion.Open()
		Dim comando As New MySqlCommand("SELECT cursos.nombre, cursos.precio FROM miembros
					INNER JOIN miembros_cursos ON miembros.ID_miembro = miembros_cursos.FK_miembros
                    INNER JOIN cursos ON cursos.ID_cursos = miembros_cursos.FK_cursos
					WHERE miembros.DNI = @dni
                                        ", _Conexion.miConexion)
		comando.Parameters.AddWithValue("@dni", DNI_Miembro)

		Dim lector = comando.ExecuteReader
		Dim precio As Integer

		If lector.HasRows Then

			While lector.Read()
				Dim n As Integer = dgvFactura.Rows.Add()
				dgvFactura.Rows(n).Cells(0).Value = lector("nombre")
				precio = lector("precio") * cbMeses.Text
				dgvFactura.Rows(n).Cells(1).Value = precio.ToString
				dgvFactura.Rows(n).Cells(2).Value = "*" + cbMeses.Text + " mes/es"
			End While
		End If

		lector.Close()
		miConexion.Close()
	End Sub

	Sub ActualizarIngresos(modo As String)
		Tabla = "TIngresos"
		Dim consulta As String = "SELECT * FROM ingresos"

		_Conexion = New Conexion(consulta, Tabla)

		Dim fila As DataRow
		Dim cmd As String

		'1. Crear una nueva fila 
		fila = _Conexion.GymcatDataSet.Tables(Tabla).NewRow
		'2. Rellenar la fila con información
		fila("fecha_pago") = dtpFechaMov.Text
		fila("forma_pago") = cbFormaPago.Text
		fila("monto") = total
		fila("concepto") = modo + DNI_Miembro + " por " + cbMeses.Text + " mes/es"

		'3. Agregar fila a la tabla del DataSet
		_Conexion.GymcatDataSet.Tables(Tabla).Rows.Add(fila)

		'4. Crear Comando para agregar a la BD la fila nueva cmd
		cmd = "INSERT INTO ingresos (fecha_pago, forma_pago, monto, concepto) VALUES (@fecha, @forma, @mon, @con)"
		_Conexion.TablaDataAdapter.InsertCommand = New MySqlCommand(cmd, _Conexion.miConexion)
		_Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@fecha", MySqlDbType.Date, 20, "fecha_pago")
		_Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@forma", MySqlDbType.VarChar, 20, "forma_pago")
		_Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@mon", MySqlDbType.Int32, 50, "monto")
		_Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@con", MySqlDbType.VarChar, 250, "concepto")

		'5. Guardar los cambios en la base de datos
		_Conexion.TablaDataAdapter.Update(_Conexion.GymcatDataSet.Tables(Tabla))
	End Sub

	Sub actualizarMiembroMesIngreso()
		Dim mesactual As Integer
		Dim mesNombre As String = Format(Now, "MMMM")

		' Crea el comando con la consulta SQL y el parámetro
		Dim comando As New MySqlCommand("SELECT ID_mes FROM mes WHERE mes = @mes", _Conexion.miConexion)
		comando.Parameters.AddWithValue("@mes", mesNombre)

		_Conexion.miConexion.Open()
		Dim lector1 = comando.ExecuteReader()

		' Verifica si se encontraron filas
		If lector1.Read() Then
			mesactual = lector1("ID_mes") ' Obtiene el ID del mes
		Else
			MsgBox("No se encontró el mes actual en la base de datos.")
		End If

		lector1.Close()
		_Conexion.miConexion.Close()


		Tabla = "TMiembroMesIngreso"
		_Conexion = New Conexion("SELECT * FROM miembros_mes_ingresos", Tabla)

		Dim fila As DataRow
		Dim cmd As String

		fila = _Conexion.GymcatDataSet.Tables(Tabla).NewRow
		fila("FK_miembros") = IdMiembro
		fila("FK_mes") = mesactual
		fila("FK_ingresos") = IDMovActual

		_Conexion.GymcatDataSet.Tables(Tabla).Rows.Add(fila)

		cmd = "INSERT INTO miembros_mes_ingresos (FK_miembros, FK_mes, FK_ingresos) VALUES (@miem, @mes, @ing)"
		_Conexion.TablaDataAdapter.InsertCommand = New MySqlCommand(cmd, _Conexion.miConexion)
		_Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@miem", MySqlDbType.Int32, 20, "FK_miembros")
		_Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@mes", MySqlDbType.Int32, 20, "FK_mes")
		_Conexion.TablaDataAdapter.InsertCommand.Parameters.Add("@ing", MySqlDbType.Int32, 20, "FK_ingresos")

		_Conexion.TablaDataAdapter.Update(_Conexion.GymcatDataSet.Tables(Tabla))
	End Sub

	Public Sub cursosapagar(curso)
		miConexion.Open()
		Dim comando As New MySqlCommand("SELECT * FROM cursos
 c where " + FormInscripciones.ListCursos, _Conexion.miConexion)

		Dim lector = comando.ExecuteReader

		If lector.HasRows Then
			While lector.Read()
				Dim n As Integer = dgvFactura.Rows.Add()
				dgvFactura.Rows(n).Cells(0).Value = lector("nombre")
				dgvFactura.Rows(n).Cells(1).Value = lector("precio") * cbMeses.Text
				dgvFactura.Rows(n).Cells(2).Value = "*" + cbMeses.Text + " mes/es"
				total += lector("precio")
			End While
		End If

		lector.Close()
		miConexion.Close()

	End Sub


End Class