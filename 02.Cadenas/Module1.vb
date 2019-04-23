Module Module1

    Sub Main()
        Dim TestString As String = "Hello World"
        Console.WriteLine(Len(TestString))
        Console.WriteLine(LCase(TestString))
        Console.WriteLine(UCase(TestString))

        Dim TestDateTime As Date = #1/27/2019 5:04:23 PM#
        Console.WriteLine(Format(TestDateTime, "Long Time"))
        Console.WriteLine(Format(TestDateTime, "h:m:s"))
        Console.WriteLine(Format(TestDateTime, "dddd, MMM d yyyy"))
        Console.WriteLine(Format(TestDateTime, "Long Time"))
        Console.WriteLine(Format(TestDateTime, "Long Time"))
        Console.WriteLine(Format(TestDateTime, "Long Time"))
        Console.WriteLine(Format(TestDateTime, "Long Time"))
    End Sub

End Module
