using System;
using System.Linq;
using System.Threading.Tasks;
using DataModels;
using DbModels;
using Entities;
using Interfaces.DataAccessors;
using Microsoft.EntityFrameworkCore;

namespace DataAccessors
{
    public class DishIngredientDataAccessor : IDishIngredientDataAccessor
    {

        private readonly DatabaseContext _databaseContext;

        public DishIngredientDataAccessor(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<DishIngredientDM> GetDishIngredient(int id)
        {
            //var dishIngredient = await _databaseContext.DishIngredient.FirstOrDefaultAsync(x => x.Id == id);
            //return BuildDishIngredientDM(dishIngredient);
            return null;
        }

        private DishIngredientDM BuildDishIngredientDM(tblDishIngredients dishIngredient)
        {
            //if (dishIngredient == null)
            //    return null;
            //return new DishIngredientDM
            //{
            //    Id = dishIngredient.Id,
            //    RestaurantId = dishIngredient.RestaurantId,
            //    DishName = dishIngredient.DishName,
            //    IngredientId = dishIngredient.IngredientId
            //};

        }

        public async Task AddDishIngredientArray(DishIngredientDM dishIngredientArray)
        {
            //var dataModel = new tblDishIngredient
            //{
            //    Id = dishIngredientArray.Id,
            //    IngredientId = dishIngredientArray.IngredientId.ToArray(),
            //    DishName = dishIngredientArray.DishName
            //};

            //_databaseContext.DishIngredient.Add(dataModel);

            _databaseContext.SaveChanges();
        }

    }
}
