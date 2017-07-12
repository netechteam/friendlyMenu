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

        public async Task AddDishIngredientArray(DishIngredientDM dishIngredientArray)
        {
            var dataModel = new tblDishIngredient
            {
                Id = dishIngredientArray.Id,
                DishId = dishIngredientArray.IngredientId,
                DishName = dishIngredientArray.DishName
            };

            _databaseContext.DishIngredient.Add(dataModel);

            _databaseContext.SaveChanges();
        }

    }
}
