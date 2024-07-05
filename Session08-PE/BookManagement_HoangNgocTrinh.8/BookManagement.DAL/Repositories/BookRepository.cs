using BookManagement.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BookManagement.DAL.Repositories
{
    public class BookRepository
    {
        private BookManagementDbContext _context;

        public List<Book> GetAll()
        {
            _context = new BookManagementDbContext();
            return _context.Books.Include("BookCategory").ToList();
        }

        public void Create(Book book)
        {
            _context = new BookManagementDbContext();
            _context.Books.Add(book);
            _context.SaveChanges();
        }
        //======Update thông thường nhưng sai theo logic vì không update được khóa ngoại
        //public void Update(Book book)
        //{
        //    _context = new BookManagementDbContext();
        //    _context.Books.Update(book);
        //    _context.SaveChanges();
        //}
        //==============================Update đúng cấu trúc===================================
        public void Update(Book book)
        {
            _context = new BookManagementDbContext();
            var existingBook = _context.Books.Include(b => b.BookCategory)
                                             .FirstOrDefault(b => b.BookId == book.BookId);

            //Không dùng lambda thì làm theo kiểu foreach nhưng tốn thời gian và khó tư duy hơn

            //Book existingBook = null;
            //foreach (var b in _context.Books.Include("BookCategory"))
            //{
            //    if (b.BookId == book.BookId)
            //    {
            //        existingBook = b;
            //        break;
            //    }
            //}
            if (existingBook != null)
            {
                existingBook.BookName = book.BookName;
                existingBook.Description = book.Description;
                existingBook.PublicationDate = book.PublicationDate;
                existingBook.Quantity = book.Quantity;
                existingBook.Price = book.Price;
                existingBook.Author = book.Author;
                existingBook.BookCategoryId = book.BookCategoryId;
                _context.SaveChanges();
            }
        }

        public void Delete(int bookId)
        {
            _context = new BookManagementDbContext();
            var book = _context.Books.Find(bookId);
            if (book != null)
            {
                _context.Books.Remove(book);
                _context.SaveChanges();
            }
        }
    }
}
