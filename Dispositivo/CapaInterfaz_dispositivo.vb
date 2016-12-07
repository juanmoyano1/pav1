Imports System.Data.SqlClient

Public Class CapaInterfaz_dispositivo

    Private Sub CapaLogicaNegocio_dispositivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 485
        CapaLogicaNegocio_dispositivo.consultarDispositivo()
        cargarComboTipoDispositivo()
        cargarComboArea()

    End Sub


    Public Sub cargarComboTipoDispositivo()
        cmb_dispositivo_tipo.DataSource = BDHelper.getTipoDispositivo()
        cmb_dispositivo_tipo.ValueMember = "codTipo"
        cmb_dispositivo_tipo.DisplayMember = "descripcion"
        'La descripcion es el nombre del tipo de dispositivo
    End Sub

    Public Sub cargarComboArea()
        cmb_dispositivo_area.DataSource = BDHelper.getArea()
        cmb_dispositivo_area.ValueMember = "codArea"
        cmb_dispositivo_area.DisplayMember = "nombre"
    End Sub


    Private Sub btn_aceptar_dispositivo_Click(sender As Object, e As EventArgs) Handles btn_dispositivo_aceptar.Click
        'Si esta enabled la grilla es porque estoy creando un nuevo registro
        If datagrid_dispositivo.Enabled = True Then
            CapaLogicaNegocio_dispositivo.registrarDispositivo(txt_dispositivo_nombre.Text, txt_dispositivo_descripcion.Text, _
                                                               cmb_dispositivo_tipo.SelectedValue)
        Else
            'Si no esta enableada la grilla es porque estoy modificando un registro
            datagrid_dispositivo.Enabled = True
            CapaLogicaNegocio_dispositivo.modificarDispositivo(datagrid_dispositivo.CurrentRow.DataBoundItem)
        End If
        Me.Width = 485
        txt_dispositivo_descripcion.Clear()
        txt_dispositivo_nombre.Clear()
        CapaLogicaNegocio_dispositivo.consultarDispositivo()
    End Sub

    Private Sub btn_agregarTipoDispositivo_Click(sender As Object, e As EventArgs) Handles btn_dispositivo_agregarTipoDispositivo.Click
        CapaInterfaz_TipoDispositivo.Show()
    End Sub

    Private Sub btn_dispositivo_agregarArea_Click(sender As Object, e As EventArgs) Handles btn_dispositivo_agregarArea.Click
        CapaInterfaz_area.Show()
    End Sub

    Private Sub btn_dispositivo_Nuevo_Click(sender As Object, e As EventArgs) Handles btn_dispositivo_Nuevo.Click
        Me.Width = 722
    End Sub

    Private Sub btn_dispositivo_borrar_Click(sender As Object, e As EventArgs) Handles btn_dispositivo_borrar.Click
        CapaLogicaNegocio_dispositivo.eliminarDispositivo(datagrid_dispositivo.CurrentRow.DataBoundItem)
        CapaLogicaNegocio_dispositivo.consultarDispositivo()
    End Sub

    Private Sub btn_dispositivo_modificar_Click(sender As Object, e As EventArgs) Handles btn_dispositivo_modificar.Click
        Me.Width = 722
        datagrid_dispositivo.Enabled = False
        Dim objeto As Dispositivo = datagrid_dispositivo.CurrentRow.DataBoundItem
        txt_dispositivo_nombre.Text = objeto.nombre
        txt_dispositivo_descripcion.Text = objeto.descripcion
        cmb_dispositivo_tipo.SelectedValue = objeto.codTipo
    End Sub


    Private Sub btn_dispositivo_cerrar_Click(sender As Object, e As EventArgs) Handles btn_dispositivo_cerrar.Click
        Me.Close()
    End Sub

    Private Sub btn_dispositivo_cancelar_Click(sender As Object, e As EventArgs) Handles btn_dispositivo_cancelar.Click
        Me.datagrid_dispositivo.Enabled = True
        Me.Width = 485
        txt_dispositivo_descripcion.Clear()
        txt_dispositivo_nombre.Clear()
    End Sub

    

End Class