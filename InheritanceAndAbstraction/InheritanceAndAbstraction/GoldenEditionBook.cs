using System;


class GoldenEditionBook : Book
{
    public GoldenEditionBook()
    {

    }
    public GoldenEditionBook(string title, string author, double price)
    {
        Title = title;
        Author = author;
        Price = price; 
    }

    public override double Price
    {
        get
        {
            return base.Price * 0.3;
        }

        set
        {
            base.Price = value;
        }
    }
}
