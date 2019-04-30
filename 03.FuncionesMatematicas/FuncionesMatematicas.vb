Imports System.Math

Module Program
    Sub Main(args As String())
        Dim a, b As Double
        a = -50.3
        b = 2.8
        Console.WriteLine("Valor absoluto de {0} = {1}", a, Abs(a))
        Console.WriteLine("Calcula el valor de pi " & 4 * Atan(1.0))
        Console.WriteLine("Redondeo de {0} = {1}", a, Round(a))
        Console.WriteLine("Redondeo de {0} = {1}", b, Round(b))
        Console.WriteLine("Parte entera de {0} = {1}", b, Truncate(b))
        Console.WriteLine("Raíz cuadrada de {0} = {1}", a, Sqrt(a))
        Console.WriteLine("Raíz cuadrada de {0} = {1}", b, Sqrt(b))

    End Sub
End Module
