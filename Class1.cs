using System;

// Клас Address
public class Address
{
    public string Index { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public string House { get; set; }
    public string Apartment { get; set; }

    public Address(string index, string country, string city, string street, string house, string apartment)
    {
        Index = index;
        Country = country;
        City = city;
        Street = street;
        House = house;
        Apartment = apartment;
    }
}

// Клас Converter
public class Converter
{
    private double usd;
    private double eur;
    private double pln;

    public Converter(double usd, double eur, double pln)
    {
        this.usd = usd;
        this.eur = eur;
        this.pln = pln;
    }

    public double UahToUsd(double amount)
    {
        return amount / usd;
    }

    public double UahToEur(double amount)
    {
        return amount / eur;
    }

    public double UahToPln(double amount)
    {
        return amount / pln;
    }

    public double UsdToUah(double amount)
    {
        return amount * usd;
    }

    public double EurToUah(double amount)
    {
        return amount * eur;
    }

    public double PlnToUah(double amount)
    {
        return amount * pln;
    }
}

// Клас Employee
public class Employee
{
    private string lastName;
    private string firstName;

    public Employee(string lastName, string firstName)
    {
        this.lastName = lastName;
        this.firstName = firstName;
    }

    public void CalculateSalary(string position, int experience)
    {
        var positions = new Dictionary<string, double>
        {
            { "manager", 30000 },
            { "developer", 45000 },
            { "designer", 35000 }
        };

        double taxRate = 0.18;
        double salary = positions.ContainsKey(position) ? positions[position] : 25000;
        salary += experience * 1000;
        double tax = salary * taxRate;
        double netSalary = salary - tax;

        Console.WriteLine("Інформація про співробітника:");
        Console.WriteLine($"Прізвище: {lastName}");
        Console.WriteLine($"Ім'я: {firstName}");
        Console.WriteLine($"Посада: {position}");
        Console.WriteLine($"Оклад: {salary} грн");
        Console.WriteLine($"Податковий збір: {tax} грн");
        Console.WriteLine($"Чистий оклад: {netSalary} грн");
    }
}

// Клас User
public class User
{
    public string Login { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public DateTime RegistrationDate { get; }

    public User(string login, string firstName, string lastName, int age)
    {
        Login = login;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        RegistrationDate = DateTime.Now;
    }

    public void DisplayUserInfo()
    {
        Console.WriteLine("Інформація про користувача:");
        Console.WriteLine($"Логін: {Login}");
        Console.WriteLine($"Ім'я: {FirstName}");
        Console.WriteLine($"Прізвище: {LastName}");
        Console.WriteLine($"Вік: {Age}");
        Console.WriteLine($"Дата заповнення анкети: {RegistrationDate.ToString("yyyy-MM-dd HH:mm:ss")}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створення класу Address
        Address addressInfo = new Address("12345", "Україна", "Київ", "Вулиця Примірна", "12", "34");
        Console.WriteLine("Адреса:");
        Console.WriteLine($"Індекс: {addressInfo.Index}");
        Console.WriteLine($"Країна: {addressInfo.Country}");
        Console.WriteLine($"Місто: {addressInfo.City}");
        Console.WriteLine($"Вулиця: {addressInfo.Street}");
        Console.WriteLine($"Будинок: {addressInfo.House}");
        Console.WriteLine($"Квартира: {addressInfo.Apartment}");

        // Створення класу Converter
        Converter converter = new Converter(27.5, 32.1, 7.2);
        double amountInUah = 1000;
        Console.WriteLine($"{amountInUah} грн у USD: {converter.UahToUsd(amountInUah)}");
        Console.WriteLine($"{amountInUah} грн у EUR: {converter.UahToEur(amountInUah)}");
        Console.WriteLine($"{amountInUah} грн у PLN: {converter.UahToPln(amountInUah)}");
        Console.WriteLine($"100 USD у UAH: {converter.UsdToUah(100)}");
        Console.WriteLine($"100 EUR у UAH: {converter.EurToUah(100)}");
        Console.WriteLine($"100 PLN у UAH: {converter.PlnToUah(100)}");

        // Створення класу Employee
        Employee employeeInfo = new Employee("Іванов", "Іван");
        string position = "developer";
        int experience = 5;
        employeeInfo.CalculateSalary(position, experience);

        // Створення класу User
        User userInfo = new User("user123", "Іван", "Іванов", 30);
        userInfo.DisplayUserInfo();
    }
}
