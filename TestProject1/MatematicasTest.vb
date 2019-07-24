Imports Framework.Lipshitz.Funciones

Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports System.Text
Imports Framework.Lipshitz.Funciones.Matematicas
<TestClass()>
Public Class MatematicasTest


    <TestMethod()>
    Public Sub NumeroAleatorioTest()

        Dim pDesde As Integer = 1
        Dim pHasta As Integer = 99999

        Dim EsperadoActual1 As Integer
        EsperadoActual1 = Framework.Lipshitz.Funciones.Matematicas.NumeroAleatorio(pDesde, pHasta)

        For Index = 1 To 100
            Dim EsperadoActual2 As Integer
            EsperadoActual2 = Framework.Lipshitz.Funciones.Matematicas.NumeroAleatorio(pDesde, pHasta)

            Assert.AreNotEqual(EsperadoActual1, EsperadoActual2)
            EsperadoActual1 = EsperadoActual2
        Next


    End Sub

    '''<summary>
    '''A test for ObtenerPorcentaje
    '''</summary>
    <TestMethod()> _
    Public Sub ObtenerPorcentajeTest()
        Dim Valor As Double = 25.5
        Dim Total As Double = 5484.4
        Dim expected As Double = 1398.522
        Dim actual As Double
        actual = Matematicas.ObtenerPorcentaje(Valor, Total)
        Assert.AreEqual(expected, actual)

    End Sub
End Class

