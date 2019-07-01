Imports System

Module Program
    Sub Main(args As String())
        ' declaraci�n e instanciaci�n
        Dim frutas As New List(Of String)
        ' carga de valores
        frutas.Add("Yaca")
        frutas.Add("Mel�n")
        frutas.Add("Sand�a")
        ' ver tama�o de la colecci�n
        Console.WriteLine("Cantidad: " & frutas.Count)
        MostrarTodos(frutas)
        ' mostrar el indice 1
        Console.WriteLine("indice 1: " & frutas.Item(1))
        ' insertar un elemento
        Console.WriteLine("insertar en 1")
        frutas.Insert(1, "Kiwi")
        MostrarTodos(frutas)
        ' ordenar
        Console.WriteLine("Ordenar")
        frutas.Sort()
        MostrarTodos(frutas)
        ' invierta el orden actual
        Console.WriteLine("Invertir")
        frutas.Reverse()
        MostrarTodos(frutas)
        ' elimino la posici�n 3
        Console.WriteLine("Borrar 2")
        frutas.RemoveAt(2)
        MostrarTodos(frutas)
        ' todos con un for
        Console.WriteLine("todos con un for")
        For x As Integer = 0 To frutas.Count - 1
            Console.WriteLine("{0} - {1}", x, frutas.Item(x))
        Next
    End Sub

    Private Sub MostrarTodos(frutas As List(Of String))
        ' salida en pantalla
        For Each fruta In frutas
            Console.WriteLine(fruta)
        Next
        Console.WriteLine("")
    End Sub
End Module
