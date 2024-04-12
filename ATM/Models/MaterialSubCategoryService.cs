using ATM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;

namespace ATM.Models
{
    public class MaterialSubCategoryService
    {

        public readonly ApplicationDbContext _applicationDbContext;

        public MaterialSubCategoryService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<MaterialSubCategory>> GetMaterialSubCategories()
        {
            return await _applicationDbContext.Tbl_MaterialSubCategory.ToListAsync();
        }

        public async Task<MaterialSubCategory> AddMaterialSubCategory(MaterialSubCategory subcategory)
        {
            if (subcategory.MaterialSubCategoryName != null)
            {
                _applicationDbContext.Tbl_MaterialSubCategory.Add(subcategory);
            }

            var result = await _applicationDbContext.Tbl_MaterialSubCategory.AddAsync(subcategory);
            await _applicationDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteMaterialSubCategory(int ID)
        {
            var result = await _applicationDbContext.Tbl_MaterialSubCategory
                .FirstOrDefaultAsync(l => l.MaterialSubCategoryID == ID);

            if (result != null)
            {
                _applicationDbContext.Tbl_MaterialSubCategory.Remove(result);
                await _applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task<MaterialSubCategory> UpdateMaterialSubCategory(MaterialSubCategory materialsubcategory)
        {
            var result = await _applicationDbContext.Tbl_MaterialSubCategory
                .FirstOrDefaultAsync(e => e.MaterialSubCategoryID == materialsubcategory.MaterialSubCategoryID);

            if (result != null)
            {
                result.MaterialSubCategoryName = materialsubcategory.MaterialSubCategoryName;
                result.MaterialCategoryID = materialsubcategory.MaterialCategoryID;

                if (materialsubcategory.MaterialSubCategoryID != 0)
                {
                    result.MaterialSubCategoryID = materialsubcategory.MaterialSubCategoryID;
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

        public async Task<List<MaterialSubCategory>> GetMaterialSubCategoryByCategoryID(int id)
        {
            var result = await _applicationDbContext.Tbl_MaterialSubCategory.Where(x => x.MaterialCategoryID == id).ToListAsync();
            return result;
        }

    }
}
