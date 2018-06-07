Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Data.OleDb

Public Class MotivoConsulta

    Dim BD As ConexionBD = New ConexionBD
    Dim encabezado As EncabezadoClase = New EncabezadoClase
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales

    'consulta un exp x cedula
    Public Sub consultarMotivoConsultaXCedula()

        Dim valores As List(Of MotivoConsultaClase)
        Dim paciente As List(Of PacienteClase)
        Dim cedulaAConsultar As String = VMotivoConsulta.MotivoConsultaTextboxConsultarCedula.Text

        If (cedulaAConsultar = "") Then
            MessageBox.Show(variablesGlobales.mensajeCedulaNula, " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
            limpiar()
        Else
            Try
                BD.ConectarBD()

                valores = BD.consultarMotivoConsultaXCedula(cedulaAConsultar)
                paciente = BD.consultarPacienteXCedula(cedulaAConsultar)
                If valores.Count <> 0 Then

                    VMotivoConsulta.MotivoConsultaTextboxCed.Text = valores(0).cedula
                    'VMotivoConsulta.MotivoConsultaDateTimeFecha.Value = Date.Parse(valores(0).fecha)
                    'VMotivoConsulta.MotivoConsultaTextboxValorConsulta.Text = valores(0).valor
                    'VMotivoConsulta.MotivoConsultaTextboxValorConsulta.Text = valores(0).motivo
                    'Para llenar nombre completo
                    VMotivoConsulta.MotivoConsultaTextboxNombreYApellidos.Text = paciente(0).nombre + " " + paciente(0).primerApellido + " " + paciente(0).segundoApellido
                    'Para cargar la info con la cedula en el ListView
                    VMotivoConsulta.Retrieve(VMotivoConsulta.MotivoConsultaTextboxCed.Text)
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

    Public Sub limpiar()
        'limpia el listview
        VMotivoConsulta.ListView1.Items.Clear()
        'limpia textfields
        VMotivoConsulta.MotivoConsultaTextboxCed.Text = ""
        VMotivoConsulta.MotivoConsultaTextboxNombreYApellidos.Text = ""
        VMotivoConsulta.MotivoConsultaTextboxConsultarCedula.Text = ""
        VMotivoConsulta.MotivoConsultaTextboxValorConsulta.Text = ""
        VMotivoConsulta.MotivoConsultaTextboxMotivoConsulta.Text = ""
    End Sub




End Class
