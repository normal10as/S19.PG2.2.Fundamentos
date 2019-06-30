Imports System

Module Program
    Sub Main(args As String())
        Dim cola As New Queue
        ' agrega elementos
        cola.Enqueue(1)
        cola.Enqueue(2)
        cola.Enqueue(3)

        mostrarTodos(cola)
        ' quita uno, el método devuelve el valor del mismo
        Console.WriteLine("Extrayendo uno: " & cola.Dequeue())
        ' agrega otro
        cola.Enqueue(4)
        mostrarTodos(cola)
        ' informa cantidad (si es igual a cero la pila esta vacia)
        Console.WriteLine("Cantidad: " & cola.Count)
        ' buscar valores
        buscarValor(cola, 2)
        buscarValor(cola, 6)
        ' itera hasta acabar la pila (con energizer eso no pasa)
        Console.WriteLine("Extraer todos: ")
        While cola.Count > 0
            Console.WriteLine("Extrayendo uno: " & cola.Dequeue())
        End While
        Console.WriteLine("Cola vacia")
    End Sub

    Private Sub buscarValor(cola As Queue, valor As Object)
        Console.WriteLine("Existe " & valor & ": " & cola.Contains(valor))
    End Sub

    Private Sub mostrarTodos(cola As Queue)
        Console.WriteLine("Mostrando todos:")
        For Each elemento In cola
            Console.WriteLine(elemento)
        Next
    End Sub
End Module
