Public Class CapaLogicaNegocio_TIpoDispositivo



    Public Shared Sub consultarTipoDispositivo()

        Dim tabla As DataTable = CapaDatos_TipoDispositivo.consultarTipoDispositivo
        'Creamos la lista con el New
        Dim lista As New List(Of TipoDispositivo)
        'Iteramos sobre las filas de la tabla que obtuvimos de la consulta
        For Each fila As DataRow In tabla.Rows
            Dim objeto As TipoDispositivo
            objeto = TipoDispositivo.crearTipoDispositivo(fila("codTipo"), fila("descripcion"), fila("baja"))
            lista.Add(objeto)
        Next

        CapaInterfaz_TipoDispositivo.grid_tipoDispositivo.DataSource = lista
    End Sub


    Public Shared Sub borrarTipoDispositivo(objeto As TipoDispositivo)
        CapaDatos_TipoDispositivo.borrarTipoDispositivo(objeto.codTipo)
    End Sub


    Public Shared Sub modificarTipoDispositivo(objeto As TipoDispositivo)
        Dim nuevoNombre As String = InputBox("Nuevo nombre", "Modificar Tipo Dispositivo")
        If nuevoNombre <> "" Then
            CapaDatos_TipoDispositivo.modificarTipoDispositivo(nuevoNombre, objeto.codTipo)
        End If
    End Sub

End Class
