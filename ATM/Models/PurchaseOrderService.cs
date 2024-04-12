using ATM.Data;
using Microsoft.EntityFrameworkCore;

namespace ATM.Models
{
    public class PurchaseOrderService
    {

        public readonly ApplicationDbContext _applicationDbContext;

        public PurchaseOrderService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }


        /// <summary>
        /// For Purchase Orders
        /// </summary>
        /// <returns></returns>


        public async Task<List<PurchaseOrder>> GetPurchaseOrders()
        {

            return await _applicationDbContext.Tbl_PurchaseOrder.ToListAsync();
        }


        public async Task<List<PurchaseOrder>> GetPOBySupplier(int ID)
        {

            var result = await _applicationDbContext.Tbl_PurchaseOrder.Where(x => x.SupplierID == ID).ToListAsync();

            return result;
        }



        //public async Task<List<string>> GetPONumbers()
        //{

        //    List<PurchaseOrder> PurchaseOrders;
        //    PurchaseOrders = await _applicationDbContext.Tbl_PurchaseOrder.ToListAsync();

        //    string fyear = "";
        //    string ponumber = "";
        //    DateTime po_date = DateTime.Now;

        //    foreach (var po in PurchaseOrders)
        //    {
        //        fyear = po.Fyear;
        //        var pomax = po.PONumber;
        //        ponumber = pomax.ToString() + "/" + fyear;
        //    }


        //    return ponumber;

        //}


