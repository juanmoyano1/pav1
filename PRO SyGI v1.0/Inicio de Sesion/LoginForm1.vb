Public Class frm_login

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_aceptar.Click

        If Not IsNumeric(txb_nombre.Text) Then
            MsgBox("Usuario o contraseña incorrectos", MsgBoxStyle.Information, "Error")
            Exit Sub
        End If

        Dim oUsuario As Usr = Usuarios_Datos.getUsuario(txb_nombre.Text, txb_password.Text)
        If IsNothing(oUsuario) Then
            MsgBox("Usuario o contraseña incorrectos", MsgBoxStyle.Information, "Error")
            Exit Sub
        End If

        Usuarios_Datos.getOpcionesMenu(oUsuario.tipoUsr)

        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelar.Click
        End
    End Sub

End Class
