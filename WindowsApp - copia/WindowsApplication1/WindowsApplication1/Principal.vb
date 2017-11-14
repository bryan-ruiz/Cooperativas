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

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
                    'Delete
                    BD.ConectarBD()
                    BD.borrarTablaAsociados()
                    BD.CerrarConexion()

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
                    MessageBox.Show("Datos importados con Éxito!", " ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Catch ex As Exception
                    MessageBox.Show("Error importando datos, favor verifique el formato del .xlsx en el Manual de Usuario", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

                    MessageBox.Show("Error causado debido a la excepción : " & vbCrLf & ex.Message)
                End Try

            End If

        End If

    End Sub
End Class