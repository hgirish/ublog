using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using uBlog.Data.Entities;

namespace uBlog.Data
{
    public  interface IBlogContext
    {
        DbSet<Post> Posts { get; set; }

        bool EnsureCreated();
    }
}
