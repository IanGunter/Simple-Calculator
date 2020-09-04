'Ian Gunter
'RCET 0265
'Fall 2020
'SimpleCalculator
'https://github.com/IanGunter/Simple-Calculator.git


Option Explicit On
Option Strict On
Option Compare Text


Module SimpleCalculator


    Sub Main()
        Dim userInput, userInput2, userResponse As String
        Dim firstNumber, secondNumber As Integer
        Dim goodData As Boolean

        'Do loops restarts the program when it is finished.
        Do
            'Do loops Re-asks the question if input is bad data.
            Do

                Console.WriteLine("Choose a number or type Q to quit")

                'Try catch catches bad data and performs a do loop.
                Try

                    userInput = Console.ReadLine()

                    If userInput = "Q" Then
                        Exit Sub
                    End If
                    'CInt converts string to Decimal.
                    firstNumber = CInt(userInput)
                    Console.WriteLine("Choose another number.")

                    userInput2 = Console.ReadLine()
                    secondNumber = CInt(userInput2)

                    goodData = True
                Catch
                    goodData = False
                    Console.WriteLine("I can only handle numbers.")
                    Console.ReadLine()
                End Try

            Loop Until goodData = True

            'Do loop loops this section if the input is bad.
            Do
                Console.WriteLine("What would you like to do?")
                Console.WriteLine("1. Sum")
                Console.WriteLine("2. Product")
                userResponse = Console.ReadLine()

                'If statement chooses different events based upon user response.
                If userResponse = "1" Then

                    Console.WriteLine("Your answer: " & firstNumber + secondNumber)
                    Console.ReadLine()

                ElseIf userResponse = "2" Then
                    Console.WriteLine("Your answer: " & firstNumber * secondNumber)
                    Console.ReadLine()

                ElseIf userResponse <> "1" And userResponse <> "2" Then
                    Console.WriteLine("Human Error... Uhh try again....")
                    Console.ReadLine()


                End If

            Loop Until userResponse = "1" Or userResponse = "2"

            'Console.clear will clear the the console.
            Console.Clear

        Loop Until userInput = "Q"

    End Sub

End Module
