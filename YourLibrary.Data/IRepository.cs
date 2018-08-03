using System;
using System.Collections.Generic;
using System.Text;
using YourLibrary.Models;

namespace YourLibrary.Data
{
    public interface IRepository<T> where T:BaseEntity, new()
    {
        T Get(string id);
        IEnumerable<T> GetAll();
        void Insert(T entity);
        void Update(T entity);
        void Delete(string id);        
    }
}
