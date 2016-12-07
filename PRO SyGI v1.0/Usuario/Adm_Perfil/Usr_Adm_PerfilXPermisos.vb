Public Class Usr_Adm_PerfilXPermisos

    Dim listaNuevaGlobal As New List(Of Permiso)

    Private Sub Usr_Adm_PerfilXPermisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        iniciarUbicaciones()
        cargarPermisosCombo()
        dgv_Adm_PerfilXPermisos_perfil.DataSource = Usr_Adm_PerfilXPermisos_Negocio.cargarGrillaPerfiles()

    End Sub
    'Realizamos la ubicacion de algunos elementos que conforman el formulario, en este caso boton +, boton -, combo de permisos y lista de permisos
    Private Sub iniciarUbicaciones()

        lbl_Adm_PerfilXPermisos_descripcion.Visible = False
        lbl_Adm_PerfilXPermisos_nombrePefil.Visible = False
        txt_descripcionPerfil.Visible = False
        txt_nombrePerfil.Visible = False
        btn_cancelar.Visible = False
        btn_confirmar.Visible = False

        Dim lugarLista1 As Point
        lugarLista1.X = 25
        lugarLista1.Y = 252
        Dim lugarLista2 As Point
        lugarLista2.X = 27
        lugarLista2.Y = 318
        Dim lugarboton1 As Point
        lugarboton1.X = 228
        lugarboton1.Y = 279
        Dim lugarboton2 As Point
        lugarboton2.X = 317
        lugarboton2.Y = 279

        cmb_permisos.Location = lugarLista1
        lst_Adm_PerfilXPermisos_PermisosAsignados.Location = lugarLista2
        btn_Adm_PerfilXPermisos_agregar.Location = lugarboton1
        btn_Adm_PerfilXPermisos_quitar.Location = lugarboton2

        Me.Height = 574

    End Sub

    'Realizamos la REubicacion de algunos elementos que conforman el formulario, en este caso boton +, boton -, combo de permisos y lista de permisos
    Private Sub ubicacionesDesplegadas()

        lbl_Adm_PerfilXPermisos_descripcion.Visible = True
        lbl_Adm_PerfilXPermisos_nombrePefil.Visible = True
        txt_descripcionPerfil.Visible = True
        txt_nombrePerfil.Visible = True
        btn_cancelar.Visible = True
        btn_confirmar.Visible = True

        Dim lugarLista1 As Point
        lugarLista1.X = 25
        lugarLista1.Y = 378
        Dim lugarLista2 As Point
        lugarLista2.X = 27
        lugarLista2.Y = 444
        Dim lugarboton1 As Point
        lugarboton1.X = 228
        lugarboton1.Y = 405
        Dim lugarboton2 As Point
        lugarboton2.X = 317
        lugarboton2.Y = 405

        cmb_permisos.Location = lugarLista1
        lst_Adm_PerfilXPermisos_PermisosAsignados.Location = lugarLista2
        btn_Adm_PerfilXPermisos_agregar.Location = lugarboton1
        btn_Adm_PerfilXPermisos_quitar.Location = lugarboton2

        Me.Height = 724

    End Sub

    'Cargamos la lista con los elementos.
    Private Sub btn_Adm_PerfilXPermisos_nuevo_Click(sender As Object, e As EventArgs) Handles btn_Adm_PerfilXPermisos_nuevo.Click
        ubicacionesDesplegadas()
        dgv_Adm_PerfilXPermisos_perfil.Enabled = False
        lst_Adm_PerfilXPermisos_PermisosAsignados.DataSource = Nothing

        dgv_Adm_PerfilXPermisos_perfil.DataSource = Usr_Adm_PerfilXPermisos_Negocio.cargarGrillaPerfiles()
    End Sub

    Private Function agregarElementoLista(lista As List(Of Permiso))

        Return lista
    End Function

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        iniciarUbicaciones()
        dgv_Adm_PerfilXPermisos_perfil.Enabled = True
        listaNuevaGlobal.Clear()

    End Sub

    Private Sub btn_confirmar_Click(sender As Object, e As EventArgs) Handles btn_confirmar.Click

        'No es la idea
        'Usr_Adm_PerfilXPermisos_Negocio.registrarPerfil(txt_nombrePerfil.Text, txt_descripcionPerfil.Text)


        Usr_Adm_PerfilXPermisos_DATOS.transaccionPermisosXPerfil(listaNuevaGlobal, txt_nombrePerfil.Text, txt_descripcionPerfil.Text)

        listaNuevaGlobal.Clear()
        dgv_Adm_PerfilXPermisos_perfil.Enabled = True
        iniciarUbicaciones()
        refrescarGrilla()

    End Sub

    Private Sub btn_Adm_PerfilXPermisos_eliminar_Click(sender As Object, e As EventArgs) Handles btn_Adm_PerfilXPermisos_eliminar.Click
        Dim perfil As Perfil
        perfil = dgv_Adm_PerfilXPermisos_perfil.CurrentRow.DataBoundItem
        Usr_Adm_PerfilXPermisos_Negocio.eliminarPerfil(perfil.codTipo)
        'codTipo es la PK, en realidad seria codPerfil
        dgv_Adm_PerfilXPermisos_perfil.DataSource = Usr_Adm_PerfilXPermisos_Negocio.cargarGrillaPerfiles()
    End Sub

    Private Sub btn_Adm_PerfilXPermisos_modificar_Click(sender As Object, e As EventArgs) Handles btn_Adm_PerfilXPermisos_modificar.Click
        'EN PROCESO
        dgv_Adm_PerfilXPermisos_perfil.DataSource = Usr_Adm_PerfilXPermisos_Negocio.cargarGrillaPerfiles()
    End Sub

    Private Sub dgv_Adm_PerfilXPermisos_perfil_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Adm_PerfilXPermisos_perfil.CellClick

        Dim perf As New Perfil
        perf = dgv_Adm_PerfilXPermisos_perfil.CurrentRow.DataBoundItem

        Dim lista As List(Of Permiso)
        lista = Usr_Adm_PerfilXPermisos_Negocio.conocerPermisosXPerfil(perf.codTipo)

        lst_Adm_PerfilXPermisos_PermisosAsignados.DataSource = lista
        lst_Adm_PerfilXPermisos_PermisosAsignados.DisplayMember = "nombre"
        lst_Adm_PerfilXPermisos_PermisosAsignados.ValueMember = "codPermiso"


    End Sub


    Private Sub cargarPermisosCombo()

        cmb_permisos.DataSource = Usr_Adm_PerfilXPermisos_DATOS.consultarPermiso()
        cmb_permisos.DisplayMember = "nombre"
        cmb_permisos.ValueMember = "codPermiso"

    End Sub

    Private Sub btn_Adm_PerfilXPermisos_agregar_Click(sender As Object, e As EventArgs) Handles btn_Adm_PerfilXPermisos_agregar.Click


        If dgv_Adm_PerfilXPermisos_perfil.Enabled = True Then
            'Agregando permisos a un perfil

            'Perfil seleccionado
            Dim perf As New Perfil
            perf = dgv_Adm_PerfilXPermisos_perfil.CurrentRow.DataBoundItem

            'Lista de permisos del perfil seleccionado
            Dim lista As New List(Of Permiso)
            lista = Usr_Adm_PerfilXPermisos_Negocio.conocerPermisosXPerfil(perf.codTipo)

            Try
                Usr_Adm_PerfilXPermisos_DATOS.registrarPermisoXPerfil(perf.codTipo, cmb_permisos.SelectedValue)
            Catch ex As SqlClient.SqlException
                MsgBox("Este perfil ya posee ese permiso")
            End Try

            refrescarLista()
        Else
            'Creando un perfil de cero
            Dim permiso As New Permiso

            permiso.codPermiso = cmb_permisos.SelectedValue
            permiso.nombre = cmb_permisos.Text

            If listaNuevaGlobal.Where(Function(x) x.codPermiso = permiso.codPermiso).Count = 0 Then
                listaNuevaGlobal.Add(permiso)
            Else
                MsgBox("Ya existe este permiso")
            End If

            lst_Adm_PerfilXPermisos_PermisosAsignados.DataSource = Nothing
            lst_Adm_PerfilXPermisos_PermisosAsignados.DataSource = listaNuevaGlobal
            lst_Adm_PerfilXPermisos_PermisosAsignados.DisplayMember = "nombre"
            lst_Adm_PerfilXPermisos_PermisosAsignados.ValueMember = "codPermiso"
        End If
    End Sub

    Private Sub refrescarGrilla()

        dgv_Adm_PerfilXPermisos_perfil.DataSource = Usr_Adm_PerfilXPermisos_Negocio.cargarGrillaPerfiles()

    End Sub

    Private Sub refrescarLista()
        Dim perf As New Perfil
        perf = dgv_Adm_PerfilXPermisos_perfil.CurrentRow.DataBoundItem

        Dim listaNueva As List(Of Permiso)
        listaNueva = Usr_Adm_PerfilXPermisos_Negocio.conocerPermisosXPerfil(perf.codTipo)

        lst_Adm_PerfilXPermisos_PermisosAsignados.DataSource = listaNueva
        lst_Adm_PerfilXPermisos_PermisosAsignados.DisplayMember = "nombre"
        lst_Adm_PerfilXPermisos_PermisosAsignados.ValueMember = "codPermiso"

    End Sub


    Private Sub btn_Adm_PerfilXPermisos_quitar_Click(sender As Object, e As EventArgs) Handles btn_Adm_PerfilXPermisos_quitar.Click

        If dgv_Adm_PerfilXPermisos_perfil.Enabled = True Then
            'Cuando ya esta creado
            Dim perfil As Integer = dgv_Adm_PerfilXPermisos_perfil.CurrentRow.Cells.Item(0).Value
            Dim permiso As Integer = lst_Adm_PerfilXPermisos_PermisosAsignados.SelectedValue

            Usr_Adm_PerfilXPermisos_DATOS.borrarPermiso(permiso, perfil)

            Me.refrescarLista()
        Else
            'Creando uno nuevo
            Dim permiso As Permiso
            permiso = lst_Adm_PerfilXPermisos_PermisosAsignados.SelectedItem

            listaNuevaGlobal.Remove(permiso)

            lst_Adm_PerfilXPermisos_PermisosAsignados.DataSource = Nothing
            lst_Adm_PerfilXPermisos_PermisosAsignados.DataSource = listaNuevaGlobal
            lst_Adm_PerfilXPermisos_PermisosAsignados.DisplayMember = "nombre"
            lst_Adm_PerfilXPermisos_PermisosAsignados.ValueMember = "codPermiso"
        End If
    End Sub


End Class