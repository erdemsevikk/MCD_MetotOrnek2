using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_MetotOrnek2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Bu uygulama örneğimizden toplam 4 adet metot kullanmaktayız. 
Bu kullandığımız metotların adları ise sırası ile; yiyecek, içecek, tatlılar ve hesap işlemlerini yerine getiren metotlardır. 
Uygulamamızı kullanan kullanıcılar uygulamayı açtıklarında karşılarına menü seçenekleri çıkıyor. 
Bu seçeneklerin seçimine ve toplam hesap bilgilerine göre metotlarımız devreye girip hesaplıyor. 
Sonucu da ekrana yazdırıyor. 
            */
            int total = 0;
            bool giris = true;
            while (giris)
            {
                Console.WriteLine("Menü:");
                Console.WriteLine("1-Yiyecek");
                Console.WriteLine("2-İçecek");
                Console.WriteLine("3-Tatlılar");
                Console.WriteLine("4-Hesap İşlemleri");

                int secim = Convert.ToInt32(Console.ReadLine());
                switch (secim)
                {
                    case 1:
                        total += Yiyecek();

                        break;
                    case 2:
                        total += İcecek();
                        break;

                    case 3:
                        total += Tatlı();
                        break;
                    case 4:
                        Hesap(total);
                        break;
                    default:
                        Console.WriteLine("Yanlış Değer Girdiniz.");
                        break;
                }

                

            }

        }
        public static int Yiyecek()
        {
            Console.WriteLine("İstediğiniz yemeğin numarasını giriniz: İstemiyorsanız başka numara giriniz:");
            Console.WriteLine("1 - Et yemeği: 50₺");
            Console.WriteLine("2 - Mantı: 40₺");
            Console.WriteLine("3 - Tavuk: 30₺");
            int yiyecek1 = Convert.ToInt32(Console.ReadLine());
            if (yiyecek1 == 1)
            {
                return 50;
            }

            else if (yiyecek1 == 2)
            {
                return 40;
            }

            else if (yiyecek1 == 3)
            {
                return 30;
            }

            else
            {
                return 0;
            }
        }

        public static int İcecek()
        {
            Console.WriteLine("İstediğiniz içeceğin numarasını giriniz: İstemiyorsanız başka numara giriniz:");
            Console.WriteLine("1 - Ayran: 5₺");
            Console.WriteLine("2 - Kola: 9₺");
            Console.WriteLine("3 - Limonata: 15₺");
            int yiyecek1 = Convert.ToInt32(Console.ReadLine());
            if (yiyecek1 == 1)
            {
                return 5;
            }

            else if (yiyecek1 == 2)
            {
                return 9;
            }

            else if (yiyecek1 == 3)
            {
                return 15;
            }

            else
            {
                return 0;
            }
        }

        public static int Tatlı()
        {
            Console.WriteLine("İstediğiniz tatlının numarasını giriniz:");
            Console.WriteLine("1 - Sütlaç : 20₺");
            Console.WriteLine("2 - Kazandibi: 25₺");
            Console.WriteLine("3 - Tavuk Göğsü: 15₺");
            int yiyecek1 = Convert.ToInt32(Console.ReadLine());
            if (yiyecek1 == 1)
            {
                return 20;
            }

            else if (yiyecek1 == 2)
            {
                return 25;
            }

            else if (yiyecek1 == 3)
            {
                return 15;
            }

            else
            {
                return 0;
            }
        }

        public static void Hesap(int toplam)
        {
            Console.WriteLine("Hesabınız: " + toplam);
            System.Threading.Thread.Sleep(2000);
            Environment.Exit(0);
        }
    }
}
