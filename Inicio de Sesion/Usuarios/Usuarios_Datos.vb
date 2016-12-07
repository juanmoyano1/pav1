Public Class Usuarios_Datos
    'Obtenemos los datos del usuarios de la BD en base a lo ingresado
    Public Shared Function getUsuario(legajo As Integer, clave As String) As Usr
        Dim dt As DataTable
        Dim oUsuario As Usr = Nothing
        dt = BDHelper.ConsultaSQL("Select * from Usrs where legajo= " & legajo & " AND clave='" & clave & "'")

        If dt.Rows.Count = 1 Then
            oUsuario = New Usr
            oUsuario.legajo = dt.Rows(0).Item("legajo")
            oUsuario.nombre = dt.Rows(0).Item("nombre")
            oUsuario.clave = dt.Rows(0).Item("clave")
            oUsuario.tipoUsr = dt.Rows(0).Item("tipoUsr")
        End If

        Return oUsuario
    End Function

    'Obtenemos los permisos asignados del usuario
    Public Shared Sub getOpcionesMenu(tipoUsr As Integer)

        Dim dt As DataTable
        dt = BDHelper.ConsultaSQL("Select permiso from PermisosXPerfiles where codTipo =  " & tipoUsr)

        For Each fila As DataRow In dt.Rows
            Dim boton As String
            boton = fila("permiso")

            'Activacion del boton Registrar Incidencia
            If frmPrincipal.btn_registrarIncidencia.Name.ToString = boton Then
                frmPrincipal.btn_registrarIncidencia.Enabled = True
                frmPrincipal.Label2.ForeColor = Color.Black
            End If
            'Activacion del boton Gestion de Incidencias
            If frmPrincipal.btn_gestionIncidencias.Name.ToString = boton Then
                frmPrincipal.btn_gestionIncidencias.Enabled = True
                frmPrincipal.Label7.ForeColor = Color.Black
            End If
            'Activacion del boton Gestion de Dispositivos
            If frmPrincipal.btn_agregarDispositivos.Name.ToString = boton Then
                frmPrincipal.btn_agregarDispositivos.Enabled = True
                frmPrincipal.lbl_agregarDispositivos.ForeColor = Color.Black
            End If
            'Activacion del boton Estadisticas y Reportes
            If frmPrincipal.btn_estadisticasReportes.Name.ToString = boton Then
                frmPrincipal.btn_estadisticasReportes.Enabled = True
                frmPrincipal.Label3.ForeColor = Color.Black
            End If
            'Activacion del boton Administrar Usuarios
            If frmPrincipal.btn_administrarUsuarios.Name.ToString = boton Then
                frmPrincipal.btn_administrarUsuarios.Enabled = True
                frmPrincipal.Label8.ForeColor = Color.Black
            End If
            'Activacion del boton Perfiles
            If frmPrincipal.btn_perfiles.Name.ToString = boton Then
                frmPrincipal.btn_perfiles.Enabled = True
                frmPrincipal.Label9.ForeColor = Color.Black
            End If
        Next
    End Sub

End Class
