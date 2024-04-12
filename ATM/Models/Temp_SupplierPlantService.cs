using ATM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;

namespace ATM.Models
{
    public class Temp_SupplierPlantService
    {

        public readonly ApplicationDbContext _applicationDbContext;

        public Temp_SupplierPlantService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<Temp_SupplierPlant>> GetTempSupplierPlants()
        {
            return await _applicationDbContext.Tbl_Temp_SupplierPlant.ToListAsync();
        }

        public async Task<Temp_SupplierPlant> AddTempSupplierPlant(Temp_SupplierPlant temp_supplierplant)
        {
            if (temp_supplierplant.SupplierPlantName != null)
            {
                _applicationDbContext.Tbl_Temp_SupplierPlant.Add(temp_supplierplant);
            }

            var result = await _applicationDbContext.Tbl_Temp_SupplierPlant.AddAsync(temp_supplierplant);
            await _applicationDbContext.SaveChangesAsync();
            return result.Entity;
        }


    }
}
