using ATM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;
using ATM.Models;

namespace ATM.Models
{
    public class MaterialTypeService
    {

        public readonly ApplicationDbContext _applicationDbContext;

        public MaterialTypeService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<MaterialType>> GetMaterialTypes()
        {
            return await _applicationDbContext.Tbl_MaterialType.ToListAsync();
        }

        public async Task<MaterialType> AddMaterial(MaterialType material)
        {
            if (material.MaterialTypeName != null)
            {
                _applicationDbContext.Tbl_MaterialType.Add(material);
            }

            var result = await _applicationDbContext.Tbl_MaterialType.AddAsync(material);
            await _applicationDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteMaterial(int ID)
        {
            var result = await _applicationDbContext.Tbl_MaterialType
                .FirstOrDefaultAsync(l => l.MaterialTypeID == ID);

            if (result != null)
            {
                _applicationDbContext.Tbl_MaterialType.Remove(result);
                await _applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task<MaterialType> UpdateMaterial(MaterialType material)
        {
            var result = await _applicationDbContext.Tbl_MaterialType
                .FirstOrDefaultAsync(e => e.MaterialTypeID == material.MaterialTypeID);

            if (result != null)
            {
                result.MaterialTypeName = material.MaterialTypeName;

                if (material.MaterialTypeID != 0)
                {
                    result.MaterialTypeID = material.MaterialTypeID;
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
