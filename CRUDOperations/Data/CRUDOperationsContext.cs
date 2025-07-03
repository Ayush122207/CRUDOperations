using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUDOperations.Models;

namespace CRUDOperations.Data
{
    public class CRUDOperationsContext : DbContext
    {
        public CRUDOperationsContext (DbContextOptions<CRUDOperationsContext> options)
            : base(options)
        {
        }

        public DbSet<CRUDOperations.Models.Employees> Employees { get; set; } = default!;
    }
}
