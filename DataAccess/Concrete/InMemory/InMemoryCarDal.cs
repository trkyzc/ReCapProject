using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars; //Bellekte datamız varmış da biz onu yönetiyormuşuz gibi simule edecez.Bundan dolayı ctor kullanıyoruz.
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
            new Car {Id=1,BrandId=1,ColorId=1,DailyPrice=200,ModelYear="2005",Description="Peugeot 206" },
            new Car {Id=2,BrandId=2,ColorId=3,DailyPrice=350,ModelYear="2009",Description="Audi"},
            new Car {Id=3,BrandId=3,ColorId=2,DailyPrice=500,ModelYear="2018",Description="Nissan"}
            };
        }

       
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car) //Referans tipler referans no ile çalışır.Direk remove(car) yapamayız.Çünkü arayüzden gönderdiğimiz car'ın biligileri aynı olsa da referansı farklı oluyor.Bizim silinecek nesnenin referansını almamız lazım.
        {
            
            Car carToDelete=_cars.SingleOrDefault(c=>c.Id==car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c=>c.Id==Id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdated=_cars.SingleOrDefault(c=>c.Id==car.Id);
            carToUpdated.ColorId = car.ColorId;
            carToUpdated.BrandId = car.BrandId;
            carToUpdated.ModelYear = car.ModelYear;
            carToUpdated.DailyPrice = car.DailyPrice;
            carToUpdated.Description = car.Description;
        }

        Car IEntityRepository<Car>.Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
