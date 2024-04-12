using ATM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;

namespace ATM.Models
{
    public class Temp_CustomerPlantService
    {
        public readonly ApplicationDbContext _applicationDbContext;

        public Temp_CustomerPlantService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<Temp_CustomerPlant>> GetCustomerPlants()
        {
            return await _applicationDbContext.Tbl_Temp_CustomerPlant.ToListAsync();
        }

        public async Task<Temp_CustomerPlant> AddCustomerPlant(Temp_CustomerPlant temp_customerplant)
        {
            if (temp_customerplant.CustomerPlantName != null)
            {
                _applicationDbContext.Tbl_Temp_CustomerPlant.Add(temp_customerplant);
            }

            var result = await _applicationDbContext.Tbl_Temp_CustomerPlant.AddAsync(temp_customerplant);
            await _applicationDbContext.SaveChangesAsync();
            return result.Entity;
        }

        
    }
}



