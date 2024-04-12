using ATM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;

namespace ATM.Models
{
    public class QualityOutService
    {
        public readonly ApplicationDbContext _applicationDbContext;

        public QualityOutService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<QualityOut>> GetQualityOut()
        {
            return await _applicationDbContext.Tbl_QualityOut.ToListAsync();
        }

        public async Task<QualityOut> AddQualityOut(QualityOut qualityout)
        {
            if (qualityout.QualityOutID != 0)
            {
                _applicationDbContext.Tbl_QualityOut.Add(qualityout);
            }

            var result = await _applicationDbContext.Tbl_QualityOut.AddAsync(qualityout);
            await _applicationDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteQualityOut(int ID)
        {
            var result = await _applicationDbContext.Tbl_QualityOut
                .FirstOrDefaultAsync(l => l.QualityOutID == ID);

            if (result != null)
            {
                _applicationDbContext.Tbl_QualityOut.Remove(result);
                await _applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task<QualityOut> UpdateQualityOut(QualityOut qualityout)
        {
            var result = await _applicationDbContext.Tbl_QualityOut
                .FirstOrDefaultAsync(e => e.QualityOutID == qualityout.QualityOutID);

            if (result != null)
            {
                result.OutQuantity = qualityout.OutQuantity;
                result.IssuedTo = qualityout.IssuedTo;
                result.MaterialID = qualityout.MaterialID;

                if (qualityout.QualityOutID != 0)
                {
                    result.QualityOutID = qualityout.QualityOutID;
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
