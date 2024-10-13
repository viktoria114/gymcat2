Imports MySql.Data.MySqlClient

Public Class FormConsultas
    Private cmd As MySqlCommand
    Private tablaResultado As DataTable
    Private dataReader As MySqlDataReader
    Private miConexion As New MySqlConnection("Server=localhost; Database=gymcat; Uid=root; Pwd=;")
    Dim total As Integer = 0

    Private Sub FormConsultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ElegirConsulta()
    End Sub

    Private Sub rbMiembrosenCursos_CheckedChanged(sender As Object, e As EventArgs) Handles rbMiembrosenCursos.CheckedChanged
        ElegirConsulta()
    End Sub

    Private Sub rbMiembrosconDeudas_CheckedChanged(sender As Object, e As EventArgs) Handles rbMiembrosconDeudas.CheckedChanged
        ElegirConsulta()
    End Sub

    Private Sub rbMejoresMiembros_CheckedChanged(sender As Object, e As EventArgs) Handles rbMejoresMiembros.CheckedChanged
        ElegirConsulta()
    End Sub

    Private Sub rbElementosenCursos_CheckedChanged(sender As Object, e As EventArgs) Handles rbElementosenCursos.CheckedChanged
        ElegirConsulta()
    End Sub
    Private Sub rbBeneficioMensual_CheckedChanged(sender As Object, e As EventArgs) Handles rbBeneficioMensual.CheckedChanged
        ElegirConsulta()
    End Sub

    Sub ElegirConsulta()
        Dim CursoMiembro As Control() = {cbCurMiembro}
        Dim MembreVencer As Control() = {dtpMemb}
        Dim MejorMiem As Control() = {cbMejMiemb}
        Dim ElemenCurso As Control() = {cbCursos}
        Dim BenfMensual As Control() = {cbMesesBeneficios}

        For Each ctrl As Control In CursoMiembro.Concat(MembreVencer).Concat(MejorMiem).Concat(ElemenCurso).Concat(BenfMensual)
            ctrl.Enabled = False
        Next

        Select Case True
            Case rbMiembrosenCursos.Checked
                HabilitarControles(CursoMiembro)

            Case rbMiembrosconDeudas.Checked
                HabilitarControles(MembreVencer)

            Case rbMejoresMiembros.Checked
                HabilitarControles(MejorMiem)

            Case rbElementosenCursos.Checked
                HabilitarControles(ElemenCurso)

            Case rbBeneficioMensual.Checked
                HabilitarControles(BenfMensual)

            Case Else

        End Select
    End Sub

    Private Sub HabilitarControles(controles As Control())
        For Each ctrl As Control In controles
            ctrl.Enabled = True
        Next
    End Sub

    Private Sub btnEjecutar_Click(sender As Object, e As EventArgs) Handles btnEjecutar.Click
        miConexion.Open()
        cmd = New MySqlCommand

        Select Case True
            Case rbMiembrosenCursos.Checked
                cmd.CommandText = "
                SELECT
                    CONCAT(miembros.nombre, ' ', miembros.apellido) AS 'Nombre Completo',
                    miembros.edad,
                    miembros_cursos.fecha_inscripcion AS 'Fecha de Inscripción'
                FROM
                    miembros
                    INNER JOIN miembros_cursos ON miembros.ID_miembro = miembros_cursos.FK_miembros
                    INNER JOIN cursos ON cursos.ID_cursos = miembros_cursos.FK_cursos
                WHERE
                    cursos.nombre = @curso
                ORDER BY
                    miembros_cursos.ID_inscripción;"

                cmd.Parameters.AddWithValue("@curso", cbCurMiembro.Text)

            Case rbMiembrosconDeudas.Checked

                cmd.CommandText = "
                SELECT
                    m.nombre,
                    m.apellido,
                    m.deudor,
                    m.fecha_inscripcion AS 'Fecha de Inscripción',
                    DATE_ADD(m.fecha_inscripcion, INTERVAL m.duracion_membresia MONTH) AS 'fecha_vencimiento',
                    CASE WHEN DATE_ADD(m.fecha_inscripcion, INTERVAL m.duracion_membresia MONTH) < @fecha THEN 
                    'Membresia a vencer' ELSE 'Membresia al dia' END AS 'Estado Membresia'
                FROM
                    miembros m
                WHERE
                    m.deudor = 1
                    OR DATE_ADD(m.fecha_inscripcion, INTERVAL m.duracion_membresia MONTH) < @fecha
                ORDER BY DATE_ADD(m.fecha_inscripcion, INTERVAL m.duracion_membresia MONTH)
                    "

                cmd.Parameters.AddWithValue("@fecha", dtpMemb.Value.Date)

            Case rbMejoresMiembros.Checked

                cmd.CommandText = "
                 SELECT CONCAT(m.nombre, ' ', m.apellido) AS 'Nombre Completo', 
                    m.costo_total AS 'Monto', m.telefono, m.correo
                 FROM miembros m
                 ORDER BY Monto DESC
                 LIMIT @nro"


                cmd.Parameters.AddWithValue("@nro", Convert.ToInt32(cbMejMiemb.Text))

            Case rbElementosenCursos.Checked
                cmd.CommandText = "
                SELECT
                    cursos.nombre AS 'Cursos',
                    CONCAT(`elementos deportivos`.nombre, ' ', `elementos deportivos`.modelo) AS 'Elemento',
                    cursos.turno,
                    cursos.horario
                FROM
                    cursos, `elementos deportivos`, cursos_elementos_maquinas
                WHERE
                    `elementos deportivos`.ID_elementos_deportivos = cursos_elementos_maquinas.FK_elementos
                    AND cursos.ID_cursos = cursos_elementos_maquinas.FK_cursos
                    AND cursos.nombre = @curso
                ORDER BY
                    cursos.nombre;"

                cmd.Parameters.AddWithValue("@curso", cbCursos.Text)


            Case rbBeneficioMensual.Checked
                cmd.CommandText = "
                SELECT 
                    gastos.ID_gastos AS ID,
                    gastos.fecha_gasto AS fecha,
                    gastos.monto,
                    gastos.forma_pago,
                    gastos.concepto,
                    'Gasto' AS tipo
                FROM 
                    gastos 
                JOIN 
                    mes ON mes.numero_mes = MONTH(gastos.fecha_gasto)
                WHERE 
                    mes.mes = @mes
                    AND gastos.fecha_gasto >= DATE_FORMAT(CONCAT(YEAR(CURDATE()), '-', mes.numero_mes, '-01'), '%Y-%m-%d')
                    AND gastos.fecha_gasto < DATE_FORMAT(CONCAT(YEAR(CURDATE()), '-', mes.numero_mes + 1, '-01'), '%Y-%m-%d')

                UNION ALL

                SELECT 
                    ingresos.ID_ingresos AS ID,
                    ingresos.fecha_pago AS fecha,
                    ingresos.monto,
                    ingresos.forma_pago,
                    ingresos.concepto,
                    'Ingreso' AS tipo
                FROM 
                    ingresos
                JOIN 
                    mes ON mes.numero_mes = MONTH(ingresos.fecha_pago)
                WHERE 
                    mes.mes =  @mes
                    AND ingresos.fecha_pago >= DATE_FORMAT(CONCAT(YEAR(CURDATE()), '-', mes.numero_mes, '-01'), '%Y-%m-%d')
                    AND ingresos.fecha_pago < DATE_FORMAT(CONCAT(YEAR(CURDATE()), '-', mes.numero_mes + 1, '-01'), '%Y-%m-%d');
                                    "

                cmd.Parameters.AddWithValue("@mes", cbMesesBeneficios.Text)

                Dim consulta As String = "SELECT 
                    gastos.monto,
                    gastos.concepto,
                    'Gasto' AS tipo
                FROM 
                    gastos 
                JOIN 
                    mes ON mes.numero_mes = MONTH(gastos.fecha_gasto)
                WHERE 
                    mes.mes = @mes1
                    AND gastos.fecha_gasto >= DATE_FORMAT(CONCAT(YEAR(CURDATE()), '-', mes.numero_mes, '-01'), '%Y-%m-%d')
                    AND gastos.fecha_gasto < DATE_FORMAT(CONCAT(YEAR(CURDATE()), '-', mes.numero_mes + 1, '-01'), '%Y-%m-%d')

                UNION ALL

                SELECT 
                    ingresos.monto,
                    ingresos.concepto,
                    'Ingreso' AS tipo
                FROM 
                    ingresos
                JOIN 
                    mes ON mes.numero_mes = MONTH(ingresos.fecha_pago)
                WHERE 
                    mes.mes =  @mes1
                    AND ingresos.fecha_pago >= DATE_FORMAT(CONCAT(YEAR(CURDATE()), '-', mes.numero_mes, '-01'), '%Y-%m-%d')
                    AND ingresos.fecha_pago < DATE_FORMAT(CONCAT(YEAR(CURDATE()), '-', mes.numero_mes + 1, '-01'), '%Y-%m-%d');
                                    "

                Dim total As Double = 0

                Dim comando As New MySqlCommand(consulta, miConexion)
                comando.Parameters.AddWithValue("@mes1", cbMesesBeneficios.Text)
                Dim lector = comando.ExecuteReader

                While lector.Read()
                    Dim monto As Double = Convert.ToDouble(lector("monto"))
                    Dim tipo As String = lector("tipo").ToString()

                    If tipo = "Ingreso" Then
                            total += monto
                        ElseIf tipo = "Gasto" Then
                            total -= monto
                        End If
                End While
                tbBeneficios.Text = total

                lector.Close()

            Case Else

        End Select

        cmd.Connection = miConexion

        If tablaResultado Is Nothing Then
            tablaResultado = New DataTable
        Else
            tablaResultado.Clear()
            tablaResultado.Columns.Clear()
        End If

        dataReader = cmd.ExecuteReader

        If dataReader.HasRows Then

            tablaResultado.Load(dataReader)

        Else
            MsgBox("Consulta sin resultados")
        End If

        dataReader.Close()

        miConexion.Close()
        tbTotal.Text = tablaResultado.Rows.Count

        dgvResultados.DataSource = tablaResultado


    End Sub

    Sub CargarDatosForm()
        cbCurMiembro.Items.Clear()
        cbCursos.Items.Clear()
        cbMesesBeneficios.Items.Clear()

        miConexion.Open()
        Dim consulta = "SELECT nombre FROM cursos"
        Dim comando As New MySqlCommand(consulta, miConexion)
        Dim lector = comando.ExecuteReader

        If lector.HasRows Then
            While lector.Read()
                cbCurMiembro.Items.Add(lector("nombre"))
                cbCursos.Items.Add(lector("nombre"))
            End While
        End If
        lector.Close()
        miConexion.Close()

        miConexion.Open()
        Dim consulta1 = "SELECT mes FROM mes"
        Dim comando1 As New MySqlCommand(consulta1, miConexion)
        Dim lector1 = comando1.ExecuteReader

        If lector1.HasRows Then
            While lector1.Read()
                cbMesesBeneficios.Items.Add(lector1("mes"))

            End While
        End If
        lector1.Close()
        miConexion.Close()
    End Sub


End Class