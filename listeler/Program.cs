namespace listeler
{
    internal class Program
    {

        struct Adres
        {
            public string ulke;
            public string il;
            public string ilce;
            public string mahalle;
            public string cadde;
            public string sokak;
            public string kapiNo;
            public string postaKodu;

        }

        struct Otomobil
        {
            public string marka;
            public string model;
            public string kasaTipi;
            public string vitesTipi;
            public string yakitTipi;

        }



        static void Main(string[] args)
        {

            //Normal dizi tanımlaması
            int[] sayilar = new int[5];

            // Liste tanımlaması: generic bir yapıya sahiptir, sabit elemanlı değildir,
            // eleman sayısı dinamik olarak artar
            //Listeler, dizilere göre daha fazla kullanılır...
            List<int> sayilarListesi = new List<int>();
            for(int i = 0; i < 20; i++)
            {
                // Burası patlar
                //sayilar[i] = i;


                sayilarListesi.Add(i+1); //eleman ekleme
                sayilarListesi.Remove(i); //eleman silme
                sayilarListesi.Clear(); //tamamen içerik silme
                int kapasite = sayilarListesi.Capacity; //kapasite öğrenme
            }

            foreach(int i in sayilarListesi)
            {
                Console.WriteLine(i);
            }


        }
    }
}
