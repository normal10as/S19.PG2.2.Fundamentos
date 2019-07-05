Imports System

Module Program
    Sub Main(args As String())
        Dim programasAsociados As New SortedList(Of String, String)

        ' Add some elements to the list. There are no 
        ' duplicate keys, but some of the values are duplicates.
        programasAsociados.Add("txt", "notepad.exe")
        programasAsociados.Add("bmp", "paint.exe")
        programasAsociados.Add("dib", "paint.exe")
        programasAsociados.Add("rtf", "wordpad.exe")
        programasAsociados.Add("exe", "explorer.exe")
        MostrarTodos(programasAsociados)

        Console.WriteLine("Cambiar rtf a winword")
        Console.WriteLine("For key = ""rtf"", value = {0}.", programasAsociados("rtf"))
        programasAsociados("rtf") = "winword.exe"
        MostrarTodos(programasAsociados)
        Console.WriteLine("Eliminar rtf a winword")
        Console.WriteLine("For key = ""rtf"", value = {0}.", programasAsociados("rtf"))
        programasAsociados.Remove("exe")
        MostrarTodos(programasAsociados)
    End Sub

    Private Sub MostrarTodos(lista As SortedList(Of String, String))
        Console.WriteLine("Lista completa")
        For Each kvp As KeyValuePair(Of String, String) In lista
            Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value)
        Next
        Console.WriteLine("")
    End Sub
End Module
