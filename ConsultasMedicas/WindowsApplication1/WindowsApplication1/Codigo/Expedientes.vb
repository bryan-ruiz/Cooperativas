Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class Expedientes

    Dim BD As ConexionBD = New ConexionBD
    Dim encabezado As EncabezadoClase = New EncabezadoClase
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales
    Dim informeEconomico As InformeEconomico = New InformeEconomico

    'consulta un exp x cedula
    Public Sub consultarExpedienteXCedula()

        Dim valores As List(Of ExpedienteClase)
        Dim valores2 As List(Of PacienteClase)
        Dim consultarAsociado As String = VExpediente.ExpedienteTextboxConsultarCedula.Text

        If (consultarAsociado = "") Then
            MessageBox.Show(variablesGlobales.mensajeCedulaNula, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            limpiar()
        Else
            Try
                BD.ConectarBD()

                valores = BD.consultarExpedienteXCedula(consultarAsociado)
                valores2 = BD.consultarPacienteXCedula(consultarAsociado)
                If valores.Count <> 0 Then

                    VExpediente.ExpedienteTextboxCed.Text = valores(0).cedula
                    VExpediente.ExpedienteDateTimeFecha.Value = Date.Parse(valores(0).fechaExpediente)
                    VExpediente.ExpedienteTextboxG3.Text = valores(0).G3
                    VExpediente.ExpedienteTextboxP3.Text = valores(0).P3
                    VExpediente.ExpedienteTextboxA0.Text = valores(0).A0
                    VExpediente.ExpedienteTextboxC0.Text = valores(0).C0
                    VExpediente.ExpedienteTextboxCC.Text = valores(0).CC
                    VExpediente.ExpedienteTextboxAqx.Text = valores(0).Aqx
                    VExpediente.ExpedienteTextboxAfyAp.Text = valores(0).AfyAp
                    VExpediente.ExpedienteTextboxAnP.Text = valores(0).AnP
                    'Para llenar nombre completo
                    VExpediente.ExpedienteTextboxNombreYApellidos.Text = valores2(0).nombre + " " + valores2(0).primerApellido + " " + valores2(0).segundoApellido
                Else
                    MessageBox.Show(variablesGlobales.noExistenDatos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    limpiar()
                End If

                BD.CerrarConexion()

            Catch ex As Exception
                MessageBox.Show(variablesGlobales.errorDe + ex.Message)

            End Try
        End If

    End Sub

    'Limpia los campos de expedientes'
    Public Sub limpiar()
        VExpediente.ExpedienteTextboxConsultarCedula.Text = ""
        VExpediente.ExpedienteTextboxCed.Text = ""
        VExpediente.ExpedienteTextboxNombreYApellidos.Text = ""
        VExpediente.ExpedienteTextboxG3.Text = ""
        VExpediente.ExpedienteTextboxP3.Text = ""
        VExpediente.ExpedienteTextboxA0.Text = ""
        VExpediente.ExpedienteTextboxC0.Text = ""
        VExpediente.ExpedienteTextboxCC.Text = ""
        VExpediente.ExpedienteTextboxAqx.Text = ""
        VExpediente.ExpedienteTextboxAfyAp.Text = ""
        VExpediente.ExpedienteTextboxAnP.Text = ""
    End Sub

    'Actualizar Info de Pacientes'
    Public Sub actualizar()

        Dim cedula As String = VExpediente.ExpedienteTextboxCed.Text
        Dim fechaExpediente As Date = VExpediente.ExpedienteDateTimeFecha.Value.ToString("dd/MM/yyyy")
        Dim G3 As String = VExpediente.ExpedienteTextboxG3.Text
        Dim P3 As String = VExpediente.ExpedienteTextboxP3.Text
        Dim A0 As String = VExpediente.ExpedienteTextboxA0.Text
        Dim C0 As String = VExpediente.ExpedienteTextboxC0.Text
        Dim CC As String = VExpediente.ExpedienteTextboxCC.Text
        Dim Aqx As String = VExpediente.ExpedienteTextboxAqx.Text
        Dim AfyAp As String = VExpediente.ExpedienteTextboxAfyAp.Text
        Dim AnP As String = VExpediente.ExpedienteTextboxAnP.Text


        If (cedula = "") Then
            MessageBox.Show(variablesGlobales.mensajeCedulaNulaExpediente, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            Return
        Else
            Try
                BD.ConectarBD()

                Dim modificado As Integer = 0

                modificado = BD.actualizarExpediente(cedula, fechaExpediente, G3, P3, A0, C0, CC, Aqx, AfyAp, AnP)

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

End Class
