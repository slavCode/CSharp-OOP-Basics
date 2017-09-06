using System;
using System.Text;

public class Book
{
    private string title;
    private string author;
    private decimal price;

    public Book(string author, string title, decimal price)
    {
        this.Author = author;
        this.Title = title;
        this.Price = price;
    }

    public virtual string Author
    {
        get => this.author; 
        protected set
        {
            var names = value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (names.Length > 1)
            {
                if (char.IsDigit(names[0][1])) throw new ArgumentException("Author not valid!");
            }

            this.author = value;
        }
    }

    public virtual string Title
    {
        get => this.title;
        protected set
        {
            if (value.Length < 3) throw new ArgumentException("Title not valid!");
            this.title = value;
        }
    }

    public virtual decimal Price
    {
        get => this.price; 
        protected set
        {
            if (value < 1) throw new ArgumentException("Price not valid!");

            this.price = value;
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("Type: ").AppendLine(this.GetType().Name)
            .Append("Title: ").AppendLine(this.Title)
            .Append("Author: ").AppendLine(this.Author)
            .Append("Price: ").Append($"{this.Price:f1}")
            .AppendLine();

        return sb.ToString();
    }
}
