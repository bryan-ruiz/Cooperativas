Public Class Asociados

    Dim BD As ConexionBD = New ConexionBD
    Dim socios As Socios = New Socios
    Dim comites As Comites = New Comites
    Dim usuarios As Usuarios = New Usuarios
    Dim ingreso As Ingreso = New Ingreso
    Dim gasto As Gastos = New Gastos
    Dim configuracion As Configuracion = New Configuracion
    Dim certificados As Certificados = New Certificados
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales
    Dim informeEconomico As InformeEconomico = New InformeEconomico

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.WindowState = FormWindowState.Maximized, Para maximizar la pantalla'
    End Sub

    Private Sub TextBoxSociosCedula_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBoxSociosCedula.KeyPress, TextBoxSociosCedula.TextChanged
        Me.TextBoxSociosCedula.MaxLength = 1
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxSociosCedula2_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBoxSociosCedula2.KeyPress, TextBoxSociosCedula2.TextChanged
        Me.TextBoxSociosCedula2.MaxLength = 1
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxSociosCedula3_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBoxSociosCedula3.KeyPress, TextBoxSociosCedula3.TextChanged
        Me.TextBoxSociosCedula3.MaxLength = 1
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    'CONSULTAR
    Private Sub ButtonAsociadosBuscar_Click(sender As Object, e As EventArgs) Handles ButtonAsociadosBuscar.Click
        socios.consultar()
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



    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonSociosRetirado.CheckedChanged
        If RadioButtonSociosRetirado.Checked = True Then
            TextBoxSociosNotasRetiro.Enabled = True
            DateTimeSociosFechaRetiro.Enabled = True
        End If
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Principal.Show()
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonSociosActivo.CheckedChanged
        If RadioButtonSociosActivo.Checked = True Then
            TextBoxSociosNotasRetiro.Enabled = False
            DateTimeSociosFechaRetiro.Enabled = False
        End If
    End Sub

    Private Sub RegistroDeAsociadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeAsociadosToolStripMenuItem.Click
        F_infogestionusuarios.Show()
    End Sub

    Private Sub ToolStripMenuAsociadosReporteActivos_Click(sender As Object, e As EventArgs) Handles ToolStripMenuAsociadosReporteActivos.Click
        socios.generarReporte("Activos")
        Print.Show()
    End Sub

    Private Sub ToolStripMenuAsociadosReporteTodos_Click(sender As Object, e As EventArgs) Handles ToolStripMenuAsociadosReporteTodos.Click
        socios.generarReporte("Todos")
        Print.Show()
    End Sub

End Class