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
        public async Task<DishIngredientDM> GetDishIngredients(int restaurantId)
        {
            var dishIngredient = await _databaseContext.DishIngredient.FirstOrDefaultAsync(x => x.Id == restaurantId);

            return BuildDishIngredientDM(dishIngredient);
        }

        private DishIngredientDM BuildDishIngredientDM(tblDishIngredient dishIngredient)
        {
            if (dishIngredient == null)
                return null;

            return new DishIngredientDM
            {
                Id = dishIngredient.Id,
                DishId = dishIngredient.DishId,
                IngredientId = dishIngredient.IngredientId
            };
        }
    }
}
