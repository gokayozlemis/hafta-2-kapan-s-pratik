using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Aşağıdaki çıktıyı yazan bir program.
        Console.WriteLine("Merhaba");
        Console.WriteLine("Nasılsın ?");
        Console.WriteLine("İyiyim");
        Console.WriteLine("Sen nasılsın ?");

        // 2. Bir adet metinsel, bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız.
        // Bunların değerlerini atayıp, ekrana yazdırınız.
        string metinselDeger = "Merhaba Dünya";
        int tamSayiDeger = 42;
        Console.WriteLine(metinselDeger);
        Console.WriteLine(tamSayiDeger);

        // 3. Rastgele bir sayı üretip, ekrana yazdırınız.
        Random rand = new Random();
        int randomSayi = rand.Next(1, 101);  // 1 ile 100 arasında rastgele bir sayı
        Console.WriteLine(randomSayi);

        // 4. Rastgele bir sayı üretip, bunun 3'e bölümünden kalanı ekrana yazdırınız.
        int kalan = randomSayi % 3;
        Console.WriteLine($"Rastgele sayı: {randomSayi}, 3'e bölümünden kalan: {kalan}");

        // 5. Kullanıcıya yaşını sorup, 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.
        Console.Write("Yaşınızı girin: ");
        int yas = int.Parse(Console.ReadLine());
        if (yas >= 18)
        {
            Console.WriteLine("+");
        }
        else
        {
            Console.WriteLine("-");
        }

        // 6. Ekrana 10 defa "Sen Vodafone gibi anı yaşarken, ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Sen Vodafone gibi anı yaşarken, ben Turkcell gibi seni her yerde çekemem.");
        }

        // 7. Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel", "Demet Evgar" bunların yerlerini değiştiriniz.
        Console.Write("Birinci ismi girin: ");
        string isim1 = Console.ReadLine();
        Console.Write("İkinci ismi girin: ");
        string isim2 = Console.ReadLine();
        string temp = isim1;
        isim1 = isim2;
        isim2 = temp;
        Console.WriteLine($"Yer değiştirilmiş isimler: {isim1}, {isim2}");

        // 8. Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız.
        // Ekrana "Ben değer döndürmem, benim bir karşılığım yok, beni değişkene atamaya çalışma" yazsın.
        BenDegerDondurmem();

        // 9. İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.
        Console.Write("Birinci sayıyı girin: ");
        int sayi1 = int.Parse(Console.ReadLine());
        Console.Write("İkinci sayıyı girin: ");
        int sayi2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Toplam: {Toplam(sayi1, sayi2)}");

        // 10. Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.
        Console.Write("True veya False yazın: ");
        string cevap = Console.ReadLine();
        Console.WriteLine(TrueFalseString(cevap));

        // 11. 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.
        Console.Write("Birinci kişinin yaşını girin: ");
        int yas1 = int.Parse(Console.ReadLine());
        Console.Write("İkinci kişinin yaşını girin: ");
        int yas2 = int.Parse(Console.ReadLine());
        Console.Write("Üçüncü kişinin yaşını girin: ");
        int yas3 = int.Parse(Console.ReadLine());
        Console.WriteLine($"En yaşlı kişi: {EnYasli(yas1, yas2, yas3)}");

        // 12. Kullanıcıdan sınırsız sayıda sayı alıp, bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.
        Console.Write("Birden fazla sayı girin (aralarına boşluk koyun): ");
        string[] sayilar = Console.ReadLine().Split(' ');
        int[] sayiDizisi = Array.ConvertAll(sayilar, int.Parse);
        Console.WriteLine($"En büyük sayı: {EnBuyukSayi(sayiDizisi)}");

        // 13. Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.
        Console.Write("Birinci ismi girin: ");
        string isim1Yeni = Console.ReadLine();
        Console.Write("İkinci ismi girin: ");
        string isim2Yeni = Console.ReadLine();
        (isim1Yeni, isim2Yeni) = IsimleriDegistir(isim1Yeni, isim2Yeni);
        Console.WriteLine($"Yer değiştirilmiş isimler: {isim1Yeni}, {isim2Yeni}");

        // 14. Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.
        Console.Write("Bir sayı girin: ");
        int sayi = int.Parse(Console.ReadLine());
        Console.WriteLine($"Sayı çift mi?: {TekMiCiftMi(sayi)}");

        // 15. Kullanıcıdan alınan hız ve zaman bilgileriyle, gidilen yolu hesaplayan bir metot yazınız.
        Console.Write("Hızı girin (km/saat): ");
        double hiz = double.Parse(Console.ReadLine());
        Console.Write("Zamanı girin (saat): ");
        double zaman = double.Parse(Console.ReadLine());
        Console.WriteLine($"Gidilen yol: {GidilenYol(hiz, zaman)} km");

        // 16. Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.
        Console.Write("Dairenin yarıçapını girin: ");
        double yaricap = double.Parse(Console.ReadLine());
        Console.WriteLine($"Dairenin alanı: {DaireAlani(yaricap)}");

        // 17. "Zaman bir GeRi SayIm" cümlesini alıp, hepsi büyük harf ve hepsi küçük harfle yazdırınız.
        string cumle = "Zaman bir GeRi SayIm";
        Console.WriteLine(cumle.ToUpper());  // Büyük harf
        Console.WriteLine(cumle.ToLower());  // Küçük harf

        // 18. "    Selamlar   " metnini bir değişkene atayıp, başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.
        string metin = "    Selamlar   ";
        metin = metin.Trim();  // Başındaki ve sonundaki boşlukları siler.
        Console.WriteLine($"Boşluksuz metin: '{metin}'");
    }

    // 8. Metot: Değer döndürmeyen bir metot
    static void BenDegerDondurmem()
    {
        Console.WriteLine("Ben değer döndürmem, benim bir karşılığım yok, beni değişkene atamaya çalışma");
    }

    // 9. Metot: İki sayıyı alıp toplamlarını döndüren metot
    static int Toplam(int a, int b)
    {
        return a + b;
    }

    // 10. Metot: True veya False string döndüren metot
    static string TrueFalseString(string cevap)
    {
        if (cevap.ToLower() == "true")
            return "Doğru";
        else if (cevap.ToLower() == "false")
            return "Yanlış";
        else
            return "Geçersiz cevap";
    }

    // 11. Metot: En yaşlı kişiyi döndüren metot
    static int EnYasli(int yas1, int yas2, int yas3)
    {
        return Math.Max(Math.Max(yas1, yas2), yas3);
    }

    // 12. Metot: En büyük sayıyı döndüren metot
    static int EnBuyukSayi(int[] sayilar)
    {
        return sayilar.Max();  
    }

    // 13. Metot: İki ismin yerlerini değiştiren metot
    static (string, string) IsimleriDegistir(string isim1, string isim2)
    {
        return (isim2, isim1);
    }

    // 14. Metot: Sayının tek mi çift mi olduğunu döndüren metot
    static bool TekMiCiftMi(int sayi)
    {
        return sayi % 2 == 0;
    }

    // 15. Metot: Hız ve zaman ile yol hesaplayan metot
    static double GidilenYol(double hiz, double zaman)
    {
        return hiz * zaman;
    }

    // 16. Metot: Dairenin alanını hesaplayan metot
    static double DaireAlani(double yaricap)
    {
        return Math.PI * yaricap * yaricap;
    }
}


