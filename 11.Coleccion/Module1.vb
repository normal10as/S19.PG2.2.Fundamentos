Module Module1

    Sub main()
        ' crea la coleccion
        Dim frutas As Collection
        ' inicializa la colección
        frutas = New Collection
        ' agregar elementos
        frutas.Add("Manzanas", "mz")
        frutas.Add("Peras", "pe")
        frutas.Add("Frutillas", "fr")
        frutas.Add("Tomate", "to")
        For x = 1 To frutas.Count
            Console.WriteLine(frutas.Item(x))
        Next
        Console.WriteLine("CAntidad: " & frutas.Count)
        ' iterar
        frutas.Remove(2)
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
