Imports System.Data.Common
Imports System.Diagnostics.Eventing
Imports System.Net.Mail
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx
Public Class FormCursosElementos
	Private _Conexion As Conexion
	Public Tabla As String = "TCursos"
	Public Tabla2 As String = "TCursos_Elementos"
	Private lector As MySqlDataReader
	Private edicion As Boolean = False
	Private PrevFila As DataGridViewCell
	Private PopUp As FormPagopopup

	Private Sub FormCursosElementos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		lbDesinscripciones.Text = vbCrLf + "Desisncripciones:"
		cbOpciones.Text = "Nombre"
	End Sub

	Public Sub CargarDatosForm()
		Dim consulta As String = "SELECT ID_cursos, nombre AS Nombre, dias_clase AS 'Dias Clase', FK_empleados AS Maestro FROM cursos"
		Dim consulta2 As String = "SELECT * FROM miembros_cursos"

		_Conexion = New Conexion(consulta, consulta2, Tabla, Tabla2)
		_Conexion.GymcatDataSet.Tables.Add("TDentro")
		_Conexion.GymcatDataSet.Tables.Add("TNoDentro")
		dgvListadoCursos.DataSource = _Conexion.vistaDatos
		dgvListadoCursos.Columns(0).Visible = False
		dgvListadoCursos.CurrentCell = dgvListadoCursos.Rows(0).Cells(1)

		_Conexion.miConexion.Open()
		'SeleccionarMiembro(dgvListadoCursos.CurrentRow.Cells(0).Value)
		'ConfigurarComandos()
		'_Conexion.miConexion.close()
	End Sub

	Sub SeleccionarMiembro(IDMiembro As Integer)
		PrevFila = dgvListadoCursos.CurrentCell
		_Conexion.GymcatDataSet.Tables("TDentro").Clear()
		_Conexion.GymcatDataSet.Tables("TNoDentro").Clear()

		'Llenar la tabla de Cursos Inscritos del Miembro
		Dim ComandoIncritos As New MySqlCommand("SELECT cursos_elementos_maquinas.ID_cursos_elemtos, `elementos deportivos`.nombre AS 'Elemento', " +
												" FROM `elementos deportivos`, cursos_elementos_maquinas " +
												"WHERE cursos_elementos_maquinas.FK_elementos = `elementos deportivos`.`ID_elementos_deportivos` AND cursos_elementos_maquinas.FK_cursoss=@num", _Conexion.miConexion)
		ComandoIncritos.Parameters.AddWithValue("@num", IDMiembro)
		_Conexion.TablaDataAdapter.SelectCommand = ComandoIncritos
		_Conexion.TablaDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
		_Conexion.TablaDataAdapter.Fill(_Conexion.GymcatDataSet.Tables("TDentro"))
		dgvElementosDentro.DataSource = _Conexion.GymcatDataSet.Tables("TDentro").DefaultView

		'Llenar la tabla de Cursos a los que el miembro no esta Inscrito
		Dim ComandoNoInscritos As New MySqlCommand("Select ID_cursos_elemtos, nombre AS 'Elemento' FROM cursos Where ID_cursos_elementos " +
						"Not In (Select FK_elementos FROM miembros_cursos WHERE FK_cursos = @num)", _Conexion.miConexion)
		ComandoNoInscritos.Parameters.AddWithValue("@num", IDMiembro)
		_Conexion.TablaDataAdapter.SelectCommand = ComandoNoInscritos
		_Conexion.TablaDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
		_Conexion.TablaDataAdapter.Fill(_Conexion.GymcatDataSet.Tables("TNoDentro"))
		dgvElementosFuera.DataSource = _Conexion.GymcatDataSet.Tables("TNoDentro").DefaultView

		dgvElementosDentro.Columns(0).Visible = False
		dgvElementosFuera.Columns(0).Visible = False
		dgvElementosFuera.Columns(2).Visible = False


		dgvElementosDentro.ClearSelection()
		dgvElementosFuera.ClearSelection()
		btnInscribir.Enabled = False
		btnDesinscribir.Enabled = False
	End Sub

End Class