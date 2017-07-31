Imports Cooperativas.Socios


Public Class Ventana_Principal

    Dim BD As ConexionBD = New ConexionBD
    Dim socios As Socios = New Socios


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
End Class


