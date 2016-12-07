<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_gestionIncidencia_agregarEncargado
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
        Me.lbl_asignarUsuario = New System.Windows.Forms.Label()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.dgv_usuarioEncargado = New System.Windows.Forms.DataGridView()
        Me.usuarioEncargado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supervisor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombreUsuarioEncargado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellidoUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.baja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoUsr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.area = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.legajo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_usuarioEncargado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_asignarUsuario
        '
        Me.lbl_asignarUsuario.AutoSize = True
        Me.lbl_asignarUsuario.BackColor = System.Drawing.Color.Transparent
        Me.lbl_asignarUsuario.Location = New System.Drawing.Point(13, 13)
        Me.lbl_asignarUsuario.Name = "lbl_asignarUsuario"
        Me.lbl_asignarUsuario.Size = New System.Drawing.Size(136, 13)
        Me.lbl_asignarUsuario.TabIndex = 0
        Me.lbl_asignarUsuario.Text = "Asignar Usuario Encargado"
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(158, 388)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar.TabIndex = 1
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(250, 388)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 2
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'dgv_usuarioEncargado
        '
        Me.dgv_usuarioEncargado.AllowUserToAddRows = False
        Me.dgv_usuarioEncargado.AllowUserToDeleteRows = False
        Me.dgv_usuarioEncargado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_usuarioEncargado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_usuarioEncargado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.usuarioEncargado, Me.supervisor, Me.nombreUsuarioEncargado, Me.apellidoUsuario, Me.baja, Me.tipoUsr, Me.area, Me.legajo})
        Me.dgv_usuarioEncargado.Location = New System.Drawing.Point(16, 43)
        Me.dgv_usuarioEncargado.Name = "dgv_usuarioEncargado"
        Me.dgv_usuarioEncargado.ReadOnly = True
        Me.dgv_usuarioEncargado.Size = New System.Drawing.Size(309, 327)
        Me.dgv_usuarioEncargado.TabIndex = 3
        '
        'usuarioEncargado
        '
        Me.usuarioEncargado.DataPropertyName = "legajo"
        Me.usuarioEncargado.HeaderText = "usuarioEncargado"
        Me.usuarioEncargado.Name = "usuarioEncargado"
        Me.usuarioEncargado.ReadOnly = True
        Me.usuarioEncargado.Visible = False
        '
        'supervisor
        '
        Me.supervisor.DataPropertyName = "supervisor"
        Me.supervisor.HeaderText = "supervisor"
        Me.supervisor.Name = "supervisor"
        Me.supervisor.ReadOnly = True
        Me.supervisor.Visible = False
        '
        'nombreUsuarioEncargado
        '
        Me.nombreUsuarioEncargado.DataPropertyName = "nombre"
        Me.nombreUsuarioEncargado.HeaderText = "Nombre"
        Me.nombreUsuarioEncargado.Name = "nombreUsuarioEncargado"
        Me.nombreUsuarioEncargado.ReadOnly = True
        '
        'apellidoUsuario
        '
        Me.apellidoUsuario.DataPropertyName = "apellido"
        Me.apellidoUsuario.HeaderText = "Apellido"
        Me.apellidoUsuario.Name = "apellidoUsuario"
        Me.apellidoUsuario.ReadOnly = True
        '
        'baja
        '
        Me.baja.DataPropertyName = "baja"
        Me.baja.HeaderText = "baja"
        Me.baja.Name = "baja"
        Me.baja.ReadOnly = True
        Me.baja.Visible = False
        '
        'tipoUsr
        '
        Me.tipoUsr.DataPropertyName = "tipoUsuario"
        Me.tipoUsr.HeaderText = "tipoUsr"
        Me.tipoUsr.Name = "tipoUsr"
        Me.tipoUsr.ReadOnly = True
        Me.tipoUsr.Visible = False
        '
        'area
        '
        Me.area.DataPropertyName = "area"
        Me.area.HeaderText = "area"
        Me.area.Name = "area"
        Me.area.ReadOnly = True
        Me.area.Visible = False
        '
        'legajo
        '
        Me.legajo.DataPropertyName = "legajo"
        Me.legajo.HeaderText = "legajo"
        Me.legajo.Name = "legajo"
        Me.legajo.ReadOnly = True
        Me.legajo.Visible = False
        '
        'form_gestionIncidencia_agregarEncargado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.fondoPrincipal
        Me.ClientSize = New System.Drawing.Size(342, 423)
        Me.Controls.Add(Me.dgv_usuarioEncargado)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.lbl_asignarUsuario)
        Me.Name = "form_gestionIncidencia_agregarEncargado"
        Me.Text = "form_gestionIncidencia_agregarEncargado"
        CType(Me.dgv_usuarioEncargado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_asignarUsuario As System.Windows.Forms.Label
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents dgv_usuarioEncargado As System.Windows.Forms.DataGridView
    Friend WithEvents usuarioEncargado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents supervisor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombreUsuarioEncargado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents apellidoUsuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents baja As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipoUsr As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents area As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents legajo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
