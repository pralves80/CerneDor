using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CerneDor.Models;

namespace CerneDor.Data
{
    public class CerneDorContext : DbContext
    {
        public CerneDorContext (DbContextOptions<CerneDorContext> options)
            : base(options)
        {
        }

        public DbSet<CerneDor.Models.Convenio> Convenio { get; set; }
    }
}
