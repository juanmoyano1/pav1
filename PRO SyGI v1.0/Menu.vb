Public Class frmPrincipal
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        If (MsgBox("¿ Esta seguro que desea Salir ?", MsgBoxStyle.YesNo)) = 6 Then
            Close()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btn_gestionIncidencias.Click
        form_gestionIncidenciaV2.ShowDialog()
    End Sub

    Private Sub btn_agregarDispositivos_Click(sender As Object, e As EventArgs) Handles btn_agregarDispositivos.Click
        CapaInterfaz_dispositivo.ShowDialog()
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frm_login.ShowDialog()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btn_administrarUsuarios.Click
        Usr_interfaz.ShowDialog()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btn_registrarIncidencia.Click
        form_registrarIncidencia.ShowDialog()
    End Sub

    Private Sub btn_perfiles_Click(sender As Object, e As EventArgs) Handles btn_perfiles.Click
        Usr_Adm_PerfilXPermisos.ShowDialog()
    End Sub

    Private Sub btn_estadisticasReportes_Click(sender As Object, e As EventArgs) Handles btn_estadisticasReportes.Click
        Reporte.ShowDialog()

    End Sub

    Private Sub btn_ayuda_Click(sender As Object, e As EventArgs) Handles btn_ayuda.Click
        MsgBox("PROSyGi: Programa de Solución y Gestión de Incidentes " & vbCr & _
               "Versión 16.0" & vbCr & vbCr & "Creadores: Moyano Juan Ignacio - Pizarro Augusto Martin - Uriarte Martin Ezequiel ", MsgBoxStyle.Information)
    End Sub
End Class
