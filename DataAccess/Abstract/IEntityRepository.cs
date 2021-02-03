using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T>
    {
        T GetById(int id);
        List<T> GetAll();
        void Add(T t);
        void Update(T t);
        void Delete(T t);
    }
}
