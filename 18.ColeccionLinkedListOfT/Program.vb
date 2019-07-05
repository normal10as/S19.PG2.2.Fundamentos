Imports System

Module Program
    Sub Main(args As String())
        Dim ciudades_ruta12 As New LinkedList(Of String)
        ciudades_ruta12.AddFirst("Posadas")
        ciudades_ruta12.AddLast("Iguazu")
        ciudades_ruta12.AddAfter(ciudades_ruta12.Find("Posadas"), "Candelaria")
        ciudades_ruta12.AddBefore(ciudades_ruta12.Find("Iguazu"), "Eldorado")
        For Each ciudad In ciudades_ruta12
            Console.WriteLine(ciudad)
        Next
    End Sub
End Module
