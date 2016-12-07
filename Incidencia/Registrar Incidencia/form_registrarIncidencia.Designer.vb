<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_registrarIncidencia
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lbl_AreaUsr = New System.Windows.Forms.Label()
        Me.cmb_area = New System.Windows.Forms.ComboBox()
        Me.lbl_dispositivo = New System.Windows.Forms.Label()
        Me.cmb_dispositivo = New System.Windows.Forms.ComboBox()
        Me.lbl_prioridad = New System.Windows.Forms.Label()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.txb_titulo = New System.Windows.Forms.TextBox()
        Me.lbl_descripcion = New System.Windows.Forms.Label()
        Me.txb_descripcion = New System.Windows.Forms.TextBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_enviar = New System.Windows.Forms.Button()
        Me.txb_nroIncidente = New System.Windows.Forms.TextBox()
        Me.rbtn_regincidencia_alta = New System.Windows.Forms.RadioButton()
        Me.rbtn_regincidencia_media = New System.Windows.Forms.RadioButton()
        Me.rbtn_regincidencia_baja = New System.Windows.Forms.RadioButton()
        Me.cmb_usuario = New System.Windows.Forms.ComboBox()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(10, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Incidente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(19, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Usuario"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(233, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Fecha "
        '
        'lbl_AreaUsr
        '
        Me.lbl_AreaUsr.AutoSize = True
        Me.lbl_AreaUsr.BackColor = System.Drawing.Color.Transparent
        Me.lbl_AreaUsr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_AreaUsr.Location = New System.Drawing.Point(233, 103)
        Me.lbl_AreaUsr.Name = "lbl_AreaUsr"
        Me.lbl_AreaUsr.Size = New System.Drawing.Size(33, 13)
        Me.lbl_AreaUsr.TabIndex = 6
        Me.lbl_AreaUsr.Text = "Area"
        '
        'cmb_area
        '
        Me.cmb_area.BackColor = System.Drawing.Color.White
        Me.cmb_area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_area.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_area.FormattingEnabled = True
        Me.cmb_area.Location = New System.Drawing.Point(268, 100)
        Me.cmb_area.Name = "cmb_area"
        Me.cmb_area.Size = New System.Drawing.Size(254, 21)
        Me.cmb_area.TabIndex = 7
        '
        'lbl_dispositivo
        '
        Me.lbl_dispositivo.AutoSize = True
        Me.lbl_dispositivo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_dispositivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dispositivo.Location = New System.Drawing.Point(205, 140)
        Me.lbl_dispositivo.Name = "lbl_dispositivo"
        Me.lbl_dispositivo.Size = New System.Drawing.Size(69, 13)
        Me.lbl_dispositivo.TabIndex = 8
        Me.lbl_dispositivo.Text = "Dispositivo"
        '
        'cmb_dispositivo
        '
        Me.cmb_dispositivo.BackColor = System.Drawing.Color.White
        Me.cmb_dispositivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_dispositivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_dispositivo.FormattingEnabled = True
        Me.cmb_dispositivo.Location = New System.Drawing.Point(276, 137)
        Me.cmb_dispositivo.Name = "cmb_dispositivo"
        Me.cmb_dispositivo.Size = New System.Drawing.Size(246, 21)
        Me.cmb_dispositivo.TabIndex = 8
        '
        'lbl_prioridad
        '
        Me.lbl_prioridad.AutoSize = True
        Me.lbl_prioridad.BackColor = System.Drawing.Color.Transparent
        Me.lbl_prioridad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_prioridad.ForeColor = System.Drawing.Color.White
        Me.lbl_prioridad.Location = New System.Drawing.Point(19, 137)
        Me.lbl_prioridad.Name = "lbl_prioridad"
        Me.lbl_prioridad.Size = New System.Drawing.Size(57, 13)
        Me.lbl_prioridad.TabIndex = 10
        Me.lbl_prioridad.Text = "Prioridad"
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titulo.ForeColor = System.Drawing.Color.White
        Me.lbl_titulo.Location = New System.Drawing.Point(19, 55)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(39, 13)
        Me.lbl_titulo.TabIndex = 12
        Me.lbl_titulo.Text = "Titulo"
        '
        'txb_titulo
        '
        Me.txb_titulo.Location = New System.Drawing.Point(71, 52)
        Me.txb_titulo.Name = "txb_titulo"
        Me.txb_titulo.Size = New System.Drawing.Size(451, 20)
        Me.txb_titulo.TabIndex = 2
        '
        'lbl_descripcion
        '
        Me.lbl_descripcion.AutoSize = True
        Me.lbl_descripcion.BackColor = System.Drawing.Color.Transparent
        Me.lbl_descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_descripcion.ForeColor = System.Drawing.Color.White
        Me.lbl_descripcion.Location = New System.Drawing.Point(19, 168)
        Me.lbl_descripcion.Name = "lbl_descripcion"
        Me.lbl_descripcion.Size = New System.Drawing.Size(74, 13)
        Me.lbl_descripcion.TabIndex = 14
        Me.lbl_descripcion.Text = "Descripcion"
        '
        'txb_descripcion
        '
        Me.txb_descripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txb_descripcion.Location = New System.Drawing.Point(17, 184)
        Me.txb_descripcion.MaxLength = 350
        Me.txb_descripcion.Multiline = True
        Me.txb_descripcion.Name = "txb_descripcion"
        Me.txb_descripcion.Size = New System.Drawing.Size(505, 136)
        Me.txb_descripcion.TabIndex = 9
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.White
        Me.btn_cancelar.Location = New System.Drawing.Point(447, 326)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 11
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'btn_enviar
        '
        Me.btn_enviar.BackColor = System.Drawing.Color.White
        Me.btn_enviar.Location = New System.Drawing.Point(366, 326)
        Me.btn_enviar.Name = "btn_enviar"
        Me.btn_enviar.Size = New System.Drawing.Size(75, 23)
        Me.btn_enviar.TabIndex = 10
        Me.btn_enviar.Text = "Enviar"
        Me.btn_enviar.UseVisualStyleBackColor = False
        '
        'txb_nroIncidente
        '
        Me.txb_nroIncidente.Enabled = False
        Me.txb_nroIncidente.Location = New System.Drawing.Point(71, 12)
        Me.txb_nroIncidente.Name = "txb_nroIncidente"
        Me.txb_nroIncidente.Size = New System.Drawing.Size(140, 20)
        Me.txb_nroIncidente.TabIndex = 1
        '
        'rbtn_regincidencia_alta
        '
        Me.rbtn_regincidencia_alta.AutoSize = True
        Me.rbtn_regincidencia_alta.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_regincidencia_alta.ForeColor = System.Drawing.Color.Red
        Me.rbtn_regincidencia_alta.Location = New System.Drawing.Point(171, 135)
        Me.rbtn_regincidencia_alta.Name = "rbtn_regincidencia_alta"
        Me.rbtn_regincidencia_alta.Size = New System.Drawing.Size(33, 17)
        Me.rbtn_regincidencia_alta.TabIndex = 6
        Me.rbtn_regincidencia_alta.Text = "▌"
        Me.rbtn_regincidencia_alta.UseVisualStyleBackColor = False
        '
        'rbtn_regincidencia_media
        '
        Me.rbtn_regincidencia_media.AutoSize = True
        Me.rbtn_regincidencia_media.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_regincidencia_media.ForeColor = System.Drawing.Color.Yellow
        Me.rbtn_regincidencia_media.Location = New System.Drawing.Point(126, 135)
        Me.rbtn_regincidencia_media.Name = "rbtn_regincidencia_media"
        Me.rbtn_regincidencia_media.Size = New System.Drawing.Size(33, 17)
        Me.rbtn_regincidencia_media.TabIndex = 5
        Me.rbtn_regincidencia_media.TabStop = True
        Me.rbtn_regincidencia_media.Text = "▌"
        Me.rbtn_regincidencia_media.UseVisualStyleBackColor = False
        '
        'rbtn_regincidencia_baja
        '
        Me.rbtn_regincidencia_baja.AutoSize = True
        Me.rbtn_regincidencia_baja.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_regincidencia_baja.Checked = True
        Me.rbtn_regincidencia_baja.ForeColor = System.Drawing.Color.Lime
        Me.rbtn_regincidencia_baja.Location = New System.Drawing.Point(79, 135)
        Me.rbtn_regincidencia_baja.Name = "rbtn_regincidencia_baja"
        Me.rbtn_regincidencia_baja.Size = New System.Drawing.Size(33, 17)
        Me.rbtn_regincidencia_baja.TabIndex = 4
        Me.rbtn_regincidencia_baja.TabStop = True
        Me.rbtn_regincidencia_baja.Text = "▌"
        Me.rbtn_regincidencia_baja.UseVisualStyleBackColor = False
        '
        'cmb_usuario
        '
        Me.cmb_usuario.BackColor = System.Drawing.Color.White
        Me.cmb_usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_usuario.FormattingEnabled = True
        Me.cmb_usuario.Location = New System.Drawing.Point(71, 95)
        Me.cmb_usuario.Name = "cmb_usuario"
        Me.cmb_usuario.Size = New System.Drawing.Size(156, 21)
        Me.cmb_usuario.TabIndex = 24
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Location = New System.Drawing.Point(285, 12)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(200, 20)
        Me.dtp_fecha.TabIndex = 25
        '
        'form_registrarIncidencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.fondoPrincipal
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(534, 362)
        Me.Controls.Add(Me.dtp_fecha)
        Me.Controls.Add(Me.cmb_usuario)
        Me.Controls.Add(Me.rbtn_regincidencia_baja)
        Me.Controls.Add(Me.rbtn_regincidencia_media)
        Me.Controls.Add(Me.rbtn_regincidencia_alta)
        Me.Controls.Add(Me.txb_nroIncidente)
        Me.Controls.Add(Me.btn_enviar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.txb_descripcion)
        Me.Controls.Add(Me.lbl_descripcion)
        Me.Controls.Add(Me.txb_titulo)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.lbl_prioridad)
        Me.Controls.Add(Me.cmb_dispositivo)
        Me.Controls.Add(Me.lbl_dispositivo)
        Me.Controls.Add(Me.cmb_area)
        Me.Controls.Add(Me.lbl_AreaUsr)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(550, 400)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(550, 400)
        Me.Name = "form_registrarIncidencia"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Incidencia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lbl_AreaUsr As System.Windows.Forms.Label
    Friend WithEvents cmb_area As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_dispositivo As System.Windows.Forms.Label
    Friend WithEvents cmb_dispositivo As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_prioridad As System.Windows.Forms.Label
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents txb_titulo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_descripcion As System.Windows.Forms.Label
    Friend WithEvents txb_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_enviar As System.Windows.Forms.Button
    Friend WithEvents txb_nroIncidente As System.Windows.Forms.TextBox
    Friend WithEvents rbtn_regincidencia_alta As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_regincidencia_media As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_regincidencia_baja As System.Windows.Forms.RadioButton
    Friend WithEvents cmb_usuario As System.Windows.Forms.ComboBox
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
End Class
