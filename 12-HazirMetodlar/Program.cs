namespace _12_HazirMetodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region String Hazir Methodlar




            string cumle = "SOLID yazılım prensipleri; geliştirilen yazılımın esnek, yeniden kullanılabilir, sürdürülebilir ve anlaşılır olmasını sağlayan, kod tekrarını önleyen ve Robert C. Martin tarafından öne sürülen prensipler bütünüdür.";

            //Cümlenin uzunluğunu bulma
            Console.WriteLine("Cümlenin uzunluğu: " + cumle.Length + " karakterdir. ");

            Console.WriteLine(cumle[0]);

            //prensipler kelimesinin indexi nedir? (index cümle içerisindeki sütun numarasını verir)
            Console.WriteLine(cumle.IndexOf("prensipler"));

            //split methodu : cümle içerisinde belirtilen karakter ile parçalama yapar
            string[] cumleler = cumle.Split('.');
            foreach (string s in cumleler)
            {
                Console.WriteLine(s);
            }


            //Replace methodu: orjinal metni değiştirmez, orjinal metnin değiştirilmiş versiyonunu bize verir.

            string yeniCumle = cumle.Replace("prensip", "Aliciğim");
            Console.WriteLine(yeniCumle);
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            //Substring: cümle içinden cımbızlama yapmamıza yarar, istediğimiz şeyi çeker
            Console.WriteLine(cumle.Substring(6));//6. indeksten başlayarak sonrasını alır
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine(cumle.Substring(6,7));//6. indeksten başlayarak 7 indeks alır


            //SOLID kelimesinin cümlede kaçıncı indekste olduğunu bulalım:
            string kelime = "SOLID";
            int indeks = cumle.IndexOf(kelime);
            string bulunan = cumle.Substring(indeks, kelime.Length);
            Console.WriteLine($"{kelime} cümle içerisinde {indeks} indexten başlar ve uzunluğu {kelime.Length} dir.");

            //Gerçek hayattaki kullanım yeri:
            //Örneğin çağrı merkezinde tcno nun son 3 hanesi ve anne kızlık soyadının 2. ve 4. harfini ekrana yazdırmak:
            string tcno = "12312312311";
            string anneKizlikSoyadi = "Gunes";


            Console.WriteLine($"Tc'nin son 3 hanesi: {tcno.Substring(7)} ve Anne Kizlik soyadinin 2. harfi: {anneKizlikSoyadi[1]} 4. harfi: {anneKizlikSoyadi[3]}");


            #endregion


            #region IsNullOrEmpty


            //Gelen verinin nul ya da boş olup olmadığını kontrol eder.

            string deger = "";
            if (string.IsNullOrEmpty(deger))
            {
                Console.WriteLine("gelen değer boş ya da null'dır.");
            }
            else 
            {
                Console.WriteLine("Gelen değer: " + deger);
            }

            //ToLower ve ToUpper
            string cumle2 = "Bugun günlerden sali";
            Console.WriteLine(cumle2.ToUpper());
            Console.WriteLine(cumle2.ToLower());


            //Insert ve Remove
            string cumle3 = "Bugün günlerden salı";
            //cümlesinin sonuna "hava çok güzel" cümlesini ekleyelim
            Console.WriteLine(cumle3.Insert(cumle3.Length, " hava çok güzel"));
            Console.WriteLine(cumle3.Insert(cumle3.IndexOf("günlerden"), DateTime.Now.ToShortDateString()+" ve "));



            #endregion


            #region matematik sınıfları


            Console.WriteLine($"2 üzeri 3: {Math.Pow(2,3)}");
            Console.WriteLine($"karekök 16: {Math.Sqrt(16)}");
            Console.WriteLine($"küpkök 8: {Math.Pow(8,1/3.0)}");
            Console.WriteLine($"pi sayısı: {Math.PI}");
            Console.WriteLine($"10,4'ün yuvarlanmış hali (üste yuvarlama): {Math.Ceiling(10.4)}");
            Console.WriteLine($"10,4'ün yuvarlanmış hali (aşağı yuvarlama): {Math.Floor(10.4)}");
            Console.WriteLine($"10,4'ün yuvarlanmış hali (0.5 in altını alta üstünü üste yuvarlar): {Math.Round(10.4)}");


            #endregion

            #region odev

            // 1- girilen e mail adresinin düzgün bir formatta olup olmadığını belirleyelim
            // strging email = ali@gmail.com.tr
            //2- bir forum sitesinde olduğumuzu düşünelim, kullanıcı bir içerik girdiğinde yasakli kelimeleri sansürleyelim
            #endregion

        }
    }
}
