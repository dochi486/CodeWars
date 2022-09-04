using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] b = new int[] { 121, 14641, 20736, 361, 25921, 361, 20736, 361 };
            bool r = AreTheySame.comp(a, b);
            Console.WriteLine(r.ToString());
        }
    }


    class AreTheySame
    {

        public static bool comp(int[] a, int[] b)
        {
           
            if (a == null)
                return false;
            if (b == null)
                return false;

            if (a.Length == 0)
                return false;
            if (b.Length == 0)
                return false;

            List<int> new_a = a.OrderBy(x => x).ToList();

            for (int i = 0; i < new_a.Count(); i++)
            {
                new_a[i] = new_a[i] * new_a[i];
            }

            List<int> new_b = b.OrderBy(x => x).ToList();

            if (new_a.Count() != new_b.Count())
                return false;

            for (int i = 0; i < new_a.Count(); i++)
            {
                if (new_a[i] != new_b[i])
                    return false;
            }
            return true;
          
        }
    }
}
