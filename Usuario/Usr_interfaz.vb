Public Class Usr_interfaz

   
    Private Sub Usr_interfaz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Usr_CapaNegocio.cargaComboArea(cmb_area)
        Usr_CapaNegocio.cargaComboTipoUsr(cmb_tipoUsr)
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        If (MsgBox("¿ Esta seguro que desea salir ?", MsgBoxStyle.YesNo) = 6) Then
            Close()
        End If
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim usuario As Usr
        usuario = Usr_CapaNegocio.buscarUsuario(txb_legajo.Text)

        If usuario.baja Then
            txb_apellido.Text = usuario.apellido
            txb_nombre.Text = usuario.nombre
            cmb_area.SelectedValue = usuario.area
            cmb_tipoUsr.SelectedValue = usuario.tipoUsr
            txb_clave.Text = usuario.clave
        Else
            MsgBox("No existe el usuario")
        End If

    End Sub


    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Usr_CapaNegocio.eliminarUsuario(txb_legajo.Text)
    End Sub

    Private Sub btn_crear_Click(sender As Object, e As EventArgs) Handles btn_crear.Click
        Dim user As Usr
        user = Usr_CapaNegocio.crearObjetoUsr(txb_legajo.Text, txb_apellido.Text, txb_nombre.Text, cmb_area.SelectedValue, cmb_tipoUsr.SelectedValue, txb_clave.Text)
        Usr_CapaNegocio.crearUsr(user)
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        Dim user As Usr
        user = Usr_CapaNegocio.crearObjetoUsr(txb_legajo.Text, txb_apellido.Text, txb_nombre.Text, cmb_area.SelectedValue, cmb_tipoUsr.SelectedValue, txb_clave.Text)
        Usr_CapaNegocio.modificarUsr(user)
    End Sub
End Class