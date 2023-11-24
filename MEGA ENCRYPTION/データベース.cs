using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEGA_ENCRYPTION
{
    public sealed class データベース : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder 选项生成器)
        {
            var 天空 = 密码.德康();
            选项生成器.UseMySQL(天空);
        }

        public DbSet<ACTIVATION> Activation { get; set; }
    }
}
