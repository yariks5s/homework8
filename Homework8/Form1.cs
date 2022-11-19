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
    public virtual int Width
    {
        get { return base.Width; }
        set
        {
            base.Height = value;
            base.Width = value;
        }
    }
    public virtual int Height
    {
        get { return base.Height; }
        set
        {
            base.Height = value;
            base.Width = value;
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