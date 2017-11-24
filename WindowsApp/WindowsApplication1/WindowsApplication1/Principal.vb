﻿Imports System.Data.OleDb

Public Class Principal

    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales
    Dim BD As ConexionBD = New ConexionBD

    Private Sub GestionUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionUsuariosToolStripMenuItem.Click
        VAsociados.Show()
    End Sub

    Private Sub ComitésToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComitésToolStripMenuItem.Click
        VComites.Show()
    End Sub

    Private Sub CertificadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CertificadosToolStripMenuItem.Click
        VCertificados.Show()
    End Sub

    Private Sub IngresosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresosToolStripMenuItem.Click
        VIngresos.Show()
    End Sub

    Private Sub SalidasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalidasToolStripMenuItem.Click
        VGastos.Show()
    End Sub

    Private Sub FechasCertificadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FechasCertificadosToolStripMenuItem.Click
        VConfiguracionFechasLimite.Show()
    End Sub

    Private Sub CodigosDeCuentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CodigosDeCuentasToolStripMenuItem.Click
        VConfiguracionCodigoCuenta.Show()
    End Sub

    Private Sub PorcentajesReservasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PorcentajesReservasToolStripMenuItem.Click
        VConfiguracionPorcentajeReservas.Show()
    End Sub

    Private Sub InformaciónCooperativaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformaciónCooperativaToolStripMenuItem.Click
        VConfiguracionInformacionCooperativa.Show()
    End Sub

    Private Sub GestiónDeUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónDeUsuariosToolStripMenuItem.Click
        'VGestionAsociados.Show()
        MessageBox.Show("Contacte al Administrador, no se tiene licencia para ingresar usuarios nuevos al sistema")
    End Sub

    Private Sub Principal_Load(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyValue = Keys.F1 Or Keys.F2 Or Keys.F3 Or Keys.F4 Or Keys.F5 Or Keys.F6 Or Keys.F7 Or Keys.F8 Or Keys.F9 Or Keys.F10 Or Keys.F11 Or Keys.F12 Then
            FuncKeysModule(e.KeyValue)
            e.Handled = True
        End If

    End Sub

    'Function for F1, F2, etc pressed call
    Public Sub FuncKeysModule(ByVal value As Keys)
        Select Case value
            Case Keys.F1
                VAsociados.Show()
            Case Keys.F2
                VComites.Show()
            Case Keys.F3
                VCertificados.Show()
            Case Keys.F4
                VIngresos.Show()
            Case Keys.F5
                VGastos.Show()
        End Select
    End Sub

    '// Evento para salir del sistema, cierra todas ventanas abiertas
    Private Sub salirAPP(sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.Closing
        Dim result As DialogResult = MessageBox.Show("¿Desea salir del sistema?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If result = System.Windows.Forms.DialogResult.No Then
            e.Cancel = True
        Else
            Try
                'Cierra todas las ventanas abiertas
                Environment.Exit(1)
            Catch ex As InvalidOperationException
                'nothing
            End Try
        End If
    End Sub

    'Importa Asociados del excel a la BD del sistema
    Private Sub CargarUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarUsuariosToolStripMenuItem.Click
        Dim result As Integer = MessageBox.Show("¿Desea importar los Asociados del Excel a la base de datos del sistema?", "Importar Asociados", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            'nothing
        ElseIf result = DialogResult.Yes Then

            Dim Access As String = "C:\BD\CoopeBD.mdb"
            Dim Excel As String = "C:\BD\Libro1.xlsx"
            Dim connect As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Excel + ";Extended Properties=""Excel 12.0 Xml;HRD=NO"""

            If Singleton.rol = "Colaborador" Then
                MessageBox.Show(variablesGlobales.permisosDeAdminRequeridos)
            Else
                Try
                    'Abro Conexión
                    BD.ConectarBD()

                    'Borra tabla Asociados
                    BD.borrarTablaAsociados()
                    BD.CerrarConexion()

                    'Inserta del Excel a la tabla Socios
                    Using conn As New OleDbConnection(connect)
                        Using cmd As New OleDbCommand()
                            cmd.Connection = conn
                            cmd.CommandText = "INSERT INTO [MS Access;Database=" & Access & ";PWD=C454gr154].[SOCIOS] SELECT * FROM [Hoja1$]"

                            If conn.State = ConnectionState.Open Then
                                conn.Close()
                            End If
                            conn.Open()
                            cmd.ExecuteNonQuery()
                        End Using
                    End Using



                    BD.ConectarBD()
                    'Borra tabla Certificados
                    BD.borrarTablaCertificados()

                    'valores con datos de tipo objeto Socio
                    Dim valores As List(Of SocioClase)
                    valores = BD.obtenerDatosReporteDeSocios("todos")

                    Dim contador As Integer = 0

                    While contador < valores.Count
                        BD.insertarCertificadoXSocio(valores(contador).cedula.ToString, valores(contador).numAsoc.ToString, "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0")
                        contador = contador + 1
                    End While
                    BD.CerrarConexion()
                    'Cierro conexión


                    MessageBox.Show("Los datos de los Asociados fueron importados con Éxito!")

                Catch ex As Exception
                    MessageBox.Show("Error importando datos, favor verifique el formato del .xlsx en el Manual de Usuario", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                    MessageBox.Show("Error causado debido a la excepción : " & vbCrLf & ex.Message)
                End Try

            End If

        End If

    End Sub

    Private Sub AcercaDeSACToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeSACToolStripMenuItem.Click
        VAcercaDe.Show()
    End Sub

    Private Sub ConfiguraciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguraciónToolStripMenuItem.Click

    End Sub
End Class
