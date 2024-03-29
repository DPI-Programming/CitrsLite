﻿using CitrsLite.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrsLite.Data.Entity
{
    public class CitrsLiteContext : DbContext
    {
        private readonly string _connectionString;

        public DbSet<Participant> Participants { get; set; }
        public DbSet<VarietyClone> VarietyClones { get; set; }
        public DbSet<Tree> Trees { get; set; }
        public DbSet<TreeType> TreeTypes { get; set; }
        public DbSet<TreeLocation> TreeLocations { get; set; }
        public DbSet<Budwood> Budwoods { get; set; }
        public DbSet<Registration> Registrations { get; set; }


        public CitrsLiteContext(string connectionString)
        {
            _connectionString = connectionString;            
        }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }                      
        
    }
}
