'Tic Tac Toe Game
'RCET0265 Fall 2021
'

Option Strict On
Option Explicit On
Option Compare Binary

'TODO:
'display game board console
'Player vs player
'evaluate win/draw
'new game, player turn, end game
'track wins per session (tournament play like best two out of three)

'Future:
'Allow choice of console game or graphical game (WinForm). web based asp.net if really ambitious
'

Module TicTacToe

    'gameboard array where the game data is stored. "X", "O", and ""
    Private gameboardData(2, 2) As String

    Sub Main()
        For i = 1 To 10
            Console.WriteLine($"It is {CurrentPlayer()}'s turn!")
        Next
        Console.ReadLine()
        Turn()
        Console.ReadLine()
    End Sub


    Function Winner() As String
        Dim _winner As String

        Return _winner
    End Function


    Private Function CheckCoulumns() As String

        Return ""
    End Function
    Private Function CheckRows() As String

        Return ""
    End Function

    Private Sub Turn()
        'This is very broke eventually it will be fixed
        If CurrentPlayer() = "X" Then
        ElseIf CurrentPlayer() = "O" Then
        End If
        Console.WriteLine()
    End Sub

    Private Sub DisplayGameBoard()

    End Sub
    ''' <summary>
    ''' sub resets gameboardData array to begin new game
    ''' </summary>
    ''' <param name="gameboardData"></param>
    Private Sub NewGame(ByRef gameboardData(,) As Boolean)
        For Row = 0 To 2
            For column = 0 To 2
                'sets the array gameboardData to clear all contents
                gameboardData(column, Row) = False
            Next
        Next
    End Sub
    ''' <summary>
    ''' toggle current player 
    ''' </summary>
    ''' <returns> "X" or "O" as string</returns>
    Private Function CurrentPlayer() As String
        Static _currentPlayer As String = "X"

        Select Case _currentPlayer
            Case "X"
                _currentPlayer = "O"
            Case Else
                _currentPlayer = "X"
        End Select

        Return _currentPlayer
    End Function
End Module
