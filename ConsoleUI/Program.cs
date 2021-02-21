using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ListCarsTest();
            //AddCarTest();
            //ListBrandTest();
            //ListColorTest();
            //AddCustomerTest();
            //CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var car in carManager.GetRentalDetails().Data)
            //{
            //    Console.Write(car.CarName + "-" + car.RentDate + "-");
                
            //}

        }

        private static void AddCustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            Customer customer = new Customer { UserId = 1, CompanyName = "Abc Haber" };
            customerManager.Add(customer);
        }

        private static void ListColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void ListBrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void AddCarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car = new Car { BrandId = 4, ColorId = 2, DailyPrice = 720, ModelYear = 2021, Description = "NewCar" };
            carManager.Add(car);
            Console.WriteLine(carManager.Add(car).Message);
            ListCarsTest();
        }

        private static void ListCarsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.CarName + "-" + car.BrandName + "-" + car.ColorName + "-" + car.DailyPrice);
            }
        }
    }
}
