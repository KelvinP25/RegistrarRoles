using Microsoft.EntityFrameworkCore;
using RegistrarRolesWpf.ENTIDADES;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegistrarRolesWpf.DAL
{
    public class Contexto: DbContext
    {
        public DbSet<Roles> roles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= DATA\RollInicio.db");
        }
    }
}
