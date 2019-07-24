Namespace Funciones
  
    Public Class Convertidores

#Region "CeroIzquierda() , devuelve un texto con 6 ceros en la izquiera"
        Public Shared Function CeroIzquierda(Valor As Integer) As String
            Return String.Format("000000" & Valor)
        End Function
#End Region

#Region "Booleano(), devuelve si el es booleano es falso o verdadero"
        Public Shared Function Booleano(texto As Boolean) As String

            If texto Then
                Return "Yes"
            Else
                Return "No"
            End If

        End Function
#End Region
      
    End Class
End Namespace
