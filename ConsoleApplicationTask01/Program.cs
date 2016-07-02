using System;
using Task01;

namespace ConsoleApplicationTask01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x^n = A \nEnter: a, b, eps, n, A");
            int a, b, n; //a and b - segment boundaries needed for initial approximation
            double eps, A;
            string str = Console.ReadLine();
            a = Int32.Parse(str);
            str = Console.ReadLine();
            b = Int32.Parse(str);
            str = Console.ReadLine();
            eps = Double.Parse(str);
            str = Console.ReadLine();
            n = Int32.Parse(str);
            str = Console.ReadLine();
            A = Double.Parse(str);
            double t = Newthon.NewthonMethod(a, b, eps, n, A);
            Console.WriteLine(t);
            Console.WriteLine(Math.Pow(t, n));
            Console.ReadLine();
        }
    }
}
