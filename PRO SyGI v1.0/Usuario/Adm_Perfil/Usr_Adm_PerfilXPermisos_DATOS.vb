Imports System.Data.SqlClient

Public Class Usr_Adm_PerfilXPermisos_DATOS

    'ABM Perfiles
    Public Shared Function consultarPerfiles()
        Return BDHelper.ConsultaSQL("Select * from Perfiles where baja = 1")
    End Function
    Public Shared Sub registrarPerfil(nombre As String, desc As String)
        BDHelper.ConsultaSQL("INSERT INTO Perfiles (nombre, descripcion) VALUES ('" & nombre & "', '" & _
                             desc & " ' )")
    End Sub
    Public Shared Sub modificarPerfil(codTipo As Integer, nombre As String, desc As String)
        BDHelper.EjecutarSQL("UPDATE Perfiles SET nombre = '" & nombre & "', descripcion = '" & desc & _
                             "' WHERE codTipo = " & codTipo)
    End Sub
    Public Shared Sub eliminarPerfil(codTipo As Integer)
        BDHelper.EjecutarSQL("UPDATE Perfiles SET baja = 0 WHERE codTipo = " & codTipo)
    End Sub



    Public Shared Function consultarPermiso()
        Return BDHelper.ConsultaSQL("SELECT * FROM Permiso WHERE baja = 1")
    End Function


    Public Shared Function consultarPermisoXPerfil(codPerfil As Integer)
        Return BDHelper.ConsultaSQL("SELECT p.codPermiso, p.nombre " & _
                                    "FROM PermisosXPerfiles pxp JOIN Permiso p ON (pxp.codPermiso = p.codPermiso) " & _
                                    "WHERE pxp.baja = 1 AND pxp.codTipo = " & codPerfil)
    End Function

    Public Shared Sub registrarPermisoXPerfil(codPerfil As Integer, codPermiso As Integer)
        BDHelper.EjecutarSQL("INSERT INTO PermisosXPerfiles (codTipo, codPermiso, permiso) VALUES(" & codPerfil & ", " & codPermiso & ",(Select permiso from Permiso where codPermiso=" & codPermiso & "))")
    End Sub

    Public Shared Sub borrarPermiso(codPermiso As Integer, codPerfil As Integer)
        BDHelper.EjecutarSQL("Delete from PermisosXPerfiles where codPermiso=" & codPermiso & " AND codTipo=" & codPerfil)
    End Sub

    Public Shared Sub transaccionPermisosXPerfil(listaPermisos As List(Of Permiso), nombrePerfil As String, descripcionPerfil As String)

        Dim cnnx As New SqlConnection
        Dim cmdUno As New SqlCommand
        Dim cmdDos As New SqlCommand
        Dim miTransaccion As SqlTransaction
        cnnx.ConnectionString = StringDeConexion.stringDeConexion()
        cnnx.Open()
        miTransaccion = cnnx.BeginTransaction

        Try
            'Registro del perfil
            cmdUno = New SqlCommand("INSERT INTO Perfiles (nombre, descripcion) VALUES ('" & nombrePerfil & "', '" & _
                                    descripcionPerfil & " ' )", cnnx, miTransaccion)
            cmdUno.Connection = cnnx
            cmdUno.ExecuteNonQuery()

            'Registro de los permisos
            For c = 0 To listaPermisos.Count - 1

                cmdDos = New SqlCommand("INSERT INTO PermisosXPerfiles (codTipo, codPermiso, permiso) VALUES((SELECT MAX(codTipo) FROM Perfiles), " & _
                                        listaPermisos(c).codPermiso & ", (Select permiso from Permiso where codPermiso=" & listaPermisos(c).codPermiso & _
                                        "))", cnnx, miTransaccion)
                cmdDos.Connection = cnnx
                cmdDos.ExecuteNonQuery()

            Next

            miTransaccion.Commit()
            MsgBox("EJECUTANDO COMMIT")

        Catch ex As Exception
            miTransaccion.Rollback()
            MsgBox("EJECUTANDO ROLLBACK")
        Finally
            cnnx.Close()
            cnnx.Dispose()
        End Try



    End Sub





End Class
