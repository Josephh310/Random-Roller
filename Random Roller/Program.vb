Imports System

Module Program
    
    Dim _modes As Object(,) = {{"Roll a dice", DiceRoll}, {"Flip a coin", Coinflip}}
    
    Private Function DiceRoll()
        
    End Function
    
    Private Function CoinFlip()
        
    End Function

    Sub Main(args As String())
        'Display the options from the _mode array.
        For i = 0 To _modes.GetUpperBound(0)
            Console.Write($"{i} | ")
            Console.WriteLine(_modes(i, 0))
        Next
    End Sub
    
End Module
