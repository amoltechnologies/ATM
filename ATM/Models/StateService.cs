using ATM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;

namespace ATM.Models
{
    public class StateService
    {

        public readonly ApplicationDbContext _applicationDbContext;

        public StateService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<State>> GetStates()
        {
            return await _applicationDbContext.Tbl_State.ToListAsync();
        }

        public async Task<State> AddState(State state)
        {
            if (state.StateName != null)
            {
                _applicationDbContext.Tbl_State.Add(state);
            }

            var result = await _applicationDbContext.Tbl_State.AddAsync(state);
            await _applicationDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteState(int ID)
        {
            var result = await _applicationDbContext.Tbl_State
                .FirstOrDefaultAsync(l => l.StateID == ID);

            if (result != null)
            {
                _applicationDbContext.Tbl_State.Remove(result);
                await _applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task<State> UpdateState(State state)
        {
            var result = await _applicationDbContext.Tbl_State
                .FirstOrDefaultAsync(e => e.StateID == state.StateID);

            if (result != null)
            {
                result.StateName = state.StateName;
                result.StateGSTCode = state.StateGSTCode;

                if (state.StateID != 0)
                {
                    result.StateID = state.StateID;
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
