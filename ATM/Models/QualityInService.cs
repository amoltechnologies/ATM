using ATM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;

namespace ATM.Models
{
    public class QualityInService
    {

        public readonly ApplicationDbContext _applicationDbContext;

        public QualityInService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<QualityIn>> GetQualityIn()
        {
            return await _applicationDbContext.Tbl_QualityIn.ToListAsync();
        }

        public async Task<QualityIn> AddQualityIn(QualityIn qualityin)
        {
            if (qualityin.QualityInID != 0)
            {
                _applicationDbContext.Tbl_QualityIn.Add(qualityin);
            }

            var result = await _applicationDbContext.Tbl_QualityIn.AddAsync(qualityin);
            await _applicationDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteQualityIn(int ID)
        {
            var result = await _applicationDbContext.Tbl_QualityIn
                .FirstOrDefaultAsync(l => l.QualityInID == ID);

            if (result != null)
            {
                _applicationDbContext.Tbl_QualityIn.Remove(result);
                await _applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task<QualityIn> UpdateQualityIn(QualityIn qualityin)
        {
            var result = await _applicationDbContext.Tbl_QualityIn
                .FirstOrDefaultAsync(e => e.QualityInID == qualityin.QualityInID);

            if (result != null)
            {
                result.MaterialID = qualityin.MaterialID;
                result.InQuantity = qualityin.InQuantity;
                result.ReceivedFrom = qualityin.ReceivedFrom;
                result.ReceivedTransactionID = qualityin.ReceivedTransactionID;

                if (qualityin.QualityInID != 0)
                {
                    result.QualityInID = qualityin.QualityInID;
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
