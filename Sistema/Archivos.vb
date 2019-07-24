
Imports System.IO

Namespace Sistema
    Public Class Archivos

#Region "GuardarArchivo() , guarda archivos en la direccion dada"
        Public Shared Sub GuardarArchivo(contenido As Object, nombreArchivo As String)

            System.IO.File.WriteAllText(nombreArchivo, contenido)

        End Sub
#End Region


        
#Region "CrearArchivo() , te crea un archivo .txt "

        Public Shared Sub CrearArchivo(nombreArchivo As String, contenido As String)

            Dim ruta As String = nombreArchivo
            File.Create(ruta).Dispose()
            File.WriteAllText(ruta, contenido)

        End Sub
#End Region

#Region "AbrirArchivo() , te permite Abrir Archivos .txt"
        Public Shared Function AbrirArchivo(nombreArchivo As String) As String

            Dim contenidoArchivo As String

            contenidoArchivo = File.ReadAllText(nombreArchivo)

            Return contenidoArchivo

        End Function
#End Region

#Region "ListarArchivos() te devuelve una lista de los archivos en la carpeta"
        Public Function ListarArchivos(nombreCarpeta As String) As List(Of String)

            Dim archivo As String
            Dim listaArchivos As New List(Of String)

            For Each archivo In My.Computer.FileSystem.GetFiles("C:\Universidad\" & nombreCarpeta)


                listaArchivos.Add(archivo)

            Next

            Return listaArchivos

        End Function
#End Region

    End Class
End Namespace
