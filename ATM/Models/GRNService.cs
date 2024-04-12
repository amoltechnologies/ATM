using ATM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;

namespace ATM.Models
{
    public class GRNService
    {
        public readonly ApplicationDbContext _applicationDbContext;

        public GRNService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<GRN>> GetGRNs()
        {
            //return await _applicationDbContext.Tbl_GRN.ToListAsync();
            return await _applicationDbContext.Tbl_GRN.ToListAsync();
        }

        public async Task<GRN> AddGRN(GRN grn)
        {
            if (grn.UserID != 0)
            {
                _applicationDbContext.Tbl_GRN.Add(grn);
            }

            var result = await _applicationDbContext.Tbl_GRN.AddAsync(grn);
            await _applicationDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteGRN(int ID)
        {
            var result = await _applicationDbContext.Tbl_GRN
                .FirstOrDefaultAsync(l => l.GRNID == ID);

            if (result != null)
            {
                _applicationDbContext.Tbl_GRN.Remove(result);
                await _applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task<GRN> UpdateGRN(GRN grn)
        {
            var result = await _applicationDbContext.Tbl_GRN
                .FirstOrDefaultAsync(e => e.GRNID == grn.GRNID);

            if (result != null)
            {
                result.SupplierID = grn.SupplierID;
                //result.DetailedPOID = grn.DetailedPOID;
                result.Date = grn.Date;
                //result.MaterialTypeID = grn.MaterialTypeID;
                //result.MaterialID = grn.MaterialID;
                //result.UnitName = grn.UnitName;
                //result.GRNQuantity = grn.GRNQuantity;
                result.UserID = grn.UserID;

                if (grn.GRNID != 0)
                {
                    result.GRNID = grn.GRNID;
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

        public async Task<string> GetPONumber(DateTime po_date)
        {

            //DateTime date = DateTime.Now;
            //po_date = Convert.ToDateTime("03-03-2022 14:06:12");
            string fyear = "";

            if (po_date.Month <= 3)
            {
                fyear = (po_date.Year - 1).ToString() + "-" + po_date.Year.ToString();
            }

            else
            {
                fyear = po_date.Year.ToString() + "-" + (po_date.Year + 1).ToString();
            }

            int pomaxx;

            pomaxx = (from M in _applicationDbContext.Tbl_GRN.ToList()
                      select M.MaterialID).DefaultIfEmpty(1).Max() + 1;

            string ponumber = pomaxx.ToString() + "/" + fyear;


            return ponumber;
        }




        public async Task<List<DetailedPurchaseOrder>> GetMaterialByTypeID(int ID, int ponumber)
        {

            var result = await _applicationDbContext.Tbl_DetailedPurchaseOrder.Where(x => x.MaterialTypeID == ID && x.PONumber == ponumber).ToListAsync();

            return result;
        }

    }
}
