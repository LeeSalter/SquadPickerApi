using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SquadPicker.Models;

namespace SquadPicker.Data
{
    public partial class SquadPickerContext : DbContext
    {
        public SquadPickerContext()
        {
        }

        public SquadPickerContext(DbContextOptions<SquadPickerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Formation> Formations { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<TeamPlayer> TeamPlayers { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=34.105.223.175;Initial Catalog=db_squad_picker;User ID=sqlserver;Password=W0lver!ne;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Formation>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<TeamPlayer>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.TeamPlayers)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeamPlayers_Players");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.TeamPlayers)
                    .HasForeignKey(d => d.TeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TeamPlayers_Teams");
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.HasIndex(e => e.FormationId);

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Formation)
                    .WithMany(p => p.Teams)
                    .HasForeignKey(d => d.FormationId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Teams)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Formation>().HasData(
                new Formation
                {
                    Id = Guid.NewGuid(),
                    Name = "4-4-2",
                    Goalkeepers = 1,
                    Defenders = 4,
                    Midfielders = 4,
                    Forwards = 2
                },
                new Formation
                {
                    Id = Guid.NewGuid(),
                    Name = "5-3-2",
                    Goalkeepers = 1,
                    Defenders = 5,
                    Midfielders = 3,
                    Forwards = 2
                },
                new Formation
                {
                    Id = Guid.NewGuid(),
                    Name = "4-3-3",
                    Goalkeepers = 1,
                    Defenders = 4,
                    Midfielders = 3,
                    Forwards = 3
                });
            modelBuilder.Entity<Player>().HasData(
                new Player
                {
                    Id = 1,
                    Name = "Jordan Pickford",
                    Position = Position.GOALKEEPER,
                    Validity = "player-valid",
                    UserId = Guid.Parse("4BE180EE-1AF1-4A19-A5F4-8105AD3EF124")
                },
                new Player
                {
                    Id = 2,
                    Name = "Sam Johnstone",
                    Position = Position.GOALKEEPER,
                    Validity = "player-valid",
                    UserId = Guid.Parse("4BE180EE-1AF1-4A19-A5F4-8105AD3EF124")
                },
                new Player
                {
                    Id = 3,
                    Name = "Aaron Ramsdale",
                    Position = Position.GOALKEEPER,
                    Validity = "player-valid",
                    UserId = Guid.Parse("4BE180EE-1AF1-4A19-A5F4-8105AD3EF124")
                },
                new Player
                {
                    Id = 4,
                    Name = "Trent Alexander-Arnold",
                    Position = Position.DEFENDER,
                    Validity = "player-valid",
                    UserId = Guid.Parse("4BE180EE-1AF1-4A19-A5F4-8105AD3EF124")
                },
                new Player
                {
                    Id = 5,
                    Name = "Ben Chilwell",
                    Position = Position.DEFENDER,
                    Validity = "player-valid",
                    UserId = Guid.Parse("4BE180EE-1AF1-4A19-A5F4-8105AD3EF124")
                },
                new Player
                {
                    Id = 6,
                    Name = "Conor Coady",
                    Position = Position.DEFENDER,
                    Validity = "player-valid",
                    UserId = Guid.Parse("4BE180EE-1AF1-4A19-A5F4-8105AD3EF124")
                },
                new Player
                {
                    Id = 7,
                    Name = "Reece James",
                    Position = Position.DEFENDER,
                    Validity = "player-valid",
                    UserId = Guid.Parse("4BE180EE-1AF1-4A19-A5F4-8105AD3EF124")
                },
                new Player
                {
                    Id = 8,
                    Name = "Harry Maguire",
                    Position = Position.DEFENDER,
                    Validity = "player-valid",
                    UserId = Guid.Parse("4BE180EE-1AF1-4A19-A5F4-8105AD3EF124")
                },
                new Player
                {
                    Id = 9,
                    Name = "Tyrone Mings",
                    Position = Position.DEFENDER,
                    Validity = "player-valid",
                    UserId = Guid.Parse("4BE180EE-1AF1-4A19-A5F4-8105AD3EF124")
                },
                new Player
                {
                    Id = 10,
                    Name = "Luke Shaw",
                    Position = Position.DEFENDER,
                    Validity = "player-valid",
                    UserId = Guid.Parse("4BE180EE-1AF1-4A19-A5F4-8105AD3EF124")
                },
                new Player
                {
                    Id = 11,
                    Name = "John Stones",
                    Position = Position.DEFENDER,
                    Validity = "player-valid",
                    UserId = Guid.Parse("4BE180EE-1AF1-4A19-A5F4-8105AD3EF124")
                },
                new Player
                {
                    Id = 12,
                    Name = "Kyle Walker",
                    Position = Position.DEFENDER,
                    Validity = "player-valid",
                    UserId = Guid.Parse("4BE180EE-1AF1-4A19-A5F4-8105AD3EF124")
                },
                new Player
                {
                    Id = 13,
                    Name = "Jude Bellingham",
                    Position = Position.MIDFIELDER,
                    Validity = "player-valid",
                    UserId = Guid.Parse("4BE180EE-1AF1-4A19-A5F4-8105AD3EF124")
                },
                new Player
                {
                    Id = 14,
                    Name = "Jordan Henderson",
                    Position = Position.MIDFIELDER,
                    Validity = "player-valid",
                    UserId = Guid.Parse("4BE180EE-1AF1-4A19-A5F4-8105AD3EF124")
                },
                new Player
                {
                    Id = 15,
                    Name = "Mason Mount",
                    Position = Position.MIDFIELDER,
                    Validity = "player-valid",
                    UserId = Guid.Parse("4BE180EE-1AF1-4A19-A5F4-8105AD3EF124")
                },
                new Player
                {
                    Id = 16,
                    Name = "Kalvin Phillips",
                    Position = Position.MIDFIELDER,
                    Validity = "player-valid",
                    UserId = Guid.Parse("4BE180EE-1AF1-4A19-A5F4-8105AD3EF124")
                },
                new Player
                {
                    Id = 17,
                    Name = "Declan Rice",
                    Position = Position.MIDFIELDER,
                    Validity = "player-valid",
                    UserId = Guid.Parse("4BE180EE-1AF1-4A19-A5F4-8105AD3EF124")
                },
                new Player
                {
                    Id = 18,
                    Name = "James Ward-Prowse",
                    Position = Position.MIDFIELDER,
                    Validity = "player-valid",
                    UserId = Guid.Parse("4BE180EE-1AF1-4A19-A5F4-8105AD3EF124")
                },
                new Player
                {
                    Id = 19,
                    Name = "Tammy Abraham",
                    Position = Position.FORWARD,
                    Validity = "player-valid",
                    UserId = Guid.Parse("4BE180EE-1AF1-4A19-A5F4-8105AD3EF124")
                },
                new Player
                {
                    Id = 20,
                    Name = "Phil Foden",
                    Position = Position.FORWARD,
                    Validity = "player-valid",
                    UserId = Guid.Parse("4BE180EE-1AF1-4A19-A5F4-8105AD3EF124")
                },
                new Player
                {
                    Id = 21,
                    Name = "Jack Grealish",
                    Position = Position.FORWARD,
                    Validity = "player-valid",
                    UserId = Guid.Parse("4BE180EE-1AF1-4A19-A5F4-8105AD3EF124")
                },
                new Player
                {
                    Id = 22,
                    Name = "Harry Kane",
                    Position = Position.FORWARD,
                    Validity = "player-valid",
                    UserId = Guid.Parse("4BE180EE-1AF1-4A19-A5F4-8105AD3EF124")
                },
                new Player
                {
                    Id = 23,
                    Name = "Bukayo Saka",
                    Position = Position.FORWARD,
                    Validity = "player-valid",
                    UserId = Guid.Parse("4BE180EE-1AF1-4A19-A5F4-8105AD3EF124")
                },
                new Player
                {
                    Id = 24,
                    Name = "Marcus Rashford",
                    Position = Position.FORWARD,
                    Validity = "player-valid",
                    UserId = Guid.Parse("4BE180EE-1AF1-4A19-A5F4-8105AD3EF124")
                },
                new Player
                {
                    Id = 25,
                    Name = "Raheem Sterling",
                    Position = Position.FORWARD,
                    Validity = "player-valid",
                    UserId = Guid.Parse("4BE180EE-1AF1-4A19-A5F4-8105AD3EF124")
                }
                );

            OnModelCreatingPartial(modelBuilder);
        }



        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
