Imports System

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports Framework.Lipshitz
Imports Framework.Lipshitz.Sistema


'''<summary>
'''Se trata de una clase de prueba para ArchivosTest y se pretende que
'''contenga todas las pruebas unitarias ArchivosTest.
'''</summary>
<TestClass()> _
Public Class ArchivosTest
    <TestMethod()> _
    Public Sub LeerEnASCIITest()
        Dim ValorEsperado As String = "Hola."
        Dim Path As String = "D:\Mis Documentos\test.txt"
        Dim ValorActual As String = Framework.Lipshitz.Sistema.Archivos.LeerEnASCII(Path)
        Assert.AreEqual(ValorActual, ValorEsperado)
    End Sub





 

    '''<summary>
    '''A test for ListarAchivos
    '''</summary>
    <TestMethod()> _
    Public Sub ListarAchivosTest()
        Dim RutaCarpeta As String = "C:\Users\Lip\Desktop\Carpetatest"
        Dim expected As Object = "C:\Users\Lip\Desktop\Carpetatest\siche2.txt"
        Dim actual As Object
        actual = Archivos.ListarAchivos(RutaCarpeta)
        Assert.AreEqual(expected, actual)

    End Sub

    '''<summary>
    '''A test for ObtenerFechaCreacion
    '''</summary>
    <TestMethod()> _
    Public Sub ObtenerFechaCreacionTest()
        Dim Ruta As String = "C:\Users\Lip\Desktop\framework.txt"
        Dim expected As String = "23/06/2013 ‏12:26:43"
        Dim actual As String
        actual = Archivos.ObtenerFechaCreacion(Ruta)
        Assert.AreEqual(expected, actual)

    End Sub

    '''<summary>
    '''A test for ObtenerPeso
    '''</summary>
    <TestMethod()> _
    Public Sub ObtenerPesoTest()
        Dim Ruta As String = "C:\Users\Lip\Desktop\framework.txt"
        Dim expected As String = "0,509765625"
        Dim actual As String
        actual = Archivos.ObtenerPeso(Ruta)
        Assert.AreEqual(expected, actual)
    End Sub
End Class
