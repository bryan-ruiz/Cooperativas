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
    Dim cuotaAdmision As CuotaAdmision = New CuotaAdmision
    Dim pacientes As Pacientes = New Pacientes

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.WindowState = FormWindowState.Maximized, Para maximizar la pantalla'
        Me.TextBoxSociosConsultarAsociado.Select()

        Me.Panel3.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.PacientesButtonAgregarPaciente.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.PacientesButtonModificar.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.PacientesButtonLimpiar.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.PacientesButtonAbrirExpediente.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.PacientesButtonBuscarXNombre.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)

        'cuotaAdmision.consultarCuotaAdmision()

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


    Private Sub ButtonAsociadosAgregar_Click(sender As Object, e As EventArgs) Handles PacientesButtonAgregarPaciente.Click
        pacientes.insertarPaciente()
    End Sub

    Private Sub ButtonSociosModificar_Click(sender As Object, e As EventArgs) Handles PacientesButtonModificar.Click
        pacientes.actualizar()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles PacientesButtonLimpiar.Click
        pacientes.limpiar()
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Principal.Show()
    End Sub

    Private Sub RegistroDeAsociadosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        VInformacionAnexoAsociados.Show()
    End Sub

    Private Sub RadioButtonSociosRetirado_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonSociosCerrado.CheckedChanged
        If RadioButtonSociosCerrado.Checked = True Then
            TextBoxSociosNotasCierre.Enabled = True
            DateTimeSociosFechaCierre.Enabled = True
            TextBoxSociosNotasCierre.Visible = True
            DateTimeSociosFechaCierre.Visible = True
            LabelNotasRetiro.Visible = True
            LabelFechaRetiro.Visible = True
        End If
    End Sub

    Private Sub RadioButtonSociosActivo_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonSociosActivo.CheckedChanged
        If RadioButtonSociosActivo.Checked = True Then
            TextBoxSociosNotasCierre.Enabled = False
            DateTimeSociosFechaCierre.Enabled = False
            TextBoxSociosNotasCierre.Visible = False
            DateTimeSociosFechaCierre.Visible = False
            LabelNotasRetiro.Visible = False
            LabelFechaRetiro.Visible = False
        End If
    End Sub

    Private Sub ImprimirReciboActualToolStripMenuItem_Click(sender As Object, e As EventArgs)
        socios.imprimirReciboActual()
    End Sub

    Private Sub AsociadosActivosResumidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsociadosActivosResumidoToolStripMenuItem.Click
        ' socios.generarReporteDeSociosResumido("Activos")
    End Sub

    Private Sub ToolStripMenuAsociadosReporteTodos_Click(sender As Object, e As EventArgs) Handles ToolStripMenuAsociadosReporteTodos.Click
        ' socios.generarReporteDeSociosResumidoTodos("Todos")
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ExcedentesPorAsociadoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        VExcedentesCorrespondientes.Show()
    End Sub

    Private Sub AsociadosPorSecciónToolStripMenuItem_Click(sender As Object, e As EventArgs)
        socios.reporteAsociadosXSeccion()
    End Sub

    Private Sub AbrirExpedienteToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'abrir expediente
    End Sub

    Private Sub PacientesButtonAbrirExpediente_Click(sender As Object, e As EventArgs) Handles PacientesButtonAbrirExpediente.Click
        'abrir expediente
        'VImagenes.Show()
        'VMotivoConsulta.Show()
        VExpediente.Show()

    End Sub

    Private Sub TextBoxSociosConsultarAsociado_TextChanged(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles TextBoxSociosConsultarAsociado.KeyPress
        'TextBoxSociosConsultarAsociado.PasswordChar = "*"
        If e.KeyChar = ChrW(Keys.Enter) Then
            Call ButtonAsociadosBuscar_Click(sender, e)
        End If
    End Sub

    'Valida que ingrese números en el campo de edad y que no ingrese más de 3 dígitos
    Private Sub TextBoxSociosEdad_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBoxSociosEdad.KeyPress
        Me.TextBoxSociosEdad.MaxLength = 3
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxSociosTelefonoTrabajo_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBoxSociosTelefonoTrabajo.KeyPress
        Me.TextBoxSociosTelefonoTrabajo.MaxLength = 4
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBoxSociosTelefonoTrabajo2_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TextBoxSociosTelefonoTrabajo2.KeyPress
        Me.TextBoxSociosTelefonoTrabajo2.MaxLength = 4
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub ButtonAsociadosBuscar_Click(sender As Object, e As EventArgs) Handles ButtonAsociadosBuscar.Click
        pacientes.consultarPaciente()
    End Sub

    Private Sub PacientesButtonBuscarXNombre_Click(sender As Object, e As EventArgs) Handles PacientesButtonBuscarXNombre.Click
        MsgBox("Funcionalidad no desarrollada, estado en Progreso")
    End Sub
End Class