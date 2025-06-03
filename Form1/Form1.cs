using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace Form1
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
            public string title { get; set; }
            public int AuthorId { get; set; }
            public virtual Author Author { get; set; }
        }

        public void AddAuthorwithBook(string authorName, string BookTitle)
        {
            using (var context = new BookstoreContext())
            {
                var author = new Author { Name = authorName };
                var book = new Book { title = BookTitle, Author = author };

                context.Add(author);
                context.Add(book);
                context.SaveChanges();

            }
        }

        public List<string> DisplayBooks()
        {
            using (var context = new BookstoreContext())
            {
                return context.Books.Include(b => b.Author)
                    .Select(b => $"Book: {b.title}, Author: {b.Author.Name}")
                    .ToList();
            }
        }


        public void UpdateBookTitle(int bookId, string newTitle)
        {
            using (var context = new BookstoreContext())
            {
                var book = context.Books.Find(bookId);
                if (book != null)
                {
                    book.title = newTitle;
                    context.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Book not found.");
                }
            }
        }

        //  Delete book by BookID
        public void DeleteBook(int bookId)
        {
            using (var context = new BookstoreContext())
            {
                var book = context.Books.Find(bookId);
                if (book != null)
                {
                    context.Books.Remove(book);
                    context.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Book not found.");
                }




            }
        }
    }
}

