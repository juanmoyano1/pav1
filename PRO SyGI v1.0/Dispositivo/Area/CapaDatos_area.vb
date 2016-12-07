Public Class CapaDatos_Area

    Public Shared Sub agregarArea(nombreArea As String)
        BDHelper.EjecutarSQL("INSERT INTO Area (nombre) VALUES ('" & nombreArea & "')")
    End Sub

    Public Shared Function consultarArea() As DataTable
        Dim tabla As DataTable
        tabla = BDHelper.ConsultaSQL("SELECT * FROM Area WHERE baja = 1")
        Return tabla
    End Function

    Public Shared Sub borrarArea(codArea As Integer)
        BDHelper.EjecutarSQL("UPDATE Area SET baja = 0 WHERE codArea = " & codArea)
    End Sub

    Public Shared Sub modificarArea(nuevoNombre As String, pkArea As Integer)
        BDHelper.EjecutarSQL("UPDATE Area SET nombre = '" & nuevoNombre & "' WHERE codArea = " & pkArea)
    End Sub

End Class


