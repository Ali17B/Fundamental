namespace tryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1- syntax error
            //2- runtime error (örn: 5/0 hatası)
            //3- mantıksal hatalar

            int sayi1, sayi2;
            Console.WriteLine("1. sayiyi giriniz:");
            sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("2. sayiyi giriniz:");
            sayi2 = int.Parse(Console.ReadLine());

            try
            {
                double bolum = sayi1 / sayi2;
                Console.WriteLine(bolum);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Sıfıra bölme hatası" + ex.Message);
            }


        }
    }
}
