using Entities;
using Interfaces.DataAccessors;
using System;
using System.Collections.Generic;
using System.Text;
using DataModels;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DbModels;

namespace DataAccessors
{
    public class IngredientDataAccessor : IIngredientDataAccessor
    {
        private readonly DatabaseContext _databaseContext;

        public IngredientDataAccessor(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<IngredientDM> GetIngredient(int ingredientID)
        {
            var ingredient = await _databaseContext.Ingredient.FirstOrDefaultAsync(x => x.Id == ingredientID);

            return BuildIngredientDM(ingredient);

        }

        private IngredientDM BuildIngredientDM(tblIngredient ingredient)
        {
            if (ingredient == null)
                return null;
            return new IngredientDM
            {
                Id = ingredient.Id,
                IngredientName = ingredient.IngredientName,
                IngredientTypeId = ingredient.IngredientTypeId
            };
        }
    }
}
