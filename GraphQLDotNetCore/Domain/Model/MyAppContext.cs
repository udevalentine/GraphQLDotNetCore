using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDotNetCore.Domain.Model
{
    public class MyAppContext:DbContext
    {
        public MyAppContext(DbContextOptions<MyAppContext> options)
       : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            modelBuilder.Entity<Gender>().HasData(
                new Gender() { Id = 1, Active = true, Name = "Male" },
                new Gender() { Id = 2, Active = true, Name = "Female" }
             );
            modelBuilder.Entity<Lga>().HasData(
                new Lga() { Id = 1, Active = true, Name = "Udi", StateId = 14 },
                new Lga() { Id = 2, Active = true, Name = "Oji-River", StateId = 14 },
                new Lga() { Id = 3, Active = true, Name = "Nsukka", StateId = 14 },
                new Lga() { Id = 4, Active = true, Name = "Ogwu", StateId = 14 },
                new Lga() { Id = 5, Active = true, Name = "Enugu", StateId = 14 },
                new Lga() { Id = 6, Active = true, Name = "Eziagu", StateId = 14 },
                new Lga() { Id = 7, Active = true, Name = "Ilaro", StateId = 28 },
                new Lga() { Id = 8, Active = true, Name = "Obiakpo", StateId = 33 },
                new Lga() { Id = 9, Active = true, Name = "Port-Harcourt", StateId = 33 },
                new Lga() { Id = 10, Active = true, Name = "Degema", StateId = 33 }
             );
            modelBuilder.Entity<GeoPoliticalZone>().HasData(
              new GeoPoliticalZone() { Id = 1, Active = true, Name = "North Central" },
              new GeoPoliticalZone() { Id = 2, Active = true, Name = "North East" },
              new GeoPoliticalZone() { Id = 3, Active = true, Name = "North West" },
              new GeoPoliticalZone() { Id = 4, Active = true, Name = "South East" },
              new GeoPoliticalZone() { Id = 5, Active = true, Name = "South South" },
              new GeoPoliticalZone() { Id = 6, Active = true, Name = "South West" }

              );
            modelBuilder.Entity<State>().HasData(
             new State() { Id = 1, Active = true, Name = "Abia", GeoPoliticalZoneId = 4 },
             new State() { Id = 2, Active = true, Name = "Adamawa", GeoPoliticalZoneId = 2 },
             new State() { Id = 3, Active = true, Name = "Akwa-Ibom", GeoPoliticalZoneId = 5 },
             new State() { Id = 4, Active = true, Name = "Anambra", GeoPoliticalZoneId = 4 },
             new State() { Id = 5, Active = true, Name = "Bauchi", GeoPoliticalZoneId = 2 },
             new State() { Id = 6, Active = true, Name = "Bayelsa", GeoPoliticalZoneId = 5 },
             new State() { Id = 7, Active = true, Name = "Benue", GeoPoliticalZoneId = 1 },
             new State() { Id = 8, Active = true, Name = "Borno", GeoPoliticalZoneId = 2 },
             new State() { Id = 9, Active = true, Name = "Cross-Rivers", GeoPoliticalZoneId = 5 },
             new State() { Id = 10, Active = true, Name = "Delta", GeoPoliticalZoneId = 5 },
             new State() { Id = 11, Active = true, Name = "Ebonyi", GeoPoliticalZoneId = 4 },
             new State() { Id = 12, Active = true, Name = "Edo", GeoPoliticalZoneId = 5 },
             new State() { Id = 13, Active = true, Name = "Ekiti", GeoPoliticalZoneId = 6 },
             new State() { Id = 14, Active = true, Name = "Enugu", GeoPoliticalZoneId = 4 },
             new State() { Id = 15, Active = true, Name = "FCT Abuja", GeoPoliticalZoneId = 1 },
             new State() { Id = 16, Active = true, Name = "Gombe", GeoPoliticalZoneId = 2 },
             new State() { Id = 17, Active = true, Name = "Imo", GeoPoliticalZoneId = 5 },
             new State() { Id = 18, Active = true, Name = "Jigawa", GeoPoliticalZoneId = 3 },
             new State() { Id = 19, Active = true, Name = "Kaduna", GeoPoliticalZoneId = 3 },
             new State() { Id = 20, Active = true, Name = "Kano", GeoPoliticalZoneId = 3 },
             new State() { Id = 21, Active = true, Name = "Katsina", GeoPoliticalZoneId = 3 },
             new State() { Id = 22, Active = true, Name = "Kebbi", GeoPoliticalZoneId = 3 },
             new State() { Id = 23, Active = true, Name = "Kogi", GeoPoliticalZoneId = 1 },
             new State() { Id = 24, Active = true, Name = "Kwara", GeoPoliticalZoneId = 1 },
             new State() { Id = 25, Active = true, Name = "Lagos", GeoPoliticalZoneId = 6 },
             new State() { Id = 26, Active = true, Name = "Nassarawa", GeoPoliticalZoneId = 1 },
             new State() { Id = 27, Active = true, Name = "Niger", GeoPoliticalZoneId = 1 },
             new State() { Id = 28, Active = true, Name = "Ogun", GeoPoliticalZoneId = 6 },
             new State() { Id = 29, Active = true, Name = "Ondo", GeoPoliticalZoneId = 6 },
             new State() { Id = 30, Active = true, Name = "Osun", GeoPoliticalZoneId = 6 },
             new State() { Id = 31, Active = true, Name = "Oyo", GeoPoliticalZoneId = 6 },
             new State() { Id = 32, Active = true, Name = "Plateau", GeoPoliticalZoneId = 1 },
             new State() { Id = 33, Active = true, Name = "Rivers", GeoPoliticalZoneId = 5 },
             new State() { Id = 34, Active = true, Name = "Sokoto", GeoPoliticalZoneId = 3 },
             new State() { Id = 35, Active = true, Name = "Taraba", GeoPoliticalZoneId = 2 },
             new State() { Id = 36, Active = true, Name = "Yobe", GeoPoliticalZoneId = 2 },
             new State() { Id = 37, Active = true, Name = "Zamfara", GeoPoliticalZoneId = 3 }
             );
            modelBuilder.Entity<Role>().HasData(
                new Role() { Id = 1, Active = true, Name = "Admin" },
                new Role() { Id = 2, Active = true, Name = "SuperAdmin" },
                new Role() { Id = 3, Active = true, Name = "Student" },
                new Role() { Id = 4, Active = true, Name = "Agent" }
             );
        }
        public DbSet<GeoPoliticalZone> USER { get; set; }
        public DbSet<Role> PERSON { get; set; }
        public DbSet<State> STATE { get; set; }
        public DbSet<Lga> LGA { get; set; }
        public DbSet<Gender> GENDER { get; set; }
    }
}
