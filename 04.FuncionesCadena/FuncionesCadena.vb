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

        ' Returns current system time in the system-defined long time format.
        Console.WriteLine(Format(Now(), "Long Time"))
        ' Returns current system date in the system-defined long date format.
        Console.WriteLine(Format(Now(), "Long Date"))
        ' Also returns current system date in the system-defined long date 
        ' format, using the single letter code for the format.
        Console.WriteLine(Format(Now(), "D"))

        ' Returns the value of TestDateTime in user-defined date/time formats.
        ' Returns "5:4:23".
        Console.WriteLine(Format(Now(), "h:m:s"))
        ' Returns "05:04:23 PM".
        Console.WriteLine(Format(Now, "hh:mm:ss tt"))
        ' Returns "Saturday, Jan 27 2001".
        Console.WriteLine(Format(Now, "dddd, MMM d yyyy"))
        ' Returns "17:04:23".
        Console.WriteLine(Format(Now, "HH:mm:ss"))

        ' User-defined numeric formats.
        ' Returns "5,459.40".
        Console.WriteLine(Format(5459.4, "##,##0.00"))
        ' Returns "334.90".
        Console.WriteLine(Format(5334.9, "###0.00"))
        ' Returns "500.00%".
        Console.WriteLine(Format(5, "0.00%"))
        Console.ReadKey()
    End Sub

End Module
