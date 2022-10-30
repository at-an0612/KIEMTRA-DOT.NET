using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace AppQLSV2.Model
{
    public partial class AppDB : DbContext
    {
        public AppDB()
            : base("name=AppDB")
        {
        }

        public virtual DbSet<LopHoc> LopHocs { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LopHoc>()
                .HasMany(e => e.SinhViens)
                .WithOptional(e => e.LopHoc)
                .HasForeignKey(e => e.IDLopHoc);
        }
    }
}
