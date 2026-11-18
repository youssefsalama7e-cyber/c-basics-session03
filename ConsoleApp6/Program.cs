using System;
using System.Text;

class Program
{
    static void Main()
    {
        // Question 1
        string title = "clean code";
        string upperTitle = title.ToUpper();
        Console.WriteLine(title);
        Console.WriteLine(upperTitle);


        // Question 2
        string str1 = "Clean Code";
        string str2 = "Clean Code";
        Console.WriteLine(object.ReferenceEquals(str1, str2));


        // Question 3
        StringBuilder sb = new StringBuilder();
        sb.Append("Book List");
        sb.Append(" - Updated");
        Console.WriteLine(sb.ToString());


        // Question 4
        sb.Replace("Book List", "Library");
        Console.WriteLine(sb.ToString());


        // Question 5
        string title5 = "Clean Code";
        int pages5 = 464;
        string sentence1 = "Book: " + title5 + ", Pages: " + pages5;
        Console.WriteLine(sentence1);


        // Question 6
        string sentence2 = $"Book: {title5}, Pages: {pages5}";
        Console.WriteLine(sentence2);


        // Question 7
        string sentence3 = string.Format("Book: {0}, Pages: {1}", title5, pages5);
        Console.WriteLine(sentence3);


        // Question 8
        int pages8 = 464;
        if (pages8 > 300)
        {
            Console.WriteLine("Long Book");
        }
        else
        {
            Console.WriteLine("Short Book");
        }


        // Question 9
        int pages9 = 464;
        bool isAvailable = true;
        if (pages9 > 300 && isAvailable == true)
        {
            Console.WriteLine("You can borrow this book");
        }


        // Question 10
        string title10 = "Refactoring";
        switch (title10)
        {
            case "Clean Code":
                Console.WriteLine("Great choice!");
                break;
            case "Refactoring":
                Console.WriteLine("Nice pick!");
                break;
            default:
                Console.WriteLine("Never heard of it");
                break;
        }


        // Question 11
        int pages11 = 464;
        string sizeLabel = (pages11 > 300) ? "Long Book" : "Short Book";
        Console.WriteLine(sizeLabel);


        // Question 12
        string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine((i + 1) + ". " + books[i]);
        }


        // Question 13
        int j = 0;
        while (j < books.Length)
        {
            Console.WriteLine(books[j]);
            j++;
        }


        // Question 14
        int k = 1;
        do
        {
            Console.WriteLine("Checking book...");
            k++;
        } while (k <= 3);


        // Question 15
        foreach (string book in books)
        {
            Console.WriteLine(book);
        }


        // Question 16
        foreach (string book in books)
        {
            if (book == "Refactoring")
            {
                break;
            }
            Console.WriteLine(book);
        }


        // Question 17
        foreach (string book in books)
        {
            if (book == "The Pragmatic Programmer")
            {
                continue;
            }
            Console.WriteLine(book);
        }


        // Question 18
        PrintFirstBook(books);
    }

    static void PrintFirstBook(string[] books)
    {
        if (books.Length == 0)
        {
            return;
        }
        Console.WriteLine(books[0]);
    }
}
