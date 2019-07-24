Imports System.Text.RegularExpressions


Namespace ExpresionesRegular

    Public Class ValidarStringRegex

        Public Shared Sub ValidarCadena(cadenaDeTexto As String)

            Dim respuesta As Boolean

            respuesta = Regex.IsMatch(cadenaDeTexto, "^([a-zA-Z]{4,})$")

            If Not respuesta Then

                Throw New Exception

            End If

        End Sub

        Public Shared Sub CadenaSoloNumero(cadenaDeTexto As String)

            Dim respuesta As Boolean

            respuesta = Regex.IsMatch(cadenaDeTexto, "^[0-9]+$")

            If Not respuesta Then

                Throw New Exception

            End If

        End Sub

        Public Shared Sub CadenaSoloLetras(cadenaDeTexto As String)

            Dim respuesta As Boolean

            respuesta = Regex.IsMatch(cadenaDeTexto, "^[a-zA-Z]+$")

            If Not respuesta Then

                Throw New Exception

            End If

        End Sub


        Public Shared Sub CantidadCaracteres(cadena As String, minimo As Integer, maximo As Integer)

            Dim r As Boolean

            r = Regex.IsMatch(cadena, "\d{" & minimo.ToString & "," & maximo.ToString & "}")

            If Not r Then
                Throw New Exception
            End If
        End Sub

        Public Shared Sub CantidadCaracteres(cadena As String, minimo As Integer)
            Dim r As Boolean

            r = Regex.IsMatch(cadena, "\d{" & minimo.ToString & ",}")

            If Not r Then
                Throw New Exception
            End If
        End Sub

    End Class

End Namespace