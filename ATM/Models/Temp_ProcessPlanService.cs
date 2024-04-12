using ATM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;

namespace ATM.Models
{
    public class Temp_ProcessPlanService
    {
        public readonly ApplicationDbContext _applicationDbContext;

        public Temp_ProcessPlanService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<Temp_ProcessPlan>> GetTemp_ProcessPlan()
        {
            return await _applicationDbContext.Tbl_Temp_ProcessPlan.ToListAsync();
        }
       
        public async Task<Temp_ProcessPlan> AddTemp_ProcessPlan(Temp_ProcessPlan temp_ProcessPlan)
        {
            if (temp_ProcessPlan.ProcessName != null)
            {
                _applicationDbContext.Tbl_Temp_ProcessPlan.Add(temp_ProcessPlan);
            }

            var result = await _applicationDbContext.Tbl_Temp_ProcessPlan.AddAsync(temp_ProcessPlan);
            await _applicationDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteProcessPlan(int ID)
        {
            var result = await _applicationDbContext.Tbl_Temp_ProcessPlan
                .FirstOrDefaultAsync(l => l.ProcessPlanID == ID);

            if (result != null)
            {
                _applicationDbContext.Tbl_Temp_ProcessPlan.Remove(result);
                await _applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task<Temp_ProcessPlan> UpdateProcessPlan(Temp_ProcessPlan temp_ProcessPlan)
        {
            var result = await _applicationDbContext.Tbl_Temp_ProcessPlan
                .FirstOrDefaultAsync(e => e.ProcessPlanID == temp_ProcessPlan.ProcessPlanID);

            if (result != null)
            {
                result.ProcessName = temp_ProcessPlan.ProcessName;
                result.OutputName = temp_ProcessPlan.OutputName;
                result.OutputQuantity = temp_ProcessPlan.OutputQuantity;
                result.ProcessPlanDescription = temp_ProcessPlan.ProcessPlanDescription;
                result.ProcessScrapQuantity = temp_ProcessPlan.ProcessScrapQuantity;
                result.isQualityRequired = temp_ProcessPlan.isQualityRequired;
                result.isFinalProcess = temp_ProcessPlan.isFinalProcess;
                result.OutputUnit = temp_ProcessPlan.OutputUnit;
              

                if (temp_ProcessPlan.ProcessPlanID != 0)
                {
                    result.ProcessPlanID = temp_ProcessPlan.ProcessPlanID;
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
