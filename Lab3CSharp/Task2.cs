namespace Lab3CSharp;

public class Task2
{

    /*
    Побудувати ієрархію класів: Республіка, монархія, королівство, держава. 
    Згідно завдання вибрати базовий клас та похідні. В
    класах задати поля, які характерні для кожного класу. Для всіх класів
    розробити метод Show(), який виводить дані про об’єкт класу. Створити
    масив базового класу та написати функцію наповняє масив різними 
    об’єктами похідних класів. Вивести масив впорядкований за деяким
    критерієм який характеризує всі об’єкти масиву
    */

    // Базовий клас
    public class Country
    {
        public string Name { get; set; }
        public double Population { get; set; }

        public Country(string name, double population)
        {
            Name = name;
            Population = population;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Country: {Name}, Population: {Population}");
        }

         public virtual String OwnToString()
        {
            return $"Country: {Name}, Population: {Population}";
        }
    }

    // Похідний клас Республіка
    public class Republic : Country
    {
        public string President { get; set; }

        public Republic(string name, double population, string president) : base(name, population)
        {
            President = president;
        }

        public override void Show()
        {
            Console.WriteLine($"Republic: {Name}, President: {President}, Population: {Population}");
        }

         public override String OwnToString()
        {
            return $"Republic: {Name}, President: {President}, Population: {Population}";
        }
    }

    // Похідний клас Монархія
    public class Monarchy : Country
    {
        public string Monarch { get; set; }

        public Monarchy(string name, double population, string monarch) : base(name, population)
        {
            Monarch = monarch;
        }

        public override void Show()
        {
            Console.WriteLine($"Monarchy: {Name}, Monarch: {Monarch}, Population: {Population}");
        }

        public override String OwnToString()
        {
            return $"Monarchy: {Name}, Monarch: {Monarch}, Population: {Population}";
        }
    }

    // Похідний клас Королівство
    public class Kingdom : Monarchy
    {
        public int NumberOfProvinces { get; set; }

        public Kingdom(string name, double population, string monarch, int numberOfProvinces) : base(name, population, monarch)
        {
            NumberOfProvinces = numberOfProvinces;
        }

        public override void Show()
        {
            Console.WriteLine($"Kingdom: {Name}, Monarch: {Monarch}, Population: {Population}, Number of Provinces: {NumberOfProvinces}");
        }

        public override String OwnToString()
        {
            return $"Kingdom: {Name}, Monarch: {Monarch}, Population: {Population}, Number of Provinces: {NumberOfProvinces}";
        }
    }

}