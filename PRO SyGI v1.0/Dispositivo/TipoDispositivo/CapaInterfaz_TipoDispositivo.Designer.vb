<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CapaInterfaz_TipoDispositivo
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
        Me.txt_tipoDispositivo = New System.Windows.Forms.TextBox()
        Me.lbl_nombreTipoDipositivo = New System.Windows.Forms.Label()
        Me.btn_agregar_tipoDispositivo = New System.Windows.Forms.Button()
        Me.grid_tipoDispositivo = New System.Windows.Forms.DataGridView()
        Me.codTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.baja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_tipoDispositivo_borrar = New System.Windows.Forms.Button()
        Me.btn_tipoDispositivo_modificar = New System.Windows.Forms.Button()
        Me.btn_tipoDispositivo_cerrar = New System.Windows.Forms.Button()
        CType(Me.grid_tipoDispositivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_tipoDispositivo
        '
        Me.txt_tipoDispositivo.Location = New System.Drawing.Point(12, 25)
        Me.txt_tipoDispositivo.Name = "txt_tipoDispositivo"
        Me.txt_tipoDispositivo.Size = New System.Drawing.Size(296, 20)
        Me.txt_tipoDispositivo.TabIndex = 0
        '
        'lbl_nombreTipoDipositivo
        '
        Me.lbl_nombreTipoDipositivo.AutoSize = True
        Me.lbl_nombreTipoDipositivo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_nombreTipoDipositivo.Location = New System.Drawing.Point(12, 9)
        Me.lbl_nombreTipoDipositivo.Name = "lbl_nombreTipoDipositivo"
        Me.lbl_nombreTipoDipositivo.Size = New System.Drawing.Size(118, 13)
        Me.lbl_nombreTipoDipositivo.TabIndex = 1
        Me.lbl_nombreTipoDipositivo.Text = "Nombre del nuevo Tipo"
        '
        'btn_agregar_tipoDispositivo
        '
        Me.btn_agregar_tipoDispositivo.Location = New System.Drawing.Point(314, 22)
        Me.btn_agregar_tipoDispositivo.Name = "btn_agregar_tipoDispositivo"
        Me.btn_agregar_tipoDispositivo.Size = New System.Drawing.Size(75, 23)
        Me.btn_agregar_tipoDispositivo.TabIndex = 2
        Me.btn_agregar_tipoDispositivo.Text = "Agregar"
        Me.btn_agregar_tipoDispositivo.UseVisualStyleBackColor = True
        '
        'grid_tipoDispositivo
        '
        Me.grid_tipoDispositivo.AllowUserToAddRows = False
        Me.grid_tipoDispositivo.AllowUserToDeleteRows = False
        Me.grid_tipoDispositivo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grid_tipoDispositivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_tipoDispositivo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codTipo, Me.descripcion, Me.baja})
        Me.grid_tipoDispositivo.Location = New System.Drawing.Point(12, 52)
        Me.grid_tipoDispositivo.Name = "grid_tipoDispositivo"
        Me.grid_tipoDispositivo.ReadOnly = True
        Me.grid_tipoDispositivo.Size = New System.Drawing.Size(377, 255)
        Me.grid_tipoDispositivo.TabIndex = 3
        '
        'codTipo
        '
        Me.codTipo.DataPropertyName = "codTipo"
        Me.codTipo.HeaderText = "codTipo"
        Me.codTipo.Name = "codTipo"
        Me.codTipo.ReadOnly = True
        Me.codTipo.Visible = False
        '
        'descripcion
        '
        Me.descripcion.DataPropertyName = "descripcion"
        Me.descripcion.HeaderText = "Nombre"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        '
        'baja
        '
        Me.baja.DataPropertyName = "baja"
        Me.baja.HeaderText = "baja"
        Me.baja.Name = "baja"
        Me.baja.ReadOnly = True
        Me.baja.Visible = False
        '
        'btn_tipoDispositivo_borrar
        '
        Me.btn_tipoDispositivo_borrar.Location = New System.Drawing.Point(153, 314)
        Me.btn_tipoDispositivo_borrar.Name = "btn_tipoDispositivo_borrar"
        Me.btn_tipoDispositivo_borrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_tipoDispositivo_borrar.TabIndex = 4
        Me.btn_tipoDispositivo_borrar.Text = "Borrar"
        Me.btn_tipoDispositivo_borrar.UseVisualStyleBackColor = True
        '
        'btn_tipoDispositivo_modificar
        '
        Me.btn_tipoDispositivo_modificar.Location = New System.Drawing.Point(234, 313)
        Me.btn_tipoDispositivo_modificar.Name = "btn_tipoDispositivo_modificar"
        Me.btn_tipoDispositivo_modificar.Size = New System.Drawing.Size(75, 23)
        Me.btn_tipoDispositivo_modificar.TabIndex = 5
        Me.btn_tipoDispositivo_modificar.Text = "Modificar"
        Me.btn_tipoDispositivo_modificar.UseVisualStyleBackColor = True
        '
        'btn_tipoDispositivo_cerrar
        '
        Me.btn_tipoDispositivo_cerrar.Location = New System.Drawing.Point(314, 313)
        Me.btn_tipoDispositivo_cerrar.Name = "btn_tipoDispositivo_cerrar"
        Me.btn_tipoDispositivo_cerrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_tipoDispositivo_cerrar.TabIndex = 6
        Me.btn_tipoDispositivo_cerrar.Text = "Cerrar"
        Me.btn_tipoDispositivo_cerrar.UseVisualStyleBackColor = True
        '
        'CapaInterfaz_TipoDispositivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.fondoPrincipal
        Me.ClientSize = New System.Drawing.Size(395, 349)
        Me.Controls.Add(Me.btn_tipoDispositivo_cerrar)
        Me.Controls.Add(Me.btn_tipoDispositivo_modificar)
        Me.Controls.Add(Me.btn_tipoDispositivo_borrar)
        Me.Controls.Add(Me.grid_tipoDispositivo)
        Me.Controls.Add(Me.btn_agregar_tipoDispositivo)
        Me.Controls.Add(Me.lbl_nombreTipoDipositivo)
        Me.Controls.Add(Me.txt_tipoDispositivo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CapaInterfaz_TipoDispositivo"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipo dispositivo"
        CType(Me.grid_tipoDispositivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_tipoDispositivo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nombreTipoDipositivo As System.Windows.Forms.Label
    Friend WithEvents btn_agregar_tipoDispositivo As System.Windows.Forms.Button
    Friend WithEvents grid_tipoDispositivo As System.Windows.Forms.DataGridView
    Friend WithEvents btn_tipoDispositivo_borrar As System.Windows.Forms.Button
    Friend WithEvents btn_tipoDispositivo_modificar As System.Windows.Forms.Button
    Friend WithEvents btn_tipoDispositivo_cerrar As System.Windows.Forms.Button
    Friend WithEvents codTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents baja As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
