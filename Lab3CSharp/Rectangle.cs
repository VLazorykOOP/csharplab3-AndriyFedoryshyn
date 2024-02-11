namespace Lab3CSharp
{

    /*
    Для розв’язання задачі згідно варіанту
    створити клас із полями, конструкторами, методами та властивостями. 
    До запропонованих полів, методів та властивосте можна додавати власні. 
    Задано масив чотирикутників. Вивести в консоль інформацію
    про чотирикутники та їх площу і периметр . Визначити скільки є
    квадратів. Створити клас Rectangle (прямокутник), розробивши такі
    лементи класу:
         Поля (захищені):
         сторони (int a, b);
         колір прямокутника (int с);
         Конструктор, що дозволяє створити екземпляр класу з
        заданими довжинами сторін.
         Методи, що дозволяють:
             вивести довжини сторін прямокутника на екран;
             розрахувати периметр прямокутника;
             розрахувати площу прямокутника;
             дозволяє встановити, чи є даний прямокутник квадратом.
         Властивості:
             отримати-встановити довжини сторін прямокутника (доступні для читання і запису);
             отримати колір (доступна тільки для читання).
    */


    public class Rectangle
    {
        protected int a;
        protected int b;
        protected int c; 

        public Rectangle(int sideA, int sideB, int color)
        {
            a = sideA;
            b = sideB;
            c = color;
        }

        public void PrintSides()
        {
            Console.WriteLine($"Sides of rect: {a}, {b}");
        }

        public int CalculatePerimeter()
        {
            return 2 * (a + b);
        }

        public int CalculateArea()
        {
            return a * b;
        }

        public bool IsSquare()
        {
            return a == b; 
        }

        public int SideA
        {
            get { return a; }
            set { a = value; }
        }

        public int SideB
        {
            get { return b; }
            set { b = value; }
        }

        public int Color
        {
            get { return c; }
        }
    }
}

