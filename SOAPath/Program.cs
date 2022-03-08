using Calculator;
using System;

namespace SOAPath
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicCalculator basicCalculator = new BasicCalculator();//COMPONENT BASED PROGRAMMING (FARKLI BİR PROJEDEKİ CLASSI, METODU  FARKLI BİR PROJEDE KULLANMAK)
            int[] numbers1 = new int[] { 1, 2, 3, 4, 5 };
            int[] numbers2 = new int[] { 10, 20, 30, 40, 50, 60 };
            Console.WriteLine(basicCalculator.Sum(numbers1));
            Console.WriteLine(basicCalculator.Sum(numbers2));
        }

        ////Procedural Programming
        //static int Sum(int[] numbers)
        //{
        //    int total = 0;
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        total += numbers[i];
        //    }
        //    return total;
        //}
    }
}
