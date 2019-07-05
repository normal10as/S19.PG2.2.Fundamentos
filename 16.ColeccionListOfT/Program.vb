Imports System

Module Program
    Sub Main(args As String())
        ' declaración e instanciación
        Dim frutas As New List(Of String)
        ' carga de valores
        frutas.Add("Yaca")
        frutas.Add("Melón")
        frutas.Add("Sandía")
        VerTodos(frutas)
        ' mostrar el indice 1
        Console.WriteLine("indice 1: " & frutas.Item(1))
        ' insertar un elemento
        Console.WriteLine("Insertar kiwi posición 1")
        frutas.Insert(1, "Kiwi")
        VerTodos(frutas)
        ' ordenar
        Console.WriteLine("Ordenar")
        frutas.Sort()
        VerTodos(frutas)
        ' invierta el orden actual
        Console.WriteLine("Invertir")
        frutas.Reverse()
        VerTodos(frutas)
        ' elimino la posición 3
        Console.WriteLine("Eliminar 3")
        frutas.RemoveAt(3)
        VerTodos(frutas)
        ' todos con un for
        Console.WriteLine("todos con un for")
        For x As Integer = 0 To frutas.Count - 1
            Console.WriteLine("{0} - {1}", x, frutas.Item(x))
        Next

        Dim precios As New List(Of Integer)({20, 30, 50})
        Console.WriteLine(vbCrLf & "Ver precios")
        VerTodos(precios)
    End Sub

    Private Sub VerTodos(cadenas As List(Of String))
        ' salida en pantalla
        For Each fruta In cadenas
            Console.WriteLine(fruta)
        Next
        Console.WriteLine("")
    End Sub

    Private Sub VerTodos(numeros As List(Of Integer))
        ' salida en pantalla
        For Each numero In numeros
            Console.WriteLine(numero & " ")
        Next
        Console.WriteLine("")
    End Sub
End Module
