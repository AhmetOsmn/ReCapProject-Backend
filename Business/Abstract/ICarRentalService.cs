using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarRentalService<T>
    {
        List<T> GetAll();
    }
}
