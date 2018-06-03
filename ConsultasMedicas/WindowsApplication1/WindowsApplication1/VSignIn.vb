Public Class VSignIn

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
                        Principal.Show()
                        Principal.Refresh()
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

    Private Sub TextBoxContraseña_TextChanged(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles TextBoxContraseña.KeyPress
        TextBoxContraseña.PasswordChar = "*"
        If e.KeyChar = ChrW(Keys.Enter) Then
            Call ButtonInsertar_InformacionAccidente_Click(sender, e)
        End If
    End Sub

    Private Sub VSignIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxlogin.Select()
    End Sub

    Private Sub ButtonLicencia_Click(sender As Object, e As EventArgs) Handles ButtonLicencia.Click
        VLicencias.Show()
    End Sub
End Class