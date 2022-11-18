using System.Security.Cryptography.X509Certificates;

namespace SnakeandLadder
{
    class Program
    {
        private const int V = 0;

        static void Main(string[] args)
        {
            const int startPos = 0;
            int currPos = 0;
            int diceVal = 0;
            const int winPos = 100;

            while (currPos < winPos)
            {
                Random random = new Random();
                int dice = random.Next(1, 7);
                Console.WriteLine("Dice Num :" + dice);
                Random randomNum = new Random();
                int option = random.Next(0, 3);
                switch (option)
                {
                    case 0:
                        currPos += dice;
                        if(currPos > 100)
                        {
                            currPos = currPos - dice;
                        }
                        Console.WriteLine("ladder");
                        Console.WriteLine("currPos:" + currPos);
                        break;
                    case 1:
                        currPos -= dice;
                        if(currPos<0)
                        {
                            currPos= 0;
                        }
                        Console.WriteLine("Snake");
                        Console.WriteLine("currPos:" + currPos);
                        break;
                    default:
                        Console.WriteLine("No Play");
                        Console.WriteLine("currPos:" + currPos);
                        break;
                }
            }

            Console.WriteLine("winPos : " + winPos);

        }
    }
}


