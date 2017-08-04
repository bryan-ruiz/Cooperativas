Imports Cooperativas.Socios


Public Class Ventana_Principal

    Dim BD As ConexionBD = New ConexionBD
    Dim socios As Socios = New Socios
    Dim comites As Comites = New Comites

    '//////////////////////////
    '///////  SOCIOS //////////
    '//////////////////////////


    'Consultar Socios por Cedula
    Private Sub ButtonSociosConsultar_Click(sender As Object, e As EventArgs) Handles ButtonSociosConsultar.Click
        socios.consultar()
    End Sub

    'Insertar Socios
    Private Sub ButtonSociosInsertar_Click(sender As Object, e As EventArgs) Handles ButtonSociosInsertar.Click
        socios.insertar()
    End Sub

    'Actualizar Socios
    Private Sub ButtonSociosModificar_Click(sender As Object, e As EventArgs) Handles ButtonSociosModificar.Click
        socios.actualizar()
    End Sub

    'Reporte de Socios (Activos o activos más inactivos)
    Private Sub ButtonSociosReporteDeSocios_Click(sender As Object, e As EventArgs) Handles ButtonSociosReporteDeSocios.Click
        socios.generarReporteDeSocios()
        Print.Show()
    End Sub

    'Salir de la app
    Private Sub ButtonSociosSalir_Click(sender As Object, e As EventArgs) Handles ButtonSociosSalir.Click
        Me.Close()
        Ventana_Acceso.Close()
    End Sub

    'Radio socio retirado
    Private Sub RadioButtonSociosRetirado_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonSociosRetirado.CheckedChanged
        mostrarOcultarCamposRetiro(True)
    End Sub

    'Radio socio activo
    Private Sub RadioButtonSociosActivo_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonSociosActivo.CheckedChanged
        mostrarOcultarCamposRetiro(False)
    End Sub

    'Muestra u oculta los campos de retiro 
    Private Sub mostrarOcultarCamposRetiro(ByVal value As Boolean)
        Me.TextBoxSociosNotasRetiro.Visible = value
        Me.DateTimeSociosFechaRetiro.Visible = value
        Me.LabelSociosFechaRetiro.Visible = value
        Me.LabelSociosNotasRetiro.Visible = value
    End Sub

    Private Sub TextBox34_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonSociosReporte_Click(sender As Object, e As EventArgs) Handles ButtonSociosReporte.Click

    End Sub

    Private Sub ButtonConsultarSocio_Click(sender As Object, e As EventArgs) Handles ButtonConsultarSocio.Click

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub RadioButtonSociosReporteTodos_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonSociosReporteTodos.CheckedChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Ventana_Acceso.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonBuscar_asociadoPresidente.Click
        comites.buscar("presidente")
    End Sub

    Private Sub ButtonBuscar_asociadoVicePresidente_Click(sender As Object, e As EventArgs) Handles ButtonBuscar_asociadoVicePresidente.Click
        comites.buscar("vicePresidente")
    End Sub

    Private Sub ButtonBuscar_asociadoSecretaria_Click(sender As Object, e As EventArgs) Handles ButtonBuscar_asociadoSecretaria.Click
        comites.buscar("secretaria")
    End Sub

    Private Sub ButtonBuscar_asociadoVocal1_Click(sender As Object, e As EventArgs) Handles ButtonBuscar_asociadoVocal1.Click
        comites.buscar("vocal1")
    End Sub

    Private Sub ButtonBuscar_asociadoVocal2_Click(sender As Object, e As EventArgs) Handles ButtonBuscar_asociadoVocal2.Click
        comites.buscar("vocal2")
    End Sub

    Private Sub ButtonBuscar_asociadoSuplente1_Click(sender As Object, e As EventArgs) Handles ButtonBuscar_asociadoSuplente1.Click
        comites.buscar("suplente1")
    End Sub

    Private Sub ButtonBuscar_asociadoSuplente2_Click(sender As Object, e As EventArgs) Handles ButtonBuscar_asociadoSuplente2.Click
        comites.buscar("suplente2")
    End Sub

    Private Sub ButtonConsultar_InformacionAccidente_Click(sender As Object, e As EventArgs) Handles ButtonConsultar_InformacionAccidente.Click
        comites.limpiar()
        comites.consultar()
    End Sub

    Private Sub ButtonSociosLimpiar_Click(sender As Object, e As EventArgs) Handles ButtonSociosLimpiar.Click
        socios.limpiar()
    End Sub

    Private Sub ButtonModificar_InformacionAccidente_Click(sender As Object, e As EventArgs) Handles ButtonModificar_InformacionAccidente.Click
        comites.actualizarComiteF()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        comites.generarReporteDeComites()
        Print.Show()
    End Sub
End Class


