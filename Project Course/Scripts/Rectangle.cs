using System;



namespace projectCourse;


class Rectangle : Shape
{
    private float h;
    private float a;
    


    public Rectangle(float h, float a)
    {
        this.h = h;
        this.a = a;
    }

    public override float GetArea()
    {
        return a * h;
    }
}