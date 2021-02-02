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
        ICarRentalDal<Brand> _brandDal;

        public BrandManager(ICarRentalDal<Brand> carRentalDal)
        {
            _brandDal = carRentalDal;
        }
        public List<Brand> GetAll()
        {
            return _brandDal.GetAll();
        }

        public Brand GetById(int id)
        {
            return _brandDal.GetById(id);
        }
        public void Add(Brand brand)
        {
            _brandDal.Add(brand);
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
