internal class Program
{
    private static void Main(string[] args)
    {
        string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
        string kurs2 = "Programlamya başlangıç için temel kurs";
        string kurs3 = "Java";
        string kurs4 = "Python";
        string kurs5 = "C++";

        Console.WriteLine(kurs1);
        Console.WriteLine(kurs2);
        Console.WriteLine(kurs3);
        Console.WriteLine(kurs4);
        Console.WriteLine(kurs5);

        Console.WriteLine("uzun kısım");
        Console.WriteLine(  );
        // array - dizi

        string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı" , "Programlamya başlangıç için temel kurs", "Java","Python","C#"};

        for (int i = 0; i < kurslar.Length; i++)
        {
            Console.WriteLine(kurslar[i]);
        }

        Console.WriteLine("for bitti");
        Console.WriteLine(  );

        foreach (string kurs in kurslar) 
        {
            Console.WriteLine(kurs); 
        }

        Console.WriteLine("froeach bitti");
        Console.WriteLine(  );


        Console.WriteLine("sayfa sonu - footer");
    }
}