Namespace Funciones
   
    Public Class Cadenas

#Region "Reemplazar(), reemplaza un caracter en todo el texto y te devuelve la texto modificado"
        Public Shared Function Reemplazar(cadenaOriginal As String, cadenaBuscar As String, cadenaReemplazar As String) As String

            Return cadenaOriginal.Replace(cadenaBuscar, cadenaReemplazar)

        End Function
#End Region
       
#Region "SepararEnLista(), separa un texto en una lista , corta el texto cuando hay un caracter separador"
        Public Shared Function SepararEnLista(cadenaSeparar As String, caracterSeparador As String) As List(Of String)

            Dim v() As String = cadenaSeparar.Split(caracterSeparador)

            Dim unaLista As List(Of String) = v.ToList()


            Return unaLista

        End Function
#End Region
        
#Region "UnirLista(), une una lista en un texto"
        Public Shared Function UnirLista(laLista As List(Of String), caracterSeparador As String) As String

            Return String.Join(caracterSeparador, laLista)

        End Function
#End Region
        
#Region "DecorarLista(), decora cada item de una lista con un caracter elegido"
        Public Shared Function DecorarLista(laLista As List(Of String), caracterDecorador As String) As List(Of String)

            Dim nuevaLista As New List(Of String)

            For Each item In laLista
                item = String.Concat(caracterDecorador, item)
                nuevaLista.Add(item)
            Next

            Return nuevaLista

        End Function

        'Dim daoFacultad As New DaoFacultad()

        'Dim facultades = daoFacultad.TraerFacultades()

        'CboFacultad.DataSource = Nothing
        'CboFacultad.DataSource = facultades
        'CboFacultad.DisplayMember = "NombreFacultad"


        'Dim sedeSeleccionada As Modelo.Sede

        'sedeSeleccionada = CboSede.SelectedItem

        'Dim daoFacultad As New DaoFacultad()
        'Dim laFacultad = daoFacultad.TraerFacultadPorId(sedeSeleccionada.IdFacultad)

        'txtNombreFacultad.Text = laFacultad.NombreFacultad


#End Region

    End Class
End Namespace
