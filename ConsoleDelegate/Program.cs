using System;

namespace ConsoleDelegate
{
    internal class Program
    {


        delegate double Dikdortgen(double x, double y);


        static void Main(string[] args)
        {

            Dikdortgen test = new Dikdortgen(alan);
            Console.WriteLine("Dikdörtgenin Alanı :" + " " + test(3,8));
            Console.ReadLine();
           
        }

        static double cevre(double a,double b)
        {

            return 2 * (a + b);


        }

        static double alan(double a , double b)
        {
            return a * b;
        }



    }
}
