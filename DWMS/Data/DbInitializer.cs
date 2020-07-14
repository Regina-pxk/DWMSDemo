using DWMS.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DWMS.Web.Data
{
    public static class DbInitializer
    {
        public static void Initialize(DefaultContext context)
        {
            context.Database.EnsureCreated();
            if (context.SysUser.Any())
            {
                return;//有数据则不插入
            }
            var users = new SysUser[]
                {
                    new SysUser{ Name = "Jack Ma"},
                    new SysUser{ Name = "Elon Musk"}
                };
            foreach (SysUser u in users)
            {
                context.SysUser.Add(u);
            }
            context.SaveChanges();
        }
    }
}
