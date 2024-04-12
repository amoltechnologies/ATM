using ATM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;

namespace ATM.Models
{
    public class MaterialCategoryService
    {

        public readonly ApplicationDbContext _applicationDbContext;

        public MaterialCategoryService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<MaterialCategory>> GetMaterialCategories()
        {
            return await _applicationDbContext.Tbl_MaterialCategory.ToListAsync();
        }



        public async Task<MaterialCategory> AddMaterialCategory(MaterialCategory materialcategory)
        {
            if (materialcategory.MaterialCategoryName != null)
            {
                _applicationDbContext.Tbl_MaterialCategory.Add(materialcategory);
            }

            var result = await _applicationDbContext.Tbl_MaterialCategory.AddAsync(materialcategory);
            await _applicationDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteMaterialCategory(int ID)
        {
            var result = await _applicationDbContext.Tbl_MaterialCategory
                .FirstOrDefaultAsync(l => l.MaterialCategoryID == ID);

            if (result != null)
            {
                _applicationDbContext.Tbl_MaterialCategory.Remove(result);
                await _applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task<MaterialCategory> UpdateMaterialCategory(MaterialCategory materialcategory)
        {
            var result = await _applicationDbContext.Tbl_MaterialCategory
                .FirstOrDefaultAsync(e => e.MaterialCategoryID == materialcategory.MaterialCategoryID);

            if (result != null)
            {
                result.MaterialCategoryName = materialcategory.MaterialCategoryName;
                result.MaterialTypeID = materialcategory.MaterialTypeID;


                if (materialcategory.MaterialCategoryID != 0)
                {
                    result.MaterialCategoryID = materialcategory.MaterialCategoryID;
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

        public async Task<List<MaterialCategory>> GetMaterialCategoryByTypeID(int id)
        {
            var result = await _applicationDbContext.Tbl_MaterialCategory.Where(x => x.MaterialTypeID == id).ToListAsync();
            return result;
        }

    }
}
