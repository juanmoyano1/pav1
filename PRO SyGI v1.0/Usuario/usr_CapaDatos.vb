Public Class usr_CapaDatos

    Public Shared Function cargarCombo(nomTabla As String)
        Return BDHelper.datosTabla(nomTabla)
    End Function

    Public Shared Function buscarUsr(legajo As Integer)
        Return BDHelper.ConsultaSQL("Select * from Usrs where legajo = " & legajo)

    End Function

    Public Shared Sub eliminarUsr(legajo As Integer)
        Try
            BDHelper.EjecutarSQL("UPDATE Usrs SET baja = 0 WHERE legajo = " & legajo)
            MsgBox("Usuario eliminado")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Shared Sub crearUsr(usua As Usr)
        Try
            BDHelper.ConsultaSQL("Insert Into Usrs(legajo,apellido,nombre,area,tipoUsr,clave)" & _
                                 "values(" & usua.legajo & ",'" & usua.apellido & _
                                 "','" & usua.nombre & "'," & usua.area & "," & usua.tipoUsr & ",'" & usua.clave & "')")
            MsgBox("Usuario creado")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Shared Sub modificarUsr(user As Usr)
        Try
            BDHelper.EjecutarSQL("UPDATE Usrs set apellido ='" & user.apellido & "', nombre ='" & user.nombre & _
                                 "', area =" & user.area & " , tipoUsr =" & user.tipoUsr & " ,clave='" & user.clave & "' where legajo =" & user.legajo)
            MsgBox("Usuario modificado")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Class
