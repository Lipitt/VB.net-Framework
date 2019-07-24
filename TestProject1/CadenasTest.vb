Imports System.Collections.Generic

Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports Framework.Lipshitz

Imports Framework.Lipshitz.Funciones
Imports Framework.Lipshitz.Sistema.Carpetas

'''<summary>
'''Se trata de una clase de prueba para CadenasTest y se pretende que
'''contenga todas las pruebas unitarias CadenasTest.
'''</summary>
<TestClass()> _
Public Class CadenasTest
    <TestMethod()>
    Public Sub TextoSinBasuraDerechaTest()

        Dim ValorProbar As String = "Homero.Simpson@gmail.com"
        Dim ValorBuscar As String = "@"
        Dim ValorEsperado As String = "Homero.Simpson"
        Dim ValorActual As String = Framework.Lipshitz.Funciones.Cadenas.TextoSinBasuraDerecha(ValorProbar, ValorBuscar)


        Assert.AreEqual(ValorEsperado, ValorActual)
    End Sub
    <TestMethod()>
    Public Sub TextoSinBasuraIzquierdaTest()

        Dim ValorProbar As String = "Homero.Simpson@gmail.com"
        Dim ValorBuscar As String = "@"
        Dim ValorEsperado As String = "gmail.com"
        Dim ValorActual As String = Framework.Lipshitz.Funciones.Cadenas.TextoSinBasuraIzquierda(ValorProbar, ValorBuscar)


        Assert.AreEqual(ValorEsperado, ValorActual)
    End Sub

    '''<summary>
    '''A test for TextoEntreMarcas
    '''</summary>
    <TestMethod()> _
    Public Sub TextoEntreMarcasTest()
        Dim pTexto As String = "[InicioProductosConsumidos]> Detalle Producto: @DetalleProducto [FinProductosConsumidos]"
        Dim MarcaIzquierda As String = "[InicioProductosConsumidos]"
        Dim MarcaDerecha As String = "[FinProductosConsumidos]"
        Dim expected As String = "> Detalle Producto: @DetalleProducto "
        Dim actual As String
        actual = Cadenas.TextoEntreMarcas(pTexto, MarcaIzquierda, MarcaDerecha)
        Assert.AreEqual(expected, actual)

    End Sub



    
    '''<summary>
    '''A test for Reemplazar
    '''</summary>
    <TestMethod()> _
    Public Sub ReemplazarTest()
        Dim Instancia As String = "Los Gatos sean unidos"
        Dim ValorAReemplazar As String = "Gatos"
        Dim Reemplazo As String = "Hermanos"
        Dim ValorEsperado As String = "Los Hermanos sean unidos"
        Dim ValorActual As String = Framework.Lipshitz.Funciones.Cadenas.Reemplazar(ValorAReemplazar, Reemplazo, Instancia)

        Assert.AreEqual(ValorActual, ValorEsperado)

    End Sub

  

    '''<summary>
    '''A test for ReemplazarEntreMarcas
    '''</summary>
    <TestMethod()> _
    Public Sub ReemplazarEntreMarcasTest()
        Dim Expresion As String = "Hola[InicioProductosConsumidos]> Detalle Producto: @DetalleProducto [FinProductosConsumidos]Chau"
        Dim MarcaInicial As String = "[InicioProductosConsumidos]"
        Dim MarcaFinal As String = "[FinProductosConsumidos]"
        Dim Reemplazo As String = "El Detalle del producto"
        Dim expected As String = "HolaEl Detalle del productoChau"
        Dim actual As String
        actual = Cadenas.ReemplazarEntreMarcas(Expresion, MarcaInicial, MarcaFinal, Reemplazo)
        Assert.AreEqual(expected, actual)

    End Sub

    '''<summary>
    '''A test for UnirLista
    '''</summary>
    <TestMethod()> _
    Public Sub UnirListaTest()
        Dim Lista As List(Of String) = ListarCarpetas("C:\a")

        Dim Separador As String = "@"
        Dim expected As String = "C:\a\b@C:\a\c@C:\a\d@C:\a\e@C:\a\f"
        Dim actual As String

        actual = Cadenas.UnirLista(Lista, Separador)
        Assert.AreEqual(expected, actual)

    End Sub
End Class