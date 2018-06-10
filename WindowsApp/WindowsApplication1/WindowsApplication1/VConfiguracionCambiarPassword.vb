Public Class VConfiguracionCambiarPassword

    Dim ingreso As Ingreso = New Ingreso
    Dim gasto As Gastos = New Gastos
    Dim configuracionCodigoCuenta As Configuracion = New Configuracion
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales
    Dim BD As ConexionBD = New ConexionBD

    Private Sub VConfiguracionCodigoCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Panel1.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.CambiarPasswordButtonModificar.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        'configuracionCodigoCuenta.obtenerDatosSeleccionarCuentaGastosEIngresos()
    End Sub

    Private Sub CambiarPasswordButtonModificar_Click(sender As Object, e As EventArgs) Handles CambiarPasswordButtonModificar.Click
        Dim usuario As String
        If (CambiarPasswordRadioButtonAdmin.Checked = True) Then
            usuario = CambiarPasswordRadioButtonAdmin.Text
        Else
            usuario = CambiarPasswordRadioButtonColaborador.Text
        End If
        Dim password As String = CambiarPasswordTextboxPassword.Text
        Dim passwordConfirmar As String = CambiarPasswordTextboxPasswordConfirmar.Text

        If (password = "") Then
            MessageBox.Show(variablesGlobales.noDebenHaberCamposVacios, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Return
        End If
        If (password <> passwordConfirmar) Then
            MessageBox.Show("Las contraseñas no coinciden, vuelva a confirmar la contraseña.", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            CambiarPasswordTextboxPasswordConfirmar.Text = ""
            CambiarPasswordTextboxPasswordConfirmar.Select()
            Return
        Else
            Try
                BD.ConectarBD()
                Dim modificado = BD.actualizarPasswordDelUsuario(usuario, password)
                If modificado = 1 Then
                    MessageBox.Show(variablesGlobales.datosActualizadosConExito, " ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    limpiar()
                Else
                    MessageBox.Show(variablesGlobales.errorActualizandoDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    limpiar()
                End If
                BD.CerrarConexion()
            Catch ex As Exception
                MessageBox.Show(variablesGlobales.errorDe + ex.Message())
            End Try
        End If
    End Sub

    Private Sub limpiar()
        CambiarPasswordTextboxPassword.Text = ""
        CambiarPasswordTextboxPasswordConfirmar.Text = ""
    End Sub

    Private Sub CambiarPasswordTextboxPassword_TextChanged(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles CambiarPasswordTextboxPassword.KeyPress
        CambiarPasswordTextboxPassword.PasswordChar = "*"
    End Sub

    Private Sub CambiarPasswordTextboxPasswordConfirmar_TextChanged(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles CambiarPasswordTextboxPasswordConfirmar.KeyPress
        CambiarPasswordTextboxPasswordConfirmar.PasswordChar = "*"
    End Sub

End Class



