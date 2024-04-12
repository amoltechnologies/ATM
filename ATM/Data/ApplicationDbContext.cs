using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ATM.Models;
using Microsoft.AspNetCore.Identity;

namespace ATM.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<PurchaseOrder>()
                .HasKey(c => new { c.PONumber, c.Fyear });


            modelBuilder.Entity<PurchaseOrder>()
                .Property(p => p.PONumber)
                .UseIdentityColumn(seed: 1, increment: 1);





            modelBuilder.Entity<GRN>()
                .HasKey(c => new { c.GRNID, c.Fyear });



            modelBuilder.Entity<GRN>()
                .Property(p => p.GRNID)
                .UseIdentityColumn(seed: 1, increment: 1);



            modelBuilder.Entity<SalesOrder>()
                .HasKey(c => new { c.SalesOrderNumber, c.Fyear });
            

            modelBuilder.Entity<SalesOrder>()
                .Property(p => p.SalesOrderNumber)
                .UseIdentityColumn(seed: 1, increment: 1);

        }

        public DbSet<Customer> Tbl_Customer { get; set; } = null!;
        public DbSet<Supplier> Tbl_Supplier { get; set; } = null!;
        public DbSet<Vendor> Tbl_Vendor { get; set; } = null!;
        public DbSet<MaterialType> Tbl_MaterialType { get; set; } = null!;
        public DbSet<MaterialCategory> Tbl_MaterialCategory { get; set; } = null!;
        public DbSet<MaterialSubCategory> Tbl_MaterialSubCategory { get; set; } = null!;
        public DbSet<Material> Tbl_Material { get; set; } = null!;
        public DbSet<FinishedGoods> Tbl_FinishedGoods { get; set; } = null!;
        public DbSet<ProcessPlan> Tbl_ProcessPlan { get; set; } = null!;
        public DbSet<QualityParameter> Tbl_QualityParameter { get; set; } = null!;
        public DbSet<BOM> Tbl_BOM { get; set; } = null!;
        public DbSet<Machine> Tbl_Machine { get; set; } = null!;
        public DbSet<Unit> Tbl_Unit { get; set; } = null!;
        public DbSet<CustomerPlant> Tbl_CustomerPlant { get; set; } = null!;
        public DbSet<SupplierPlant> Tbl_SupplierPlant { get; set; } = null!;
        public DbSet<VendorPlant> Tbl_VendorPlant { get; set; } = null!;
        public DbSet<State> Tbl_State { get; set; } = null!;
        public DbSet<PurchaseOrder> Tbl_PurchaseOrder { get; set; } = null!;
        public DbSet<TemperoryPurchaseOrder> Tbl_TemperoryPurchaseOrder { get; set; } = null!;
        public DbSet<DetailedPurchaseOrder> Tbl_DetailedPurchaseOrder { get; set; } = null!;
        public DbSet<GRN> Tbl_GRN { get; set; } = null!;
        public DbSet<StoreIn> Tbl_StoreIn { get; set; } = null!;
        public DbSet<StoreOut> Tbl_StoreOut { get; set; } = null!;
        public DbSet<QualityIn> Tbl_QualityIn { get; set; } = null!;
        public DbSet<QualityOut> Tbl_QualityOut { get; set; } = null!;
        public DbSet<ProductionIn> Tbl_ProductionIn { get; set; } = null!;
        public DbSet<ProductionOut> Tbl_ProductionOut { get; set; } = null!;
        public DbSet<SalesOrder> Tbl_SalesOrder { get; set; } = null!;
        public DbSet<DispatchIn> Tbl_DispatchIn { get; set; } = null!;
        public DbSet<DispatchOut> Tbl_DispatchOut { get; set; } = null!;
        public DbSet<TemperorySalesOrder> Tbl_TemperorySalesOrder { get; set; } = null!;
        public DbSet<DetailedSalesOrder> Tbl_DetailedSalesOrder { get; set; } = null!;
        public DbSet<Temp_ProcessPlan> Tbl_Temp_ProcessPlan { get; set; } = null!;
        public DbSet<Temp_CustomerPlant> Tbl_Temp_CustomerPlant { get; set; } = null!;
        public DbSet<Temp_VendorPlant> Tbl_Temp_VendorPlant { get; set; } = null!;
        public DbSet<Temp_SupplierPlant> Tbl_Temp_SupplierPlant { get; set; } = null!;
        public DbSet<Temp_BOM> Tbl_Temp_BOM { get; set; } = null!;
        public DbSet<Temp_QualityParameter> Tbl_Temp_QualityParameter { get; set; } = null!;



    }
}