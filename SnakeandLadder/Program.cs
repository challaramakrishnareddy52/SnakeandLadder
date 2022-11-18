using System.Security.Cryptography.X509Certificates;

namespace SnakeandLadder
{
    class Program
    {
        private const int V = 0;

        static void Main(string[] args)
        {
            const int startPos = 0;
            int player1 = 0;
            int player2 = 0;
            int diceVal = 0;
            const int winPos = 100;
            int diceRole = 0;
            int currPlayer = 1;

            while (player1 < winPos && player2 < winPos)
            {
                playAgain:
                diceRole++;
                Random random = new Random();
                int dice = random.Next(1, 7);
                Console.WriteLine("Dice Num :" + dice);
                Random randomNum = new Random();
                int option = random.Next(0, 3);
                if (currPlayer == 1)
                {

                    switch (option)
                    {
                        case 0:
                            player1 += dice;
                            if (player1 > 100)
                            {
                                player1 = player1 - dice;
                            }
                            Console.WriteLine("ladder");
                            Console.WriteLine("currPos:" + player1);
                            if (player1 == 100)
                            {
                                Console.WriteLine("player1 wins : " + player1);
                                Console.WriteLine("diceRole:" + diceRole);
                            }
                            goto playAgain;
                            //break;
                        case 1:
                            player1 -= dice;
                            if (player1 < 0)
                            {
                                player1 = 0;
                            }
                            Console.WriteLine("Snake");
                            Console.WriteLine("currPos:" + player1);
                            currPlayer= 2;
                            break;
                        default:
                            Console.WriteLine("No Play");
                            Console.WriteLine("currPos:" + player1);
                            break;
                    }
                }
                else
                {
                    switch (option)
                    {
                        case 0:
                            player2 += dice;
                            if (player2 > 100)
                            {
                                player2 = player2 - dice;
                            }
                            Console.WriteLine("ladder");
                            Console.WriteLine("currPos:" + player2);
                            if (player2 == 100)
                            {
                                Console.WriteLine("player2 wins : " + player2);
                                Console.WriteLine("diceRole:" + diceRole);
                            }
                            goto playAgain;
                            //break;
                        case 1:
                            player2 -= dice;
                            if (player2 < 0)
                            {
                                player2 = 0;
                            }
                            Console.WriteLine("Snake");
                            Console.WriteLine("currPos:" + player2);
                            currPlayer = 1;
                            break;
                        default:
                            Console.WriteLine("No Play");
                            Console.WriteLine("currPos:" + player2);
                            break;
                    }
            }
               
            }

        }
    }
}


