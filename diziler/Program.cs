using Bogus;

namespace diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region dizi
            string[] isimsoyisim = new string[15];
            string[] e_mail = new string[15];
            string[] cepT = new string[15];
            string[] yas = new string[15];



            Faker fk = new Faker("tr");

            isimsoyisim[0] = "Ali balamurr";
            e_mail[0] = "ali.b@gmail.com";
            cepT[0] = "05555895";
            yas[0] = "23";

            isimsoyisim[1] = "Eren T";
            e_mail[1] = "erent@hotmail.com";
            cepT[1] = "057874545";
            yas[1] = "27";


            isimsoyisim[2] = fk.Person.FirstName;
            e_mail[2] = fk.Person.Email;
            cepT[2] = fk.Person.Phone;
            yas[2] = fk.Person.DateOfBirth.ToString();




            Console.WriteLine("Ogrenci bilgileri:");
            Console.WriteLine("----------------------------------------------------------");


            for (int i = 0; i <= 14; i++)
            {

                //Console.WriteLine($"İsim Soyisim: {isimsoyisim[i]}, email: {e_mail[i]}, Cep: {cepT[i]}, Yas: {yas[i]}");

                if (isimsoyisim[i] != null && e_mail[i] != null && cepT[i] != null && yas[i] != null)
                {
                    Console.WriteLine($"İsim Soyisim: {isimsoyisim[i]}, email: {e_mail[i]}, Cep: {cepT[i]}, Yas: {yas[i]}");
                }
            }


            Ogrenci ogr = new Ogrenci();

            ogr.isimSoyisim = "ismail";

            #endregion



        }
        #region struct
        struct Ogrenci
        {
            public string isimSoyisim;
            public string e_mail;
            public string cepT;
            public string yas;



        } 
        #endregion
    }
}





