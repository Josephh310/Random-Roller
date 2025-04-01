Imports System

Module Program
    
    Dim ReadOnly Modes As Object() = {"Roll a dice", "Flip a coin"}

    Private Sub CoinFlip()
        Dim randomSeed As New Random()
        Dim randomValue As Integer = randomSeed.Next(0, 6) + 1
        Console.WriteLine($"You rolled a {randomValue}.")
    End Function
    
    Private Sub DiceRoll()
        Dim randomFlip As Integer = New Random().Next(0, 2) + 1
        If randomFlip = 1 Then
            Console.WriteLine("You rolled heads.")
        Else
            Console.WriteLine("You rolled tails.")
        End If
    End Function
    
    Sub Main(args As String())
        'Display the options from the _mode array.
        For i = 0 To Modes.GetUpperBound(0)
            Console.WriteLine($"{i + 1} | {Modes(i)}")
        Next
        'Take user input. Loop until sanity is checked.
        Dim saneInput As Integer = -1
        Do
            Console.WriteLine("Select an option: ")
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
        Select Case saneInput
            Case 1
                DiceRoll()
            Case 2
                CoinFlip()
        End Select
    End Sub
    
End Module
