
Imports System.Xml
Imports System.Xml.XPath

Public Class Xpath

    '    ''' <summary>
    '    ''' Ejemplo:
    '    ''' C:\LUG\Alumno.XML
    '--------------------------------
    '/Alumnos/Alumno/Apellido
    '/Alumnos/Alumno[Numero >= 700]
    '/Alumnos/Alumno[position()=2]
    '/Alumnos/Alumno[last()]

    '/Alumnos/Alumno[Apellido="Lopez"]</summary>
  

    Public Function BuscarPorXpath(direccionXml As String, consultaXpath As String) As String
        Dim valorRetorno As String = " "

        Try

            Dim xDoc As New Xml.XPath.XPathDocument(direccionXml)
            Dim xNav As Xml.XPath.XPathNavigator = xDoc.CreateNavigator
            Dim xExpression As Xml.XPath.XPathExpression = xNav.Compile(consultaXpath)
            Dim xIterador As Xml.XPath.XPathNodeIterator = xNav.Select(xExpression)

            Try
                Do While xIterador.MoveNext

                    Dim cadenaInformacion As String = ""

                    If xIterador.Current.HasChildren Then

                        xIterador.Current.MoveToFirstChild()
                        cadenaInformacion += xIterador.Current.Name + ": " + xIterador.Current.Value + " ; "

                        Do While xIterador.Current.MoveToNext(Xml.XPath.XPathNodeType.Element)

                            cadenaInformacion += xIterador.Current.Name + ": " + xIterador.Current.Value + " ; "

                        Loop

                    End If
                    valorRetorno += cadenaInformacion

                Loop

            Catch ex1 As Exception

                MsgBox("Error en busqueda XPATH", MsgBoxStyle.Critical)

            End Try

        Catch ex2 As Exception

            MsgBox("No se encuentra el archivo ingresado", MsgBoxStyle.Critical)

        End Try


        Return valorRetorno

    End Function


End Class
