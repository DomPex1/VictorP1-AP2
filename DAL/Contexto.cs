using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace VictorP1_AP2.DAL
{

    public class Contexto : DbContext
    {

        public DbSet<Articulos> Articulos { get; set; }

        public override void onConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlite(@"Data Source= DATA\ArticulosDB.db");

        }

    }

}