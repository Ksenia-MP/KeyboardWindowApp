using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyboardWIndowApp.DataBase
{
    public class Context : DbContext
    {

        public DbSet<Users> Users { get; set; }
        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Keyboard> Keyboards { get; set; }
        public DbSet<Statistics> Statistics { get; set; }
        public DbSet<TypeZone> TypeZones { get; set; }


        public Context()
        {
            Database.EnsureCreated();
        }

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var uriString = "postgresql://uh1srox1yttftbmstrtu:MNcNeVRlYXdW1aPbHlvR@byejp0mzelrxtjzryxfd-postgresql.services.clever-cloud.com:5432/byejp0mzelrxtjzryxfd";
            var uri = new Uri(uriString);
            var db = uri.AbsolutePath.Trim('/');
            var user = uri.UserInfo.Split(':')[0];
            var passwd = uri.UserInfo.Split(':')[1];
            var port = uri.Port > 0 ? uri.Port : 5432;
            var connStr = string.Format("Server={0};Database={1};User Id={2};Password={3};Port={4}",
                uri.Host, db, user, passwd, port);
            optionsBuilder.UseNpgsql(connStr);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>().HasAlternateKey(u => u.Login);
            modelBuilder.Entity<Users>().HasKey(u => u.Id);

            modelBuilder.Entity<Difficulty>().HasKey(d => d.Id);

            modelBuilder.Entity<Exercise>().HasKey(e => e.Id);
            modelBuilder.Entity<Exercise>().HasAlternateKey(e => e.Name);
            modelBuilder.Entity<Exercise>().HasOne(e => e.Difficulty);

            modelBuilder.Entity<TypeZone>().HasKey(t => t.Id);
            modelBuilder.Entity<TypeZone>().HasOne(t => t.Difficulty);
            //modelBuilder.Entity<TypeZone>().HasOne(e => e.Keyboard);

            modelBuilder.Entity<Statistics>().HasOne(s => s.Users);
            modelBuilder.Entity<Statistics>().HasOne(s => s.Exercise);
            modelBuilder.Entity<Statistics>().HasKey(s => s.Id);

        }
    }
}