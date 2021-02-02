using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarRentalService<T>
    {
        List<T> GetAll();
        T GetById(int id);
        void Add(T t);
        void Delete(T t);
        void Update(T t);
    }
}
