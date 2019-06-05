Module LoopWhile
    Sub SumatoriaPromedio()
        Console.WriteLine("Sumatoria y promedio")
        Console.WriteLine("Ingresar varios numeros, salir por cero")
        Dim valor, acumulado As UInteger
        Dim contador As SByte
        contador = -1
        Do
            valor = Console.ReadLine()
            acumulado += valor
            contador += 1
        Loop While valor <> 0
        Console.WriteLine("Total: " & acumulado)
        Console.WriteLine("Promedio: " & acumulado / contador)
    End Sub
End Module
