using ATM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;

namespace ATM.Models
{
    public class ProductionInService
    {

        public readonly ApplicationDbContext _applicationDbContext;

        public ProductionInService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<ProductionIn>> GetProductionIn()
        {
            return await _applicationDbContext.Tbl_ProductionIn.ToListAsync();
        }

        public async Task<ProductionIn> AddProductionIn(ProductionIn productionin)
        {
            if (productionin.ProductionInID != 0)
            {
                _applicationDbContext.Tbl_ProductionIn.Add(productionin);
            }

            var result = await _applicationDbContext.Tbl_ProductionIn.AddAsync(productionin);
            await _applicationDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteQualityIn(int ID)
        {
            var result = await _applicationDbContext.Tbl_ProductionIn
                .FirstOrDefaultAsync(l => l.ProductionInID == ID);

            if (result != null)
            {
                _applicationDbContext.Tbl_ProductionIn.Remove(result);
                await _applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task<ProductionIn> UpdateQualityIn(ProductionIn productionin)
        {
            var result = await _applicationDbContext.Tbl_ProductionIn
                .FirstOrDefaultAsync(e => e.ProductionInID == productionin.ProductionInID);

            if (result != null)
            {
                result.MaterialID = productionin.MaterialID;
                result.InQuantity = productionin.InQuantity;
                result.ReceivedFrom = productionin.ReceivedFrom;
                result.ReceivedTransactionID = productionin.ReceivedTransactionID;

                if (productionin.ProductionInID != 0)
                {
                    result.ProductionInID = productionin.ProductionInID;
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
