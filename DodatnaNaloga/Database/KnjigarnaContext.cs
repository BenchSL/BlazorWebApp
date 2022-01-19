using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DodatnaNaloga.Models
{
    public class KnjigarnaContext : DbContext
    {
        public DbSet<Knjiga> knjige { get; set; }
        public DbSet<Avtor> avtorji { get; set; }
        public DbSet<Stranka> stranke { get; set; }
        public DbSet<Uporabnik> Uporabniki { get; set; }

        //public KnjigarnaContext()
        //{

        //}

        //public KnjigarnaContext(DbContextOptions<KnjigarnaContext> options)
        //    : base(options)
        //{
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DodatnaNaloga.Models.KnjigarnaContext;Integrated Security=True;Connect Timeout=5;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


    }
}
