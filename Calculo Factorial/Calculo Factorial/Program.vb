Imports System

Module Program
    Sub Main(args As String())
        'LUIS ALEJANDRO VASQUEZ GALVEZ
        Dim num As Integer

        Console.Write("Ingrese el numero a calcular: ")
        num = Integer.Parse(Console.ReadLine())
        Console.WriteLine("{0}! = {1}", num, fact(num))
        Console.Read()

    End Sub

    Function fact(ByVal num) As Integer

        If num = 1 Then
            Return num
        Else
            Return num * fact(num - 1)
        End If
    End Function

End Module
