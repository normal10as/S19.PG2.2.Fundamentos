Imports System

Module Program
    Sub Main(args As String())
        Dim programaAsociado As New SortedList(Of String, String)
        AgregarElementos(programaAsociado)
        MostrarUnoPorClave("rtf", programaAsociado)
        MostrarTodos(programaAsociado)
        MostrarTodasLasClaves(programaAsociado)
        MostrarTodosLosValores(programaAsociado)
        MostrarTodosPorIndice(programaAsociado)
        CambiarUnValor("rtf", "Word.exe", programaAsociado)
        MostrarTodos(programaAsociado)
        ExisteClave("doc", programaAsociado)
        ExisteClave("rtf", programaAsociado)
        MostrarElValorSiExisteLaClave("doc", programaAsociado)
        MostrarElValorSiExisteLaClave("rtf", programaAsociado)
        BorrarUnElemento("dib", programaAsociado)
        MostrarTodos(programaAsociado)
    End Sub

    Private Sub AgregarElementos(programaAsociado As SortedList(Of String, String))
        ' Agrega algunos elementos a la lista
        ' No hay claves duplicadas pero los valores si pueden estarlo
        programaAsociado.Add("txt", "notepad.exe")
        programaAsociado.Add("bmp", "paint.exe")
        programaAsociado.Add("dib", "paint.exe")
        programaAsociado.Add("rtf", "wordpad.exe")
        programaAsociado.Add("exe", "explorer.exe")
    End Sub

    Private Sub MostrarTodosLosValores(programaAsociado As SortedList(Of String, String))
        Console.WriteLine(vbCrLf & "Todos los valores")
        For Each clave In programaAsociado.Values
            Console.WriteLine(clave)
        Next
    End Sub

    Private Sub MostrarTodasLasClaves(programaAsociado As SortedList(Of String, String))
        Console.WriteLine(vbCrLf & "Todas las claves")
        For Each clave In programaAsociado.Keys
            Console.WriteLine(clave)
        Next
    End Sub

    Private Sub MostrarUnoPorClave(clave As String, coleccion As SortedList(Of String, String))
        Console.WriteLine("Clave: {0} - Valor: {1}", clave, coleccion(clave))
    End Sub
    Private Sub MostrarTodos(programaAsociado As SortedList(Of String, String))
        Console.WriteLine(vbCrLf & "Lista completa")
        For Each kvp As KeyValuePair(Of String, String) In programaAsociado
            Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value)
        Next
    End Sub

    Private Sub CambiarUnValor(clave As String, nuevoValor As String, lista As SortedList(Of String, String))
        Console.WriteLine(vbCrLf & "Cambiar para clave = {0} valor = {1} a nuevo valor {2}", clave, lista(clave), nuevoValor)
        lista(clave) = nuevoValor
    End Sub

    Private Sub BorrarUnElemento(clave As String, lista As SortedList(Of String, String))
        Console.WriteLine(vbCrLf & "Borrar para clave = {0} valor = {1}", clave, lista(clave))
        lista.Remove(clave)
    End Sub

    Private Sub MostrarElValorSiExisteLaClave(clave As String, lista As SortedList(Of String, String))
        ' Si la clave existe obtiene el valor y lo muestra
        ' si no muestra un mensaje de error
        Dim valor As String = ""
        If lista.TryGetValue(clave, valor) Then
            Console.WriteLine(vbCrLf & "En clave = {0} - valor = {1}", clave, valor)
        Else
            Console.WriteLine(vbCrLf & "Clave = {0} no tiene valor porque no existe.", clave)
        End If
    End Sub

    Private Sub ExisteClave(clave As String, lista As SortedList(Of String, String))
        If lista.ContainsKey(clave) Then
            Console.WriteLine(vbCrLf & "Clave = {0} existe.", clave)
        Else
            Console.WriteLine(vbCrLf & "Clave = {0} no existe.", clave)
        End If
    End Sub

    Private Sub MostrarTodosPorIndice(lista As SortedList(Of String, String))
        Console.WriteLine(vbCrLf & "Lista completa iterada por índice")
        For x = 0 To lista.Count - 1
            Console.WriteLine("Key = {0}, Value = {1}", lista.Keys(x), lista.Values(x))
        Next
    End Sub
End Module
