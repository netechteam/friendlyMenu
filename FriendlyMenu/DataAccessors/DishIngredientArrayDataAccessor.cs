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
    public class DishIngredientDataArrayAccessor : IDishIngredientDataArrayAccessor
    {

        private readonly DatabaseContext _databaseContext;

        public DishIngredientDataArrayAccessor(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task AddDishIngredientArray(DishIngredientArrayDM dishIngredientArray)
        {
            var dataModel = new tblDishIngredientArray
            {
                Id = dishIngredientArray.Id,
                DishId = dishIngredientArray.IngredientId,
                DishName = dishIngredientArray.DishName
            };

            _databaseContext.DishIngredientArray.Add(dataModel);

            _databaseContext.SaveChanges();
        }

    }
}
