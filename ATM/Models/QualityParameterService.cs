using ATM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;

namespace ATM.Models
{
    public class QualityParameterService
    {

        public readonly ApplicationDbContext _applicationDbContext;

        public QualityParameterService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<QualityParameter>> GetQualityParameters()
        {
            return await _applicationDbContext.Tbl_QualityParameter.ToListAsync();
        }

        public async Task<QualityParameter> AddQualityParameter(QualityParameter qualityparameter)
        {
            if (qualityparameter.QualityParameterName != null)
            {
                _applicationDbContext.Tbl_QualityParameter.Add(qualityparameter);
            }

            var result = await _applicationDbContext.Tbl_QualityParameter.AddAsync(qualityparameter);
            await _applicationDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteQualityParameter(int ID)
        {
            var result = await _applicationDbContext.Tbl_QualityParameter
                .FirstOrDefaultAsync(l => l.QualityParameterID == ID);

            if (result != null)
            {
                _applicationDbContext.Tbl_QualityParameter.Remove(result);
                await _applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task<QualityParameter> UpdateQualityParameter(QualityParameter qualityparameter)
        {
            var result = await _applicationDbContext.Tbl_QualityParameter
                .FirstOrDefaultAsync(e => e.QualityParameterID == qualityparameter.QualityParameterID);

            if (result != null)
            {
                result.QualityParameterName = qualityparameter.QualityParameterName;
                result.ProcessPlanID = qualityparameter.ProcessPlanID;
                result.OperationName = qualityparameter.OperationName;
                result.Value = qualityparameter.Value;
                //result.UnitID = qualityparameter.UnitID;

                if (qualityparameter.QualityParameterID != 0)
                {
                    result.QualityParameterID = qualityparameter.QualityParameterID;
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
