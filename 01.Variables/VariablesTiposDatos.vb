Imports System

Module Variables
    Sub Main()
        ' declaraci�n
        Dim bite As Byte
        ' asignaci�n
        bite = 100
        Console.WriteLine("Byte = " & bite)

        ' operaci�n
        bite = bite - 100
        ' salida
        Console.WriteLine("Byte -= 100 = " & bite)

        ' conversi�n impl�cita de double a single: se realiza redondeo
        Dim simple As Single = Math.PI
        Dim doble As Double = Math.PI
        Console.WriteLine("Pi en single: " & simple)
        Console.WriteLine("Pi en doble: " & doble)

        ' conversi�n impl�cita de double a decimal
        Dim deci As Decimal = Math.PI
        Console.WriteLine("Pi en decimal: " & deci)

        ' desplazamiento del punto flotante
        simple = simple * 4
        Console.WriteLine("Pi single * 4: " & simple)
        deci = deci * 4
        Console.WriteLine("Pi decimal * 4: " & deci)

        ' fecha
        Dim ahora As Date
        ahora = Date.Now
        Console.WriteLine("Ahora es: " & ahora)
        Dim algunDia As Date
        algunDia = #4/2/2017 21:47#
        Console.WriteLine("Alg�n d�a: " & algunDia)

        ' char
        Dim car As Char
        car = "e"
        Console.WriteLine("Char: " & car)
        car = Convert.ToChar(101)
        Console.WriteLine("ToChar(101): " & car)
    End Sub
End Module
