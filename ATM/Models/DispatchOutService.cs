using ATM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;

namespace ATM.Models
{
    public class DispatchOutService
    {
        public readonly ApplicationDbContext _applicationDbContext;

        public DispatchOutService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<DispatchOut>> GetDispatchOut()
        {
            return await _applicationDbContext.Tbl_DispatchOut.ToListAsync();
        }

        public async Task<DispatchOut> AddDispatchOut(DispatchOut dispatchout)
        {
            if (dispatchout.DispatchOutID != 0)
            {
                _applicationDbContext.Tbl_DispatchOut.Add(dispatchout);
            }

            var result = await _applicationDbContext.Tbl_DispatchOut.AddAsync(dispatchout);
            await _applicationDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteDispatchOut(int ID)
        {
            var result = await _applicationDbContext.Tbl_DispatchOut
                .FirstOrDefaultAsync(l => l.DispatchOutID == ID);

            if (result != null)
            {
                _applicationDbContext.Tbl_DispatchOut.Remove(result);
                await _applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task<DispatchOut> UpdateDispatchOut(DispatchOut dispatchout)
        {
            var result = await _applicationDbContext.Tbl_DispatchOut
                .FirstOrDefaultAsync(e => e.DispatchOutID == dispatchout.DispatchOutID);

            if (result != null)
            {
                result.OutQuantity = dispatchout.OutQuantity;
                result.IssuedTo = dispatchout.IssuedTo;
                result.MaterialID = dispatchout.MaterialID;
                result.TypeID = dispatchout.TypeID;

                if (dispatchout.DispatchOutID != 0)
                {
                    result.DispatchOutID = dispatchout.DispatchOutID;
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
