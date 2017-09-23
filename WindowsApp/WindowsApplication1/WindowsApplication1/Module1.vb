Module Metodo
    Sub limpiarCampos(ByVal formulario As Form)
        Dim Text As Object

        For Each Text In formulario.Controls
            If TypeOf Text Is TextBox Then
                Dim txtTemp As TextBox = CType(Text, TextBox)
                txtTemp.Text = ""
            End If
        Next

    End Sub
End Module
