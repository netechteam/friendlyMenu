using System;
using System.Linq;
using System.Threading.Tasks;
using DataModels;
using DbModels;
using Entities;
using Interfaces.DataAccessors;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Extensions;
using Remotion.Linq.Clauses;

namespace DataAccessors
{
    public class RestaurantDataAccessor : IRestaurantDataAccessor
    {
        private readonly DatabaseContext _context;

        public RestaurantDataAccessor(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<CategoryDishesDM> GetDishesByCategory(int categoryId, int restaurantId)
        {
            // get category
            var getCategoryTask = (from cat in _context.tblcategories where cat.ixCategoryId == categoryId select cat).FirstAsync();

            // get dishes
            var getDishesTask = (from dish in _context.tblDishes
                                .Include(x => x.dishIngredients).ThenInclude(x => x.tblIngredient)
                                .Include(x => x.dishImages)
                                where dish.ixCategoryId == categoryId && dish.restaurantId == restaurantId
                                select dish).ToListAsync();

            var category = await getCategoryTask;
            if (category == null)
                throw new InvalidOperationException("Invalid categoryId: " + categoryId);

            var dishes = await getDishesTask;
            var dishSummaries = dishes.EmptyIfNull().Select(GetDishSummaryDM).ToList();
           
            return new CategoryDishesDM
            {
                CategoryId = category.ixCategoryId,
                CategoryName = category.sCategoryName,
                DishSummaries = dishSummaries
            };
        }

        private static DishSummaryDM GetDishSummaryDM(tblDish dish)
        {
            if (dish == null)
                return null;

            var imageUrl = dish.dishImages.EmptyIfNull().Any() ? dish.dishImages.First().ImageLocation : null;

            return new DishSummaryDM
            {
                DishId = dish.ixDish,
                DishName = dish.DishName,
                Description = dish.Description,
                //CategoryId = dish.ixCategoryId,
                IsBreakfast = dish.IsBreakfast,
                IsCombo = dish.IsCombo,
                IsLunch = dish.IsLunch,
                IsSpicy = dish.IsSpicy,
                BreakfastPrice = dish.PriceBreakfast,
                ComboPrice = dish.PriceCombo,
                DinnerPrice = dish.PriceDinner,
                LunchPrice = dish.PriceLunch,
                Ingredients = dish.dishIngredients.Select(x => new IngredientDM
                {
                    IngredientId = x.tblIngredient.ixIngredient,
                    IngredientName = x.tblIngredient.sIngredientName
                }).ToList(),
                ImageUrl = imageUrl
            };
        }

    public Task<HomePageDM> GetHomePageDm(int restaurantId)
    {
      throw new NotImplementedException();
    }


    //public async Task<CategoryDishesDM> GetDishesByCategory(int categoryId, int restaurantId)
    //{
    //    var allDBDishes = _context.tblDishes.Where(x => x.restaurantId == restaurantId && x.ixCategoryId == categoryId).Select(y => new DishSummaryDM
    //    {
    //        DishId = y.ixDish,
    //        RestaurantId = y.restaurantId,
    //        DishName = y.DishName,
    //        Description = y.Description,
    //        CategoryId = y.ixCategoryId,
    //        IsBreakfast = y.IsBreakfast,
    //        IsCombo = y.IsCombo,
    //        IsLunch = y.IsLunch,
    //        IsSpicy = y.IsSpicy,
    //        BreakfastPrice = y.PriceBreakfast,
    //        ComboPrice = y.PriceCombo,
    //        DinnerPrice = y.PriceDinner,
    //        LunchPrice = y.PriceLunch,
    //        Ingredients = (from di in _context.tblDishIngredients
    //                       join i in _context.tblIngredients on di.ixIngredient equals i.ixIngredient
    //                       where di.ixDish == y.ixDish
    //                       select new IngredientDM
    //                       {
    //                           IngredientId = di.ixIngredient,
    //                           IngredientName = i.sIngredientName
    //                       }).ToList(), 
    //        ImageUrl = (from image in _context.DishImage
    //                      join d in _context.tblDishes on image.ixdish equals d.ixDish
    //                      where  image.ixdish == y.ixDish select image.ImageLocation).FirstOrDefault()
    //    }).ToList();

    //    var categoryName = (from x in _context.tblcategories where x.ixCategoryId == categoryId select x.sCategoryName).First();
    //    var categoryDishes = new CategoryDishesDM
    //    {
    //        CategoryName = categoryName,
    //        DishSummaries = allDBDishes

    //    };
    //    return categoryDishes;
    //}

  }
}
