<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usr_interfaz
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txb_legajo = New System.Windows.Forms.TextBox()
        Me.txb_apellido = New System.Windows.Forms.TextBox()
        Me.txb_nombre = New System.Windows.Forms.TextBox()
        Me.cmb_area = New System.Windows.Forms.ComboBox()
        Me.cmb_tipoUsr = New System.Windows.Forms.ComboBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.btn_crear = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.lbl_clave = New System.Windows.Forms.Label()
        Me.txb_clave = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(82, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Legajo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(82, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Apellido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(82, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(82, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Area"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(82, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Perfil"
        '
        'txb_legajo
        '
        Me.txb_legajo.Location = New System.Drawing.Point(173, 27)
        Me.txb_legajo.Name = "txb_legajo"
        Me.txb_legajo.Size = New System.Drawing.Size(176, 20)
        Me.txb_legajo.TabIndex = 1
        '
        'txb_apellido
        '
        Me.txb_apellido.Location = New System.Drawing.Point(173, 94)
        Me.txb_apellido.Name = "txb_apellido"
        Me.txb_apellido.Size = New System.Drawing.Size(263, 20)
        Me.txb_apellido.TabIndex = 4
        '
        'txb_nombre
        '
        Me.txb_nombre.Location = New System.Drawing.Point(173, 128)
        Me.txb_nombre.Name = "txb_nombre"
        Me.txb_nombre.Size = New System.Drawing.Size(263, 20)
        Me.txb_nombre.TabIndex = 5
        '
        'cmb_area
        '
        Me.cmb_area.FormattingEnabled = True
        Me.cmb_area.Location = New System.Drawing.Point(173, 168)
        Me.cmb_area.Name = "cmb_area"
        Me.cmb_area.Size = New System.Drawing.Size(263, 21)
        Me.cmb_area.TabIndex = 6
        '
        'cmb_tipoUsr
        '
        Me.cmb_tipoUsr.FormattingEnabled = True
        Me.cmb_tipoUsr.Location = New System.Drawing.Point(173, 203)
        Me.cmb_tipoUsr.Name = "cmb_tipoUsr"
        Me.cmb_tipoUsr.Size = New System.Drawing.Size(263, 21)
        Me.cmb_tipoUsr.TabIndex = 7
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(361, 24)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_buscar.TabIndex = 2
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'btn_crear
        '
        Me.btn_crear.Location = New System.Drawing.Point(75, 274)
        Me.btn_crear.Name = "btn_crear"
        Me.btn_crear.Size = New System.Drawing.Size(75, 23)
        Me.btn_crear.TabIndex = 8
        Me.btn_crear.Text = "Crear"
        Me.btn_crear.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Location = New System.Drawing.Point(173, 274)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(75, 23)
        Me.btn_modificar.TabIndex = 9
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(269, 274)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_eliminar.TabIndex = 10
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(361, 274)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancelar.TabIndex = 11
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'lbl_clave
        '
        Me.lbl_clave.AutoSize = True
        Me.lbl_clave.BackColor = System.Drawing.Color.Transparent
        Me.lbl_clave.Location = New System.Drawing.Point(82, 72)
        Me.lbl_clave.Name = "lbl_clave"
        Me.lbl_clave.Size = New System.Drawing.Size(34, 13)
        Me.lbl_clave.TabIndex = 17
        Me.lbl_clave.Text = "Clave"
        '
        'txb_clave
        '
        Me.txb_clave.Location = New System.Drawing.Point(173, 62)
        Me.txb_clave.Name = "txb_clave"
        Me.txb_clave.Size = New System.Drawing.Size(263, 20)
        Me.txb_clave.TabIndex = 3
        '
        'Usr_interfaz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.fondoPrincipal
        Me.ClientSize = New System.Drawing.Size(464, 322)
        Me.Controls.Add(Me.txb_clave)
        Me.Controls.Add(Me.lbl_clave)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_crear)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.cmb_tipoUsr)
        Me.Controls.Add(Me.cmb_area)
        Me.Controls.Add(Me.txb_nombre)
        Me.Controls.Add(Me.txb_apellido)
        Me.Controls.Add(Me.txb_legajo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Usr_interfaz"
        Me.Text = "ABM de usuarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txb_legajo As System.Windows.Forms.TextBox
    Friend WithEvents txb_apellido As System.Windows.Forms.TextBox
    Friend WithEvents txb_nombre As System.Windows.Forms.TextBox
    Friend WithEvents cmb_area As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_tipoUsr As System.Windows.Forms.ComboBox
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents btn_crear As System.Windows.Forms.Button
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents lbl_clave As System.Windows.Forms.Label
    Friend WithEvents txb_clave As System.Windows.Forms.TextBox
End Class
