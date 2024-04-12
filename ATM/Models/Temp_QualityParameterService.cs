using ATM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;

namespace ATM.Models
{
    public class Temp_QualityParameterService
    {
        public readonly ApplicationDbContext _applicationDbContext;

        public Temp_QualityParameterService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<Temp_QualityParameter>> GetTemp_QualityParameter()
        {


            return await _applicationDbContext.Tbl_Temp_QualityParameter.ToListAsync();
        }

        public async Task<Temp_QualityParameter> AddTemp_QualityParameter(Temp_QualityParameter temp_qualityparameter)
        {
            if (temp_qualityparameter.QualityParameterName != null)
            {
               

                _applicationDbContext.Tbl_Temp_QualityParameter.Add(temp_qualityparameter);
            }

            var result = await _applicationDbContext.Tbl_Temp_QualityParameter.AddAsync(temp_qualityparameter);
            await _applicationDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteQualityParameter(int ID)
        {
            var result = await _applicationDbContext.Tbl_Temp_QualityParameter
                .FirstOrDefaultAsync(l => l.QualityParameterID == ID);

            if (result != null)
            {
                _applicationDbContext.Tbl_Temp_QualityParameter.Remove(result);
                await _applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task<Temp_QualityParameter> UpdateQualityParameter(Temp_QualityParameter temp_qualityparameter)
        {
            var result = await _applicationDbContext.Tbl_Temp_QualityParameter
                .FirstOrDefaultAsync(e => e.QualityParameterID == temp_qualityparameter.QualityParameterID);

            if (result != null)
            {
                result.QualityParameterName = temp_qualityparameter.QualityParameterName;
                result.UnitName = temp_qualityparameter.UnitName;
                result.OperatorName = temp_qualityparameter.OperatorName;
                result.Value = temp_qualityparameter.Value;
              


                if (temp_qualityparameter.QualityParameterID != 0)
                {
                    result.QualityParameterID = temp_qualityparameter.QualityParameterID;
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
