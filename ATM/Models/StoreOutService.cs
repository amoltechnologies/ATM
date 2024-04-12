using ATM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;

namespace ATM.Models
{
    public class StoreOutService
    {

        public readonly ApplicationDbContext _applicationDbContext;

        public StoreOutService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<StoreOut>> GetStoreOuts()
        {
            return await _applicationDbContext.Tbl_StoreOut.ToListAsync();
        }

        public async Task<StoreOut> AddStoreOut(StoreOut storeout)
        {
            if (storeout.StoreOutID != 0)
            {
                _applicationDbContext.Tbl_StoreOut.Add(storeout);
            }

            var result = await _applicationDbContext.Tbl_StoreOut.AddAsync(storeout);
            await _applicationDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteStoreOut(int ID)
        {
            var result = await _applicationDbContext.Tbl_StoreOut
                .FirstOrDefaultAsync(l => l.StoreOutID == ID);

            if (result != null)
            {
                _applicationDbContext.Tbl_StoreOut.Remove(result);
                await _applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task<StoreOut> UpdateStoreOut(StoreOut storeout)
        {
            var result = await _applicationDbContext.Tbl_StoreOut
                .FirstOrDefaultAsync(e => e.StoreOutID == storeout.StoreOutID);

            if (result != null)
            {
                result.MaterialID = storeout.MaterialID;
                result.OutQuantity = storeout.OutQuantity;
                result.IssuedTo = storeout.IssuedTo;

                if (storeout.StoreOutID != 0)
                {
                    result.StoreOutID = storeout.StoreOutID;
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
