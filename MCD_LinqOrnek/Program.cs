using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_LinqOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Linq --> Language Integrated Query (Dil Entegre Edilmiş Sorgu)

            int[] sayilar = { 0, -2, 1, 3, 33, 44, 50, 101 };
            var tekler = from s in sayilar//nereden hangikoleksiyondan 
                         where s % 2 != 0//Where ile koşul belirttik
                         select s;//şarta uygun bir sayı varsa seç .
            Console.WriteLine("Sayılar dizisindeki tek sayılar");
            foreach (var item in tekler)//tekler biz dizi olarak oluşturuyor.
            {
                Console.WriteLine(item +" ");
            }
            Console.WriteLine("\n");
            //2. yötem
            //Tek satırda Linq
            var ciftler = sayilar.Where(x => x % 2 == 0);
            Console.WriteLine("Sayılardizindeki çift sayılar");
            foreach (var item in ciftler)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine("*********************");

            //Sıfırdan büyük olan çift sayıları getirsin
            ciftler.ToList().ForEach(x =>
            {
                if (x > 0)
                {
                    Console.WriteLine(x + " ");
                }
            });
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
