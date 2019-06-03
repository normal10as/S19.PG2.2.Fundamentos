Module ForNext
    Sub Hacer()
        Console.WriteLine("Tabla de multiplicar")
        Console.Write("Ingrese un valor: ")
        Dim valor As UInt16 = Console.ReadLine()
        For x = 1 To 10
            Console.WriteLine("{0} x {1} = {2}", valor, x, valor * x)
        Next
    End Sub
End Module
