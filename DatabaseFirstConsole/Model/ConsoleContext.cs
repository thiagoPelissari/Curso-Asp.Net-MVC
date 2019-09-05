using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseFirstConsole.Model
{
    public class ConsoleContext : DbContext
    {

        private string _conn;
        public ConsoleContext(string conection)
        {
            this._conn = conection;
        }

        public DbSet<Client> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_conn);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
