using Microsoft.EntityFrameworkCore;
using RickyAppDLL.DomainModel;
using RickyDemo01.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace RickyAppDLL.SQLConnection
{
    public class RickyDBContextDLL : DbContext
    {
        public DbSet<AlphaUser> Users { get; set; }
        
        private readonly string _DBPath;

        public RickyDBContextDLL(string Path)
        {
            _DBPath = Path;
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlite($"Filename={_DBPath}");
        }


    }
}
