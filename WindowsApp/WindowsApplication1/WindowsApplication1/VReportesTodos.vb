Public Class VReportesTodos

    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales
    Dim socios As Socios = New Socios
    Dim comites As Comites = New Comites
    Dim certificados As Certificados = New Certificados


    'LOAD 
    Private Sub VIngresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Panel1.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
    End Sub

    'ASOCIADOS
    Private Sub ReporteAsociadosActivosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteAsociadosActivosToolStripMenuItem.Click
        socios.generarReporteDeSociosResumido("Activos")
    End Sub

    Private Sub ReporteTodosLosAsociadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteTodosLosAsociadosToolStripMenuItem.Click
        socios.generarReporteDeSociosResumidoTodos("Todos")
    End Sub

    Private Sub ExcedentesPorAsociadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExcedentesPorAsociadoToolStripMenuItem.Click
        VExcedentesCorrespondientes.Show()
    End Sub

    Private Sub ReporteAsociadosPorSecciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteAsociadosPorSecciónToolStripMenuItem.Click
        socios.reporteAsociadosXSeccion()
    End Sub

    'CUERPOS DIRECTIVOS O COMITES
    Private Sub ReporteComitésToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteComitésToolStripMenuItem.Click
        comites.generarReporteDeComitesNuevo()
    End Sub

    Private Sub InformaciónDeCuerposDirectivosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformaciónDeCuerposDirectivosToolStripMenuItem.Click
        VInformacionCuerposDirectivos.Show()
    End Sub

    'CERTIFICADOS
    Private Sub ReporteMorosidadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteMorosidadToolStripMenuItem.Click
        VReporteMorosidad.Show()
    End Sub

    Private Sub ReportePagosAlDíaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportePagosAlDíaToolStripMenuItem.Click
        VReportePAagosAlDia.Show()
    End Sub

    Private Sub ReporteTodosLosPagosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteTodosLosPagosToolStripMenuItem.Click
        VReporteTodosLosPagos.Show()
    End Sub

    'ENTRADAS
    Private Sub ReporteEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteEntradasToolStripMenuItem.Click
        VIngresosReporte.Show()
    End Sub

    Private Sub ReporteSaldosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteSaldosToolStripMenuItem.Click
        VIngresosSaldos.Show()
    End Sub

    Private Sub ReporteInformeEconómicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteInformeEconómicoToolStripMenuItem.Click
        VInformeEconomico.Show()
    End Sub

    Private Sub ReporteTotalCuentaEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteTotalCuentaEntradasToolStripMenuItem.Click
        VReporteIngresoCuentas.Show()
    End Sub

    'SALIDAS
    Private Sub ReporteSalidasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteSalidasToolStripMenuItem.Click
        VGastosReporte.Show()
    End Sub

    Private Sub ReporteSaldosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ReporteSaldosToolStripMenuItem1.Click
        VIngresosSaldos.Show()
    End Sub

    Private Sub ReporteInformeEconómicoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ReporteInformeEconómicoToolStripMenuItem1.Click
        VInformeEconomico.Show()
    End Sub

    Private Sub ReporteTotalCodigosSalidasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteTotalCodigosSalidasToolStripMenuItem.Click
        VReporteGastoCuentas.Show()
    End Sub


End Class