<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CapaInterfaz_area
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
        Me.lbl_area_textoArea = New System.Windows.Forms.Label()
        Me.txt_area_nombre = New System.Windows.Forms.TextBox()
        Me.grid_area = New System.Windows.Forms.DataGridView()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codArea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.baja = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_area_agregar = New System.Windows.Forms.Button()
        Me.btn_area_cerrar = New System.Windows.Forms.Button()
        Me.btn_area_borrar = New System.Windows.Forms.Button()
        Me.btn_area_modificar = New System.Windows.Forms.Button()
        CType(Me.grid_area, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_area_textoArea
        '
        Me.lbl_area_textoArea.AutoSize = True
        Me.lbl_area_textoArea.BackColor = System.Drawing.Color.Transparent
        Me.lbl_area_textoArea.Location = New System.Drawing.Point(12, 9)
        Me.lbl_area_textoArea.Name = "lbl_area_textoArea"
        Me.lbl_area_textoArea.Size = New System.Drawing.Size(102, 13)
        Me.lbl_area_textoArea.TabIndex = 0
        Me.lbl_area_textoArea.Text = "Agregar nueva Area"
        '
        'txt_area_nombre
        '
        Me.txt_area_nombre.Location = New System.Drawing.Point(12, 28)
        Me.txt_area_nombre.Name = "txt_area_nombre"
        Me.txt_area_nombre.Size = New System.Drawing.Size(339, 20)
        Me.txt_area_nombre.TabIndex = 1
        '
        'grid_area
        '
        Me.grid_area.AllowUserToAddRows = False
        Me.grid_area.AllowUserToDeleteRows = False
        Me.grid_area.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grid_area.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_area.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nombre, Me.codArea, Me.baja})
        Me.grid_area.Location = New System.Drawing.Point(12, 54)
        Me.grid_area.MultiSelect = False
        Me.grid_area.Name = "grid_area"
        Me.grid_area.ReadOnly = True
        Me.grid_area.Size = New System.Drawing.Size(420, 263)
        Me.grid_area.TabIndex = 2
        '
        'nombre
        '
        Me.nombre.DataPropertyName = "nombre"
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'codArea
        '
        Me.codArea.DataPropertyName = "codArea"
        Me.codArea.HeaderText = "Codigo"
        Me.codArea.Name = "codArea"
        Me.codArea.ReadOnly = True
        Me.codArea.Visible = False
        '
        'baja
        '
        Me.baja.DataPropertyName = "baja"
        Me.baja.HeaderText = "Baja"
        Me.baja.Name = "baja"
        Me.baja.ReadOnly = True
        Me.baja.Visible = False
        '
        'btn_area_agregar
        '
        Me.btn_area_agregar.Location = New System.Drawing.Point(357, 25)
        Me.btn_area_agregar.Name = "btn_area_agregar"
        Me.btn_area_agregar.Size = New System.Drawing.Size(75, 23)
        Me.btn_area_agregar.TabIndex = 3
        Me.btn_area_agregar.Text = "Agregar"
        Me.btn_area_agregar.UseVisualStyleBackColor = True
        '
        'btn_area_cerrar
        '
        Me.btn_area_cerrar.Location = New System.Drawing.Point(357, 323)
        Me.btn_area_cerrar.Name = "btn_area_cerrar"
        Me.btn_area_cerrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_area_cerrar.TabIndex = 4
        Me.btn_area_cerrar.Text = "Cerrar"
        Me.btn_area_cerrar.UseVisualStyleBackColor = True
        '
        'btn_area_borrar
        '
        Me.btn_area_borrar.Location = New System.Drawing.Point(195, 323)
        Me.btn_area_borrar.Name = "btn_area_borrar"
        Me.btn_area_borrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_area_borrar.TabIndex = 5
        Me.btn_area_borrar.Text = "Borrar"
        Me.btn_area_borrar.UseVisualStyleBackColor = True
        '
        'btn_area_modificar
        '
        Me.btn_area_modificar.Location = New System.Drawing.Point(276, 323)
        Me.btn_area_modificar.Name = "btn_area_modificar"
        Me.btn_area_modificar.Size = New System.Drawing.Size(75, 23)
        Me.btn_area_modificar.TabIndex = 6
        Me.btn_area_modificar.Text = "Modificar"
        Me.btn_area_modificar.UseVisualStyleBackColor = True
        '
        'CapaInterfaz_area
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.fondoPrincipal
        Me.ClientSize = New System.Drawing.Size(441, 358)
        Me.Controls.Add(Me.btn_area_modificar)
        Me.Controls.Add(Me.btn_area_borrar)
        Me.Controls.Add(Me.btn_area_cerrar)
        Me.Controls.Add(Me.btn_area_agregar)
        Me.Controls.Add(Me.grid_area)
        Me.Controls.Add(Me.txt_area_nombre)
        Me.Controls.Add(Me.lbl_area_textoArea)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CapaInterfaz_area"
        Me.Text = "Administrar Area"
        CType(Me.grid_area, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_area_textoArea As System.Windows.Forms.Label
    Friend WithEvents txt_area_nombre As System.Windows.Forms.TextBox
    Friend WithEvents btn_area_agregar As System.Windows.Forms.Button
    Friend WithEvents btn_area_cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_area_borrar As System.Windows.Forms.Button
    Friend WithEvents btn_area_modificar As System.Windows.Forms.Button
    Friend WithEvents grid_area As System.Windows.Forms.DataGridView
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codArea As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents baja As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
