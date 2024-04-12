using ATM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;

namespace ATM.Models
{
    public class VendorService
    {

        public readonly ApplicationDbContext _applicationDbContext;

        public VendorService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<Vendor>> GetVendors()
        {
            return await _applicationDbContext.Tbl_Vendor.ToListAsync();
        }

        public async Task<Vendor> AddVendor(Vendor vendor)
        {
            if (vendor.VendorName != null)
            {
                _applicationDbContext.Tbl_Vendor.Add(vendor);
            }

            var result = await _applicationDbContext.Tbl_Vendor.AddAsync(vendor);
            await _applicationDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteVendor(int ID)
        {
            var result = await _applicationDbContext.Tbl_Vendor
                .FirstOrDefaultAsync(l => l.VendorID == ID);

            if (result != null)
            {
                _applicationDbContext.Tbl_Vendor.Remove(result);
                await _applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task<Vendor> UpdateVendor(Vendor vendor)
        {
            var result = await _applicationDbContext.Tbl_Vendor
                .FirstOrDefaultAsync(e => e.VendorID == vendor.VendorID);

            if (result != null)
            {
                result.VendorName = vendor.VendorName;
                result.Address = vendor.Address;
                result.City = vendor.City;
                result.State = vendor.State;
                result.PINCode = vendor.PINCode;
                result.PrimaryContactPersonName = vendor.PrimaryContactPersonName;
                result.PrimaryContactPersonContact = vendor.PrimaryContactPersonContact;
                result.GSTNo = vendor.GSTNo;
                result.PANNo = vendor.PANNo;
                result.OpeningBalance = vendor.OpeningBalance;

                if (vendor.VendorID != 0)
                {
                    result.VendorID = vendor.VendorID;
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
