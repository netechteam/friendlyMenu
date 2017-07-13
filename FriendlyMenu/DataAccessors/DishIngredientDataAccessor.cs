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

            var dish = _databaseContext.DishIngredient.FirstOrDefault(x => x.Id == id);

            var dataModel = new DishIngredientDM();
            if (dish != null)
            {
                dataModel.Id = dish.Id;
                dataModel.DishName = dish.DishName;
                dataModel.IngredientId = dish.IngredientId.ToList();
            }

            return dataModel;

        }

        
        public async Task AddDishIngredientArray(DishIngredientDM dishIngredientArray)
        {
            var dataModel = new tblDishIngredient
            {
                Id = dishIngredientArray.Id,
                IngredientId = dishIngredientArray.IngredientId.ToArray(),
                DishName = dishIngredientArray.DishName
            };

            _databaseContext.DishIngredient.Add(dataModel);

            _databaseContext.SaveChanges();
        }

    }
}
