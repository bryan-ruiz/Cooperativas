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


    Private Sub VMotivoConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Panel1.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)

        Me.ExpedienteButtonBuscar.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.ExpedienteButtonBuscarXNombre.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.ExpedienteButtonLimpiar.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.ExpedienteButtonActualizarDatos.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.ExpedienteButtonVerMotivoConsulta.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)

    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub MotivoConsultaButtonBuscar_Click(sender As Object, e As EventArgs) Handles ExpedienteButtonBuscar.Click
        'Buscar x cedula de paciente
        'etc

        'carga la info desde la BD para un paciente
        Dim cedula As String = ExpedienteTextboxCed.Text
        If (cedula = "") Then
            MessageBox.Show(variablesGlobales.mensajeCedulaNula, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Return
        End If


    End Sub

    Private Sub MotivoConsultaButtonLimpiar_Click(sender As Object, e As EventArgs) Handles ExpedienteButtonLimpiar.Click
        limpiar()
    End Sub

    Public Sub limpiar()
        ExpedienteTextboxCed.Text = ""
        ExpedienteTextboxNombreYApellidos.Text = ""
        ExpedienteTextboxConsultarCedula.Text = ""

        'etc
    End Sub


    Private Sub ExpedienteButtonBuscarXNombre_Click(sender As Object, e As EventArgs) Handles ExpedienteButtonBuscarXNombre.Click
        'Pending
    End Sub

    Private Sub ExpedienteButtonActualizarDatos_Click(sender As Object, e As EventArgs) Handles ExpedienteButtonActualizarDatos.Click

    End Sub

    Private Sub ExpedienteButtonVerMotivoConsulta_Click(sender As Object, e As EventArgs) Handles ExpedienteButtonVerMotivoConsulta.Click
        VMotivoConsulta.Show()
        'llamar con la cedula a buscar motivo consulta para cargar los datos automáticamente
        'pending
    End Sub
End Class