using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLKTX.DATA
{
    public partial class KTXDBContext : DbContext
    {
        public KTXDBContext()
            : base("name=KTXDBContext1")
        {
        }

        public virtual DbSet<ACCOUNT> ACCOUNT { get; set; }
        public virtual DbSet<BANGGIADIENNUOC> BANGGIADIENNUOC { get; set; }
        public virtual DbSet<CTKYLUAT> CTKYLUAT { get; set; }
        public virtual DbSet<CTHOADONDIENNUOC> CTHOADONDIENNUOC { get; set; }
        public virtual DbSet<CTHOADONLEPHI> CTHOADONLEPHI { get; set; }
        public virtual DbSet<HOADONDIENNUOC> HOADONDIENNUOC { get; set; }
        public virtual DbSet<HOADONLEPHI> HOADONLEPHI { get; set; }
        public virtual DbSet<KYLUAT> KYLUAT { get; set; }
        public virtual DbSet<NOIQUYKTX> NOIQUYKTX { get; set; }
        public virtual DbSet<NGUOITHANSV> NGUOITHANSV { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIEN { get; set; }
        public virtual DbSet<PHONGSV> PHONGSV { get; set; }
        public virtual DbSet<SINHVIEN> SINHVIEN { get; set; }
        public virtual DbSet<TOANHA> TOANHA { get; set; }
        public virtual DbSet<TRUONGHOC> TRUONGHOC { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.USER)
                .IsUnicode(false);

            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.PASS)
                .IsUnicode(false);

            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.MANV)
                .IsUnicode(false);

            modelBuilder.Entity<ACCOUNT>()
                .Property(e => e.CCCD)
                .IsUnicode(false);

            modelBuilder.Entity<BANGGIADIENNUOC>()
                .Property(e => e.MABANGGIA)
                .IsUnicode(false);

            modelBuilder.Entity<CTKYLUAT>()
                .Property(e => e.MAKYLUAT)
                .IsUnicode(false);

            modelBuilder.Entity<CTKYLUAT>()
                .Property(e => e.MANOIQUY)
                .IsUnicode(false);

            modelBuilder.Entity<CTHOADONDIENNUOC>()
                .Property(e => e.MABANGGIA)
                .IsUnicode(false);

            modelBuilder.Entity<CTHOADONLEPHI>()
                .Property(e => e.MAPHONG)
                .IsUnicode(false);

            modelBuilder.Entity<HOADONDIENNUOC>()
                .Property(e => e.MAPHONG)
                .IsUnicode(false);

            modelBuilder.Entity<HOADONDIENNUOC>()
                .Property(e => e.MANV)
                .IsUnicode(false);

            modelBuilder.Entity<HOADONLEPHI>()
                .Property(e => e.MANV)
                .IsUnicode(false);

            modelBuilder.Entity<HOADONLEPHI>()
                .Property(e => e.CCCD)
                .IsUnicode(false);

            modelBuilder.Entity<KYLUAT>()
                .Property(e => e.MAKYLUAT)
                .IsUnicode(false);

            modelBuilder.Entity<KYLUAT>()
                .Property(e => e.CCCD)
                .IsUnicode(false);

            modelBuilder.Entity<KYLUAT>()
                .Property(e => e.MANV)
                .IsUnicode(false);

            modelBuilder.Entity<NOIQUYKTX>()
                .Property(e => e.MANOIQUY)
                .IsUnicode(false);

            modelBuilder.Entity<NGUOITHANSV>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<NGUOITHANSV>()
                .Property(e => e.CCCD)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MANV)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<PHONGSV>()
                .Property(e => e.MAPHONG)
                .IsUnicode(false);

            modelBuilder.Entity<PHONGSV>()
                .Property(e => e.MATOA)
                .IsUnicode(false);

            modelBuilder.Entity<SINHVIEN>()
                .Property(e => e.CCCD)
                .IsUnicode(false);

            modelBuilder.Entity<SINHVIEN>()
                .Property(e => e.MSSV)
                .IsUnicode(false);

            modelBuilder.Entity<SINHVIEN>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<SINHVIEN>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<SINHVIEN>()
                .Property(e => e.MAPHONG)
                .IsUnicode(false);

            modelBuilder.Entity<SINHVIEN>()
                .Property(e => e.MATRUONG)
                .IsUnicode(false);

            modelBuilder.Entity<TOANHA>()
                .Property(e => e.MATOA)
                .IsUnicode(false);

            modelBuilder.Entity<TOANHA>()
                .Property(e => e.TENTOA)
                .IsUnicode(false);

            modelBuilder.Entity<TRUONGHOC>()
                .Property(e => e.MATRUONG)
                .IsUnicode(false);
        }
    }
}
