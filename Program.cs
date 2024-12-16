using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("0 ile 100 arasında bir sayı giriniz:");
        int sayi = Convert.ToInt32(Console.ReadLine());
        int defa = 0;
        Random rnd = new Random();
        int aklimdakiSayi = rnd.Next(0, 100);

        do
        {
            defa++;
            if (sayi > aklimdakiSayi)
            {
                Console.WriteLine("Daha küçük bir sayı giriniz:");
            }
            else if (sayi < aklimdakiSayi)
            {
                Console.WriteLine("Daha büyük bir sayı giriniz:");
            }

            if (sayi != aklimdakiSayi) // Yanlış tahminde yeni sayı al
            {
                sayi = Convert.ToInt32(Console.ReadLine());
            }
        }
        while (sayi != aklimdakiSayi);

        Console.WriteLine("Tebrikler! Sayıyı {0}. defada buldunuz.", defa);
    }
}
