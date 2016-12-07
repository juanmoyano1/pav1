Public Class CapaInterfaz_area

    Private Sub btn_area_agregar_Click(sender As Object, e As EventArgs) Handles btn_area_agregar.Click
        CapaLogicaNegocio_Area.agregarArea(txt_area_nombre.Text)
        CapaLogicaNegocio_Area.consultarArea()
    End Sub

    Private Sub CapaInterfaz_area_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CapaLogicaNegocio_Area.consultarArea()
    End Sub

    Private Sub btn_area_borrar_Click(sender As Object, e As EventArgs) Handles btn_area_borrar.Click
        CapaLogicaNegocio_Area.borrarArea(grid_area.CurrentRow.DataBoundItem)
        CapaLogicaNegocio_Area.consultarArea()
    End Sub

    Private Sub btn_area_modificar_Click(sender As Object, e As EventArgs) Handles btn_area_modificar.Click
        CapaLogicaNegocio_Area.modificarArea(grid_area.CurrentRow.DataBoundItem)
        CapaLogicaNegocio_Area.consultarArea()
    End Sub

    Private Sub btn_area_cerrar_Click(sender As Object, e As EventArgs) Handles btn_area_cerrar.Click
        Me.Close()
        CapaInterfaz_dispositivo.cargarComboArea()
    End Sub
End Class