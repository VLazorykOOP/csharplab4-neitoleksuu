using System;

// Абстрактний клас Видання
abstract class Publication
{
    protected string title;
    protected string author;
    protected int year;

    // Конструктор
    public Publication(string title, string author, int year)
    {
        this.title = title;
        this.author = author;
        this.year = year;
    }

    // Метод, що виводить інформацію про видання на екран
    public abstract void DisplayInfo();

    // Метод, що перевіряє, чи є видання шуканим
    public abstract bool IsSearchable(string authorName);
}

// Похідний клас Книга
class Book : Publication
{
    protected string publisher;

    // Конструктор
    public Book(string title, string author, int year, string publisher) : base(title, author, year)
    {
        this.publisher = publisher;
    }

    // Реалізація методу виведення інформації про книгу на екран
    public override void DisplayInfo()
    {
        Console.WriteLine($"Book: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Year: {year}");
        Console.WriteLine($"Publisher: {publisher}");
    }

    // Реалізація методу перевірки, чи є книга шуканою за автором
    public override bool IsSearchable(string authorName)
    {
        return author.Equals(authorName, StringComparison.OrdinalIgnoreCase);
    }
}

// Похідний клас Стаття
class Article : Publication
{
    protected string journal;
    protected int issue;

    // Конструктор
    public Article(string title, string author, int year, string journal, int issue) : base(title, author, year)
    {
        this.journal = journal;
        this.issue = issue;
    }

    // Реалізація методу виведення інформації про статтю на екран
    public override void DisplayInfo()
    {
        Console.WriteLine($"Article: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Year: {year}");
        Console.WriteLine($"Journal: {journal}, Issue: {issue}");
    }

    // Реалізація методу перевірки, чи є стаття шуканою за автором
    public override bool IsSearchable(string authorName)
    {
        return author.Equals(authorName, StringComparison.OrdinalIgnoreCase);
    }
}

// Похідний клас Електронний ресурс
class ElectronicResource : Publication
{
    protected string link;
    protected string annotation;

    // Конструктор
    public ElectronicResource(string title, string author, int year, string link, string annotation) : base(title, author, year)
    {
        this.link = link;
        this.annotation = annotation;
    }

    // Реалізація методу виведення інформації про електронний ресурс на екран
    public override void DisplayInfo()
    {
        Console.WriteLine($"Electronic Resource: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Year: {year}");
        Console.WriteLine($"Link: {link}");
        Console.WriteLine($"Annotation: {annotation}");
    }

    // Реалізація методу перевірки, чи є електронний ресурс шуканим за автором
    public override bool IsSearchable(string authorName)
    {
        return author.Equals(authorName, StringComparison.OrdinalIgnoreCase);
    }
}

class Catalog
{
    private Publication[] publications;

    // Конструктор
    public Catalog(int size)
    {
        publications = new Publication[size];
    }

    // Додавання видання в каталог
    public void AddPublication(int index, Publication publication)
    {
        publications[index] = publication;
    }

    // Виведення повної інформації з каталогу
    public void DisplayCatalog()
    {
        Console.WriteLine("Catalog:");
        foreach (Publication publication in publications)
        {
            publication.DisplayInfo();
            Console.WriteLine();
        }
    }

    // Пошук видань за автором
    public void SearchByAuthor(string authorName)
    {
        Console.WriteLine($"Publications by author '{authorName}':");
        foreach (Publication publication in publications)
        {
            if (publication.IsSearchable(authorName))
            {
                publication.DisplayInfo();
                Console.WriteLine();
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створення каталогу
        Catalog catalog = new Catalog(3);

        // Додавання видань в каталог
        catalog.AddPublication(0, new Book("The Catcher in the Rye", "J.D. Salinger", 1951, "Little, Brown and Company"));
        catalog.AddPublication(1, new Article("Introduction to Machine Learning", "Andrew Ng", 2018, "Machine Learning Journal", 1));
        catalog.AddPublication(2, new ElectronicResource("Deep Learning Basics", "Yann LeCun", 2020, "https://deeplearning.com/basics", "Introduction to deep learning concepts"));

        // Виведення повної інформації з каталогу
        catalog.DisplayCatalog();

        // Пошук видань за автором
        catalog.SearchByAuthor("Andrew Ng");
    }
}
