
using Form1;
using Microsoft.EntityFrameworkCore;
namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Author
        {
            public int AuthorId { get; set; }
            public string Name { get; set; }
            public virtual ICollection<Book> Books { get; set; }
        }

        public class Book
        {
            public int BookID { get; set; }
            public string Title { get; set; }
            public int AuthorId { get; set; }
            public virtual Author Author { get; set; }
        }


        public async Task<List<string>> GetBooksAsync()
        {

            using (var context = new BookstoreContext())
            {
                var books = await context.Books.Include(b => b.Author)
                        .Select(b => $"Book: {b.Title}, Author: {b.Author.Name}")
                        .ToListAsync();

                return books;
            }
        }
        private async void btnFetchBooks_Click(object sender, EventArgs e)
        {
            var books = await GetBooksAsync();

            ListBoxBooks.DataSource = books;
        }

        public async Task SaveBookAsync(string bookTitle, string authorName)
        {
            using (var context = new BookstoreContext())
            {
                var author = new Author { Name = authorName };
                var book = new Book { Title = bookTitle, Author = author };


                context.Authors.Add(author);
                context.Books.Add(book);

                await context.SaveChangesAsync();
            }
        }

        private async void btnAddBook_Click(object sender, EventArgs e)
        {
            var authorName = txtAuthorName.Text;
            var bookTitle = txtBookTitle.Text;

            await SaveBookAsync(bookTitle, authorName);

            MessageBox.Show("Book and Author saved Successfully");
        }

        //Task
        public async Task UpdateBookAsync(string currentTitle, string newTitle, string newAuthorName)
        {
            using (var context = new BookstoreContext())
            {
                var book = await context.Books.Include(b => b.Author)
                                 .FirstOrDefaultAsync(b => b.Title == currentTitle);
                if (book != null)
                {
                    book.Title = newTitle;
                    book.Author.Name = newAuthorName;
                    await context.SaveChangesAsync();
                }
                else
                {
                    MessageBox.Show("Book not found.");
                }
            }
        }

        private  async void btnUpdateBook_Click(object sender, EventArgs e)
        {

            string currentTitle = txtBookTitle.Text;
            string newTitle = txtBookTitle.Text;
            string newAuthor = txtAuthorName.Text;

            await UpdateBookAsync(currentTitle, newTitle, newAuthor);
            MessageBox.Show("Book updated successfully!");
        }

        //Delets book

        public async Task DeleteBookByTitleAsync(string title)
        {
            using (var context = new BookstoreContext())
            {
                var book = await context.Books.FirstOrDefaultAsync(b => b.Title == title);
                if (book != null)
                {
                    context.Books.Remove(book);
                    await context.SaveChangesAsync();
                }
                else
                {
                    MessageBox.Show("Book not found.");
                }
            }
        }

        private  async void btnDeletebook_Click(object sender, EventArgs e)
        {
            string title = txtBookTitle.Text;
            await DeleteBookByTitleAsync(title);
            MessageBox.Show("Book deleted successfully!");
        }

        //Display With Progress bar

        public async Task<List<string>> GetBooksAsyncWithProgress(IProgress<int> progress)
        {
            using (var context = new BookstoreContext())
            {
                var books = await context.Books.Include(b => b.Author).ToListAsync();
                var result = new List<string>();
                int count = books.Count;

                for (int i = 0; i < count; i++)
                {
                    result.Add($"Book: {books[i].Title}, Author: {books[i].Author.Name}");
                    progress.Report((i + 1) * 100 / count);
                    await Task.Delay(100); // Simulate load
                }

                return result;
            }
        }

        private  async void btnDisplaybook_Click(object sender, EventArgs e)
        {
            var progress = new Progress<int>(value => progressBar1.Value = value);
            progressBar1.Value = 0;

            var books = await GetBooksAsyncWithProgress(progress);
            ListBoxBooks.DataSource = books;
        }
    }
}
