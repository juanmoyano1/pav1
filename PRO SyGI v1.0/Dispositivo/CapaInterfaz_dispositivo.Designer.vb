<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CapaInterfaz_dispositivo
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
        Me.btn_dispositivo_aceptar = New System.Windows.Forms.Button()
        Me.btn_dispositivo_cancelar = New System.Windows.Forms.Button()
        Me.cmb_dispositivo_tipo = New System.Windows.Forms.ComboBox()
        Me.lbl_dispositivo_tipo = New System.Windows.Forms.Label()
        Me.txt_dispositivo_descripcion = New System.Windows.Forms.TextBox()
        Me.txt_dispositivo_nombre = New System.Windows.Forms.TextBox()
        Me.lbl_dispositivo_descripcion = New System.Windows.Forms.Label()
        Me.lbl_dispositivo_nombre = New System.Windows.Forms.Label()
        Me.lbl_dispositivo_agregar = New System.Windows.Forms.Label()
        Me.lbl_lista_dispositivos = New System.Windows.Forms.Label()
        Me.btn_dispositivo_agregarTipoDispositivo = New System.Windows.Forms.Button()
        Me.btn_dispositivo_borrar = New System.Windows.Forms.Button()
        Me.btn_dispositivo_modificar = New System.Windows.Forms.Button()
        Me.cmb_dispositivo_area = New System.Windows.Forms.ComboBox()
        Me.lbl_dispositivo_area = New System.Windows.Forms.Label()
        Me.btn_dispositivo_agregarArea = New System.Windows.Forms.Button()
        Me.datagrid_dispositivo = New System.Windows.Forms.DataGridView()
        Me.codDispositivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.baja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_dispositivo_cerrar = New System.Windows.Forms.Button()
        Me.btn_dispositivo_Nuevo = New System.Windows.Forms.Button()
        CType(Me.datagrid_dispositivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_dispositivo_aceptar
        '
        Me.btn_dispositivo_aceptar.Location = New System.Drawing.Point(477, 356)
        Me.btn_dispositivo_aceptar.Name = "btn_dispositivo_aceptar"
        Me.btn_dispositivo_aceptar.Size = New System.Drawing.Size(94, 23)
        Me.btn_dispositivo_aceptar.TabIndex = 13
        Me.btn_dispositivo_aceptar.Text = "Aceptar"
        Me.btn_dispositivo_aceptar.UseVisualStyleBackColor = True
        '
        'btn_dispositivo_cancelar
        '
        Me.btn_dispositivo_cancelar.Location = New System.Drawing.Point(594, 356)
        Me.btn_dispositivo_cancelar.Name = "btn_dispositivo_cancelar"
        Me.btn_dispositivo_cancelar.Size = New System.Drawing.Size(96, 23)
        Me.btn_dispositivo_cancelar.TabIndex = 12
        Me.btn_dispositivo_cancelar.Text = "Cancelar"
        Me.btn_dispositivo_cancelar.UseVisualStyleBackColor = True
        '
        'cmb_dispositivo_tipo
        '
        Me.cmb_dispositivo_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_dispositivo_tipo.FormattingEnabled = True
        Me.cmb_dispositivo_tipo.Location = New System.Drawing.Point(477, 263)
        Me.cmb_dispositivo_tipo.Name = "cmb_dispositivo_tipo"
        Me.cmb_dispositivo_tipo.Size = New System.Drawing.Size(180, 21)
        Me.cmb_dispositivo_tipo.Sorted = True
        Me.cmb_dispositivo_tipo.TabIndex = 11
        '
        'lbl_dispositivo_tipo
        '
        Me.lbl_dispositivo_tipo.AutoSize = True
        Me.lbl_dispositivo_tipo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_dispositivo_tipo.Location = New System.Drawing.Point(474, 246)
        Me.lbl_dispositivo_tipo.Name = "lbl_dispositivo_tipo"
        Me.lbl_dispositivo_tipo.Size = New System.Drawing.Size(80, 13)
        Me.lbl_dispositivo_tipo.TabIndex = 14
        Me.lbl_dispositivo_tipo.Text = "Tipo dispositivo"
        '
        'txt_dispositivo_descripcion
        '
        Me.txt_dispositivo_descripcion.Location = New System.Drawing.Point(477, 98)
        Me.txt_dispositivo_descripcion.Multiline = True
        Me.txt_dispositivo_descripcion.Name = "txt_dispositivo_descripcion"
        Me.txt_dispositivo_descripcion.Size = New System.Drawing.Size(215, 125)
        Me.txt_dispositivo_descripcion.TabIndex = 9
        '
        'txt_dispositivo_nombre
        '
        Me.txt_dispositivo_nombre.Location = New System.Drawing.Point(477, 47)
        Me.txt_dispositivo_nombre.Name = "txt_dispositivo_nombre"
        Me.txt_dispositivo_nombre.Size = New System.Drawing.Size(215, 20)
        Me.txt_dispositivo_nombre.TabIndex = 7
        '
        'lbl_dispositivo_descripcion
        '
        Me.lbl_dispositivo_descripcion.AutoSize = True
        Me.lbl_dispositivo_descripcion.BackColor = System.Drawing.Color.Transparent
        Me.lbl_dispositivo_descripcion.Location = New System.Drawing.Point(474, 81)
        Me.lbl_dispositivo_descripcion.Name = "lbl_dispositivo_descripcion"
        Me.lbl_dispositivo_descripcion.Size = New System.Drawing.Size(63, 13)
        Me.lbl_dispositivo_descripcion.TabIndex = 10
        Me.lbl_dispositivo_descripcion.Text = "Descripción"
        '
        'lbl_dispositivo_nombre
        '
        Me.lbl_dispositivo_nombre.AutoSize = True
        Me.lbl_dispositivo_nombre.BackColor = System.Drawing.Color.Transparent
        Me.lbl_dispositivo_nombre.Location = New System.Drawing.Point(474, 31)
        Me.lbl_dispositivo_nombre.Name = "lbl_dispositivo_nombre"
        Me.lbl_dispositivo_nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_dispositivo_nombre.TabIndex = 8
        Me.lbl_dispositivo_nombre.Text = "Nombre"
        '
        'lbl_dispositivo_agregar
        '
        Me.lbl_dispositivo_agregar.AutoSize = True
        Me.lbl_dispositivo_agregar.BackColor = System.Drawing.Color.Transparent
        Me.lbl_dispositivo_agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dispositivo_agregar.Location = New System.Drawing.Point(485, 9)
        Me.lbl_dispositivo_agregar.Name = "lbl_dispositivo_agregar"
        Me.lbl_dispositivo_agregar.Size = New System.Drawing.Size(205, 15)
        Me.lbl_dispositivo_agregar.TabIndex = 6
        Me.lbl_dispositivo_agregar.Text = "Agregar nuevo dispositivo al sistema"
        '
        'lbl_lista_dispositivos
        '
        Me.lbl_lista_dispositivos.AutoSize = True
        Me.lbl_lista_dispositivos.BackColor = System.Drawing.Color.Transparent
        Me.lbl_lista_dispositivos.Location = New System.Drawing.Point(8, 9)
        Me.lbl_lista_dispositivos.Name = "lbl_lista_dispositivos"
        Me.lbl_lista_dispositivos.Size = New System.Drawing.Size(103, 13)
        Me.lbl_lista_dispositivos.TabIndex = 15
        Me.lbl_lista_dispositivos.Text = "Lista de Dispositivos"
        '
        'btn_dispositivo_agregarTipoDispositivo
        '
        Me.btn_dispositivo_agregarTipoDispositivo.Location = New System.Drawing.Point(663, 263)
        Me.btn_dispositivo_agregarTipoDispositivo.Name = "btn_dispositivo_agregarTipoDispositivo"
        Me.btn_dispositivo_agregarTipoDispositivo.Size = New System.Drawing.Size(29, 21)
        Me.btn_dispositivo_agregarTipoDispositivo.TabIndex = 17
        Me.btn_dispositivo_agregarTipoDispositivo.Text = "+"
        Me.btn_dispositivo_agregarTipoDispositivo.UseVisualStyleBackColor = True
        '
        'btn_dispositivo_borrar
        '
        Me.btn_dispositivo_borrar.Location = New System.Drawing.Point(124, 356)
        Me.btn_dispositivo_borrar.Name = "btn_dispositivo_borrar"
        Me.btn_dispositivo_borrar.Size = New System.Drawing.Size(100, 23)
        Me.btn_dispositivo_borrar.TabIndex = 18
        Me.btn_dispositivo_borrar.Text = "Borrar"
        Me.btn_dispositivo_borrar.UseVisualStyleBackColor = True
        '
        'btn_dispositivo_modificar
        '
        Me.btn_dispositivo_modificar.Location = New System.Drawing.Point(12, 356)
        Me.btn_dispositivo_modificar.Name = "btn_dispositivo_modificar"
        Me.btn_dispositivo_modificar.Size = New System.Drawing.Size(100, 23)
        Me.btn_dispositivo_modificar.TabIndex = 19
        Me.btn_dispositivo_modificar.Text = "Modificar"
        Me.btn_dispositivo_modificar.UseVisualStyleBackColor = True
        '
        'cmb_dispositivo_area
        '
        Me.cmb_dispositivo_area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_dispositivo_area.FormattingEnabled = True
        Me.cmb_dispositivo_area.Location = New System.Drawing.Point(477, 314)
        Me.cmb_dispositivo_area.Name = "cmb_dispositivo_area"
        Me.cmb_dispositivo_area.Size = New System.Drawing.Size(180, 21)
        Me.cmb_dispositivo_area.TabIndex = 22
        '
        'lbl_dispositivo_area
        '
        Me.lbl_dispositivo_area.AutoSize = True
        Me.lbl_dispositivo_area.BackColor = System.Drawing.Color.Transparent
        Me.lbl_dispositivo_area.Location = New System.Drawing.Point(478, 295)
        Me.lbl_dispositivo_area.Name = "lbl_dispositivo_area"
        Me.lbl_dispositivo_area.Size = New System.Drawing.Size(100, 13)
        Me.lbl_dispositivo_area.TabIndex = 23
        Me.lbl_dispositivo_area.Text = "Area del Dispositivo"
        '
        'btn_dispositivo_agregarArea
        '
        Me.btn_dispositivo_agregarArea.Location = New System.Drawing.Point(663, 314)
        Me.btn_dispositivo_agregarArea.Name = "btn_dispositivo_agregarArea"
        Me.btn_dispositivo_agregarArea.Size = New System.Drawing.Size(29, 21)
        Me.btn_dispositivo_agregarArea.TabIndex = 24
        Me.btn_dispositivo_agregarArea.Text = "+"
        Me.btn_dispositivo_agregarArea.UseVisualStyleBackColor = True
        '
        'datagrid_dispositivo
        '
        Me.datagrid_dispositivo.AllowUserToAddRows = False
        Me.datagrid_dispositivo.AllowUserToDeleteRows = False
        Me.datagrid_dispositivo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagrid_dispositivo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.datagrid_dispositivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid_dispositivo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codDispositivo, Me.nombre, Me.descripcion, Me.codTipo, Me.baja})
        Me.datagrid_dispositivo.Location = New System.Drawing.Point(11, 35)
        Me.datagrid_dispositivo.Name = "datagrid_dispositivo"
        Me.datagrid_dispositivo.ReadOnly = True
        Me.datagrid_dispositivo.Size = New System.Drawing.Size(442, 303)
        Me.datagrid_dispositivo.TabIndex = 25
        '
        'codDispositivo
        '
        Me.codDispositivo.DataPropertyName = "codDispositivo"
        Me.codDispositivo.HeaderText = "Codigo"
        Me.codDispositivo.Name = "codDispositivo"
        Me.codDispositivo.ReadOnly = True
        Me.codDispositivo.Visible = False
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'descripcion
        '
        Me.descripcion.DataPropertyName = "descripcion"
        Me.descripcion.HeaderText = "Descripcion"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        '
        'codTipo
        '
        Me.codTipo.DataPropertyName = "codTipo"
        Me.codTipo.HeaderText = "Codigo Tipo"
        Me.codTipo.Name = "codTipo"
        Me.codTipo.ReadOnly = True
        Me.codTipo.Visible = False
        '
        'baja
        '
        Me.baja.DataPropertyName = "baja"
        Me.baja.HeaderText = "Baja"
        Me.baja.Name = "baja"
        Me.baja.ReadOnly = True
        Me.baja.Visible = False
        '
        'btn_dispositivo_cerrar
        '
        Me.btn_dispositivo_cerrar.Location = New System.Drawing.Point(354, 356)
        Me.btn_dispositivo_cerrar.Name = "btn_dispositivo_cerrar"
        Me.btn_dispositivo_cerrar.Size = New System.Drawing.Size(100, 23)
        Me.btn_dispositivo_cerrar.TabIndex = 26
        Me.btn_dispositivo_cerrar.Text = "Cerrar"
        Me.btn_dispositivo_cerrar.UseVisualStyleBackColor = True
        '
        'btn_dispositivo_Nuevo
        '
        Me.btn_dispositivo_Nuevo.Location = New System.Drawing.Point(239, 356)
        Me.btn_dispositivo_Nuevo.Name = "btn_dispositivo_Nuevo"
        Me.btn_dispositivo_Nuevo.Size = New System.Drawing.Size(100, 23)
        Me.btn_dispositivo_Nuevo.TabIndex = 27
        Me.btn_dispositivo_Nuevo.Text = "Nuevo"
        Me.btn_dispositivo_Nuevo.UseVisualStyleBackColor = True
        '
        'CapaInterfaz_dispositivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.fondoPrincipal
        Me.ClientSize = New System.Drawing.Size(709, 391)
        Me.Controls.Add(Me.btn_dispositivo_Nuevo)
        Me.Controls.Add(Me.btn_dispositivo_cerrar)
        Me.Controls.Add(Me.datagrid_dispositivo)
        Me.Controls.Add(Me.btn_dispositivo_agregarArea)
        Me.Controls.Add(Me.lbl_dispositivo_area)
        Me.Controls.Add(Me.cmb_dispositivo_area)
        Me.Controls.Add(Me.btn_dispositivo_modificar)
        Me.Controls.Add(Me.btn_dispositivo_borrar)
        Me.Controls.Add(Me.btn_dispositivo_agregarTipoDispositivo)
        Me.Controls.Add(Me.lbl_lista_dispositivos)
        Me.Controls.Add(Me.btn_dispositivo_aceptar)
        Me.Controls.Add(Me.btn_dispositivo_cancelar)
        Me.Controls.Add(Me.cmb_dispositivo_tipo)
        Me.Controls.Add(Me.lbl_dispositivo_tipo)
        Me.Controls.Add(Me.txt_dispositivo_descripcion)
        Me.Controls.Add(Me.txt_dispositivo_nombre)
        Me.Controls.Add(Me.lbl_dispositivo_descripcion)
        Me.Controls.Add(Me.lbl_dispositivo_nombre)
        Me.Controls.Add(Me.lbl_dispositivo_agregar)
        Me.Name = "CapaInterfaz_dispositivo"
        Me.Text = "Administrar Dispositivos"
        CType(Me.datagrid_dispositivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_dispositivo_aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_dispositivo_cancelar As System.Windows.Forms.Button
    Friend WithEvents cmb_dispositivo_tipo As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_dispositivo_tipo As System.Windows.Forms.Label
    Friend WithEvents txt_dispositivo_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents txt_dispositivo_nombre As System.Windows.Forms.TextBox
    Friend WithEvents lbl_dispositivo_descripcion As System.Windows.Forms.Label
    Friend WithEvents lbl_dispositivo_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_dispositivo_agregar As System.Windows.Forms.Label
    Friend WithEvents lbl_lista_dispositivos As System.Windows.Forms.Label
    Friend WithEvents btn_dispositivo_agregarTipoDispositivo As System.Windows.Forms.Button
    Friend WithEvents btn_dispositivo_borrar As System.Windows.Forms.Button
    Friend WithEvents btn_dispositivo_modificar As System.Windows.Forms.Button
    Friend WithEvents cmb_dispositivo_area As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_dispositivo_area As System.Windows.Forms.Label
    Friend WithEvents btn_dispositivo_agregarArea As System.Windows.Forms.Button
    Friend WithEvents datagrid_dispositivo As System.Windows.Forms.DataGridView
    Friend WithEvents btn_dispositivo_cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_dispositivo_Nuevo As System.Windows.Forms.Button
    Friend WithEvents codDispositivo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents baja As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
