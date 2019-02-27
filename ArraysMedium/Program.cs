using System;

namespace ArraysMedium
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Array3();
        }

        private static void Array3()
        {
            int[,] intArray = new int[3, 2]{
                                {1, 2},
                                {3, 4},
                                {5, 6}
                            };

            Console.WriteLine(intArray[0, 0]);
            Console.WriteLine(intArray[0, 1]);
            Console.WriteLine(intArray[1, 0]);
            Console.WriteLine(intArray[1, 1]);
            Console.WriteLine(intArray[2, 0]);
            Console.WriteLine(intArray[2, 1]);
        }
    }
}
