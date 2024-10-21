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
    public class InformationManager : IInformationService
    {
        private readonly IInformationDal _informationDal;

        public InformationManager(IInformationDal informationDal)
        {
            _informationDal = informationDal;
        }

        public void TDelete(int id)
        {
            _informationDal.Delete(id);
        }

        public List<Information> TGetAll()
        {
            return _informationDal.GetAll();
        }

        public Information TGetByID(int id)
        {
            return _informationDal.GetByID(id);
        }

        public void TInsert(Information entity)
        {
            _informationDal.Insert(entity);
        }

        public void TUpdate(Information entity)
        {
           _informationDal.Update(entity);
        }
    }
}
