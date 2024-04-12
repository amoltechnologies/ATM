using ATM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;

namespace ATM.Models
{
    public class DispatchInService
    {

        public readonly ApplicationDbContext _applicationDbContext;

        public DispatchInService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<DispatchIn>> GetDispatchIn()
        {
            return await _applicationDbContext.Tbl_DispatchIn.ToListAsync();
        }

        public async Task<DispatchIn> AddDispatchIn(DispatchIn dispatchin)
        {
            if (dispatchin.DispatchInID != 0)
            {
                _applicationDbContext.Tbl_DispatchIn.Add(dispatchin);
            }

            var result = await _applicationDbContext.Tbl_DispatchIn.AddAsync(dispatchin);
            await _applicationDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteDispatchIn(int ID)
        {
            var result = await _applicationDbContext.Tbl_DispatchIn
                .FirstOrDefaultAsync(l => l.DispatchInID == ID);

            if (result != null)
            {
                _applicationDbContext.Tbl_DispatchIn.Remove(result);
                await _applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task<DispatchIn> UpdateDispatchIn(DispatchIn dispatchin)
        {
            var result = await _applicationDbContext.Tbl_DispatchIn
                .FirstOrDefaultAsync(e => e.DispatchInID == dispatchin.DispatchInID);

            if (result != null)
            {
                result.TypeID = dispatchin.TypeID;
                result.MaterialID = dispatchin.MaterialID;
                result.InQuantity = dispatchin.InQuantity;
                result.ReceivedFrom = dispatchin.ReceivedFrom;
                result.ReceivedTransactionID = dispatchin.ReceivedTransactionID;

                if (dispatchin.DispatchInID != 0)
                {
                    result.DispatchInID = dispatchin.DispatchInID;
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
