using DataBase.Model;
using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class EDBContext: DbContext
    {
            public DbSet<Address> Address { get; set; }
            public DbSet<Branch> Branches { get; set; }
            public DbSet<CasseteRent> CasseteRents { get; set; }
            public DbSet<Cassette> Cassettes { get; set; }
            public DbSet<Genre> Genres { get; set; }
            public DbSet<Employee> Employees { get; set; }
            public DbSet<Position> Positions { get; set; }
            public DbSet<Contract> Contracts { get; set; }
            public DbSet<Login> Logins { get; set; }
            public DbSet<Customer> Customers { get; set; }
            public DbSet<ActorsTeam> ActorsTeams { get; set; }
            public DbSet<DirectorsTeam> DirectorsTeams { get; set; }
            public DbSet<Person> Persons { get; set; }
            public DbSet<Film> Films { get; set; }

            public EDBContext() : base("name=CassettesDataBase") 
            {
            }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                //modelBuilder.Entity<Branch>().OwnsOne(typeof(Address), "Address");
                //modelBuilder.Entity<ActorsTeam>().Property(p => p.actor.Id).IsRequired();
                //modelBuilder.Entity<DirectorsTeam>().Property(p => p.director.Id).IsRequired();
                //modelBuilder.Entity<ActorsTeam>().HasKey(t => new { t.ActorId, t.FilmID });
                modelBuilder.Entity<CasseteRent>().HasKey(t => new { t.CassetteID, t.ContractID });
                //modelBuilder.Entity<Employee>().HasOne(pc => pc.KeyPEr).WithOne(c => c.Id).HasForeignKey(pc => pc.ClubId);
                base.OnModelCreating(modelBuilder);
            }
    }

