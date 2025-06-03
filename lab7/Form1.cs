
using Microsoft.EntityFrameworkCore;
using System.Web.Mvc;
namespace lab7
{
    public partial class txtAuthorName : Form
    {
        public txtAuthorName()
        {
            InitializeComponent();
        }

        private const int pageSize = 10;
        private int currentPage = 1;

        public string Filter { get; private set; }
        public string Title { get; private set; }

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

        public async Task<List<string>> GetBooksByPageAsync(int pageNumber)
        {
            using (var context = new BookstoreContext())
            {
                var books = await context.Books
                                            .Include(x => x.Author)
                                            .OrderBy(x => x.BookID)
                                            .Skip((pageNumber - 1) * pageSize)
                                            .Take(pageSize)
                                            .Select(x => x.Title)
                                            .ToListAsync();

                return books;
            }
        }

        private async void btnNextPage_Click(object sender, EventArgs e)
        {
            currentPage++;
            var books = await GetBooksByPageAsync(currentPage);
            listBoxBooks.DataSource = books;
            lblPageNumber.Text = $"Page{currentPage}";
        }

        private async void btnreverse_Click(object sender, EventArgs e)
        {
            currentPage--;
            var books = await GetBooksByPageAsync(currentPage);
            listBoxBooks.DataSource = books;
            lblPageNumber.Text = $"Page{currentPage}";
        }

        public async Task SaveBookWithHandlingAsync(string bookTitle, string authorName)
        {
            try
            {
                using (var context = new BookstoreContext())
                {
                    var author = new Author { Name = authorName };
                    var book = new Book { Title = bookTitle, Author = author };

                    context.Authors.Add(author);
                    context.Books.Add(book);

                    await context.SaveChangesAsync();
                    MessageBox.Show("Books and Author saved Successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured :{ex.Message}");
            }
        }

        private async void addbook_Click(object sender, EventArgs e)
        {
            var authorName = txtNameAuthor.Text;
            var bookTitle = txtBookTitle.Text;

            await SaveBookWithHandlingAsync(bookTitle, authorName);
        }
        public async Task ExportBooksAsync(string filePath)
        {
            var books = await GetBooksByPageAsync(currentPage);

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var book in books)
                {
                    await writer.WriteLineAsync(book);
                }
            }
        }

        private async void btnExporter_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            {
                Filter = "Text Files (*.text)|*.txt";
                Title = "Save Book List";
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                await ExportBooksAsync(filePath);
                MessageBox.Show("books exported Successfully");
            }
        }



        //Asychronous Search w/ error handling
        public async Task<List<string>> SearchBooksAsync(string keyword)
        {
            try
            {
                using (var context = new BookstoreContext())
                {
                    var results = await context.Books
                        .Include(b => b.Author)
                        .Where(b => b.Title.Contains(keyword))
                        .Select(b => $"Title: {b.Title}, Author: {b.Author.Name}")
                        .ToListAsync();

                    return results;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Search failed: {ex.Message}");
                return new List<string>();
            }
        }

        private async void AsyncSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text;
            var results = await SearchBooksAsync(keyword);
            listBoxBooks.DataSource = results;
        }

        //Asychronous Data Import
        public async Task ImportBooksAsync(string filePath)
        {
            try
            {
                var lines = await File.ReadAllLinesAsync(filePath);

                using (var context = new BookstoreContext())
                {
                    foreach (var line in lines)
                    {
                        var parts = line.Split('|');
                        if (parts.Length == 2)
                        {
                            var author = new Author { Name = parts[0].Trim() };
                            var book = new Book { Title = parts[1].Trim(), Author = author };

                            context.Authors.Add(author);
                            context.Books.Add(book);
                        }
                    }
                    await context.SaveChangesAsync();
                    MessageBox.Show("Books imported successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Import failed: {ex.Message}");
            }
        }

        private  async void Importer_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt",
                Title = "Import Book List"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                await ImportBooksAsync(filePath);
            }
        }
    }
}
