using ATM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;

namespace ATM.Models
{
    public class FinishedGoodsService
    {

        public readonly ApplicationDbContext _applicationDbContext;

        public FinishedGoodsService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<FinishedGoods>> GetFinishedGoods()
        {
            return await _applicationDbContext.Tbl_FinishedGoods.ToListAsync();
        }

        public async Task<FinishedGoods> AddFinishedGoods(FinishedGoods finishedgoods)
        {
            if (finishedgoods.InternalFG_Name != null)
            {
                _applicationDbContext.Tbl_FinishedGoods.Add(finishedgoods);
            }

            var result = await _applicationDbContext.Tbl_FinishedGoods.AddAsync(finishedgoods);
            await _applicationDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteFinishedGoods(int ID)
        {
            var result = await _applicationDbContext.Tbl_FinishedGoods
                .FirstOrDefaultAsync(l => l.FinishedGoodsID == ID);

            if (result != null)
            {
                _applicationDbContext.Tbl_FinishedGoods.Remove(result);
                await _applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task<FinishedGoods> UpdateFinishedGoods(FinishedGoods finishedgoods)
        {
            var result = await _applicationDbContext.Tbl_FinishedGoods
                .FirstOrDefaultAsync(e => e.FinishedGoodsID == finishedgoods.FinishedGoodsID);

            if (result != null)
            {
                result.InternalFG_Name = finishedgoods.InternalFG_Name;
                result.HSNCode = finishedgoods.HSNCode;
                result.GSTPercent = finishedgoods.GSTPercent;
                result.Description = finishedgoods.Description;
                result.PerUnitPrice = finishedgoods.PerUnitPrice;
                result.InternalDrawing = finishedgoods.InternalDrawing;
                result.CustomerDrawing = finishedgoods.CustomerDrawing;
                result.UnitName = finishedgoods.UnitName;

                if (finishedgoods.FinishedGoodsID != 0)
                {
                    result.FinishedGoodsID = finishedgoods.FinishedGoodsID;
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
