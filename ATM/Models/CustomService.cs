//using ATM.Data;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.AspNetCore.Components;

//namespace ATM.Models
//{
//    public class CustomService
//    {


//        public readonly ApplicationDbContext _applicationDbContext;

//        public CustomService(ApplicationDbContext applicationDbContext)
//        {
//            _applicationDbContext = applicationDbContext;
//        }


//        public async Task<List<Custom>> GetMaterialDetails()
//        {
//            var result = await _applicationDbContext.Tbl_Material
//                .FromSqlRaw("select Tbl_Material.MaterialName, Tbl_MaterialSubCategory.MaterialSubCategoryName, Tbl_MaterialCategory.MaterialCategoryName, Tbl_MaterialType.MaterialTypeName from Tbl_Material, Tbl_MaterialSubCategory, Tbl_MaterialCategory, Tbl_MaterialType where Tbl_Material.MaterialCategoryID = Tbl_MaterialCategory.MaterialCategoryID and Tbl_Material.MaterialTypeID = Tbl_MaterialType.MaterialTypeID and Tbl_Material.MaterialSubCategoryID = Tbl_MaterialSubCategory.MaterialSubCategoryID").ToListAsync();

//            return result;
//        }

//    }
//}
