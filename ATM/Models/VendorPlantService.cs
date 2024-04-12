using ATM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;

namespace ATM.Models
{
    public class VendorPlantService
    {

        public readonly ApplicationDbContext _applicationDbContext;

        public VendorPlantService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<VendorPlant>> GetVendorPlants()
        {
            return await _applicationDbContext.Tbl_VendorPlant.ToListAsync();
        }

        public async Task<VendorPlant> AddVendorPlant(VendorPlant vendorplant)
        {
            if (vendorplant.VendorPlantName != null)
            {
                _applicationDbContext.Tbl_VendorPlant.Add(vendorplant);
            }

            var result = await _applicationDbContext.Tbl_VendorPlant.AddAsync(vendorplant);
            await _applicationDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteVendorPlant(int ID)
        {
            var result = await _applicationDbContext.Tbl_VendorPlant
                .FirstOrDefaultAsync(l => l.VendorPlantID == ID);

            if (result != null)
            {
                _applicationDbContext.Tbl_VendorPlant.Remove(result);
                await _applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task<VendorPlant> UpdateVendorPlant(VendorPlant vendorplant)
        {
            var result = await _applicationDbContext.Tbl_VendorPlant
                .FirstOrDefaultAsync(e => e.VendorPlantID == vendorplant.VendorPlantID);

            if (result != null)
            {
                result.VendorPlantName = vendorplant.VendorPlantName;
                result.VendorID = vendorplant.VendorID;
                result.VendorPlantName = vendorplant.VendorPlantName;
                result.VendorPlantAddress = vendorplant.VendorPlantAddress;

                if (vendorplant.VendorPlantID != 0)
                {
                    result.VendorPlantID = vendorplant.VendorPlantID;
                }

                //else if (lead.Department != null)
                //{
                //    result.DepartmentId = employee.Department.DepartmentId;
                //}

                await _applicationDbContext.SaveChangesAsync();

                return result;
            }

            return null;
        }

    }
}
