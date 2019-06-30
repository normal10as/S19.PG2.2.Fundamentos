Imports System

Module Program
    Sub Main(args As String())
        ' crea la coleccion
        Dim frutas As ArrayList
        ' inicializa la colección
        frutas = New ArrayList
        ' agregar elementos
        frutas.Add("Manzanas")
        frutas.Add("Peras")
        frutas.Add("Frutillas")
        frutas.Add("Tomate")
        ' ver tamaño de la colección
        Console.WriteLine("Cantidad: " & frutas.Count)
        ' iterar
        MostrarColeccion(frutas)

        Console.WriteLine("eliminar e insertar")
        frutas.RemoveAt(3)
        frutas.Remove("Peras")
        frutas.Insert(0, "Mandarina")
        frutas.Insert(2, "Naranja")

        MostrarColeccion(frutas)
        ' ordena por valores
        frutas.Sort()
        ' invierte el orden
        frutas.Reverse()
        Console.WriteLine("Ordenar")
        MostrarColeccion(frutas)
        ' obtiene el segundo elemento
        Console.WriteLine("segundo: " & frutas.Item(1))
        ' modifica el segundo elemento
        frutas(1) = "Sandia"
        frutas.Item(1) = "Morango"
        Console.WriteLine("segundo: " & frutas.Item(1))
        ' buscar un valor
        Console.WriteLine(frutas.Contains("Sandia"))
        Console.WriteLine(frutas.Contains("Morango"))
        Console.WriteLine(frutas.IndexOf("Sandia"))
        Console.WriteLine(frutas.IndexOf("Morango"))
        MostrarColeccion(frutas)

        frutas.Clear()
        Console.WriteLine("borrado todo")
        Console.WriteLine("Cantidad elementos: " & frutas.Count)
        MostrarColeccion(frutas)
    End Sub

    Private Sub MostrarColeccion(frutas As ArrayList)
        Console.WriteLine("Mostrar colección")
        For Each fruta In frutas
            Console.WriteLine(fruta)
        Next
    End Sub
End Module
