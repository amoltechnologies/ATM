using ATM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;

namespace ATM.Models
{
    public class ProductionOutService
    {
        public readonly ApplicationDbContext _applicationDbContext;

        public ProductionOutService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<ProductionOut>> GetProductionOut()
        {
            return await _applicationDbContext.Tbl_ProductionOut.ToListAsync();
        }

        public async Task<ProductionOut> AddProductionOut(ProductionOut productionout)
        {
            if (productionout.ProductionOutID != 0)
            {
                _applicationDbContext.Tbl_ProductionOut.Add(productionout);
            }

            var result = await _applicationDbContext.Tbl_ProductionOut.AddAsync(productionout);
            await _applicationDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteProductionOut(int ID)
        {
            var result = await _applicationDbContext.Tbl_ProductionOut
                .FirstOrDefaultAsync(l => l.ProductionOutID == ID);

            if (result != null)
            {
                _applicationDbContext.Tbl_ProductionOut.Remove(result);
                await _applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task<ProductionOut> UpdateProductionOut(ProductionOut productionout)
        {
            var result = await _applicationDbContext.Tbl_ProductionOut
                .FirstOrDefaultAsync(e => e.ProductionOutID == productionout.ProductionOutID);

            if (result != null)
            {
                result.OutQuantity = productionout.OutQuantity;
                result.IssuedTo = productionout.IssuedTo;
                result.MaterialID = productionout.MaterialID;

                if (productionout.ProductionOutID != 0)
                {
                    result.ProductionOutID = productionout.ProductionOutID;
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
