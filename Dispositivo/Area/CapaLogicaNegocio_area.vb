Public Class CapaLogicaNegocio_Area

    Public Shared Sub agregarArea(nombreArea As String)
        CapaDatos_Area.agregarArea(nombreArea)
    End Sub

    Public Shared Sub consultarArea()

        Dim tabla As DataTable = CapaDatos_Area.consultarArea
        'Creamos la lista con el New
        Dim lista As New List(Of Area)
        'Iteramos sobre las filas de la tabla que obtuvimos de la consulta
        For Each fila As DataRow In tabla.Rows
            Dim objeto As Area
            objeto = Area.crearObjeto(fila("codArea"), fila("nombre"), fila("baja"))
            lista.Add(objeto)
        Next

        CapaInterfaz_area.grid_area.DataSource = lista
    End Sub

    Public Shared Sub borrarArea(fila As Area)
        CapaDatos_Area.borrarArea(fila.codArea)
    End Sub

    Public Shared Sub modificarArea(objeto As Area)
        Dim nuevoNombre As String = InputBox("Nuevo nombre", "Modificar area")
        If nuevoNombre <> "" Then
            CapaDatos_Area.modificarArea(nuevoNombre, objeto.codArea)
        End If
    End Sub

End Class
