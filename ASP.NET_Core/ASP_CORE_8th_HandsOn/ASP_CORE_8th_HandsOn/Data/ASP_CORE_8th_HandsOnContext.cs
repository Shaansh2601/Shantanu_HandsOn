using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASP_CORE_8th_HandsOn.Models;

namespace ASP_CORE_8th_HandsOn.Data
{
    public class ASP_CORE_8th_HandsOnContext : DbContext
    {
        public ASP_CORE_8th_HandsOnContext (DbContextOptions<ASP_CORE_8th_HandsOnContext> options)
            : base(options)
        {
        }

        public DbSet<ASP_CORE_8th_HandsOn.Models.Account> Account { get; set; }
    }
}
