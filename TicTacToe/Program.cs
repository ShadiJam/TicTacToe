using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeStarter
{
    class Program
    {

        static string[] board = { " ", " ", " ",
                                  " ", " ", " ",
                                  " ", " ", " " };

        static int counter = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("> Let's play a game.");
            PrintBoard();
            Turn();
            Console.ReadLine();
        }

        static void Turn()
        {

            Console.WriteLine("> Enter a spot. \"x,y\"");
            char[] delim = { ',' };
            Random rnd = new Random();
            int compChoice = rnd.Next(0, 8);
            string[] positions = Console.ReadLine().Split(delim); // --> "1,2" -> ["1", "2"]
            List<int> xPlays = new List<int>();
            List<int> oPlays = new List<int>();
            int x = Int32.Parse(positions[0]);
            int y = Int32.Parse(positions[1]);
            int index = GetIndex(x, y);
            if ((x > 0 && x <= 3) && (y > 0 && y <= 3))
            {
                board[index] = "X";
                counter += 1;
            }
            else
            {
                Console.WriteLine("Invalid Input. Please try again!");
            }
            PrintBoard();
            Console.WriteLine(counter);
            if (counter % 2 == 0)
            {
                xPlays.Add(index);

            } else
            {
                oPlays.Add(index);
            }
            Turn();
            
            }

        static int GetIndex(int x, int y)
        {
            return (x - 1) + (y - 1) * 3;
        }
         

static void PrintBoard()
        {
            Console.WriteLine("---------");
            Console.WriteLine("| {0} | {1} | {2} |", board[0], board[1], board[2]);
            Console.WriteLine("| {0} | {1} | {2} |", board[3], board[4], board[5]);
            Console.WriteLine("| {0} | {1} | {2} |", board[6], board[7], board[8]);
            Console.WriteLine("---------");
        }

        static void PromptForInput()
        {

        }

        
    }
}