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
    public class IngredientTypeDataAccessor : IIngredientTypeDataAccessor
    {
        private readonly DatabaseContext _databaseContext;

        public IngredientTypeDataAccessor(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<IngredientTypeDM> GetIngredientType(int ingredientID)
        {
            var ingredientType = await _databaseContext.IngredientType.FirstOrDefaultAsync(x => x.Id == ingredientID);

            return BuildIngredientTypeDM(ingredientType);

        }

        private IngredientTypeDM BuildIngredientTypeDM(tblIngredienttype ingredientType)
        {
            if (ingredientType == null)
                return null;
            return new IngredientTypeDM
            {
                Id = ingredientType.Id,
                TypeName = ingredientType.IngredientTypeName
            };
        }

    }
}
