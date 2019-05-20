Module Module1
    Const inicio As Short = 1
    Const tope As Short = 5

    Sub ComparandoEstructras()
        Dim valor As Short
        Console.WriteLine(vbCr & "Do While")
        valor = inicio
        Do While valor > tope
            Console.Write(valor)
            valor += 1
        Loop
        Console.WriteLine(vbCr & "Do Until")
        valor = inicio
        Do Until valor > tope
            Console.Write(valor)
            valor += 1
        Loop
        Console.WriteLine(vbCr & "Loop While")
        valor = inicio
        Do
            Console.Write(valor)
            valor += 1
        Loop While valor <= tope
        valor = inicio
        Console.WriteLine(vbCr & "Loop Until")
        Do
            Console.Write(valor)
            valor += 1
        Loop Until valor > tope

        Console.WriteLine(vbCr & "For")
        For y As Byte = 1 To 5
            Console.WriteLine(y)
        Next
    End Sub
End Module
