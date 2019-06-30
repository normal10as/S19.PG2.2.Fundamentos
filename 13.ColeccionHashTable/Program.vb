Imports System

Module Program
    Sub Main(args As String())
        ' crea e instancia
        Dim tablita As New Hashtable
        ' agrega elementos
        tablita.Add("R", "Rojo")
        tablita.Add("V", "Verde")
        tablita.Add("A", "Azul")
        ' itera sobre la colección
        ' cada elemento es creado como un dictionaryentry
        mostrarElementos(tablita)
        Console.WriteLine(tablita.ContainsKey("R"))
        Console.WriteLine(tablita.ContainsKey("W"))
        tablita.Remove("V")
        mostrarElementos(tablita)
    End Sub

    Private Sub mostrarElementos(tablita As Hashtable)
        For Each elemento As DictionaryEntry In tablita
            Console.WriteLine(elemento.Key & " " & elemento.Value)
        Next
    End Sub
End Module
