Imports System.Data.OleDb

Public Class Principal

    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales
    Dim BD As ConexionBD = New ConexionBD

    Private Sub GestionUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionUsuariosToolStripMenuItem.Click
        VAsociados.Show()
    End Sub


    Private Sub CertificadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CertificadosToolStripMenuItem.Click
        VCertificados.Show()
    End Sub

    Private Sub IngresosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresosToolStripMenuItem.Click
        VMotivoConsulta.Show()
    End Sub

    Private Sub SalidasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        VGastos.Show()
    End Sub

    Private Sub FechasCertificadosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'VConfiguracionFechasLimite.Show()
    End Sub

    Private Sub CodigosDeCuentasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If Singleton.rol = "Colaborador" Then
            MessageBox.Show(variablesGlobales.permisosDeAdminRequeridos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return
        End If

        'si es admin o super admin puede ver la ventana
        VConfiguracionCodigoCuenta.Show()
    End Sub


    Private Sub PorcentajesReservasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If Singleton.rol = "Colaborador" Then
            MessageBox.Show(variablesGlobales.permisosDeAdminRequeridos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return
        End If

        'si es admin o super admin puede ver la ventana
        VConfiguracionPorcentajeReservas.Show()
    End Sub

    Private Sub InformaciónCooperativaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformaciónCooperativaToolStripMenuItem.Click
        If Singleton.rol = "Colaborador" Then
            MessageBox.Show(variablesGlobales.permisosDeAdminRequeridos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return
        End If

        'si es admin o super admin puede ver la ventana
        VConfiguracionInformacionCooperativa.Show()

    End Sub

    Private Sub GestiónDeUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'VGestionAsociados.Show()
        'MessageBox.Show("Contacte al Administrador, no se tiene licencia para ingresar usuarios nuevos al sistema")
    End Sub

    ''Private Sub Principal_Load(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown, MyBase.Load
    ''If e.KeyValue = Keys.F1 Or Keys.F2 Or Keys.F3 Or Keys.F4 Or Keys.F5 Or Keys.F6 Or Keys.F7 Or Keys.F8 Or Keys.F9 Or Keys.F10 Or Keys.F11 Or Keys.F12 Then
    ''      FuncKeysModule(e.KeyValue)
    ''    e.Handled = True
    ''End If
    ''End Sub

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
    Private Sub CargarUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If Singleton.rol = "Admin" Then
            MessageBox.Show(variablesGlobales.permisosDeSuperAdminRequeridos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return
        End If

        If Singleton.rol = "Colaborador" Then
            MessageBox.Show(variablesGlobales.permisosDeSuperAdminRequeridos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return
        End If


        Dim result As Integer = MessageBox.Show("¿Desea importar los Asociados del Excel a la base de datos del sistema?", "Importar Asociados", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            'nothing
        ElseIf result = DialogResult.Yes Then

            Dim Access As String = "C:\BD\CoopeBD.mdb"
            Dim Excel As String = "C:\BD\Asociados.xlsx"
            Dim connect As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Excel + ";Extended Properties=""Excel 12.0 Xml;HRD=NO"""
            Dim todaysdate As String = String.Format("{0:dd/MM/yyyy}", DateTime.Now)

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



                'Abro Conexión
                BD.ConectarBD()


                'valores con datos de tipo objeto Socio
                Dim valores As List(Of SocioClase)
                valores = BD.obtenerDatosReporteDeSocios("todos")

                Dim contador As Integer = 0

                While contador < valores.Count
                    BD.insertarCertificadoXSocio(valores(contador).cedula.ToString, valores(contador).numAsoc.ToString, "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", todaysdate,
                                                     todaysdate, todaysdate, todaysdate, todaysdate, todaysdate, todaysdate, todaysdate, todaysdate, todaysdate)
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



    End Sub

    Private Sub AcercaDeSACToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeSACToolStripMenuItem.Click
        VAcercaDe.Show()
    End Sub

    Private Sub ConfiguraciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguraciónToolStripMenuItem.Click

    End Sub

    Private Sub SumarTotalDeCertificadosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'VSumarCertificados.Show()
    End Sub

    Private Sub MontoMáximoEnCertificadosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'VMontoCertificados.Show()
    End Sub

    'Importa Acumulado del Excel a la BD del sistema
    Private Sub ImportarAcumuladoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If Singleton.rol = "Admin" Then
            MessageBox.Show(variablesGlobales.permisosDeSuperAdminRequeridos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return
        End If

        If Singleton.rol = "Colaborador" Then
            MessageBox.Show(variablesGlobales.permisosDeSuperAdminRequeridos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return
        End If


        MessageBox.Show("NOTA: Deben existir Asociados en el Sistema, favor crear o importar Asociados antes de realizar esta acción.", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)

        Dim result As Integer = MessageBox.Show("¿Desea importar los Acumulados por Asociado del Excel a la base de datos del sistema?", "Importar Acumulado", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            'nothing
        ElseIf result = DialogResult.Yes Then

            Dim baseDatos As String = "C:\BD\CoopeBD.mdb"
            Dim Excel As String = "C:\BD\Acumulado.xlsx"
            Dim connect As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Excel + ";Extended Properties=""Excel 12.0 Xml;HRD=NO"""

            Try
                'Abro Conexión
                BD.ConectarBD()

                'Borra tabla acum - la que contiene ced, nombre y acum por asociado
                BD.borrarTablaAcumulado()
                BD.CerrarConexion()

                'Inserta del Excel a la tabla Acumulado
                Using conn As New OleDbConnection(connect)
                    Using cmd As New OleDbCommand()
                        cmd.Connection = conn
                        cmd.CommandText = "INSERT INTO [MS Access;Database=" & baseDatos & ";PWD=C454gr154].[ACUMULADO] SELECT * FROM [Hoja1$]"
                        If conn.State = ConnectionState.Open Then
                            conn.Close()
                        End If
                        conn.Open()
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                BD.ConectarBD()
                Dim valores As List(Of AcumuladoClase)
                valores = BD.obtenerDatosAcumuladoXAsociado()
                Dim contador As Integer = 0
                While contador < valores.Count
                    BD.actualizarDatosAcumuladoXAsociado(valores(contador).cedula.ToString, valores(contador).acumuladoAnterior.ToString)
                    contador = contador + 1
                End While
                BD.CerrarConexion()
                'Cierro conexión


                MessageBox.Show("Los datos de los Acumulados fueron importados con Éxito!")

            Catch ex As Exception
                MessageBox.Show("Error importando datos, favor verifique el formato del .xlsx en el Manual de Usuario", " ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                MessageBox.Show("Error causado debido a la excepción : " & vbCrLf & ex.Message)
            End Try

        End If

    End Sub

    Private Sub CerrarPeriodoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If Singleton.rol = "Colaborador" Then
            MessageBox.Show(variablesGlobales.permisosDeAdminRequeridos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return
        End If

        'si es admin o super admin puede ver la ventana
        VResrvasPrincipal.Show()
    End Sub

    Private Sub ExcedentesMoverAReservasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If Singleton.rol = "Colaborador" Then
            MessageBox.Show(variablesGlobales.permisosDeAdminRequeridos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return
        End If

        'si es admin o super admin puede ver la ventana
        VGestionDeExcedentes.Show()
    End Sub

    Private Sub CertificadosEnTránsitoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If Singleton.rol = "Colaborador" Then
            MessageBox.Show(variablesGlobales.permisosDeAdminRequeridos, " ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return
        End If

        'si es admin o super admin puede ver la ventana
        VGestionDeCertificados.Show()
    End Sub

    Private Sub ToolStripMenuItemReservas_Click(sender As Object, e As EventArgs)
        VGestionDeReservas.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        VConfiguracionCuotaAdmision.Show()
    End Sub

    Private Sub ReportesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        VReportesTodos.Show()
    End Sub

    Private Sub ExpedientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExpedientesToolStripMenuItem.Click
        VExpediente.Show()
    End Sub
End Class
