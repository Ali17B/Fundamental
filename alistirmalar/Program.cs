namespace alistirmalar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region switch
            //Console.WriteLine("Bir Sayı giriniz: ");
            //int sayi = int.Parse(Console.ReadLine());
            //int secim;
            //Console.WriteLine("Seçim yapınız:\n1-Karesi\n2-Küp\n3-Karekök\n4-Faktöriyel");
            //secim = int.Parse(Console.ReadLine());


            //int faktoriyel(int sayi)
            //{
            //    int fakt = 1;
            //    for (int x = 1; x <= sayi; x++)
            //    {
            //        fakt *= x;
            //    }
            //    return fakt;
            //}

            //switch (secim)
            //{
            //    case 1:
            //        Console.WriteLine($"Girdiğiniz sayının karesi: {sayi * sayi}");
            //        break;
            //    case 2:
            //        Console.WriteLine($"Girdiğiniz sayının küpü: {sayi * sayi * sayi}");
            //        break;
            //    case 3:
            //        Console.WriteLine($"Girdiğiniz sayının karekökü: {Math.Sqrt(sayi)}");
            //        break;
            //    case 4:
            //        Console.WriteLine($"Girdiğiniz sayının faktöriyeli: {faktoriyel(sayi)}");
            //        break;
            #endregion


            #region arachizhesabi
            //Console.WriteLine("Arabanın hızını giriniz (KM/H cinsinden): ");
            //double hiz = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Arabanın gideceği mesafeyi giriniz (KM cinsinden): ");
            //double mesafe = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Arabadaki yakıt durumunu giriniz (LT cinsinden): ");
            //double yakit = Convert.ToDouble(Console.ReadLine());

            //double sure = mesafe / hiz;

            //double yakacakyakit=(5 / 100.0) * mesafe;


            //Console.WriteLine($"Araba bu hızda, bu mesafeyi {sure * 60} dakikada gider.");
            //if(yakacakyakit <= yakit)
            //{
            //    Console.WriteLine("yakıt yeterli");
            //}
            //else
            //{
            //    Console.WriteLine($"yakıt yetersiz {yakit - yakacakyakit} kadar eksiktir");
            //}

            //Console.WriteLine($"Araba {mesafe} km'de {yakacakyakit} kadar yakıt harcar");






            #endregion

            #region ist-izmir


            //double harcanacakLitre = (564 * 5) / 100;
            //double tekGidisUcreti = 1360 + (harcanacakLitre * 45);
            //Console.WriteLine($"İstanbul izmir arası seyahatte gidiş-geliş {tekGidisUcreti * 2} TL para harcarız. ");


            #endregion


            #region kartal-besiktas

            int secim;
            Console.WriteLine("Seçim yapınız: ");
            Console.WriteLine("1-Metro-Vapur\n2-Metro-Metrobüs-Otobüs\n3-Marmaray Üsküdar-Vapur");
            int kontor = 20;
            secim = Convert.ToInt32(Console.ReadLine());

            
            switch (secim)
            {
                case 1:
                    Console.WriteLine($"Metro-Vapur yaparsanız {1*kontor + 1*kontor} TL ödersiniz. (Gitgel: {(1 * kontor + 1 * kontor)*2}TL)");
                    break;
                case 2:
                    Console.WriteLine($"Metro-Metrobüs-Otobüs yaparsanız {1*kontor + 2*kontor + 1*kontor} TL ödersiniz. (Gitgel: {(1 * kontor + 2 * kontor + 1 * kontor) * 2}TL) ");
                    break;
                case 3:
                    Console.WriteLine($"Marmaray Üsküdar-Vapur yaparsanız {3*kontor + 1*kontor} TL ödersiniz. (Gitgel: {(3 * kontor + 1 * kontor) * 2}TL) ");
                    break;
                default:
                    Console.WriteLine("Hata");
                    break;

            }



            #endregion


        }
    }
}
