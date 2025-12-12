using System;
using System.Collections.Generic;


namespace projectCourse;


//interface Это интерфейс
// Интерфейсы это типо классы, но проще
interface ITalk
{
    // Мы не можем сдесь прописывать поля
    // Тут можно создавать константы, статические переменные, аксессоры, но без реализации, методы тоже можно писать, но без реализации
    const string language = "RU";

    static int talkSpeed = 1;

    List<string> Words {  get; set; }

    // В интерфейсах не пишут модификатор доступа 
    // Тут по умолчанию всегда идет public
    void Talk(string word)
    {
        Console.WriteLine(word);
    }

    string AllWords();

}
