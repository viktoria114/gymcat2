﻿Public Class nuevoMiembro
    Private Sub nuevoMiembro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CrudMiembros._Conexion.esNuevo Then
            Me.Text = ("Nuevo Miembro")
            tbNombre.Text = ""
            tbApellido.Text = ""
            tbDNI.Text = ""
            tbEdad.Text = ""
            dtpInscripcion.Text = Today
            cbDuracMemb.Text = ""
            tbCostoTotal.Enabled = False
            tbTelef.Text = ""
            tbCorreo.Text = ""
            tbPuntos.Text = "0"
        Else
            Dim fila As DataGridViewRow = CrudMiembros.dgvListadoMiembros.CurrentRow
            Me.Text = ("Editar Miembro")
            CrudMiembros._Conexion.idFila = fila.Cells(0).Value
            tbNombre.Text = fila.Cells(2).Value
            tbApellido.Text = fila.Cells(3).Value
            tbDNI.Text = fila.Cells(1).Value
            tbEdad.Text = fila.Cells(4).Value
            dtpInscripcion.Text = fila.Cells(5).Value
            cbDuracMemb.Text = fila.Cells(6).Value
            tbCostoTotal.Text = fila.Cells(7).Value
            tbCostoTotal.Enabled = True
            cbDeudor.Checked = fila.Cells(8).Value
            tbTelef.Text = fila.Cells(9).Value
            tbCorreo.Text = fila.Cells(10).Value
            tbPuntos.Text = fila.Cells(11).Value
        End If


    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If CrudMiembros._Conexion.esNuevo Then
            tbCostoTotal.Text = CalcularCostoTotla()
        Else

        End If
        CrudMiembros.Guardar()
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Function CalcularCostoTotla() As Single
        If cbDuracMemb.Text < 3 Then
            Return 15000
        ElseIf cbDuracMemb.Text >= 3 And cbDuracMemb.Text < 12 Then
            Return 15000 * 0.85
        ElseIf cbDuracMemb.Text >= 12 Then
            Return 15000 * 0.7
        End If
    End Function

    Private Sub cbDuracMemb_TextChanged(sender As Object, e As EventArgs) Handles cbDuracMemb.TextChanged
        Dim columnaSeleccionada = cbDuracMemb.SelectedItem

        If columnaSeleccionada < 3 Then
            lbMensajeDescuento.Text = ""
            tbCostoTotal.Text = 15000
        ElseIf columnaSeleccionada >= 3 And columnaSeleccionada < 12 Then
            lbMensajeDescuento.Text = "Se va a aplicar un descuento" & vbCrLf & "del 15% a la cuota"
            tbCostoTotal.Text = 15000 * 0.85
        ElseIf columnaSeleccionada >= 12 Then
            lbMensajeDescuento.Text = "Se va a aplicar un descuento" & vbCrLf & "del 30% a la cuota"
            tbCostoTotal.Text = 15000 * 0.7
        End If

    End Sub
End Class

