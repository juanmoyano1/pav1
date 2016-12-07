Imports System.Data.SqlClient

Public Class Reg_Incidencia_Datos

    Public Shared Function cargarCombo(nomTabla As String)
        Dim tabla As New DataTable
        Try
            tabla = BDHelper.datosTabla(nomTabla)
        Catch ex As Exception
            MsgBox("Excepcion no controlada: " + ex.ToString)
        End Try
        Return tabla
    End Function


    'Public Shared Sub registrarIncidencia(incidente As Incidencia)
    '   Try
    '      BDHelper.EjecutarSQL("INSERT INTO Incidencia (codEstado, codUsuarioFinal, areaIncidente, codDispositivo, codPrioridad, titulo, descripcion, fechaCarga)" & _
    '                          " VALUES (4, " & incidente.usuarioFinal & ", " & incidente.area & ", " & incidente.dispositivo & ", " & _
    '                                 incidente.prioridad & ", '" & incidente.titulo & "', '" & incidente.descripcion & "', " & "CONVERT(datetime,'" & incidente.fechaCarga & "',103)")
    '    Catch ex As Exception
    '        MsgBox("Excepcion no controlada: " + ex.ToString)
    '    End Try

    'End Sub

    'Nuevo metodo para registrar incidencia realizado con un convert time

    Public Shared Sub registrarIncidencia(incidente As Incidencia)
        Try
            BDHelper.EjecutarSQL("Insert Into Incidencia (codUsuarioFinal, titulo, fechaCarga, areaIncidente, descripcion, codEstado,codPrioridad,codDispositivo)" & _
                                 "values(" & incidente.usuarioFinal & ",'" & incidente.titulo & "', Convert(datetime,'" & incidente.fechaCarga & "',103)," & _
                                 incidente.area & ",'" & incidente.descripcion & "',4," & incidente.prioridad & "," & incidente.dispositivo & ")")
        Catch ex As Exception
            MsgBox("Excepcion no controlada: " + ex.ToString)
        End Try
    End Sub

    'Metodo para obtener el ID del proximo incidente
    Public Shared Function conocerProximoId() As Integer
        Dim tabla As New DataTable
        Try
            'Le cambie el MAX por el count. Ya que sino puede haber problemas en la concurrencia de la BD
            'TENER EN CUENTA QUE EN LA BD LOS CODIGO DE INCIDENTES NO ESTAN EN ORDEN SUCESIVO POR LO CUAL EL NUMERO DE INCIDENCIA
            'NO COINCIDE CON EL DEL FORMULARIO
            tabla = BDHelper.ConsultaSQL("SELECT COUNT(*) FROM Incidencia")
        Catch ex As Exception
            MsgBox("Excepcion no controlada: " + ex.ToString)
        End Try
        Return (tabla.Rows(0).Item(0)) + 1
    End Function



End Class
