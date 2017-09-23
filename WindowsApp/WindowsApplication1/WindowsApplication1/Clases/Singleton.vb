Public Class Singleton

    Public Shared usuario As String
    Public Shared contrasena As String
    Public Shared rol As String
    Public Shared permisos As String

    Private Sub New()
    End Sub

    Public Shared ReadOnly Property Instance() As Singleton
        Get
            Static INST As Singleton = New Singleton
            Return INST
        End Get
    End Property

    Public Sub llenarConInformacion(ByVal usuarioP As String, ByVal contrasenaP As String, ByVal rolP As String, ByVal permisosP As String)
        usuario = usuarioP
        contrasena = contrasenaP
        rol = rolP
        permisos = permisosP
    End Sub
End Class
