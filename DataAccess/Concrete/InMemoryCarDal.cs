using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarRentalDal<Car>
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car { Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 100, ModelYear = "2015", Description = " Arac 1" },
                new Car { Id = 2, BrandId = 1, ColorId = 2, DailyPrice = 100, ModelYear = "2020", Description = " Arac 2" },
                new Car { Id = 3, BrandId = 2, ColorId = 1, DailyPrice = 150, ModelYear = "2015", Description = " Arac 3" },
                new Car { Id = 4, BrandId = 2, ColorId = 3, DailyPrice = 150, ModelYear = "2020", Description = " Arac 4" },
                new Car { Id = 5, BrandId = 3, ColorId = 5, DailyPrice = 200, ModelYear = "2015", Description = " Arac 5" },
                new Car { Id = 6, BrandId = 3, ColorId = 4, DailyPrice = 200, ModelYear = "2020", Description = " Arac 6" }
            };

        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(c => c.Id == id);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
