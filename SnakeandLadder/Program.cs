namespace SnakeandLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            int Pos = 0;
            Console.WriteLine("single player at start position :" + Pos);
            RollDice();
        }
         public static void RollDice()
        {
            Random random= new Random();
            int dice = random.Next(3);
            int dice = random.Next(1, 7);
            Console.WriteLine("Dice Num :" + dice);
        }
    }
}
