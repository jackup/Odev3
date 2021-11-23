using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bu uygulama örneğimizden toplam 4 adet metot kullanmaktayız.
            //Bu kullandığımız metotların adları ise sırası ile; yiyecek, içecek, tatlılar ve hesap işlemlerini yerine getiren metotlardır.
            //Uygulamamızı kullanan kullanıcılar uygulamayı açtıklarında karşılarına menü seçenekleri çıkıyor.
            //Bu seçeneklerin seçimine ve toplam hesap bilgilerine göre metotlarımız devreye girip hesaplıyor. 
            //Sonucu da ekrana yazdırıyor.


            //Console.WriteLine("İstediğiniz yemeğin numarasını giriniz:");
            //Console.WriteLine("1 - Et yemeği");
            //Console.WriteLine("2 - Mantı");
            //Console.WriteLine("3 - Tavuk");


            //Console.WriteLine("İstediğiniz içeceğin numarasını giriniz:");
            //Console.WriteLine("1 - Ayran");
            //Console.WriteLine("2 - Kola");
            //Console.WriteLine("3 - Limonata");

            //Console.WriteLine("İstediğiniz tatlının numarasını giriniz:");
            //Console.WriteLine("1 - Sütlaç");
            //Console.WriteLine("2 - Kazandibi");
            //Console.WriteLine("3 - Tavuk Göğsü");

            Console.WriteLine("Restaurant'ımıza hoşgeldiniz.");
            Restaurant musteri = new Restaurant();
            //musteri.Yemekler();
            //musteri.Icecekler();
            //musteri.Tatlılar();
            musteri.Hesap();

            

            
        }
        //static int Hesap()
        //{
        //    int hesap = ;

        //    return hesap;
        //}
    }
    class Restaurant
    {
        public int Yemekler()
        {
            Console.WriteLine("İstediğiniz yemeğin numarasını giriniz:");
            Console.WriteLine("1 - Et yemeği");
            Console.WriteLine("2 - Mantı");
            Console.WriteLine("3 - Tavuk");
            int yemek = int.Parse(Console.ReadLine());
            int fiyat = yemek == 1 ? 35 : yemek == 2 ? 25 : yemek == 3 ? 30 : 0;
            if (fiyat == 0)
            {
                Console.WriteLine("Yanlış Değer Girdiniz.");
                return 0;
            }

            else
            {
                Console.WriteLine("Yemeğinizin ücreti : " + fiyat);
                return fiyat;
            }
        }
        public int Icecekler()
        {
            Console.WriteLine("İstediğiniz içeceğin numarasını giriniz:");
            Console.WriteLine("1 - Ayran");
            Console.WriteLine("2 - Kola");
            Console.WriteLine("3 - Limonata");
            int icecek = int.Parse(Console.ReadLine());
            int fiyat = icecek == 1 ? 5 : icecek == 2 ? 10 : icecek == 3 ? 15 : 0;
            if (fiyat == 0)
            {
                Console.WriteLine("Yanlış Değer Girdiniz.");
                return 0;
            }

            else
            {
                Console.WriteLine("İçeceğinizin ücreti : " + fiyat);
                return fiyat;
            }
                

        }
        public int Tatlılar()
        {
            Console.WriteLine("İstediğiniz tatlının numarasını giriniz:");
            Console.WriteLine("1 - Sütlaç");
            Console.WriteLine("2 - Kazandibi");
            Console.WriteLine("3 - Tavuk Göğsü");
            int tatli = int.Parse(Console.ReadLine());
            int fiyat  = tatli == 1 ? 15 : tatli == 2 ? 20 : tatli == 3 ? 10 : 0;
            if (fiyat == 0)
            {
                Console.WriteLine("Yanlış Değer Girdiniz.");
                return 0;
            }

            else
            {
                Console.WriteLine("Tatlınızın ücreti : " + fiyat);
                return fiyat;
            }
        }
        public int Hesap()
        {
            int hesap = Tatlılar() + Icecekler() + Yemekler();
            Console.WriteLine("Hesabınız {0} TL dir.", hesap);
            return hesap;
        }
    }
}
