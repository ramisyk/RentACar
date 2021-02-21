using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        //dependency on abstract so loosely coupled
        //add singleton for not new() for service and manager
        ICarService _carService;
        public CarsController(ICarService carService)
        {
            _carService = carService;
        }
        
        [HttpGet]
        public List<Car> Get()
        {
            //Dependency chain 
            //ICarService carService = new CarManager(new EfCarDal());
            var result = _carService.GetAll();
            return result.Data;
        }
    }
}
