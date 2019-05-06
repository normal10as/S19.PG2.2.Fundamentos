Imports System

Module Program
    Enum ColoresPrimarios
        Red = 5
        Green = 18
        Blue = 67
    End Enum

    Sub Main(args As String())
        Console.WriteLine("Ingrese un color ({0}, {1}, {2})")
        Console.WriteLine(ColoresPrimarios.Red & ") " & ColoresPrimarios.Red.ToString())
        Console.WriteLine(ColoresPrimarios.Green & ") {0}", ColoresPrimarios.Green)
        Console.WriteLine("{0}) {1}", ColoresPrimarios.Blue.GetHashCode, ColoresPrimarios.Blue.ToString())
        Dim color As ColoresPrimarios
        color = 18
        Console.WriteLine("Color existe: " & [Enum].IsDefined(GetType(ColoresPrimarios), color))
        Console.WriteLine("Color escogido: " & color & " - " & color.ToString)
        color = 15
        Console.WriteLine("Color existe: " & [Enum].IsDefined(GetType(ColoresPrimarios), color))
        Console.WriteLine("Color escogido: " & color & " - " & color.ToString)
    End Sub
End Module