        public async Task<PurchaseOrder> AddPurchaseOrder(PurchaseOrder purchaseorder)
        {
            if (purchaseorder.PONumber != 0)
            {
                _applicationDbContext.Tbl_PurchaseOrder.Add(purchaseorder);
            }

            var result = await _applicationDbContext.Tbl_PurchaseOrder.AddAsync(purchaseorder);
            await _applicationDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeletePurchaseOrder(int ID)
        {
            var result = await _applicationDbContext.Tbl_PurchaseOrder
                .FirstOrDefaultAsync(l => l.PONumber == ID);

            if (result != null)
            {
                _applicationDbContext.Tbl_PurchaseOrder.Remove(result);
                await _applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task<PurchaseOrder> UpdatePurchaseOrder(PurchaseOrder purchaseorder)
        {
            var result = await _applicationDbContext.Tbl_PurchaseOrder
                .FirstOrDefaultAsync(e => e.PONumber == purchaseorder.PONumber);

            if (result != null)
            {
                result.SupplierID = purchaseorder.SupplierID;
                result.TotalAmount = purchaseorder.TotalAmount;
                result.DateOfPO = purchaseorder.DateOfPO;
                result.KindAttention = purchaseorder.KindAttention;
                result.Delivery = purchaseorder.Delivery;
                result.Payment = purchaseorder.Payment;
                result.PandF = purchaseorder.PandF;
                result.TransportationAmount = purchaseorder.TransportationAmount;
                result.Insurance = purchaseorder.Insurance;
                result.DispatchedThrough = purchaseorder.DispatchedThrough;
                result.QuotationNo = purchaseorder.QuotationNo;
                result.DateOfQuotation = purchaseorder.DateOfQuotation;

                if (purchaseorder.PONumber != 0)
                {
                    result.PONumber = purchaseorder.PONumber;
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
        /// For Temperory Purchase Orders                                                   ///
        /// </summary>                                                                      ///
        ///////////////////////////////////////////////////////////////////////////////////////


        public async Task<List<TemperoryPurchaseOrder>> GetTemperoryPO()
        {
            return await _applicationDbContext.Tbl_TemperoryPurchaseOrder.ToListAsync();

        }

        public async Task<TemperoryPurchaseOrder> AddTemperoryPO(TemperoryPurchaseOrder temperorypurchaseorder)
        {
            if (temperorypurchaseorder.MaterialName != null)
            {
                _applicationDbContext.Tbl_TemperoryPurchaseOrder.Add(temperorypurchaseorder);
            }


            var result = await _applicationDbContext.Tbl_TemperoryPurchaseOrder.AddAsync(temperorypurchaseorder);
            await _applicationDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteTemperoryPO(int ID)
        {
            var result = await _applicationDbContext.Tbl_TemperoryPurchaseOrder
                .FirstOrDefaultAsync(l => l.SrNo == ID);

            if (result != null)
            {
                _applicationDbContext.Tbl_TemperoryPurchaseOrder.Remove(result);
                await _applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task<TemperoryPurchaseOrder> UpdateTemperoryPO(TemperoryPurchaseOrder tempPO)
        {
            var result = await _applicationDbContext.Tbl_TemperoryPurchaseOrder
                .FirstOrDefaultAsync(e => e.SrNo == tempPO.SrNo);

            if (result != null)
            {
                result.MaterialID = tempPO.MaterialID;
                result.MaterialName = tempPO.MaterialName;
                result.Fyear = tempPO.Fyear;
                result.Description = tempPO.Description;
                result.HSNCode = tempPO.HSNCode;
                result.BaseAmount = tempPO.BaseAmount;
                result.Quantity = tempPO.Quantity;
                //result.Amount = tempPO.Amount;
                result.UnitName = tempPO.UnitName;
                result.DiscountPercent = tempPO.DiscountPercent;
                result.SGSTPercent = tempPO.SGSTPercent;
                result.SGSTAmount = tempPO.SGSTAmount;
                result.CGSTPercent = tempPO.CGSTPercent;
                result.CGSTAmount = tempPO.CGSTAmount;
                result.IGSTPercent = tempPO.IGSTPercent;
                //result.IGSTAmount = tempPO.IGSTAmount;
                //result.SubTotal = tempPO.SubTotal;
                result.UserId = tempPO.UserId;

                // calculated amounts:

                var AmountAfterDiscount = tempPO.BaseAmount * tempPO.Quantity - tempPO.BaseAmount * tempPO.Quantity * tempPO.DiscountPercent / 100; ;
                var GSTAmount = AmountAfterDiscount * tempPO.IGSTPercent * 100;

                result.Amount = tempPO.BaseAmount * tempPO.Quantity;
                result.IGSTAmount = GSTAmount;
                result.SubTotal = AmountAfterDiscount + GSTAmount;

                if (tempPO.SrNo != 0)
                {
                    result.SrNo = tempPO.SrNo;
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

            var pomaxx = 1;

            pomaxx = (from M in _applicationDbContext.Tbl_PurchaseOrder.ToList()
                      select M.PONumber).DefaultIfEmpty(1).Max() + 1;

            string ponumber = pomaxx.ToString() + "/" + fyear;

            return ponumber;
        }


        public async Task<string> GetFYear(DateTime po_date)
        {

            string fyear;

            if (po_date.Month <= 3)
            {
                fyear = (po_date.Year - 1).ToString() + "-" + po_date.Year.ToString();
            }

            else
            {
                fyear = po_date.Year.ToString() + "-" + (po_date.Year + 1).ToString();
            }

            return fyear;
        }


        ///////////////////////////////////////////////////////////////////////////////////////
        /// <summary>                                                                       ///
        /// For Detailed Purchase Orders                                                    ///
        /// </summary>                                                                      ///
        ///////////////////////////////////////////////////////////////////////////////////////

        public async Task<List<DetailedPurchaseOrder>> GetDetailedPO()
        {
            return await _applicationDbContext.Tbl_DetailedPurchaseOrder.ToListAsync();
        }

        public async Task<DetailedPurchaseOrder> AddDetailedPO(DetailedPurchaseOrder detailedpurchaseorder)
        {
            if (detailedpurchaseorder.MaterialName != null)
            {
                _applicationDbContext.Tbl_DetailedPurchaseOrder.Add(detailedpurchaseorder);
            }

            var result = await _applicationDbContext.Tbl_DetailedPurchaseOrder.AddAsync(detailedpurchaseorder);
            await _applicationDbContext.SaveChangesAsync();
            return result.Entity;


        }

        public async Task DeleteDetailedPO(int ID)
        {
            var result = await _applicationDbContext.Tbl_DetailedPurchaseOrder
                .FirstOrDefaultAsync(l => l.DetailedPOID == ID);

            if (result != null)
            {
                _applicationDbContext.Tbl_DetailedPurchaseOrder.Remove(result);
                await _applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task<DetailedPurchaseOrder> UpdateDetailedPO(DetailedPurchaseOrder detailedpurchaseorder)
        {
            var result = await _applicationDbContext.Tbl_DetailedPurchaseOrder
                .FirstOrDefaultAsync(e => e.DetailedPOID == detailedpurchaseorder.DetailedPOID);

            if (result != null)
            {
                result.PONumber = detailedpurchaseorder.PONumber;
                result.SrNo = detailedpurchaseorder.SrNo;
                result.MaterialID = detailedpurchaseorder.MaterialID;
                result.MaterialName = detailedpurchaseorder.MaterialName;
                result.Fyear = detailedpurchaseorder.Fyear;
                result.HSNCode = detailedpurchaseorder.HSNCode;
                result.BaseAmount = detailedpurchaseorder.BaseAmount;
                result.Quantity = detailedpurchaseorder.Quantity;
                result.GRNQuantity = detailedpurchaseorder.GRNQuantity;
                result.Amount = detailedpurchaseorder.Amount;
                result.UnitName = detailedpurchaseorder.UnitName;
                result.DiscountPercent = detailedpurchaseorder.DiscountPercent;
                result.SGSTPercent = detailedpurchaseorder.SGSTPercent;
                result.SGSTAmount = detailedpurchaseorder.SGSTAmount;
                result.CGSTPercent = detailedpurchaseorder.CGSTPercent;
                result.CGSTAmount = detailedpurchaseorder.CGSTAmount;
                result.IGSTPercent = detailedpurchaseorder.IGSTPercent;
                result.IGSTAmount = detailedpurchaseorder.IGSTAmount;
                result.SubTotal = detailedpurchaseorder.SubTotal;
                result.UserId = detailedpurchaseorder.UserId;

                if (detailedpurchaseorder.DetailedPOID != 0)
                {
                    result.DetailedPOID = detailedpurchaseorder.DetailedPOID;
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

        public async Task<int> GetMaterialID(int ponumber, int detailedpoid)
        {
            //var materialid = Convert.ToInt32(_applicationDbContext.Tbl_DetailedPurchaseOrder
            //    .Where(x => x.DetailedPOID == detailedpoid && x.PONumber == ponumber)
            //    .Select(x => x.MaterialID).FirstOrDefaultAsync());

            var materialid = await _applicationDbContext.Tbl_DetailedPurchaseOrder
                .Where(x => x.DetailedPOID == detailedpoid)
                .Where(x => x.PONumber == ponumber)
                .Select(x => x.MaterialID)
                .FirstOrDefaultAsync();

            return Convert.ToInt32(materialid);
        }

        public async Task<int> GetMaterialTypeID(int ponumber, int detailedpoid)
        {
            var materialtypeid = await _applicationDbContext.Tbl_DetailedPurchaseOrder
                .Where(x => x.DetailedPOID == detailedpoid)
                .Where(x => x.PONumber == ponumber)
                .Select(x => x.MaterialTypeID).FirstOrDefaultAsync();

            return Convert.ToInt32(materialtypeid);
        }


        public async Task<List<DetailedPurchaseOrder>> GetDetailsByID(int ID)
        {

            var result = await _applicationDbContext.Tbl_DetailedPurchaseOrder.Where(x => x.PONumber == ID).ToListAsync();

            return result;
        }

        public async Task<DetailedPurchaseOrder> UpdatePOQuantity(DetailedPurchaseOrder detailedpurchaseorder)
        {
            var result = await _applicationDbContext.Tbl_DetailedPurchaseOrder
                .FirstOrDefaultAsync(e => e.DetailedPOID == detailedpurchaseorder.DetailedPOID);


            var qty = result.GRNQuantity + detailedpurchaseorder.GRNQuantity;

            if (qty <= detailedpurchaseorder.Quantity)
            {
                result.GRNQuantity = qty;
            }

            result.PONumber = detailedpurchaseorder.PONumber;
            result.SrNo = detailedpurchaseorder.SrNo;
            result.MaterialID = detailedpurchaseorder.MaterialID;
            result.MaterialName = detailedpurchaseorder.MaterialName;
            result.Fyear = detailedpurchaseorder.Fyear;
            result.HSNCode = detailedpurchaseorder.HSNCode;
            result.BaseAmount = detailedpurchaseorder.BaseAmount;
            result.Quantity = detailedpurchaseorder.Quantity;
            result.Amount = detailedpurchaseorder.Amount;
            result.UnitName = detailedpurchaseorder.UnitName;
            result.DiscountPercent = detailedpurchaseorder.DiscountPercent;
            result.SGSTPercent = detailedpurchaseorder.SGSTPercent;
            result.SGSTAmount = detailedpurchaseorder.SGSTAmount;
            result.CGSTPercent = detailedpurchaseorder.CGSTPercent;
            result.CGSTAmount = detailedpurchaseorder.CGSTAmount;
            result.IGSTPercent = detailedpurchaseorder.IGSTPercent;
            result.IGSTAmount = detailedpurchaseorder.IGSTAmount;
            result.SubTotal = detailedpurchaseorder.SubTotal;
            result.UserId = detailedpurchaseorder.UserId;

            if (detailedpurchaseorder.DetailedPOID != 0)
            {
                result.DetailedPOID = detailedpurchaseorder.DetailedPOID;
            }


            await _applicationDbContext.SaveChangesAsync();

            return result;
        }

    }

}
