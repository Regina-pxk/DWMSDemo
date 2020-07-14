using DWMS.Web.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DWMS.Web.Data
{
    public class DefaultContext : DbContext
    {
        public DefaultContext(DbContextOptions<DefaultContext> options)
            : base(options)
        { }
        public DbSet<SysUser> SysUser { get; set; }
    }
}
