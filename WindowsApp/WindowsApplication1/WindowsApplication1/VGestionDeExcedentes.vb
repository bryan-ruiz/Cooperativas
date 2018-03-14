Public Class VGestionDeExcedentes

    Dim Reserva As Reservas = New Reservas
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales
    Dim gestionExcedentes As GestionExcedentes = New GestionExcedentes

    Private Sub VGestionDeReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Panel1.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.GestionExcButtonLimpiar.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.GestionExcButtonRetirarExcedente.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.GestionExcButtonSumarAlAcumulado.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.GestionExcButtonSumarAReservas.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)

    End Sub

    Private Sub GestionExcButtonLimpiar_Click(sender As Object, e As EventArgs) Handles GestionExcButtonLimpiar.Click

    End Sub

    Private Sub GestionExcButtonConsultar_Click(sender As Object, e As EventArgs) Handles GestionExcButtonConsultar.Click
        gestionExcedentes.consultar()
    End Sub

    Private Sub GestionExcButtonSumarAlAcumulado_Click(sender As Object, e As EventArgs) Handles GestionExcButtonSumarAlAcumulado.Click

    End Sub

    Private Sub GestionExcButtonSumarAReservas_Click(sender As Object, e As EventArgs) Handles GestionExcButtonSumarAReservas.Click

    End Sub

    Private Sub GestionExcButtonRetirarExcedente_Click(sender As Object, e As EventArgs) Handles GestionExcButtonRetirarExcedente.Click

    End Sub

    'para cuando presiona Enter en el Textfield de cedula num asociado
    Private Sub GestionExcTextboxCedulaNumAsociado_TextChanged(sender As System.Object, e As KeyPressEventArgs) Handles GestionExcTextboxCedulaNumAsociado.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Call GestionExcButtonConsultar_Click(sender, e)
        End If
    End Sub
End Class