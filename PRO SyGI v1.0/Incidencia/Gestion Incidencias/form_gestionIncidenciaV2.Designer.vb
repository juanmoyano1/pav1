<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_gestionIncidenciaV2
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
        Me.btn_consultarDetalle = New System.Windows.Forms.Button()
        Me.btn_nuevoDetalle = New System.Windows.Forms.Button()
        Me.txb_descripcion = New System.Windows.Forms.TextBox()
        Me.lbl_descripcion = New System.Windows.Forms.Label()
        Me.rbtn_detalle_baja = New System.Windows.Forms.RadioButton()
        Me.rbtn_detalle_media = New System.Windows.Forms.RadioButton()
        Me.rbtn_detalle_alta = New System.Windows.Forms.RadioButton()
        Me.chk_prioridad = New System.Windows.Forms.CheckBox()
        Me.cmb_estado = New System.Windows.Forms.ComboBox()
        Me.chk_estado = New System.Windows.Forms.CheckBox()
        Me.txb_titulo = New System.Windows.Forms.TextBox()
        Me.lbl_titulo = New System.Windows.Forms.Label()
        Me.lbl_detalleIncidente = New System.Windows.Forms.Label()
        Me.lbl_fechaAtencion = New System.Windows.Forms.Label()
        Me.lbl_nroOrden = New System.Windows.Forms.Label()
        Me.txt_nroOrden = New System.Windows.Forms.TextBox()
        Me.rbtn_incidencia_prioridad_baja = New System.Windows.Forms.RadioButton()
        Me.rbtn_incidencia_prioridad_media = New System.Windows.Forms.RadioButton()
        Me.rbtn_incidencia_prioridad_alta = New System.Windows.Forms.RadioButton()
        Me.txtbox_incidencia_descripcion = New System.Windows.Forms.TextBox()
        Me.txtbox_incidencia_titulo = New System.Windows.Forms.TextBox()
        Me.txtbox_incidencia_nro = New System.Windows.Forms.TextBox()
        Me.scr_GestionIncidentes = New System.Windows.Forms.Button()
        Me.btn_incidencia_limpiar = New System.Windows.Forms.Button()
        Me.cbox_incidencia_usuario = New System.Windows.Forms.CheckBox()
        Me.cbox_incidencia_estado = New System.Windows.Forms.CheckBox()
        Me.cbox_incidencia_prioridad = New System.Windows.Forms.CheckBox()
        Me.cbox_incidencia_area = New System.Windows.Forms.CheckBox()
        Me.lbl_incidencia_usuario = New System.Windows.Forms.Label()
        Me.cmb_incidencia_usuario = New System.Windows.Forms.ComboBox()
        Me.lbl_incidencia_estado = New System.Windows.Forms.Label()
        Me.cmb_incidencia_estado = New System.Windows.Forms.ComboBox()
        Me.lbl_incidencia_prioridad = New System.Windows.Forms.Label()
        Me.lbl_incidencia_area = New System.Windows.Forms.Label()
        Me.cmb_incidencia_area = New System.Windows.Forms.ComboBox()
        Me.dgv_detalle = New System.Windows.Forms.DataGridView()
        Me.codIncidente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nroOrden = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bajaDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tituloDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechaAtencion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.duracion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcionDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_aceptar = New System.Windows.Forms.Button()
        Me.lbl_duracion = New System.Windows.Forms.Label()
        Me.txb_duracion = New System.Windows.Forms.TextBox()
        Me.btn_asignarUsuarioEncargado = New System.Windows.Forms.Button()
        Me.dtp_fechaActual = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgv_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_incidencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_consultarDetalle
        '
        Me.btn_consultarDetalle.Enabled = False
        Me.btn_consultarDetalle.Location = New System.Drawing.Point(663, 378)
        Me.btn_consultarDetalle.Name = "btn_consultarDetalle"
        Me.btn_consultarDetalle.Size = New System.Drawing.Size(107, 23)
        Me.btn_consultarDetalle.TabIndex = 22
        Me.btn_consultarDetalle.Text = "Consultar Detalle"
        Me.btn_consultarDetalle.UseVisualStyleBackColor = True
        '
        'btn_nuevoDetalle
        '
        Me.btn_nuevoDetalle.Enabled = False
        Me.btn_nuevoDetalle.Location = New System.Drawing.Point(776, 378)
        Me.btn_nuevoDetalle.Name = "btn_nuevoDetalle"
        Me.btn_nuevoDetalle.Size = New System.Drawing.Size(107, 23)
        Me.btn_nuevoDetalle.TabIndex = 23
        Me.btn_nuevoDetalle.Text = "Nuevo Detalle"
        Me.btn_nuevoDetalle.UseVisualStyleBackColor = True
        '
        'txb_descripcion
        '
        Me.txb_descripcion.Location = New System.Drawing.Point(913, 205)
        Me.txb_descripcion.Multiline = True
        Me.txb_descripcion.Name = "txb_descripcion"
        Me.txb_descripcion.Size = New System.Drawing.Size(296, 383)
        Me.txb_descripcion.TabIndex = 33
        Me.txb_descripcion.Text = "Descripcion Incidente"
        '
        'lbl_descripcion
        '
        Me.lbl_descripcion.AutoSize = True
        Me.lbl_descripcion.BackColor = System.Drawing.Color.Transparent
        Me.lbl_descripcion.Location = New System.Drawing.Point(910, 178)
        Me.lbl_descripcion.Name = "lbl_descripcion"
        Me.lbl_descripcion.Size = New System.Drawing.Size(63, 13)
        Me.lbl_descripcion.TabIndex = 82
        Me.lbl_descripcion.Text = "Descripcion"
        '
        'rbtn_detalle_baja
        '
        Me.rbtn_detalle_baja.AutoSize = True
        Me.rbtn_detalle_baja.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_detalle_baja.Enabled = False
        Me.rbtn_detalle_baja.ForeColor = System.Drawing.Color.Lime
        Me.rbtn_detalle_baja.Location = New System.Drawing.Point(985, 144)
        Me.rbtn_detalle_baja.Name = "rbtn_detalle_baja"
        Me.rbtn_detalle_baja.Size = New System.Drawing.Size(30, 17)
        Me.rbtn_detalle_baja.TabIndex = 30
        Me.rbtn_detalle_baja.TabStop = True
        Me.rbtn_detalle_baja.Text = "▌"
        Me.rbtn_detalle_baja.UseVisualStyleBackColor = False
        '
        'rbtn_detalle_media
        '
        Me.rbtn_detalle_media.AutoSize = True
        Me.rbtn_detalle_media.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_detalle_media.Enabled = False
        Me.rbtn_detalle_media.ForeColor = System.Drawing.Color.Yellow
        Me.rbtn_detalle_media.Location = New System.Drawing.Point(1020, 144)
        Me.rbtn_detalle_media.Name = "rbtn_detalle_media"
        Me.rbtn_detalle_media.Size = New System.Drawing.Size(30, 17)
        Me.rbtn_detalle_media.TabIndex = 31
        Me.rbtn_detalle_media.TabStop = True
        Me.rbtn_detalle_media.Text = "▌"
        Me.rbtn_detalle_media.UseVisualStyleBackColor = False
        '
        'rbtn_detalle_alta
        '
        Me.rbtn_detalle_alta.AutoSize = True
        Me.rbtn_detalle_alta.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_detalle_alta.Enabled = False
        Me.rbtn_detalle_alta.ForeColor = System.Drawing.Color.Red
        Me.rbtn_detalle_alta.Location = New System.Drawing.Point(1051, 144)
        Me.rbtn_detalle_alta.Name = "rbtn_detalle_alta"
        Me.rbtn_detalle_alta.Size = New System.Drawing.Size(30, 17)
        Me.rbtn_detalle_alta.TabIndex = 32
        Me.rbtn_detalle_alta.TabStop = True
        Me.rbtn_detalle_alta.Text = "▌"
        Me.rbtn_detalle_alta.UseVisualStyleBackColor = False
        '
        'chk_prioridad
        '
        Me.chk_prioridad.AutoSize = True
        Me.chk_prioridad.BackColor = System.Drawing.Color.Transparent
        Me.chk_prioridad.Location = New System.Drawing.Point(912, 144)
        Me.chk_prioridad.Name = "chk_prioridad"
        Me.chk_prioridad.Size = New System.Drawing.Size(67, 17)
        Me.chk_prioridad.TabIndex = 29
        Me.chk_prioridad.Text = "Prioridad"
        Me.chk_prioridad.UseVisualStyleBackColor = False
        '
        'cmb_estado
        '
        Me.cmb_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_estado.Enabled = False
        Me.cmb_estado.FormattingEnabled = True
        Me.cmb_estado.Location = New System.Drawing.Point(977, 117)
        Me.cmb_estado.Name = "cmb_estado"
        Me.cmb_estado.Size = New System.Drawing.Size(231, 21)
        Me.cmb_estado.TabIndex = 28
        '
        'chk_estado
        '
        Me.chk_estado.AutoSize = True
        Me.chk_estado.BackColor = System.Drawing.Color.Transparent
        Me.chk_estado.Location = New System.Drawing.Point(912, 119)
        Me.chk_estado.Name = "chk_estado"
        Me.chk_estado.Size = New System.Drawing.Size(59, 17)
        Me.chk_estado.TabIndex = 27
        Me.chk_estado.Text = "Estado"
        Me.chk_estado.UseVisualStyleBackColor = False
        '
        'txb_titulo
        '
        Me.txb_titulo.Location = New System.Drawing.Point(948, 91)
        Me.txb_titulo.Name = "txb_titulo"
        Me.txb_titulo.Size = New System.Drawing.Size(260, 20)
        Me.txb_titulo.TabIndex = 26
        '
        'lbl_titulo
        '
        Me.lbl_titulo.AutoSize = True
        Me.lbl_titulo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_titulo.Location = New System.Drawing.Point(909, 94)
        Me.lbl_titulo.Name = "lbl_titulo"
        Me.lbl_titulo.Size = New System.Drawing.Size(33, 13)
        Me.lbl_titulo.TabIndex = 74
        Me.lbl_titulo.Text = "Titulo"
        '
        'lbl_detalleIncidente
        '
        Me.lbl_detalleIncidente.AutoSize = True
        Me.lbl_detalleIncidente.BackColor = System.Drawing.Color.Transparent
        Me.lbl_detalleIncidente.Location = New System.Drawing.Point(23, 383)
        Me.lbl_detalleIncidente.Name = "lbl_detalleIncidente"
        Me.lbl_detalleIncidente.Size = New System.Drawing.Size(109, 13)
        Me.lbl_detalleIncidente.TabIndex = 72
        Me.lbl_detalleIncidente.Text = "Detalles del Incidente"
        '
        'lbl_fechaAtencion
        '
        Me.lbl_fechaAtencion.AutoSize = True
        Me.lbl_fechaAtencion.BackColor = System.Drawing.Color.Transparent
        Me.lbl_fechaAtencion.Location = New System.Drawing.Point(909, 61)
        Me.lbl_fechaAtencion.Name = "lbl_fechaAtencion"
        Me.lbl_fechaAtencion.Size = New System.Drawing.Size(82, 13)
        Me.lbl_fechaAtencion.TabIndex = 71
        Me.lbl_fechaAtencion.Text = "Fecha Atencion"
        '
        'lbl_nroOrden
        '
        Me.lbl_nroOrden.AutoSize = True
        Me.lbl_nroOrden.BackColor = System.Drawing.Color.Transparent
        Me.lbl_nroOrden.Location = New System.Drawing.Point(907, 24)
        Me.lbl_nroOrden.Name = "lbl_nroOrden"
        Me.lbl_nroOrden.Size = New System.Drawing.Size(76, 13)
        Me.lbl_nroOrden.TabIndex = 70
        Me.lbl_nroOrden.Text = "Numero Orden"
        '
        'txt_nroOrden
        '
        Me.txt_nroOrden.Enabled = False
        Me.txt_nroOrden.Location = New System.Drawing.Point(998, 19)
        Me.txt_nroOrden.Name = "txt_nroOrden"
        Me.txt_nroOrden.Size = New System.Drawing.Size(210, 20)
        Me.txt_nroOrden.TabIndex = 24
        '
        'rbtn_incidencia_prioridad_baja
        '
        Me.rbtn_incidencia_prioridad_baja.AutoSize = True
        Me.rbtn_incidencia_prioridad_baja.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_incidencia_prioridad_baja.Enabled = False
        Me.rbtn_incidencia_prioridad_baja.ForeColor = System.Drawing.Color.Lime
        Me.rbtn_incidencia_prioridad_baja.Location = New System.Drawing.Point(455, 72)
        Me.rbtn_incidencia_prioridad_baja.Name = "rbtn_incidencia_prioridad_baja"
        Me.rbtn_incidencia_prioridad_baja.Size = New System.Drawing.Size(30, 17)
        Me.rbtn_incidencia_prioridad_baja.TabIndex = 13
        Me.rbtn_incidencia_prioridad_baja.TabStop = True
        Me.rbtn_incidencia_prioridad_baja.Text = "▌"
        Me.rbtn_incidencia_prioridad_baja.UseVisualStyleBackColor = False
        '
        'rbtn_incidencia_prioridad_media
        '
        Me.rbtn_incidencia_prioridad_media.AutoSize = True
        Me.rbtn_incidencia_prioridad_media.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_incidencia_prioridad_media.Enabled = False
        Me.rbtn_incidencia_prioridad_media.ForeColor = System.Drawing.Color.Yellow
        Me.rbtn_incidencia_prioridad_media.Location = New System.Drawing.Point(490, 72)
        Me.rbtn_incidencia_prioridad_media.Name = "rbtn_incidencia_prioridad_media"
        Me.rbtn_incidencia_prioridad_media.Size = New System.Drawing.Size(30, 17)
        Me.rbtn_incidencia_prioridad_media.TabIndex = 14
        Me.rbtn_incidencia_prioridad_media.TabStop = True
        Me.rbtn_incidencia_prioridad_media.Text = "▌"
        Me.rbtn_incidencia_prioridad_media.UseVisualStyleBackColor = False
        '
        'rbtn_incidencia_prioridad_alta
        '
        Me.rbtn_incidencia_prioridad_alta.AutoSize = True
        Me.rbtn_incidencia_prioridad_alta.BackColor = System.Drawing.Color.Transparent
        Me.rbtn_incidencia_prioridad_alta.Enabled = False
        Me.rbtn_incidencia_prioridad_alta.ForeColor = System.Drawing.Color.Red
        Me.rbtn_incidencia_prioridad_alta.Location = New System.Drawing.Point(521, 72)
        Me.rbtn_incidencia_prioridad_alta.Name = "rbtn_incidencia_prioridad_alta"
        Me.rbtn_incidencia_prioridad_alta.Size = New System.Drawing.Size(30, 17)
        Me.rbtn_incidencia_prioridad_alta.TabIndex = 15
        Me.rbtn_incidencia_prioridad_alta.TabStop = True
        Me.rbtn_incidencia_prioridad_alta.Text = "▌"
        Me.rbtn_incidencia_prioridad_alta.UseVisualStyleBackColor = False
        '
        'txtbox_incidencia_descripcion
        '
        Me.txtbox_incidencia_descripcion.Enabled = False
        Me.txtbox_incidencia_descripcion.Location = New System.Drawing.Point(23, 72)
        Me.txtbox_incidencia_descripcion.Multiline = True
        Me.txtbox_incidencia_descripcion.Name = "txtbox_incidencia_descripcion"
        Me.txtbox_incidencia_descripcion.Size = New System.Drawing.Size(347, 41)
        Me.txtbox_incidencia_descripcion.TabIndex = 3
        '
        'txtbox_incidencia_titulo
        '
        Me.txtbox_incidencia_titulo.Enabled = False
        Me.txtbox_incidencia_titulo.Location = New System.Drawing.Point(108, 27)
        Me.txtbox_incidencia_titulo.Name = "txtbox_incidencia_titulo"
        Me.txtbox_incidencia_titulo.Size = New System.Drawing.Size(262, 20)
        Me.txtbox_incidencia_titulo.TabIndex = 2
        '
        'txtbox_incidencia_nro
        '
        Me.txtbox_incidencia_nro.Enabled = False
        Me.txtbox_incidencia_nro.Location = New System.Drawing.Point(23, 27)
        Me.txtbox_incidencia_nro.Name = "txtbox_incidencia_nro"
        Me.txtbox_incidencia_nro.Size = New System.Drawing.Size(79, 20)
        Me.txtbox_incidencia_nro.TabIndex = 1
        Me.txtbox_incidencia_nro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'scr_GestionIncidentes
        '
        Me.scr_GestionIncidentes.Location = New System.Drawing.Point(811, 71)
        Me.scr_GestionIncidentes.Name = "scr_GestionIncidentes"
        Me.scr_GestionIncidentes.Size = New System.Drawing.Size(72, 23)
        Me.scr_GestionIncidentes.TabIndex = 19
        Me.scr_GestionIncidentes.Text = "Buscar"
        Me.scr_GestionIncidentes.UseVisualStyleBackColor = True
        '
        'btn_incidencia_limpiar
        '
        Me.btn_incidencia_limpiar.Location = New System.Drawing.Point(811, 24)
        Me.btn_incidencia_limpiar.Name = "btn_incidencia_limpiar"
        Me.btn_incidencia_limpiar.Size = New System.Drawing.Size(72, 23)
        Me.btn_incidencia_limpiar.TabIndex = 10
        Me.btn_incidencia_limpiar.Text = "Limpiar"
        Me.btn_incidencia_limpiar.UseVisualStyleBackColor = True
        '
        'cbox_incidencia_usuario
        '
        Me.cbox_incidencia_usuario.AutoSize = True
        Me.cbox_incidencia_usuario.Location = New System.Drawing.Point(606, 75)
        Me.cbox_incidencia_usuario.Name = "cbox_incidencia_usuario"
        Me.cbox_incidencia_usuario.Size = New System.Drawing.Size(15, 14)
        Me.cbox_incidencia_usuario.TabIndex = 17
        Me.cbox_incidencia_usuario.UseVisualStyleBackColor = True
        '
        'cbox_incidencia_estado
        '
        Me.cbox_incidencia_estado.AutoSize = True
        Me.cbox_incidencia_estado.Location = New System.Drawing.Point(432, 28)
        Me.cbox_incidencia_estado.Name = "cbox_incidencia_estado"
        Me.cbox_incidencia_estado.Size = New System.Drawing.Size(15, 14)
        Me.cbox_incidencia_estado.TabIndex = 5
        Me.cbox_incidencia_estado.UseVisualStyleBackColor = True
        '
        'cbox_incidencia_prioridad
        '
        Me.cbox_incidencia_prioridad.AutoSize = True
        Me.cbox_incidencia_prioridad.Location = New System.Drawing.Point(432, 74)
        Me.cbox_incidencia_prioridad.Name = "cbox_incidencia_prioridad"
        Me.cbox_incidencia_prioridad.Size = New System.Drawing.Size(15, 14)
        Me.cbox_incidencia_prioridad.TabIndex = 12
        Me.cbox_incidencia_prioridad.UseVisualStyleBackColor = True
        '
        'cbox_incidencia_area
        '
        Me.cbox_incidencia_area.AutoSize = True
        Me.cbox_incidencia_area.Location = New System.Drawing.Point(606, 27)
        Me.cbox_incidencia_area.Name = "cbox_incidencia_area"
        Me.cbox_incidencia_area.Size = New System.Drawing.Size(15, 14)
        Me.cbox_incidencia_area.TabIndex = 8
        Me.cbox_incidencia_area.UseVisualStyleBackColor = True
        '
        'lbl_incidencia_usuario
        '
        Me.lbl_incidencia_usuario.AutoSize = True
        Me.lbl_incidencia_usuario.BackColor = System.Drawing.Color.Transparent
        Me.lbl_incidencia_usuario.Enabled = False
        Me.lbl_incidencia_usuario.Location = New System.Drawing.Point(557, 75)
        Me.lbl_incidencia_usuario.Name = "lbl_incidencia_usuario"
        Me.lbl_incidencia_usuario.Size = New System.Drawing.Size(43, 13)
        Me.lbl_incidencia_usuario.TabIndex = 16
        Me.lbl_incidencia_usuario.Text = "Usuario"
        '
        'cmb_incidencia_usuario
        '
        Me.cmb_incidencia_usuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_incidencia_usuario.Enabled = False
        Me.cmb_incidencia_usuario.FormattingEnabled = True
        Me.cmb_incidencia_usuario.Location = New System.Drawing.Point(628, 72)
        Me.cmb_incidencia_usuario.Name = "cmb_incidencia_usuario"
        Me.cmb_incidencia_usuario.Size = New System.Drawing.Size(177, 21)
        Me.cmb_incidencia_usuario.TabIndex = 18
        '
        'lbl_incidencia_estado
        '
        Me.lbl_incidencia_estado.AutoSize = True
        Me.lbl_incidencia_estado.BackColor = System.Drawing.Color.Transparent
        Me.lbl_incidencia_estado.Enabled = False
        Me.lbl_incidencia_estado.Location = New System.Drawing.Point(386, 28)
        Me.lbl_incidencia_estado.Name = "lbl_incidencia_estado"
        Me.lbl_incidencia_estado.Size = New System.Drawing.Size(40, 13)
        Me.lbl_incidencia_estado.TabIndex = 4
        Me.lbl_incidencia_estado.Text = "Estado"
        '
        'cmb_incidencia_estado
        '
        Me.cmb_incidencia_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_incidencia_estado.Enabled = False
        Me.cmb_incidencia_estado.FormattingEnabled = True
        Me.cmb_incidencia_estado.Location = New System.Drawing.Point(453, 26)
        Me.cmb_incidencia_estado.Name = "cmb_incidencia_estado"
        Me.cmb_incidencia_estado.Size = New System.Drawing.Size(98, 21)
        Me.cmb_incidencia_estado.TabIndex = 6
        '
        'lbl_incidencia_prioridad
        '
        Me.lbl_incidencia_prioridad.AutoSize = True
        Me.lbl_incidencia_prioridad.BackColor = System.Drawing.Color.Transparent
        Me.lbl_incidencia_prioridad.Enabled = False
        Me.lbl_incidencia_prioridad.Location = New System.Drawing.Point(378, 74)
        Me.lbl_incidencia_prioridad.Name = "lbl_incidencia_prioridad"
        Me.lbl_incidencia_prioridad.Size = New System.Drawing.Size(48, 13)
        Me.lbl_incidencia_prioridad.TabIndex = 11
        Me.lbl_incidencia_prioridad.Text = "Prioridad"
        '
        'lbl_incidencia_area
        '
        Me.lbl_incidencia_area.AutoSize = True
        Me.lbl_incidencia_area.BackColor = System.Drawing.Color.Transparent
        Me.lbl_incidencia_area.Enabled = False
        Me.lbl_incidencia_area.Location = New System.Drawing.Point(571, 26)
        Me.lbl_incidencia_area.Name = "lbl_incidencia_area"
        Me.lbl_incidencia_area.Size = New System.Drawing.Size(29, 13)
        Me.lbl_incidencia_area.TabIndex = 7
        Me.lbl_incidencia_area.Text = "Area"
        '
        'cmb_incidencia_area
        '
        Me.cmb_incidencia_area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_incidencia_area.Enabled = False
        Me.cmb_incidencia_area.FormattingEnabled = True
        Me.cmb_incidencia_area.Location = New System.Drawing.Point(628, 24)
        Me.cmb_incidencia_area.Name = "cmb_incidencia_area"
        Me.cmb_incidencia_area.Size = New System.Drawing.Size(177, 21)
        Me.cmb_incidencia_area.TabIndex = 9
        '
        'dgv_detalle
        '
        Me.dgv_detalle.AllowUserToAddRows = False
        Me.dgv_detalle.AllowUserToDeleteRows = False
        Me.dgv_detalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codIncidente, Me.nroOrden, Me.bajaDetalle, Me.tituloDetalle, Me.fechaAtencion, Me.duracion, Me.descripcionDetalle})
        Me.dgv_detalle.Location = New System.Drawing.Point(23, 408)
        Me.dgv_detalle.Name = "dgv_detalle"
        Me.dgv_detalle.ReadOnly = True
        Me.dgv_detalle.Size = New System.Drawing.Size(860, 260)
        Me.dgv_detalle.TabIndex = 49
        '
        'codIncidente
        '
        Me.codIncidente.DataPropertyName = "codIncidencia"
        Me.codIncidente.HeaderText = "Codigo Incidente"
        Me.codIncidente.Name = "codIncidente"
        Me.codIncidente.ReadOnly = True
        Me.codIncidente.Visible = False
        '
        'nroOrden
        '
        Me.nroOrden.DataPropertyName = "nroOrden"
        Me.nroOrden.HeaderText = "Numero Orden"
        Me.nroOrden.Name = "nroOrden"
        Me.nroOrden.ReadOnly = True
        '
        'bajaDetalle
        '
        Me.bajaDetalle.DataPropertyName = "baja"
        Me.bajaDetalle.HeaderText = "Baja detalle"
        Me.bajaDetalle.Name = "bajaDetalle"
        Me.bajaDetalle.ReadOnly = True
        Me.bajaDetalle.Visible = False
        '
        'tituloDetalle
        '
        Me.tituloDetalle.DataPropertyName = "titulo"
        Me.tituloDetalle.HeaderText = "Titulo"
        Me.tituloDetalle.Name = "tituloDetalle"
        Me.tituloDetalle.ReadOnly = True
        '
        'fechaAtencion
        '
        Me.fechaAtencion.DataPropertyName = "fechaAtencion"
        Me.fechaAtencion.HeaderText = "Fecha atencion"
        Me.fechaAtencion.Name = "fechaAtencion"
        Me.fechaAtencion.ReadOnly = True
        '
        'duracion
        '
        Me.duracion.DataPropertyName = "duracion"
        Me.duracion.HeaderText = "Duracion"
        Me.duracion.Name = "duracion"
        Me.duracion.ReadOnly = True
        '
        'descripcionDetalle
        '
        Me.descripcionDetalle.DataPropertyName = "descripcion"
        Me.descripcionDetalle.HeaderText = "Descripcion"
        Me.descripcionDetalle.Name = "descripcionDetalle"
        Me.descripcionDetalle.ReadOnly = True
        '
        'dgv_incidencia
        '
        Me.dgv_incidencia.AllowUserToAddRows = False
        Me.dgv_incidencia.AllowUserToDeleteRows = False
        Me.dgv_incidencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_incidencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_incidencia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codIncidencia, Me.baja, Me.titulo, Me.descripcion, Me.usuarioFinal, Me.fechaCarga, Me.fechaCierre, Me.area, Me.estado, Me.prioridad, Me.usuarioSupervisor, Me.dispositivo})
        Me.dgv_incidencia.Location = New System.Drawing.Point(23, 119)
        Me.dgv_incidencia.Name = "dgv_incidencia"
        Me.dgv_incidencia.ReadOnly = True
        Me.dgv_incidencia.Size = New System.Drawing.Size(860, 253)
        Me.dgv_incidencia.TabIndex = 20
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
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(1132, 645)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 36
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_aceptar
        '
        Me.btn_aceptar.Location = New System.Drawing.Point(1051, 645)
        Me.btn_aceptar.Name = "btn_aceptar"
        Me.btn_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.btn_aceptar.TabIndex = 35
        Me.btn_aceptar.Text = "Aceptar"
        Me.btn_aceptar.UseVisualStyleBackColor = True
        '
        'lbl_duracion
        '
        Me.lbl_duracion.AutoSize = True
        Me.lbl_duracion.BackColor = System.Drawing.Color.Transparent
        Me.lbl_duracion.Location = New System.Drawing.Point(915, 606)
        Me.lbl_duracion.Name = "lbl_duracion"
        Me.lbl_duracion.Size = New System.Drawing.Size(50, 13)
        Me.lbl_duracion.TabIndex = 87
        Me.lbl_duracion.Text = "Duracion"
        '
        'txb_duracion
        '
        Me.txb_duracion.Location = New System.Drawing.Point(971, 603)
        Me.txb_duracion.Name = "txb_duracion"
        Me.txb_duracion.Size = New System.Drawing.Size(237, 20)
        Me.txb_duracion.TabIndex = 34
        '
        'btn_asignarUsuarioEncargado
        '
        Me.btn_asignarUsuarioEncargado.Location = New System.Drawing.Point(542, 378)
        Me.btn_asignarUsuarioEncargado.Name = "btn_asignarUsuarioEncargado"
        Me.btn_asignarUsuarioEncargado.Size = New System.Drawing.Size(115, 23)
        Me.btn_asignarUsuarioEncargado.TabIndex = 21
        Me.btn_asignarUsuarioEncargado.Text = "Asignar Encargado"
        Me.btn_asignarUsuarioEncargado.UseVisualStyleBackColor = True
        '
        'dtp_fechaActual
        '
        Me.dtp_fechaActual.Location = New System.Drawing.Point(998, 57)
        Me.dtp_fechaActual.Name = "dtp_fechaActual"
        Me.dtp_fechaActual.Size = New System.Drawing.Size(211, 20)
        Me.dtp_fechaActual.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(23, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Nro Incidente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(23, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "Detalle incidente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(114, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Titulo"
        '
        'form_gestionIncidenciaV2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.fondoPrincipal
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1224, 682)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtp_fechaActual)
        Me.Controls.Add(Me.btn_asignarUsuarioEncargado)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_aceptar)
        Me.Controls.Add(Me.lbl_duracion)
        Me.Controls.Add(Me.txb_duracion)
        Me.Controls.Add(Me.btn_consultarDetalle)
        Me.Controls.Add(Me.btn_nuevoDetalle)
        Me.Controls.Add(Me.txb_descripcion)
        Me.Controls.Add(Me.lbl_descripcion)
        Me.Controls.Add(Me.rbtn_detalle_baja)
        Me.Controls.Add(Me.rbtn_detalle_media)
        Me.Controls.Add(Me.rbtn_detalle_alta)
        Me.Controls.Add(Me.chk_prioridad)
        Me.Controls.Add(Me.cmb_estado)
        Me.Controls.Add(Me.chk_estado)
        Me.Controls.Add(Me.txb_titulo)
        Me.Controls.Add(Me.lbl_titulo)
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
        Me.Controls.Add(Me.scr_GestionIncidentes)
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
        Me.Name = "form_gestionIncidenciaV2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion Incidencias"
        CType(Me.dgv_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_incidencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_consultarDetalle As System.Windows.Forms.Button
    Friend WithEvents btn_nuevoDetalle As System.Windows.Forms.Button
    Friend WithEvents txb_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents lbl_descripcion As System.Windows.Forms.Label
    Friend WithEvents rbtn_detalle_baja As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_detalle_media As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_detalle_alta As System.Windows.Forms.RadioButton
    Friend WithEvents chk_prioridad As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_estado As System.Windows.Forms.ComboBox
    Friend WithEvents chk_estado As System.Windows.Forms.CheckBox
    Friend WithEvents txb_titulo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_titulo As System.Windows.Forms.Label
    Friend WithEvents lbl_detalleIncidente As System.Windows.Forms.Label
    Friend WithEvents lbl_fechaAtencion As System.Windows.Forms.Label
    Friend WithEvents lbl_nroOrden As System.Windows.Forms.Label
    Friend WithEvents txt_nroOrden As System.Windows.Forms.TextBox
    Friend WithEvents rbtn_incidencia_prioridad_baja As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_incidencia_prioridad_media As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_incidencia_prioridad_alta As System.Windows.Forms.RadioButton
    Friend WithEvents txtbox_incidencia_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtbox_incidencia_titulo As System.Windows.Forms.TextBox
    Friend WithEvents txtbox_incidencia_nro As System.Windows.Forms.TextBox
    Friend WithEvents scr_GestionIncidentes As System.Windows.Forms.Button
    Friend WithEvents btn_incidencia_limpiar As System.Windows.Forms.Button
    Friend WithEvents cbox_incidencia_usuario As System.Windows.Forms.CheckBox
    Friend WithEvents cbox_incidencia_estado As System.Windows.Forms.CheckBox
    Friend WithEvents cbox_incidencia_prioridad As System.Windows.Forms.CheckBox
    Friend WithEvents cbox_incidencia_area As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_incidencia_usuario As System.Windows.Forms.Label
    Friend WithEvents cmb_incidencia_usuario As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_incidencia_estado As System.Windows.Forms.Label
    Friend WithEvents cmb_incidencia_estado As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_incidencia_prioridad As System.Windows.Forms.Label
    Friend WithEvents lbl_incidencia_area As System.Windows.Forms.Label
    Friend WithEvents cmb_incidencia_area As System.Windows.Forms.ComboBox
    Friend WithEvents dgv_detalle As System.Windows.Forms.DataGridView
    Friend WithEvents dgv_incidencia As System.Windows.Forms.DataGridView
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
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_aceptar As System.Windows.Forms.Button
    Friend WithEvents lbl_duracion As System.Windows.Forms.Label
    Friend WithEvents txb_duracion As System.Windows.Forms.TextBox
    Friend WithEvents btn_asignarUsuarioEncargado As System.Windows.Forms.Button
    Friend WithEvents dtp_fechaActual As System.Windows.Forms.DateTimePicker
    Friend WithEvents codIncidente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nroOrden As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bajaDetalle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tituloDetalle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fechaAtencion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents duracion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcionDetalle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
