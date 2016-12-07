<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporte
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
        Me.components = New System.ComponentModel.Container()
        Me.crvInforme = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ListadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DispositivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IncidenciasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadisticasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerfilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IncidenciasEstadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.chk_disp_baja = New System.Windows.Forms.CheckBox()
        Me.btn_generar = New System.Windows.Forms.Button()
        Me.cmb_estado = New System.Windows.Forms.ComboBox()
        Me.lbl_text = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'crvInforme
        '
        Me.crvInforme.ActiveViewIndex = -1
        Me.crvInforme.AutoSize = True
        Me.crvInforme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvInforme.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvInforme.DisplayStatusBar = False
        Me.crvInforme.DisplayToolbar = False
        Me.crvInforme.Location = New System.Drawing.Point(12, 82)
        Me.crvInforme.Name = "crvInforme"
        Me.crvInforme.Size = New System.Drawing.Size(910, 590)
        Me.crvInforme.TabIndex = 0
        Me.crvInforme.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListadosToolStripMenuItem, Me.EstadisticasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(934, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ListadosToolStripMenuItem
        '
        Me.ListadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DispositivosToolStripMenuItem, Me.IncidenciasToolStripMenuItem})
        Me.ListadosToolStripMenuItem.Name = "ListadosToolStripMenuItem"
        Me.ListadosToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.ListadosToolStripMenuItem.Text = "Listados"
        '
        'DispositivosToolStripMenuItem
        '
        Me.DispositivosToolStripMenuItem.Name = "DispositivosToolStripMenuItem"
        Me.DispositivosToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.DispositivosToolStripMenuItem.Text = "Dispositivos"
        '
        'IncidenciasToolStripMenuItem
        '
        Me.IncidenciasToolStripMenuItem.Name = "IncidenciasToolStripMenuItem"
        Me.IncidenciasToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.IncidenciasToolStripMenuItem.Text = "Incidencias"
        '
        'EstadisticasToolStripMenuItem
        '
        Me.EstadisticasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PerfilesToolStripMenuItem, Me.IncidenciasEstadosToolStripMenuItem})
        Me.EstadisticasToolStripMenuItem.Name = "EstadisticasToolStripMenuItem"
        Me.EstadisticasToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.EstadisticasToolStripMenuItem.Text = "Estadisticas"
        '
        'PerfilesToolStripMenuItem
        '
        Me.PerfilesToolStripMenuItem.Name = "PerfilesToolStripMenuItem"
        Me.PerfilesToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.PerfilesToolStripMenuItem.Text = "Usuarios de Perfiles"
        '
        'IncidenciasEstadosToolStripMenuItem
        '
        Me.IncidenciasEstadosToolStripMenuItem.Name = "IncidenciasEstadosToolStripMenuItem"
        Me.IncidenciasEstadosToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.IncidenciasEstadosToolStripMenuItem.Text = "Incidencias por Fecha"
        '
        'chk_disp_baja
        '
        Me.chk_disp_baja.AutoSize = True
        Me.chk_disp_baja.BackColor = System.Drawing.Color.Transparent
        Me.chk_disp_baja.Location = New System.Drawing.Point(164, 44)
        Me.chk_disp_baja.Name = "chk_disp_baja"
        Me.chk_disp_baja.Size = New System.Drawing.Size(183, 17)
        Me.chk_disp_baja.TabIndex = 7
        Me.chk_disp_baja.Text = "¿Mostrar los dispositivos activos?"
        Me.chk_disp_baja.UseVisualStyleBackColor = False
        '
        'btn_generar
        '
        Me.btn_generar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_generar.Location = New System.Drawing.Point(650, 31)
        Me.btn_generar.Name = "btn_generar"
        Me.btn_generar.Size = New System.Drawing.Size(272, 40)
        Me.btn_generar.TabIndex = 8
        Me.btn_generar.Text = "Generar Reporte"
        Me.btn_generar.UseVisualStyleBackColor = False
        '
        'cmb_estado
        '
        Me.cmb_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_estado.FormattingEnabled = True
        Me.cmb_estado.Location = New System.Drawing.Point(164, 50)
        Me.cmb_estado.Name = "cmb_estado"
        Me.cmb_estado.Size = New System.Drawing.Size(183, 21)
        Me.cmb_estado.TabIndex = 9
        '
        'lbl_text
        '
        Me.lbl_text.AutoSize = True
        Me.lbl_text.BackColor = System.Drawing.Color.Transparent
        Me.lbl_text.Location = New System.Drawing.Point(161, 28)
        Me.lbl_text.Name = "lbl_text"
        Me.lbl_text.Size = New System.Drawing.Size(35, 13)
        Me.lbl_text.TabIndex = 10
        Me.lbl_text.Text = "[label]"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(164, 50)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 13
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(380, 50)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 14
        '
        'Reporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.fondoPrincipal
        Me.ClientSize = New System.Drawing.Size(934, 684)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lbl_text)
        Me.Controls.Add(Me.cmb_estado)
        Me.Controls.Add(Me.btn_generar)
        Me.Controls.Add(Me.chk_disp_baja)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.crvInforme)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Reporte"
        Me.Text = "Informes"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents crvInforme As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ListadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DispositivosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstadisticasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PerfilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IncidenciasEstadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chk_disp_baja As System.Windows.Forms.CheckBox
    Friend WithEvents btn_generar As System.Windows.Forms.Button
    Friend WithEvents IncidenciasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmb_estado As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_text As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
End Class
