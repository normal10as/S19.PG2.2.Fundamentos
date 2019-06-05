Module DoUntil
    Sub NumeroPrimo()
        Console.WriteLine("Un número primo es un número natural mayor que 1 que tiene únicamente dos divisores distintos: él mismo y el 1")
        Console.WriteLine("Ingrese un valor para saber si es número primo: ")
        Dim valor, divisor, raizcuadrada As UInteger
        valor = Console.ReadLine()
        ' el máximo valor divisor sera equivalente a la raíz cuadrada del valor
        ' esto reduce iteraciones innecesarias
        raizcuadrada = Math.Sqrt(valor)
        Console.WriteLine("Raiz cuadrada: " & raizcuadrada)
        ' el primer valor divisor para descartar un numero primo es 2
        divisor = 2

        ' sale si el resto es igual de cero y el divisor es mayor a la raíz cuadrada
        ' si el primer calculo de resto da 0 no itera en absoluto
        Do Until valor Mod divisor = 0 Or divisor > raizcuadrada
            divisor += 1
            Console.Write(" " & divisor)
        Loop

        'si el divisor es mayor a la raíz cuadrada es primo
        If divisor > raizcuadrada Then
            Console.WriteLine(vbCrLf & "Es primo")
        Else
            Console.WriteLine(vbCrLf & "No es primo")
        End If
    End Sub
End Module
