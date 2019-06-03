Imports System

Module Program
    Const minimo As Short = -10
    Const maximo As UShort = 10
    Sub Main(args As String())
        Dim valor As Short
        Console.WriteLine("Ingrese un valor entre {0} y {1}", minimo, maximo)
        valor = Console.ReadLine()
        ' verificar si el valor esta entre el mínimo y el máximo
        If valor < minimo Then
            Console.WriteLine("El valor no puede ser menor a " & minimo)
        ElseIf valor > maximo Then
            Console.WriteLine("El valor no puede ser mayor a " & maximo)
        Else
            Console.WriteLine("Valor aceptado")
            ' da información adicional del numero
            Select Case valor
                Case 1
                    Console.WriteLine("Es uno")
                Case 2
                    Console.WriteLine("Es dos")
                Case 3, 5
                    Console.WriteLine("Es tres o cinco")
                Case 6 To 8
                    Console.WriteLine("Es de seis a ocho")
                Case  Is <0
                    Console.WriteLine("Es negativo")
                Case Else
                    Console.WriteLine("Es otro numero")
            End Select
        End If
    End Sub
End Module
