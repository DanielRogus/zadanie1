namespace Zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Przeczytaj = File.ReadAllText("C:/test/test_daniel_rogus.txt");
            Console.WriteLine("Tekst z pliku: " + Przeczytaj);
            Console.WriteLine("Ilość litery a w pliku: " + Przeczytaj.Count(s => s == 'a'));
        }
    }
}
