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
    public class RecipeManager : IRecipeService
    {
        private readonly IRecipeDal _recipeDal;

        public RecipeManager(IRecipeDal recipeDal)
        {
            _recipeDal = recipeDal;
        }

        public void TDelete(int id)
        {
            _recipeDal.Delete(id);  
        }

        public List<Recipe> TGetAll()
        {
           return _recipeDal.GetAll();
        }

        public Recipe TGetByID(int id)
        {
            return _recipeDal.GetByID(id);
        }

        public void TInsert(Recipe entity)
        {
            _recipeDal.Insert(entity);
        }

        public void TUpdate(Recipe entity)
        {
            _recipeDal.Update(entity);
        }
    }
}
