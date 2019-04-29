Imports System

Module Program
    Sub Main(args As String())
        Dim dato1, dato2, resultado As Integer
        dato1 = 20
        dato2 = 10

        ' suma
        resultado = dato1 + dato2
        ' el método writeline reemplaza en la cadena a un valor entre llaves por el número de parámetro respectivo
        Console.WriteLine("{0} + {1} = {2}", dato1, dato2, resultado)

        ' resta
        resultado = dato1 - dato2
        Console.WriteLine("{0} - {1} = {2}", dato1, dato2, resultado)

        ' multiplicación
        resultado = dato1 * dato2
        Console.WriteLine("{0} * {1} = {2}", dato1, dato2, resultado)

        ' división
        resultado = dato1 / dato2
        Console.WriteLine("{0} / {1} = {2}", dato1, dato2, resultado)

        Dim a As Integer = 5
        Dim b As Single = 10
        Dim c As Byte = 2
        Dim x As Double
        x = a + b * c / a
        Console.WriteLine("{0} + {1} * {2} / {0} = " & x, a, b, c)

        ' Acumulador
        Console.Write("{0} + {1} = ", x, b)
        x += b
        Console.WriteLine(x)

        ' booleano
        Dim verdadero As Boolean = True
        Dim falso As Boolean = False
        Console.WriteLine("valor 1 {0} y valor 2 {1}: " _
            & (verdadero And falso), verdadero, falso)
        Console.WriteLine("valor 1 Verdadero y valor 2 Falso: " _
            & (verdadero And falso))

        ' resto
        Console.WriteLine("{0} mod {1}: " & (a Mod b), a, b)

        Console.WriteLine(Convert.ToByte("5"))

        ' concatenacion
        Dim numero As Integer = 6
        Dim cadena As String = "pepe"
        'concatenaciones
        ' con converción explícita
        Console.WriteLine(cadena + " " + Convert.ToString(numero))
        ' con conversión implícita
        Console.WriteLine(cadena & " " & numero)
    End Sub
End Module
