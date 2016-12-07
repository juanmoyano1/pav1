Public Class Reg_Incidencia_Negocio

    'Cargar combos
    Private Shared Sub cargarCombo(ByRef combo As ComboBox, ByRef datos As Data.DataTable, ByVal pk As String, ByVal descripcion As String)
        combo.DataSource = datos
        combo.ValueMember = pk
        combo.DisplayMember = descripcion
    End Sub
    Public Shared Sub cargaComboArea(ByRef combo As ComboBox)
        cargarCombo(combo, Reg_Incidencia_Datos.cargarCombo("[Area]"), "codArea", "nombre")
    End Sub
    Public Shared Sub cargaComboDispositivo(ByRef combo As ComboBox)
        cargarCombo(combo, Reg_Incidencia_Datos.cargarCombo("[Dispositivo]"), "codDispositivo", "nombre")
    End Sub

    Public Shared Sub cargarComboUsuario(combo As ComboBox)
        cargarCombo(combo, Reg_Incidencia_Datos.cargarCombo("[Usrs]"), "legajo", "legajo")
    End Sub


    'Crear el objeto Incidencia
    Public Shared Function crearReg_Incidencia(codUsuarioFinal As Integer, areaIncidente As Integer, codDispositivo As Integer, codPrioridad As Integer, titulo As String, descripcion As String, fechaCarga As Date) As Incidencia
        Dim oIncidencia As New Incidencia
        'oIncidencia.codIncidencia = codIncidencia
        oIncidencia.usuarioFinal = codUsuarioFinal
        oIncidencia.area = areaIncidente
        oIncidencia.dispositivo = codDispositivo
        oIncidencia.prioridad = codPrioridad
        oIncidencia.titulo = titulo
        oIncidencia.descripcion = descripcion
        oIncidencia.fechaCarga = fechaCarga
        Return oIncidencia
    End Function

    'FACHADA para la capa de datos y registrar la Incidencia
    Public Shared Sub guardarIncidencia(oIncidencia As Incidencia)
        Reg_Incidencia_Datos.registrarIncidencia(oIncidencia)
    End Sub

End Class
