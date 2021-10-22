using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
           bool sistemegirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugün = 7.35;

            if (dolarDun>dolarBugün)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugün)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Eşittir Butonu");
            }



            if (sistemegirisYapmisMi=true)
            {
                Console.WriteLine("Kullanıcı giriş yapmış");
            }
            else
            {
                Console.WriteLine("Kullanıcı Giriş Yapmamış");
            }

        }
    }
}
