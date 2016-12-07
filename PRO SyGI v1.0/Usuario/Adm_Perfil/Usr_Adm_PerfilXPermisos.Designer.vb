<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usr_Adm_PerfilXPermisos
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
        Me.dgv_Adm_PerfilXPermisos_perfil = New System.Windows.Forms.DataGridView()
        Me.btn_Adm_PerfilXPermisos_nuevo = New System.Windows.Forms.Button()
        Me.btn_Adm_PerfilXPermisos_agregar = New System.Windows.Forms.Button()
        Me.btn_Adm_PerfilXPermisos_quitar = New System.Windows.Forms.Button()
        Me.lst_Adm_PerfilXPermisos_PermisosAsignados = New System.Windows.Forms.ListBox()
        Me.btn_Adm_PerfilXPermisos_modificar = New System.Windows.Forms.Button()
        Me.btn_Adm_PerfilXPermisos_eliminar = New System.Windows.Forms.Button()
        Me.txt_nombrePerfil = New System.Windows.Forms.TextBox()
        Me.txt_descripcionPerfil = New System.Windows.Forms.TextBox()
        Me.lbl_Adm_PerfilXPermisos_nombrePefil = New System.Windows.Forms.Label()
        Me.lbl_Adm_PerfilXPermisos_descripcion = New System.Windows.Forms.Label()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_confirmar = New System.Windows.Forms.Button()
        Me.cmb_permisos = New System.Windows.Forms.ComboBox()
        Me.Perfil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.baja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv_Adm_PerfilXPermisos_perfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_Adm_PerfilXPermisos_perfil
        '
        Me.dgv_Adm_PerfilXPermisos_perfil.AllowUserToAddRows = False
        Me.dgv_Adm_PerfilXPermisos_perfil.AllowUserToDeleteRows = False
        Me.dgv_Adm_PerfilXPermisos_perfil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Adm_PerfilXPermisos_perfil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Adm_PerfilXPermisos_perfil.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Perfil, Me.Nombre, Me.Descripcion, Me.baja})
        Me.dgv_Adm_PerfilXPermisos_perfil.Location = New System.Drawing.Point(25, 12)
        Me.dgv_Adm_PerfilXPermisos_perfil.Name = "dgv_Adm_PerfilXPermisos_perfil"
        Me.dgv_Adm_PerfilXPermisos_perfil.ReadOnly = True
        Me.dgv_Adm_PerfilXPermisos_perfil.Size = New System.Drawing.Size(550, 187)
        Me.dgv_Adm_PerfilXPermisos_perfil.TabIndex = 0
        '
        'btn_Adm_PerfilXPermisos_nuevo
        '
        Me.btn_Adm_PerfilXPermisos_nuevo.Location = New System.Drawing.Point(502, 205)
        Me.btn_Adm_PerfilXPermisos_nuevo.Name = "btn_Adm_PerfilXPermisos_nuevo"
        Me.btn_Adm_PerfilXPermisos_nuevo.Size = New System.Drawing.Size(75, 23)
        Me.btn_Adm_PerfilXPermisos_nuevo.TabIndex = 2
        Me.btn_Adm_PerfilXPermisos_nuevo.Text = "Nuevo"
        Me.btn_Adm_PerfilXPermisos_nuevo.UseVisualStyleBackColor = True
        '
        'btn_Adm_PerfilXPermisos_agregar
        '
        Me.btn_Adm_PerfilXPermisos_agregar.Location = New System.Drawing.Point(228, 405)
        Me.btn_Adm_PerfilXPermisos_agregar.Name = "btn_Adm_PerfilXPermisos_agregar"
        Me.btn_Adm_PerfilXPermisos_agregar.Size = New System.Drawing.Size(37, 23)
        Me.btn_Adm_PerfilXPermisos_agregar.TabIndex = 5
        Me.btn_Adm_PerfilXPermisos_agregar.Text = "+"
        Me.btn_Adm_PerfilXPermisos_agregar.UseVisualStyleBackColor = True
        '
        'btn_Adm_PerfilXPermisos_quitar
        '
        Me.btn_Adm_PerfilXPermisos_quitar.Location = New System.Drawing.Point(317, 405)
        Me.btn_Adm_PerfilXPermisos_quitar.Name = "btn_Adm_PerfilXPermisos_quitar"
        Me.btn_Adm_PerfilXPermisos_quitar.Size = New System.Drawing.Size(37, 23)
        Me.btn_Adm_PerfilXPermisos_quitar.TabIndex = 6
        Me.btn_Adm_PerfilXPermisos_quitar.Text = "-"
        Me.btn_Adm_PerfilXPermisos_quitar.UseVisualStyleBackColor = True
        '
        'lst_Adm_PerfilXPermisos_PermisosAsignados
        '
        Me.lst_Adm_PerfilXPermisos_PermisosAsignados.FormattingEnabled = True
        Me.lst_Adm_PerfilXPermisos_PermisosAsignados.Location = New System.Drawing.Point(27, 444)
        Me.lst_Adm_PerfilXPermisos_PermisosAsignados.Name = "lst_Adm_PerfilXPermisos_PermisosAsignados"
        Me.lst_Adm_PerfilXPermisos_PermisosAsignados.Size = New System.Drawing.Size(548, 199)
        Me.lst_Adm_PerfilXPermisos_PermisosAsignados.TabIndex = 7
        '
        'btn_Adm_PerfilXPermisos_modificar
        '
        Me.btn_Adm_PerfilXPermisos_modificar.Location = New System.Drawing.Point(627, 205)
        Me.btn_Adm_PerfilXPermisos_modificar.Name = "btn_Adm_PerfilXPermisos_modificar"
        Me.btn_Adm_PerfilXPermisos_modificar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Adm_PerfilXPermisos_modificar.TabIndex = 8
        Me.btn_Adm_PerfilXPermisos_modificar.Text = "Modificar"
        Me.btn_Adm_PerfilXPermisos_modificar.UseVisualStyleBackColor = True
        '
        'btn_Adm_PerfilXPermisos_eliminar
        '
        Me.btn_Adm_PerfilXPermisos_eliminar.Location = New System.Drawing.Point(421, 205)
        Me.btn_Adm_PerfilXPermisos_eliminar.Name = "btn_Adm_PerfilXPermisos_eliminar"
        Me.btn_Adm_PerfilXPermisos_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Adm_PerfilXPermisos_eliminar.TabIndex = 9
        Me.btn_Adm_PerfilXPermisos_eliminar.Text = "Eliminar"
        Me.btn_Adm_PerfilXPermisos_eliminar.UseVisualStyleBackColor = True
        '
        'txt_nombrePerfil
        '
        Me.txt_nombrePerfil.Location = New System.Drawing.Point(27, 253)
        Me.txt_nombrePerfil.Name = "txt_nombrePerfil"
        Me.txt_nombrePerfil.Size = New System.Drawing.Size(550, 20)
        Me.txt_nombrePerfil.TabIndex = 10
        '
        'txt_descripcionPerfil
        '
        Me.txt_descripcionPerfil.Location = New System.Drawing.Point(27, 296)
        Me.txt_descripcionPerfil.Multiline = True
        Me.txt_descripcionPerfil.Name = "txt_descripcionPerfil"
        Me.txt_descripcionPerfil.Size = New System.Drawing.Size(550, 55)
        Me.txt_descripcionPerfil.TabIndex = 11
        '
        'lbl_Adm_PerfilXPermisos_nombrePefil
        '
        Me.lbl_Adm_PerfilXPermisos_nombrePefil.AutoSize = True
        Me.lbl_Adm_PerfilXPermisos_nombrePefil.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Adm_PerfilXPermisos_nombrePefil.Location = New System.Drawing.Point(27, 234)
        Me.lbl_Adm_PerfilXPermisos_nombrePefil.Name = "lbl_Adm_PerfilXPermisos_nombrePefil"
        Me.lbl_Adm_PerfilXPermisos_nombrePefil.Size = New System.Drawing.Size(44, 13)
        Me.lbl_Adm_PerfilXPermisos_nombrePefil.TabIndex = 12
        Me.lbl_Adm_PerfilXPermisos_nombrePefil.Text = "Nombre"
        '
        'lbl_Adm_PerfilXPermisos_descripcion
        '
        Me.lbl_Adm_PerfilXPermisos_descripcion.AutoSize = True
        Me.lbl_Adm_PerfilXPermisos_descripcion.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Adm_PerfilXPermisos_descripcion.Location = New System.Drawing.Point(30, 280)
        Me.lbl_Adm_PerfilXPermisos_descripcion.Name = "lbl_Adm_PerfilXPermisos_descripcion"
        Me.lbl_Adm_PerfilXPermisos_descripcion.Size = New System.Drawing.Size(63, 13)
        Me.lbl_Adm_PerfilXPermisos_descripcion.TabIndex = 13
        Me.lbl_Adm_PerfilXPermisos_descripcion.Text = "Descripcion"
        Me.lbl_Adm_PerfilXPermisos_descripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(501, 652)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 14
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_confirmar
        '
        Me.btn_confirmar.Location = New System.Drawing.Point(421, 652)
        Me.btn_confirmar.Name = "btn_confirmar"
        Me.btn_confirmar.Size = New System.Drawing.Size(75, 23)
        Me.btn_confirmar.TabIndex = 15
        Me.btn_confirmar.Text = "Confirmar"
        Me.btn_confirmar.UseVisualStyleBackColor = True
        '
        'cmb_permisos
        '
        Me.cmb_permisos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_permisos.FormattingEnabled = True
        Me.cmb_permisos.Location = New System.Drawing.Point(25, 378)
        Me.cmb_permisos.Name = "cmb_permisos"
        Me.cmb_permisos.Size = New System.Drawing.Size(550, 21)
        Me.cmb_permisos.TabIndex = 16
        '
        'Perfil
        '
        Me.Perfil.DataPropertyName = "codTipo"
        Me.Perfil.HeaderText = "Perfil"
        Me.Perfil.Name = "Perfil"
        Me.Perfil.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "descripcion"
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'baja
        '
        Me.baja.DataPropertyName = "baja"
        Me.baja.HeaderText = "baja"
        Me.baja.Name = "baja"
        Me.baja.ReadOnly = True
        Me.baja.Visible = False
        '
        'Usr_Adm_PerfilXPermisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.fondoPrincipal
        Me.ClientSize = New System.Drawing.Size(592, 678)
        Me.Controls.Add(Me.cmb_permisos)
        Me.Controls.Add(Me.btn_confirmar)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.lbl_Adm_PerfilXPermisos_descripcion)
        Me.Controls.Add(Me.lbl_Adm_PerfilXPermisos_nombrePefil)
        Me.Controls.Add(Me.txt_descripcionPerfil)
        Me.Controls.Add(Me.txt_nombrePerfil)
        Me.Controls.Add(Me.btn_Adm_PerfilXPermisos_eliminar)
        Me.Controls.Add(Me.btn_Adm_PerfilXPermisos_modificar)
        Me.Controls.Add(Me.lst_Adm_PerfilXPermisos_PermisosAsignados)
        Me.Controls.Add(Me.btn_Adm_PerfilXPermisos_quitar)
        Me.Controls.Add(Me.btn_Adm_PerfilXPermisos_agregar)
        Me.Controls.Add(Me.btn_Adm_PerfilXPermisos_nuevo)
        Me.Controls.Add(Me.dgv_Adm_PerfilXPermisos_perfil)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Usr_Adm_PerfilXPermisos"
        Me.Text = "Administracion de Permios en Perfiles"
        CType(Me.dgv_Adm_PerfilXPermisos_perfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_Adm_PerfilXPermisos_perfil As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Adm_PerfilXPermisos_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_Adm_PerfilXPermisos_agregar As System.Windows.Forms.Button
    Friend WithEvents btn_Adm_PerfilXPermisos_quitar As System.Windows.Forms.Button
    Friend WithEvents lst_Adm_PerfilXPermisos_PermisosAsignados As System.Windows.Forms.ListBox
    Friend WithEvents btn_Adm_PerfilXPermisos_modificar As System.Windows.Forms.Button
    Friend WithEvents btn_Adm_PerfilXPermisos_eliminar As System.Windows.Forms.Button
    Friend WithEvents txt_nombrePerfil As System.Windows.Forms.TextBox
    Friend WithEvents txt_descripcionPerfil As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Adm_PerfilXPermisos_nombrePefil As System.Windows.Forms.Label
    Friend WithEvents lbl_Adm_PerfilXPermisos_descripcion As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_confirmar As System.Windows.Forms.Button
    Friend WithEvents cmb_permisos As System.Windows.Forms.ComboBox
    Friend WithEvents Perfil As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents baja As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
