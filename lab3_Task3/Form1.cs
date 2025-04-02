namespace lab3_Task3
{
    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {

        }
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


        //Extensions (Textbook and AudioBox Classes)
        public class Textbook : Book
        {
            public string Subject { get; set; }
            public override string GetInfo()
            {
                return $"{Title} (Textbook - {Subject}) by {Author}";
            }
        }

        public class AudioBook : Book
        {
            public double Duration { get; set; }    
            public string Narrator { get; set; }
            public override string GetInfo()
            {
                return $"{Title} (Audiobook, {Duration} hrs) narrated by {Narrator}";
            }
        }

        private void DisplayBooks(Book[] books)
        {

            foreach (Book book in books)
            {
                listBoxBooks.Items.Add(book.GetInfo());
            }
        }

        private void btnShow_Info_Click(object sender, EventArgs e)
        {
            Book[] books = new Book[]
            {
                new Book { Title = "C# Fundamentals", Author = "Mark Smith" },
                new Magazine { Title = "Tech Weekly", Author = "John Doe", IssueNumber = 45 },
                new Ebook { Title = "Learn C# in 30 Days", Author = "Jane Doe", FileSizeMB = 5 },
                new Textbook { Title = "Advanced Mathematics", Author = "Dr. Allen", Subject = "Mathematics" },
                new AudioBook { Title = "The Art of War", Author = "Sun Tzu", Duration = 4.5, Narrator = "Morgan Freeman" }
            };

            DisplayBooks(books);
        }
    }

}
