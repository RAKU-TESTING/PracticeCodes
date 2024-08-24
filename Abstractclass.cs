// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

abstract class Parent
{
  public void Add(int x,int y)
  {
      Console.WriteLine(x+y);
  }
  public abstract void Mul(int x,int y);
  public abstract void Div(int x,int y);
  
}
class Child:Parent
{
    // public override void Mul(int x,int y)
    // {
    //     Console.WriteLine(x*y);
    // }
    // public override void Div(int x,int y)
    // {
    //     Console.WriteLine(x/y);
    // }
    public static void Main(string [] args)
    {
    Child c=new Child();
    c.Add(1,2);
    // c.Mul(2,2);
    // c.Div(2,2);
    }
    
    
}



// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

abstract class Figure
{
    public float length,width,radius;
    public abstract float GetArea();
}
class Rectangle:Figure
{
    public override float GetArea()
    {
        return width*length;
    }
    public Rectangle(float Length,float Width)
    {
        this.length=Length;
        this.width=Width;
    }
}
class Square:Figure
{
    public Square(float Length)
    {
        this.length=Length;
    }
    public override float GetArea()
    {
        return length*length;
    }
}
class Circle:Figure
{
    public Circle(float Radius)
    {
        this.radius=Radius;
    }
    public override float GetArea()
    {
        // float a=(float)Math.PI;
        // return a*radius*radius;
        return MathF.PI*radius*radius;
    }
}
class All
{
    public static void Main(string[] args)
    {
        Rectangle r=new Rectangle(5.0f,6.0f);
        Console.WriteLine("The Rectangle Area is:"+r.GetArea());
        Console.WriteLine("\n");
         Square s=new Square(5.0f);
        Console.WriteLine("The Square Area is:"+s.GetArea());
         Circle c=new Circle(5.0f);
        Console.WriteLine("The Circle Area is:"+c.GetArea());
    }
}


    
    
