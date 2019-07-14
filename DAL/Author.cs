using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirst.DAL
{
    public class Author
    {
        public int id { get; set; }
        public string name { get; set; }
        public string  role { get; set; }
    }


    public class BlogContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
    }



}