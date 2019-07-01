Imports System

Module Program
    Sub Main(args As String())
        Dim programaAsociado As New SortedList(Of String, String)

        ' Add some elements to the list. There are no 
        ' duplicate keys, but some of the values are duplicates.
        programaAsociado.Add("txt", "notepad.exe")
        programaAsociado.Add("bmp", "paint.exe")
        programaAsociado.Add("dib", "paint.exe")
        programaAsociado.Add("rtf", "wordpad.exe")
        programaAsociado.Add("exe", "explorer.exe")
        MostrarTodos(programaAsociado)

        Console.WriteLine("Cambiar rtf a winword")
        Console.WriteLine("For key = ""rtf"", value = {0}.", programaAsociado("rtf"))
        programaAsociado("rtf") = "winword.exe"
        MostrarTodos(programaAsociado)
        Console.WriteLine("Eliminar rtf a winword")
        Console.WriteLine("For key = ""rtf"", value = {0}.", programaAsociado("rtf"))
        programaAsociado.Remove("exe")
        MostrarTodos(programaAsociado)
    End Sub

    Private Sub MostrarTodos(programaAsociado As SortedList(Of String, String))
        Console.WriteLine("Lista completa")
        For Each kvp As KeyValuePair(Of String, String) In programaAsociado
            Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value)
        Next
        Console.WriteLine("")
    End Sub
End Module
