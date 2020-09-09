using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Nop.Web.Models
{
    public class bankcontex : DbContext
    {
        public bankcontex(DbContextOptions<bankcontex> options) : base(options)

	        { 

	        }

        public DbSet<Manufacturer> Manufacturer { get; set; }
    }
}
