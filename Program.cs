using System;

namespace _1
{
    class Program
    {
        enum gradus : int
        {
            min = 0,
            krit = 72,
            max = 100,

        }
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            /*int i = 10;	//объявление и инициализация целочисленной переменной i
            Console.WriteLine(i);		//просмотр значения переменной
            i = 100;		//изменение значение переменной
            Console.WriteLine(i);*/
            /* int i;
             Console.WriteLine(i);*/
            /*Console.WriteLine("минимальная температура=" + (int)gradus.min);
            Console.WriteLine("критическая температура=" + (int)gradus.krit);
            Console.WriteLine("максимальная температура=" + (int)gradus.max);*/

            /*string i = "я", j = "дурак";
            Console.WriteLine("{0} {1}", i, j);*/

            // string s = Console.ReadLine();
            //Console.WriteLine(s);

            /*string s = Console.ReadLine();
            int x = int.Parse(s); //преобразование строки в число
            

            string r = Console.ReadLine();
            int y = int.Parse(r); //преобразование строки в число
                                

            string l = Console.ReadLine();
            int z = int.Parse(l); //преобразование строки в число

            Console.WriteLine("{0}+{1}={2}", x, y, x+y);
            Console.WriteLine("{0}+{1}={1}+{0}", x, y);
            Console.WriteLine("{0}+{1}+{2}={3}", x, y, z, x+y+z);*/

            string a = Console.ReadLine();
            double o = double.Parse(a);

            string b = Console.ReadLine();
            double p = double.Parse(b);

            string c = Console.ReadLine();
            double v = double.Parse(c);

            Console.WriteLine("{0}+{1}={2}", o, p, o * p);
            Console.WriteLine("{0:.###}/{1:.###}={2}", o, p, o/p);
            Console.WriteLine("({0:.##}+{1:.##})+{2:.##}={0:.##}+({1:.##}+{2:.##})", o, p, v);
        }
    }
}
