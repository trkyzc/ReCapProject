using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal) //Dependency injection
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice>0 && car.CarName.Length>=2)
            {
                _carDal.Add(car);
                Console.WriteLine("Operation successful.");
            }
            else
            {
                Console.WriteLine("Operation failed.");
            }
            
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int brandid)
        {
            return _carDal.GetAll(p=>p.BrandId==brandid);
        }

        public List<Car> GetCarsByColorId(int colorid)
        {
            return _carDal.GetAll(p=>p.ColorId==colorid);
        }
    }
}
