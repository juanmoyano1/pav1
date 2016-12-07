Public Class Usr_Adm_PerfilXPermisos_Negocio

    Public Shared Function cargarGrillaPerfiles()

        Dim perfiles As DataTable = Usr_Adm_PerfilXPermisos_DATOS.consultarPerfiles()
        Dim lista As New List(Of Perfil)


        For Each perfil As DataRow In perfiles.Rows
            Dim oPerfil As New Perfil
            oPerfil.codTipo = perfil.Item("codTipo")
            oPerfil.nombre = perfil.Item("nombre")
            oPerfil.descripcion = perfil.Item("descripcion")
            lista.Add(oPerfil)
        Next

        Return lista
    End Function

    Public Shared Sub registrarPerfil(nombre As String, descripcion As String)

        Usr_Adm_PerfilXPermisos_DATOS.registrarPerfil(nombre, descripcion)

    End Sub

    Public Shared Sub eliminarPerfil(codTipo As Integer)
        Usr_Adm_PerfilXPermisos_DATOS.eliminarPerfil(codTipo)
    End Sub


    Public Shared Function conocerPermisosXPerfil(codPerfil As Integer)

        Dim tabla As DataTable
        Dim lista As New List(Of Permiso)
        tabla = Usr_Adm_PerfilXPermisos_DATOS.consultarPermisoXPerfil(codPerfil)
        For Each fila As DataRow In tabla.Rows
            Dim obj As New Permiso
            obj.codPermiso = fila("codPermiso")
            obj.nombre = fila("nombre")
            lista.Add(obj)
        Next

        Return lista

    End Function

    'Public Shared Sub refrescarGrilla()
    '    Dim lista As List(Of Perfil) = Usr_Adm_PerfilXPermisos_Negocio.cargarGrillaPerfiles()
    '    'Usr_Adm_PerfilXPermisos.dgv_Adm_PerfilXPermisos_perfil.Rows.Clear()
    '    For Each elemento In lista
    '        Usr_Adm_PerfilXPermisos.dgv_Adm_PerfilXPermisos_perfil.Rows.Add(elemento.codTipo, elemento.nombre, elemento.descripcion)
    '    Next

    'End Sub
End Class
