
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpRest.Models
{
    public class DestinoDBContext : DbContext
    {
        public DestinoDBContext(DbContextOptions<DestinoDBContext> options)
            : base(options)
        { }

        public DbSet<Destino> Destinos { get; set; }
    }
}
