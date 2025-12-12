using System;


namespace projectCourse;


// —татичный класс говорит о том, что все что находитс€ внутри класса оно должно быть статичным
static class Users
{

    // static делает так что объект не нужно создавать, а можно сразу обращатс€ к полу через класс
    // static пренадлежит целому классу, ак
    // не объекту
    public static int count;


    // ѕри создании конструктора модификатор доступа прописывать не нужно
    // —татичный конструктор выполн€етс€ тольнко 1 раз
    //static Users() 
    //{
    //    Console.WriteLine("User Created!");

    //}

    // ¬ static нельз€ использовать указатель this
    // ≈сли начал работать со static в классе, то лучше все делать со static
    public static void Count()
    {
        Console.WriteLine($"Count: {count}");
    }

    public static float Multiply( float a, float b)
    {
       return a * b;

    }
}
