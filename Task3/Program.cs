using System;

class Rectangle : Square
{
    public int Width { get; set; }
    public int Height { get; set; }
    public int GetRectangleArea()
    {
        return Width * Height;
    }
}

//квадрат наслідується від прямокутника!!!
class Square
{
    public int Width
    {
        get{return Width;}
        set
        {
            Height = value;
            Width = value;
            
        }

    }
    public int Height
    {
        get { return Height; }
        set
        {
            Height = value;
            Width = value;
        }
       
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.Width = 5;
            rect.Height = 10;

            Console.WriteLine(rect.GetRectangleArea());
            //Відповідь 100? Що не так???
            Console.ReadKey();
        }
    }
}