Public Class CapaDatos_Incidencia

    Public Shared Function consultarIncidencia(estado As Integer, prioridad As Integer, _
                                                 usuario As Integer, area As Integer)


        Dim stringConsulta As String
        stringConsulta = "SELECT i.codIncidencia, i.titulo, i.descripcion, i.fechaCarga, i.fechaCierre, a.nombre as 'nombreArea', d.nombre as 'nombreDispositivo', " & _
                                 "e.nombre as 'nombreEstado', p.nombre as 'nombrePrioridad', uf.nombre as 'nombreUsrFInal', ue.nombre as 'nombreUsrEncargado'" & _
                         "FROM Incidencia i LEFT JOIN Estado e ON (e.codEstado = i.codEstado) " & _
                                           "LEFT JOIN Prioridad p ON (i.codPrioridad = p.codPrioridad) " & _
                                           "LEFT JOIN Area a ON (a.codArea = i.areaIncidente) " & _
                                           "LEFT JOIN Usrs uf ON (uf.legajo = i.codUsuarioFinal) " & _
                                           "LEFT JOIN Usrs ue ON (ue.legajo = i.codUsuarioEncargado) " & _
                                           "LEFT JOIN Dispositivo d ON (d.codDispositivo = i.codDispositivo) " & _
                         "WHERE i.baja = 1"


        If estado <> 0 Then
            stringConsulta = stringConsulta & " AND i.codEstado = " & estado
        End If

        If prioridad <> 0 Then
            stringConsulta = stringConsulta & " AND i.codPrioridad = " & prioridad
        End If

        If usuario <> 0 Then
            stringConsulta = stringConsulta & " AND i.codUsuarioFinal = " & usuario
        End If

        If area <> 0 Then
            stringConsulta = stringConsulta & " AND i.areaIncidente = " & area
        End If


        Return BDHelper.ConsultaSQL(stringConsulta)
    End Function

    Public Shared Function conocerProxNroOrden(codIncidente As Integer)
        Dim tablas As DataTable
        tablas = BDHelper.ConsultaSQL("SELECT MAX(nroOrden) FROM DetalleIncidencia WHERE codIncidencia = " & codIncidente)
        Dim nroProximoOrden As Integer
        If tablas.Rows(0).Item(0).ToString = "" Then
            nroProximoOrden = 1
        Else
            nroProximoOrden = tablas.Rows(0).Item(0) + 1
        End If
        Return nroProximoOrden
    End Function

    Public Shared Function consultarEstado()
        '1 esta activo, 0 esta dado de baja
        Return BDHelper.ConsultaSQL("SELECT * FROM Estado WHERE baja = 1")
    End Function

    Public Shared Function consultarArea()
        Return BDHelper.ConsultaSQL("SELECT * FROM Area WHERE baja = 1")
    End Function

    Public Shared Function consultarUsuario()
        Return BDHelper.ConsultaSQL("SELECT * FROM Usrs WHERE baja = 1")
    End Function


    Public Shared Sub registrarDetalleTransaccion(detalle As DetalleIncidencia, codNuevoEstado As Integer, codNuevaPrioridad As Integer)

        Dim conexion As New System.Data.SqlClient.SqlConnection
        Dim comando1 As New System.Data.SqlClient.SqlCommand
        Dim comando2 As New System.Data.SqlClient.SqlCommand
        Dim miTransaccion As System.Data.SqlClient.SqlTransaction

        'Aca llamamos al metodo stringDeConexion que se nos devuelve un string con la conexion.
        conexion.ConnectionString = StringDeConexion.stringDeConexion
        conexion.Open()
        miTransaccion = conexion.BeginTransaction

        Try
            comando1 = New System.Data.SqlClient.SqlCommand("UPDATE Incidencia SET codEstado = " & codNuevoEstado & ", codPrioridad = " & codNuevaPrioridad & " WHERE codIncidencia = " & detalle.incidencia, conexion, miTransaccion)
            comando1.ExecuteNonQuery()

            comando2 = New System.Data.SqlClient.SqlCommand("INSERT INTO DetalleIncidencia (nroOrden, codIncidencia, fechaAtencion, duracion, descripcion, titulo) " & _
                                                            "VALUES (" & detalle.nroOrden & ", " & detalle.incidencia & ", " & _
                                                            "CAST('" & DateTime.Now & "' AS datetime2)" & ", " & _
                                                            "CONVERT(VARCHAR," & detalle.duracion & " / 60) + ':' + RIGHT('00' + CONVERT(VARCHAR," & detalle.duracion & " % 60),2)" & _
                                                            ", '" & detalle.descripcion & "', '" & detalle.titulo & "')", conexion, miTransaccion)
            comando2.ExecuteNonQuery()


            miTransaccion.Commit()
            MsgBox("EJECUTANDO COMMIT")
        Catch ex As Exception
            miTransaccion.Rollback()
            MsgBox("EJECUTANDO ROLLBACK")
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try
    End Sub

    'PRUEBA NUEVO METODO

    Public Shared Sub pruebaRegistrarDetalleTransaccion(detalle As DetalleIncidencia, codNuevoEstado As Integer, codNuevaPrioridad As Integer)

        Dim conexion As New System.Data.SqlClient.SqlConnection
        Dim comando1 As New System.Data.SqlClient.SqlCommand
        Dim comando2 As New System.Data.SqlClient.SqlCommand
        Dim miTransaccion As System.Data.SqlClient.SqlTransaction

        'Aca llamamos al metodo stringDeConexion que se nos devuelve un string con la conexion.
        conexion.ConnectionString = StringDeConexion.stringDeConexion
        conexion.Open()
        miTransaccion = conexion.BeginTransaction

        Dim fechaCierre As String
        Try
            If codNuevoEstado = 5 Then
                fechaCierre = Date.Now.ToShortDateString.ToString

                comando1 = New System.Data.SqlClient.SqlCommand("UPDATE Incidencia SET codEstado = " & codNuevoEstado & ", codPrioridad = " & codNuevaPrioridad & ", fechaCierre='" & fechaCierre & "' WHERE codIncidencia = " & detalle.incidencia, conexion, miTransaccion)
            Else
                comando1 = New System.Data.SqlClient.SqlCommand("UPDATE Incidencia SET codEstado = " & codNuevoEstado & ", codPrioridad = " & codNuevaPrioridad & " WHERE codIncidencia = " & detalle.incidencia, conexion, miTransaccion)
            End If
            comando1.ExecuteNonQuery()


            comando2 = New System.Data.SqlClient.SqlCommand("INSERT INTO DetalleIncidencia (nroOrden, codIncidencia, fechaAtencion, duracion, descripcion, titulo) " & _
                                                            "VALUES (" & detalle.nroOrden & ", " & detalle.incidencia & ", " & _
                                                            "CONVERT(datetime,'" & detalle.fechaAtencion & "',103)," & _
                                                            "CONVERT(VARCHAR," & detalle.duracion & " / 60) + ':' + RIGHT('00' + CONVERT(VARCHAR," & detalle.duracion & " % 60),2)" & _
                                                            ", '" & detalle.descripcion & "', '" & detalle.titulo & "')", conexion, miTransaccion)
            comando2.ExecuteNonQuery()


            miTransaccion.Commit()
            MsgBox("EJECUTANDO COMMIT")
        Catch ex As Exception
            miTransaccion.Rollback()
            MsgBox("EJECUTANDO ROLLBACK")
        Finally
            conexion.Close()
            conexion.Dispose()
        End Try
    End Sub


    Public Shared Function consultarDetallesIncidencia(codIncidencia As Integer) As DataTable
        Return BDHelper.ConsultaSQL("SELECT * FROM DetalleIncidencia WHERE codIncidencia = " & codIncidencia & " ORDER BY nroOrden")
    End Function


    Public Shared Function consultarUsuariosEncargados()
        Return BDHelper.ConsultaSQL("SELECT legajo, nombre, apellido FROM Usrs")
    End Function

    Public Shared Sub asignarUsuarioEncargado(codUsuarioEncargado As Integer, codIncidencia As Integer)
        BDHelper.EjecutarSQL("UPDATE Incidencia SET codUsuarioEncargado = " & codUsuarioEncargado & " WHERE codIncidencia = " & codIncidencia)
    End Sub

End Class
