Imports System
Imports System.Collections.ObjectModel

Module Program
    Sub main()
        ' crea la coleccion
        Dim frutas As Collection
        ' inicializa la colecci�n
        frutas = New Collection
        ' agregar elementos
        frutas.Add("Manzanas", "mz")
        frutas.Add("Peras", "pe")
        frutas.Add("Frutillas", "fr")
        frutas.Add("Tomate", "to")
        Console.WriteLine("CAntidad: " & frutas.Count)
        ' iterar
        frutas.Remove(4)
        For Each fruta In frutas
            Console.WriteLine(fruta)
        Next

        Console.WriteLine("segundo: " & frutas.Item(2))
        Console.WriteLine("segundo: " & frutas.Item("fr"))
        frutas.Clear()
        Console.WriteLine("borrado todo")
        For Each fruta In frutas
            Console.WriteLine(fruta)
        Next


    End Sub
End Module
