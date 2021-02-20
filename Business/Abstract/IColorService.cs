using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();
        List<Color> GetAllById(int colorId);

        IResult Add(Color color);
        IResult Update(Color color);
        IResult Delete(Color color);
    }
}
