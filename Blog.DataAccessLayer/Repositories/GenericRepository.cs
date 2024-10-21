using Blog.DataAccessLayer.Abstract;
using Blog.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly DbBlogContext _blogContext;

        public GenericRepository(DbBlogContext blogContext)
        {
            _blogContext = blogContext;
        }

        public void Delete(int id)
        {
            _blogContext.Remove(id);
            _blogContext.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _blogContext.Set<T>().ToList();
        }

        public T GetByID(int id)
        {
            return _blogContext.Set<T>().Find(id);
        }

        public void Insert(T entity)
        {
            _blogContext.Add(entity);
            _blogContext.SaveChanges();
        }

        public void Update(T entity)
        {
            _blogContext.Update(entity);
            _blogContext.SaveChanges();
        }
    }
}
