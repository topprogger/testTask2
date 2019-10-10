using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> mas = new List<int> ();
            Random random=new Random();
  
            for (int i = 0; i< random.Next(150); i++)
            {
                mas.Add(random.Next(500));
            }
            for (int ind=0; ind<mas.Count;ind++)
            {
                if (mas[ind] < 14)
                {
                    mas.Remove(ind);
                }
            }
            mas = mas.OrderByDescending(x => x)                 
                  .ToList();
            for(int a=0;a< mas.Count;a++)
            {
                Console.WriteLine(mas[a]);
            }
            Console.ReadKey();
        }
    }
}
