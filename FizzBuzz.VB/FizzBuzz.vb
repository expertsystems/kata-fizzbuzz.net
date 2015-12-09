Imports Common.Logging

Namespace FizzBuzz
    Public Class FizzBuzz


        Function fizzbuzz(input As Integer) As String

            If isBuzz(input) Then
                If isFizz(input) Then
                    Return "FizzBuzz"
                Else
                    Return "Buzz"
                End If
            ElseIf isFizz(input) Then
                Return "Fizz"
            Else
                Return input
            End If

        End Function

        Function isFizz(input As Integer) As Boolean

            Return (input Mod 3 = 0) OrElse CStr(input).Contains(3)

        End Function

        Function isBuzz(input As Integer) As Boolean

            Return (input Mod 5 = 0)

        End Function

    End Class


End Namespace
