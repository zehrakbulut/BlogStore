using Blog.BusinessLayer.Abstract;
using Blog.DataAccessLayer.Abstract;
using Blog.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.BusinessLayer.Concrete
{
    public class MapManager : IMapService
    {
        private readonly IMapDal _mapDal;

        public MapManager(IMapDal mapDal)
        {
            _mapDal = mapDal;
        }

        public void TDelete(int id)
        {
            _mapDal.Delete(id); 
        }

        public List<Map> TGetAll()
        {
            return _mapDal.GetAll();
        }

        public Map TGetByID(int id)
        {
            return _mapDal.GetByID(id);
        }

        public void TInsert(Map entity)
        {
            _mapDal.Insert(entity);
        }

        public void TUpdate(Map entity)
        {
            _mapDal.Update(entity);
        }
    }
}
