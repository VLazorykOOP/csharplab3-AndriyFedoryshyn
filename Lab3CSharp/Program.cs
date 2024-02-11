namespace Lab3CSharp;

internal class Program
{
    public static void task1()
    {
        //get count of rect and rects from user
        Console.WriteLine("Enter count of rectangles: ");
        int count = Convert.ToInt32(Console.ReadLine());
        Rectangle[] rectangles = new Rectangle[count];
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("");
            Console.Write($"Enter side A of rectangle {i + 1}: ");
            int sideA = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter side B of rectangle {i + 1}: ");
            int sideB = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter color of rectangle {i + 1}: ");
            int color = Convert.ToInt32(Console.ReadLine());

            rectangles[i] = new Rectangle(sideA, sideB, color);
        }
        int squareCount = 0;
        foreach (Rectangle rectangle in rectangles)
        {
            Console.WriteLine($"Color {rectangle.Color}:");
            rectangle.PrintSides();
            Console.WriteLine($"Perimeter: {rectangle.CalculatePerimeter()}");
            Console.WriteLine($"Square: {rectangle.CalculateArea()}");

            if (rectangle.IsSquare())
            {
                squareCount++;
            }

            Console.WriteLine();
        }

        Console.WriteLine($"Count of squares: {squareCount}");
    }

    public static void task2()
    {
        var countries = new List<Task2.Kingdom>();
        countries.Add(new Task2.Kingdom("Spain", 46.9, "King Felipe VI", 17));
        countries.Add(new Task2.Kingdom("Ale", 26.9, "King Felipe VI", 19));
        countries.Add(new Task2.Kingdom("Bale", 36.9, "King Felipe VI", 10));
        countries.Add(new Task2.Kingdom("Sale", 16.9, "King Felipe VI", 20));

        countries.Sort((x, y) =>
        {
            if (x is Task2.Kingdom && y is Task2.Kingdom)
            {
                return ((Task2.Kingdom)x).NumberOfProvinces.CompareTo(((Task2.Kingdom)y).NumberOfProvinces);
            }
            return 0;
        });

        // Виведення інформації про об'єкти
        foreach (var country in countries)
        {
            country.Show();
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Lab 3 ");

        try
        {
            Console.WriteLine("Input number of task(1 or 2): ");
            int task = Convert.ToInt32(Console.ReadLine());
            switch (task)
            {
                case 1:
                    task1();
                    break;
                case 2:
                    task2();
                    break;
                default:
                    Console.WriteLine("Task not found");
                    break;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}

