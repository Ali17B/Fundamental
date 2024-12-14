namespace FirsConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dünyaya merhabalarrrss");
            Console.Write("1. sayıyı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            topla(sayi1, sayi2);


        }

        static void topla(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}
