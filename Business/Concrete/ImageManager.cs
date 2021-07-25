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
    public class ImageManager : IImageService
    {
        IImageDal _imageDal;

        public ImageManager(IImageDal imageDal)
        {
            _imageDal = imageDal;
        }

        public IResult Add(Image image)
        {
            _imageDal.Add(image);
            return new SuccessResult(Messages.ImageAdded);
        }

        public IResult Delete(Image image)
        {
            _imageDal.Delete(image);
            return new SuccessResult(Messages.ImageDeleted);
        }

        public IDataResult<List<Image>> GetAll()
        {
              return new SuccessDataResult<List<Image>>(_imageDal.GetAll(), Messages.ImagesListed)  
        }

        public IResult Update(Image image)
        {
            throw new NotImplementedException();
        }
    }
}
