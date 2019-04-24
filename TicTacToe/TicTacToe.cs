using System;

namespace TicTacToe
{
    class Program
    {
        public static string playerTurn = "";
        public static string[][] board = new string[][]
        {
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "}
        };

        public static void Main()
        {
            do
            {
                DrawBoard();
                GetInput();

            } while (!CheckForWin() && !CheckForTie());

            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }

        public static void GetInput()
        {
            Console.WriteLine("Player " + playerTurn);
            Console.WriteLine("Enter Row:");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Column:");
            int column = int.Parse(Console.ReadLine());
        }

        public static void PlaceMark(int row, int column)
        {
        // your code goes here

        //grabs the position from user input and places the x or o in the correct space

        
        }

        public static bool CheckForWin()
        {
            // your code goes here

            if (HorizontalWin = true)
            {
                return true;
            }else if ( VerticalWin = true){
                return true;
            }else if (DiagonalWin = true){
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool CheckForTie()
        {
            // your code goes here

            // get input can't take anymore input return true

            return false;
        }
        
        public static bool HorizontalWin()
        {
        // your code goes here

        // 0: 0,1,2
        // 1: 0,1,2
        // 2: 0,1,2

        if(board[0][0] == board[0][1] && board[0][1] == board[0][2]){
            return true;
        }else if(board[1][0] == board[1][1] && board[1][1] == board[1][2]){
            return true;
        }else if(board[2][0] == board[2][1] && board[2][1] == board[2][2]){
            return true;
        }else{
            return false;
        }
        

        
        }

        public static bool VerticalWin()
        {
            // your code goes here

            // 0:0 , 1:0 , 2:0
            // 0:1 , 1:1 , 2:1
            // 0:2 , 1:2 , 2:2

            return false;
        }

        public static bool DiagonalWin()
        {
            // your code goes here

            // 0:0 , 1:1 , 2:2
            // 0:2 , 1:1 , 2:0

            return false;
        }

        public static void DrawBoard()
        {
            Console.WriteLine("  0 1 2");
            Console.WriteLine("0 " + String.Join("|", board[0]));
            Console.WriteLine("  -----");
            Console.WriteLine("1 " + String.Join("|", board[1]));
            Console.WriteLine("  -----");
            Console.WriteLine("2 " + String.Join("|", board[2]));
        }
    }
}
