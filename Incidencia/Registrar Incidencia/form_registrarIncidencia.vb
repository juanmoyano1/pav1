Public Class form_registrarIncidencia

   
    'LOAD
    Private Sub form_registrarIncidencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.limpiarFormulario()
        Reg_Incidencia_Negocio.cargaComboArea(cmb_area)
        Reg_Incidencia_Negocio.cargaComboDispositivo(cmb_dispositivo)
        Reg_Incidencia_Negocio.cargarComboUsuario(cmb_usuario)
        dtp_fecha.Enabled = False
    End Sub

    'Conocer el id de la prioridad
    Private Function conocerPrioridad() As Integer

        If rbtn_regincidencia_alta.Checked Then
            Return 3
        ElseIf rbtn_regincidencia_media.Checked Then
            Return 2
        Else
            'Si no selecciona ninguna damos por hecho que es baja
            Return 1
        End If

    End Function

    'Limpiar los campos
    Private Sub limpiarFormulario()
        txb_nroIncidente.Text = Reg_Incidencia_Datos.conocerProximoId()
        rbtn_regincidencia_baja.Checked = True
        txb_descripcion.Text = String.Empty
        txb_titulo.Text = String.Empty
    End Sub

    'Principal, para cargar Incidencia
    Private Sub btn_enviar_Click(sender As Object, e As EventArgs) Handles btn_enviar.Click
        Try
            Dim oIncidencia As New Incidencia
            oIncidencia = Reg_Incidencia_Negocio.crearReg_Incidencia(cmb_usuario.SelectedValue, cmb_area.SelectedValue, cmb_dispositivo.SelectedValue, conocerPrioridad(), txb_titulo.Text, txb_descripcion.Text, dtp_fecha.Value)
            Reg_Incidencia_Negocio.guardarIncidencia(oIncidencia)
            MsgBox("Se guardo la incidencia exitosamente")
            Me.Refresh()

            Me.limpiarFormulario()

        Catch ex As Exception
            MsgBox("No se pudo registrar la incidencia")
        End Try
    End Sub

    'Mensaje de salida (aunque me parece que es innecesario)
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        If (MsgBox("¿ Esta seguro que desea Salir ?", MsgBoxStyle.YesNo) = 6) Then
            Close()
        End If
        Me.Close()
    End Sub


End Class