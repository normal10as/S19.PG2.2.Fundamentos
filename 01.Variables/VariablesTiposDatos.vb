Imports System
Imports _02

Module Variables
    ' esta variable es accesible en cualquier lugar de este módulo
    Private privada As String

    Sub Main()
        ' declaración
        Dim bite As Byte
        ' asignación
        bite = 100
        Console.WriteLine("Byte = " & bite)

        ' operación
        bite = bite - 100
        ' salida
        Console.WriteLine("Byte -= 100 = " & bite)

        ' conversión implícita de double a single: se realiza redondeo
        Dim simple As Single = Math.PI
        Dim doble As Double = Math.PI
        Console.WriteLine("Pi en single: " & simple)
        Console.WriteLine("Pi en doble: " & doble)

        ' conversión implícita de double a decimal
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
        Console.WriteLine("Algún día: " & algunDia)

        ' char
        Dim car As Char
        car = "e"
        Console.WriteLine("Char: " & car)
        car = Convert.ToChar(101)
        Console.WriteLine("ToChar(101): " + car)

        'Constante
        Const iva As Single = 21
        Dim monto As Single = 500
        Console.WriteLine("Compra: $" & monto)
        Console.WriteLine("Iva: %" & iva)
        Console.WriteLine("Total: $" & monto + monto * iva / 100)

        ' alcance o visibilidad de variables
        privada = "Esta cadena esta en una variable privada"
        amiga = "Esta cadena esta en una variable amiga"
        Operaciones.publica = "Esta cadena esta en una variable publica"
        otroProcedimiento()
        Console.ReadKey()
        Console.Clear()
        Operaciones.Main()
    End Sub

    Sub otroProcedimiento()
        Console.WriteLine(privada)
        Console.WriteLine(amiga)
        Console.WriteLine(Operaciones.publica)
    End Sub
End Module
