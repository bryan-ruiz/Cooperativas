

Public Class Ventana_Acceso

    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales

    Private Sub ButtonInsertar_InformacionAccidente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonIngresar.Click

        If (TextBoxlogin.Text = "" Or TextBoxContraseña.Text = "") Then
            MessageBox.Show(variablesGlobales.noDebenHaberCamposVacios, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

            TextBoxlogin.Text = ""
            TextBoxContraseña.Text = ""
        Else
            Dim usuario As Usuarios = New Usuarios
            usuario.buscar()
            If (TextBoxlogin.Text = Singleton.usuario) Then
                If (TextBoxContraseña.Text = Singleton.contrasena) Then

                    If Singleton.permisos = "0" Then
                        MessageBox.Show(variablesGlobales.licenciaCaducada, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    Else
                        usuario.login()
                        Me.Hide()
                        Ventana_Principal.Show()
                        Ventana_Principal.Refresh()
                    End If
                Else
                    MessageBox.Show(variablesGlobales.nombreUsuarioOContrasenaIncorrecto, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    TextBoxlogin.Text = ""
                    TextBoxContraseña.Text = ""
                End If
            Else
                MessageBox.Show(variablesGlobales.nombreUsuarioOContrasenaIncorrecto, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                TextBoxlogin.Text = ""
                TextBoxContraseña.Text = ""
            End If
        End If

    End Sub

    Private Sub TextBoxContraseña_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxContraseña.TextChanged
        TextBoxContraseña.PasswordChar = "*"
    End Sub
End Class