namespace DB
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class NoteEnity : DbContext
    {
        public NoteEnity()
            : base("data source=DESKTOP-MDCEEA1\\SQLEXPRESS;initial catalog=Note;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework providerName = System.Data.SqlClient")
        {
        }

        public virtual DbSet<Trening> Trening { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trening>()
                .Property(e => e.uLogin)
                .IsFixedLength();

            modelBuilder.Entity<Trening>()
                .Property(e => e.csv)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Username)
                .IsFixedLength();

            modelBuilder.Entity<Users>()
                .Property(e => e.Surame)
                .IsFixedLength();

            modelBuilder.Entity<Users>()
                .Property(e => e.uLogin)
                .IsFixedLength();

            modelBuilder.Entity<Users>()
                .Property(e => e.Mail)
                .IsFixedLength();

            modelBuilder.Entity<Users>()
                .Property(e => e.Passwd)
                .IsFixedLength();
        }
    }
}
