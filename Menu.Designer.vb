<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.btn_estadisticasReportes = New System.Windows.Forms.Button()
        Me.btn_ayuda = New System.Windows.Forms.Button()
        Me.lbl_version = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_gestionIncidencias = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_agregarDispositivos = New System.Windows.Forms.Label()
        Me.btn_administrarUsuarios = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_agregarDispositivos = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_registrarIncidencia = New System.Windows.Forms.Button()
        Me.btn_perfiles = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_estadisticasReportes
        '
        Me.btn_estadisticasReportes.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.ico_resportesEstadisticas
        Me.btn_estadisticasReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_estadisticasReportes.Enabled = False
        Me.btn_estadisticasReportes.FlatAppearance.BorderSize = 2
        Me.btn_estadisticasReportes.Location = New System.Drawing.Point(114, 175)
        Me.btn_estadisticasReportes.Name = "btn_estadisticasReportes"
        Me.btn_estadisticasReportes.Size = New System.Drawing.Size(75, 75)
        Me.btn_estadisticasReportes.TabIndex = 5
        Me.btn_estadisticasReportes.UseVisualStyleBackColor = True
        '
        'btn_ayuda
        '
        Me.btn_ayuda.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.ico_ayuda
        Me.btn_ayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_ayuda.FlatAppearance.BorderSize = 2
        Me.btn_ayuda.Location = New System.Drawing.Point(431, 175)
        Me.btn_ayuda.Name = "btn_ayuda"
        Me.btn_ayuda.Size = New System.Drawing.Size(75, 75)
        Me.btn_ayuda.TabIndex = 8
        Me.btn_ayuda.UseVisualStyleBackColor = True
        '
        'lbl_version
        '
        Me.lbl_version.AutoSize = True
        Me.lbl_version.BackColor = System.Drawing.Color.Transparent
        Me.lbl_version.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_version.Location = New System.Drawing.Point(286, 321)
        Me.lbl_version.Name = "lbl_version"
        Me.lbl_version.Size = New System.Drawing.Size(220, 13)
        Me.lbl_version.TabIndex = 4
        Me.lbl_version.Text = "Programa de solución y gestión de incidentes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label2.Location = New System.Drawing.Point(124, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 26)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Registrar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Incidencia"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label3.Location = New System.Drawing.Point(119, 253)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 26)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Estadisticas " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "y Reportes"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(444, 258)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Acerca de"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(455, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Salir"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(12, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 25)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Principal"
        '
        'btn_gestionIncidencias
        '
        Me.btn_gestionIncidencias.BackgroundImage = CType(resources.GetObject("btn_gestionIncidencias.BackgroundImage"), System.Drawing.Image)
        Me.btn_gestionIncidencias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_gestionIncidencias.Enabled = False
        Me.btn_gestionIncidencias.FlatAppearance.BorderSize = 2
        Me.btn_gestionIncidencias.Location = New System.Drawing.Point(224, 63)
        Me.btn_gestionIncidencias.Name = "btn_gestionIncidencias"
        Me.btn_gestionIncidencias.Size = New System.Drawing.Size(75, 75)
        Me.btn_gestionIncidencias.TabIndex = 2
        Me.btn_gestionIncidencias.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label7.Location = New System.Drawing.Point(231, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 26)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Gestion de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Incidencias"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_agregarDispositivos
        '
        Me.lbl_agregarDispositivos.BackColor = System.Drawing.Color.Transparent
        Me.lbl_agregarDispositivos.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.lbl_agregarDispositivos.Location = New System.Drawing.Point(340, 141)
        Me.lbl_agregarDispositivos.Name = "lbl_agregarDispositivos"
        Me.lbl_agregarDispositivos.Size = New System.Drawing.Size(63, 26)
        Me.lbl_agregarDispositivos.TabIndex = 14
        Me.lbl_agregarDispositivos.Text = "Gestion de Dispositivos"
        Me.lbl_agregarDispositivos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_administrarUsuarios
        '
        Me.btn_administrarUsuarios.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.ico_administrarUsuarios
        Me.btn_administrarUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_administrarUsuarios.Enabled = False
        Me.btn_administrarUsuarios.FlatAppearance.BorderSize = 2
        Me.btn_administrarUsuarios.Location = New System.Drawing.Point(224, 175)
        Me.btn_administrarUsuarios.Name = "btn_administrarUsuarios"
        Me.btn_administrarUsuarios.Size = New System.Drawing.Size(75, 75)
        Me.btn_administrarUsuarios.TabIndex = 6
        Me.btn_administrarUsuarios.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label8.Location = New System.Drawing.Point(234, 253)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 26)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Administrar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Usuarios"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_agregarDispositivos
        '
        Me.btn_agregarDispositivos.BackColor = System.Drawing.Color.Transparent
        Me.btn_agregarDispositivos.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.ico_gestionDispositivos
        Me.btn_agregarDispositivos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_agregarDispositivos.Enabled = False
        Me.btn_agregarDispositivos.FlatAppearance.BorderSize = 2
        Me.btn_agregarDispositivos.Location = New System.Drawing.Point(333, 63)
        Me.btn_agregarDispositivos.Name = "btn_agregarDispositivos"
        Me.btn_agregarDispositivos.Size = New System.Drawing.Size(75, 75)
        Me.btn_agregarDispositivos.TabIndex = 3
        Me.btn_agregarDispositivos.UseVisualStyleBackColor = False
        '
        'btn_salir
        '
        Me.btn_salir.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.ico_salir
        Me.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_salir.FlatAppearance.BorderSize = 2
        Me.btn_salir.Location = New System.Drawing.Point(431, 63)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(75, 75)
        Me.btn_salir.TabIndex = 4
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_registrarIncidencia
        '
        Me.btn_registrarIncidencia.BackColor = System.Drawing.SystemColors.Control
        Me.btn_registrarIncidencia.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.ico_gestionIncidencias
        Me.btn_registrarIncidencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_registrarIncidencia.Enabled = False
        Me.btn_registrarIncidencia.FlatAppearance.BorderSize = 2
        Me.btn_registrarIncidencia.Location = New System.Drawing.Point(114, 63)
        Me.btn_registrarIncidencia.Name = "btn_registrarIncidencia"
        Me.btn_registrarIncidencia.Size = New System.Drawing.Size(75, 75)
        Me.btn_registrarIncidencia.TabIndex = 1
        Me.btn_registrarIncidencia.UseVisualStyleBackColor = False
        '
        'btn_perfiles
        '
        Me.btn_perfiles.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.ico_perfiles
        Me.btn_perfiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_perfiles.Enabled = False
        Me.btn_perfiles.FlatAppearance.BorderSize = 2
        Me.btn_perfiles.Location = New System.Drawing.Point(333, 175)
        Me.btn_perfiles.Name = "btn_perfiles"
        Me.btn_perfiles.Size = New System.Drawing.Size(75, 75)
        Me.btn_perfiles.TabIndex = 7
        Me.btn_perfiles.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label9.Location = New System.Drawing.Point(352, 257)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Perfiles"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmPrincipal
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.fondoPrincipal
        Me.ClientSize = New System.Drawing.Size(539, 343)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btn_perfiles)
        Me.Controls.Add(Me.btn_registrarIncidencia)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btn_administrarUsuarios)
        Me.Controls.Add(Me.lbl_agregarDispositivos)
        Me.Controls.Add(Me.btn_agregarDispositivos)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btn_gestionIncidencias)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_version)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_ayuda)
        Me.Controls.Add(Me.btn_estadisticasReportes)
        Me.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PRO SyGi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_estadisticasReportes As System.Windows.Forms.Button
    Friend WithEvents btn_ayuda As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
    Friend WithEvents lbl_version As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_gestionIncidencias As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_agregarDispositivos As System.Windows.Forms.Button
    Friend WithEvents lbl_agregarDispositivos As System.Windows.Forms.Label
    Friend WithEvents btn_administrarUsuarios As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btn_registrarIncidencia As System.Windows.Forms.Button
    Friend WithEvents btn_perfiles As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label

End Class
