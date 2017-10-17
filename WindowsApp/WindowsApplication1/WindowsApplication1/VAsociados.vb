Public Class VAsociados

    Dim BD As ConexionBD = New ConexionBD
    Dim socios As Socios = New Socios
    Dim comites As VComites = New VComites
    Dim usuarios As Usuarios = New Usuarios
    Dim ingreso As Ingreso = New Ingreso
    Dim gasto As Gastos = New Gastos
    Dim configuracion As Configuracion = New Configuracion
    Dim certificados As Certificados = New Certificados
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales
    Dim informeEconomico As InformeEconomico = New InformeEconomico

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.WindowState = FormWindowState.Maximized, Para maximizar la pantalla'
        Me.TextBoxSociosConsultarAsociado.Select()
    End Sub

    Private Sub TextBoxSociosCedula_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBoxSociosCedula.KeyPress
        Me.TextBoxSociosCedula.MaxLength = 1
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxSociosCedula2_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBoxSociosCedula2.KeyPress
        Me.TextBoxSociosCedula2.MaxLength = 4
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxSociosCedula3_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBoxSociosCedula3.KeyPress
        Me.TextBoxSociosCedula3.MaxLength = 4
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxSociosNumAsociado_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBoxSociosNumAsociado.KeyPress
        Me.TextBoxSociosNumAsociado.MaxLength = 15
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxSociosTelefono_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBoxSociosTelefono.KeyPress
        Me.TextBoxSociosTelefono.MaxLength = 4
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxSociosTelefono2_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBoxSociosTelefono2.KeyPress
        Me.TextBoxSociosTelefono2.MaxLength = 4
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub TextBoxSociosSeccion_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBoxSociosSeccion.KeyPress
        Me.TextBoxSociosSeccion.MaxLength = 2
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxSociosSeccion2_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBoxSociosSeccion2.KeyPress
        Me.TextBoxSociosSeccion2.MaxLength = 2
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxSociosCuotaMatricula_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBoxSociosCuotaMatricula.KeyPress
        Me.TextBoxSociosCuotaMatricula.MaxLength = 15
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    'CONSULTAR
    Private Sub ButtonAsociadosBuscar_Click(sender As Object, e As EventArgs) Handles ButtonAsociadosBuscar.Click
        socios.consultarAsociado()
    End Sub

    Private Sub ButtonAsociadosAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAsociadosAgregar.Click
        socios.insertar()
    End Sub

    Private Sub ButtonSociosModificar_Click(sender As Object, e As EventArgs) Handles ButtonSociosModificar.Click
        socios.actualizar()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles SociosButtonLimpiar.Click
        socios.limpiar()
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Principal.Show()
    End Sub

    Private Sub RegistroDeAsociadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeAsociadosToolStripMenuItem.Click
        VInformacionAnexoAsociados.Show()
    End Sub

    Private Sub ToolStripMenuAsociadosReporteActivos_Click(sender As Object, e As EventArgs) Handles ToolStripMenuAsociadosReporteActivos.Click
        socios.generarReporte("Activos")
        Print.Show()
    End Sub

    Private Sub ToolStripMenuAsociadosReporteTodos_Click(sender As Object, e As EventArgs) Handles ToolStripMenuAsociadosReporteTodos.Click
        socios.generarReporte("Todos")
        Print.Show()
    End Sub

    Private Sub RadioButtonSociosRetirado_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonSociosRetirado.CheckedChanged
        If RadioButtonSociosRetirado.Checked = True Then
            TextBoxSociosNotasRetiro.Enabled = True
            DateTimeSociosFechaRetiro.Enabled = True
            TextBoxSociosNotasRetiro.Visible = True
            DateTimeSociosFechaRetiro.Visible = True
            LabelNotasRetiro.Visible = True
            LabelFechaRetiro.Visible = True
        End If
    End Sub

    Private Sub RadioButtonSociosActivo_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonSociosActivo.CheckedChanged
        If RadioButtonSociosActivo.Checked = True Then
            TextBoxSociosNotasRetiro.Enabled = False
            DateTimeSociosFechaRetiro.Enabled = False
            TextBoxSociosNotasRetiro.Visible = False
            DateTimeSociosFechaRetiro.Visible = False
            LabelNotasRetiro.Visible = False
            LabelFechaRetiro.Visible = False
        End If
    End Sub

    Private Sub ImprimirReciboActualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirReciboActualToolStripMenuItem.Click
        socios.imprimirReciboActual()

    End Sub
End Class