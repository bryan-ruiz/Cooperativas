Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class Expedientes

    Dim BD As ConexionBD = New ConexionBD
    Dim encabezado As EncabezadoClase = New EncabezadoClase
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales
    Dim informeEconomico As InformeEconomico = New InformeEconomico

    'consulta un asociado
    Public Sub consultarExpedienteDelPaciente()

        Dim valores As List(Of ExpedienteClase)

        Dim consultarAsociado As String = VExpediente.ExpedienteTextboxConsultarCedula.Text

        If (consultarAsociado = "") Then
            MessageBox.Show(variablesGlobales.mensajeCedulaNula, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            limpiar()
        Else
            Try
                BD.ConectarBD()

                valores = BD.consultarExpedienteXCedula(consultarAsociado)

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

End Class
