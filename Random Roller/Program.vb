Imports System

Module Program
    
    Dim ReadOnly Modes As Object() = {"Roll a dice", "Flip a coin"}
    
    Private Sub RunMode(selection As Integer)
        'Use user selection to call intended subroutine.
        Select Case selection
            Case 1
                DiceRoll()
            Case 2
                CoinFlip()
        End Select
    End Sub
    
    Private Function RandomInt(lowerBound As Integer, upperBound As Integer) As Integer
        Dim randomSeed As New Random() 'Generate a new 'random seed'
        Dim randomValue As Integer = randomSeed.Next(lowerBound - 1, upperBound) + 1 'Adjust for weird random values
        Return randomValue
    End Function

    Private Sub DiceRoll()
        Dim randomValue As Integer = RandomInt(1, 6)
        Console.WriteLine($"You rolled a {randomValue}.")
    End Sub
    
    Private Sub CoinFlip()
        Dim randomFlip As Integer = RandomInt(1, 2)
        If randomFlip = 1 Then
            Console.WriteLine("You rolled heads.")
        Else
            Console.WriteLine("You rolled tails.")
        End If
    End Sub
    
    Sub Main(args As String())
        'Display the options from the _mode array.
        For i = 0 To Modes.GetUpperBound(0)
            Console.WriteLine($"{i + 1} | {Modes(i)}")
        Next
        Console.WriteLine()
        Do
            'Take user input. Loop until sanity is checked.
            Dim saneInput As Integer = -1
            Do
                Console.Write("Select an option: ")
                Dim input As String = Console.ReadLine()
                Dim inputParsed As Integer
                'Attempt to convert input to Integer
                If Integer.TryParse(input, inputParsed) Then
                    If inputParsed >= 1 And inputParsed <= Modes.GetUpperBound(0) + 1 Then
                        saneInput = inputParsed
                    End If
                End If
                If saneInput = -1 Then
                    Console.WriteLine("Please enter a valid selection.")
                End If
            Loop Until saneInput <> -1
            'User has entered a valid integer selection. Proceed.
            RunMode(saneInput)
            Console.WriteLine()
        Loop
    End Sub
    
End Module
