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


    class AreTheySame
    {
        public static bool comp(int[] a, int[] b)
        {
            bool isContain = false;

            if (a == null)
                return false;
            if (b == null)
                return false;

            // 배열 a와 b를 비교하는데
            // b의 요소가 모두 a의 요소들의 제곱값이라면 true

            foreach (var item in b)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == Math.Sqrt(item))
                    {
                        isContain = true;
                        continue;
                    }
                    else
                    {
                        isContain = false;
                        continue;
                    }
                       
                }
            }

            // 하나라도 다르면 false

            return isContain;
        }
    }
}
