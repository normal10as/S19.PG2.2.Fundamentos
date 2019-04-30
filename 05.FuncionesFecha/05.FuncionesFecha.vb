Imports System.DateTime
Imports System.String
Module Program
    Sub Main(args As String())
        Console.WriteLine("Ahora: " & now)
        Dim TestDateTime As Date = #1/27/2019 5:04:23 PM#
        Console.WriteLine("Fecha: " & TestDateTime)
        TestDateTime = New DateTime(2019, 4, 20)
        Console.WriteLine(TestDateTime)
        TestDateTime = New DateTime(2019, 4, 20, 12, 35, 30)
        Console.WriteLine(TestDateTime)
        Console.WriteLine("Día de la semana: " & TestDateTime.DayOfWeek)
        Console.WriteLine("Mes: " & Now.Month)
        Console.WriteLine("Segundos: " & Now.Second)

        Console.WriteLine("Fecha: " & TestDateTime.AddDays(10))
        Console.WriteLine("Fecha: " & TestDateTime.AddMonths(-2))
        Console.WriteLine("Fecha: " & TestDateTime.AddHours(5))

    End Sub
End Module
