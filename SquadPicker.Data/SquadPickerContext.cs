using Microsoft.EntityFrameworkCore;
using SquadPicker.Models;
using System;

namespace SquadPicker.Data
{
    public class SquadPickerContext:DbContext
    {
        private string _connectionString
        {
            get
            {
                //Obvs wouldn't leave this like this in Production. Add password to Secret Store in GCP.
                return @"Data Source=34.105.223.175;Initial Catalog=db_squad_picker;User ID=sqlserver;Password=W0lver!ne;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;";
            }
        }

        public SquadPickerContext(DbContextOptions<SquadPickerContext> options):base(options)
        {
        }

        public virtual DbSet<Player> Players { get; set; }   
        public virtual DbSet<Formation> Formations { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<TeamPlayer> TeamPlayer { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(_connectionString);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Formation>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<Player>(entity =>
            {
                entity.HasIndex(e => e.TeamId);

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.Players)
                    .HasForeignKey(d => d.TeamId);
            });

            modelBuilder.Entity<TeamPlayer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Team_Player");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.TeamPlayer)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Team_Player_Players");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.TeamPlayer)
                    .HasForeignKey(d => d.TeamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Team_Player_Teams");
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.HasIndex(e => e.FormationId);

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedDateUtc).HasColumnName("CreatedDateUTC");

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
                    Validity = "player-valid"
                },
                new Player
                {
                    Id = 2,
                    Name = "Sam Johnstone",
                    Position = Position.GOALKEEPER,
                    Validity = "player-valid"
                },
                new Player
                {
                    Id = 3,
                    Name = "Aaron Ramsdale",
                    Position = Position.GOALKEEPER,
                    Validity = "player-valid"
                },
                new Player
                {
                    Id = 4,
                    Name = "Trent Alexander-Arnold",
                    Position = Position.DEFENDER,
                    Validity = "player-valid"
                },
                new Player
                {
                    Id = 5,
                    Name = "Ben Chilwell",
                    Position = Position.DEFENDER,
                    Validity = "player-valid"
                },
                new Player
                {
                    Id = 6,
                    Name = "Conor Coady",
                    Position = Position.DEFENDER,
                    Validity = "player-valid"
                },
                new Player
                {
                    Id = 7,
                    Name = "Reece James",
                    Position = Position.DEFENDER,
                    Validity = "player-valid"
                },
                new Player
                {
                    Id = 8,
                    Name = "Harry Maguire",
                    Position = Position.DEFENDER,
                    Validity = "player-valid"
                },
                new Player
                {
                    Id = 9,
                    Name = "Tyrone Mings",
                    Position = Position.DEFENDER,
                    Validity = "player-valid"
                },
                new Player
                {
                    Id = 10,
                    Name = "Luke Shaw",
                    Position = Position.DEFENDER,
                    Validity = "player-valid"
                },
                new Player
                {
                    Id = 11,
                    Name = "John Stones",
                    Position = Position.DEFENDER,
                    Validity = "player-valid"
                },
                new Player
                {
                    Id = 12,
                    Name = "Kyle Walker",
                    Position = Position.DEFENDER,
                    Validity = "player-valid"
                },
                new Player
                {
                    Id = 13,
                    Name = "Jude Bellingham",
                    Position = Position.MIDFIELDER,
                    Validity = "player-valid"
                },
                new Player
                {
                    Id = 14,
                    Name = "Jordan Henderson",
                    Position = Position.MIDFIELDER,
                    Validity = "player-valid"
                },
                new Player
                {
                    Id = 15,
                    Name = "Mason Mount",
                    Position = Position.MIDFIELDER,
                    Validity = "player-valid"
                },
                new Player
                {
                    Id = 16,
                    Name = "Kalvin Phillips",
                    Position = Position.MIDFIELDER,
                    Validity = "player-valid"
                },
                new Player
                {
                    Id = 17,
                    Name = "Declan Rice",
                    Position = Position.MIDFIELDER,
                    Validity = "player-valid"
                },
                new Player
                {
                    Id = 18,
                    Name = "James Ward-Prowse",
                    Position = Position.MIDFIELDER,
                    Validity = "player-valid"
                },
                new Player
                {
                    Id = 19,
                    Name = "Tammy Abraham",
                    Position = Position.FORWARD,
                    Validity = "player-valid"
                },
                new Player
                {
                    Id = 20,
                    Name = "Phil Foden",
                    Position = Position.FORWARD,
                    Validity = "player-valid"
                },
                new Player
                {
                    Id = 21,
                    Name = "Jack Grealish",
                    Position = Position.FORWARD,
                    Validity = "player-valid"
                },
                new Player
                {
                    Id = 22,
                    Name = "Harry Kane",
                    Position = Position.FORWARD,
                    Validity = "player-valid"
                },
                new Player
                {
                    Id = 23,
                    Name = "Bukayo Saka",
                    Position = Position.FORWARD,
                    Validity = "player-valid"
                },
                new Player
                {
                    Id = 24,
                    Name = "Marcus Rashford",
                    Position = Position.FORWARD,
                    Validity = "player-valid"
                },
                new Player
                {
                    Id = 25,
                    Name = "Raheem Sterling",
                    Position = Position.FORWARD,
                    Validity = "player-valid"
                }
                );            
        }
    }
}
