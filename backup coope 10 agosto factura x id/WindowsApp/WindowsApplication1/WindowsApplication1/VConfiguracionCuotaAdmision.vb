Public Class VConfiguracionCuotaAdmision

    Dim cuotaAdmision As CuotaAdmision = New CuotaAdmision
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales


    Dim certificados As Certificados = New Certificados



    'Carga los datos de la info de la coope
    Private Sub VConfiguracionInformacionCooperativa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cuotaAdmision.consultarInformacionAdmision()

        Me.Panel1.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.ButtonConfiguracionCuotaAdmisionGuardar.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)

    End Sub


    Private Sub ConfiguracionTextBoxCuotaAdmision_TextChanged(sender As Object, e As KeyPressEventArgs) Handles ConfiguracionTextBoxCuotaAdmision.KeyPress
        Me.ConfiguracionTextBoxCuotaAdmision.MaxLength = 3
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ButtonConfiguracionCuotaAdmisionGuardar_Click(sender As Object, e As EventArgs) Handles ButtonConfiguracionCuotaAdmisionGuardar.Click
        If Singleton.rol = "Colaborador" Then
            MessageBox.Show(variablesGlobales.permisosDeAdminRequeridos)
        Else
            cuotaAdmision.actualizarDatosDeCuotaAdmision()
            cuotaAdmision.consultarCuotaAdmision()
        End If
        Me.Close()
    End Sub
End Class