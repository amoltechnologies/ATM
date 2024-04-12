using ATM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;

namespace ATM.Models
{
    public class StoreInService
    {

        public readonly ApplicationDbContext _applicationDbContext;

        public StoreInService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<StoreIn>> GetStoreIns()
        {
            return await _applicationDbContext.Tbl_StoreIn.ToListAsync();
        }

        public async Task<StoreIn> AddStoreIn(StoreIn storein)
        {
            if (storein.StoreInID != 0)
            {
                _applicationDbContext.Tbl_StoreIn.Add(storein);
            }

            var result = await _applicationDbContext.Tbl_StoreIn.AddAsync(storein);
            await _applicationDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteStoreIn(int ID)
        {
            var result = await _applicationDbContext.Tbl_StoreIn
                .FirstOrDefaultAsync(l => l.StoreInID == ID);

            if (result != null)
            {
                _applicationDbContext.Tbl_StoreIn.Remove(result);
                await _applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task<StoreIn> UpdateStoreIn(StoreIn storein)
        {
            var result = await _applicationDbContext.Tbl_StoreIn
                .FirstOrDefaultAsync(e => e.StoreInID == storein.StoreInID);

            if (result != null)
            {
                result.MaterialID = storein.MaterialID;
                result.InQuantity = storein.InQuantity;
                result.ReceivedFrom = storein.ReceivedFrom;
                result.ReceivedTransactionID = storein.ReceivedTransactionID;

                if (storein.StoreInID != 0)
                {
                    result.StoreInID = storein.StoreInID;
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
