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
<<<<<<< HEAD
            int dice = random.Next(3);
=======
            int dice = random.Next(1, 7);
            dice = dice + 1;
>>>>>>> 98a3fdbac5a4ab7b2aa09101bfa4c68b64d04822
            Console.WriteLine("Dice Num :" + dice);
        }
    }
}
