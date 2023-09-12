using System;

class Rhombus
{
    private double a; // Перша діагональ
    private double b; // Друга діагональ

    // Конструктор з параметрами
    public Rhombus(double diagonalA, double diagonalB)
    {
        a = diagonalA;
        b = diagonalB;
    }

    // Метод Correct, який перевіряє, чи може існувати такий об'єкт
    public bool Correct()
    {
        return a > 0 && b > 0;
    }

    // Метод без параметрів Area, який обчислює площу ромба
    public double Area()
    {
        if (!Correct())
        { 
            throw new InvalidOperationException("Ромб не iснує. Дiагоналi повиннi бути додатнiми числами.");
        }
        return 0.5 * a * b;
    }

    // Метод без параметрів Side, який обчислює сторону ромба
    public double Side()
    {
        if (!Correct())
        {
            throw new InvalidOperationException("Ромб не iснує. Діагоналі повинні бути додатніми числами.");
        }
        return Math.Sqrt(Math.Pow(a / 2, 2) + Math.Pow(b / 2, 2));
    }

    // Метод без параметрів Print, що виводить на екран значення полів
    public void Print()
    {
        Console.WriteLine($"Перша дiагональ: {a}");
        Console.WriteLine($"Друга дiагональ: {b}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //для коректної роботи укранської клавіатури
            Console.Write("Введіть довжину першої діагоналі: ");
            double diagonalA = double.Parse(Console.ReadLine());

            Console.Write("Введіть довжину другої діагоналі: ");
            double diagonalB = double.Parse(Console.ReadLine());

            Rhombus rhombus = new Rhombus(diagonalA, diagonalB);

            Console.WriteLine("Значення полів ромба:");
            rhombus.Print();

            if (rhombus.Correct())
            {
                Console.WriteLine($"Площа ромба: {rhombus.Area()}");
                Console.WriteLine($"Сторона ромба: {rhombus.Side()}");
            }
            else
            {
                Console.WriteLine("Ромб не існує. Діагоналі повинні бути додатніми числами.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
    }
}
