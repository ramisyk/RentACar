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
            return _carDal.GetAll(p => p.BrandId == brandId);
        }

        public List<Car> GetAllByColorId(int colorId)
        {
            return _carDal.GetAll(p => p.ColorId == colorId);
        }

        public List<Car> GetAllByDailyPrice(int min, int max)
        {
            return _carDal.GetAll(p => p.DailyPrice >= min && p.DailyPrice <= max);
        }

        public List<Car> GetAllByModelYear(int min, int max)
        {
            return _carDal.GetAll(p => p.ModelYear >= min && p.ModelYear <= max);
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
