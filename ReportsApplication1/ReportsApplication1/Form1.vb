Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'datosDeSocio.SOCIOS' Puede moverla o quitarla según sea necesario.
        Me.SOCIOSTableAdapter.Fill(Me.datosDeSocio.SOCIOS)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load
        'TODO: esta línea de código carga datos en la tabla 'datosDeSocio.SOCIOS' Puede moverla o quitarla según sea necesario.
        Me.SOCIOSTableAdapter.Fill(Me.datosDeSocio.SOCIOS)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class
