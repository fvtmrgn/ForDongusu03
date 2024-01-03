using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDongusu03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iki sayı arasındaki sayıları toplamak için alta sayıları giriniz:");
            Console.Write("ilk sayıyı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci sayıyı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Tek sayıları toplamak için 'tek', çift sayıları toplamak için 'çift' yazın: ");
            string secim = Console.ReadLine().ToLower();

            int toplam = 0 , b = 0;

            if (sayi > sayi1)
            {

                b = sayi;
                sayi = sayi1;
                sayi1 = b;

            }
           
            for (; sayi <= sayi1; sayi++)
            {
                if ((secim == "tek" && sayi % 2 == 1) || (secim == "çift" && sayi % 2 == 0))
                {
                    toplam += sayi;
                }
       

            }

             Console.WriteLine("Girilen sayılar arasındaki " + $"{(secim == "tek" ? "Tek" : "Çift")} sayıların toplamı: {toplam}");
        }
    }
}
