using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetAllByBrandId(int brandId);
        List<Car> GetAllByColorId(int colorId);
        List<Car> GetAllByModelYear(int min, int max);
        List<Car> GetAllByDailyPrice(int min, int max);

        Car GetByBrandId(int brandId);

        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);

        List<CarDetailDto> GetCarDetails();
    }
}
