using System;

namespace SatrancUygulamasi
{
    class Program
    {
        static int birSatirIcinIstenilenOlasilikSayisi = 0;// kurallara uyan olasiliklarin sayisini tutmak ve her yerden erismek icin kullanildi
        static public void KontrolEt(int[] dizi) //olusturulan sayi dizisi parametre olarak alinip istenilen kurallara uyup uymadigi kontrol ediliyor
        {
            if (dizi[0] == 0) //dizinin ilk elemaninin 0 olması ve iki sifirin yan yana gelmesi istenmiyor diger tum durumlar istenilen durumlardir
            {

            }
            else if (dizi[0] == 0 && dizi[1] == 0)
            {

            }
            else if (dizi[1] == 0 && dizi[2] == 0)
            {

            }
            else if (dizi[2] == 0 && dizi[3] == 0)
            {

            }
            else if (dizi[3] == 0 && dizi[4] == 0)
            {

            }
            else if (dizi[4] == 0 && dizi[5] == 0)
            {

            }
            else if (dizi[5] == 0 && dizi[6] == 0)
            {

            }
            else if (dizi[6] == 0 && dizi[7] == 0)
            {

            }

            else
            {
                for (int i = 0; i < dizi.Length; i++)
                {
                    Console.Write(dizi[i]);//kurallara uyan dizinin elemanlari ekrana yazdirilir
                }

                Console.WriteLine("");
                birSatirIcinIstenilenOlasilikSayisi++;//kurallara uyan siralislarin sayisini bir artiriliyor
            }
        }
        static public int[] IkilikSayiSistemineCevir(int sayi)
        {
            int kalan; //cevirme icin kullanilan sayinin 2'ye kalanini tutmak icin kullanildi ikili sisteme çevirmek için gerekli

            int[] sayilar = new int[8];// cevrilen sayinin 2' lik halinde islem yapmak icin diziye atilmasi gerekir girilmeyen değerler default olarak 0 dir
            int kacinci = 7; //cevrilen sayinin kacinci kalani oldugunu belirlemek icin
            while (sayi != 0)//sayin 1'den kücük olduğunda çevirme işlemi tamamlanmıştır
            {
                kalan = sayi % 2;
                sayi = sayi / 2;
                sayilar[kacinci] = kalan; //2' lik sistemde kalanlar sirayla diziye atılır
                
                kacinci--;//bir sonraki indikse atlanir


            }
           


            return sayilar; //elde edilen 2'lik sisteme donusturulmus sayi dizisi  geri gonderilir
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Siyah Taşlar: ' 0 ' Olarak temsil edilmistir");
            Console.WriteLine("Beyez Taşlar: ' 1 ' Olarak temsil edilmistir");
            for (int tumOlasiliklar = 0; tumOlasiliklar < 256; tumOlasiliklar++)
            {
                KontrolEt(IkilikSayiSistemineCevir(tumOlasiliklar)); //tek bir satir icin doğruluk tablosundan yararlanılarak 2^8 den =256 olasılık olduğu tespit edilmistir 
                                                        //sayı 0 den başlayarak 256'ya kadar sayilar 2'lik sayi sistemine cevrildi 

            }
            int tumistenilenolasilikdurumlari = birSatirIcinIstenilenOlasilikSayisi * 8;//Bir satir için istenilen olasilik sayisi  8 ile carpilirsa tum tahta icin olasilik sayisi bulunur
            Console.WriteLine("Tek bir satir için istenilen olasiliklarin sayısı:" + birSatirIcinIstenilenOlasilikSayisi);
            Console.WriteLine("8*8 lik  bir satranç tahtasi  için istenilen olasiliklarin sayısı:" + tumistenilenolasilikdurumlari);
        }

    }
}
