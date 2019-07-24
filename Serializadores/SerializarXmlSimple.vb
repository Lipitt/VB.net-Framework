Imports System.Xml
Imports System.Text
Imports FrameworkLipshitz.Serializadores

Namespace Serializadores

End Namespace
Public Class SerializarXmlSimple
    Implements ISerializador
    Dim documentoXml As XmlWriter


    Public Function Deserealizar(Of T As New)(unObejtoSerializado As String) As List(Of T) Implements ISerializador.Deserealizar
        '1 crear una instancia del resultado
        Dim resultado As New List(Of T)

        '2 parsear el xml 

        Dim xdoc = XDocument.Parse(unObejtoSerializado)

        '3 foreach del todo xml
        Dim nodoRaiz As XElement = xdoc.LastNode

        For Each nodo As XElement In nodoRaiz.Nodes()

            For Each elementosDelNodo As XElement In nodo.Nodes()


                Dim nombreProperty As String = nodo.Name.ToString()
                Dim valorProperty As Object = nodo.Value

                'version pachu
                'Dim nombreProperty As String = elementosDelNodo.Name.ToString
                'Dim valorProperty As Object = elementosDelNodo.Value

                '4 reflection por cada elemento 
                Dim unObjetoMapeado As New T
                Dim pp = unObjetoMapeado.GetType.GetProperty(nombreProperty)
                '5 mapear el elemento hacia la property

                pp.SetValue(unObjetoMapeado, valorProperty)

                resultado.Add(unObjetoMapeado)
            Next
        Next

        Return resultado
        'return del resultado
    End Function

    Public Function Serializar(unObjeto As List(Of Object)) As String Implements ISerializador.Serializar

        Dim configuracionXml As New XmlWriterSettings()
        configuracionXml.Indent = 2



        Dim sb As New StringBuilder

        documentoXml = XmlWriter.Create(sb, configuracionXml)
        documentoXml.WriteStartDocument(True)

        documentoXml.WriteStartElement(unObjeto.First.GetType.Name.ToString + "s")

        For Each item In unObjeto

            documentoXml.WriteStartElement(item.GetType().Name)

            For Each pi In item.GetType().GetProperties()

                documentoXml.WriteElementString(pi.Name, pi.GetValue(item))

            Next

            documentoXml.WriteEndElement()

        Next

        documentoXml.WriteEndDocument()
        documentoXml.Close()

        Return sb.ToString()

    End Function



    'Public Function Serializar(unObjeto As List(Of Object)) As String Implements ISerializador.Serializar

    '    Dim configuracionXml As New XmlWriterSettings()
    '    configuracionXml.Indent = 2

    '    Dim documentoXml As XmlWriter

    '    Dim sb As New StringBuilder

    '    documentoXml = XmlWriter.Create(sb)
    '    documentoXml.WriteStartDocument(True)

    '    documentoXml.WriteStartElement("ListOf" + unObjeto.First().GetType().Name)

    '    For Each item In unObjeto

    '        documentoXml.WriteStartElement(item.GetType().Name)

    '        For Each pi In item.GetType().GetProperties()

    '            documentoXml.WriteElementString(pi.Name, pi.GetValue(item))

    '        Next

    '        documentoXml.WriteEndElement()

    '    Next

    '    documentoXml.WriteEndDocument()
    '    documentoXml.Close()

    '    Return sb.ToString()

    'End Function
End Class

