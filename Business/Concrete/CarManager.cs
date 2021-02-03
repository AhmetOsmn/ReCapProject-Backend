﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarRentalService<Car>
    {
        IEntityRepository<Car> _carDal;
        public CarManager(IEntityRepository<Car> carRentalDal)
        {
            _carDal = carRentalDal;
        }
        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
        public Car GetById(int id)
        {
            return _carDal.GetById(id);
        }

        public void Add(Car car)
        {
            _carDal.Add(car);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }
        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
