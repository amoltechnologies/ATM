using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ATM.Migrations
{
    public partial class new_database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Customer",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    State = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmailID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PINCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PrimaryContactPersonName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PrimaryContactPersonContact = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GSTNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PANNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OpeningBalance = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    VendorCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Customer", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_FinishedGoods",
                columns: table => new
                {
                    FinishedGoodsID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FG_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    InternalFG_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HSNCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GSTPercent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PerUnitPrice = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    InternalDrawing = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerDrawing = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnitName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FGBufferLevelQuantity = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    FGOpeningQuantity = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    FGAvailableQuantity = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    FGStoreQuantity = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    FGProductionQuantity = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    FGQualityQuantity = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    FGDispatchQuantity = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModificationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_FinishedGoods", x => x.FinishedGoodsID);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Machine",
                columns: table => new
                {
                    MachineID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MachineName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Make = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Company = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModificationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Machine", x => x.MachineID);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_MaterialType",
                columns: table => new
                {
                    MaterialTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaterialTypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModificationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_MaterialType", x => x.MaterialTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_PurchaseOrder",
                columns: table => new
                {
                    PONumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fyear = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SupplierID = table.Column<int>(type: "int", nullable: false),
                    DateOfPO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalGSTAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalDiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    KindAttention = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Delivery = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Payment = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PandF = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TransportationAmount = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Insurance = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DispatchedThrough = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    QuotationNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateOfQuotation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    POStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModificationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_PurchaseOrder", x => new { x.PONumber, x.Fyear });
                });

            migrationBuilder.CreateTable(
                name: "Tbl_SalesOrder",
                columns: table => new
                {
                    SalesOrderNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fyear = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    DateOfSalesOrder = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalGSTAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    ModificationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_SalesOrder", x => new { x.SalesOrderNumber, x.Fyear });
                });

            migrationBuilder.CreateTable(
                name: "Tbl_State",
                columns: table => new
                {
                    StateID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StateGSTCode = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModificationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_State", x => x.StateID);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Supplier",
                columns: table => new
                {
                    SupplierID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    State = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SupplierEmailID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PINCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PrimaryContactPersonName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PrimaryContactPersonContact = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GSTNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PANNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OpeningBalance = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModificationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Supplier", x => x.SupplierID);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Temp_BOM",
                columns: table => new
                {
                    BOMID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProcessPlanID = table.Column<int>(type: "int", nullable: false),
                    FinishedGoodsID = table.Column<int>(type: "int", nullable: false),
                    MaterialID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModificationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Temp_BOM", x => x.BOMID);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Temp_CustomerPlant",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerPlantName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerPlantAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendorCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerPlantCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerPlantState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerPlantEmailID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CustomerPlnatPincode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerPlantPANNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerPlantGSTNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerPlantOpeningBalance = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    CustomerPlantContactPersonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerPlantContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModificationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Temp_CustomerPlant", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Temp_ProcessPlan",
                columns: table => new
                {
                    ProcessPlanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FinishedGoodsID = table.Column<int>(type: "int", nullable: false),
                    ProcessName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OutputName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OutputQuantity = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    ProcessPlanDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProcessScrapQuantity = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    ProcessOpeningQuantity = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    ProcessBufferLevelQuantity = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    isQualityRequired = table.Column<bool>(type: "bit", nullable: false),
                    isFinalProcess = table.Column<bool>(type: "bit", nullable: false),
                    OutputUnit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModificationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Temp_ProcessPlan", x => x.ProcessPlanID);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Temp_QualityParameter",
                columns: table => new
                {
                    QualityParameterID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QualityParameterName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProcessPlanID = table.Column<int>(type: "int", nullable: false),
                    UnitName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OperatorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModificationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Temp_QualityParameter", x => x.QualityParameterID);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Temp_SupplierPlant",
                columns: table => new
                {
                    SupplierPlantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierPlantName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupplierPlantAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupplierPlantCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupplierPlantEmailID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SupplierPlantState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupplierPlantPincode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupplierplantPANNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupplierPlantGSTNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupplierPlantContactPersonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupplierPlantContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupplierPlantOpeningBalance = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModificationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Temp_SupplierPlant", x => x.SupplierPlantId);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Temp_VendorPlant",
                columns: table => new
                {
                    VendorPlantID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorPlantName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendorPlantAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendorPlantEmailID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    VendorPlantCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendorPlantState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendorPlantPincode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendorplantPANNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendorPlantGSTNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendorPlantContactPersonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendorPlantContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendorPlantOpeningBalance = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModificationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Temp_VendorPlant", x => x.VendorPlantID);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Unit",
                columns: table => new
                {
                    UnitID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModificationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Unit", x => x.UnitID);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Vendor",
                columns: table => new
                {
                    VendorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    State = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    VendorEmailID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PINCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PrimaryContactPersonName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PrimaryContactPersonContact = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GSTNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PANNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OpeningBalance = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModificationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Vendor", x => x.VendorID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_CustomerPlant",
                columns: table => new
                {
                    CustomerPlantID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    CustomerPlantName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CustomerPlantAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendorCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_CustomerPlant", x => x.CustomerPlantID);
                    table.ForeignKey(
                        name: "FK_Tbl_CustomerPlant_Tbl_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Tbl_Customer",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_ProcessPlan",
                columns: table => new
                {
                    ProcessPlanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FinishedGoodsID = table.Column<int>(type: "int", nullable: false),
                    ProcessPlanName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProcessPlanDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OutputName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsFinalProcess = table.Column<bool>(type: "bit", nullable: false),
                    ProcessOutputQuantity = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    ProcessOutputUnit = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProcessScrapQuantity = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    ProcessOpeningQuantity = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    ProcessBufferLevelQuantity = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    ProcessAvailableQuantity = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    ProcessStoreQuantity = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    ProcessProductionQuantity = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    ProcessQualityQuantity = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    ProcessDispatchQuantity = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModificationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_ProcessPlan", x => x.ProcessPlanID);
                    table.ForeignKey(
                        name: "FK_Tbl_ProcessPlan_Tbl_FinishedGoods_FinishedGoodsID",
                        column: x => x.FinishedGoodsID,
                        principalTable: "Tbl_FinishedGoods",
                        principalColumn: "FinishedGoodsID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_DetailedSalesOrder",
                columns: table => new
                {
                    DetailedSalesOrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalesOrderNumber = table.Column<int>(type: "int", nullable: false),
                    SrNo = table.Column<int>(type: "int", nullable: false),
                    FinishedGoodsID = table.Column<int>(type: "int", nullable: false),
                    MaterialTypeID = table.Column<int>(type: "int", nullable: false),
                    FG_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Fyear = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HSNCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BaseAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GRNQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DiscountPercent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SGSTPercent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SGSTAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CGSTPercent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CGSTAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IGSTPercent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IGSTAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserId = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    ModificationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_DetailedSalesOrder", x => x.DetailedSalesOrderID);
                    table.ForeignKey(
                        name: "FK_Tbl_DetailedSalesOrder_Tbl_FinishedGoods_FinishedGoodsID",
                        column: x => x.FinishedGoodsID,
                        principalTable: "Tbl_FinishedGoods",
                        principalColumn: "FinishedGoodsID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tbl_DetailedSalesOrder_Tbl_MaterialType_MaterialTypeID",
                        column: x => x.MaterialTypeID,
                        principalTable: "Tbl_MaterialType",
                        principalColumn: "MaterialTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_MaterialCategory",
                columns: table => new
                {
                    MaterialCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaterialCategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MaterialTypeID = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModificationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_MaterialCategory", x => x.MaterialCategoryID);
                    table.ForeignKey(
                        name: "FK_Tbl_MaterialCategory_Tbl_MaterialType_MaterialTypeID",
                        column: x => x.MaterialTypeID,
                        principalTable: "Tbl_MaterialType",
                        principalColumn: "MaterialTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_TemperorySalesOrder",
                columns: table => new
                {
                    SrNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FinishedGoodsID = table.Column<int>(type: "int", nullable: false),
                    MaterialTypeID = table.Column<int>(type: "int", nullable: false),
                    FG_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Fyear = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HSNCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BaseAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscountPercent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SGSTPercent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SGSTAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CGSTPercent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CGSTAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IGSTPercent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IGSTAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModificationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_TemperorySalesOrder", x => x.SrNo);
                    table.ForeignKey(
                        name: "FK_Tbl_TemperorySalesOrder_Tbl_FinishedGoods_FinishedGoodsID",
                        column: x => x.FinishedGoodsID,
                        principalTable: "Tbl_FinishedGoods",
                        principalColumn: "FinishedGoodsID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tbl_TemperorySalesOrder_Tbl_MaterialType_MaterialTypeID",
                        column: x => x.MaterialTypeID,
                        principalTable: "Tbl_MaterialType",
                        principalColumn: "MaterialTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_SupplierPlant",
                columns: table => new
                {
                    SupplierPlantID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierID = table.Column<int>(type: "int", nullable: false),
                    SupplierPlantName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SupplierPlantEmailID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SupplierPlantAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupplierPlantCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupplierPlantState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupplierPlantPincode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupplierplantPANNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupplierPlantGSTNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupplierPlantContactPersonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupplierPlantContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupplierPlantOpeningBalance = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModificationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_SupplierPlant", x => x.SupplierPlantID);
                    table.ForeignKey(
                        name: "FK_Tbl_SupplierPlant_Tbl_Supplier_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Tbl_Supplier",
                        principalColumn: "SupplierID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_VendorPlant",
                columns: table => new
                {
                    VendorPlantID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorID = table.Column<int>(type: "int", nullable: false),
                    VendorPlantName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendorPlantAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendorPlantEmailID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    VendorPlantCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendorPlantState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendorPlantPincode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendorplantPANNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendorPlantGSTNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendorPlantContactPersonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendorPlantContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendorPlantOpeningBalance = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_VendorPlant", x => x.VendorPlantID);
                    table.ForeignKey(
                        name: "FK_Tbl_VendorPlant_Tbl_Vendor_VendorID",
                        column: x => x.VendorID,
                        principalTable: "Tbl_Vendor",
                        principalColumn: "VendorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_QualityParameter",
                columns: table => new
                {
                    QualityParameterID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QualityParameterName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProcessPlanID = table.Column<int>(type: "int", nullable: false),
                    UnitName = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    OperationName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModificationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_QualityParameter", x => x.QualityParameterID);
                    table.ForeignKey(
                        name: "FK_Tbl_QualityParameter_Tbl_ProcessPlan_ProcessPlanID",
                        column: x => x.ProcessPlanID,
                        principalTable: "Tbl_ProcessPlan",
                        principalColumn: "ProcessPlanID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_MaterialSubCategory",
                columns: table => new
                {
                    MaterialSubCategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaterialSubCategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MaterialCategoryID = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModificationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_MaterialSubCategory", x => x.MaterialSubCategoryID);
                    table.ForeignKey(
                        name: "FK_Tbl_MaterialSubCategory_Tbl_MaterialCategory_MaterialCategoryID",
                        column: x => x.MaterialCategoryID,
                        principalTable: "Tbl_MaterialCategory",
                        principalColumn: "MaterialCategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Material",
                columns: table => new
                {
                    MaterialID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaterialTypeID = table.Column<int>(type: "int", nullable: false),
                    MaterialCategoryID = table.Column<int>(type: "int", nullable: false),
                    MaterialSubCategoryID = table.Column<int>(type: "int", nullable: false),
                    UnitName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MaterialName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MaterialDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialHSNCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MaterialGSTPercent = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    MaterialOpeningQuantity = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    MaterialBufferLevelQuantity = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    MaterialAvailableQuantity = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    MaterialStoreQuantity = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    MaterialProductionQuantity = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    MaterialQualityQuantity = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    MaterialDispatchQuantity = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    IsQualityRequire = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModificationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Material", x => x.MaterialID);
                    table.ForeignKey(
                        name: "FK_Tbl_Material_Tbl_MaterialCategory_MaterialCategoryID",
                        column: x => x.MaterialCategoryID,
                        principalTable: "Tbl_MaterialCategory",
                        principalColumn: "MaterialCategoryID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tbl_Material_Tbl_MaterialSubCategory_MaterialSubCategoryID",
                        column: x => x.MaterialSubCategoryID,
                        principalTable: "Tbl_MaterialSubCategory",
                        principalColumn: "MaterialSubCategoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tbl_Material_Tbl_MaterialType_MaterialTypeID",
                        column: x => x.MaterialTypeID,
                        principalTable: "Tbl_MaterialType",
                        principalColumn: "MaterialTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_BOM",
                columns: table => new
                {
                    BOMID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProcessPlanID = table.Column<int>(type: "int", nullable: false),
                    FinishedGoodsID = table.Column<int>(type: "int", nullable: false),
                    MaterialID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<decimal>(type: "Decimal(18,2)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_BOM", x => x.BOMID);
                    table.ForeignKey(
                        name: "FK_Tbl_BOM_Tbl_FinishedGoods_FinishedGoodsID",
                        column: x => x.FinishedGoodsID,
                        principalTable: "Tbl_FinishedGoods",
                        principalColumn: "FinishedGoodsID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tbl_BOM_Tbl_Material_MaterialID",
                        column: x => x.MaterialID,
                        principalTable: "Tbl_Material",
                        principalColumn: "MaterialID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tbl_BOM_Tbl_ProcessPlan_ProcessPlanID",
                        column: x => x.ProcessPlanID,
                        principalTable: "Tbl_ProcessPlan",
                        principalColumn: "ProcessPlanID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_DetailedPurchaseOrder",
                columns: table => new
                {
                    DetailedPOID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PONumber = table.Column<int>(type: "int", nullable: false),
                    SrNo = table.Column<int>(type: "int", nullable: false),
                    MaterialID = table.Column<int>(type: "int", nullable: false),
                    MaterialTypeID = table.Column<int>(type: "int", nullable: false),
                    MaterialName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Fyear = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HSNCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BaseAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GRNQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DiscountPercent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SGSTPercent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SGSTAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CGSTPercent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CGSTAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IGSTPercent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IGSTAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserId = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    ModificationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_DetailedPurchaseOrder", x => x.DetailedPOID);
                    table.ForeignKey(
                        name: "FK_Tbl_DetailedPurchaseOrder_Tbl_Material_MaterialID",
                        column: x => x.MaterialID,
                        principalTable: "Tbl_Material",
                        principalColumn: "MaterialID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tbl_DetailedPurchaseOrder_Tbl_MaterialType_MaterialTypeID",
                        column: x => x.MaterialTypeID,
                        principalTable: "Tbl_MaterialType",
                        principalColumn: "MaterialTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_DispatchIn",
                columns: table => new
                {
                    DispatchInID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeID = table.Column<int>(type: "int", nullable: false),
                    MaterialTypeID = table.Column<int>(type: "int", nullable: false),
                    MaterialID = table.Column<int>(type: "int", nullable: false),
                    InQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReceivedFrom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceivedTransactionID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModificationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_DispatchIn", x => x.DispatchInID);
                    table.ForeignKey(
                        name: "FK_Tbl_DispatchIn_Tbl_Material_MaterialID",
                        column: x => x.MaterialID,
                        principalTable: "Tbl_Material",
                        principalColumn: "MaterialID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tbl_DispatchIn_Tbl_MaterialType_MaterialTypeID",
                        column: x => x.MaterialTypeID,
                        principalTable: "Tbl_MaterialType",
                        principalColumn: "MaterialTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_DispatchOut",
                columns: table => new
                {
                    DispatchOutID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeID = table.Column<int>(type: "int", nullable: false),
                    MaterialTypeID = table.Column<int>(type: "int", nullable: false),
                    MaterialID = table.Column<int>(type: "int", nullable: false),
                    OutQuantity = table.Column<decimal>(type: "decimal (18,2)", nullable: false),
                    IssuedTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModificationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_DispatchOut", x => x.DispatchOutID);
                    table.ForeignKey(
                        name: "FK_Tbl_DispatchOut_Tbl_Material_MaterialID",
                        column: x => x.MaterialID,
                        principalTable: "Tbl_Material",
                        principalColumn: "MaterialID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tbl_DispatchOut_Tbl_MaterialType_MaterialTypeID",
                        column: x => x.MaterialTypeID,
                        principalTable: "Tbl_MaterialType",
                        principalColumn: "MaterialTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_ProductionIn",
                columns: table => new
                {
                    ProductionInID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaterialID = table.Column<int>(type: "int", nullable: false),
                    InQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReceivedFrom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceivedTransactionID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModificationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_ProductionIn", x => x.ProductionInID);
                    table.ForeignKey(
                        name: "FK_Tbl_ProductionIn_Tbl_Material_MaterialID",
                        column: x => x.MaterialID,
                        principalTable: "Tbl_Material",
                        principalColumn: "MaterialID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_ProductionOut",
                columns: table => new
                {
                    ProductionOutID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaterialID = table.Column<int>(type: "int", nullable: false),
                    OutQuantity = table.Column<decimal>(type: "decimal (18,2)", nullable: false),
                    IssuedTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModificationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_ProductionOut", x => x.ProductionOutID);
                    table.ForeignKey(
                        name: "FK_Tbl_ProductionOut_Tbl_Material_MaterialID",
                        column: x => x.MaterialID,
                        principalTable: "Tbl_Material",
                        principalColumn: "MaterialID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_QualityIn",
                columns: table => new
                {
                    QualityInID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeID = table.Column<int>(type: "int", nullable: false),
                    MaterialTypeID = table.Column<int>(type: "int", nullable: false),
                    MaterialID = table.Column<int>(type: "int", nullable: false),
                    InQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReceivedFrom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceivedTransactionID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModificationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_QualityIn", x => x.QualityInID);
                    table.ForeignKey(
                        name: "FK_Tbl_QualityIn_Tbl_Material_MaterialID",
                        column: x => x.MaterialID,
                        principalTable: "Tbl_Material",
                        principalColumn: "MaterialID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tbl_QualityIn_Tbl_MaterialType_MaterialTypeID",
                        column: x => x.MaterialTypeID,
                        principalTable: "Tbl_MaterialType",
                        principalColumn: "MaterialTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_QualityOut",
                columns: table => new
                {
                    QualityOutID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaterialID = table.Column<int>(type: "int", nullable: false),
                    TypeID = table.Column<int>(type: "int", nullable: false),
                    MaterialTypeID = table.Column<int>(type: "int", nullable: false),
                    OutQuantity = table.Column<decimal>(type: "decimal (18,2)", nullable: false),
                    IssuedTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModificationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_QualityOut", x => x.QualityOutID);
                    table.ForeignKey(
                        name: "FK_Tbl_QualityOut_Tbl_Material_MaterialID",
                        column: x => x.MaterialID,
                        principalTable: "Tbl_Material",
                        principalColumn: "MaterialID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tbl_QualityOut_Tbl_MaterialType_MaterialTypeID",
                        column: x => x.MaterialTypeID,
                        principalTable: "Tbl_MaterialType",
                        principalColumn: "MaterialTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_StoreIn",
                columns: table => new
                {
                    StoreInID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaterialID = table.Column<int>(type: "int", nullable: false),
                    InQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReceivedFrom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReceivedTransactionID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModificationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_StoreIn", x => x.StoreInID);
                    table.ForeignKey(
                        name: "FK_Tbl_StoreIn_Tbl_Material_MaterialID",
                        column: x => x.MaterialID,
                        principalTable: "Tbl_Material",
                        principalColumn: "MaterialID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_StoreOut",
                columns: table => new
                {
                    StoreOutID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaterialID = table.Column<int>(type: "int", nullable: false),
                    OutQuantity = table.Column<decimal>(type: "decimal (18,2)", nullable: false),
                    IssuedTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModificationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_StoreOut", x => x.StoreOutID);
                    table.ForeignKey(
                        name: "FK_Tbl_StoreOut_Tbl_Material_MaterialID",
                        column: x => x.MaterialID,
                        principalTable: "Tbl_Material",
                        principalColumn: "MaterialID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_TemperoryPurchaseOrder",
                columns: table => new
                {
                    SrNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaterialID = table.Column<int>(type: "int", nullable: false),
                    MaterialTypeID = table.Column<int>(type: "int", nullable: false),
                    MaterialName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Fyear = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HSNCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BaseAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscountPercent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SGSTPercent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SGSTAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CGSTPercent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CGSTAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IGSTPercent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IGSTAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModificationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_TemperoryPurchaseOrder", x => x.SrNo);
                    table.ForeignKey(
                        name: "FK_Tbl_TemperoryPurchaseOrder_Tbl_Material_MaterialID",
                        column: x => x.MaterialID,
                        principalTable: "Tbl_Material",
                        principalColumn: "MaterialID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tbl_TemperoryPurchaseOrder_Tbl_MaterialType_MaterialTypeID",
                        column: x => x.MaterialTypeID,
                        principalTable: "Tbl_MaterialType",
                        principalColumn: "MaterialTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_GRN",
                columns: table => new
                {
                    GRNID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fyear = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SupplierID = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaterialTypeID = table.Column<int>(type: "int", nullable: false),
                    MaterialID = table.Column<int>(type: "int", nullable: false),
                    UnitName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GRNQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    DetailedPOID = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModificationTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_GRN", x => new { x.GRNID, x.Fyear });
                    table.ForeignKey(
                        name: "FK_Tbl_GRN_Tbl_DetailedPurchaseOrder_DetailedPOID",
                        column: x => x.DetailedPOID,
                        principalTable: "Tbl_DetailedPurchaseOrder",
                        principalColumn: "DetailedPOID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tbl_GRN_Tbl_Material_MaterialID",
                        column: x => x.MaterialID,
                        principalTable: "Tbl_Material",
                        principalColumn: "MaterialID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tbl_GRN_Tbl_MaterialType_MaterialTypeID",
                        column: x => x.MaterialTypeID,
                        principalTable: "Tbl_MaterialType",
                        principalColumn: "MaterialTypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tbl_GRN_Tbl_Supplier_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Tbl_Supplier",
                        principalColumn: "SupplierID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_BOM_FinishedGoodsID",
                table: "Tbl_BOM",
                column: "FinishedGoodsID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_BOM_MaterialID",
                table: "Tbl_BOM",
                column: "MaterialID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_BOM_ProcessPlanID",
                table: "Tbl_BOM",
                column: "ProcessPlanID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_CustomerPlant_CustomerID",
                table: "Tbl_CustomerPlant",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_DetailedPurchaseOrder_MaterialID",
                table: "Tbl_DetailedPurchaseOrder",
                column: "MaterialID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_DetailedPurchaseOrder_MaterialTypeID",
                table: "Tbl_DetailedPurchaseOrder",
                column: "MaterialTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_DetailedSalesOrder_FinishedGoodsID",
                table: "Tbl_DetailedSalesOrder",
                column: "FinishedGoodsID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_DetailedSalesOrder_MaterialTypeID",
                table: "Tbl_DetailedSalesOrder",
                column: "MaterialTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_DispatchIn_MaterialID",
                table: "Tbl_DispatchIn",
                column: "MaterialID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_DispatchIn_MaterialTypeID",
                table: "Tbl_DispatchIn",
                column: "MaterialTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_DispatchOut_MaterialID",
                table: "Tbl_DispatchOut",
                column: "MaterialID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_DispatchOut_MaterialTypeID",
                table: "Tbl_DispatchOut",
                column: "MaterialTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_GRN_DetailedPOID",
                table: "Tbl_GRN",
                column: "DetailedPOID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_GRN_MaterialID",
                table: "Tbl_GRN",
                column: "MaterialID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_GRN_MaterialTypeID",
                table: "Tbl_GRN",
                column: "MaterialTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_GRN_SupplierID",
                table: "Tbl_GRN",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Material_MaterialCategoryID",
                table: "Tbl_Material",
                column: "MaterialCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Material_MaterialSubCategoryID",
                table: "Tbl_Material",
                column: "MaterialSubCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Material_MaterialTypeID",
                table: "Tbl_Material",
                column: "MaterialTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_MaterialCategory_MaterialTypeID",
                table: "Tbl_MaterialCategory",
                column: "MaterialTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_MaterialSubCategory_MaterialCategoryID",
                table: "Tbl_MaterialSubCategory",
                column: "MaterialCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_ProcessPlan_FinishedGoodsID",
                table: "Tbl_ProcessPlan",
                column: "FinishedGoodsID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_ProductionIn_MaterialID",
                table: "Tbl_ProductionIn",
                column: "MaterialID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_ProductionOut_MaterialID",
                table: "Tbl_ProductionOut",
                column: "MaterialID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_QualityIn_MaterialID",
                table: "Tbl_QualityIn",
                column: "MaterialID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_QualityIn_MaterialTypeID",
                table: "Tbl_QualityIn",
                column: "MaterialTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_QualityOut_MaterialID",
                table: "Tbl_QualityOut",
                column: "MaterialID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_QualityOut_MaterialTypeID",
                table: "Tbl_QualityOut",
                column: "MaterialTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_QualityParameter_ProcessPlanID",
                table: "Tbl_QualityParameter",
                column: "ProcessPlanID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_StoreIn_MaterialID",
                table: "Tbl_StoreIn",
                column: "MaterialID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_StoreOut_MaterialID",
                table: "Tbl_StoreOut",
                column: "MaterialID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_SupplierPlant_SupplierID",
                table: "Tbl_SupplierPlant",
                column: "SupplierID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_TemperoryPurchaseOrder_MaterialID",
                table: "Tbl_TemperoryPurchaseOrder",
                column: "MaterialID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_TemperoryPurchaseOrder_MaterialTypeID",
                table: "Tbl_TemperoryPurchaseOrder",
                column: "MaterialTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_TemperorySalesOrder_FinishedGoodsID",
                table: "Tbl_TemperorySalesOrder",
                column: "FinishedGoodsID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_TemperorySalesOrder_MaterialTypeID",
                table: "Tbl_TemperorySalesOrder",
                column: "MaterialTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_VendorPlant_VendorID",
                table: "Tbl_VendorPlant",
                column: "VendorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Tbl_BOM");

            migrationBuilder.DropTable(
                name: "Tbl_CustomerPlant");

            migrationBuilder.DropTable(
                name: "Tbl_DetailedSalesOrder");

            migrationBuilder.DropTable(
                name: "Tbl_DispatchIn");

            migrationBuilder.DropTable(
                name: "Tbl_DispatchOut");

            migrationBuilder.DropTable(
                name: "Tbl_GRN");

            migrationBuilder.DropTable(
                name: "Tbl_Machine");

            migrationBuilder.DropTable(
                name: "Tbl_ProductionIn");

            migrationBuilder.DropTable(
                name: "Tbl_ProductionOut");

            migrationBuilder.DropTable(
                name: "Tbl_PurchaseOrder");

            migrationBuilder.DropTable(
                name: "Tbl_QualityIn");

            migrationBuilder.DropTable(
                name: "Tbl_QualityOut");

            migrationBuilder.DropTable(
                name: "Tbl_QualityParameter");

            migrationBuilder.DropTable(
                name: "Tbl_SalesOrder");

            migrationBuilder.DropTable(
                name: "Tbl_State");

            migrationBuilder.DropTable(
                name: "Tbl_StoreIn");

            migrationBuilder.DropTable(
                name: "Tbl_StoreOut");

            migrationBuilder.DropTable(
                name: "Tbl_SupplierPlant");

            migrationBuilder.DropTable(
                name: "Tbl_Temp_BOM");

            migrationBuilder.DropTable(
                name: "Tbl_Temp_CustomerPlant");

            migrationBuilder.DropTable(
                name: "Tbl_Temp_ProcessPlan");

            migrationBuilder.DropTable(
                name: "Tbl_Temp_QualityParameter");

            migrationBuilder.DropTable(
                name: "Tbl_Temp_SupplierPlant");

            migrationBuilder.DropTable(
                name: "Tbl_Temp_VendorPlant");

            migrationBuilder.DropTable(
                name: "Tbl_TemperoryPurchaseOrder");

            migrationBuilder.DropTable(
                name: "Tbl_TemperorySalesOrder");

            migrationBuilder.DropTable(
                name: "Tbl_Unit");

            migrationBuilder.DropTable(
                name: "Tbl_VendorPlant");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Tbl_Customer");

            migrationBuilder.DropTable(
                name: "Tbl_DetailedPurchaseOrder");

            migrationBuilder.DropTable(
                name: "Tbl_ProcessPlan");

            migrationBuilder.DropTable(
                name: "Tbl_Supplier");

            migrationBuilder.DropTable(
                name: "Tbl_Vendor");

            migrationBuilder.DropTable(
                name: "Tbl_Material");

            migrationBuilder.DropTable(
                name: "Tbl_FinishedGoods");

            migrationBuilder.DropTable(
                name: "Tbl_MaterialSubCategory");

            migrationBuilder.DropTable(
                name: "Tbl_MaterialCategory");

            migrationBuilder.DropTable(
                name: "Tbl_MaterialType");
        }
    }
}
