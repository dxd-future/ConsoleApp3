var person = new Person();

person.Print();

class Person
{
    public string Name = "Семён";
    public int Age = 18;

    public void Print()
    {
        Console.WriteLine($"Имя: {Name}, Возраст: {Age}");
    }
}