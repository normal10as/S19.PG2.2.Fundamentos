Module Module1
    Const inicio As Short = 1
    Const tope As Short = 5

    Sub ComparandoEstructras()
        Console.WriteLine(vbCrLf & "For")
        For y As Byte = inicio To tope
            Console.Write(y & " ")
        Next

        Dim valor As Short
        Console.WriteLine(vbCrLf & "Do While")
        valor = inicio
        Do While valor < tope
            Console.Write(valor)
            valor += 1
        Loop
        Console.WriteLine(vbCrLf & "Do Until")
        valor = inicio
        Do Until valor > tope
            Console.Write(valor)
            valor += 1
        Loop
        Console.WriteLine(vbCrLf & "Loop While")
        valor = inicio
        Do
            Console.Write(valor)
            valor += 1
        Loop While valor <= tope
        valor = inicio
        Console.WriteLine(vbCrLf & "Loop Until")
        Do
            Console.Write(valor)
            valor += 1
        Loop Until valor > tope
    End Sub
End Module
