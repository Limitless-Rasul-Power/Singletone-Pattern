public class Person
{
    //correct yanasma
    public Person(string name, string surname, int age)
    {
        Name = name;
        Surname = surname;
        Age = age;
    }

    public Person()
    {

    }

    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }

    //wrong yanasma
    //public static Person Get(string name, string surname, int age)
    //{
    //    return new Person { Name = name, Surname = surname, Age = age };
    //}

}