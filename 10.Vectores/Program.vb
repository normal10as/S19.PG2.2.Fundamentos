Imports System

Module Program
    Sub Main(args As String())
        ' declaración de un array con 3 elementos
        Dim valores(2) As UShort
        ' asignación de los valores uno por uno
        valores(0) = 5
        valores(1) = 15
        valores(2) = 25

        ' iteración sobre el vector para mostrar el valor de todos los elementos
        For x = 0 To valores.Length() - 1
            Console.WriteLine(valores(x))
        Next

        ' declaración de un array con 3 elementos y asignación de los valores
        Dim nombres = New String() {"Pepe", "Juan", "Maria"}
        ' iteración sobre el vector para mostrar el valor de todos los elementos
        For Each nombre In nombres
            Console.WriteLine(nombre)
        Next

        ' iteración sobre el vector para alterar el valor de todos los elementos
        For x = 0 To valores.Length() - 1
            valores(x) *= valores(x)
            Console.WriteLine(valores(x))
        Next

        ' declara un array de 2 dimensiones 3 x 2
        Dim matriz(2, 1) As Single
        ' asignación de los valores uno por uno
        matriz(0, 0) = 1
        matriz(0, 1) = 2
        matriz(1, 0) = 3
        matriz(1, 1) = 4
        'matriz(2, 0) = 5
        'matriz(2, 1) = 6
        MostrarMatriz(matriz)

        ' declara y asigna un vector de 2 x 3
        Dim grid1 = {{1, 2}, {3, 4}, {5, 6}}
        MostrarMatriz(grid1)
        Console.WriteLine("Longitud: " & grid1.Length())
        Console.WriteLine("Ultima posición Dimension 0: " & grid1.GetUpperBound(0))
        Console.WriteLine("Ultima posición Dimension 1: " & grid1.GetUpperBound(1))

        For x = 0 To grid1.GetUpperBound(1)
            For y = 0 To grid1.GetUpperBound(0)
                Console.Write(grid1(y, x) & " ")
            Next
            Console.WriteLine()
        Next

        ' array multidimensional
        Dim grid2 = {{{1, 2}, {3, 4}, {5, 6}}, {{7, 8}, {9, 10}, {11, 12}}, {{13, 14}, {15, 16}, {17, 18}}, {{19, 20}, {21, 22}, {23, 24}}}
        Console.WriteLine("Longitud: " & grid2.Length())
        Console.WriteLine("Dimensiones: " & grid2.Rank())
        For x = 1 To grid2.Rank()
            Console.WriteLine("Longitud dimension {0}: {1}", x, grid2.GetLength(x - 1))
        Next

    End Sub
    Sub MostrarMatriz(grid)
        For Each valor In grid
            Console.Write(valor & " ")
        Next
        Console.WriteLine()
    End Sub
End Module
