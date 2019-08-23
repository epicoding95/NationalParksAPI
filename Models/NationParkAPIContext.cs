using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NationParkAPI.Models
{
    public class NationParkContext : DbContext
    {
        public NationParkContext(DbContextOptions<NationParkContext> options)
            : base(options)
        {
        }

        public DbSet<NationParkAPI.Models.Park> Parks { get; set; }
    }
}