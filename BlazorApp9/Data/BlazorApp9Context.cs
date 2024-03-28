using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorApp9;

namespace BlazorApp9.Data
{
    public class BlazorApp9Context : DbContext
    {
        public BlazorApp9Context (DbContextOptions<BlazorApp9Context> options)
            : base(options)
        {
        }

        public DbSet<BlazorApp9.Blog> Blog { get; set; } = default!;
    }
}
