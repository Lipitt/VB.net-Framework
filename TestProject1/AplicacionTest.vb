Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports Framework.Lipshitz
Imports Framework.Lipshitz.Aplicaciones



'''<summary>
'''This is a test class for AplicacionTest and is intended
'''to contain all AplicacionTest Unit Tests
'''</summary>
<TestClass()> _
Public Class AplicacionTest

    '''<summary>
    '''A test for AplicacionEstaCorriendo
    '''</summary>
    <TestMethod()> _
    Public Sub AplicacionEstaCorriendoTest()
        Dim NombreProceso As String = "firefox"
        Dim expected As Boolean = True
        Dim actual As Boolean
        actual = Aplicacion.AplicacionEstaCorriendo(NombreProceso)
        Assert.AreEqual(expected, actual)
    End Sub
End Class
