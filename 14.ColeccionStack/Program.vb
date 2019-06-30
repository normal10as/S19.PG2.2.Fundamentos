Imports System

Module Program
    Sub Main(args As String())
        Dim pila As New Stack
        ' agrega elementos
        pila.Push(1)
        pila.Push(2)
        pila.Push(3)

        mostrarTodos(pila)
        ' quita uno, el método devuelve el valor del mismo
        Console.WriteLine("Extrayendo uno: " & pila.Pop())
        ' agrega otro
        pila.Push(4)
        mostrarTodos(pila)
        ' informa cantidad (si es igual a cero la pila esta vacia)
        Console.WriteLine("Cantidad: " & pila.Count)
        ' buscar valores
        buscarValor(pila, 2)
        buscarValor(pila, 6)
        ' itera hasta acabar la pila (con energizer eso no pasa)
        Console.WriteLine("Extraer todos: ")
        While pila.Count > 0
            Console.WriteLine("Extrayendo uno: " & pila.Pop())
        End While
        Console.WriteLine("Pila vacia")
    End Sub

    Private Sub buscarValor(pila As Stack, valor As Object)
        Console.WriteLine("Existe " & valor & ": " & pila.Contains(valor))
    End Sub

    Private Sub mostrarTodos(pila As Stack)
        Console.WriteLine("Mostrando todos:")
        For Each elemento In pila
            Console.WriteLine(elemento)
        Next
    End Sub
End Module
