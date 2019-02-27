using System;

namespace ArraysEasy
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Array1();
            Array2();
        }

        private static void Array1()
        {
            int[] intArray = new int[3] { 10, 20, 30 };

            for (int i = 0; i < intArray.Length; i++)
                Console.WriteLine(intArray[i]);
        }

        private static void Array2()
        {
            Array array = Array.CreateInstance(typeof(int), new int[1] { 5 }, new int[1] { 1 });

            array.SetValue(1, 1);
            array.SetValue(2, 2);
            array.SetValue(3, 3);
            array.SetValue(4, 4);
            array.SetValue(5, 5);

            for (int i = 1; i <= array.Length; i++)
                Console.WriteLine("Array value {0} at position {1}", array.GetValue(i), i);
        }
    }
}
