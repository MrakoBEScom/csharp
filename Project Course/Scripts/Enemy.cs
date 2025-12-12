using System;
using System.Collections.Generic;





namespace projectCourse;


class Enemy : Person
{
    public Enemy(string name, PersonType type, int age, Dictionary<string, bool>? places) : base(name, type, age, places)
    {
        
    }

    protected override int Health { get; set; }

    
    public override void Action()
    {
        Console.WriteLine("Мы тебя ударили");
    }
}