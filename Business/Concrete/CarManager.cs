using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            Console.WriteLine("Add Car çalıştı");
            if (car.DailyPrice > 0 && car.Description.Length > 2)
                _carDal.Add(car);
            else
                Console.WriteLine("Günlük fiyat 0'dan büyük tanımlama 2 karakterden uzun olmalıdır.");
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetAllByBrandId(int brandId)
        {
            return _carDal.GetAll(c => c.BrandId == brandId);
        }

        public List<Car> GetAllByColorId(int colorId)
        {
            return _carDal.GetAll(c => c.ColorId == colorId);
        }

        public List<Car> GetAllByDailyPrice(int min, int max)
        {
            return _carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max);
        }

        public List<Car> GetAllByModelYear(int min, int max)
        {
            return _carDal.GetAll(c => c.ModelYear >= min && c.ModelYear <= max);
        }
        public Car GetByBrandId(int brandId)
        {
            return _carDal.Get(c => c.BrandId == brandId);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
