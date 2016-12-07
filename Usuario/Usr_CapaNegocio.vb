Public Class Usr_CapaNegocio

    Private Shared Sub cargarCombo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
    End Sub

    Public Shared Sub cargaComboArea(ByRef combo As ComboBox)
        cargarCombo(combo, Reg_Incidencia_Datos.cargarCombo("[Area]"), "codArea", "nombre")
    End Sub

    Public Shared Sub cargaComboTipoUsr(ByRef combo As ComboBox)
        cargarCombo(combo, Reg_Incidencia_Datos.cargarCombo("[Perfiles]"), "codTipo", "nombre")
    End Sub


    Public Shared Function buscarUsuario(usuario As Integer)
        Dim oUser As New Usr
        Dim usr As DataTable
        usr = usr_CapaDatos.buscarUsr(usuario)
        For Each algo As DataRow In usr.Rows
            oUser.legajo = algo.Item("legajo")
            oUser.apellido = algo.Item("apellido")
            oUser.nombre = algo.Item("nombre")
            oUser.area = algo.Item("area")
            oUser.tipoUsr = algo.Item("tipoUsr")
            oUser.clave = algo.Item("clave")
            oUser.baja = algo.Item("baja")
        Next
        Return oUser
    End Function
    Public Shared Sub eliminarUsuario(usuario As Integer)
        usr_CapaDatos.eliminarUsr(usuario)
    End Sub

    Public Shared Sub crearUsr(user As Usr)
        usr_CapaDatos.crearUsr(user)
    End Sub

    Public Shared Function crearObjetoUsr(legajo, apellido, nombre, area, tipoUsr, clave)
        Dim oUser As New Usr
        oUser.legajo = legajo
        oUser.apellido = apellido
        oUser.nombre = nombre
        oUser.area = area
        oUser.tipoUsr = tipoUsr
        oUser.clave = clave

        Return oUser
    End Function

    Public Shared Sub modificarUsr(user As Usr)
        usr_CapaDatos.modificarUsr(user)
    End Sub
End Class
