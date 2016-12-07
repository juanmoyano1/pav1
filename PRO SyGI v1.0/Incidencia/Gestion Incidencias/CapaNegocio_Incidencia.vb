Public Class CapaNegocio_Incidencia


    Public Shared Function consultarIncidencias(filtroEstado As Boolean, valorEstado As Integer, _
                                                filtroPrioridad As Boolean, valorPrioridad As Integer, _
                                                 filtroUsuario As Boolean, valorUsuario As Integer, _
                                                 filtroArea As Boolean, valorArea As Integer) As List(Of Incidencia)


        If filtroEstado = False Then
            valorEstado = 0
        End If
        If filtroArea = False Then
            valorArea = 0
        End If

        If filtroPrioridad = False Then
            valorPrioridad = 0
        End If
        If filtroUsuario = False Then
            valorUsuario = 0
        End If



        Dim lista As New List(Of Incidencia)
        Dim tabla As DataTable
        tabla = CapaDatos_Incidencia.consultarIncidencia(valorEstado, valorPrioridad, valorUsuario, valorArea)

        For Each fila As DataRow In tabla.Rows
            Dim inc As New Incidencia
            inc.descripcion = fila("descripcion")
            inc.codIncidencia = fila("codIncidencia")
            inc.titulo = fila("titulo")
            inc.usuarioFinal = fila("nombreUsrFinal")
            inc.fechaCarga = fila("fechaCarga")
            If fila("fechaCierre").ToString <> "" Then
                inc.fechaCierre = fila("fechaCierre")
            End If
            inc.area = fila("nombreArea")
            inc.estado = fila("nombreEstado")
            inc.prioridad = fila("nombrePrioridad")
            If fila("nombreUsrEncargado").ToString <> "" Then
                inc.usuarioSupervisor = fila("nombreUsrEncargado")
            End If
            inc.dispositivo = fila("nombreDispositivo")

            lista.Add(inc)
        Next

        Return lista
    End Function



    Public Shared Sub registrarDetalleTransaccionNEGOCIO(nroOrden As Integer, titulo As String, estado As Integer, _
                                                         prioridad As Integer, descripcion As String, _
                                                         duracion As Integer, codIncidencia As Integer, fechaAtencion As Date)

        Dim detalle As New DetalleIncidencia
        detalle.nroOrden = nroOrden
        detalle.titulo = titulo
        detalle.descripcion = descripcion
        detalle.duracion = duracion
        detalle.incidencia = codIncidencia
        detalle.fechaAtencion = fechaAtencion

        CapaDatos_Incidencia.pruebaRegistrarDetalleTransaccion(detalle, estado, prioridad)

    End Sub


    Public Shared Function consultarDetallesIncidencia(inc As Incidencia) As DataTable
        Return CapaDatos_Incidencia.consultarDetallesIncidencia(inc.codIncidencia)
    End Function

End Class
