using ATM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;

namespace ATM.Models
{
    public class MachineService
    {

        public readonly ApplicationDbContext _applicationDbContext;

        public MachineService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<Machine>> GetMachines()
        {
            return await _applicationDbContext.Tbl_Machine.ToListAsync();
        }

        public async Task<Machine> AddMachine(Machine machine)
        {
            if (machine.MachineName != null)
            {
                _applicationDbContext.Tbl_Machine.Add(machine);
            }

            var result = await _applicationDbContext.Tbl_Machine.AddAsync(machine);
            await _applicationDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteMachine(int ID)
        {
            var result = await _applicationDbContext.Tbl_Machine
                .FirstOrDefaultAsync(l => l.MachineID == ID);

            if (result != null)
            {
                _applicationDbContext.Tbl_Machine.Remove(result);
                await _applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task<Machine> UpdateMachine(Machine machine)
        {
            var result = await _applicationDbContext.Tbl_Machine
                .FirstOrDefaultAsync(e => e.MachineID == machine.MachineID);

            if (result != null)
            {
                result.MachineName = machine.MachineName;
                result.Make = machine.Make;
                result.Company = machine.Company;

                if (machine.MachineID != 0)
                {
                    result.MachineID = machine.MachineID;
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
