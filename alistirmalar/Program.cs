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

            //int secim;
            //Console.WriteLine("Seçim yapınız: ");
            //Console.WriteLine("1-Metro-Vapur\n2-Metro-Metrobüs-Otobüs\n3-Marmaray Üsküdar-Vapur");
            //int kontor = 20;
            //secim = Convert.ToInt32(Console.ReadLine());


            //switch (secim)
            //{
            //    case 1:
            //        Console.WriteLine($"Metro-Vapur yaparsanız {1*kontor + 1*kontor} TL ödersiniz. (Gitgel: {(1 * kontor + 1 * kontor)*2}TL)");
            //        break;
            //    case 2:
            //        Console.WriteLine($"Metro-Metrobüs-Otobüs yaparsanız {1*kontor + 2*kontor + 1*kontor} TL ödersiniz. (Gitgel: {(1 * kontor + 2 * kontor + 1 * kontor) * 2}TL) ");
            //        break;
            //    case 3:
            //        Console.WriteLine($"Marmaray Üsküdar-Vapur yaparsanız {3*kontor + 1*kontor} TL ödersiniz. (Gitgel: {(3 * kontor + 1 * kontor) * 2}TL) ");
            //        break;
            //    default:
            //        Console.WriteLine("Hata");
            //        break;

            //}



            #endregion

            #region vize-final
            //Random rnd = new Random();
            //int[] vize1 = new int[20];
            //int[] vize2 = new int[20];
            //int[] final = new int[20];

            //for (int i = 0; i < vize1.Length; i++) { 
            //    vize1 [i] = rnd.Next(1,100);
            //}

            //for (int i = 0; i < vize1.Length; i++)
            //{
            //    vize2[i] = rnd.Next(1, 100);
            //}

            //for (int i = 0; i < vize1.Length; i++)
            //{
            //    final[i] = rnd.Next(1, 100);
            //}

            //foreach (int value in vize1) {
            //    Console.Write(value);
            //    Console.Write(",");

            //}
            //Console.WriteLine("*********Vize1'lerr");
            //foreach (int value in vize2)
            //{
            //    Console.Write(value);
            //    Console.Write(",");
            //}
            //Console.WriteLine("*********Vize2'lerr");
            //foreach (int value in final)
            //{
            //    Console.Write(value);
            //    Console.Write(",");
            //}
            //Console.WriteLine("*********Final'lerr");

            //int gecensayisi=0;
            //int kalansayisi=0;
            //for (int i = 0; i < vize1.Length; i++) {

            //    if(50<=((((vize1[i] + vize2[i]) / 2) * 0.3) + (final[i] * 0.7)))
            //    {
            //        Console.WriteLine($"Sınıftaki {i+1}.kişi {((((vize1[i] + vize2[i]) / 2.0) * 0.3) + (final[i] * 0.7)).ToString("#.##")} not ile geçti");
            //        gecensayisi++;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Sınıftaki {i+1}.kişi {((((vize1[i] + vize2[i]) / 2.0) * 0.3) + (final[i] * 0.7)).ToString("#.##")} not ile kaldı");
            //        kalansayisi++;
            //    }



            //}

            //Console.WriteLine($"Sınıfın % {(100*gecensayisi)/20} kadarı geçti, % {(100* kalansayisi) /20} kadarı kaldı.");


            #endregion

            #region sayisalLoto

            //int[] kazananNumaralar = new int[6];
            //int[] tahminEdilenNumaralar = new int[6];

            //Random rnd = new Random();

            //for (int i = 0; i < kazananNumaralar.Length; i++) { 

            //    kazananNumaralar[i] = rnd.Next(1,49);

            //}


            //Console.WriteLine("Kazanan Numaralar: ");
            //Console.WriteLine("-----------------------");
            //foreach (int value in kazananNumaralar) {

            //    Console.Write(value);
            //    Console.WriteLine(" ");
            //}
            //Console.WriteLine("-----------------------");

            //Console.WriteLine("6 tane tahmin gir: ");

            //for (int i = 0; i < tahminEdilenNumaralar.Length; i++) {

            //    tahminEdilenNumaralar[i] = int.Parse(Console.ReadLine());

            //}
            //Console.WriteLine("*****************");
            //foreach (int value in tahminEdilenNumaralar){

            //    Console.WriteLine(value);
            //}

            //int bulunanSayisi = 0;


            //for (int i = 0; i < kazananNumaralar.Length; i++) { 

            //    for (int j =0; j < tahminEdilenNumaralar.Length; j++)
            //    {
            //        if (kazananNumaralar == tahminEdilenNumaralar)
            //        {
            //            bulunanSayisi++;
            //        }

            //    }
            //}

            //if (0 < bulunanSayisi)
            //{
            //    Console.WriteLine($"{bulunanSayisi} tane sayıyı doğru tahmin ettiniz.");
            //}
            //else
            //{
            //    Console.WriteLine("Hiç doğru tahmin yapamadınız.");
            //}


            #endregion

            #region faktoriyel

            //int sayi;
            //Console.WriteLine("Faktoriyelini bulmak için sayı giriniz: ");
            //sayi = int.Parse(Console.ReadLine());
            //int carpim = 1;
            //for (int i = 1; i <= sayi; i++)
            //{

            //    carpim *= i;

            //}
            //Console.WriteLine($"Girilen sayının faktoriyeli {carpim}");


            #endregion

            #region sayibasamak

            //Console.WriteLine("Bir sayı giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Girdiğiniz sayının basamakları:");
            //int basamak = 1;

            //string basamakAdi = "";



            //while (sayi > 0)
            //{

            //    int sonBasamak = sayi % 10;

            //    sayi /= 10;


            //    switch (basamak)
            //    {
            //        case 1:

            //            basamakAdi = "Birler";
            //            Console.WriteLine($"{basamakAdi}. Basamağı: {sonBasamak}");
            //            break;
            //        case 2:
            //            basamakAdi = "Onlar";
            //            Console.WriteLine($"{basamakAdi}. Basamağı: {sonBasamak}");
            //            break;
            //        case 3:
            //            basamakAdi = "Yüzler";
            //            Console.WriteLine($"{basamakAdi}. Basamağı: {sonBasamak}");
            //            break;
            //        case 4:
            //            basamakAdi = "Binler";
            //            Console.WriteLine($"{basamakAdi}. Basamağı: {sonBasamak}");
            //            break;
            //        case 5:
            //            basamakAdi = "Onbinler";
            //            Console.WriteLine($"{basamakAdi}. Basamağı: {sonBasamak}");
            //            break;
            //        case 6:
            //            basamakAdi = "Yüzbinler";
            //            Console.WriteLine($"{basamakAdi}. Basamağı: {sonBasamak}");
            //            break;
            //        case 7:
            //            basamakAdi = "Milyonlar";
            //            Console.WriteLine($"{basamakAdi}. Basamağı: {sonBasamak}");
            //            break;
            //        case 8:
            //            basamakAdi = "Onmilyonlar";
            //            Console.WriteLine($"{basamakAdi}. Basamağı: {sonBasamak}");
            //            break;
            //        default:
            //            Console.WriteLine("hata");
            //            break;

            //    }
            //    basamak++;

            //}

            #endregion

            #region sayibasamak+yaziyla

            //Console.WriteLine("Bir sayi giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //string[] birler = { "", "Bir", "İki", "Üç", "Dört", "Beş", "Altı", "Yedi", "Sekiz", "Dokuz" };
            //string[] onlar = { "", "On", "Yirmi", "Otuz", "Kırk", "Elli", "Altmış", "Yetmiş", "Seksen", "Doksan" };

            //Console.WriteLine("sayının basamakları:");
            //int basamak = 1;
            //string basamakAdi = "";
            //string yaziylaSayi = "";

            //while (sayi > 0)
            //{
            //    int sonBasamak = sayi % 10;

            //    switch (basamak)
            //    {
            //        case 1:
            //            basamakAdi = "Birler";
            //            break;
            //        case 2:
            //            basamakAdi = "Onlar";
            //            break;
            //        case 3:
            //            basamakAdi = "Yüzler";
            //            break;
            //        case 4:
            //            basamakAdi = "Binler";
            //            break;
            //        case 5:
            //            basamakAdi = "Onbinler";
            //            break;
            //        case 6:
            //            basamakAdi = "Yüzbinler";
            //            break;
            //        case 7:
            //            basamakAdi = "Milyonlar";
            //            break;
            //        case 8:
            //            basamakAdi = "Onmilyonlar";
            //            break;
            //        default:
            //            basamakAdi = "Bilinmeyen";
            //            break;
            //    }

            //    Console.WriteLine($"{basamakAdi} Basamağı: {sonBasamak}");

                
            //    if (basamak == 1) 
            //        yaziylaSayi = birler[sonBasamak] + yaziylaSayi;
            //    else if (basamak == 2) 
            //        yaziylaSayi = onlar[sonBasamak] + yaziylaSayi;
            //    else if (basamak == 3) 
            //        yaziylaSayi = (sonBasamak > 0 ? birler[sonBasamak] + "Yüz" : "") + yaziylaSayi;
            //    else if (basamak == 4) 
            //        yaziylaSayi = (sonBasamak > 0 ? birler[sonBasamak] + "Bin" : "") + yaziylaSayi;
            //    else if (basamak == 5 || basamak == 6 || basamak == 7 || basamak == 8) 
            //        yaziylaSayi = (sonBasamak > 0 ? birler[sonBasamak] : "") + yaziylaSayi;

            //    sayi /= 10;
            //    basamak++;
            //}

            //Console.WriteLine("\nSayının yazı karşılığı: " + yaziylaSayi);


            #endregion

            #region carpitablosu

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.WriteLine($"{i} x {j} = {i*j}");

            //    }
            //    Console.WriteLine("-------------------------");

            //}

            #endregion




        }
    }
}
