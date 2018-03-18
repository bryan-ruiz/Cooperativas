Public Class VSignIn

    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales
    Dim licencias As Licencias = New Licencias

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
        'Esto se hace solo una vez en la BD
        licencias.insertarLicenciasEnBD()


        ' Dim existe As Integer = 0
        'existe = licencias.buscarLicencia("asR7AjWqg")

        'If (existe = 1) Then
        'MessageBox.Show("La licencia es válida", " ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        'Else
        'MessageBox.Show("Licencia inactiva, contacte al Administrador", " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        'End If

        Dim valores As List(Of String)

        valores = licencias.consultarLicenciaEnBD("asR7AjWqg")

        If valores.Count <> 0 Then
            ' MessageBox.Show(variablesGlobales.licenciasRenovadas, " ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

            'llamar a actualizar licencia
            Try
                licencias.actualizarEstadoLicencia(valores.Item(1), "0")
            Catch ex As Exception
                MessageBox.Show(variablesGlobales.errorRenovandoLicencia, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End Try


            ''llamar a actualizar USUARIO.permisos = 300
            'pending

        End If






        'Para renovar la licencia
        '

    End Sub
End Class