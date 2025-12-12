//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;


//namespace projectCourse;

//class Homework2
//{
//    public static void Main()
//    {
//        // Задание 1
//        Dictionary<string, string> user_files = new Dictionary<string, string>();
        
//        for (int i = 0; i < 3; i++)
//        {
//            Console.Write("Введите название для файла: ");
//            string a = Console.ReadLine() ?? "Default file.txt";
//            a = a == "" ? $"Default file{i}.txt" : a;

//            Console.Write("Введите содержимое файла: ");
//            string b = Console.ReadLine() ?? "";

//            user_files.Add(a, b);

//        }

//        Dictionary<string, string> user_keys = user_files.Where(i => i.Key.ToLower().StartsWith("q")).ToDictionary();

//        foreach (var el in user_keys)
//        {

//            using (FileStream file = new FileStream($"{el.Key}", FileMode.OpenOrCreate))
//            {
//                    byte[] convert = System.Text.Encoding.Default.GetBytes(el.Value);
//                    file.Write(convert);
//            }
            
//        }

//    }
//}