using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : ICarRentalService<Brand>
    {
        IEntityRepository<Brand> _brandDal;

        public BrandManager(IEntityRepository<Brand> carRentalDal)
        {
            _brandDal = carRentalDal;
        }
        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetById(int id)
        {
            return _brandDal.Get(p => p.BrandId == id);
        }
        public void Add(Brand brand)
        {
            if (brand.Name.Length >= 2)
            {
                _brandDal.Add(brand);
            }
            else
            {
                Console.WriteLine("Marka ismi en az 2 harften olusmali");
            }
            
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
        }
        public void Update(Brand brand)
        {
            _brandDal.Update(brand);
        }

    }
}
