namespace tests;
using Lab3CSharp;

public class UnitTest2
{
    [Fact]
    public void Test1()
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

        Assert.Equal(10, countries[0].NumberOfProvinces);
        Assert.Equal(17, countries[1].NumberOfProvinces);



    }

    [Fact]
    public void Test2()
    {
        var countries = new List<Task2.Country>();
        countries.Add(new Task2.Republic("USA", 331.4, "Joe Biden"));
        countries.Add(new Task2.Monarchy("UK", 67.1, "Queen Elizabeth II"));
        countries.Add(new Task2.Kingdom("Spain", 46.9, "King Felipe VI", 17));
        Assert.Equal("Republic: USA, President: Joe Biden, Population: 331.4", countries[0].OwnToString());
        Assert.Equal("Monarchy: UK, Monarch: Queen Elizabeth II, Population: 67.1", countries[1].OwnToString());
        Assert.Equal("Kingdom: Spain, Monarch: King Felipe VI, Population: 46.9, Number of Provinces: 17", countries[2].OwnToString());
    }
}