using Blog.DataAccessLayer.Abstract;
using Blog.DataAccessLayer.Concrete;
using Blog.DataAccessLayer.Repositories;
using Blog.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccessLayer.EntityFramework
{
    public class EfInformationDal : GenericRepository<Information>, IInformationDal
    {
        public EfInformationDal(DbBlogContext blogContext) : base(blogContext)
        {
        }
    }
}
