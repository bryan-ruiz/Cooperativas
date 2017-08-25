Public Class Ventana_Acceso

    Private Sub Label26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label26.Click

    End Sub
    Private Sub ButtonInsertar_InformacionAccidente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonIngresar.Click
        If (TextBoxlogin.Text = "" Or TextBoxContraseña.Text = "") Then
            MsgBox("Debe llenar todos los campos para Ingresar")
            TextBoxlogin.Text = ""
            TextBoxContraseña.Text = ""
        Else
            Dim usuario As Usuarios = New Usuarios
            usuario.buscar()
            If (TextBoxlogin.Text = Singleton.usuario) Then
                If (TextBoxContraseña.Text = Singleton.contrasena) Then
                    If Singleton.permisos = "0" Then
                        MsgBox("Su licencia ha caducado. Contacte al Administrador del Sistema.")
                    Else
                        usuario.login()
                        Me.Hide()
                        Ventana_Principal.Show()
                        Ventana_Principal.Refresh()
                    End If
                Else
                    MsgBox("El nombre de usuario o contraseña es incorrecto")
                    TextBoxlogin.Text = ""
                    TextBoxContraseña.Text = ""
                End If
            Else
                MsgBox("El nombre de usuario o contraseña es incorrecto")
                TextBoxlogin.Text = ""
                TextBoxContraseña.Text = ""
            End If
        End If

    End Sub

    Private Sub TextBoxContraseña_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxContraseña.TextChanged
        TextBoxContraseña.PasswordChar = "*"
    End Sub
End Class