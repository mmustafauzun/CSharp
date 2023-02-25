using System.Collections.Generic;

namespace GenericsIntro
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // T = string 
            MyList<string>isimler = new MyList<string>();
            isimler.Add("Engin");

            Console.WriteLine(isimler.Length);

            isimler.Add("Kerem");

            Console.WriteLine(isimler.Length);

            foreach (var isim in isimler.Items) 
            {
                Console.WriteLine(isim);
            }


        }
    }
}