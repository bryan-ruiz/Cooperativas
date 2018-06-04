Public Class ExpedienteClase

    Public cedula As String
    Public fechaExpediente As DateTime
    Public G3 As String
    Public P3 As String
    Public A0 As String
    Public C0 As String
    Public CC As String
    Public Aqx As String
    Public AfyAp As String
    Public AnP As String

    Public Sub expedienteClaseConstructor(ByVal cedulap As String, ByVal fechaExpedientep As DateTime, ByVal G3p As String, ByVal P3p As String,
                                    ByVal A0p As String, ByVal C0p As String, ByVal CCp As String, ByVal Aqxp As String, ByVal AfyApp As String,
                                    ByVal AnPp As String)

        cedula = cedulap
        fechaExpediente = fechaExpedientep
        G3 = G3p
        P3 = P3p
        A0 = A0p
        C0 = C0p
        CC = CCp
        Aqx = Aqxp
        AfyAp = AfyApp
        AnP = AnPp

    End Sub

End Class
