namespace Calc
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            var firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            var secondNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Результат: " + (firstNumber + secondNumber));
        }
    }
}