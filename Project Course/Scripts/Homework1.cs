//using System;

//namespace projectCourse
//{
//    class Homework1
//    {
//        public static void Main()
//        {
//            // Задание 1
//            Console.WriteLine("Задание 1");
//            int result = 0;

//            for (int i = 0; i < 1000; i++)
//            {
//                if (i % 3 == 0 || i % 5 == 0)
//                {
//                    result += i;
//                }
//            }

//            Console.WriteLine($"Сумма всех чисел кратных 5 или 3 от 0 и до 1000: {result}\n");

//            // Задание 2
//            Console.WriteLine("Задание 2");
//            int[,] x =
//            {
//                { 20, 34, 2 },
//                { 9, 12, 18 },
//                { 3, 4, 5 }
//            };

//            int min = 1000;

//            for (int i = 0; i < x.GetLength(1); i++)
//            {
//                for (int j = 0; j < x.GetLength(1); j++)
//                {
//                    if (x[i, j] < min)
//                    {
//                        min = x[i, j];
//                    }
//                }
//            }

//            Console.WriteLine($"Минимальнй элемент: {min}");



//        }
//    }
//}