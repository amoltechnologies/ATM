using ATM.Data;
using Microsoft.EntityFrameworkCore;

namespace ATM.Models
{
    public class SalesOrderService
    {

        public readonly ApplicationDbContext _applicationDbContext;

        public SalesOrderService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }


        /// <summary>
        /// For Sales Orders
        /// </summary>
        /// <returns></returns>


        public async Task<List<SalesOrder>> GetSalesOrders()
        {

            return await _applicationDbContext.Tbl_SalesOrder.ToListAsync();
        }


        public async Task<SalesOrder> AddSalesOrder(SalesOrder salesorder)
        {
            if (salesorder.SalesOrderNumber != 0)
            {
                _applicationDbContext.Tbl_SalesOrder.Add(salesorder);
            }

            var result = await _applicationDbContext.Tbl_SalesOrder.AddAsync(salesorder);
            await _applicationDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteSalesOrder(int ID)
        {
            var result = await _applicationDbContext.Tbl_SalesOrder
                .FirstOrDefaultAsync(l => l.SalesOrderNumber == ID);

            if (result != null)
            {
                _applicationDbContext.Tbl_SalesOrder.Remove(result);
                await _applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task<SalesOrder> UpdateSalesOrder(SalesOrder salesorder)
        {
            var result = await _applicationDbContext.Tbl_SalesOrder
                .FirstOrDefaultAsync(e => e.SalesOrderNumber == salesorder.SalesOrderNumber);

            if (result != null)
            {
                result.CustomerID = salesorder.CustomerID;
                result.DateOfSalesOrder = salesorder.DateOfSalesOrder;
                result.TotalGSTAmount = salesorder.TotalGSTAmount;
                result.TotalAmount = salesorder.TotalAmount;
                result.UserId = salesorder.UserId;
                result.CreatedBy = salesorder.CreatedBy;
                result.CreationTime = salesorder.CreationTime;
                result.ModifiedBy = salesorder.ModifiedBy;
                result.ModificationTime = salesorder.ModificationTime;
                

                if (salesorder.SalesOrderNumber != 0)
                {
                    result.SalesOrderNumber = salesorder.SalesOrderNumber;
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


        ///////////////////////////////////////////////////////////////////////////////////////
        /// <summary>                                                                       ///
        /// For Temperory Sales Orders                                                   ///
        /// </summary>                                                                      ///
        ///////////////////////////////////////////////////////////////////////////////////////


        public async Task<List<TemperorySalesOrder>> GetTemperorySalesOrder()
        {
            return await _applicationDbContext.Tbl_TemperorySalesOrder.ToListAsync();

        }

        public async Task<TemperorySalesOrder> AddTemperorySalesOrder(TemperorySalesOrder temperorysalesorder)
        {
            if (temperorysalesorder.FG_Name != null)
            {
                _applicationDbContext.Tbl_TemperorySalesOrder.Add(temperorysalesorder);
            }


            var result = await _applicationDbContext.Tbl_TemperorySalesOrder.AddAsync(temperorysalesorder);
            await _applicationDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteTemperorySalesOrder(int ID)
        {
            var result = await _applicationDbContext.Tbl_TemperorySalesOrder
                .FirstOrDefaultAsync(l => l.SrNo == ID);

            if (result != null)
            {
                _applicationDbContext.Tbl_TemperorySalesOrder.Remove(result);
                await _applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task<TemperorySalesOrder> UpdateTemperorySalesOrder(TemperorySalesOrder tempsalesorder)
        {
            var result = await _applicationDbContext.Tbl_TemperorySalesOrder
                .FirstOrDefaultAsync(e => e.SrNo == tempsalesorder.SrNo);

            if (result != null)
            {
                result.FinishedGoodsID = tempsalesorder.FinishedGoodsID;
                result.FG_Name = tempsalesorder.FG_Name;
                result.Fyear = tempsalesorder.Fyear;
                result.Description = tempsalesorder.Description;
                result.HSNCode = tempsalesorder.HSNCode;
                result.BaseAmount = tempsalesorder.BaseAmount;
                result.Quantity = tempsalesorder.Quantity;
                //result.Amount = tempsalesorder.Amount;
                result.UnitName = tempsalesorder.UnitName;
                result.DiscountPercent = tempsalesorder.DiscountPercent;
                result.SGSTPercent = tempsalesorder.SGSTPercent;
                result.SGSTAmount = tempsalesorder.SGSTAmount;
                result.CGSTPercent = tempsalesorder.CGSTPercent;
                result.CGSTAmount = tempsalesorder.CGSTAmount;
                result.IGSTPercent = tempsalesorder.IGSTPercent;
                //result.IGSTAmount = tempsalesorder.IGSTAmount;
                //result.SubTotal = tempsalesorder.SubTotal;
                result.UserId = tempsalesorder.UserId;

                // calculated amounts:

                var AmountAfterDiscount = tempsalesorder.BaseAmount * tempsalesorder.Quantity - tempsalesorder.BaseAmount * tempsalesorder.Quantity * tempsalesorder.DiscountPercent / 100; ;
                var GSTAmount = AmountAfterDiscount * tempsalesorder.IGSTPercent * 100;

                result.Amount = tempsalesorder.BaseAmount * tempsalesorder.Quantity;
                result.IGSTAmount = GSTAmount;
                result.SubTotal = AmountAfterDiscount + GSTAmount;

                if (tempsalesorder.SrNo != 0)
                {
                    result.SrNo = tempsalesorder.SrNo;
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



        public async Task<string> GetSalesOrderNumber(DateTime salesorder_date)
        {

            //DateTime date = DateTime.Now;
            //salesorder_date = Convert.ToDateTime("03-03-2022 14:06:12");
            string fyear = "";

            if (salesorder_date.Month <= 3)
            {
                fyear = (salesorder_date.Year - 1).ToString() + "-" + salesorder_date.Year.ToString();
            }

            else
            {
                fyear = salesorder_date.Year.ToString() + "-" + (salesorder_date.Year + 1).ToString();
            }

            var somaxx = 1;

            somaxx = (from M in _applicationDbContext.Tbl_SalesOrder.ToList()
                      select M.SalesOrderNumber).DefaultIfEmpty(1).Max() + 1;

            string sonumber = somaxx.ToString() + "/" + fyear;

            return sonumber;

        }


        public async Task<string> GetFYear(DateTime salesorder_date)
        {

            string fyear;

            if (salesorder_date.Month <= 3)
            {
                fyear = (salesorder_date.Year - 1).ToString() + "-" + salesorder_date.Year.ToString();
            }

            else
            {
                fyear = salesorder_date.Year.ToString() + "-" + (salesorder_date.Year + 1).ToString();
            }

            return fyear;
        }


        ///////////////////////////////////////////////////////////////////////////////////////
        /// <summary>                                                                       ///
        /// For Detailed Sales Orders                                                       ///
        /// </summary>                                                                      ///
        ///////////////////////////////////////////////////////////////////////////////////////

        public async Task<List<DetailedSalesOrder>> GetDetailedSalesOrder()
        {
            return await _applicationDbContext.Tbl_DetailedSalesOrder.ToListAsync();
        }

        public async Task<DetailedSalesOrder> AddDetailedSalesOrder(DetailedSalesOrder detailedsalesorder)
        {
            if (detailedsalesorder.FG_Name != null)
            {
                _applicationDbContext.Tbl_DetailedSalesOrder.Add(detailedsalesorder);
            }

            var result = await _applicationDbContext.Tbl_DetailedSalesOrder.AddAsync(detailedsalesorder);
            await _applicationDbContext.SaveChangesAsync();
            return result.Entity;


        }

        public async Task DeleteDetailedSalesOrder(int ID)
        {
            var result = await _applicationDbContext.Tbl_DetailedSalesOrder
                .FirstOrDefaultAsync(l => l.DetailedSalesOrderID == ID);

            if (result != null)
            {
                _applicationDbContext.Tbl_DetailedSalesOrder.Remove(result);
                await _applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task<DetailedSalesOrder> UpdateDetailedSalesOrder(DetailedSalesOrder detailedsalesorder)
        {
            var result = await _applicationDbContext.Tbl_DetailedSalesOrder
                .FirstOrDefaultAsync(e => e.DetailedSalesOrderID == detailedsalesorder.DetailedSalesOrderID);

            if (result != null)
            {
                result.SalesOrderNumber = detailedsalesorder.SalesOrderNumber;
                result.SrNo = detailedsalesorder.SrNo;
                result.FinishedGoodsID = detailedsalesorder.FinishedGoodsID;
                result.FG_Name = detailedsalesorder.FG_Name;
                result.Fyear = detailedsalesorder.Fyear;
                result.HSNCode = detailedsalesorder.HSNCode;
                result.BaseAmount = detailedsalesorder.BaseAmount;
                result.Quantity = detailedsalesorder.Quantity;
                result.GRNQuantity = detailedsalesorder.GRNQuantity;
                result.Amount = detailedsalesorder.Amount;
                result.UnitName = detailedsalesorder.UnitName;
                result.DiscountPercent = detailedsalesorder.DiscountPercent;
                result.SGSTPercent = detailedsalesorder.SGSTPercent;
                result.SGSTAmount = detailedsalesorder.SGSTAmount;
                result.CGSTPercent = detailedsalesorder.CGSTPercent;
                result.CGSTAmount = detailedsalesorder.CGSTAmount;
                result.IGSTPercent = detailedsalesorder.IGSTPercent;
                result.IGSTAmount = detailedsalesorder.IGSTAmount;
                result.SubTotal = detailedsalesorder.SubTotal;
                result.UserId = detailedsalesorder.UserId;

                if (detailedsalesorder.DetailedSalesOrderID != 0)
                {
                    result.DetailedSalesOrderID = detailedsalesorder.DetailedSalesOrderID;
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
