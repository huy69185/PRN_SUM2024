using BookManagement.DAL.Models;
using BookManagement.DAL.Repositories;
using System.Collections.Generic;

namespace BookManagement.BLL.Services
{
    public class BookService
    {
        private BookRepository _repo = new();

        public List<Book> GetAllBooks()
        {
            return _repo.GetAll();
        }

        public void CreateBook(Book book)
        {
            _repo.Create(book);
        }

        public void UpdateBook(Book book)
        {
            _repo.Update(book);
        }

        public void DeleteBook(int bookId)
        {
            _repo.Delete(bookId);
        }
    }
}
