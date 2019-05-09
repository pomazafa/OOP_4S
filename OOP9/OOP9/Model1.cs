namespace OOP9
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<ADDRESS> ADDRESSes { get; set; }
        public virtual DbSet<PATIENT> PATIENTs { get; set; }
        public virtual DbSet<RECIPE> RECIPEs { get; set; }
        public virtual DbSet<USER> USERS { get; set; }
        public virtual DbSet<VISIT> VISITs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PATIENT>()
                .Property(e => e.GENDER)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<VISIT>()
                .Property(e => e.HEIGHT)
                .HasPrecision(4, 1);

            modelBuilder.Entity<VISIT>()
                .Property(e => e.WEIGHT)
                .HasPrecision(5, 2);
        }
    }
}
