
// TikTakToe Game by Keegan Smith
// Created for Practice to Learn C#
// 11/14/2024

using System.Threading.Tasks.Dataflow;
using System;
using System.ComponentModel;
using System.Security;
class Program {
    // prints the board
    public static void PrintBoard(int[,] gameboard) {
        Console.WriteLine("-----");
        for (int i = 0; i < gameboard.GetLength(0); i++) { 
            Console.Write("|");
            for (int j = 0; j < gameboard.GetLength(1); j++) { 
                Console.Write(gameboard[i, j]); 
            } 
            Console.WriteLine("|");
        }
        Console.WriteLine("-----");
    } 
    // gameloop
    // handles most game functions
    public static void GameLoop(String player1, String player2) {
        int[,] board = {{0,0,0},{0,0,0},{0,0,0}};
        Boolean win = false;
        Boolean win2 = false;
        while (win == false) {
            PrintBoard(board);
            // Player 1 Turn
            Console.WriteLine(player1 + "'s turn!");
            Console.WriteLine("Enter Position: ");
            String input = Console.ReadLine();
            char a = input[0];
            char b = input[1];
            int x = a - '0';
            int y = b - '0';
            board[x,y] = 1;
            win = checkwin(board, 1);
            
            if (win == true) {
                Console.WriteLine(player1 + " wins!!!");
                break;
            }
            PrintBoard(board);

            // Player 2 Turn
            Console.WriteLine(player2 + "'s turn!");
            Console.WriteLine("Enter Position: ");
            String input2 = Console.ReadLine();
            char c = input2[0];
            char d = input2[1];
            int x2 = c - '0';
            int y2 = d - '0';
            board[x2,y2] = 2;
            win = checkwin(board, 2);
              if (win == true) {
                Console.WriteLine(player2 + " wins!!!");
                break;
                }
        }


    } 
    //checks if a player has won
    public static Boolean checkwin(int[,] gameboard, int playcheck) {
        // horizontal win check
        for(int i = 0; i < gameboard.GetLength(0); i++) {
            // horizontal
                if ( gameboard[i,0] == playcheck && gameboard[i,1] == playcheck && gameboard[i,2] == playcheck) {
                    return true;
                }
            // vertical
                if ( gameboard[0,i] == playcheck && gameboard[1,i] == playcheck && gameboard[2,i] == playcheck) {
                    return true;
                }
            // diagonal 1
                if ( gameboard[0,0] == playcheck && gameboard[1,1] == playcheck && gameboard[2,2] == playcheck) {
                    return true;
                }
            // diagonal 2
                if ( gameboard[0,2] == playcheck && gameboard[1,1] == playcheck && gameboard[2,0] == playcheck) {
                    return true;
                }
                else {
                     return false;
                }
            }
        return false;
    }
    public static void Main() {
        // StartUp
        Console.WriteLine("Welcome to TikTakToe!");
        Console.WriteLine("Enter Player 1 Name: ");
        String Player1 = Console.ReadLine();
        Console.WriteLine("Enter Player 2 Name: ");
        String Player2 = Console.ReadLine();
        GameLoop(Player1,Player2);
    }
}
