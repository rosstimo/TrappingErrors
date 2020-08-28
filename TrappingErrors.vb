Option Strict On
Option Explicit On
Option Compare Binary

Module TrappingErrors

    Sub Main()
        Dim userInput As String
        Dim userNumber As Integer


        'While userInput <> "Q" And userInput <> "q"
        Do

            Console.WriteLine("Type a number and press enter. Enter Q to quit.")
            userInput$ = Console.ReadLine()

            Try
                'try to convert user input from string to integer
                userNumber% = CInt(userInput$)
                Console.WriteLine(userInput & " + 5 is:")
                Console.WriteLine(userNumber% + 5)
            Catch ex As InvalidCastException
                Console.WriteLine("I asked for a number... You entered: " & userInput)
            Catch ex As OverflowException
                Console.WriteLine(userInput & " is too big!!")
            Catch ex As Exception
                Console.WriteLine("You broke it!!!")
                Console.WriteLine(ex.Message)
            Finally
                'always runs
            End Try

        Loop Until userInput$ = "Q" Or userInput$ = "q"
        'End While


        Console.ReadLine()
    End Sub

End Module
