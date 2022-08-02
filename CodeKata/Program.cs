namespace CodeKata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, insert: true for positive or false for negative:");
            var userAnswer = bool.Parse(Console.ReadLine());
            Console.WriteLine(BoolToWord.ConvertBoolToWord(userAnswer));
            var userAnswer2 = bool.Parse(Console.ReadLine());
            Console.WriteLine(BoolToWord.ConvertBoolToWord(userAnswer2));
        }
    }
}