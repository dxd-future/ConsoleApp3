//var person = new Person();

//person.Print();

//class Person
//{
//    public string Name = "Семён";
//    public int Age = 18;

//    public void Print()
//    {
//        Console.WriteLine($"Имя: {Name}, Возраст: {Age}");
//    }
//}

//// экземпляр класса
//Calculator Cal = new Calculator();
//// вызов метода Sum у экземпляра Cal
//Console.WriteLine(Cal.Sum(1,2));
//// вызов метода vivod у экземпляра Cal
//Cal.vivod(1, 2);
//class Calculator
//{
//    // публичный метод 
//    public int Sum(int a, int b)
//    {
//        return a + b;
//    }
//    // приватный метод
//    private int Multiply(int a, int b)
//    {
//        return a * b;
//    }
//    // используем приватный метод в другом методе внутри класса, так как private запрещает его использование вне класса
//    public void vivod(int a, int b)
//    {
//        Console.WriteLine(Multiply(a,b));
//    }
//}

User user1 = new User("Semen", "gmail@mail.com", 18);
user1.vivod();
class User
{
    // свойства пользователя
    private string Username { get; set; }
    private string Email { get; set; }
    private int Age { get; set; }

    // конструктор, понадобиться для создания экземпляра
    public User(string username, string email, int age)
    {
        Username = username;
        Email = email;
        Age = age;
    }

    // метод для вывода информации о пользователе
    public void vivod()
    {
        Console.WriteLine($"Имя пользователя: {Username}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Возраст: {Age}");
    }
}
