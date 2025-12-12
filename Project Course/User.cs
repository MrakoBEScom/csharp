//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;


//namespace projectCourse;

//[Serializable]
//public class User
//{
//    private int age = 0;

//    public string? Name { get; set; }
//    public string? Login { get; set; }
//    public int Age 
//    {
//        get
//        {
//            return age;
//        }
//        set
//        {
//            if(value > 0 && value < 150)
//                age = value;
//            else
//            {
//                throw new Exception("Возраст не может быть отрицательным или слишком большим!");
//            }
//        } 
//    }
//    public List<string> Hobbies { get; set;} = new List<string>();
    
//    public User() { }
//    public void GetUserData()
//    {
//        try
//        {
//            Console.Write("Введите имя: ");
//            this.Name = Console.ReadLine();

//            Console.Write("Введите логин: ");
//            this.Login = Console.ReadLine();

//            Console.Write("Введите возраст: ");
//            this.Age = Convert.ToInt32(Console.ReadLine());

//            Console.Write("Введите хобби: ");
//            string hobbye = Console.ReadLine() ?? "У меня нет хобби!";
//            this.Hobbies = hobbye.Split(',').ToList();
//        }
//        catch(Exception ex)
//        {
//            Console.WriteLine(ex.Message);
//            GetUserData();
//        }
//    }

//    public void PrintUserData()
//    {
//        Console.Write($"Пользователь: {Name} c логином {Login}. Его возраст: {Age}. Хобби: \n");
//        foreach (var i in this.Hobbies)
//        {
//            Console.WriteLine($"{i.Trim()}");
//        }

//    }



//}