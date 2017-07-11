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

            return BuildDishDM(dish);
        }

        private DishDM BuildDishDM(tbldish dish)
        {
            if (dish == null)
                return null;

            return new DishDM
            {
                Id = dish.Id,
                RestaurantId = dish.RestaurantId,
                MenuCategoryId = dish.MenuCategoryId,
                Description = dish.Description,
                Price = dish.Price
                
            };
        }
    }
}
