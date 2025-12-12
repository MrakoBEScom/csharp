using System;



namespace projectCourse;


class Person2
{
    public string? Name { get; set; }
    public int Age { get; set; }


    public Person2(string? name, int age)
    {
        SetValues(name, age);
    }

    
    private void SetValues(string? name, int age)
    {
        Name = name;
        Age = age;
    }

   
}