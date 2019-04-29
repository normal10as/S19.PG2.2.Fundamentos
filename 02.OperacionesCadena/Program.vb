Module Program
    Sub Main(args As String())
        ' caracteres según codigo unicode
        Console.WriteLine(ChrW(65))
        Console.WriteLine(ChrW(97))
        'mayúsculas y minúsculas
        Dim UpperLowerCase As String = "Hello World 1234"
        Console.WriteLine(Lcase(""))
        Console.WriteLine(UpperLowerCase.ToUpper())

    End Sub
End Module
