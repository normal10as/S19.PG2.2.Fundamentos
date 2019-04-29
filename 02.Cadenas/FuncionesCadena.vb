Module FuncionesCadena

    Sub Main()
        Dim TestString As String = "Hello World"
        Console.WriteLine(TestString)
        Console.WriteLine("Longitud: " & Len(TestString))
        Console.WriteLine("todo minúscula: " & LCase(TestString))
        Console.WriteLine("TODO MAYÚSCULA: " & UCase(TestString))

        ' Initializes string.
        TestString = "  <-Trim->  "
        Console.WriteLine("Recortar:")
        Console.WriteLine("Completo  >{0}<", TestString)
        Console.WriteLine("Izquierda >{0}<", LTrim(TestString))
        Console.WriteLine("Derecha   >{0}<", RTrim(TestString))
        Console.WriteLine("Todo      >{0}<", Trim(TestString))

        TestString = "Mid Function Demo"
        Console.WriteLine("Extraer: " & TestString)
        Console.WriteLine(Mid(TestString, 1, 3))
        Console.WriteLine(Mid(TestString, 5, 8))
        Console.WriteLine(Mid(TestString, 14))

        ' cadena donde ser realiza la busqueda
        Dim SearchString As String = "XXpXXpXXPXXP"
        ' cadena a buscar
        Dim SearchChar As String = "P"
        Dim startPosition As Byte = 4
        Console.WriteLine("Buscar {0} en {1} empezando en la posición {2}", SearchChar, SearchString, startPosition)
        ' A textual comparison starting at position 4. Returns 6.
        Console.WriteLine(InStr(startPosition, SearchString, SearchChar, CompareMethod.Text))
        ' A binary comparison starting at position 1. Returns 9.
        startPosition = 1
        Console.WriteLine("Buscar {0} en {1} empezando en la posición {2}", SearchChar, SearchString, startPosition)
        Console.WriteLine(InStr(startPosition, SearchString, SearchChar, CompareMethod.Binary))
        ' Returns 0.
        Console.WriteLine(InStr(startPosition, SearchString, "W", CompareMethod.Binary))

        ' Reemplazo
        TestString = "Shopping List"
        Console.WriteLine("Reemplazar en '{0}' la o por la i", TestString)
        Console.WriteLine(Replace(TestString, "o", "i"))

        Console.ReadKey()
    End Sub

End Module
