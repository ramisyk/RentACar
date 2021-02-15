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
        }

        private static void AddCarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car = new Car { BrandId = 4, ColorId = 2, DailyPrice = 720, ModelYear = 2021, Description = "NewCar" };
            carManager.Add(car);
            ListCarsTest();
        }

        private static void ListCarsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description + "'s Daily Price : " + car.DailyPrice.ToString());
            }
        }
    }
}
