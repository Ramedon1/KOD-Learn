namespace RandomGame
{
    class RandomGame
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var randNum  = rnd.Next(1, 100);
            
            Console.WriteLine("Угадай число от 1 до 100:");
            
            var userNumber = Convert.ToInt32(Console.ReadLine());
            
            while (userNumber != randNum)
            {
                if (userNumber > randNum)
                    Console.WriteLine("Загаданное число меньше чем твоё");
                else
                    Console.WriteLine("Загаданное число больше чем твоё");
            
                Console.WriteLine("Попробуй еще раз:");
                
                userNumber = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Поздравляю, ты угадал!");
            
        }
    }
}