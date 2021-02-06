using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
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
            carManager = new CarManager(new EfCarDal());
            brandManager = new BrandManager(new EfBrandDal());
            colorManager = new ColorManager(new EfColorDal());

            ShowCarsEf();
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            ShowCarsEfByColorId(1);
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><><><><><><><><><>");
            ShowCarsEfByBrandId(1);
        }

        public static void ShowCarsEf()
        {
            Console.WriteLine("-------BUTUN ARACLAR------ -");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Arac Id: "+car.CarId + "-->" +
                                  "Marka: "+brandManager.GetById(car.BrandId).Name + " " +
                                  "Model: "+brandManager.GetById(car.BrandId).Model + " " +
                                  "Renk: "+colorManager.GetById(car.ColorId).Name + " " +
                                  "Yil: "+car.ModelYear + " " +
                                  "Aciklama: "+car.Description);
            }
        }
        public static void ShowCarsEfByColorId(int i)
        {
            Console.WriteLine("ColorId= {0} OLAN ARACLAR", i);

            foreach (var car in carManager.GetCarsByColorId(i))
            {
                Console.WriteLine("Arac Id: " + car.CarId + ":" +
                                  brandManager.GetById(car.BrandId).Name + " " +
                                  brandManager.GetById(car.BrandId).Model + " " +
                                  colorManager.GetById(car.ColorId).Name + " " +
                                  car.ModelYear + " " +
                                  car.Description);
            }
        }
        public static void ShowCarsEfByBrandId(int i)
        {
            Console.WriteLine("BrandId= {0} OLAN ARACLAR", i);

            foreach (var car in carManager.GetCarsByBrandId(i))
            {
                Console.WriteLine("Arac Id: " + car.CarId + ":" +
                                  brandManager.GetById(car.BrandId).Name + " " +
                                  brandManager.GetById(car.BrandId).Model + " " +
                                  colorManager.GetById(car.ColorId).Name + " " +
                                  car.ModelYear + " " +
                                  car.Description);
            }
        }
    }
}
