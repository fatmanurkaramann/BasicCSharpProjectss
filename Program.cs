using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    public static void Main(string[] args)
    {
        //AverageFibonacci fibonaccis = new AverageFibonacci();
        //fibonaccis.FibonacciNumber();

        //Triangle triangle = new Triangle();

        //Circle circle = new Circle();   
        //Algorithm algorithm = new Algorithm();
        //ChangeLocation changeLocation = new();

        Area area = new Area();

        //IntegerDual integerDual = new IntegerDual();
        //integerDual.IntegerDualFunction();

        //AbsoluteSquare absoluteSquare = new AbsoluteSquare();


        //SwapFirstAndLastCharacter swapFirstAndLastCharacter = new SwapFirstAndLastCharacter();

        //Console.WriteLine("İki kelime girin:");
        //string input = Console.ReadLine();

        //string[] words = input.Split(' ');

        //string output = "";
        //foreach (string word in words)
        //{
        //    string swappedWord = SwapFirstAndLastCharacter.SwapFirstAndLastCharacterFunction(word);
        //    output += swappedWord + " ";
        //}

        //Console.WriteLine("Sonuç: " + output.Trim());

        //Consanants consanants = new Consanants();
        //Console.WriteLine("Bir string ifade girin:");
        //string input = Console.ReadLine();

        //bool[] results = consanants.CheckConsecutiveConsonants(input);
        //Console.WriteLine("Sonuç:");
        //foreach (bool result in results)
        //{
        //    Console.Write(result + " ");
        //}
    }
}
public class AverageFibonacci
{
    public void FibonacciNumber()
    {
        Console.Write("Fibonacci serisinin kaç terimini yazdırmak istersiniz? ");
        int sayi = int.Parse(Console.ReadLine());
        int total = 0;
        Console.WriteLine("Fibonacci Serisi:");
        for (int i = 0; i < sayi; i++)
        {
            int fibonacciTerimi = Fibonacci(i);
            Console.WriteLine(fibonacciTerimi);
            total += fibonacciTerimi;
        }

        double average = (double)total / sayi;
        Console.WriteLine("ortalama: " + average);
    }
    public int Fibonacci(int n)
    {
        if (n == 0)
        {
            return 0;
        }
        else if (n == 1)
        {
            return 1;
        }
        else
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
public class Triangle
{
    public Triangle()
    {
        Console.Write("Üçgenin boyutunu girin: ");
        int boyut = int.Parse(Console.ReadLine());

        for (int i = 1; i <= boyut; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
public class Circle
{
    public Circle()
    {
        Console.Write("Dairenin yarıçapını girin: ");
        double yaricap = double.Parse(Console.ReadLine());

        double pi = Math.PI;
        double cevre = 2 * pi * yaricap;
        double alan = pi * yaricap * yaricap;

        Console.WriteLine("Dairenin Çevresi: " + cevre);
        Console.WriteLine("Dairenin Alanı: " + alan);

        Console.WriteLine("Dairenin Çizimi:");

        int daireYaricapi = (int)yaricap;
        int daireCizimGenislik = 2 * daireYaricapi + 1;
        int daireCizimYukseklik = daireYaricapi * 2 + 1;
        char bosKarakter = ' ';
        char daireKarakter = '*';

        for (int y = 0; y < daireCizimYukseklik; y++)
        {
            for (int x = 0; x < daireCizimGenislik; x++)
            {
                double uzaklikX = Math.Abs(x - daireYaricapi);
                double uzaklikY = Math.Abs(y - daireYaricapi);
                double uzaklik = Math.Sqrt(uzaklikX * uzaklikX + uzaklikY * uzaklikY);

                if (uzaklik <= daireYaricapi)
                {
                    Console.Write(daireKarakter);
                }
                else
                {
                    Console.Write(bosKarakter);
                }
            }

            Console.WriteLine();
        }
    }
}
public class Algorithm
{
    public Algorithm()
    {
        Console.Write("Bir string ifade girin: ");
        string ifade = Console.ReadLine();

        Console.Write("Çıkartılacak karakterin indeksini girin: ");
        int indeks = int.Parse(Console.ReadLine());

        if (indeks < 0 || indeks >= ifade.Length)
        {
            Console.WriteLine("Geçersiz indeks! Lütfen geçerli bir indeks girin.");
            return;
        }

        char cikarilanKarakter = ifade[indeks];
        string kalanIfade = ifade.Remove(indeks, 1);

        Console.WriteLine("Çıkarılan Karakter: " + cikarilanKarakter);
        Console.WriteLine("Kalan İfade: " + kalanIfade);
    }
}
public class ChangeLocation
{
    public ChangeLocation()
    {
        Console.Write("Bir string ifade girin: ");
        string ifade = Console.ReadLine();

        string yeniIfade = changeLocationString(ifade);

        Console.WriteLine("Yeni İfade: " + yeniIfade);
    }
    public string changeLocationString(string ifade)
    {
        char[] karakterler = ifade.ToCharArray();

        for (int i = 1; i < karakterler.Length; i++)
        {
            char temp = karakterler[i];
            karakterler[i] = karakterler[i - 1];
            karakterler[i - 1] = temp;
        }

        return new string(karakterler);
    }
}
public class Area
{
    public Area()
    {


        while (true)
        {
            Console.WriteLine("İşlem yapmak istediğiniz geometrik şekil nedir?");
            Console.WriteLine("1. Kare");
            Console.WriteLine("2. Dikdörtgen");
            Console.WriteLine("3. Üçgen");
            Console.WriteLine("3. Daire");


            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("Ne hesaplamak istersiniz?");
            Console.WriteLine("1. Alan");
            Console.WriteLine("2. Çevre");
            int choice2 = int.Parse(Console.ReadLine());
            Kare kare = new Kare();
            Dikdörtgen dikdortgen = new Dikdörtgen();
            switch (choice)
            {

                case 1:
                    switch (choice2)
                    {

                        case 1:
                            kare.AlanHesapla();
                            break;
                        case 2:
                            kare.CevreHesapla();
                            break;
                    }
                    break;

                case 2:

                    switch (choice2)
                    {
                        case 1:
                            dikdortgen.AlanHesapla();
                            break;
                        case 2:
                            dikdortgen.CevreHesapla();
                            break;
                    }
                    break;

            }
        }
    }
    public class BaseClass
    {
        public virtual void AlanHesapla()
        {
            Console.WriteLine("Kenar giriniz");

        }
        public virtual void CevreHesapla()
        {
            Console.WriteLine("Kenar giriniz");
        }
    }

    public class Kare : BaseClass
    {
        public override void AlanHesapla()
        {
            base.AlanHesapla();
            int uzunKenar = int.Parse(Console.ReadLine());
            int alan = uzunKenar * uzunKenar;
            Console.WriteLine("Kare Alanı : " + alan);
        }
        public override void CevreHesapla()
        {
            base.CevreHesapla();
            int kenar = int.Parse(Console.ReadLine());
            int cevre = kenar * 4;
            Console.WriteLine("Karenin Çevresi : " + cevre);
        }
    }
  public class Dikdörtgen : BaseClass
    {
        public override void AlanHesapla()
        {
            base.AlanHesapla();
            int uzunKenar = int.Parse(Console.ReadLine());
            Console.WriteLine("2. Kenar girin");
            int kisaKenar = int.Parse(Console.ReadLine());
            int area = uzunKenar * kisaKenar;
            Console.WriteLine(area);
        }
        public override void CevreHesapla()
        {
            base.AlanHesapla();
            int uzunKenar = int.Parse(Console.ReadLine());
            Console.WriteLine("2. Kenar girin");
            int kisaKenar = int.Parse(Console.ReadLine());
            int cevre = (2 * uzunKenar) + (2 * kisaKenar);
            Console.WriteLine("Dikdörtgenin çevresi : "+cevre);
        }

    }
  
}
public class IntegerDual
{
    public void IntegerDualFunction()
    {
        Console.WriteLine("Kaç tane ikili sayı girmek istersiniz");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("1. sayıyı gir");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("2. sayıyı gir");
            int b = int.Parse(Console.ReadLine());

            if (a != b)
            {
                int pairSum = a + b;
                Console.Write(pairSum + " ");
            }
            else
            {
                int pairSquareSum = (a + b) * (a + b);
                Console.Write(pairSquareSum + " ");
            }



        }

    }
}
public class AbsoluteSquare
{
    public AbsoluteSquare()
    {
        Console.WriteLine("Kaç tane sayı girmek istersiniz");
        int n = int.Parse(Console.ReadLine());
        int sumSmall = 0;
        int sumLarge = 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("sayıyı gir");
            int a = int.Parse(Console.ReadLine());

            if (a < 67)
            {
                int fark = 67 - a;

                sumSmall += fark;
                Console.WriteLine("67den küçük sayılar için " + sumSmall);

            }
            else if (a > 67)
            {
                sumLarge += Math.Abs(67 - a) * Math.Abs(67 - a);
                Console.WriteLine("67den büyük sayılar için " + sumLarge);

            }


        }

    }

}
public class SwapFirstAndLastCharacter
{
    public static string SwapFirstAndLastCharacterFunction(string input)
    {
        if (string.IsNullOrEmpty(input) || input.Length == 1)
        {
            return input;
        }

        char[] charArray = input.ToCharArray();

        char firstChar = charArray[0];
        charArray[0] = charArray[input.Length - 1];
        charArray[input.Length - 1] = firstChar;

        return new string(charArray);
    }
}
public class Consanants
{
    public bool[] CheckConsecutiveConsonants(string input)
    {
        string[] words = input.Split(' ');
        bool[] results = new bool[words.Length];

        for (int i = 0; i < words.Length; i++)
        {
            results[i] = CheckConsecutiveConsonantsInWord(words[i]);
        }

        return results;
    }
    public static bool CheckConsecutiveConsonantsInWord(string word)
    {
        bool hasConsecutiveConsonants = false;
        for (int i = 0; i < word.Length - 1; i++)
        {
            if (IsConsonant(word[i]) && IsConsonant(word[i + 1]))
            {
                hasConsecutiveConsonants = true;
                break;
            }
        }
        return hasConsecutiveConsonants;
    }
    public static bool IsConsonant(char c)
    {
        char[] consonants = { 'b', 'c', 'ç', 'd', 'f', 'g', 'ğ', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'r', 's', 'ş', 't', 'v', 'y', 'z' };
        return Array.IndexOf(consonants, char.ToLower(c)) >= 0;
    }
}