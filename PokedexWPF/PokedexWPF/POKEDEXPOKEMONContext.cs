using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata; 

namespace PokedexWPF
{
    public partial class POKEDEXPOKEMONContext : DbContext
    {
        public POKEDEXPOKEMONContext()
        {
        }

        public POKEDEXPOKEMONContext(DbContextOptions<POKEDEXPOKEMONContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Pokemon> Pokemon { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source = localhost; Initial Catalog= POKEDEXPOKEMON; Persist Security Info = True; User ID = SA; Password = Passw0rd2018");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pokemon>(entity =>
            {
                entity.Property(e => e.PokemonId).HasColumnName("PokemonID");

                entity.Property(e => e.PokemonImage1)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PokemonImage2)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PokemonName)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
