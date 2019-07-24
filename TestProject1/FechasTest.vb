Imports System

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports Framework.Lipshitz.Funciones




'''<summary>
'''This is a test class for FechasTest and is intended
'''to contain all FechasTest Unit Tests
'''</summary>
<TestClass()> _
Public Class FechasTest


    <TestMethod()> _
    Public Sub HoyTest()
        Dim ValorEsperado As String
        Dim ValorActual As String
        ValorActual = "18/12/2013"
        ValorEsperado = Fechas.Hoy
        Assert.AreEqual(ValorEsperado, ValorActual)

    End Sub

    '''<summary>
    '''A test for Ahora
    '''</summary>
    <TestMethod()> _
    Public Sub AhoraTest()
        Dim expected As System.DateTime = "30/06/2013 20:46:45"
        Dim actual As Date
        actual = Fechas.Ahora
        Assert.AreEqual(expected, actual)

    End Sub

    '''<summary>
    '''A test for UltimoDiaDelMesEnFecha
    '''</summary>
    <TestMethod()> _
    Public Sub UltimoDiaDelMesEnFechaTest()
        Dim expected As System.DateTime = "31/12/2013 00:00:00"
        Dim actual As Date
        actual = Fechas.UltimoDiaDelMesEnFecha
        Assert.AreEqual(expected, actual)

    End Sub
End Class
