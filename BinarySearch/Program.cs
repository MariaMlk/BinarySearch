using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program

    {

        public static int BinarySearch(int[] array, int value)
        {
            int minNum = 0;
            int maxNum = array.Length - 1;

            while (minNum <= maxNum)
            {
                int mid = (minNum + maxNum) / 2;
                if (value == array[mid])
                {
                    return mid;
                }
                else if (value < array[mid])
                {
                    maxNum = mid - 1;
                }
                else
                {
                    minNum = mid + 1;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            TestExistentElement();
            TestNegativeNumbers();
            TestNonExistentElement();
            TestRepeatableElement();
            TestEmptyArray();
            TestVeryBigArray();

            Console.ReadKey();
        }

        private static void TestNegativeNumbers()
        {
            //Тестирование поиска в отрицательных числах
            int[] negativeNumbers = new[] { -5, -4, -3, -2 };
            if (BinarySearch(negativeNumbers, -3) != 2)
                Console.WriteLine("! Поиск не нашёл число -3 среди чисел {-5, -4, -3, -2}");
            else
                Console.WriteLine("Поиск среди отрицательных чисел работает корректно");
        }

        private static void TestNonExistentElement()
        {
            //Тестирование поиска отсутствующего элемента
            int[] negativeNumbers = new[] { -5, -4, -3, -2 };
            if (BinarySearch(negativeNumbers, -1) >= 0)
                Console.WriteLine("! Поиск нашёл число -1 среди чисел {-5, -4, -3, -2}");
            else
                Console.WriteLine("Поиск отсутствующего элемента вернул корректный результат работает корректно");
        }

        private static void TestExistentElement()
        {
            int[] numbers = new[] { 1, 3, 4, 5, 10 };
            if (BinarySearch(numbers, 1) != 0)
                Console.WriteLine("! Поиск не нашёл число 1 среди чисел {1, 3, 4, 5, 10 }");
            else
                Console.WriteLine("Поиск элемента вернул корректный результат работает корректно");
        }

        private static void TestRepeatableElement()
        {
            //бинарный поиск не может найти повторяющийся элемент
            int[] numbers = new[] { 1, 3, 5, 5, 10 };
            if (BinarySearch(numbers, 1) != 3)
                Console.WriteLine("! Поиск не нашёл число 5 среди чисел {1, 3, 5, 5, 10 }");
            else
                Console.WriteLine("Поиск элемента вернул корректный результат работает корректно");
        }

        private static void TestEmptyArray()
        {
            //бинарный поиск не может найти повторяющийся элемент
            int[] numbers = new int[0];

            if (BinarySearch(numbers, 1) == -1)
                Console.WriteLine("Поиск в пустом массиве работает корректно");
        }

        private static void TestVeryBigArray()
        {
            var numbers = new int[100001];

            for(var i = 0; i<numbers.Length; i++)            
                numbers[i] = i;

            if (BinarySearch(numbers, 5000) != 5000)
                Console.WriteLine("! Поиск не нашёл число 5000");
            else
                Console.WriteLine("Поиск элемента вернул корректный результат работает корректно");
        }
    }
}
