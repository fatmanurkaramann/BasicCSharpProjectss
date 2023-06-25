﻿using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    public  static void Main(string[] args)
    {
        //AverageFibonacci fibonaccis = new AverageFibonacci();
        //fibonaccis.FibonacciNumber();

        //Triangle triangle = new Triangle();

        //Circle circle = new Circle();   
        //Algorithm algorithm = new Algorithm();
        ChangeLocation changeLocation = new();
    }
}
public class AverageFibonacci
{
    public  void FibonacciNumber()
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

        double average =(double)total / sayi;
        Console.WriteLine("ortalama: "+average);
    }
    public int Fibonacci(int n)
    {
        if (n == 0)
        {
            return 0;
        }
        else if(n== 1)
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