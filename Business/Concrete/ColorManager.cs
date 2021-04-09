using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colordal;

        public ColorManager(IColorDal colordal)
        {
            _colordal = colordal;
        }

        public void Add(Color color)
        {
            _colordal.Add(color);
        }

        public void Delete(Color color)
        {
            _colordal.Delete(color);
        }

        public List<Color> GetAll()
        {
            return _colordal.GetAll();
        }

        public Color GetColorByColorId(int colorid)
        {
            return _colordal.Get(c=>c.ColorId==colorid);
        }

        

        public void Insert(Color color)
        {
            throw new NotImplementedException();
        }

        public void Update(Color color)
        {
            _colordal.Update(color);
        }
    }
}
