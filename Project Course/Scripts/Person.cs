using System; 

using System.Collections.Generic;

namespace projectCourse;

enum PersonType
{
    Player,
    Enemy
}

// Насследование от нескольких классов запрещено, а вот от интефейсов можно сколько угодно насследовать
// Ошибка будет до тех пор пока интерфейс не будет полностью реализован в классе
abstract class Person : ITalk
{

    protected string? name;
    protected PersonType type;
    private int age;
    protected Dictionary<string, bool>? places = new Dictionary<string, bool>();
    
    // Вот таким образом создается аксессор на основе коллекции
    public List<string> Words { get; set; } = new List<string>();

    public int Age
    { 
        get 
        { 
            return age;
        }
        set
        {
            if (value > 0 && value < 100)
            {
                age = value;
            }
            else
            {
                Console.WriteLine("Возраст должен быть боьше чем 0 и меньше чем 100");
            }
        }
    }
    protected abstract int Health { get; set; }

    public Person(string name, PersonType type, int age, Dictionary<string, bool>? places)
    {
        Console.WriteLine("Pesnon has created!!!!!$$$$");
        SetData(name, type, age, places);
        Users.count++;
    }  
    public Person(string name, PersonType type, int age)
    {
        Console.WriteLine("Pesnon has created!!!!!");

        this.name = name;
        this.type = type;
        this.Age = age;
        Users.count++;

    }
    public Person() 
    { 
        Console.WriteLine("Pesnon has created!");
        Users.count++;
    }
    public abstract void Action();

    public string AllWords()
    {
        // Перебирает массив и разделяет целый массив при помоци запятой
        return String.Join(", ", Words);
    }

    public void Talk(string word)
    {
        Words.Add(word);
        Console.WriteLine(word);
    }




    // В классах методы создаются без static
    public void SetData(string name, PersonType type, int age, Dictionary<string, bool>? places = null)
    {
        this.name = name;
        this.type = type;
        this.Age = age;
        this.places = places;
    }
    // Полиморфизм - это переопределение методов в классах наследниках
    // virtual значит то, что метод может быть переопределен в классах наследниках
    // override говорит о том, что мы преписываем виртуальный метод
    public virtual void GetInfo()
    {
        Console.WriteLine($"Игрок: {this.GetName()} \nТип: {this.GetPersonType()} \nВозраст: {Age}" );
        if (places == null || places.Count == 0)
        {
            // return говорит о том что я выхожу из функции/метода
            return;
        }
        foreach(var place in places)
        {
            Console.WriteLine(place.Key);
        }
    }
   

    // Это метод возвращает 
    public string? GetName() => this.name;
    public string? GetPersonType()
    {
        switch (this.type)
        {
            case PersonType.Player: 
                return "Игрок"; 
            
            case PersonType.Enemy: 
                return "Враг"; 
                
            default: return "Такого нет!";
        }
        
    }

    



}





