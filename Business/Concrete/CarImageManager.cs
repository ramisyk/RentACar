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
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _imageDal;

        public CarImageManager(ICarImageDal imageDal)
        {
            _imageDal = imageDal;
        }

        public IResult Add(CarImage image)
        {
            image.Date = DateTime.Now;
            _imageDal.Add(image);
            return new SuccessResult(Messages.ImageAdded);
        }

        public IResult Delete(CarImage image)
        {
            _imageDal.Delete(image);
            return new SuccessResult(Messages.ImageDeleted);
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_imageDal.GetAll(), Messages.ImagesListed);
        }

        public IResult Update(CarImage image)
        {
            throw new NotImplementedException();
        }
    }
}
