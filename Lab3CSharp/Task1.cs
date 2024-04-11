class Trapeze
{
    private int a;
    private int b;
    private int h;
    private string color;
    
    public Trapeze(int a, int b, int h, string color)
    {
        this.a = a;
        this.b = b;
        this.h = h;
        this.color = color;
    }
    
    public void DisplayLengths()
    {
        Console.WriteLine($"Основи трапеції: a={a}, b={b}, висота h={h}");
    }
    
    public int CalculatePerimeter()
    {
        return a + b + 2 * (int)Math.Sqrt(h * h + Math.Pow((b - a) / 2, 2));
    }
    
    public double CalculateArea()
    {
        return (a + b) * h / 2.0;
    }
    
    public int A
    {
        get { return a; }
        set { a = value; }
    }

    public int B
    {
        get { return b; }
        set { b = value; }
    }

    public int H
    {
        get { return h; }
        set { h = value; }
    }
    
    public string Color
    {
        get { return color; }
    }
    
    public bool IsSquare
    {
        get { return a == b && a == h; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Trapeze[] trapezes = new Trapeze[]
        {
            new Trapeze(4, 6, 4, "Червоний"),
            new Trapeze(5, 5, 5, "Синій"),
            new Trapeze(3, 7, 3, "Зелений"),
            new Trapeze(8, 8, 4, "Жовтий")
        };

        int squareCount = 0; 
        
        foreach (var trapeze in trapezes)
        {
            trapeze.DisplayLengths();
            Console.WriteLine($"Периметр: {trapeze.CalculatePerimeter()}");
            Console.WriteLine($"Площа: {trapeze.CalculateArea()}");
            Console.WriteLine($"Колір: {trapeze.Color}");
            if (trapeze.IsSquare)
            {
                squareCount++;
            }
            Console.WriteLine();
        }

        Console.WriteLine($"Кількість квадратів: {squareCount}");
    }
}
