//namespace ATM.Models
//{
//    using System;
//    using System.Data;
//    using System.Data.Entity.Infrastructure;
//    using System.Data.Entity.Core.Objects;
//    using System.Linq;
//    using Microsoft.EntityFrameworkCore;

//    public partial class Custom : DbContext
//    {
//        public Custom()
//            : base("name=Custom")
//        {
//        }

//        protected override void OnModelCreating(DbModelBuilder modelBuilder)
//        {
//            throw new UnintentionalCodeFirstException();
//        }

//        public virtual DbSet<Material> Tbl_Materials { get; set; }
//        public virtual DbSet<MaterialCategory> Tbl_MaterialCategories { get; set; }
//        public virtual DbSet<MaterialType> Tbl_MaterialTypes { get; set; }
//        public virtual DbSet<MaterialSubCategory> Tbl_MaterialSubCategories { get; set; }

//    }
//}
