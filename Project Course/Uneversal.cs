
//using System;
//using System.Net.Http;
//using System.Threading.Tasks;

//namespace projectCourse;

//class Client
//{
//    // HttpClient специальный тип данных для обращения к сайту
//    private static HttpClient client = new HttpClient();

//    // Task<string> Я говорю о том что помимимо Task я возвращаю еще и string
//    public static async Task<string> GetData()
//    {
//        // await client.GetStringAsync(""); Дожидается ответа по определенному адресу
//        return await client.GetStringAsync("https://jsonplaceholder.typicode.com/todos/1");
        
//    }
//}