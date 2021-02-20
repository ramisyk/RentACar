using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

        public IResult Add(Car car)
        {
            Console.WriteLine("Add Car çalıştı");
            if (car.DailyPrice > 0 && car.Description.Length > 2)
            {
                _carDal.Add(car);
                return new SuccessResult(Messages.CarAdded);
            }
            return new ErrorResult(Messages.CarNameInvalid);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult("Araç Silindi");
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

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult("Araç Güncellendi");
        }
    }
}
