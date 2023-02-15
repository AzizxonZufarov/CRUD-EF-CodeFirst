using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUD_EF_CodeFirst.Models;

namespace CRUD_EF_CodeFirst.Data
{
    public class CRUD_EF_CodeFirstContext : DbContext
    {
        public CRUD_EF_CodeFirstContext (DbContextOptions<CRUD_EF_CodeFirstContext> options)
            : base(options)
        {
        }

        public DbSet<CRUD_EF_CodeFirst.Models.Student> Student { get; set; } = default!;
    }
}
