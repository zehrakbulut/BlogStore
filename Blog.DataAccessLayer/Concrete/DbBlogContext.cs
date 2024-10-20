using Blog.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccessLayer.Concrete
{
    public class DbBlogContext:DbContext
    {
        public DbBlogContext(DbContextOptions<DbBlogContext> options) : base(options)
        {

        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Information> Informations { get; set; }
        public DbSet<Map> Maps { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
    }
}
