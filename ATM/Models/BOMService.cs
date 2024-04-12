using ATM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;

namespace ATM.Models
{
    public class BOMService
    {

        public readonly ApplicationDbContext _applicationDbContext;

        public BOMService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<BOM>> GetBOMs()
        {
            return await _applicationDbContext.Tbl_BOM.ToListAsync();
        }

        public async Task<BOM> AddBOM(BOM bom)
        {
            if (bom.BOMID != 0)
            {
                _applicationDbContext.Tbl_BOM.Add(bom);
            }

            var result = await _applicationDbContext.Tbl_BOM.AddAsync(bom);
            await _applicationDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteBOM(int ID)
        {
            var result = await _applicationDbContext.Tbl_BOM
                .FirstOrDefaultAsync(l => l.BOMID == ID);

            if (result != null)
            {
                _applicationDbContext.Tbl_BOM.Remove(result);
                await _applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task<BOM> UpdateBOM(BOM bom)
        {
            var result = await _applicationDbContext.Tbl_BOM
                .FirstOrDefaultAsync(e => e.BOMID == bom.BOMID);

            if (result != null)
            {
                result.ProcessPlanID = bom.ProcessPlanID;
                result.FinishedGoodsID = bom.FinishedGoodsID;
                result.MaterialID = bom.MaterialID;
                result.Quantity = bom.Quantity;

                if (bom.BOMID != 0)
                {
                    result.BOMID = bom.BOMID;
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
