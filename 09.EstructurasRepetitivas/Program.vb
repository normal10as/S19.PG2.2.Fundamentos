Imports System

Module Program
    Sub Main(args As String())
        ComparandoEstructras()
        Return
        For y As Byte = 3 To 30 Step 3
            Console.WriteLine(y)
        Next
        Console.ReadKey()

        Do
            Console.WriteLine("ingresar un valor entre 1 y 10")
            valor = Console.ReadLine()
        Loop Until valor >= 1 And valor <= 10
    End Sub
End Module
