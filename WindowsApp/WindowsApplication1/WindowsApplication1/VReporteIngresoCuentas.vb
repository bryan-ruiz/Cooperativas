Public Class VReporteIngresoCuentas
    Dim ingreso As Ingreso = New Ingreso
    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales
    Private Sub VIngresosReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Panel1.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
        Me.Button_IngresoCuentasReporte_aceptar.BackColor = ColorTranslator.FromHtml(variablesGlobales.colorDisenoCeleste)
    End Sub

    Private Sub Button_IngresoCuentasReporte_aceptar_Click(sender As Object, e As EventArgs) Handles Button_IngresoCuentasReporte_aceptar.Click
        ingreso.generarReporteCuentaIngresos()
        Print.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub DateTimePicker_IngresoCuentasReporte_ff_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker_IngresoCuentasReporte_ff.ValueChanged

    End Sub

    Private Sub DateTimePicker_IngresoCuentasReporte_fi_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker_IngresoCuentasReporte_fi.ValueChanged

    End Sub
End Class