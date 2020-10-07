using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using VictorP1_AP2.Models;

namespace VictorP1_AP2.DAL
{

    public class Contexto : DbContext
    {

        public DbSet<Articulos> Articulos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlite(@"Data Source= DATA\ArticulosDB.db");

        }

    }

}