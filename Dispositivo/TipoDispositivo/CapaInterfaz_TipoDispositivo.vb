Public Class CapaInterfaz_TipoDispositivo

    Private Sub btn_aceptar_tipoDispositivo_Click(sender As Object, e As EventArgs) Handles btn_agregar_tipoDispositivo.Click
        agregarNuevoTipoDipositivo()
        CapaLogicaNegocio_TIpoDispositivo.consultarTipoDispositivo()
    End Sub

    Private Sub agregarNuevoTipoDipositivo()
        BDHelper.setTipoDispositivo(txt_tipoDispositivo.Text)
    End Sub

    Private Sub lbl_nombreTipoDipositivo_Click(sender As Object, e As EventArgs) Handles lbl_nombreTipoDipositivo.Click

    End Sub

    Private Sub btn_tipoDispositivo_cerrar_Click(sender As Object, e As EventArgs) Handles btn_tipoDispositivo_cerrar.Click
        Me.Close()

        CapaInterfaz_dispositivo.cargarComboTipoDispositivo()
    End Sub

    Private Sub CapaInterfaz_TipoDispositivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CapaLogicaNegocio_TIpoDispositivo.consultarTipoDispositivo()
    End Sub

    Private Sub btn_tipoDispositivo_borrar_Click(sender As Object, e As EventArgs) Handles btn_tipoDispositivo_borrar.Click
        CapaLogicaNegocio_TIpoDispositivo.borrarTipoDispositivo(grid_tipoDispositivo.CurrentRow.DataBoundItem)
        CapaLogicaNegocio_TIpoDispositivo.consultarTipoDispositivo()
    End Sub

    Private Sub btn_tipoDispositivo_modificar_Click(sender As Object, e As EventArgs) Handles btn_tipoDispositivo_modificar.Click
        CapaLogicaNegocio_TIpoDispositivo.modificarTipoDispositivo(grid_tipoDispositivo.CurrentRow.DataBoundItem)
        CapaLogicaNegocio_TIpoDispositivo.consultarTipoDispositivo()
    End Sub
End Class