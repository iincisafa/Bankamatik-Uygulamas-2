using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BankaHesabi
{
    private string kullaniciAdi;
    private double bakiye;

    public BankaHesabi(string kullaniciAdi, double baslangicBakiye)
    {
        this.kullaniciAdi = kullaniciAdi;
        this.bakiye = baslangicBakiye;
    }

    public void BakiyeSorgula()
    {
        Console.WriteLine($"Hesap Bakiyeniz: {bakiye:C}");
    }

    public void ParaCek(double miktar)
    {
        if (miktar > 0 && miktar <= bakiye)
        {
            bakiye -= miktar;
            Console.WriteLine($"{miktar:C} tutarında para çekildi. Yeni bakiye: {bakiye:C}");
        }
        else
        {
            Console.WriteLine("Geçersiz işlem. Yetersiz bakiye veya geçersiz miktar.");
        }
    }

    public void ParaYatir(double miktar)
    {
        if (miktar > 0)
        {
            bakiye += miktar;
            Console.WriteLine($"{miktar:C} tutarında para yatırıldı. Yeni bakiye: {bakiye:C}");
        }
        else
        {
            Console.WriteLine("Geçersiz işlem. Geçersiz miktar.");
        }
    }
    public void sifreCoz()
    {
        for (int i = 3; i >= 1; i--)
        {
            Console.WriteLine("Merhabalar, Hoşgeldiniz \" Tane Deneme Hakkınız Var\"");
            Console.WriteLine(i + "Tane Deneme Hakkınız Var");
            string sifre = Convert.ToString(Console.ReadLine());
            if (sifre == "1234")
            {
                break;
            }
            if (i == 1)
            {
                Console.WriteLine("KARTINIZ BLOKE OLMUŞTUR\n BİLGİ İÇİN 444 3* *1 NUMARALI TELEFON ADRESİNİ ARAYINIZ...\n");
                Console.WriteLine("Çıkış yapılıyor...");
                Environment.Exit(0);
            }
        }
    }
}

class Program
{
    static void Main()
    {
        BankaHesabi hesap = new BankaHesabi("Ahmet Safa İnci", 1000.0);

        Console.WriteLine("1. Kartlı İşlemler");
        Console.WriteLine("2. Kartsız İşlemler");
        Console.WriteLine("3. Çıkış");
        int secim1 = Convert.ToInt32(Console.ReadLine());

        switch (secim1)
        {
            case 1:
                //bankamatik.sifreCoz();
                break;
            case 2:
                Console.WriteLine("Bu İşlemi Şu Anda Gerçekleştiremiyoruz Maalesef...\n" +
                    "Lütfen Yeniden Yapmak ;İstediğiniz İşlemi Seçiniz");
                break;
            case 3:
                Console.WriteLine("Çıkış yapılıyor...");
                Console.ReadKey ();
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Geçersiz seçenek. Tekrar deneyin.");
                continue;
        }


        while (true)
        {           
            Console.WriteLine("\n1 - Bakiye Sorgula");
            Console.WriteLine("2 - Para Çek");
            Console.WriteLine("3 - Para Yatır");
            Console.WriteLine("4 - Çıkış");
            Console.Write("İşlemi seçin (1-4): ");

            int secim2;
            if (int.TryParse(Console.ReadLine(), out secim2))
            {
                switch (secim2)
                {
                    case 1:
                        hesap.BakiyeSorgula();
                        break;
                    case 2:
                        Console.Write("Çekmek istediğiniz miktarı girin: ");
                        double cekilenMiktar;
                        if (double.TryParse(Console.ReadLine(), out cekilenMiktar))
                        {
                            hesap.ParaCek(cekilenMiktar);
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz miktar.");
                        }
                        break;
                    case 3:
                        Console.Write("Yatırmak istediğiniz miktarı girin: ");
                        double yatirilanMiktar;
                        if (double.TryParse(Console.ReadLine(), out yatirilanMiktar))
                        {
                            hesap.ParaYatir(yatirilanMiktar);
                        }
                        else
                        {
                            Console.WriteLine("Geçersiz miktar.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Çıkış yapılıyor...");
                        Console.ReadKey ();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçenek. Lütfen tekrar deneyin.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Geçersiz giriş. Lütfen bir sayı girin.");
            }
        }
    }
    
}