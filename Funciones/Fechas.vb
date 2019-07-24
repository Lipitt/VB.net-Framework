Namespace Funciones
 
    Public Class Fechas

#Region "FechaHoy(), devuelve la fecha de hoy"
        Public Shared Function FechaHoy() As DateTime
            Return Date.Today()
        End Function
#End Region
        
#Region "HoraFecha(), devulve la fecha y la hora de ahora"
        Public Shared Function HoraFecha() As DateTime
            Return Date.Now()
        End Function

        'Public Function TraerFacultades() As List(Of Facultad)

        '    'Algo... que conecte,traiga..convierta en dto y devuelva al formulario

        '    Dim unaConexion As New ConexionSqlServer()

        '    unaConexion.ConexionIniciar("CARP-PC\SQLEXPRESS", "PreParcial")

        '    Dim resultado = unaConexion.EjecutarTupla(Of Facultad)("Select * from Facultad", New Dictionary(Of String, Object))

        '    unaConexion.ConexionFinalizar()

        '    Return resultado
        'End Function
#End Region

    End Class
End Namespace
