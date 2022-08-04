class Library
{
    class Book
    {
        private string title;
        private string author;
        private bool available;
        public string Title { get { return title; } }
        public string Author { get { return author; } }
        public bool Available { get { return available; } } 
        public Book(string title, string author, bool available)
        {
            this.title = title;
            this.author = author;
            this.available = available;
        }
        public Book(string title, string author) : this(title, author, true)
        {
            this.title = title;
            this.author = author;
        }
        public Book(string title)
        {
            this.title=title;
        }
        public Book()
        {
            this.title = "untitled";
            this.author = "anonymous";
            this.available = true;
        }
    }
    class BookTest
    {
        public static void Main()
        {
            Book book = new Book("Rich dad poor dad","Shreyas S",true);
            Console.WriteLine(book.Title);
            Console.WriteLine(book.Author); 
            Console.WriteLine(book.Available);  
        }
    }
}