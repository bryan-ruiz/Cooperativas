Public Class validacionesGlobales

    Dim variablesGlobales As MensajesGlobales = New MensajesGlobales

    Sub datosEnReporte(ByVal cantidadDeDatos As Integer)
        If cantidadDeDatos = 0 Then
            MessageBox.Show(variablesGlobales.reporteSinDatos, "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
        End If
    End Sub

End Class
