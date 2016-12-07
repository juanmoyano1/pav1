Public Class CapaLogicaNegocio_dispositivo

    Public Shared Sub consultarDispositivo()
        Dim tabla As DataTable = CapaDatos_dispositivo.consultarDispositivo
        'Creamos la lista con el New
        Dim lista As New List(Of Dispositivo)
        'Iteramos sobre las filas de la tabla que obtuvimos de la consulta
        For Each fila As DataRow In tabla.Rows
            Dim objeto As Dispositivo
            objeto = Dispositivo.crearObjeto(fila("codDispositivo"), fila("nombre"), fila("descripcion"), fila("codTipo"), fila("baja"))
            lista.Add(objeto)
        Next

        CapaInterfaz_dispositivo.datagrid_dispositivo.DataSource = lista
    End Sub

    Public Shared Sub registrarDispositivo(nombre As String, descripcion As String, codTipo As Integer)
        CapaDatos_dispositivo.registrarDispositivo(nombre, descripcion, codTipo)
    End Sub

    Public Shared Sub eliminarDispositivo(dispositivo As Dispositivo)
        CapaDatos_dispositivo.eliminarDispositivo(dispositivo.codDispositivo)
    End Sub

    Public Shared Sub modificarDispositivo(dispositivo As Dispositivo)

        CapaDatos_dispositivo.modificarDispositivo(dispositivo.codDispositivo, _
                                                   CapaInterfaz_dispositivo.txt_dispositivo_nombre.Text, _
                                                   CapaInterfaz_dispositivo.txt_dispositivo_descripcion.Text, _
                                                   CapaInterfaz_dispositivo.cmb_dispositivo_tipo.SelectedValue)
    End Sub

End Class
