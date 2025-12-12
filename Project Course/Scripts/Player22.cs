using System;
using System.Collections.Generic;
using System.Numerics;




namespace projectCourse;

class Player22 : Person
{
    private string? magicPower;
    public string MagicPower {  
        get 
        { 
            return magicPower ?? "";
        } 
        set 
        { 
            if (value == "heal")
            {
                magicPower = value;
                
            }
            else
            {
                Console.WriteLine("Такого нет");
            }
        } 
    }



    // При переписи аксессора нужно использовать такойже модификатор достапа как и в первоначальном месте
    protected override int Health {  get; set; }



    public Player22() { }
    public Player22(string name, PersonType type, int age, Dictionary<string, bool>? places, string magicPower) : base(name, type, age, places) 
    { 
        this.MagicPower = magicPower;
        
    }
    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"Magic power: {MagicPower}");
    }

   


    // override Всегда используется при реализации абстрактных методов
    public override void Action()
    {
        Console.WriteLine("Мы просто ходим");
    }




}