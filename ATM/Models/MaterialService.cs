using ATM.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Components;
using ATM.Models;

namespace ATM.Models
{
    public class MaterialService
    {

        public readonly ApplicationDbContext _applicationDbContext;

        public MaterialService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<List<Material>> GetMaterials()
        {
            return await _applicationDbContext.Tbl_Material.ToListAsync();
        }

        //public async Task<List<Material>> GetCustomTypeID()
        //{
        //    var result = await _applicationDbContext.Tbl_Material.Join(_applicationDbContext.Tbl_MaterialType, material => material.MaterialTypeID,
        //                                                      type => type.MaterialTypeID,
        //                                                      (material, type) => new
        //                                                      {
        //                                                          MaterialTypeID = type.MaterialTypeID,
        //                                                          MaterialTypeName = type.MaterialTypeName
        //                                                      }).ToListAsync();
        //    return result;

        //    //return await _applicationDbContext.Tbl_Material.Select(x => x.MaterialTypeID).Distinct().ToListAsync();
        //    //return await _applicationDbContext.Tbl_Material.FromSqlRaw("select distinct(MaterialTypeName), Tbl_Material.MaterialTypeID from Tbl_Material join Tbl_MaterialType on Tbl_MaterialType.MaterialTypeID = Tbl_Material.MaterialTypeID").ToListAsync();

        //}

        public async Task<bool> GetQualityParameters(int id)
        {

            var parameter = await _applicationDbContext.Tbl_Material
                .Where(x => x.MaterialID == id)
                .Select(x => x.IsQualityRequire)
                .FirstOrDefaultAsync();

            return parameter;
        }

        public async Task<List<Material>> GetMaterialByTypeID(string ID)
        {
            var id = Convert.ToInt32(ID);

            var result = await _applicationDbContext.Tbl_Material.Where(x => x.MaterialTypeID == id).ToListAsync();

            return result;
        }

        public async Task<List<Material>> GetMaterialDetails(string ID)
        {
            var id = Convert.ToInt32(ID);

            var result = await _applicationDbContext.Tbl_Material.Where(x => x.MaterialID == id).ToListAsync();

            return result;
        }


        public async Task<Material> AddMaterial(Material material)
        {
            if (material.MaterialName != null)
            {
                _applicationDbContext.Tbl_Material.Add(material);
            }

            var result = await _applicationDbContext.Tbl_Material.AddAsync(material);
            await _applicationDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteMaterial(int ID)
        {
            var result = await _applicationDbContext.Tbl_Material
                .FirstOrDefaultAsync(l => l.MaterialID == ID);

            if (result != null)
            {
                _applicationDbContext.Tbl_Material.Remove(result);
                await _applicationDbContext.SaveChangesAsync();
            }
        }

        public async Task<Material> UpdateMaterial(Material material)
        {
            var result = await _applicationDbContext.Tbl_Material
                .FirstOrDefaultAsync(e => e.MaterialID == material.MaterialID);

            if (result != null)
            {
                result.MaterialName = material.MaterialName;
                result.MaterialTypeID = material.MaterialTypeID;
                result.MaterialCategoryID = material.MaterialCategoryID;
                result.MaterialSubCategoryID = material.MaterialSubCategoryID;
                result.MaterialName = material.MaterialName;
                result.MaterialDescription = material.MaterialDescription;
                result.MaterialHSNCode = material.MaterialHSNCode;
                result.MaterialGSTPercent = material.MaterialGSTPercent;
                result.MaterialOpeningQuantity = material.MaterialOpeningQuantity;
                result.MaterialBufferLevelQuantity = material.MaterialBufferLevelQuantity;
                result.IsQualityRequire = material.IsQualityRequire;
                result.MaterialAvailableQuantity = material.MaterialAvailableQuantity;
                //result.UnitID = material.UnitID;

                if (material.MaterialID != 0)
                {
                    result.MaterialID = material.MaterialID;
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


        //public async Task<List<Material>> GetMaterialDetails()
        //{
        //    var result = await _applicationDbContext.Tbl_Material
        //        .FromSqlRaw("select Tbl_Material.MaterialName, Tbl_MaterialSubCategory.MaterialSubCategoryName, Tbl_MaterialCategory.MaterialCategoryName, Tbl_MaterialType.MaterialTypeName from Tbl_Material, Tbl_MaterialSubCategory, Tbl_MaterialCategory, Tbl_MaterialType where Tbl_Material.MaterialCategoryID = Tbl_MaterialCategory.MaterialCategoryID and Tbl_Material.MaterialTypeID = Tbl_MaterialType.MaterialTypeID and Tbl_Material.MaterialSubCategoryID = Tbl_MaterialSubCategory.MaterialSubCategoryID").ToListAsync();

        //    return result;
        //}

    }


}
