    namespace lab3
    {
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }

            public class Book
            {
                public string Title { get; set; }
                public string Author { get; set; }
                public virtual string GetInfo()
                {
                    return $"{Title} by {Author}";

                }
            }

            public class Magazine : Book
            {
                public int IssueNumber { get; set; }
                public override string GetInfo()
                {
                    return $"{Title} - Issue {IssueNumber}";
                }

            }
            public class Ebook : Book
            {
                public int FileSizeMB { get; set; }
                public override string GetInfo()
                {
                    return $"{Title} (Ebook, {FileSizeMB}MB) by {Author}";
                }
            }

        
            private void DisplayBooks(Book[] books)
            {
                listBoxBooks.Items.Clear(); 
                foreach (Book book in books)
                {
                    listBoxBooks.Items.Add(book.GetInfo()); 
                }
            }
            private void Form1_Load(object sender, EventArgs e)
            {

            }

            private void btnShow_Info_Click(object sender, EventArgs e)
            {
                Book[] books = new Book[]
                {
                    new Book { Title = "C# Fundamentals", Author = "Mark Smith" },
                    new Magazine { Title = "Tech Weekly", Author = "John Doe", IssueNumber = 45 },
                    new Ebook { Title = "Learn C# in 30 Days", Author = "Jane Doe", FileSizeMB = 5 }
                };

                DisplayBooks(books); 
            }

        }
    }
