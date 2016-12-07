Public Class CapaDatos_TipoDispositivo
    Public Shared Function consultarTipoDispositivo() As DataTable
        Dim tabla As DataTable
        tabla = BDHelper.ConsultaSQL("SELECT * FROM TipoDispositivo WHERE baja = 1")
        Return tabla
    End Function

    Public Shared Sub borrarTipoDispositivo(codTipo As Integer)
        BDHelper.EjecutarSQL("UPDATE TipoDispositivo SET baja = 0 WHERE codTipo = " & codTipo)
    End Sub


    Public Shared Sub modificarTipoDispositivo(nuevoNombre As String, pkTipoDispositivo As Integer)
        BDHelper.EjecutarSQL("UPDATE TipoDispositivo SET descripcion = '" & nuevoNombre & "' WHERE codTipo = " & pkTipoDispositivo)
    End Sub

End Class
