using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardWIndowApp.DataBase
{
    public class Conteeeeeeeext : DbContext
    {

        public DbSet<Users> Users { get; set; }

        public Conteeeeeeeext()
        {
            Database.EnsureCreated();
        }

        public Conteeeeeeeext(DbContextOptions<Conteeeeeeeext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var uriString = "postgres://ysiclzkh:HmvxBycjVkGCNqFAohzBTLXgn5-ikbu-@tyke.db.elephantsql.com/ysiclzkh";
            var uri = new Uri(uriString);
            var db = uri.AbsolutePath.Trim('/');
            var user = uri.UserInfo.Split(':')[0];
            var passwd = uri.UserInfo.Split(':')[1];
            var port = uri.Port > 0 ? uri.Port : 5432;
            var connStr = string.Format("Server={0};Database={1};User Id={2};Password={3};Port={4}",
                uri.Host, db, user, passwd, port);
            optionsBuilder.UseNpgsql(connStr);
        }
    }
}