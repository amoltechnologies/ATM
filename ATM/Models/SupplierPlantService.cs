using ATM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;

namespace ATM.Models
{
    public class SupplierPlantService
    {

        public readonly ApplicationDbContext _applicationDbContext;

        public SupplierPlantService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<SupplierPlant>> GetSupplierPlants()
        {
            return await _applicationDbContext.Tbl_SupplierPlant.ToListAsync();
        }

        public async Task<SupplierPlant> AddSupplierPlant(SupplierPlant supplierplant)
        {
            if (supplierplant.SupplierPlantName != null)
            {
                _applicationDbContext.Tbl_SupplierPlant.Add(supplierplant);
            }

            var result = await _applicationDbContext.Tbl_SupplierPlant.AddAsync(supplierplant);
            await _applicationDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteSupplierPlant(int ID)
        {
            var result = await _applicationDbContext.Tbl_SupplierPlant
                .FirstOrDefaultAsync(l => l.SupplierPlantID == ID);

            if (result != null)
            {
                _applicationDbContext.Tbl_SupplierPlant.Remove(result);
                await _applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task<SupplierPlant> UpdateSupplierPlant(SupplierPlant supplierplant)
        {
            var result = await _applicationDbContext.Tbl_SupplierPlant
                .FirstOrDefaultAsync(e => e.SupplierPlantID == supplierplant.SupplierPlantID);

            if (result != null)
            {
                result.SupplierPlantName = supplierplant.SupplierPlantName;
                result.SupplierID = supplierplant.SupplierID;
                result.SupplierPlantName = supplierplant.SupplierPlantName;
                result.SupplierPlantAddress = supplierplant.SupplierPlantAddress;

                if (supplierplant.SupplierPlantID != 0)
                {
                    result.SupplierPlantID = supplierplant.SupplierPlantID;
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
