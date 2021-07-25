using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ImageManager : IImageService
    {
        public IResult Add(Car car)
        {
            throw new NotImplementedException();
        }

        public IResult Add(Image image)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Car car)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Image image)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetAllByBrandId(int brandId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetAllByColorId(int colorId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetAllByDailyPrice(int min, int max)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetAllByModelYear(int min, int max)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Car> GetById(int carId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public IResult Update(Car car)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Image image)
        {
            throw new NotImplementedException();
        }

        IDataResult<List<Image>> IImageService.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
