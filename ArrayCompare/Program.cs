using System;

namespace ArrayCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 10 };
            int[] b = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };
            bool r = AreTheySame.comp(a, b);
            Console.WriteLine(r.ToString());
        }
    }


    // 배열 a와 b를 비교하는데

    // b의 요소들이 모두 a의 요소들의 제곱값이라면 true

    // 하나라도 다르면 false


    class AreTheySame
    {
        public static bool comp(int[] a, int[] b)
        {
            bool isSame = false;

            if (a == null)
                return false;
            if (b == null)
                return false;

            for (int i = 0; i < b.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[j] == Math.Sqrt(b[i]))
                        isSame = true;
                    else
                        isSame = false;
                }
            }

            //foreach (var item in b)
            //{
            //    //for (int i = 0; i < a.Length; i++)
            //    //{
            //    //    //if (item == Math.Pow(a[i], 2))
            //    //    //    isSame &= true;
            //    //    isSame = item == (Math.Pow(a[i], 2));
            //    //}
            //    //foreach (var value in a)
            //    //{
            //    //    if (Math.Sqrt(item) == value)
            //    //        isSame = true;
            //    //}
            //}
            return isSame;
        }
    }
}
