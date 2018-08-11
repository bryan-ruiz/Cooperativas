Public Class ConfiguracionClase

    Public periodo As String
    Public cooperativa As String
    Public cedulaJuridica As String
    Public telefono As String
    Public fechaLimite1 As DateTime
    Public fechaLimite2 As DateTime
    Public fechaLimite3 As DateTime
    Public fechaLimite4 As DateTime
    Public fechaLimite5 As DateTime
    Public fechaLimite6 As DateTime
    Public fechaLimite7 As DateTime
    Public fechaLimite8 As DateTime
    Public fechaLimite9 As DateTime
    Public fechaLimite10 As DateTime
    Public legal As String
    Public educacion As String
    Public bienestarSocial As String
    Public institucional As String
    Public patrimonial As String
    Public montoMaxPeriodo As Integer
    Public montoMaxTracto As Integer

    Public Sub configuracionClaseCostructor(ByVal periodop As String, ByVal cooperativap As String, ByVal cedulaJuridicap As String,
                                            ByVal telefonop As String, ByVal fechaLimite1p As DateTime, ByVal fechaLimite2p As DateTime,
                                            ByVal fechaLimite3p As DateTime, ByVal fechaLimite4p As DateTime,
                                            ByVal fechaLimite5p As DateTime, ByVal fechaLimite6p As DateTime,
                                            ByVal fechaLimite7p As DateTime, ByVal fechaLimite8p As DateTime,
                                            ByVal fechaLimite9p As DateTime, ByVal fechaLimite10p As DateTime,
                                            ByVal legalp As String, ByVal educacionp As String, ByVal bienestarSocialp As String,
                                            ByVal institucionalp As String, ByVal patrimonialp As String,
                                            ByVal montoMaxPeriodoP As Integer, ByVal montoMaxTractoP As Integer)
        periodo = periodop
        cooperativa = cooperativap
        cedulaJuridica = cedulaJuridicap
        telefono = telefonop
        fechaLimite1 = fechaLimite1p
        fechaLimite2 = fechaLimite2p
        fechaLimite3 = fechaLimite3p
        fechaLimite4 = fechaLimite4p
        fechaLimite5 = fechaLimite5p
        fechaLimite6 = fechaLimite6p
        fechaLimite7 = fechaLimite7p
        fechaLimite8 = fechaLimite8p
        fechaLimite9 = fechaLimite9p
        fechaLimite10 = fechaLimite10p
        legal = legalp
        educacion = educacionp
        bienestarSocial = bienestarSocialp
        institucional = institucionalp
        patrimonial = patrimonialp
        montoMaxPeriodo = montoMaxPeriodoP
        montoMaxTracto = montoMaxTractoP
    End Sub

End Class
