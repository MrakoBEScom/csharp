//using System;
//using System.IO;
//using System.Xml;
//using System.Xml.Serialization;



//namespace projectCourse;


//class Homework4
//{
//    public static void Main()
//    {     
//        User user = new User();
//        user.GetUserData();



//        XmlSerializer xml = new XmlSerializer(typeof(User));

//        using (FileStream file = new FileStream("userObj.xml", FileMode.OpenOrCreate))
//        {
//            xml.Serialize(file, user);
//            Console.WriteLine("Сериализация прошла успешно!");
//        }

//        using (FileStream file2 = new FileStream("userObj.xml", FileMode.OpenOrCreate))
//        {
//            User deserializedUser = xml.Deserialize(file2) as User ?? new User();
//            Console.WriteLine("Десериализация прошла успешно!");

//            deserializedUser.PrintUserData(); 
//        }

//    }
//}