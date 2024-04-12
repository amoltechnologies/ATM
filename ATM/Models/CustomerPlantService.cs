using ATM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;

namespace ATM.Models
{
    public class CustomerPlantService
    {

        public readonly ApplicationDbContext _applicationDbContext;

        public CustomerPlantService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<CustomerPlant>> GetCustomerPlants()
        {
            return await _applicationDbContext.Tbl_CustomerPlant.ToListAsync();
        }

        public async Task<CustomerPlant> AddCustomerPlant(CustomerPlant customerplant)
        {
            if (customerplant.CustomerPlantName != null)
            {
                _applicationDbContext.Tbl_CustomerPlant.Add(customerplant);
            }

            var result = await _applicationDbContext.Tbl_CustomerPlant.AddAsync(customerplant);
            await _applicationDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteCustomerPlant(int ID)
        {
            var result = await _applicationDbContext.Tbl_CustomerPlant
                .FirstOrDefaultAsync(l => l.CustomerPlantID == ID);

            if (result != null)
            {
                _applicationDbContext.Tbl_CustomerPlant.Remove(result);
                await _applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task<CustomerPlant> UpdateCustomerPlant(CustomerPlant customerplant)
        {
            var result = await _applicationDbContext.Tbl_CustomerPlant
                .FirstOrDefaultAsync(e => e.CustomerPlantID == customerplant.CustomerPlantID);

            if (result != null)
            {
                result.CustomerPlantName = customerplant.CustomerPlantName;
                result.CustomerID = customerplant.CustomerID;
                result.CustomerPlantName = customerplant.CustomerPlantName;
                result.CustomerPlantAddress = customerplant.CustomerPlantAddress;
                result.VendorCode = customerplant.VendorCode;

                if (customerplant.CustomerPlantID != 0)
                {
                    result.CustomerPlantID = customerplant.CustomerPlantID;
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
