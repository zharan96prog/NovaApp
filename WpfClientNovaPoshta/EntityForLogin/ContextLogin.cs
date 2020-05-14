namespace WpfClientNovaPoshta.EntityForLogin
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ContextLogin : DbContext
    {
        public ContextLogin()
            : base("name=ContextLogin")
        {
        }

        public virtual DbSet<Package> Package { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(e => e.Package)
                .WithOptional(e => e.User)
                .HasForeignKey(e => e.ID_User);
        }
    }
}
