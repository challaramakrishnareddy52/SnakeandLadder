using System.Security.Cryptography.X509Certificates;

namespace SnakeandLadder
{
    class Program
    {
        private const int V = 0;

        static void Main(string[] args)
        {
           const int startPos = 0;
           const int numofPlayers = 2;
           const int currPos = 0;
           const int diceVal = 0;
           const int winPos = 100;


             static void RollDice(int numofPlayers,int currPos)
             {
                Console.WriteLine("Enter Number Of Players");
                numofPlayers = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter winning Position");
               int winPos = Convert.ToInt32(Console.ReadLine());

                Random random = new Random();
                int dice = random.Next(1, 7);
                Console.WriteLine("Dice Num :" + dice);

                Random randomNum = new Random();
                int option = random.Next(1, 7);
                switch (option) 
                {
                    case 0:
                        currPos += dice;
                        Console.WriteLine("ladder");
                        break;
                    case 1:
                        currPos += dice;
                        Console.WriteLine("Snake");
                        break;
                    default:
                        Console.WriteLine("No Play");
                        break;
                }
                winPos= currPos * numofPlayers;
                Console.WriteLine("winPos : " +winPos);

            }
            Console.WriteLine("numofPlayers : " +numofPlayers); 
        }
    }
}
 
