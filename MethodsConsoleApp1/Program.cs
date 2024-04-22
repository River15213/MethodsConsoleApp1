namespace MethodsConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание №1");
            Console.WriteLine("Введите текст через пробел: ");
            string inputText = Console.ReadLine();

            SplitTextAndPrint.PrintText(SplitTextAndPrint.SeparationText(inputText));

            Console.WriteLine("--------------------------");

            Console.WriteLine("Задание №2");

            SplitTextAndPrint.PrintText(ReversText.ReversWorld(SplitTextAndPrint.SeparationText(inputText)));



        }
    }
}
