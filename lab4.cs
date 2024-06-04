using System;

// Базовий клас Employee
/*class Employee
{
    protected string name;
    protected string position;
    protected int salary;

    // Конструктор
    public Employee(string name, string position, int salary)
    {
        this.name = name;
        this.position = position;
        this.salary = salary;
    }

    // Метод для виведення даних про працівника
    public virtual void Show()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Position: {position}");
        Console.WriteLine($"Salary: {salary}");
    }
}

// Похідний клас Worker
class Worker : Employee
{
    protected string department;

    // Конструктор
    public Worker(string name, string position, int salary, string department) : base(name, position, salary)
    {
        this.department = department;
    }

    // Перевизначений метод Show
    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Department: {department}");
    }
}

// Похідний клас Engineer
class Engineer : Employee
{
    protected string specialization;

    // Конструктор
    public Engineer(string name, string position, int salary, string specialization) : base(name, position, salary)
    {
        this.specialization = specialization;
    }

    // Перевизначений метод Show
    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Specialization: {specialization}");
    }
}

// Похідний клас Administration
class Administration : Employee
{
    protected string department;

    // Конструктор
    public Administration(string name, string position, int salary, string department) : base(name, position, salary)
    {
        this.department = department;
    }

    // Перевизначений метод Show
    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Department: {department}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Приклад використання
        Worker worker = new Worker("John Doe", "Worker", 2000, "Production");
        worker.Show();

        Engineer engineer = new Engineer("Jane Smith", "Engineer", 3000, "Software Development");
        engineer.Show();

        Administration admin = new Administration("Alice Johnson", "Administrator", 2500, "Human Resources");
        admin.Show();
    }
}*/


// Базовий клас Employee
/*class Employee
{
    protected string name;
    protected string position;
    protected int salary;

    // Конструктор з параметрами
    public Employee(string name, string position, int salary)
    {
        this.name = name;
        this.position = position;
        this.salary = salary;
        Console.WriteLine("Constructor of Employee class is called.");
    }

    // Перевантажений конструктор
    public Employee(string name) : this(name, "Employee", 0)
    {
        Console.WriteLine("Second constructor of Employee class is called.");
    }

    // Перевантажений конструктор
    public Employee() : this("Unknown")
    {
        Console.WriteLine("Third constructor of Employee class is called.");
    }

    // Деструктор
    ~Employee()
    {
        Console.WriteLine("Destructor of Employee class is called.");
    }

    // Метод для виведення даних про працівника
    public virtual void Show()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Position: {position}");
        Console.WriteLine($"Salary: {salary}");
    }
}

// Похідний клас Worker
class Worker : Employee
{
    protected string department;

    // Конструктор з параметрами
    public Worker(string name, string position, int salary, string department) : base(name, position, salary)
    {
        this.department = department;
        Console.WriteLine("Constructor of Worker class is called.");
    }

    // Деструктор
    ~Worker()
    {
        Console.WriteLine("Destructor of Worker class is called.");
    }

    // Перевизначений метод Show
    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Department: {department}");
    }
}

// Похідний клас Engineer
class Engineer : Employee
{
    protected string specialization;

    // Конструктор з параметрами
    public Engineer(string name, string position, int salary, string specialization) : base(name, position, salary)
    {
        this.specialization = specialization;
        Console.WriteLine("Constructor of Engineer class is called.");
    }

    // Деструктор
    ~Engineer()
    {
        Console.WriteLine("Destructor of Engineer class is called.");
    }

    // Перевизначений метод Show
    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Specialization: {specialization}");
    }
}

// Похідний клас Administration
class Administration : Employee
{
    protected string department;

    // Конструктор з параметрами
    public Administration(string name, string position, int salary, string department) : base(name, position, salary)
    {
        this.department = department;
        Console.WriteLine("Constructor of Administration class is called.");
    }

    // Деструктор
    ~Administration()
    {
        Console.WriteLine("Destructor of Administration class is called.");
    }

    // Перевизначений метод Show
    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Department: {department}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Приклад використання
        Worker worker = new Worker("John Doe", "Worker", 2000, "Production");
        worker.Show();

        Engineer engineer = new Engineer("Jane Smith", "Engineer", 3000, "Software Development");
        engineer.Show();

        Administration admin = new Administration("Alice Johnson", "Administrator", 2500, "Human Resources");
        admin.Show();
    }
}*/


