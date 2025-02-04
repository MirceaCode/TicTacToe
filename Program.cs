using System.ComponentModel.Design;
using System.Diagnostics.Tracing;
using System.Numerics;
using System.Security.Cryptography;

public enum Player
{
    None,
    XPlayer = 1,
    OPlayer
}

class Program
{
    static Player[] vector = {     Player.None,     Player.None,     Player.None,
                                   Player.None,     Player.None,     Player.None,
                                   Player.None,     Player.None,     Player.None };
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
        printBoard();

        string input = Console.ReadLine();
        vector[Int32.Parse(input)] = Player.XPlayer;
        printBoard();
    }

    static string getPlayerAsString(Player p)
    {
        if (p == Player.None)
            return " ";
        else if (p == Player.XPlayer)
            return "x";
        else
            return "o";

    }
    static void printBoard()
    {

     
        Console.WriteLine("Do you require the first move? (y/n): ");
        string input = Console.ReadLine();


        if (input.Equals("y"))
        {
            Console.WriteLine("Hope you can beat me");
        }
        else if (input.Equals("n"))
        {
            Console.WriteLine("Very brave human...I will go first");
        }
     
        
        string firstLine = string.Format("{0}, {1}, {2}", getPlayerAsString(vector[0]), getPlayerAsString(vector[1]), getPlayerAsString(vector[2]));
        Console.WriteLine(firstLine);
        string secondLine = string.Format("{0}, {1}, {2}", getPlayerAsString(vector[3]), getPlayerAsString(vector[4]), getPlayerAsString(vector[5]));
        Console.WriteLine(secondLine);
        string thirdLine = string.Format("{0}, {1}, {2}", getPlayerAsString(vector[6]), getPlayerAsString(vector[7]), getPlayerAsString(vector[8]));
        Console.WriteLine(thirdLine);

    }

}