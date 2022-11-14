using System.Security.Cryptography.X509Certificates;

namespace SnakeandLadder
{
    class Program
    {
        private const int V = 0;

        static void Main(string[] args)
        {
            int startPos = 0;
            int numofPlayers = 0;
            int currPos = 0;
            int diceVal = 0;


             static void RollDice(int numofPlayers)
             {
                Console.WriteLine("Enter Number Of Players");
                numofPlayers = Convert.ToInt32(Console.ReadLine());

                Random random = new Random();
                int dice = random.Next(1, 7);
                Console.WriteLine("Dice Num :" + dice);

                Random randomNum = new Random();
                int option = random.Next(1, 7);
                switch (option) 
                {
                    case 0:
                        Console.WriteLine("ladder");
                        break;
                    case 1:
                        Console.WriteLine("Snake");
                        break;
                    default:
                        Console.WriteLine("No Play");
                        break;
                }
            }
        }
    }
}
 
