Public Class CapaDatos_dispositivo

    Public Shared Function consultarDispositivo() As DataTable
        Dim tabla As DataTable
        tabla = BDHelper.ConsultaSQL("SELECT * FROM Dispositivo WHERE baja = 1")
        Return tabla
    End Function

    Public Shared Sub registrarDispositivo(nombre As String, descripcion As String, codTipo As String)
        BDHelper.ConsultaSQL("INSERT INTO Dispositivo (nombre, descripcion, codTipo) VALUES ('" & nombre & "', '" & _
                             descripcion & "', " & codTipo & ")")
    End Sub

    Public Shared Sub eliminarDispositivo(codDispositivo As Integer)
        BDHelper.EjecutarSQL("UPDATE Dispositivo SET baja = 0 WHERE codDispositivo = " & codDispositivo)
    End Sub

    Public Shared Sub modificarDispositivo(codDispositivo As Integer, nombre As String, descripcion As String, _
                                           codTipo As Integer)
        BDHelper.EjecutarSQL("UPDATE Dispositivo SET nombre = '" & nombre & "', descripcion = '" & descripcion & _
                             "', codTipo = " & codTipo & " WHERE codDispositivo = " & codDispositivo)
    End Sub

End Class
