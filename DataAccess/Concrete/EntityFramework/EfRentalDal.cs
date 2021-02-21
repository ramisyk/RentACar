using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarsDbContext>, IRentalDal
    {
        public List<RentalDetailDto> GetAllRentalDetail()
        {
            using (CarsDbContext context = new CarsDbContext())
            {
                var result = from rental in context.Rentals
                             join car in context.Cars
                             on rental.CarId equals car.CarId
                             join customer in context.Customers
                             on rental.CustomerId equals customer.CustomerId
                             join user in context.Users
                             on customer.UserId equals user.UserId
                             select new RentalDetailDto
                             {
                                 FirstName = user.FirstName,
                                 LastName = user.LastName,
                                 CarName = car.Description,
                                 CarId = car.CarId,
                                 DailyPrice = car.DailyPrice,
                                 ReturnDate = rental.ReturnDate,
                                 RentDate = rental.RentDate
                             };

                return result.ToList();
            }

        }
    }
}
