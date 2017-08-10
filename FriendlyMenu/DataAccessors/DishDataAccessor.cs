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
    public class DishDataAccessor : IDishDataAccessor
    {

        private readonly DatabaseContext _databaseContext;

        public DishDataAccessor(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public async Task<DishDM> GetDish(int restaurantId)
        {
            var dish = await _databaseContext.Dish.FirstOrDefaultAsync(x => x.Id == restaurantId);
            
            return BuildAddressDM(dish);
        }

        private DishDM BuildAddressDM(tblDish dish)
        {
            if (dish == null)
                return null;

            return new DishDM
            {
                Id = dish.Id,
                RestaurantId = dish.RestaurantId,
                MenuCategoryId = dish.MenuCategoryId,
                DishName = dish.DishName,
                Description = dish.Description,
                PriceLunch = dish.PriceLunch,
                PriceDinner = dish.PriceDinner,
                PriceCombo = dish.PriceCombo,
                IsCombo = dish.IsCombo,
                IsLunch = dish.IsLunch,
                IsSpicy = dish.IsSpicy
            };
        }
     
    }
}
