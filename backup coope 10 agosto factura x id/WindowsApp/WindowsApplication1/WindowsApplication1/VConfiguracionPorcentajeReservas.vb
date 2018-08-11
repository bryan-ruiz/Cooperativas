Public Class VConfiguracionPorcentajeReservas

    Dim configuracionReservas As Configuracion = New Configuracion
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales


    Private Sub VConfiguracionPorcentajeReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load
        configuracionReservas.consultarPorcentajeReservas()

        Me.Panel1.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.ButtonConfiguracionReservasModificar.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)

    End Sub


    Private Sub ButtonConfiguracionReservasModificar_Click(sender As Object, e As EventArgs) Handles ButtonConfiguracionReservasModificar.Click
        configuracionReservas.actualizarPorcentajeReservas()
        Me.Close()
    End Sub

    Private Sub ConfiguracionTextBoxLegal_TextChanged(sender As Object, e As KeyPressEventArgs) Handles ConfiguracionTextBoxLegal.KeyPress
        Me.ConfiguracionTextBoxLegal.MaxLength = 2
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ConfiguracionTextBoxEducacion_TextChanged(sender As Object, e As KeyPressEventArgs) Handles ConfiguracionTextBoxEducacion.KeyPress
        Me.ConfiguracionTextBoxEducacion.MaxLength = 2
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ConfiguracionTextBoxBienestarSocial_TextChanged(sender As Object, e As KeyPressEventArgs) Handles ConfiguracionTextBoxBienestarSocial.KeyPress
        Me.ConfiguracionTextBoxBienestarSocial.MaxLength = 2
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ConfiguracionTextBoxInstitucional_TextChanged(sender As Object, e As KeyPressEventArgs) Handles ConfiguracionTextBoxInstitucional.KeyPress
        Me.ConfiguracionTextBoxInstitucional.MaxLength = 2
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ConfiguracionTextBoxPatrimonial_TextChanged(sender As Object, e As KeyPressEventArgs) Handles ConfiguracionTextBoxPatrimonial.KeyPress
        Me.ConfiguracionTextBoxPatrimonial.MaxLength = 2
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class