using System;

namespace projectCourse;

class Book
{
    private string? title;
    private string? author;
    private int year;



    public void writeInfo(string title, string author, int year)
    {
        this.title = title;
        this.author = author;
        this.year = year;

        
    }


    public void displayInfo()
    {
        Console.Write($"Название: {title} \n");
        Console.Write($"Автор: {author} \n");
        Console.Write($"Год издания: {year}  \n");
    }

}