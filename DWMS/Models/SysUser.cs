using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DWMS.Web.Models
{
    [Table("SysUser")]
    public class SysUser
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
