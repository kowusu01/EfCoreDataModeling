using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace EfCoreDataModeling
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BankAccount> Accounts { get; set; } = null!;
        public virtual DbSet<AccountHolder> AcountHolders { get; set; } = null!;
        public virtual DbSet<Address> Addresses { get; set; } = null!;

        public virtual DbSet<UserAccount> UserAcounts { get; set; } = null!;
        public virtual DbSet<AccountHolderAddress> AccountHolderAddresses { get; set; } = null!;
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
