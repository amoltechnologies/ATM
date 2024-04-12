using ATM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;

namespace ATM.Models
{
    public class ProcessPlanService
    {

        public readonly ApplicationDbContext _applicationDbContext;

        public ProcessPlanService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<ProcessPlan>> GetProcessPlans()
        {
            return await _applicationDbContext.Tbl_ProcessPlan.ToListAsync();
        }

        public async Task<ProcessPlan> AddProcessPlan(ProcessPlan processplan)
        {
            if (processplan.ProcessPlanName != null)
            {
                _applicationDbContext.Tbl_ProcessPlan.Add(processplan);
            }

            var result = await _applicationDbContext.Tbl_ProcessPlan.AddAsync(processplan);
            await _applicationDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteProcessPlan(int ID)
        {
            var result = await _applicationDbContext.Tbl_ProcessPlan
                .FirstOrDefaultAsync(l => l.ProcessPlanID == ID);

            if (result != null)
            {
                _applicationDbContext.Tbl_ProcessPlan.Remove(result);
                await _applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task<ProcessPlan> UpdateProcessPlan(ProcessPlan processplan)
        {
            var result = await _applicationDbContext.Tbl_ProcessPlan
                .FirstOrDefaultAsync(e => e.ProcessPlanID == processplan.ProcessPlanID);

            if (result != null)
            {
                result.ProcessPlanName = processplan.ProcessPlanName;
                result.FinishedGoodsID = processplan.FinishedGoodsID;
                result.ProcessPlanDescription = processplan.ProcessPlanDescription;
                result.OutputName = processplan.OutputName;
                result.IsFinalProcess = processplan.IsFinalProcess;
                result.ProcessOutputQuantity = processplan.ProcessOutputQuantity;
                result.ProcessOutputUnit = processplan.ProcessOutputUnit;
                result.ProcessScrapQuantity = processplan.ProcessScrapQuantity;

                if (processplan.ProcessPlanID != 0)
                {
                    result.ProcessPlanID = processplan.ProcessPlanID;
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
