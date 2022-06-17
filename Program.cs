using System;

namespace Chocolates
{
    class Program
    {
        static int buy(int dollars)
        {          
            int chocolates =0;
            int wrapes =0;
            while (dollars > 0)
            {
                dollars--;
                chocolates++;
                wrapes++;
                if (wrapes == 3) 
                { 
                    wrapes = 0;
                    chocolates++;
                    wrapes++;
                }
            }
            Console.WriteLine("Оберток осталось:{0}",wrapes);
            return chocolates;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество денег");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = buy(a);
            Console.WriteLine("Количество купленых шоколадок:{0}",b);          
            Console.ReadLine();
        }
    }
}
