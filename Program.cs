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
//Console.WriteLine(Cal.Sum(1, 2));
//// вызов метода Multiply_vivod у экземпляра Cal
//Cal.Multiply_vivod(1, 2);
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
//    public void Multiply_vivod(int a, int b)
//    {
//        Console.WriteLine(Multiply(a, b));
//    }
//}

//User user1 = new User("Semen", "gmail@mail.com", 18);
//user1.vivod();
//class User
//{
//    // свойства пользователя
//    private string Username;
//    private string Email;
//    private int Age;

//    // конструктор, для создания экземпляра
//    public User(string username, string email, int age)
//    {
//        Username = username;
//        Email = email;
//        Age = age;
//    }

//    // метод для вывода информации о пользователе
//    public void vivod()
//    {
//        Console.WriteLine($"Имя пользователя: {Username}");
//        Console.WriteLine($"Email: {Email}");
//        Console.WriteLine($"Возраст: {Age}");
//    }
//}




// zadanie 3



// импорт только что созданной библеотеки
using SemenLibrary;

// создание экземпляра класса из подключенной библеотеки
Semen semen = new Semen();

// методы экземпляра класса
semen.vivod1();
semen.vivod2();

int res = semen.summa(12, 4);
Console.WriteLine(res);

double res2 = semen.delenieNaPoltora(12);
Console.WriteLine(res2);

Console.WriteLine(semen.chetnost(2));



// zadanie 4


try
{
    int a = 5;
    int b = 0;
    int result = a / b;
    Console.WriteLine($"Результат: {result}");
}
catch (Exception ex)
{
    Console.WriteLine($"Исключение: {ex.Message}");
    Console.WriteLine($"На ноль делить нельзя!!!");
}
finally
{
    Console.WriteLine("Программа завершила свою работу");
}

// test