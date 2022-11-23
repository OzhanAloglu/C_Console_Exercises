using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Hesap makinesi uygulaması
            //**********************HESAP MAKİNESİ * ****************************
            //int toplama, çıkarma, çarpma, bölme;
            //Console.WriteLine("Hesap Makinesi uygulamasına hoşgeldiniz.");
            //Console.WriteLine("İlk sayı:");
            //int hesap = Convert.ToInt32(Console.ReadLine().ToLower());
            //Console.WriteLine("İkinci sayı:");
            //int hesap2 = Convert.ToInt32(Console.ReadLine().ToLower());
            //Console.WriteLine("Yapmak istediğiniz işlem nedir?  " + "\n" + "toplama" + "\n" + "çıkarma" + "\n" + "çarpma" + "\n" + "bölme");
            //string islem = Console.ReadLine();

            //toplama = hesap + hesap2;
            //çıkarma = hesap - hesap2;
            //çarpma = hesap * hesap2;
            //bölme = hesap / hesap2;

            //if (islem == "toplama")
            //{
            //    Console.WriteLine("Toplama sonucu=" + toplama);
            //}
            //else if (islem == "çıkarma")
            //{
            //    Console.WriteLine("çıkarma sonucu=" + çıkarma);
            //}
            //else if (islem == "çarpma")
            //{
            //    Console.WriteLine("çarpma sonucu=" + çarpma);
            //}
            //else if (islem == "bölme")
            //{
            //    Console.WriteLine("bölme sonucu=" + bölme);
            //}


            //Console.ReadLine();
            #endregion

            #region 1-50 arasındaki tek sayılar

            //for (int i = 1; i < 50; i += 2)

            //{
            //    Console.WriteLine("Tek sayılar=" + i);
            //}
            //Console.ReadLine();
            #endregion

            #region iki sayının arasındaki çift sayıların toplamı

            //int sayi1, sayi2, toplam;
            //Console.WriteLine("1.Sayı:");
            //sayi1 =Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.Sayı:");
            //sayi2 =Convert.ToInt32(Console.ReadLine());
            //toplam = 0;

            //for (int i = sayi1; i < sayi2; i+=2)
            //{
            //    toplam += i;
            //    Console.WriteLine(toplam);
            //}
            //Console.ReadKey();

            #endregion

            #region Fibonacci 

            //Console.WriteLine("Fibonacci şemasına hoşgeldiniz.");

            //int a = 1;
            //int b = 1;
            //int c;

            //for (int i = 1; i < 8; i++)
            //{
            //    c = a + b;
            //    a = b;
            //    b = c;

            //    Console.WriteLine(c);
            //}
            //Console.ReadLine();

            #endregion

            #region Ortalama geçti kaldı hesabı

            //Console.WriteLine("Hesaplama uygulamasına hoşgeldiniz.");
            //Console.WriteLine("1.NOT:");
            //int not1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2.NOT:");
            //int not2 = Convert.ToInt32(Console.ReadLine());

            //int ortalama = (not1 + not2) / 2;

            //if (ortalama>=50)
            //{
            //    Console.WriteLine("Geçtiniz.");

            //}

            //else
            //{
            //    Console.WriteLine("Kaldınız");
            //}

            //Console.ReadLine();

            #endregion

            #region Kullanıcı Adı ve Şifre uygulaması

            //Console.WriteLine("Giriş yapmak için Kullanıcı Adı ve şifrenizi giriniz.");
            //Console.WriteLine("Kullanıcı Adı");
            //string kullanıcıAdi=Console.ReadLine();
            //Console.WriteLine("Şifre");
            //string sifre=Console.ReadLine();

            //string ıD = "Ozhan";
            //string pasword = "M1M2ozhan.";

            //if (kullanıcıAdi==ıD && sifre==pasword)
            //{
            //    Console.WriteLine("GİRİŞ BAŞARILI.");
            //}

            //else
            //{
            //    Console.WriteLine("Yanlış şifre yada kullanıcı adı.");

            //}

            //Console.ReadLine();

            #endregion

            #region Mağaza örneği

            //int fiyat,kargo,toplam;
            //Console.WriteLine("Mağazamıza Hoşgeldiniz.");
            //Console.WriteLine("Almak istediğiniz ürünün fiyatı:");
            //fiyat = Convert.ToInt32(Console.ReadLine());
            //kargo = 5;
            //toplam = 0;
            //int ödemeTutari = fiyat - kargo;
            //int ödemeTutari1 = fiyat + kargo;

            //if (fiyat>=100)
            //{
            //    Console.WriteLine("Ödenecek tutardan kargo parası olan 5 TL düşülmüştür.:"+ödemeTutari);
            //}
            //else if (fiyat<100)
            //{
            //    Console.WriteLine("Ödenecek tutara kargo parası eklenmiştir.:"+ödemeTutari1);
            //}

            //Console.ReadLine();

            #endregion

            #region Mağaza örneği 2

            //int toplam, indirim;
            //Console.WriteLine("Mağazamıza hoşgeldiniz.");
            //Console.WriteLine("Alacağınız ilk ürünün fiyatını");
            //int ürün1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Alacağınız ikinci ürünün fiyatını giriniz.");
            //int ürün2 = Convert.ToInt32(Console.ReadLine());
            //toplam = ürün1 + ürün2;
            //indirim = ürün1 + ürün2 - (ürün2 * 25) / 100;

            //if (toplam>=200)
            //{
            //    Console.WriteLine(indirim);
            //}

            //else if (toplam < 200)
            //{
            //    Console.WriteLine(toplam);
            //}

            //Console.ReadLine();

            #endregion

            #region a dan z ye kadar olan harfleri yazdırma kodu.

            //char karakter;

            //for (karakter = 'a'; karakter <= 'z'; karakter++)
            //{
            //    Console.Write(karakter);


            //}

            //Console.ReadLine();
            #endregion

            #region Kullanıcıdan for döngüsü ile isim alma.


            //int toplam, sayi;
            //toplam = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("Sayıyı giriniz");
            //    sayi = Convert.ToInt16(Console.ReadLine());
            //    toplam = toplam + sayi;
            //}

            //Console.Write("Yazdığınız sayıların toplamı="+toplam);
            //Console.ReadLine();

            #endregion

            #region Kullanıcıdan alınan isimlerin başında numaraları ile birlikte sırala

            //Console.WriteLine("İsimleri numara ile sıralama");

            //string isim;
            //Console.Write("İsminiz:");

            //int i;
            //for (i = 1; i <= 10; i++)
            //{
            //    isim = (Console.ReadLine());
            //    Console.WriteLine("{0} : {1}", i, isim);

            //}

            //Console.ReadLine();

            #endregion

            #region Kullanıcı tarafından 10 elemanlı bir diziye sayı girişi yaptıran ve bu dizinin elemanlarını %20 arttırıp ekrana yazdır.

            //int[] dizi= new int[10];

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.Write("{0}.elemanı giriniz:", i + 1);
            //    dizi[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //    Console.WriteLine("---------------------------------");

            //for (int i = 0; i < 10; i++)

            //{
            //    dizi[i] = dizi[i] + (dizi[i]*20/100);
            //    Console.WriteLine("Dizinin {0}. indexi:{1}",i,dizi[i]);

            //}
            //Console.ReadKey();

            #endregion

            #region 1-100 arasında 3 ve 5 e bölünen sayıları listele.

            //Console.WriteLine("Sayılar");



            //for (int i = 0; i < 100; i++)
            //{

            //    if (i % 3 == 0 && i % 5 == 0)
            //    {
            //        Console.WriteLine("Sayılar="+i);
            //    }
            //}

            //Console.ReadLine();

            #endregion


            #region 1 den kullanıcının girdiği sayıya kadar olan sayıları listeleyen örnek:

            //Console.WriteLine("Sayıyı giriniz.");
            //int sayi=Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < sayi; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.ReadLine();



            #endregion

            #region Kullanıcıdan alınan 5 sayıdan kaç tanesi 10-20 arasında olduğunu göster.

            //Console.WriteLine("Sayı oyunu");

            //int sayi, adet;
            //adet = 0;

            //for (int i = 0; i <= 5; i++)
            //{
            //    Console.Write("Bir sayı giriniz:");
            //    sayi = Convert.ToInt32(Console.ReadLine());

            //    if (sayi > 10 && sayi < 20)
            //    {
            //        adet++;
            //    }

            //    Console.WriteLine("Yazdığınız sayılardan {0} tanesi 10-20 arasındadır.",adet);
            //}

            //Console.ReadLine();

            #endregion

            #region Cümleyi 1-1 atlatarak yazdıran komut


            //Console.WriteLine("Bir cümle giirinzzz");
            //string cümle = Console.ReadLine();

            //for (int i = 0; i < cümle.Length; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write(cümle[j]);
            //    }
            //    Console.WriteLine();
            //}

            //Console.ReadLine();

            #endregion

            #region 1-100 arasındaki sayıların toplamı

            //int toplam;
            //toplam= 0;


            //for (int i = 0; i <= 100; i++)
            //{
            //    toplam=toplam+i;
            //    Console.WriteLine(toplam);
            //}

            //Console.ReadLine();

            #endregion

            #region Asal sayıları bulma örneği

            Console.WriteLine("Asal sayıları bulma oyununa hoşgeldiniz.");
            Console.WriteLine("Lütfen bir sayı giriniz.");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sayac = 0;

            if (sayi == 0 || sayi == 1)
            {
                Console.WriteLine("Sayı asal sayı değildir.");
            }

            else
            {
                for (int j = 2; j < sayi; j++)
                {
                    if (sayi % j == 0)
                    {
                        sayac++;
                        break;
                    }
                }
                if (sayac == 0)
                {
                    Console.WriteLine("Girilen {0} sayısı asal sayıdır.", sayi);
                }
                else
                {
                    Console.WriteLine("Girilen {0} sayısı asal sayı değildir.", sayi);
                }
            }
            Console.ReadLine();



            #endregion

            #region While döngüsü ile 1-100 arası sayıların toplamı

            //int toplam, sayi;

            //toplam = 0;
            //sayi = 0;

            //while (sayi<100)
            //{
            //    toplam = toplam + sayi;
            //    Console.WriteLine(toplam);
            //    sayi++;
            //}
            //Console.WriteLine("1-100 arasındaki sayıların toplamı:"+toplam);

            //Console.ReadLine();

            #endregion

            #region 1 den 10 a kadar olan sayıları ekrana yazdır.

            int i = 0;

            while (i < 10)
            {
                i++;
                Console.WriteLine(i);
            }
            Console.ReadLine();

            #endregion

            #region Dizilerin oluşturulması

            //int[] numbers = { 1, 2, 3, 4, 5, 6 };

            //Console.WriteLine(numbers[2]);
            //Console.WriteLine(numbers[5]);

            //string[] isim = { "Özhan", "asfas", "sdfds", "shfdhdf" };
            //Console.WriteLine(isim[3]);

            //Console.ReadLine();

            #endregion

            //#region Kullanıcıdan 5 sayı alıp en büyük ve en kücüğünü yazdıran program

            //int[] numbers = new int[5];

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("{0} Sayıyı giriniz:",i);
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}

            

            //#endregion









        }
    }
}
