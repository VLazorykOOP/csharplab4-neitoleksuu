using System;
using System.Collections.Generic;

// Інтерфейс Видання
interface IPublication
{
    void DisplayInfo();
    bool IsAuthor(string authorSurname);
}

// Клас для представлення книги
class Book : IPublication
{
    public string Title { get; set; }
    public string AuthorSurname { get; set; }
    public int Year { get; set; }
    public string Publisher { get; set; }

    public Book(string title, string authorSurname, int year, string publisher)
    {
        Title = title;
        AuthorSurname = authorSurname;
        Year = year;
        Publisher = publisher;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Book Title: {Title}");
        Console.WriteLine($"Author: {AuthorSurname}");
        Console.WriteLine($"Year: {Year}");
        Console.WriteLine($"Publisher: {Publisher}");
    }

    public bool IsAuthor(string authorSurname)
    {
        return AuthorSurname.Equals(authorSurname, StringComparison.OrdinalIgnoreCase);
    }
}

// Клас для представлення статті
class Article : IPublication
{
    public string Title { get; set; }
    public string AuthorSurname { get; set; }
    public string JournalName { get; set; }
    public int IssueNumber { get; set; }
    public int Year { get; set; }

    public Article(string title, string authorSurname, string journalName, int issueNumber, int year)
    {
        Title = title;
        AuthorSurname = authorSurname;
        JournalName = journalName;
        IssueNumber = issueNumber;
        Year = year;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Article Title: {Title}");
        Console.WriteLine($"Author: {AuthorSurname}");
        Console.WriteLine($"Journal Name: {JournalName}");
        Console.WriteLine($"Issue Number: {IssueNumber}");
        Console.WriteLine($"Year: {Year}");
    }

    public bool IsAuthor(string authorSurname)
    {
        return AuthorSurname.Equals(authorSurname, StringComparison.OrdinalIgnoreCase);
    }
}

// Клас для представлення електронного ресурсу
class ElectronicResource : IPublication
{
    public string Title { get; set; }
    public string AuthorSurname { get; set; }
    public string Url { get; set; }
    public string Annotation { get; set; }

    public ElectronicResource(string title, string authorSurname, string url, string annotation)
    {
        Title = title;
        AuthorSurname = authorSurname;
        Url = url;
        Annotation = annotation;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Electronic Resource Title: {Title}");
        Console.WriteLine($"Author: {AuthorSurname}");
        Console.WriteLine($"URL: {Url}");
        Console.WriteLine($"Annotation: {Annotation}");
    }

    public bool IsAuthor(string authorSurname)
    {
        return AuthorSurname.Equals(authorSurname, StringComparison.OrdinalIgnoreCase);
    }
}

// Клас для представлення каталогу видань
class Catalog
{
    private List<IPublication> publications = new List<IPublication>();

    public void AddPublication(IPublication publication)
    {
        publications.Add(publication);
    }

    public void DisplayCatalog()
    {
        foreach (var publication in publications)
        {
            publication.DisplayInfo();
            Console.WriteLine();
        }
    }

    public void SearchByAuthor(string authorSurname)
    {
        bool found = false;
        foreach (var publication in publications)
        {
            if (publication.IsAuthor(authorSurname))
            {
                publication.DisplayInfo();
                Console.WriteLine();
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine($"No publications found for author: {authorSurname}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Catalog catalog = new Catalog();

        catalog.AddPublication(new Book("C# Programming", "Smith", 2020, "Tech Books"));
        catalog.AddPublication(new Article("AI Research", "Johnson", "AI Journal", 5, 2019));
        catalog.AddPublication(new ElectronicResource("Learn C#", "Doe", "http://learn-csharp.com", "Comprehensive guide to C#"));

        Console.WriteLine("Full Catalog:");
        catalog.DisplayCatalog();

        Console.WriteLine("Search by Author (Smith):");
        catalog.SearchByAuthor("Smith");

        Console.WriteLine("Search by Author (Doe):");
        catalog.SearchByAuthor("Doe");

        Console.WriteLine("Search by Author (Brown):");
        catalog.SearchByAuthor("Brown");
    }
}
