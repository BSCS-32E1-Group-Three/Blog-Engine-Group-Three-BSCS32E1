using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Blog_Engine.Models;

namespace Blog_Engine.Data
{
    public class Blog_EngineContext : DbContext
    {
        public Blog_EngineContext (DbContextOptions<Blog_EngineContext> options)
            : base(options)
        {
        }

        public DbSet<Blog_Engine.Models.Blog> Blog { get; set; } = default!;
    }
}
