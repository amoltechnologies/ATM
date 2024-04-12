using ATM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;

namespace ATM.Models
{
    public class Temp_VendorPlantService
    {
        public readonly ApplicationDbContext _applicationDbContext;

        public Temp_VendorPlantService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<Temp_VendorPlant>> GetTempVendorPlants()
        {
            return await _applicationDbContext.Tbl_Temp_VendorPlant.ToListAsync();
        }

        public async Task<Temp_VendorPlant> AddTempVendorPlant(Temp_VendorPlant temp_vendorplant)
        {
            if (temp_vendorplant.VendorPlantName != null)
            {
                _applicationDbContext.Tbl_Temp_VendorPlant.Add(temp_vendorplant);
            }

            var result = await _applicationDbContext.Tbl_Temp_VendorPlant.AddAsync(temp_vendorplant);
            await _applicationDbContext.SaveChangesAsync();
            return result.Entity;
        }


    }
}
