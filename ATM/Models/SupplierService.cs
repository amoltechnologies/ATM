using ATM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;

namespace ATM.Models
{
    public class SupplierService
    {

        public readonly ApplicationDbContext _applicationDbContext;

        public SupplierService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<Supplier>> GetSuppliers()
        {
            return await _applicationDbContext.Tbl_Supplier.ToListAsync();
        }

        public async Task<Supplier> AddSupplier(Supplier supplier)
        {
            if (supplier.SupplierName != null)
            {
                _applicationDbContext.Tbl_Supplier.Add(supplier);
            }

            var result = await _applicationDbContext.Tbl_Supplier.AddAsync(supplier);
            await _applicationDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteSupplier(int ID)
        {
            var result = await _applicationDbContext.Tbl_Supplier
                .FirstOrDefaultAsync(l => l.SupplierID == ID);

            if (result != null)
            {
                _applicationDbContext.Tbl_Supplier.Remove(result);
                await _applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task<Supplier> UpdateSupplier(Supplier supplier)
        {
            var result = await _applicationDbContext.Tbl_Supplier
                .FirstOrDefaultAsync(e => e.SupplierID == supplier.SupplierID);

            if (result != null)
            {
                result.SupplierName = supplier.SupplierName;
                result.Address = supplier.Address;
                result.City = supplier.City;
                result.State = supplier.State;
                result.PINCode = supplier.PINCode;
                result.PrimaryContactPersonName = supplier.PrimaryContactPersonName;
                result.PrimaryContactPersonContact = supplier.PrimaryContactPersonContact;
                result.GSTNo = supplier.GSTNo;
                result.PANNo = supplier.PANNo;
                result.OpeningBalance = supplier.OpeningBalance;

                if (supplier.SupplierID != 0)
                {
                    result.SupplierID = supplier.SupplierID;
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
