Module Module1
    Const inicio As Short = 1
    Const tope As Short = 5

    Sub ComparandoEstructras()
        Console.WriteLine(vbCrLf & "For")
        For y As SByte = inicio To tope
            EscribirHorizontal(y)
        Next

        Dim valor As Short
        Console.WriteLine(vbCrLf & "Do While")
        valor = inicio
        Do While valor <= tope
            EscribirHorizontal(valor)
            valor += 1
        Loop
        Console.WriteLine(vbCrLf & "Do Until")
        valor = inicio
        Do Until valor > tope
            EscribirHorizontal(valor)
            valor += 1
        Loop
        Console.WriteLine(vbCrLf & "Loop While")
        valor = inicio
        Do
            EscribirHorizontal(valor)
            valor += 1
        Loop While valor <= tope
        valor = inicio
        Console.WriteLine(vbCrLf & "Loop Until")
        Do
            EscribirHorizontal(valor)
            valor += 1
        Loop Until valor > tope
    End Sub

    Private Sub EscribirHorizontal(y As SByte)
        Console.Write(y & " ")
    End Sub
End Module
