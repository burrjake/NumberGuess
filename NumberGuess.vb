Option Compare Text
Option Explicit On
Option Strict On

'
'
'
'

Module NumberGuess

    Sub Main()
        Dim guessedNumber As Single
        Dim highNumber As Int32
        Dim lowNumber As Int32
        Dim numberOfGuesses As Integer
        Dim correct As Boolean
        Dim userMessage As String

        lowNumber = 1
        highNumber = 100

        Console.WriteLine("Think of a number between 1 and 100.")

        Do While correct = False
            correct = False
            guessedNumber = Int((Rnd() * highNumber) + lowNumber)

            Console.WriteLine("Is your number " & guessedNumber & "?")
            Console.WriteLine("1. yes")
            Console.WriteLine("2. Too low")
            Console.WriteLine("3. Too high")

            userMessage = Console.ReadLine()

            If userMessage = "Yes" Or userMessage = "1" Or userMessage = "1. Yes" Then
                correct = True
                Console.WriteLine("Got it in " & numberOfGuesses & "tries")
            ElseIf userMessage = "Too low" Or userMessage = "2" Or userMessage = "2. Too low" Or userMessage = "low" Then
                lowNumber = lowNumber + 1
                highNumber = highNumber - 1
            ElseIf userMessage = "Too high" Or userMessage = "3" Or userMessage = "3. Too high" Or userMessage = "high" Then
                highNumber = highNumber - 1
            Else
                Console.WriteLine("Please enter one of the options, please.")
            End If
        Loop
    End Sub

End Module
