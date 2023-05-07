using System;
using System.Collections;

class QuadCollection
{
    private Stack<Figure> stack = new Stack<Figure>();
    public void Add(Figure fig)
    {
        stack.Push(fig);
    }
    public void Remove(Figure fig)
    {
        stack.Pop();
    }

    public void Print()
    {
        foreach (Figure fig in stack)
        {
            fig.Draw();
            Console.WriteLine();
        }
    }


}
public abstract class Figure
{
    public abstract void Draw();
}


class Parallelogram : Figure
{
    public override void Draw()
    {
        Console.WriteLine("********");
        Console.WriteLine(" *      *");
        Console.WriteLine("  *      *");
        Console.WriteLine("   *      *");
        Console.WriteLine("    ********");
    }
}
class Rhomb : Figure
{
    public override void Draw()
    {
        Console.WriteLine("   /\\");
        Console.WriteLine("  /  \\  ");
        Console.WriteLine(" /    \\");
        Console.WriteLine(" \\    / ");
        Console.WriteLine("  \\  /");
        Console.WriteLine("   \\/ ");
    }
}
class Rectangle : Figure
{
    public override void Draw()
    {
        Console.WriteLine("******************");
        Console.WriteLine("*                *");
        Console.WriteLine("*                *");
        Console.WriteLine("******************");

    }
}
class Square : Figure
{
    public override void Draw()
    {

        Console.WriteLine("**********");
        Console.WriteLine("*        *");
        Console.WriteLine("*        *");
        Console.WriteLine("*        *");
        Console.WriteLine("*        *");
        Console.WriteLine("**********");

    }
}



class Program
{
    static void Main(string[] args)
    {
        QuadCollection quadCollection = new QuadCollection();
        quadCollection.Add(new Parallelogram());
        quadCollection.Add(new Rhomb());
        quadCollection.Add(new Rectangle());
        quadCollection.Add(new Square());
        quadCollection.Print();

    }
}

