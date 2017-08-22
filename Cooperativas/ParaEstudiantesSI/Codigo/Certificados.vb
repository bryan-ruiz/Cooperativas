Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class Certificados
    Dim BD As ConexionBD = New ConexionBD
    Dim estado As Boolean = True
    Dim encabezado As EncabezadoClase = New EncabezadoClase

    Public Sub consultar()

        Dim valores As List(Of String)
        Dim cedulaOnumAsociado As String = Ventana_Principal.CertificadosTextboxCedulaNumAsociado.Text

        If (cedulaOnumAsociado = "") Then
            MessageBox.Show("Debe ingresar la Cédula o el Número de asociado para consultar")
        Else
            Try
                BD.ConectarBD()
                valores = BD.consultarCertificadoXSocio(cedulaOnumAsociado)

                If valores.Count <> 0 Then
                    Ventana_Principal.CertificadosTextboxNombre.Text = valores(0)
                    Ventana_Principal.CertificadosTextboxPrimerApellido.Text = valores(1)
                    Ventana_Principal.CertificadosTextboxSegundoApellido.Text = valores(2)
                    Ventana_Principal.CertificadosTextboxTracto1.Text = valores(6)
                    Ventana_Principal.CertificadosTextboxTracto2.Text = valores(7)
                    Ventana_Principal.CertificadosTextboxTracto3.Text = valores(8)
                    Ventana_Principal.CertificadosTextboxTracto4.Text = valores(9)
                    Ventana_Principal.CertificadosTextboxTracto5.Text = valores(10)
                    Ventana_Principal.CertificadosTextboxTracto6.Text = valores(11)
                    Ventana_Principal.CertificadosTextboxTracto7.Text = valores(12)
                    Ventana_Principal.CertificadosTextboxTracto8.Text = valores(13)
                    Ventana_Principal.CertificadosTextboxTracto9.Text = valores(14)
                    Ventana_Principal.CertificadosTextboxTracto10.Text = valores(15)
                    Ventana_Principal.CertificadosTextboxAcumAnterior.Text = valores(16)
                    Ventana_Principal.CertificadosTextboxTotalPeriodo.Text = valores(17)

                Else
                    MessageBox.Show("El Socio no se encuentra registrado")
                    Ventana_Principal.CertificadosTextboxCedulaNumAsociado.Text = ""
                End If
                'Cierro conexion'
                BD.CerrarConexion()
            Catch ex As Exception
                MessageBox.Show("Error de: " + ex.ToString)
            End Try
        End If
    End Sub


End Class
