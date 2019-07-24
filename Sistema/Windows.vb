Namespace Sistema

    Public Class Windows
#Region "ApagarSistema() , apaga el computador"
        Public Shared Sub ApagarSistema()
            Shell("shutdown -s -f -t 00")
        End Sub
#End Region

#Region "ReiniciarSistema() , reinicia el computador"
        Public Shared Sub ReiniciarSistema()

        End Sub
#End Region

#Region "CerrarSesion() , Cierra la sesion de usuario actual"
        Public Shared Sub CerrarSesion()

        End Sub
#End Region

    End Class

End Namespace
