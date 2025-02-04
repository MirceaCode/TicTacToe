using System;

public enum Player
{
    None,
    XPlayer = 1,
    OPlayer
}

class Program
{
    static Player[] vector = { Player.None, Player.None, Player.None,
                               Player.None, Player.None, Player.None,
                               Player.None, Player.None, Player.None };

    static void Main()
    {
        Console.WriteLine("Welcome to Tic-Tac-Toe.");
        Console.WriteLine("You will make your move know by entering a number, 0 - 8.\nThe number will correspond to the board position as illustrated:\n");

        Console.WriteLine("0 | 1 | 2");
        Console.WriteLine("---------");
        Console.WriteLine("3 | 4 | 5");
        Console.WriteLine("---------");
        Console.WriteLine("6 | 7 | 8");
        Console.WriteLine("---------");

        Console.WriteLine("Do you require the first move? (y/n): ");
        string input = Console.ReadLine();

        Player currentPlayer = input.Equals("y") ? Player.XPlayer : Player.OPlayer;

        Console.WriteLine(currentPlayer == Player.XPlayer ? "Hope you can beat me" : "Very brave human...I will go first");

        printBoard();

        while (true)
        {
            Console.WriteLine($"Player {(currentPlayer == Player.XPlayer ? "X" : "O")}'s turn. Enter where you want to put your move (0-8): ");
            string stringInput = Console.ReadLine();

            if (int.TryParse(stringInput, out int move) && move >= 0 && move <= 8 && vector[move] == Player.None)
            {
                vector[move] = currentPlayer;
                printBoard();

                currentPlayer = (currentPlayer == Player.XPlayer) ? Player.OPlayer : Player.XPlayer;
            }
            else
            {
                Console.WriteLine("Invalid move. Try again.");
            }
        }
    }

    static string getPlayerAsString(Player p)
    {
        if (p == Player.None)
            return " ";
        else if (p == Player.XPlayer)
            return "X";
        else
            return "O";
    }

    static void printBoard()
    {
        string firstLine = string.Format("{0} | {1} | {2}", getPlayerAsString(vector[0]), getPlayerAsString(vector[1]), getPlayerAsString(vector[2]));
        Console.WriteLine(firstLine);
        string secondLine = string.Format("{0} | {1} | {2}", getPlayerAsString(vector[3]), getPlayerAsString(vector[4]), getPlayerAsString(vector[5]));
        Console.WriteLine(secondLine);
        string thirdLine = string.Format("{0} | {1} | {2}", getPlayerAsString(vector[6]), getPlayerAsString(vector[7]), getPlayerAsString(vector[8]));
        Console.WriteLine(thirdLine);
    }
}
