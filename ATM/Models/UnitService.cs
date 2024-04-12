using ATM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;

namespace ATM.Models
{
    public class UnitService
    {

        public readonly ApplicationDbContext _applicationDbContext;

        public UnitService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<Unit>> GetUnits()
        {
            return await _applicationDbContext.Tbl_Unit.ToListAsync();
        }

        public async Task<Unit> AddUnit(Unit unit)
        {
            if (unit.UnitName != null)
            {
                _applicationDbContext.Tbl_Unit.Add(unit);
            }

            var result = await _applicationDbContext.Tbl_Unit.AddAsync(unit);
            await _applicationDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteUnit(int ID)
        {
            var result = await _applicationDbContext.Tbl_Unit
                .FirstOrDefaultAsync(l => l.UnitID == ID);

            if (result != null)
            {
                _applicationDbContext.Tbl_Unit.Remove(result);
                await _applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task<Unit> UpdateUnit(Unit unit)
        {
            var result = await _applicationDbContext.Tbl_Unit
                .FirstOrDefaultAsync(e => e.UnitID == unit.UnitID);

            if (result != null)
            {
                result.UnitName = unit.UnitName;

                if (unit.UnitID != 0)
                {
                    result.UnitID = unit.UnitID;
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
