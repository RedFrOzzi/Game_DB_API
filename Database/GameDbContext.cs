using Game_DB_API.Models.Abilities;
using Game_DB_API.Models.Buffs;
using Game_DB_API.Models.JoinTables;
using Game_DB_API.Models.OnHitEffects;
using Microsoft.EntityFrameworkCore;

namespace Game_DB_API.Database
{
    public class GameDbContext : DbContext
    {
        public GameDbContext(DbContextOptions<GameDbContext> options) : base(options) { }

        public DbSet<Ability> Abilities { get; set; }
        public DbSet<Buff> Buffs { get; set; }
        public DbSet<OnHit> OnHits { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ability>()
                .HasMany(a => a.LinkedBuffs)
                .WithMany(b => b.AbilitySource)
                .UsingEntity<AbilityBuff>();

            modelBuilder.Entity<OnHit>()
                .HasMany(o => o.LinkedBuffs)
                .WithMany(b => b.OnHitSource)
                .UsingEntity<OnHitBuff>();
        }
    }
}
