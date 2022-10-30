using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WindowsFormsApp1.Model
{
    public partial class appDBQLSV : DbContext
    {
        public appDBQLSV()
            : base("name=appDBQLSV")
        {
        }

        public virtual DbSet<LopHoc> LopHocs { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LopHoc>()
                .HasMany(e => e.SinhViens)
                .WithRequired(e => e.LopHoc)
                .HasForeignKey(e => e.IDLopHoc)
                .WillCascadeOnDelete(false);
        }
    }
}
