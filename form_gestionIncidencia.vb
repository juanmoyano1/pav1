Public Class form_gestionIncidencia

    Private Sub form_gestionIncidencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargarCombosDeFiltros()
        Me.Width = 931
    End Sub

    'Carga de los TextBox de abajo de la grilla
    Private Sub dgv_incidencia_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_incidencia.CellClick
        cargarTxtBox(dgv_incidencia.CurrentRow.DataBoundItem)
    End Sub
    Private Sub cargarTxtBox(inc As Incidencia)
        txtbox_incidencia_nro.Text = inc.codIncidencia
        txtbox_incidencia_titulo.Text = inc.titulo
        txtbox_incidencia_descripcion.Text = inc.descripcion
    End Sub


    'Funcionamiento de los CheckBox para habilitar7deshabilitar filtros
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
    End Sub


    'Cargar la grilla de Incidencias
    Private Sub btn_incidencia_buscar_Click(sender As Object, e As EventArgs) Handles btn_incidencia_buscar.Click
        dgv_incidencia.DataSource = CapaNegocio_Incidencia.consultarIncidencias(cbox_incidencia_estado.Checked, _
                                                                                cmb_incidencia_estado.SelectedValue, _
                                                                                cbox_incidencia_prioridad.Checked, _
                                                                                Me.radioButtonSeleccionadoPrioridadFiltro, _
                                                                                cbox_incidencia_usuario.Checked, _
                                                                                cmb_incidencia_usuario.SelectedValue, _
                                                                                cbox_incidencia_area.Checked, _
                                                                                cmb_incidencia_usuario.SelectedValue)
    End Sub


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
    End Sub
    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Width = 931
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
        cargarCombosGenerico(cmb_incidencia_estado, CapaDatos_Incidencia.consultarEstado, "codEstado", "nombre")
        cargarCombosGenerico(cmb_incidencia_area, CapaDatos_Incidencia.consultarArea, "codArea", "nombre")
        cargarCombosGenerico(cmb_incidencia_usuario, CapaDatos_Incidencia.consultarUsuario, "codUsuario", "nombre")
    End Sub

End Class