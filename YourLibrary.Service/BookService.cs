using System;
using System.Collections.Generic;
using YourLibrary.Data;
using YourLibrary.Models;

namespace YourLibrary.Service
{
    public class BookService : IBookService
    {
        private readonly IRepository<Book> repository;
        public BookService(IRepository<Book> repository)
        {
            this.repository = repository;
        }

        public void Delete(string id)
        {
            repository.Delete(id);
        }

        public Book Get(string id)
        {
            return repository.Get(id);
        }

        public IEnumerable<Book> GetAll()
        {
            return repository.GetAll();
        }

        public void Insert(Book entity)
        {
            repository.Insert(entity);
        }

        public void Update(Book entity)
        {
            repository.Update(entity);
        }
    }

    public interface IBookService
    {
        Book Get(string id);
        IEnumerable<Book> GetAll();
        void Insert(Book entity);
        void Update(Book entity);
        void Delete(string id);
    }
}
