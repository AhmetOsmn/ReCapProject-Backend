using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryBrandDal : ICarRentalDal<Brand>
    {
        List<Brand> _brands;

        public InMemoryBrandDal()
        {
            _brands = new List<Brand>
            {
                new Brand{BrandId = 1, Name = "Ford", Model = "Focus"},
                new Brand{BrandId = 2, Name = "BMW", Model = "M 39"},
                new Brand{BrandId = 3, Name = "AUDI", Model = "A3 SPORTBACK"},
                new Brand{BrandId = 4, Name = "TOYOTA", Model = "COROLLA"},
                new Brand{BrandId = 5, Name = "RANGE ROVER", Model = "VOGUE"},
            };
        }
        public void Add(Brand brand)
        {
            _brands.Add(brand);
        }

        public void Delete(Brand brand)
        {
            var brandToDelete = _brands.SingleOrDefault(b => b.BrandId == brand.BrandId);
            _brands.Remove(brandToDelete);
        }

        public List<Brand> GetAll()
        {
            return _brands;
        }

        public Brand GetById(int id)
        {
            return _brands.SingleOrDefault(b => b.BrandId == id);
        }

        public void Update(Brand brand)
        {
            var brandToUpdate = _brands.SingleOrDefault(b => b.BrandId == brand.BrandId);

            brandToUpdate.BrandId = brand.BrandId;
            brandToUpdate.Model = brand.Model;
            brandToUpdate.Name = brand.Name;
        }
    }
}
