Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports Framework.Lipshitz.Funciones



'''<summary>
'''This is a test class for ConvertidoresTest and is intended
'''to contain all ConvertidoresTest Unit Tests
'''</summary>
<TestClass()> _
Public Class ConvertidoresTest

    '''<summary>
    '''A test for ObjetoABooleano
    '''</summary>
    <TestMethod()> _
    Public Sub ObjetoABooleanoTest()
        Dim valor1 As Object = "si"
        Dim expected As Boolean = True
        Dim actual As Boolean
        actual = Convertidores.ObjetoABooleano(valor1)
        Assert.AreEqual(expected, actual)
    End Sub


  



    '''<summary>
    '''A test for CeroALaIzquierda
    '''</summary>
    <TestMethod()> _
    Public Sub CeroALaIzquierdaTest()
        Dim Numero As String = 234
        Dim Caracteres As String = 6
        Dim expected As String = "000234"
        Dim actual As String
        actual = Convertidores.CeroALaIzquierda(Numero, Caracteres)
        Assert.AreEqual(expected, actual)
    End Sub
End Class
