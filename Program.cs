using System;

namespace PracaDomowaL13T4
{
    class Program
    {
        static void Main(string[] args)
        {
     
            while(true)
            {
                try
                {
                    Console.WriteLine("Podaj liczbe");
                    var myNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Podana przez ciebie liczba to " + myNumber);
                    if (myNumber % 2 == 0)
                    {
                        Console.WriteLine("Jest to liczba parzysta");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Jest liczba nieparzysta");

                    }

                }
                catch
                {
                    Console.WriteLine("Podana wartosc nie jest prawdopodobnie liczba :(");

                }
               

            } 

        }


    }
}
