using ATM.Areas.Identity;
using ATM.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Syncfusion.Blazor;
using ATM.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddSyncfusionBlazor();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
builder.Services.AddSingleton<WeatherForecastService>();

builder.Services.AddScoped<CustomerService>();
builder.Services.AddScoped<SupplierService>();
builder.Services.AddScoped<MaterialTypeService>();
builder.Services.AddScoped<VendorService>();
builder.Services.AddScoped<MaterialCategoryService>();
builder.Services.AddScoped<MaterialSubCategoryService>();
builder.Services.AddScoped<MaterialService>();
builder.Services.AddScoped<FinishedGoodsService>();
builder.Services.AddScoped<ProcessPlanService>();
builder.Services.AddScoped<QualityParameterService>();
builder.Services.AddScoped<BOMService>();
builder.Services.AddScoped<MachineService>();
builder.Services.AddScoped<UnitService>();
builder.Services.AddScoped<CustomerPlantService>();
builder.Services.AddScoped<SupplierPlantService>();
builder.Services.AddScoped<VendorPlantService>();
builder.Services.AddScoped<StateService>();
builder.Services.AddScoped<PurchaseOrderService>();
builder.Services.AddScoped<GRNService>();
builder.Services.AddScoped<StoreInService>();
builder.Services.AddScoped<StoreOutService>();
builder.Services.AddScoped<QualityInService>();
builder.Services.AddScoped<QualityOutService>();
builder.Services.AddScoped<ProductionInService>();
builder.Services.AddScoped<ProductionOutService>();
builder.Services.AddScoped<SalesOrderService>();
builder.Services.AddScoped<DispatchInService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
