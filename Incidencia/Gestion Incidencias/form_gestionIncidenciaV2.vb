Public Class form_gestionIncidenciaV2


    Private Sub form_gestionIncidencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargarCombosDeFiltros()
        Me.Width = 927
        btn_asignarUsuarioEncargado.Enabled = False
        dtp_fechaActual.Enabled = False
    End Sub

    'Carga de los TextBox de abajo de la grilla y manejo de los clics de la grilla
    Private Sub dgv_incidencia_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_incidencia.CellClick
        cargarTxtBox(dgv_incidencia.CurrentRow.DataBoundItem)
        btn_nuevoDetalle.Enabled = True
        btn_asignarUsuarioEncargado.Enabled = True
        btn_consultarDetalle.Enabled = True
    End Sub
    Private Sub cargarTxtBox(inc As Incidencia)
        txtbox_incidencia_nro.Text = inc.codIncidencia
        txtbox_incidencia_titulo.Text = inc.titulo
        txtbox_incidencia_descripcion.Text = inc.descripcion
    End Sub


    'Funcionamiento de los CheckBox para habilitar deshabilitar filtros
    Private Sub cbox_incidencia_area_CheckedChanged(sender As Object, e As EventArgs) Handles cbox_incidencia_area.CheckedChanged
        habilitarFiltro(cbox_incidencia_area.Checked, lbl_incidencia_area, cmb_incidencia_area)
    End Sub
    Private Sub cbox_incidencia_prioridad_CheckedChanged(sender As Object, e As EventArgs) Handles cbox_incidencia_prioridad.CheckedChanged
        lbl_incidencia_prioridad.Enabled = cbox_incidencia_prioridad.Checked

        If chk_prioridad.Checked Then
            chk_prioridad.Checked = False
        End If

        rbtn_incidencia_prioridad_baja.Enabled = cbox_incidencia_prioridad.Checked
        rbtn_incidencia_prioridad_media.Enabled = cbox_incidencia_prioridad.Checked
        rbtn_incidencia_prioridad_alta.Enabled = cbox_incidencia_prioridad.Checked
    End Sub
    Private Sub cbox_incidencia_estado_CheckedChanged(sender As Object, e As EventArgs) Handles cbox_incidencia_estado.CheckedChanged
        habilitarFiltro(cbox_incidencia_estado.Checked, lbl_incidencia_estado, cmb_incidencia_estado)
    End Sub
    Private Sub cbox_incidencia_usuario_CheckedChanged(sender As Object, e As EventArgs) Handles cbox_incidencia_usuario.CheckedChanged
        habilitarFiltro(cbox_incidencia_usuario.Checked, lbl_incidencia_usuario, cmb_incidencia_usuario)
    End Sub
    Private Sub habilitarFiltro(bandera As Boolean, lbl As Label, cmb As ComboBox)
        lbl.Enabled = bandera
        cmb.Enabled = bandera
        If bandera = False Then
            cmb.Text = String.Empty
        End If
    End Sub


    'Boton limpiar (usa el cambio del CheckBox para reutilizar los metodos de click)
    Private Sub btn_incidencia_limpiar_Click(sender As Object, e As EventArgs) Handles btn_incidencia_limpiar.Click
        cbox_incidencia_area.Checked = False
        cbox_incidencia_estado.Checked = False
        cbox_incidencia_prioridad.Checked = False
        rbtn_incidencia_prioridad_alta.Checked = False
        rbtn_incidencia_prioridad_media.Checked = False
        rbtn_incidencia_prioridad_baja.Checked = False
        cbox_incidencia_usuario.Checked = False
        txtbox_incidencia_descripcion.Text = String.Empty
        txtbox_incidencia_titulo.Text = String.Empty
        txtbox_incidencia_nro.Text = String.Empty
        dgv_incidencia.ClearSelection()
        btn_nuevoDetalle.Enabled = False
    End Sub

    'Cargar la grilla de Incidencias
    Private Sub btn_incidencia_buscar_Click(sender As Object, e As EventArgs) Handles scr_GestionIncidentes.Click
        cargarGrilla()
    End Sub

    Private Sub cargarGrilla()
        dgv_incidencia.DataSource = CapaNegocio_Incidencia.consultarIncidencias(cbox_incidencia_estado.Checked, _
                                                                               cmb_incidencia_estado.SelectedValue, _
                                                                               cbox_incidencia_prioridad.Checked, _
                                                                               Me.radioButtonSeleccionadoPrioridadFiltro, _
                                                                               cbox_incidencia_usuario.Checked, _
                                                                               cmb_incidencia_usuario.SelectedValue, _
                                                                               cbox_incidencia_area.Checked, _
                                                                               cmb_incidencia_area.SelectedValue)
        btn_nuevoDetalle.Enabled = False
    End Sub

    'Buscar el numero de la prioridad seleccionada
    Private Function radioButtonSeleccionadoPrioridadFiltro()
        If cbox_incidencia_prioridad.Checked Then
            If rbtn_incidencia_prioridad_baja.Checked Then
                Return 1
            End If
            If rbtn_incidencia_prioridad_media.Checked Then
                Return 2
            End If
            If rbtn_incidencia_prioridad_alta.Checked Then
                Return 3
            End If
        Else
            Return 0
        End If
        Return 0
    End Function


    'Agrandar/Achicar ventana para cear o no un nuevo detalle
    Private Sub btn_nuevoDetalle_Click(sender As Object, e As EventArgs) Handles btn_nuevoDetalle.Click
        Me.Width = 1251
        'lbl_fechaActual.Text = DateTime.Now

        dgv_incidencia.Enabled = False
        scr_GestionIncidentes.Enabled = False
        btn_incidencia_limpiar.Enabled = False
        Dim inc As Incidencia
        inc = dgv_incidencia.CurrentRow.DataBoundItem
        txt_nroOrden.Text = CapaDatos_Incidencia.conocerProxNroOrden(inc.codIncidencia)

    End Sub
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Width = 927
        dgv_incidencia.Enabled = True
        scr_GestionIncidentes.Enabled = True
        btn_incidencia_limpiar.Enabled = True
    End Sub

    'Manejo de los CheckBox de prioridad de nuevo detalle y del filtro
    Private Sub chk_prioridad_CheckedChanged(sender As Object, e As EventArgs) Handles chk_prioridad.CheckedChanged

        rbtn_detalle_baja.Enabled = chk_prioridad.Checked
        rbtn_detalle_media.Enabled = chk_prioridad.Checked
        rbtn_detalle_alta.Enabled = chk_prioridad.Checked
        If cbox_incidencia_prioridad.Checked Then
            cbox_incidencia_prioridad.Checked = False
        End If
    End Sub
    Private Sub chk_estado_CheckedChanged(sender As Object, e As EventArgs) Handles chk_estado.CheckedChanged
        cmb_estado.Enabled = chk_estado.Checked
    End Sub
    'Cargar los combos
    Private Sub cargarCombosGenerico(combo As ComboBox, tabla As DataTable, pk As String, paraMostrar As String)
        combo.DataSource = tabla
        combo.ValueMember = pk
        combo.DisplayMember = paraMostrar
    End Sub

    Private Sub cargarCombosDeFiltros()
        cargarCombosGenerico(cmb_estado, CapaDatos_Incidencia.consultarEstado, "codEstado", "nombre")
        cargarCombosGenerico(cmb_incidencia_estado, CapaDatos_Incidencia.consultarEstado, "codEstado", "nombre")
        cargarCombosGenerico(cmb_incidencia_area, CapaDatos_Incidencia.consultarArea, "codArea", "nombre")
        cargarCombosGenerico(cmb_incidencia_usuario, CapaDatos_Incidencia.consultarUsuario, "legajo", "nombre")
    End Sub

    Private Sub pasarDatosDetalleTransaccion()

        CapaNegocio_Incidencia.registrarDetalleTransaccionNEGOCIO(txt_nroOrden.Text, txb_titulo.Text, cmb_estado.SelectedValue, _
                                                              obtenerPrioridadDetalle(), txb_descripcion.Text, _
                                                              txb_duracion.Text, txtbox_incidencia_nro.Text, dtp_fechaActual.Value)

    End Sub

    Private Function obtenerPrioridadDetalle() As Integer
        If rbtn_detalle_alta.Checked Then
            Return 3
        ElseIf rbtn_detalle_media.Checked Then
            Return 2
        Else
            Return 1
        End If
    End Function


    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        pasarDatosDetalleTransaccion()
    End Sub

    Private Sub btn_consultarDetalle_Click(sender As Object, e As EventArgs) Handles btn_consultarDetalle.Click
        Dim inc As Incidencia
        inc = dgv_incidencia.CurrentRow.DataBoundItem

        dgv_detalle.DataSource = CapaNegocio_Incidencia.consultarDetallesIncidencia(inc)
    End Sub

    Private Sub btn_asignarUsuarioEncargado_Click(sender As Object, e As EventArgs) Handles btn_asignarUsuarioEncargado.Click
        form_gestionIncidencia_agregarEncargado.ShowDialog()
    End Sub
 
End Class