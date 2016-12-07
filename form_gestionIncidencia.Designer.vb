<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_gestionIncidencia
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
        Me.dgv_incidencia = New System.Windows.Forms.DataGridView()
        Me.codIncidencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.baja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.titulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usuarioFinal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaCarga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaCierre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.area = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prioridad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usuarioSupervisor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dispositivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgv_detalle = New System.Windows.Forms.DataGridView()
        Me.cmb_incidencia_area = New System.Windows.Forms.ComboBox()
        Me.lbl_incidencia_area = New System.Windows.Forms.Label()
        Me.lbl_incidencia_prioridad = New System.Windows.Forms.Label()
        Me.lbl_incidencia_estado = New System.Windows.Forms.Label()
        Me.cmb_incidencia_estado = New System.Windows.Forms.ComboBox()
        Me.lbl_incidencia_usuario = New System.Windows.Forms.Label()
        Me.cmb_incidencia_usuario = New System.Windows.Forms.ComboBox()
        Me.cbox_incidencia_area = New System.Windows.Forms.CheckBox()
        Me.cbox_incidencia_prioridad = New System.Windows.Forms.CheckBox()
        Me.cbox_incidencia_estado = New System.Windows.Forms.CheckBox()
        Me.cbox_incidencia_usuario = New System.Windows.Forms.CheckBox()
        Me.btn_incidencia_limpiar = New System.Windows.Forms.Button()
        Me.btn_incidencia_buscar = New System.Windows.Forms.Button()
        Me.txtbox_incidencia_nro = New System.Windows.Forms.TextBox()
        Me.txtbox_incidencia_titulo = New System.Windows.Forms.TextBox()
        Me.txtbox_incidencia_descripcion = New System.Windows.Forms.TextBox()
        Me.rbtn_incidencia_prioridad_alta = New System.Windows.Forms.RadioButton()
        Me.rbtn_incidencia_prioridad_media = New System.Windows.Forms.RadioButton()
        Me.rbtn_incidencia_prioridad_baja = New System.Windows.Forms.RadioButton()
        Me.txt_nroOrden = New System.Windows.Forms.TextBox()
        Me.lbl_nroOrden = New System.Windows.Forms.Label()
        Me.lbl_fechaAtencion = New System.Windows.Forms.Label()
        Me.lbl_detalleIncidente = New System.Windows.Forms.Label()
        Me.lbl_fechaActual = New System.Windows.Forms.Label()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.txb_titulo = New System.Windows.Forms.TextBox()
        Me.chk_estado = New System.Windows.Forms.CheckBox()
        Me.cmb_estado = New System.Windows.Forms.ComboBox()
        Me.chk_prioridad = New System.Windows.Forms.CheckBox()
        Me.rbtn_detalle_baja = New System.Windows.Forms.RadioButton()
        Me.rbtn_detalle_media = New System.Windows.Forms.RadioButton()
        Me.rbtn_detalle_alta = New System.Windows.Forms.RadioButton()
        Me.lbl_descripcion = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txb_duracion = New System.Windows.Forms.TextBox()
        Me.lbl_duracion = New System.Windows.Forms.Label()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_nuevoDetalle = New System.Windows.Forms.Button()
        Me.btn_consultarDetalle = New System.Windows.Forms.Button()
        CType(Me.dgv_incidencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_incidencia
        '
        Me.dgv_incidencia.AllowUserToAddRows = False
        Me.dgv_incidencia.AllowUserToDeleteRows = False
        Me.dgv_incidencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_incidencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_incidencia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codIncidencia, Me.baja, Me.titulo, Me.descripcion, Me.usuarioFinal, Me.fechaCarga, Me.fechaCierre, Me.area, Me.estado, Me.prioridad, Me.usuarioSupervisor, Me.dispositivo})
        Me.dgv_incidencia.Location = New System.Drawing.Point(30, 108)
        Me.dgv_incidencia.Name = "dgv_incidencia"
        Me.dgv_incidencia.ReadOnly = True
        Me.dgv_incidencia.Size = New System.Drawing.Size(860, 297)
        Me.dgv_incidencia.TabIndex = 0
        '
        'codIncidencia
        '
        Me.codIncidencia.DataPropertyName = "codIncidencia"
        Me.codIncidencia.HeaderText = "Nro"
        Me.codIncidencia.Name = "codIncidencia"
        Me.codIncidencia.ReadOnly = True
        '
        'baja
        '
        Me.baja.DataPropertyName = "baja"
        Me.baja.HeaderText = "baja"
        Me.baja.Name = "baja"
        Me.baja.ReadOnly = True
        Me.baja.Visible = False
        '
        'titulo
        '
        Me.titulo.DataPropertyName = "titulo"
        Me.titulo.HeaderText = "Titulo"
        Me.titulo.Name = "titulo"
        Me.titulo.ReadOnly = True
        '
        'descripcion
        '
        Me.descripcion.DataPropertyName = "descripcion"
        Me.descripcion.HeaderText = "Descripcion"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Visible = False
        '
        'usuarioFinal
        '
        Me.usuarioFinal.DataPropertyName = "usuarioFinal"
        Me.usuarioFinal.HeaderText = "Usuario"
        Me.usuarioFinal.Name = "usuarioFinal"
        Me.usuarioFinal.ReadOnly = True
        '
        'fechaCarga
        '
        Me.fechaCarga.DataPropertyName = "fechaCarga"
        Me.fechaCarga.HeaderText = "Fecha Carga"
        Me.fechaCarga.Name = "fechaCarga"
        Me.fechaCarga.ReadOnly = True
        '
        'fechaCierre
        '
        Me.fechaCierre.DataPropertyName = "fechaCierre"
        Me.fechaCierre.HeaderText = "Fecha Cierre"
        Me.fechaCierre.Name = "fechaCierre"
        Me.fechaCierre.ReadOnly = True
        '
        'area
        '
        Me.area.DataPropertyName = "area"
        Me.area.HeaderText = "Area"
        Me.area.Name = "area"
        Me.area.ReadOnly = True
        '
        'estado
        '
        Me.estado.DataPropertyName = "estado"
        Me.estado.HeaderText = "Estado"
        Me.estado.Name = "estado"
        Me.estado.ReadOnly = True
        '
        'prioridad
        '
        Me.prioridad.DataPropertyName = "prioridad"
        Me.prioridad.HeaderText = "Prioridad"
        Me.prioridad.Name = "prioridad"
        Me.prioridad.ReadOnly = True
        '
        'usuarioSupervisor
        '
        Me.usuarioSupervisor.DataPropertyName = "usuarioSupervisor"
        Me.usuarioSupervisor.HeaderText = "Usuario Encargado"
        Me.usuarioSupervisor.Name = "usuarioSupervisor"
        Me.usuarioSupervisor.ReadOnly = True
        '
        'dispositivo
        '
        Me.dispositivo.DataPropertyName = "dispositivo"
        Me.dispositivo.HeaderText = "Dispositivo"
        Me.dispositivo.Name = "dispositivo"
        Me.dispositivo.ReadOnly = True
        '
        'dgv_detalle
        '
        Me.dgv_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detalle.Location = New System.Drawing.Point(30, 445)
        Me.dgv_detalle.Name = "dgv_detalle"
        Me.dgv_detalle.Size = New System.Drawing.Size(860, 289)
        Me.dgv_detalle.TabIndex = 1
        '
        'cmb_incidencia_area
        '
        Me.cmb_incidencia_area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_incidencia_area.Enabled = False
        Me.cmb_incidencia_area.FormattingEnabled = True
        Me.cmb_incidencia_area.Location = New System.Drawing.Point(635, 25)
        Me.cmb_incidencia_area.Name = "cmb_incidencia_area"
        Me.cmb_incidencia_area.Size = New System.Drawing.Size(177, 21)
        Me.cmb_incidencia_area.TabIndex = 2
        '
        'lbl_incidencia_area
        '
        Me.lbl_incidencia_area.AutoSize = True
        Me.lbl_incidencia_area.Enabled = False
        Me.lbl_incidencia_area.Location = New System.Drawing.Point(578, 27)
        Me.lbl_incidencia_area.Name = "lbl_incidencia_area"
        Me.lbl_incidencia_area.Size = New System.Drawing.Size(29, 13)
        Me.lbl_incidencia_area.TabIndex = 3
        Me.lbl_incidencia_area.Text = "Area"
        '
        'lbl_incidencia_prioridad
        '
        Me.lbl_incidencia_prioridad.AutoSize = True
        Me.lbl_incidencia_prioridad.Enabled = False
        Me.lbl_incidencia_prioridad.Location = New System.Drawing.Point(385, 66)
        Me.lbl_incidencia_prioridad.Name = "lbl_incidencia_prioridad"
        Me.lbl_incidencia_prioridad.Size = New System.Drawing.Size(48, 13)
        Me.lbl_incidencia_prioridad.TabIndex = 5
        Me.lbl_incidencia_prioridad.Text = "Prioridad"
        '
        'lbl_incidencia_estado
        '
        Me.lbl_incidencia_estado.AutoSize = True
        Me.lbl_incidencia_estado.Enabled = False
        Me.lbl_incidencia_estado.Location = New System.Drawing.Point(393, 29)
        Me.lbl_incidencia_estado.Name = "lbl_incidencia_estado"
        Me.lbl_incidencia_estado.Size = New System.Drawing.Size(40, 13)
        Me.lbl_incidencia_estado.TabIndex = 7
        Me.lbl_incidencia_estado.Text = "Estado"
        '
        'cmb_incidencia_estado
        '
        Me.cmb_incidencia_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_incidencia_estado.Enabled = False
        Me.cmb_incidencia_estado.FormattingEnabled = True
        Me.cmb_incidencia_estado.Location = New System.Drawing.Point(460, 27)
        Me.cmb_incidencia_estado.Name = "cmb_incidencia_estado"
        Me.cmb_incidencia_estado.Size = New System.Drawing.Size(98, 21)
        Me.cmb_incidencia_estado.TabIndex = 6
        '
        'lbl_incidencia_usuario
        '
        Me.lbl_incidencia_usuario.AutoSize = True
        Me.lbl_incidencia_usuario.Enabled = False
        Me.lbl_incidencia_usuario.Location = New System.Drawing.Point(564, 67)
        Me.lbl_incidencia_usuario.Name = "lbl_incidencia_usuario"
        Me.lbl_incidencia_usuario.Size = New System.Drawing.Size(43, 13)
        Me.lbl_incidencia_usuario.TabIndex = 9
        Me.lbl_incidencia_usuario.Text = "Usuario"
        '
        'cmb_incidencia_usuario
        '
        Me.cmb_incidencia_usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_incidencia_usuario.Enabled = False
        Me.cmb_incidencia_usuario.FormattingEnabled = True
        Me.cmb_incidencia_usuario.Location = New System.Drawing.Point(635, 64)
        Me.cmb_incidencia_usuario.Name = "cmb_incidencia_usuario"
        Me.cmb_incidencia_usuario.Size = New System.Drawing.Size(177, 21)
        Me.cmb_incidencia_usuario.TabIndex = 8
        '
        'cbox_incidencia_area
        '
        Me.cbox_incidencia_area.AutoSize = True
        Me.cbox_incidencia_area.Location = New System.Drawing.Point(613, 28)
        Me.cbox_incidencia_area.Name = "cbox_incidencia_area"
        Me.cbox_incidencia_area.Size = New System.Drawing.Size(15, 14)
        Me.cbox_incidencia_area.TabIndex = 14
        Me.cbox_incidencia_area.UseVisualStyleBackColor = True
        '
        'cbox_incidencia_prioridad
        '
        Me.cbox_incidencia_prioridad.AutoSize = True
        Me.cbox_incidencia_prioridad.Location = New System.Drawing.Point(439, 66)
        Me.cbox_incidencia_prioridad.Name = "cbox_incidencia_prioridad"
        Me.cbox_incidencia_prioridad.Size = New System.Drawing.Size(15, 14)
        Me.cbox_incidencia_prioridad.TabIndex = 15
        Me.cbox_incidencia_prioridad.UseVisualStyleBackColor = True
        '
        'cbox_incidencia_estado
        '
        Me.cbox_incidencia_estado.AutoSize = True
        Me.cbox_incidencia_estado.Location = New System.Drawing.Point(439, 29)
        Me.cbox_incidencia_estado.Name = "cbox_incidencia_estado"
        Me.cbox_incidencia_estado.Size = New System.Drawing.Size(15, 14)
        Me.cbox_incidencia_estado.TabIndex = 16
        Me.cbox_incidencia_estado.UseVisualStyleBackColor = True
        '
        'cbox_incidencia_usuario
        '
        Me.cbox_incidencia_usuario.AutoSize = True
        Me.cbox_incidencia_usuario.Location = New System.Drawing.Point(613, 67)
        Me.cbox_incidencia_usuario.Name = "cbox_incidencia_usuario"
        Me.cbox_incidencia_usuario.Size = New System.Drawing.Size(15, 14)
        Me.cbox_incidencia_usuario.TabIndex = 17
        Me.cbox_incidencia_usuario.UseVisualStyleBackColor = True
        '
        'btn_incidencia_limpiar
        '
        Me.btn_incidencia_limpiar.Location = New System.Drawing.Point(818, 25)
        Me.btn_incidencia_limpiar.Name = "btn_incidencia_limpiar"
        Me.btn_incidencia_limpiar.Size = New System.Drawing.Size(72, 23)
        Me.btn_incidencia_limpiar.TabIndex = 18
        Me.btn_incidencia_limpiar.Text = "Limpiar"
        Me.btn_incidencia_limpiar.UseVisualStyleBackColor = True
        '
        'btn_incidencia_buscar
        '
        Me.btn_incidencia_buscar.Location = New System.Drawing.Point(818, 63)
        Me.btn_incidencia_buscar.Name = "btn_incidencia_buscar"
        Me.btn_incidencia_buscar.Size = New System.Drawing.Size(72, 23)
        Me.btn_incidencia_buscar.TabIndex = 19
        Me.btn_incidencia_buscar.Text = "Buscar"
        Me.btn_incidencia_buscar.UseVisualStyleBackColor = True
        '
        'txtbox_incidencia_nro
        '
        Me.txtbox_incidencia_nro.Enabled = False
        Me.txtbox_incidencia_nro.Location = New System.Drawing.Point(30, 19)
        Me.txtbox_incidencia_nro.Name = "txtbox_incidencia_nro"
        Me.txtbox_incidencia_nro.Size = New System.Drawing.Size(57, 20)
        Me.txtbox_incidencia_nro.TabIndex = 20
        Me.txtbox_incidencia_nro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtbox_incidencia_titulo
        '
        Me.txtbox_incidencia_titulo.Enabled = False
        Me.txtbox_incidencia_titulo.Location = New System.Drawing.Point(93, 19)
        Me.txtbox_incidencia_titulo.Name = "txtbox_incidencia_titulo"
        Me.txtbox_incidencia_titulo.Size = New System.Drawing.Size(284, 20)
        Me.txtbox_incidencia_titulo.TabIndex = 21
        '
        'txtbox_incidencia_descripcion
        '
        Me.txtbox_incidencia_descripcion.Enabled = False
        Me.txtbox_incidencia_descripcion.Location = New System.Drawing.Point(30, 45)
        Me.txtbox_incidencia_descripcion.Multiline = True
        Me.txtbox_incidencia_descripcion.Name = "txtbox_incidencia_descripcion"
        Me.txtbox_incidencia_descripcion.Size = New System.Drawing.Size(347, 41)
        Me.txtbox_incidencia_descripcion.TabIndex = 22
        '
        'rbtn_incidencia_prioridad_alta
        '
        Me.rbtn_incidencia_prioridad_alta.AutoSize = True
        Me.rbtn_incidencia_prioridad_alta.Enabled = False
        Me.rbtn_incidencia_prioridad_alta.ForeColor = System.Drawing.Color.Red
        Me.rbtn_incidencia_prioridad_alta.Location = New System.Drawing.Point(528, 64)
        Me.rbtn_incidencia_prioridad_alta.Name = "rbtn_incidencia_prioridad_alta"
        Me.rbtn_incidencia_prioridad_alta.Size = New System.Drawing.Size(30, 17)
        Me.rbtn_incidencia_prioridad_alta.TabIndex = 23
        Me.rbtn_incidencia_prioridad_alta.TabStop = True
        Me.rbtn_incidencia_prioridad_alta.Text = "▌"
        Me.rbtn_incidencia_prioridad_alta.UseVisualStyleBackColor = True
        '
        'rbtn_incidencia_prioridad_media
        '
        Me.rbtn_incidencia_prioridad_media.AutoSize = True
        Me.rbtn_incidencia_prioridad_media.Enabled = False
        Me.rbtn_incidencia_prioridad_media.ForeColor = System.Drawing.Color.Yellow
        Me.rbtn_incidencia_prioridad_media.Location = New System.Drawing.Point(497, 64)
        Me.rbtn_incidencia_prioridad_media.Name = "rbtn_incidencia_prioridad_media"
        Me.rbtn_incidencia_prioridad_media.Size = New System.Drawing.Size(30, 17)
        Me.rbtn_incidencia_prioridad_media.TabIndex = 24
        Me.rbtn_incidencia_prioridad_media.TabStop = True
        Me.rbtn_incidencia_prioridad_media.Text = "▌"
        Me.rbtn_incidencia_prioridad_media.UseVisualStyleBackColor = True
        '
        'rbtn_incidencia_prioridad_baja
        '
        Me.rbtn_incidencia_prioridad_baja.AutoSize = True
        Me.rbtn_incidencia_prioridad_baja.Enabled = False
        Me.rbtn_incidencia_prioridad_baja.ForeColor = System.Drawing.Color.Lime
        Me.rbtn_incidencia_prioridad_baja.Location = New System.Drawing.Point(462, 64)
        Me.rbtn_incidencia_prioridad_baja.Name = "rbtn_incidencia_prioridad_baja"
        Me.rbtn_incidencia_prioridad_baja.Size = New System.Drawing.Size(30, 17)
        Me.rbtn_incidencia_prioridad_baja.TabIndex = 25
        Me.rbtn_incidencia_prioridad_baja.TabStop = True
        Me.rbtn_incidencia_prioridad_baja.Text = "▌"
        Me.rbtn_incidencia_prioridad_baja.UseVisualStyleBackColor = True
        '
        'txt_nroOrden
        '
        Me.txt_nroOrden.Location = New System.Drawing.Point(996, 26)
        Me.txt_nroOrden.Name = "txt_nroOrden"
        Me.txt_nroOrden.Size = New System.Drawing.Size(50, 20)
        Me.txt_nroOrden.TabIndex = 26
        '
        'lbl_nroOrden
        '
        Me.lbl_nroOrden.AutoSize = True
        Me.lbl_nroOrden.Location = New System.Drawing.Point(914, 29)
        Me.lbl_nroOrden.Name = "lbl_nroOrden"
        Me.lbl_nroOrden.Size = New System.Drawing.Size(76, 13)
        Me.lbl_nroOrden.TabIndex = 27
        Me.lbl_nroOrden.Text = "Numero Orden"
        '
        'lbl_fechaAtencion
        '
        Me.lbl_fechaAtencion.AutoSize = True
        Me.lbl_fechaAtencion.Location = New System.Drawing.Point(1061, 26)
        Me.lbl_fechaAtencion.Name = "lbl_fechaAtencion"
        Me.lbl_fechaAtencion.Size = New System.Drawing.Size(82, 13)
        Me.lbl_fechaAtencion.TabIndex = 28
        Me.lbl_fechaAtencion.Text = "Fecha Atencion"
        '
        'lbl_detalleIncidente
        '
        Me.lbl_detalleIncidente.AutoSize = True
        Me.lbl_detalleIncidente.Location = New System.Drawing.Point(30, 416)
        Me.lbl_detalleIncidente.Name = "lbl_detalleIncidente"
        Me.lbl_detalleIncidente.Size = New System.Drawing.Size(109, 13)
        Me.lbl_detalleIncidente.TabIndex = 29
        Me.lbl_detalleIncidente.Text = "Detalles del Incidente"
        '
        'lbl_fechaActual
        '
        Me.lbl_fechaActual.AutoSize = True
        Me.lbl_fechaActual.Location = New System.Drawing.Point(1149, 26)
        Me.lbl_fechaActual.Name = "lbl_fechaActual"
        Me.lbl_fechaActual.Size = New System.Drawing.Size(67, 13)
        Me.lbl_fechaActual.TabIndex = 30
        Me.lbl_fechaActual.Text = "FechaActual"
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.Location = New System.Drawing.Point(917, 62)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(33, 13)
        Me.lbl_titulo.TabIndex = 31
        Me.lbl_titulo.Text = "Titulo"
        '
        'txb_titulo
        '
        Me.txb_titulo.Location = New System.Drawing.Point(956, 59)
        Me.txb_titulo.Name = "txb_titulo"
        Me.txb_titulo.Size = New System.Drawing.Size(260, 20)
        Me.txb_titulo.TabIndex = 32
        '
        'chk_estado
        '
        Me.chk_estado.AutoSize = True
        Me.chk_estado.Location = New System.Drawing.Point(920, 87)
        Me.chk_estado.Name = "chk_estado"
        Me.chk_estado.Size = New System.Drawing.Size(59, 17)
        Me.chk_estado.TabIndex = 33
        Me.chk_estado.Text = "Estado"
        Me.chk_estado.UseVisualStyleBackColor = True
        '
        'cmb_estado
        '
        Me.cmb_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_estado.Enabled = False
        Me.cmb_estado.FormattingEnabled = True
        Me.cmb_estado.Location = New System.Drawing.Point(985, 85)
        Me.cmb_estado.Name = "cmb_estado"
        Me.cmb_estado.Size = New System.Drawing.Size(231, 21)
        Me.cmb_estado.TabIndex = 35
        '
        'chk_prioridad
        '
        Me.chk_prioridad.AutoSize = True
        Me.chk_prioridad.Location = New System.Drawing.Point(920, 112)
        Me.chk_prioridad.Name = "chk_prioridad"
        Me.chk_prioridad.Size = New System.Drawing.Size(67, 17)
        Me.chk_prioridad.TabIndex = 36
        Me.chk_prioridad.Text = "Prioridad"
        Me.chk_prioridad.UseVisualStyleBackColor = True
        '
        'rbtn_detalle_baja
        '
        Me.rbtn_detalle_baja.AutoSize = True
        Me.rbtn_detalle_baja.Enabled = False
        Me.rbtn_detalle_baja.ForeColor = System.Drawing.Color.Lime
        Me.rbtn_detalle_baja.Location = New System.Drawing.Point(993, 112)
        Me.rbtn_detalle_baja.Name = "rbtn_detalle_baja"
        Me.rbtn_detalle_baja.Size = New System.Drawing.Size(30, 17)
        Me.rbtn_detalle_baja.TabIndex = 39
        Me.rbtn_detalle_baja.TabStop = True
        Me.rbtn_detalle_baja.Text = "▌"
        Me.rbtn_detalle_baja.UseVisualStyleBackColor = True
        '
        'rbtn_detalle_media
        '
        Me.rbtn_detalle_media.AutoSize = True
        Me.rbtn_detalle_media.Enabled = False
        Me.rbtn_detalle_media.ForeColor = System.Drawing.Color.Yellow
        Me.rbtn_detalle_media.Location = New System.Drawing.Point(1028, 112)
        Me.rbtn_detalle_media.Name = "rbtn_detalle_media"
        Me.rbtn_detalle_media.Size = New System.Drawing.Size(30, 17)
        Me.rbtn_detalle_media.TabIndex = 38
        Me.rbtn_detalle_media.TabStop = True
        Me.rbtn_detalle_media.Text = "▌"
        Me.rbtn_detalle_media.UseVisualStyleBackColor = True
        '
        'rbtn_detalle_alta
        '
        Me.rbtn_detalle_alta.AutoSize = True
        Me.rbtn_detalle_alta.Enabled = False
        Me.rbtn_detalle_alta.ForeColor = System.Drawing.Color.Red
        Me.rbtn_detalle_alta.Location = New System.Drawing.Point(1059, 112)
        Me.rbtn_detalle_alta.Name = "rbtn_detalle_alta"
        Me.rbtn_detalle_alta.Size = New System.Drawing.Size(30, 17)
        Me.rbtn_detalle_alta.TabIndex = 37
        Me.rbtn_detalle_alta.TabStop = True
        Me.rbtn_detalle_alta.Text = "▌"
        Me.rbtn_detalle_alta.UseVisualStyleBackColor = True
        '
        'lbl_descripcion
        '
        Me.lbl_descripcion.AutoSize = True
        Me.lbl_descripcion.Location = New System.Drawing.Point(917, 142)
        Me.lbl_descripcion.Name = "lbl_descripcion"
        Me.lbl_descripcion.Size = New System.Drawing.Size(63, 13)
        Me.lbl_descripcion.TabIndex = 40
        Me.lbl_descripcion.Text = "Descripcion"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(920, 173)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(296, 500)
        Me.TextBox1.TabIndex = 41
        '
        'txb_duracion
        '
        Me.txb_duracion.Location = New System.Drawing.Point(979, 690)
        Me.txb_duracion.Name = "txb_duracion"
        Me.txb_duracion.Size = New System.Drawing.Size(237, 20)
        Me.txb_duracion.TabIndex = 42
        '
        'lbl_duracion
        '
        Me.lbl_duracion.AutoSize = True
        Me.lbl_duracion.Location = New System.Drawing.Point(923, 693)
        Me.lbl_duracion.Name = "lbl_duracion"
        Me.lbl_duracion.Size = New System.Drawing.Size(50, 13)
        Me.lbl_duracion.TabIndex = 43
        Me.lbl_duracion.Text = "Duracion"
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(1060, 716)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar.TabIndex = 44
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(1141, 716)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 45
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_nuevoDetalle
        '
        Me.btn_nuevoDetalle.Location = New System.Drawing.Point(783, 411)
        Me.btn_nuevoDetalle.Name = "btn_nuevoDetalle"
        Me.btn_nuevoDetalle.Size = New System.Drawing.Size(107, 23)
        Me.btn_nuevoDetalle.TabIndex = 46
        Me.btn_nuevoDetalle.Text = "Nuevo Detalle"
        Me.btn_nuevoDetalle.UseVisualStyleBackColor = True
        '
        'btn_consultarDetalle
        '
        Me.btn_consultarDetalle.Location = New System.Drawing.Point(670, 411)
        Me.btn_consultarDetalle.Name = "btn_consultarDetalle"
        Me.btn_consultarDetalle.Size = New System.Drawing.Size(107, 23)
        Me.btn_consultarDetalle.TabIndex = 47
        Me.btn_consultarDetalle.Text = "Consultar Detalle"
        Me.btn_consultarDetalle.UseVisualStyleBackColor = True
        '
        'form_gestionIncidencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1235, 746)
        Me.Controls.Add(Me.btn_consultarDetalle)
        Me.Controls.Add(Me.btn_nuevoDetalle)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.lbl_duracion)
        Me.Controls.Add(Me.txb_duracion)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lbl_descripcion)
        Me.Controls.Add(Me.rbtn_detalle_baja)
        Me.Controls.Add(Me.rbtn_detalle_media)
        Me.Controls.Add(Me.rbtn_detalle_alta)
        Me.Controls.Add(Me.chk_prioridad)
        Me.Controls.Add(Me.cmb_estado)
        Me.Controls.Add(Me.chk_estado)
        Me.Controls.Add(Me.txb_titulo)
        Me.Controls.Add(Me.lbl_titulo)
        Me.Controls.Add(Me.lbl_fechaActual)
        Me.Controls.Add(Me.lbl_detalleIncidente)
        Me.Controls.Add(Me.lbl_fechaAtencion)
        Me.Controls.Add(Me.lbl_nroOrden)
        Me.Controls.Add(Me.txt_nroOrden)
        Me.Controls.Add(Me.rbtn_incidencia_prioridad_baja)
        Me.Controls.Add(Me.rbtn_incidencia_prioridad_media)
        Me.Controls.Add(Me.rbtn_incidencia_prioridad_alta)
        Me.Controls.Add(Me.txtbox_incidencia_descripcion)
        Me.Controls.Add(Me.txtbox_incidencia_titulo)
        Me.Controls.Add(Me.txtbox_incidencia_nro)
        Me.Controls.Add(Me.btn_incidencia_buscar)
        Me.Controls.Add(Me.btn_incidencia_limpiar)
        Me.Controls.Add(Me.cbox_incidencia_usuario)
        Me.Controls.Add(Me.cbox_incidencia_estado)
        Me.Controls.Add(Me.cbox_incidencia_prioridad)
        Me.Controls.Add(Me.cbox_incidencia_area)
        Me.Controls.Add(Me.lbl_incidencia_usuario)
        Me.Controls.Add(Me.cmb_incidencia_usuario)
        Me.Controls.Add(Me.lbl_incidencia_estado)
        Me.Controls.Add(Me.cmb_incidencia_estado)
        Me.Controls.Add(Me.lbl_incidencia_prioridad)
        Me.Controls.Add(Me.lbl_incidencia_area)
        Me.Controls.Add(Me.cmb_incidencia_area)
        Me.Controls.Add(Me.dgv_detalle)
        Me.Controls.Add(Me.dgv_incidencia)
        Me.Name = "form_gestionIncidencia"
        Me.Text = "Form 3"
        CType(Me.dgv_incidencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_incidencia As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_detalle As System.Windows.Forms.DataGridView
    Friend WithEvents cmb_incidencia_area As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_incidencia_area As System.Windows.Forms.Label
    Friend WithEvents lbl_incidencia_prioridad As System.Windows.Forms.Label
    Friend WithEvents lbl_incidencia_estado As System.Windows.Forms.Label
    Friend WithEvents cmb_incidencia_estado As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_incidencia_usuario As System.Windows.Forms.Label
    Friend WithEvents cmb_incidencia_usuario As System.Windows.Forms.ComboBox
    Friend WithEvents cbox_incidencia_area As System.Windows.Forms.CheckBox
    Friend WithEvents cbox_incidencia_prioridad As System.Windows.Forms.CheckBox
    Friend WithEvents cbox_incidencia_estado As System.Windows.Forms.CheckBox
    Friend WithEvents cbox_incidencia_usuario As System.Windows.Forms.CheckBox
    Friend WithEvents btn_incidencia_limpiar As System.Windows.Forms.Button
    Friend WithEvents btn_incidencia_buscar As System.Windows.Forms.Button
    Friend WithEvents txtbox_incidencia_nro As System.Windows.Forms.TextBox
    Friend WithEvents txtbox_incidencia_titulo As System.Windows.Forms.TextBox
    Friend WithEvents txtbox_incidencia_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents rbtn_incidencia_prioridad_alta As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_incidencia_prioridad_media As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_incidencia_prioridad_baja As System.Windows.Forms.RadioButton
    Friend WithEvents txt_nroOrden As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nroOrden As System.Windows.Forms.Label
    Friend WithEvents lbl_fechaAtencion As System.Windows.Forms.Label
    Friend WithEvents lbl_detalleIncidente As System.Windows.Forms.Label
    Friend WithEvents lbl_fechaActual As System.Windows.Forms.Label
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents txb_titulo As System.Windows.Forms.TextBox
    Friend WithEvents chk_estado As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_estado As System.Windows.Forms.ComboBox
    Friend WithEvents chk_prioridad As System.Windows.Forms.CheckBox
    Friend WithEvents rbtn_detalle_baja As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_detalle_media As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_detalle_alta As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_descripcion As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txb_duracion As System.Windows.Forms.TextBox
    Friend WithEvents lbl_duracion As System.Windows.Forms.Label
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_nuevoDetalle As System.Windows.Forms.Button
    Friend WithEvents btn_consultarDetalle As System.Windows.Forms.Button
    Friend WithEvents codIncidencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents baja As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents titulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents usuarioFinal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fechaCarga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fechaCierre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents area As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prioridad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents usuarioSupervisor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dispositivo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
