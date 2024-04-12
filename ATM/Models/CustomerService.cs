using ATM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;

namespace ATM.Models
{
    public class CustomerService
    { 

        public readonly ApplicationDbContext _applicationDbContext;

        public CustomerService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<Customer>> GetCustomers()
        {
            return await _applicationDbContext.Tbl_Customer.ToListAsync();
        }

        public async Task<Customer> AddCustomer(Customer customer)
        {
            if (customer.CustomerName != null)
            {
                _applicationDbContext.Tbl_Customer.Add(customer);
            }

            var result = await _applicationDbContext.Tbl_Customer.AddAsync(customer);
            await _applicationDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteCustomer(int ID)
        {
            var result = await _applicationDbContext.Tbl_Customer
                .FirstOrDefaultAsync(l => l.CustomerID == ID);

            if (result != null)
            {
                _applicationDbContext.Tbl_Customer.Remove(result);
                await _applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task<Customer> UpdateCustomer(Customer customer)
        {
            var result = await _applicationDbContext.Tbl_Customer
                .FirstOrDefaultAsync(e => e.CustomerID == customer.CustomerID);

            if (result != null)
            {
                result.CustomerName = customer.CustomerName;
                result.Address = customer.Address;
                result.City = customer.City;
                result.State = customer.State;
                result.PINCode = customer.PINCode;
                result.PrimaryContactPersonName = customer.PrimaryContactPersonName;
                result.PrimaryContactPersonContact = customer.PrimaryContactPersonContact;
                result.GSTNo = customer.GSTNo;           
                result.PANNo = customer.PANNo;
                result.OpeningBalance = customer.OpeningBalance;
                result.EmailID = customer.EmailID;

                if (customer.CustomerID != 0)
                {
                    result.CustomerID = customer.CustomerID;
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
