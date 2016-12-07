Public Class Reporte

    Private estado As String = "nulo"

    'Load del FORM
    Private Sub Reporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        limpiarParametros()
        cargarComboEstado()
    End Sub

    Private Sub cargarComboEstado()
        cmb_estado.DataSource = CapaDatos_Incidencia.consultarEstado()
        cmb_estado.DisplayMember = "nombre"
        cmb_estado.ValueMember = "codEstado"
    End Sub

    Private Sub DispositivosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DispositivosToolStripMenuItem.Click
        limpiarParametros()
        chk_disp_baja.Visible = True
        estado = "lst_dispositivo"
    End Sub

    Private Sub limpiarParametros()
        chk_disp_baja.Visible = False
        chk_disp_baja.Checked = False
        lbl_text.Text = String.Empty
        cmb_estado.Visible = False
        DateTimePicker1.Visible = False
        DateTimePicker2.Visible = False
      
    End Sub




    Private Sub PerfilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerfilesToolStripMenuItem.Click
        limpiarParametros()
        estado = "reporte_perfiles"
    End Sub

    Private Sub IncidenciasEstadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncidenciasEstadosToolStripMenuItem.Click
        limpiarParametros()
        estado = "reporte_incidenciasXFecha"
        DateTimePicker1.Visible = True
        DateTimePicker2.Visible = True
        lbl_text.Text = "Seleccione el intervalo de fechas"
    End Sub

    Private Sub btn_generar_Click(sender As Object, e As EventArgs) Handles btn_generar.Click

        'No se genera reporte por no seleccionar ninguno
        If estado = "nulo" Then
            MsgBox("Debe seleccionar algun tipo de reporte")
        End If

        'Reporte LISTADO DE DISPOSITIVOS (lst_dispositivo) con un parametro booleano referente a "baja"
        If estado = "lst_dispositivo" Then
            Dim reporte As New lst_dispositivo
            reporte.SetDatabaseLogon("pav1", "lacontrasena")
            reporte.SetParameterValue("@baja", chk_disp_baja.Checked)
            Me.crvInforme.ReportSource = reporte
            Me.crvInforme.Show()
            Me.crvInforme.Refresh()
        End If

        'Reporte LISTADO DE INCIDENTES (lst_incidente) con un parametro de estado
        If estado = "lst_incidente" Then
            Dim reporte As New lst_incidente_estado
            reporte.SetDatabaseLogon("pav1", "lacontrasena")
            reporte.SetParameterValue("@codEstado", cmb_estado.SelectedValue)
            Me.crvInforme.ReportSource = reporte
            Me.crvInforme.Show()
            Me.crvInforme.Refresh()
        End If

        'Reporte ESTADISICA DE PERFILES (reporte_perfiles) sin parametros
        If estado = "reporte_perfiles" Then
            Dim reporte As New ReportePerfiles
            reporte.SetDatabaseLogon("pav1", "lacontrasena")
            Me.crvInforme.ReportSource = reporte
            Me.crvInforme.Show()
            Me.crvInforme.Refresh()
        End If

        'Reporte ESTADISTICA DE INCIDENTES (reporte_incidenciasXFecha) con 2 parametros
        If estado = "reporte_incidenciasXFecha" Then

            Dim fechaDesde As String = DateTimePicker1.Value.Month & "/" & DateTimePicker1.Value.Day & "/" & DateTimePicker1.Value.Year
            Dim fechaHasta As String = DateTimePicker2.Value.Month & "/" & DateTimePicker2.Value.Day & "/" & DateTimePicker2.Value.Year

            Dim reporte As New reporte_incidenteXFecha
            reporte.SetDatabaseLogon("pav1", "lacontrasena")
            reporte.SetParameterValue("@fecha1", fechaDesde)
            reporte.SetParameterValue("@fecha2", fechaHasta)
            Me.crvInforme.ReportSource = reporte
            Me.crvInforme.Show()
            Me.crvInforme.Refresh()

        End If

    End Sub

    
    Private Sub IncidenciasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncidenciasToolStripMenuItem.Click
        limpiarParametros()
        cmb_estado.Visible = True
        lbl_text.Text = "Seleccione el estado de los incidentes a generar"
        estado = "lst_incidente"
    End Sub
End Class