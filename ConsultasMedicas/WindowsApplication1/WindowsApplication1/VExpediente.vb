Imports System.Data.OleDb
Imports System.IO

Public Class VExpediente

    Dim cerrarPeriodo As Reservas = New Reservas
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales
    Dim conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source =" & "C:/BD/BDConsultasMed.mdb;Jet OLEDB:Database Password=C454gr154;"
    Dim con As OleDbConnection = New OleDbConnection(conString)
    Dim cmd As OleDbCommand
    Dim adapter As OleDbDataAdapter
    Dim dt As DataTable = New DataTable()
    Dim expediente As Expedientes = New Expedientes


    Private Sub VExpediente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Panel1.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)

        Me.ExpedienteButtonBuscar.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        'Me.ExpedienteButtonBuscarXNombre.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.ExpedienteButtonLimpiar.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.ExpedienteButtonActualizarDatos.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.ExpedienteButtonVerMotivoConsulta.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        ExpedienteTextboxConsultarCedula.Select()
    End Sub

    Private Sub MotivoConsultaButtonBuscar_Click(sender As Object, e As EventArgs) Handles ExpedienteButtonBuscar.Click
        expediente.consultarExpedienteXCedula()
    End Sub

    Private Sub MotivoConsultaButtonLimpiar_Click(sender As Object, e As EventArgs) Handles ExpedienteButtonLimpiar.Click
        limpiar()
    End Sub

    Public Sub limpiar()
        ExpedienteTextboxConsultarCedula.Text = ""
        ExpedienteTextboxCed.Text = ""
        ExpedienteTextboxNombreYApellidos.Text = ""
        ExpedienteTextboxG3.Text = ""
        ExpedienteTextboxP3.Text = ""
        ExpedienteTextboxA0.Text = ""
        ExpedienteTextboxC0.Text = ""
        ExpedienteTextboxCC.Text = ""
        ExpedienteTextboxAqx.Text = ""
        ExpedienteTextboxAfyAp.Text = ""
        ExpedienteTextboxAnP.Text = ""
    End Sub

    Private Sub ExpedienteButtonBuscarXNombre_Click(sender As Object, e As EventArgs) Handles ExpedienteButtonBuscarXNombre.Click
        'Pending
    End Sub

    Private Sub ExpedienteButtonActualizarDatos_Click(sender As Object, e As EventArgs) Handles ExpedienteButtonActualizarDatos.Click
        expediente.actualizar()
    End Sub

    Private Sub ExpedienteButtonVerMotivoConsulta_Click(sender As Object, e As EventArgs) Handles ExpedienteButtonVerMotivoConsulta.Click
        VMotivoConsulta.Show()
        'llamar con la cedula a buscar motivo consulta para cargar los datos automáticamente
        'pending
    End Sub

    Private Sub ExpedienteTextboxConsultarCedula_TextChanged(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles ExpedienteTextboxConsultarCedula.KeyPress
        'TextBoxSociosConsultarAsociado.PasswordChar = "*"
        If e.KeyChar = ChrW(Keys.Enter) Then
            Call MotivoConsultaButtonBuscar_Click(sender, e)
        End If
    End Sub

End Class