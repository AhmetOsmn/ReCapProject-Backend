using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static CarManager carManager;
        static BrandManager brandManager;
        static ColorManager colorManager;
        static void Main(string[] args)
        {

            carManager = new CarManager(new InMemoryCarDal());
            brandManager = new BrandManager(new InMemoryBrandDal());
            colorManager = new ColorManager(new InMemoryColorDal());

            Console.WriteLine("1. LISTE --------------------------------------------------------------------------------------------------------");
            ShowCars();

            Console.WriteLine("ARABA EKLENDI ---------------------------------------------------------------------------------------------------");
            carManager.Add(new Car { Id = 7, BrandId = 5, ColorId = 4, DailyPrice = 500, ModelYear = "2000", Description = "Son arac" });
            ShowCars();

            Console.WriteLine("ARABA CIKARTILDI ------------------------------------------------------------------------------------------------");
            carManager.Delete(carManager.GetById(1));
            ShowCars();

            Console.WriteLine("3. ARAC GUNCELLENDI ---------------------------------------------------------------------------------------------");
            carManager.GetById(3).ColorId = 5;
            carManager.Update(carManager.GetById(3));
            ShowCars();
        }

        public static void ShowCars()
        {
            

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id +
                    " : Marka --> " + brandManager.GetById(car.BrandId).Name +
                    " : Renk --> " + colorManager.GetById(car.ColorId).Name +
                    " : Yil --> " + car.ModelYear +
                    " : Gunluk Ucret --> " + car.DailyPrice +
                    " : Aciklama --> " + car.Description);
            }
        }
    }
}
