using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine(car.DailyPrice);
            }

            carManager.Add(new Car {CarName="Audi A4",BrandId = 2, ColorId = 1, DailyPrice = 500, ModelYear = "2008", Description = "Daily Car" });
        }
       
    }
}
