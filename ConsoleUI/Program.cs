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
            //Test();

            //carManagerTest();
            //brandManagerTest();
            //colorManagerTest();

            DetailsTest();
        }

        private static void DetailsTest()
        {
            Console.WriteLine("Car Name" + "\t" + "Brand Name" + "\t" + "Color Name" + "\t" + "Daily Price");
            Console.WriteLine("-----------------------------------------------------------");
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName + "\t" + car.BrandName + "\t" + car.ColorName + "\t" + car.DailyPrice);
            }
        }

        private static void carManagerTest()
        {
            //carManager.Add(new Car { BrandId = 2, ColorId = 3, DailyPrice = 650, Description = "Deneme 2", ModelYear = "2022" });
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(brandManager.GetById(car.BrandId).Name);
            }
            //carManager.Delete(carManager.GetById(1003));
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(brandManager.GetById(car.BrandId).Name);
            }
        }

        private static void brandManagerTest()
        {
            //brandManager.Add(new Brand { Name = "Tesla", Model = "5" });
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.Name + " " + brand.Model);
            }
            //brandManager.Delete(brandManager.GetById(3));
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.Name + " " + brand.Model);
            }
        }

        private static void colorManagerTest()
        {
            //colorManager.Add(new Color {Name = "Turuncu"});
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.Name + " : " + color.ColorId.ToString());
            }
            //colorManager.Delete(colorManager.GetById(1002));
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.Name);
            }
        }

        private static void Test()
        {
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
