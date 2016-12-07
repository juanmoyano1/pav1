Public Class form_gestionIncidencia_agregarEncargado

    Private Sub form_gestionIncidencia_agregarEncargado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim tabla As DataTable
        Dim lista As New List(Of Usr)

        tabla = CapaDatos_Incidencia.consultarUsuariosEncargados()

        For Each fila As DataRow In tabla.Rows
            Dim user As New Usr
            user.legajo = fila("legajo")
            user.nombre = fila("nombre")
            user.apellido = fila("apellido")
            lista.Add(user)
        Next

        dgv_usuarioEncargado.DataSource = lista

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.Close()
    End Sub

    Private Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click

        Dim usuarioEncargado As Usr
        usuarioEncargado = dgv_usuarioEncargado.CurrentRow.DataBoundItem

        Try
            CapaDatos_Incidencia.asignarUsuarioEncargado(usuarioEncargado.legajo, form_gestionIncidenciaV2.txtbox_incidencia_nro.Text)
            Me.Close()

        Catch saraza As Exception
            MsgBox("No se ha podido asignar el usuario encargado")
        End Try




    End Sub
End Class